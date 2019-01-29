using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eval
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("masukan nilai n :");
            int val = int.Parse(Console.ReadLine());
            //Console.Write("masukan nilai m :");
            //int val1 = int.Parse(Console.ReadLine());
            soalP3 soal06 = new soalP3(val);
            Console.Write("tekan semabarang tombol");
            Console.ReadKey();
        }
    }
}
