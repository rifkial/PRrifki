﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examhari02
{
    class soal06
    {
        public soal06(int n)
        {
            cetakpola(n, n);
        }
        private void cetakpola(int jB, int jK)
        {
            
            for (int b = 0; b < jB; b++)
            {
                for (int k = 0; k < jK; k++)
                {
                    if (b + k == jK - 1)
                    {
                        Console.Write("{0}\t", k * 2);
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                }
            }
        }
    }
}

