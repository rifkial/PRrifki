using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exambase;

namespace Eval
{
    class soal04:LogicBase
    {
        public soal04(int n,int m)
        {
            jmlBaris = n;
            jmlKolom = n;
            Array2D = new string[jmlBaris, jmlKolom];
            IsiArray(n, m);
            FunctionBase.CetakArray(Array2D);
        }

        private void IsiArray(int n,int m)
        {
            bool a = true;
            int angka = m;
            for (int b = jmlBaris-1; b >=1; b--)
            {
                if (a)
                {
                    Array2D[b, jmlKolom - 1] = angka.ToString();
                    angka = angka + n;
                    a = !a;
                }
                else
                {
                    Array2D[b, jmlKolom - 1] = "*";
                    a = !a;
                }
            }
            for (int k = jmlKolom; k >=1; k--)
            {
                if (k % 2 == 0)
                {
                    Array2D[0, k] = angka.ToString();
                    angka = angka + n;
                }
                else
                {
                    Array2D[0, k] = "*";
                }
            }
            for (int b = 0; b <= jmlBaris+2; b++)
            {
                for (int k = 0; k <=jmlKolom+2 ; k++)
                {
                    if (b==k)
                    {
                        if (k%2==0)
                        {
                            Array2D[b, k] = angka.ToString();
                            angka = angka + n;
                        }
                        else
                        {
                            Array2D[b, k] = "*";
                        }
                    }
                }

            }
        }
    }
}
