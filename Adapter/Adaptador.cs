using System;
using System.Collections.Generic;
using System.Text;

namespace Adaptaer
{
     public class Adaptador : Itarget
    {
        
        CcalcuArray CcalcuArray = new CcalcuArray();
       
        public int Multiplicar(int a, int b)
        {
            double r = 0;
            
            int[] operadores = { a, b };
            
            r = CcalcuArray.Multiplicar(operadores);
            
            return (int)r;
        }
    }
}
