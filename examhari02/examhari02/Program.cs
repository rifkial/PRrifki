﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examhari02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("masukan nilai n :");
            int val = int.Parse(Console.ReadLine());
            soal06 soal03 = new soal06(val);
            Console.ReadKey();
        }
    }
}
