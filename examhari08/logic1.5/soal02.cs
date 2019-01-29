using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exambase;

namespace logic1._5
{
    class soal02 : LogicBase
    {
        public int PubN = 0;
        public int angka = 1;
        public int[] fibo;
        public soal02(int n)
        {
            PubN = n;
            int m = Math.Abs(n);
            jmlBaris = m;
            jmlKolom = m * m + (m - 1);
            Array2D = new string[jmlBaris, jmlKolom];
            IsiArray(m);
            FunctionBase.CetakArray(Array2D);
        }

        private void IsiArray(int m)
        {
            fibo = FunctionBase.Fibonacci(m * m);
            for (int bgn = 0; bgn < m; bgn++)
            {
                angka = 1;
                int stKol = (m + 1) * bgn;
                int endKol = stKol + m - 1;

                //Bawah to Kanan
                for (int k = stKol; k <= endKol - 1; k++)
                {
                    Array2D[m - 1, k] = GetValue(angka++).ToString();
                }
                //Kanan to Atas
                for (int b = m - 1; b >= 1; b--)
                {
                    Array2D[b, endKol] = GetValue(angka++).ToString();
                }
                //Atas to Kiri
                for (int k = endKol; k >= stKol + 1; k--)
                {
                    Array2D[0, k] = GetValue(angka++).ToString();
                }
                //Atas to Bawah
                for (int b = 0; b <= m - 2; b++)
                {
                    Array2D[b, stKol] = GetValue(angka++).ToString();
                }
            }
        }
        private int GetValue(int val)
        {
            //untuk inputan Negatif
            if (PubN < 0 && val % Math.Abs(PubN) == 0)
            {
                return PubN;
            }
            //Untuk Inputan Positif
            else if (val % Math.Abs(PubN) == 0)
            {
                angka = 1;
                //return val;                
            }
            //else
            //{
            //    return val;
            //}
            return fibo[val - 1];
        }
    }
}

