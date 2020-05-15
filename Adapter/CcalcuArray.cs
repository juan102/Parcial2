using System;
using System.Collections.Generic;
using System.Text;

namespace Adaptaer
{
    public class CcalcuArray
    {
        
        public double Multiplicar(int[] operandos)
        {
            int n = 0;
            int r = 0;
            for (n=0;n<operandos.Length;n++)
            {
                r *= operandos[n];
            }
            return r;
        }
    }
}
