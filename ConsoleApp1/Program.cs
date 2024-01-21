using System;
using System.IO;
using System.Net.Sockets;
using System.Threading;

class TcpClientThread
{
    private TcpClient tcpClient;
    private StreamReader reader;
    private StreamWriter writer;

    private string ServerIP = "127.0.0.1";
    private int ServerPort = 11445;

    public void Connect()
    {
        try
        {
            tcpClient = new TcpClient();
            tcpClient.Connect(ServerIP, ServerPort);

            Stream stream = tcpClient.GetStream();
            reader = new StreamReader(stream);
            writer = new StreamWriter(stream) { AutoFlush = true };

            Thread receiveThread = new Thread(Receive);
            receiveThread.Start();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error connecting to server: {ex.Message}");
        }
    }

    private void Receive()
    {
        try
        {
            while (true)
            {
                string message = reader.ReadLine();
                Console.WriteLine(message);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error receiving message: {ex.Message}");
        }
    }

    public void Send(string message)
    {
        try
        {
            writer.WriteLine(message);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error sending message: {ex.Message}");
        }
    }

    static void Main(string[] args)
    {
        TcpClientThread client = new TcpClientThread();
        client.Connect();

        while (true)
        {
            Console.Write("Enter message: ");
            string message = Console.ReadLine();
            client.Send(message);
        }
    }
}
