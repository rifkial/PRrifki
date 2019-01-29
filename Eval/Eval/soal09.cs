using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exambase;

namespace Eval
{
    class soal09 : LogicBase
    {
        public soal09(int n, int m)
        {
            jmlBaris = 2;
            jmlKolom = m * 2;
            Array2D = new string[jmlBaris, jmlKolom];
            IsiArray(n, m);
            FunctionBase.CetakArray(Array2D);
        }

        private void IsiArray(int n, int m)
        {
            
            for (int bgn = 0; bgn <= m; bgn++)
            {
                int angka = n;
                for (int b = 0; b <= jmlBaris; b++)
                 {
                for (int k = 0; k < jmlKolom; k++)
                {
                    if (bgn % 2 != 0)
                    {
                        Array2D[0, k] = n.ToString();
                    }
                    else
                    //{
                    //    Array2D[0, k] = "";
                    //}



                    //if (bgn % 2 == 0)
                    {
                        Array2D[1, k] = n.ToString();
                    }
                    //else
                    //{
                    //    Array2D[1, k] = "";
                    //}
                }
                n++;
                }
            }
        }

        //private string getValue(int k,int val1)
        //{
        //    string result = string.Empty();
        //    val
        //}
    }
}
