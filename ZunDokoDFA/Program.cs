using System;
using System.Threading;

namespace ZunDokoDFA
{
    class Program
    {
        private static readonly string[] phrases = new string[] { "ズン", "ドコ" };
        private static readonly int[,] room = new int[,] { { 1, 0 }, { 2, 0 }, { 3, 0 }, { 4, 0 }, { 4, 5 }, { -1, 0 } };

        static void Main(string[] args)
        {
            var i = 0;

            while (room[i, 0] != -1)
            {
                var phrase = Sing();
                Console.WriteLine(phrase);
                i = room[i, Convert.ToInt32(phrase == phrases[1])];
            }

            Console.WriteLine("き・よ・し！");
            Console.ReadKey();
        }

        private static string Sing()
        {
            Thread.Sleep(100);
            var random = new Random(int.Parse(DateTime.Now.Millisecond.ToString()));
            var num = random.Next(10);
            return phrases[Convert.ToInt32(num < 5)];
        }
    }
}
