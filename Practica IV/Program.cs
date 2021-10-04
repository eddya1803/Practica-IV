using System;
using System.Collections.Generic;

namespace Practica_IV
{

    class Program
    {
        static void Main(string[] args)
        {

            List<int> numeros = new List<int>() { 2, 3, 5, 9, 11, 14, 15, 18, 19, 22, 25, 27, 30 };

            foreach (var n in Helpers.Pares(numeros))
            {

                Console.WriteLine(n);

            }
        }



        /*=================================================================================================

        2da. parte de la practica:
        Escribir los siguientes metodos como expresiones lambda:


         a)
            public bool EsImpar(int x){
                if (x % 2 != 0){
                  return true;
                else{
                  return false;
                }
              }

         */
        public bool EsImpar(int x) => x % 2 != 0;


        /*
         * b)
        *   public double CalcularITBIS(double precio){
               var itebis = precio * 0.18;
               return itebis;
            }
        */

        public double CalcularITBIS(double precio) => (precio * 0.18);



        /*
         * c)
           public void GetDate(){
               var fecha = DateTime.Now;
               return fecha;
           }
        */

        public DateTime GetDate() => DateTime.Now;


    }

}
