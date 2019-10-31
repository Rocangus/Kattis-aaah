using System;

namespace Kattis_aaah
{
    class Program
    {
        static void Main(string[] args)
        {
            var marius = Console.ReadLine();
            var doc = Console.ReadLine();

            if (marius.IndexOf('h') < doc.IndexOf('h'))
            {
                Console.WriteLine("no");
            }
            else
            {
                Console.WriteLine("go");
            }
        }
    }
}
