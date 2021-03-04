using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            string v = "";
            string t = "";
            int a = 0;
            int b = 0;
            int c = 0;
            Console.Write("Plase put an int:");
            s = Console.ReadLine();
            a = int.Parse(s);
            Console.Write("Plase put an symble:");
            t = Console.ReadLine();
            Console.Write("Plase put an int:");
            v = Console.ReadLine();
            b = int.Parse(v);
            if (t == "+")
            {
                c = a + b;
                Console.Write(c);
            }
            else if (t == "-")
            {
                c = a - b;
                Console.Write(c);
            }
            else if (t == "*")
            {
                c = a * b;
                Console.Write(c);
            }
            else if (t == "/")
            {
                if (b == 0)
                {
                    Console.Write("illegal");
                }
                else
                {
                    c = a / b;
                    Console.Write(c);
                }
            }
            Console.ReadKey();
        }
    }
}
