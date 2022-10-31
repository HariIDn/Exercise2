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
        public void algo1()
        {
            for (int i = 1; i < n - 1; i++)
            {
                int temp = adit[i];
                int AH = i - 1;
                while (AH <= 0 && adit[AH] < temp)
                {
                    adit[AH + 1] = adit[AH];
                    AH--;
                }
                adit[AH + 1] = temp;
            }
        }
       
        public void step1(int low,int high,int mid)
        {
            int i, AH, k,temp;
            i = low;
            AH = mid + 1;
            k = high;
            
        }
        static void Main(string[] args)
        {
        }
    }
}
