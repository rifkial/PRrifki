using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamBase;


namespace examhari03
{
    class SOAL03
    {
        public SOAL03(int n)
            {
            jmlBaris = 1;
            jmlKolom = n;
            Array2D = new string[jmlBaris, jmlKolom];
            IsiArray();
            CetakArray();
        }
        private void IsiArray()
        {
            // Console.WriteLine("nilai jumlah baris: {0}", jmlBaris);
            //Console.WriteLine("nilai jumlah kolom: {0}", jmlKolom);
            //Console.WriteLine("buffer array : {0}",jmlBaris*jmlKolom);

            //for (int b = 0; b < jmlBaris; b++)
            //{
            // for (int k = 0; k < jmlKolom; k++)
            //{   //diagonal kiri ke kanan ganjil
            //  if (b == k)
            //    Array2D[b, k] = (k*2+1).ToString();
            //diagonal kanan ke kiri genap
            //else if (b + k == jmlBaris - 1)
            //  Array2D[b, k] = (k * 2).ToString();   


            int[] soal3 = ExamBase.FunctionBasexx.soal3(jmlKolom);
            for (int k = 0; k < jmlKolom; k++)
            {
                Array2D[0, k] = soal3[k].ToString();
            }
        }

        private void CetakArray()
        {
            for (int b = 0; b < Array2D.GetLength(0); b++)
            {
                for (int k = 0; k < Array2D.GetLength(1); k++)
                {
                    Console.Write("{0}\t", Array2D[b, k]);
                }
                Console.WriteLine("\n");
            }
        }

        public int jmlBaris { get; set; }

        public int jmlKolom { get; set; }

        public string[,] Array2D { get; set; }
    }
}
