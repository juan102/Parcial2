using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class ProcesadorGrande:Decorador
    {
        private Computador ComputadorActual;

        public ProcesadorGrande(Computador computer)
        {
            this.ComputadorActual = computer;
        }

        public override decimal CalcularCosto()
        {
            return this.ComputadorActual.CalcularCosto() + 120.00M;
        }
    }
}
