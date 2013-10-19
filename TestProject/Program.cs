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
            Console.Read();
        }

        static void PrintNumbers()
        {
            for(int i = 0; i < 10; i++ )
            {
                Console.WriteLine(i);
            }
        }
    }
}
