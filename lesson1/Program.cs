using System;

namespace lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myDateTime = DateTime.Today;
            string str;
            Console.WriteLine("Ваше имя? :");
            str = Console.ReadLine();
            Console.WriteLine($"Hello {str}! Сегодня {myDateTime.ToString("dd/MM/yyyy")} г.");

            
        }
    }
}
