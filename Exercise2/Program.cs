using System;
using System.Collections.Generic;
using System.Globalization;
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
            int[] temp = new int[64];
            int i, AH, k,n1,n2,n3;
            n1 = (mid - 1);
            n2 = low;
            n3 = (high - low + 1);

            while ((low <= n1) && (mid <= high))
            {
                if (adit[low] <= adit[mid])
                    temp[n2++] = adit[low++];
                else
                    temp[n2++] = adit[mid++];
            }
            while(low<= n2)
                temp[n2++] = adit[low++];
            while(mid<= high)
                temp[n2++] = adit[mid++];
            for (i = 0; i < n3; i++)
            {

            }
        }
        static void Main(string[] args)
        {
            Program prg = new Program();
            int pilihan;
            do
            {
                Console.WriteLine("Menu Option");
                Console.WriteLine("----------------");
                Console.WriteLine("1. Linear Search");
                Console.WriteLine("2. Binary Search");
                Console.WriteLine("3. Exit");
                Console.WriteLine(" Enter the Number 1, 2, 3");
                pilihan = Convert.ToInt32(Console.ReadLine());

                switch (pilihan)
                {

                }
            }
        }
    }
}
