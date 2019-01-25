using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace review45
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("masukan nilai n :");
            int val = int.Parse(Console.ReadLine());
            rifki soal06 = new rifki(val);
            Console.Write("tekan aku sesuka masnya ajah");
            Console.ReadKey();
        }
    }
}
