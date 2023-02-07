namespace Redactor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Way.GetLink();
            Console.WriteLine("F1 - Сохранить файл\nESC - выход из программы");
            ConsoleKey key = Console.ReadKey().Key;
            switch(key)
            {
                case ConsoleKey.F1:
                    Console.WriteLine("Была нажата F1");
                    GivingInfo.fileData();
                        break;
                case ConsoleKey.Escape:
                    Console.WriteLine();
                        break;
            }
        }
    }
}