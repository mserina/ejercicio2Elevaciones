using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Elevado.Servicios
{
    /// <summary>
    /// Clase que contiene toda la logica de los metodos de la interfaz
    /// msm - 281023
    /// </summary>
    internal class OperacionImplementacion : OperacionInterfaz
    {
        public void Operacion (double y, int x)
        {

            double operacion = 0;


            for (int i = 0; i <= x; i++)
            {
                operacion = y * i;
            }
            
            Console.WriteLine("El resultado de " + y + " elevado a " + x + " es: " + operacion);
            
        }
    }
}
