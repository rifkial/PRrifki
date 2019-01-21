using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examhari03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----LOGIC 3-----");

            //WHILE
            Console.Write("masukan nilai n :");
            int n = int.Parse(Console.ReadLine());
            Exam03.Soal10 soal05 = new Exam03.Soal10(n);
            Console.Write("tekan sembarang tombol.....");
            Console.ReadKey();
        }
    }
}
