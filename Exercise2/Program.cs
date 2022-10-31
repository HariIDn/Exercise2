using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    internal class Program
    {
        int[] adit = new int[64];
        int n;

        public void input()
        {
            while (true)
            {
                Console.Write("Masukan banyaknya Array");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 64)
                    break;
                else
                    Console.WriteLine("\nMaksimal Elemen Array 64\n");
            }
            Console.WriteLine(".......................");
            Console.WriteLine("Enter the Array Element");
            Console.WriteLine(".......................");

            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                adit[i] = Int32.Parse(s1);
            }
        }
       
        static void Main(string[] args)
        {
        }
    }
}
