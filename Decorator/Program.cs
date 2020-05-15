using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Computador gammerPC = new ComputadorBase();
           
            gammerPC = new FastSSD(gammerPC);
            gammerPC = new ProcesadorGrande(gammerPC);

            var cost = gammerPC.CalcularCosto();

            Console.WriteLine(string.Format("El Coste del Gammer PC es de {0} euros", cost));


        }
    }
}
