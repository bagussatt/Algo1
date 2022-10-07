using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo1
{
    class Program
    {

        private int[] a = new int[20];
        private int n;

        public void read()
        {
            while (true)
            {
                Console.Write("Masukkan banyaknya elemen pada Array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 20 elemen.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("-----------------------");
            Console.WriteLine(" Masukan elemen array ");
            Console.WriteLine("-----------------------");
            for (int i = 0; i < n; i++) 
            {
                Console.WriteLine("<" + (i + 1) + "> ");
                String s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }
        }
        public void display ()
        {
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(" Element array yang telah tersusun ");
            Console.WriteLine("-----------------------------------");
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine(a[j]);
            }
            Console.WriteLine("");
        }
        public void bubbleShortArray()
        {
            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < n - i; j++)
                {
                    if (a[j] > a[j + 1])

                    {
                        int temp;
                        temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
            static void main(string[] args)
            {
                Program myList = new Program();
                myList.read();
                myList.bubbleShortArray();
                myList.display();
                Console.WriteLine("\n\n Tekan Tombol Apa saja untuk keluar.");
                Console.Read();
            }

        }
    }
}
