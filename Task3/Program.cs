using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Классное решение с использованием регулярных вырожений
            // string inputString = Console.ReadLine();
            //  string outputString = Regex.Replace(inputString, @"{[\d\D]+}", "");
            // Console.WriteLine(outputString);
            #endregion

            Console.WriteLine("Введите строку:");
            string inputString = Console.ReadLine();
            string temp = string.Empty;

            int l = inputString.Split('}').Length;

            while (l > 1)
            {
                int i = inputString.IndexOf('}');
                temp = inputString.Substring(0, i + 1);
                inputString = inputString.Remove(0, i + 1);
                i = temp.LastIndexOf('{');
                inputString = temp.Remove(i, temp.Length - i) + inputString;
                l--;
            }

            Console.WriteLine("Обработанная строка: ");
            Console.WriteLine(inputString);
            Console.ReadKey();
        }
    }
}
