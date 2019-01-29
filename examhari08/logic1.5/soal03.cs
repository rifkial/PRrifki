using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exambase;

namespace logic1._5
{
    class soal03 : LogicBase
    {
        public soal03(int n1, int n2)
        {
            jmlBaris = n1;
            jmlKolom = n1;
            Array2D = new string[jmlBaris, jmlKolom];
            IsiArray(n1, n2);
            FunctionBase.CetakArray(Array2D);
        }

        private void IsiArray(int n1, int n2)
        {
            int angka = 1;
            int stBrs = 0;
            int stKol = 0;
            int endKol = n1 - 1;
            int endBrs = n1 - 1;
            for (int k = 0; k <= jmlKolom-2; k++)
            {
                Array2D[0, k] = angka++.ToString();
            }
            while (stBrs <= endBrs && stKol <= endKol)
            {
                for (int b = stBrs; b <= endBrs; b++)
                {
                    Array2D[b, endKol] = angka++.ToString();
                }
                stBrs += 2;
                ////bawah dari kanan ke kiri
                for (int k = endKol - 1; k >= stKol; k--)
                {
                    Array2D[endBrs, k] = angka++.ToString();
                }
                endKol -= n2;
                ////kiri dari bawah ke atas
                for (int b = endBrs - 1; b >= stBrs; b--)
                {
                    Array2D[b, stKol] = angka++.ToString();
                }
                endBrs -= n2;
                ////atas dari kiri ke kanan
                for (int k = stKol + 1; k <= endKol; k++)
                {
                    Array2D[stBrs, k] = angka++.ToString();
                }
                stKol += n2;
            }
        }
    }

}
    
