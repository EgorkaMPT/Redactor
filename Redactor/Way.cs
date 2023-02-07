using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Serialization;
using static System.Net.Mime.MediaTypeNames;

namespace Redactor
{
    internal class Way
    {
        public string Viper;
        public string Neon;
        public string Sova;
        static public List<Way> Raze = new List<Way>(); 
        public Way()
        {
        }
        public Way(string viper, string neon, string sova)
        {
            this.Viper = viper;
            this.Neon = neon;
            this.Sova = sova;
        }
        public static void GetLink()
        {
            string a;
            Console.WriteLine("Введите путь файла:\n");
            a = Console.ReadLine();
            String b = a.Substring(a.Length - 1);
            GetInfo(b,a);
            Thread.Sleep(3000);
            Console.Clear();
        }
        public static void GetInfo(string b, string a)
        {
            switch(b)
            {
                case "t":
                    Console.SetCursorPosition(0, 4);
                    Console.WriteLine("Формат файла txt");
                    Way txt = new Way();
                    string viper = File.ReadLines($"{a}").ElementAtOrDefault(0);
                    txt.Viper = viper;
                    Console.WriteLine(txt.Viper);
                    string neon = File.ReadLines($"{a}").ElementAtOrDefault(1);
                    txt.Neon = neon;
                    Console.WriteLine(txt.Neon);
                    string sova = File.ReadLines($"{a}").ElementAtOrDefault(2);
                    txt.Sova = sova;
                    Console.WriteLine(txt.Sova);
                    Way.Raze.Add(txt);
                    Thread.Sleep(2500);
                    break;
                case "j":
                    Console.SetCursorPosition(0, 4);
                    Console.WriteLine("Формат файла json");
                    string json = File.ReadAllText($"{a}");
                    Raze = JsonConvert.DeserializeObject<List<Way>>(json);
                    foreach (var item in Raze)
                    {
                        Console.WriteLine(item.Viper);
                        Console.WriteLine(item.Neon);
                        Console.WriteLine(item.Sova);
                    }
                    Thread.Sleep(2500);
                    break;
                case "x":
                    Console.SetCursorPosition(0, 4);
                    Console.WriteLine("Формат файла xml");
                    XmlSerializer Xml = new XmlSerializer(typeof(List<Way>));
                    using (FileStream Jett = new FileStream($"{b}", FileMode.Open))
                    {
                        Raze = (List<Way>)Xml.Deserialize(Jett);
                    }
                    foreach (var item in Raze)
                    {
                        Console.WriteLine(item.Viper);
                        Console.WriteLine(item.Neon);
                        Console.WriteLine(item.Sova);
                    }
                    Thread.Sleep(2500);
                    break;
            }
        }
    }
}