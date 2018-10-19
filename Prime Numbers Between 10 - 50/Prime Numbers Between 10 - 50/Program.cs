using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Numbers_Between_10___50
{
    class Program
    {
        static void Main(string[] args)
        {

            bool asal_kontrol = true;
            int c = 0;
            for (int i = 10; i < 51; i++)
            {
                c = i / 2;
                for (int j = 2; j < c; j++)
                {
                    if (i % j == 0)
                    {
                        asal_kontrol = false;
                    }
                }
                if (asal_kontrol)
                {
                    Console.WriteLine(i + " Sayısı bir asal sayıdır. ");
                }
                else
                {
                    asal_kontrol = true;
                }






            }
    }
}
