using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Elevado.Servicios
{
    internal class NumeroImplementacion : NumeroInterfaz
    {

        public double solicitudNumero(int k)
        {
            double numero;

            if (k == 0)
            {
                Console.WriteLine("Dame un numero tipo double");
            }
            else
            {
                Console.WriteLine("Dame un numero tipo int");
            }

            numero = Convert.ToDouble(Console.ReadLine());

            return numero;
        }
       
    }
}
