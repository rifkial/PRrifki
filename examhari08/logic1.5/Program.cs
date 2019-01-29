using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("masukan nilai n :");
            //int val = int.Parse(Console.ReadLine());
            //soal02 soal03 = new soal02(val);
            //Console.ReadKey();



            Console.Write("masukan nilai n1=");
            int val = int.Parse(Console.ReadLine());
            //Console.Write("masukan nilai n2=");
            //int val2 = int.Parse(Console.ReadLine());
            soal01 soal01 = new soal01(val);
            Console.ReadKey();
        }
    }
}
