using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace examhari04
{
    class soal02:LogicBase
    {
        public soal02(int n)
        {
            JmlBaris = n;
            JmlKolom = JmlBaris * 2 - 1;
            Array2D = new string[JmlBaris, JmlKolom];
            IsiArray();
            FunctionBase.CetakArray(Array2D);

        }

        private void IsiArray()
        {
            for (int b = 0; b < JmlBaris; b++)
            {
                int angka = 1;
                for (int k = 0; k < JmlKolom; k++)
                {
                    if (k>=b && b+k<=JmlKolom-1)
                    {
                        Array2D[b, k] = angka++.ToString();
                    }
                }
                
            }
        }
    }
}
