﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examhari02
{
    class soal02
    {
        public soal02(int n)
        {
            CetakPola(n, n);
        }
        private void CetakPola(int jB, int jK)
        {
           
            for (int b = 0; b < jB; b++)
            {
                for (int k = 0; k < jK; k++)
                {
                    if (b + k == jK - 1)
                    {
                      // Console.Write("{0}\t", k * 2);
                        Console.Write("{0}\t",k * 2);
                    }
                    //prepare yg kosong
                    else
                    {
                        Console.Write("\t");
                    }
                }
                Console.WriteLine("\n");
            }
        }
    
    }
}
