import socket
import threading
from http.server import SimpleHTTPRequestHandler, HTTPServer

class NoLogRequestHandler(SimpleHTTPRequestHandler):
    def log_message(self, format, *args):
        pass

class MyRequestHandler(NoLogRequestHandler):
    def do_GET(self):
        if self.path == '/':
            self.send_response(200)
            self.send_header('Content-type', 'text/html')
            self.end_headers()
            message = "<h1>When you see this page, the NoteChat service is running normally<h1>"
            self.wfile.write(message.encode('utf-8'))
        else:
            super().do_GET()

class ChatServer:
    def __init__(self, host, port):
        self.host = host
        self.port = port
        self.clients = {}
        self.server_socket = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
        self.server_socket.bind((host, port))
        self.server_socket.listen(5)
        self.lock = threading.Lock()

        self.input_thread = threading.Thread(target=self.handle_server_input)
        self.input_thread.start()

        self.http_server_thread = threading.Thread(target=self.start_http_server)
        self.http_server_thread.start()

    def handle_server_input(self):
        while True:
            command = input("Enter broadcast: ")
            with self.lock:
                if command.lower() == "exit":
                    self.shutdown()
                else:
                    self.broadcast("[Broadcast]" + command)
                    print("[Broadcast]" + command)

    def start_http_server(self):
        http_server = HTTPServer(('127.0.0.1', 11444), MyRequestHandler)
        http_server.serve_forever()
        print("HTTP 服务器已启动，访问 http://127.0.0.1:11444 查看服务运行状态。")

    def shutdown(self):
        print("Server is shutting down...")
        self.broadcast("Server Closed.")
        for client_socket, _ in list(self.clients.items()):
            client_socket.close()
        self.server_socket.close()
        exit()

    def handle_client(self, client_socket, username):
        self.broadcast(f"{username} joined the chat.")

        while True:
            try:
                message = client_socket.recv(1024).decode("utf-8")
                if message:
                    if message.startswith("Command:"):
                        self.handle_command(client_socket, username, message[len("Command:"):])
                    else:
                        print(f"{username} says: {message}")
                        self.broadcast(f"{username} says: {message}")
            except ConnectionResetError:
                print(f"{username} Disconnected.")
                self.broadcast(f"{username} Disconnected.")
                with self.lock:
                    if client_socket.fileno() != -1:
                        del self.clients[client_socket]
                break

    def handle_command(self, client_socket, username, command):
        if command.startswith("onlinelist"):
            online_users = [user for user in self.clients.values()]
            response = f"List:{online_users}"
            self.send_message(response, client_socket)
        elif command.lower() == "exit":
            self.shutdown()
        else:
            pass

    def broadcast(self, message):
        for client_socket, _ in list(self.clients.items()):
            try:
                if client_socket.fileno() == -1:
                    continue
                client_socket.send((message + "\n").encode("utf-8"))
            except Exception as e:
                print(f"Error broadcasting: {e}")
                with self.lock:
                    if client_socket.fileno() != -1:
                        client_socket.close()
                    del self.clients[client_socket]

    def send_message(self, message, client_socket):
        try:
            client_socket.send((message + "\n").encode("utf-8"))
        except Exception as e:
            print(f"Error sending message to {client_socket}: {e}")
            with self.lock:
                if client_socket.fileno() != -1:
                    client_socket.close()
                del self.clients[client_socket]

    def start(self):
        print(f"Server listening on {self.host}:{self.port}")

        while True:
            client_socket, addr = self.server_socket.accept()

            client_socket.send(b"Auth:What is your name?")
            auth_response = client_socket.recv(1024).decode("utf-8")
            if auth_response.startswith("Auth:"):
                username = auth_response.split(":")[1]
                with self.lock:
                    self.clients[client_socket] = username
                print(f"{username} connected from {addr}.")
                self.broadcast(f"{username} joined the chat.")

                welcome_message = "Welcome to the chat, {}!".format(username)
                self.send_message(welcome_message, client_socket)

                client_handler = threading.Thread(target=self.handle_client, args=(client_socket, username))
                client_handler.start()

if __name__ == "__main__":
    server = ChatServer("127.0.0.1", 11445)
    server.start()
