using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examhari01
{
    class soal06
    {
        public soal06 (int n)
	    {
            //baris
            for (int b=0;b<n;b++)
            {   //kolom
                for (int k=0;k<n;k++)
                {
                    //diagonal dari kiri kenan
                    if (b >= k)
                    {
                        Console.Write("*\t");
                    }
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
