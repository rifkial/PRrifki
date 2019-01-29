using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exambase;

namespace Eval
{
    class soalP3 : LogicBase
    {
        public soalP3(int n)
        {
            jmlBaris = 1;
            jmlKolom = n;
            Array2D = new string[jmlBaris, jmlKolom];
            IsiArray(n);
            FunctionBase.CetakArray(Array2D);
        }

        private void IsiArray(int n)
        {
            int angka = 0;
            for (int b = 0; b < n; b++)
            {
                for (int k = 0; k <= b; k++)
                {
                    angka = ((n + 1) * 2);
                    Array2D[0, k] = angka.ToString();
                }
            }
        }
    }
}