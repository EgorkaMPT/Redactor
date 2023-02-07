using Newtonsoft.Json;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Redactor
{
    internal class GivingInfo
    {
        static public void fileData()
        {
            string file;
            Console.Clear();
            Console.WriteLine("Введите путь к файлу");
            file = Console.ReadLine();
            String editlink = file.Substring(file.Length - 1);
            infoFile(file, editlink);
        }
        static void infoFile(string fileData, string link) 
        {
            File.Create($"{infoFile}").Close();
            switch(link)
            {
                case "t":
                    Console.SetCursorPosition(0, 5);
                    Console.WriteLine("Выбранный формат - txt");
                    string formatTxt = "";
                    string en = "\n";
                foreach (var item in Way.Raze)
                {
                    formatTxt += item.Viper;
                    formatTxt += en;
                    formatTxt += item.Neon;
                    formatTxt += en;
                    formatTxt += item.Sova;
                }
                    File.WriteAllText($"{infoFile}", formatTxt);
                foreach ( var item in Way.Raze)
                {
                    Console.WriteLine(item.Viper);
                    Console.WriteLine(item.Neon);
                    Console.WriteLine(item.Sova);
                }
                    Thread.Sleep(2500);
                    break;
                case "j":
                    Console.SetCursorPosition(0, 5);
                    Console.WriteLine("Выбранный формат - json");
                    string formatJson = JsonConvert.SerializeObject(Way.Raze); ;
                    File.AppendAllText($"{infoFile}", formatJson);
                    Console.SetCursorPosition(0, 6);
                foreach(var item in Way.Raze)
                {
                    Console.WriteLine(item.Viper);
                    Console.WriteLine(item.Neon);
                    Console.WriteLine(item.Sova);
                }
                    Thread.Sleep(2500);
                    break;
                case "x":
                    Console.SetCursorPosition(0, 5);
                    Console.WriteLine("Выбранный формат - xml");
                    XmlSerializer formatXlm = new XmlSerializer(typeof(List<Way>));
                    using (FileStream Jett2 = new FileStream($"{infoFile}", FileMode.OpenOrCreate))
                    {
                        formatXlm.Serialize(Jett2, Way.Raze);
                    }
                foreach(var item in Way.Raze)
                {
                    Console.WriteLine(item.Viper);
                    Console.WriteLine(item.Neon);
                    Console.WriteLine(item.Sova);
                }
                        break;
            }
        }
    }
}
