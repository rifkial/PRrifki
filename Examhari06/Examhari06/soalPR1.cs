using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exambase;

namespace Examhari06
{
    class soalPR1:LogicBase
    {
        public soalPR1(int n)
        {
            jmlBaris = 3 * n + (n - 1);
            jmlKolom = 3 * n + (n - 1);
            Array2D = new string[jmlBaris, jmlKolom];
            IsiArray(n);
            FunctionBase.CetakArray(Array2D);

        }

        private void IsiArray(int n)
        {
            for (int b = 0; b < jmlBaris; b++)
            {
                for (int k = 0; k < jmlKolom; k++)
                {
                    if(b+k>=n+n && k-b<=n+n-1 && b<n)
                    {
                        Array2D[b, k] = "*";
                        Array2D[k, b] = "*";
                        Array2D[jmlKolom - k - 1, jmlBaris - b - 1] = "*";
                        Array2D[jmlBaris - b - 1, jmlKolom - k - 1] = "*";
                    } 
                       
                }
            }
            
        }
    }
}
