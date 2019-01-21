using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examhari04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("masukan nilai n :");
            int val = int.Parse(Console.ReadLine());
            soal01 soalAA = new soal01(val);
            Console.ReadKey();
        }
    }
}
