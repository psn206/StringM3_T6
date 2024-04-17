using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            string[] arrString = inputString.Split();
            string longWord = arrString[0];

            foreach (string word in arrString)
            {
                if (longWord.Length < word.Length)
                {
                    longWord = word;
                }
            }
            Console.WriteLine($"Самое длинное слово: {longWord}");
            Console.ReadKey();
        }
    }
}
