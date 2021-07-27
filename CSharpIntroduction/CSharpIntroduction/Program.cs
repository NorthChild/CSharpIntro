using System;

namespace CSharpIntroduction
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 100;
            x += 1;

            for (int i = 0; i <= 10; i++) 
            {
                Console.WriteLine(i);
                x += i;
            }

            Console.WriteLine("Writing out command line arguments");
            foreach (string item in args) {
                Console.WriteLine(item);
            }
        }
    }
}
