using System;
using System.IO;
using System.Linq;

namespace pr16_1_Mezenceva_Polina
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Введите слово для его поиска по файлу: ");
            string word = Console.ReadLine();

            Console.WriteLine("Введите название файла откуда брать текст: ");
            string file = Console.ReadLine();

            if (File.Exists($"{file}.txt"))
            {
                StreamReader sr = new StreamReader($"{file}.txt");

                string[] text = sr.ReadToEnd().Split('.', ' ');
                int i = 0;
                var answer = from bb in text where bb.ToUpper() == word.ToUpper() select bb;

                foreach (string x in answer)
                {
                    i++;
                }

                Console.WriteLine($"Были найдены {i} вхождения (ий) поискового запроса \"{word}\" ");
                sr.ReadLine();
            }
            else Console.WriteLine("Такого файла не найдено.");
        }
    }
}
