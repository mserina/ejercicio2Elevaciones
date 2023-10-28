using Ejercicio2Elevado.Servicios;

namespace Ejercicio2Elevado
{
    /// <summary>
    /// Clase principal
    /// msm - 281023
    /// </summary>
    class program
    {
        /// <summary>
        /// Metodo main, contiene el el procedimiento de la aplicacion
        /// msm - 281023
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            
            //Variables
            double n1;
            int n2;
            double resultado;

            //Objetos
            NumeroInterfaz num = new NumeroImplementacion();
            OperacionInterfaz op = new OperacionImplementacion();

            //Metodos
            n1 = num.solicitudNumero(0);
            n2 = Convert.ToInt32(num.solicitudNumero(1));
            op.Operacion(n1,n2);





        }
    }
}