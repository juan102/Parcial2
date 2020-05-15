using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class FastSSD : Decorador
    {
        private Computador ComputadorActual;

        public FastSSD(Computador computador)
        {
            this.ComputadorActual = computador;
        }
        public override decimal CalcularCosto()
        {
            return this.ComputadorActual.CalcularCosto() + 255.20M;
        }
    }
}
