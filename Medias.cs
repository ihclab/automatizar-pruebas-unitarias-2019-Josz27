using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatizarPruebasUnitarias {

    class Medias {

        /**
         * Calcula y regresa la media artimética
         */
        public static double mediaAritmetica( int[] vals, int size)
        {
          int sum = 0;
                 int average = 0;
                  for (int i = 0; i < size; i++)
                  {
                      sum += vals[i];
                  }
                  average = sum / size;
                  return average;
        }


        /**
         * Calcula y regresa la raíz enésima = x^(1/n)
         */
         static double raizEnésima(double A, int N)
             {
                 double epsilon = 0.00001d;//
                 double n = N;
                 double x = A / n;
                 while (Math.Abs(A-Power(x,N)) > epsilon)
                 {
                     x = (1.0d/n) * ((n-1)*x + (A/(Power(x, N-1))));
                 }
                 return x;

             }










        /**
         *  Usa raizEnesima para calcular y regresar la media geométrica
         */
        public double mediaGeometrica(params int[] vals, int size)
        {
          int sum=0;
          int x=0;
for int (int i=0; i<size;i++ )
{
  sum=sum+vals[i];

}
int media=sum/ (1/size);
return int;

        }

        /**
         * Este método no está implementado
         */
        public static double mediaArmonica(params int[] vals, int longitud)
        {
          int suma=0;
        }
    }
}
