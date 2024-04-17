using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Является ли строка палиндромом? Введите строку:");
            string inputString = Console.ReadLine().Replace(" ", string.Empty).ToLower();
            string invertedStiring = string.Empty;
            foreach (char ch in inputString)
            {
                invertedStiring = ch + invertedStiring;
            }
            if (inputString.Equals(invertedStiring))
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Строка является палиндромом!");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Строка НЕ вляется палиндромом!");
            }         
            Console.ReadKey();
        }
    }
}
