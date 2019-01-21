using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;


namespace examhari04
{
    class soal01 : LogicBase
    {
       public soal01 (int n)
	{
        JmlBaris = rere;
        JmlKolom = rere;
        Array2D = new String[JmlBaris, JmlKolom];
        IsiArray2D();
        FunctionBase.CetakArray(Array2D)
	}

       public int angka;
         
        private void Isiarray2D()
       {
           for (int b = 0; b < JmlBaris; b++)
           {
               for (int k = 0; k < JmlKolom; k++)
               {
                   if(b+k)>= JmlBaris - 1&& k-b<=JmlBaris-1)
                   {
                       Array2D[b,k] = angka++.ToString
                   }
               }
               
           }
       }

    }
}
