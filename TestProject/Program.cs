using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintNumbers();
            PrintCharacters();
            ManualTest test = new ManualTest();
            test.RunTests("R u there?");
            Console.Read();
        }

        static void PrintNumbers()
        {
            for(int i = 0; i < 10; i++ )
            {
                Console.WriteLine(i);
            }
        }

        static void PrintCharacters()
        {
            List<char> charaters = new List<char>() { 'a', 'b', 'c', 'd', 'e', 'f' };

            foreach(char c in charaters)
            {
                Console.WriteLine(c);
            }

        }
    }
}
