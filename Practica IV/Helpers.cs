using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_IV
{
    public static class Helpers
    {

        public static List<int> Pares(this List<int> num)
        {

            List<int> NumPares = num.FindAll(n => n % 2 == 0);
            return NumPares;

        }

    }
    
}
