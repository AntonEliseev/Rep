using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
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

            List<int> lvl = new List<int>();
            lvl = t.NodesOnLevel(3);
            foreach (int p in lvl) Console.Write("{0}\t", p);

            t.WriteTree("OutPut.txt");
            Console.ReadKey();
        }
    }
}
