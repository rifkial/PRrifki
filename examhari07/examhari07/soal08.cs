using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exambase;


namespace examhari07
{
    class soal08:LogicBase
    {
        public soal08(int n1,int n2,int n3)
        {
            jmlBaris = n1;
            jmlKolom = n2*n3+n3-1;
            Array2D = new string[jmlBaris, jmlKolom];
            IsiArray(n1, n2, n3);
            FunctionBase.CetakArray(Array2D);
        }

        private void IsiArray(int n1,int n2,int n3) { }

    }
}
