using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;

namespace examhari04
{
    class soalPR : LogicBase
    {
        public soalPR (int n)
        {
            JmlBaris = n;
            JmlKolom = n*2-1;
            Array2D = new string[JmlBaris, JmlKolom];
            IsiArray();
            FunctionBase.CetakArray(Array2D);
         }

        private void IsiArray()
        {
            int asscii = 65;
            int [] Fibo = FunctionBase.soalPP(JmlKolom);
            for (int b = 0; b < JmlBaris; b++)
			{
			 for (int k = 0; k < JmlKolom; k++)
			{
                Array2D[b,k] =  Fibo[b].ToString();	
		         Array2D[b,JmlKolom-k-1]= Fibo[b].ToString();
			}
                else if (b+k == (JmlKolom-1)/2 )
                {
                    Array2D[b,k]=Fibo[k].ToString();
                    Array2D[b,JmlKolom-k-1]=Fibo[k].ToString();
                }
			}
        }
    }
}
