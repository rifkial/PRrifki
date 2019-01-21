using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examhari05
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("masukan nilai n");
            //Console.Readline

            Console.Write("masukan nilai n :");
            int val = int.Parse(Console.ReadLine());
            soal07 soal06 = new soal07(val);
            Console.ReadKey();
        }
    }
}
