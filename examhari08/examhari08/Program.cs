using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examhari08
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("masukan nilai n1=");
            int val1 = int.Parse(Console.ReadLine());
            Console.Write("masukan nilai n2=");
            int val2 = int.Parse(Console.ReadLine());
            soal04 soal03 = new soal04(val1,val2);
            Console.ReadKey();


        }
    }
}
