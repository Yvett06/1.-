using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Нечетни_срещания
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine()
                .ToLower().Split(' ').ToList();
            Dictionary<string, int> wordsCount = new Dictionary<string, int>();
            foreach (var item in words)
            {
                if (wordsCount.ContainsKey(item))
                {
                    wordsCount[item]++;
                }
                else
                {
                    wordsCount[item] = 1;
                }
            }
            List<string> result = new List<string>();
            foreach (var item in wordsCount)
            {
                if (item.Value % 2 == 1)
                {
                    result.Add(item.Key);
                }
            }
            Console.WriteLine(string.Join(",", result));
        }
    }
}
