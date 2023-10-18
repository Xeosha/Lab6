using MenuOpt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreateShowArray;
using System.Text.RegularExpressions;

namespace Lab6
{
    internal class Task2 : TaskBase
    {
        string row;
        public override void Create()
        {
            CreateKeyboard();
        }

        public void CreateKeyboard() => row = Console.ReadLine();
        public override void Show()
        {
            if (row == null ||  row.Length == 0) 
                Console.WriteLine("Пустая строка");
            else
                Console.WriteLine(row);
        }

        public void MoveLeft()
        {
            var result = row;
            string[] words = Regex.Split(row, @"(\W+)");

            int wordCount = 1;
            for (int i = 0; i < words.Length; i++)
            {
                if (String.IsNullOrEmpty(words[i]) || !Regex.IsMatch(words[i], @"\w+"))
                    continue;

                words[i] = RotateLeft(words[i], wordCount);
                wordCount++;
            }
            result = String.Concat(words);

            Console.WriteLine("Исходная строка: " + row);
            Console.WriteLine("Новая строка: " + result);
        }

        private static string RotateLeft(string word, int positions)
        {
            positions %= word.Length;
            return word.Substring(positions) + word.Substring(0, positions);
        }
    }
}
