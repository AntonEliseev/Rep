using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree t = new Tree();
            Random rnd = new Random();
            for (int i = 0; i < 30; i++)
                t.Insert(rnd.Next(50));
            int k = t.CountOnLevel(3);
            Console.WriteLine(k);
            t.WriteTree("OutPut.txt");
            Console.ReadKey();
            
        }
    }
}
