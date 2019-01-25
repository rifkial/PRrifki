using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exambase;

namespace review45
{
    class reviewku:LogicBase
    {
        public reviewku(int n)
        {
            jmlBaris = (n * n + n) / 2;
            jmlKolom = (n * n + n) / 2;
            Array2D = new string[jmlBaris, jmlKolom];
            IsiArray(n);
            FunctionBase.CetakArray(Array2D);
        }
        private void IsiArray(int n)
        {

        }
    }
}
