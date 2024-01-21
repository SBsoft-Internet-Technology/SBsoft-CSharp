using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteChat_Client.Helper
{
    public class ConfigHelper
    {
        public static void CreateDefaultConfig()
        {
            // 构建配置文件的完整路径
            string directory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "NoteChat-Client");
            string filePath = Path.Combine(directory, "Config.ini");

            try
            {
                // 如果目录不存在，则创建目录
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }
                if(!File.Exists(filePath))
                {
                    // 创建默认的配置文件内容
                    string defaultConfigContent = "[Connection]" + Environment.NewLine +
                                                  "LastServer=" + Environment.NewLine +
                                                  "LastServerPort=11445" + Environment.NewLine +
                                                  "LastSecret=" + Environment.NewLine +
                                                  "LastUsername=";

                    // 将默认配置内容写入文件
                    File.WriteAllText(filePath, defaultConfigContent);

                    Console.WriteLine("默认的 Config.ini 文件已创建。");
                }
                else{
                    Console.WriteLine("默认的 Config.ini 已存在，不创建。");
                }
                
            }
            catch (Exception ex)
            {
                TipHelper.ShowWarning($"创建默认的 Config.ini 文件时出错：{ex.Message}");
            }
        }
        public static void SaveConfig(string configItem, string configName, string content)
        {
            // 构建配置文件的完整路径
            string directory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "NoteChat-Client");
            string filePath = Path.Combine(directory, "Config.ini");

            // 创建一个字典用于存储配置项和配置名的内容
            var configData = new Dictionary<string, Dictionary<string, string>>();

            if (File.Exists(filePath))
            {
                // 读取现有的配置文件内容
                string[] lines = File.ReadAllLines(filePath);
                string currentSection = string.Empty;

                foreach (string line in lines)
                {
                    if (line.StartsWith("["))
                    {
                        // 识别配置项的部分（配置项名称）
                        currentSection = line.Trim('[', ']');
                        configData[currentSection] = new Dictionary<string, string>();
                    }
                    else if (currentSection != string.Empty)
                    {
                        // 识别配置名和内容
                        string[] parts = line.Split('=');
                        if (parts.Length == 2)
                        {
                            string name = parts[0].Trim();
                            string value = parts[1].Trim();
                            configData[currentSection][name] = value;
                        }
                    }
                }
            }

            // 更新或添加新的配置项和配置名
            if (!configData.ContainsKey(configItem))
            {
                configData[configItem] = new Dictionary<string, string>();
            }
            configData[configItem][configName] = content;

            // 将配置数据写入文件
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var section in configData)
                {
                    writer.WriteLine($"[{section.Key}]");
                    foreach (var item in section.Value)
                    {
                        writer.WriteLine($"{item.Key}={item.Value}");
                    }
                }
            }
        }

        public static string LoadConfig(string configItem, string configName)
        {
            // 构建配置文件的完整路径
            string directory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "NoteChat-Client");
            string filePath = Path.Combine(directory, "Config.ini");

            if (File.Exists(filePath))
            {
                // 读取配置文件内容
                string[] lines = File.ReadAllLines(filePath);
                string currentSection = string.Empty;

                foreach (string line in lines)
                {
                    if (line.StartsWith("["))
                    {
                        // 识别配置项的部分（配置项名称）
                        currentSection = line.Trim('[', ']');
                    }
                    else if (currentSection == configItem)
                    {
                        // 识别配置名和内容
                        string[] parts = line.Split('=');
                        if (parts.Length == 2)
                        {
                            string name = parts[0].Trim();
                            string value = parts[1].Trim();
                            if (name == configName)
                            {
                                System.Diagnostics.Debug.WriteLine(value);
                                return value;
                            }
                        }
                    }
                }
            }

            // 如果配置文件不存在或者未找到配置项和配置名，返回空字符串或其他适当的默认值
            return "";
        }
    }
}
