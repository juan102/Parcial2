using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class ComputadorFalso : Computador
    {
        private decimal processor = 56.00M;
        private decimal hdd = 30.00M;
        private decimal graphics = 41.99M;
        private decimal ram = 23.50M;
        public override decimal CalcularCosto()
        {
            var cost = this.processor + this.hdd + this.graphics + this.ram;

            return cost;
        }
    }
}
