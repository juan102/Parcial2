using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class Construir2piso : ConstruirCasa
    {
        public override void construirBaño()
        {
            casa.CementoCantidad(4).LadrilloCantidad(1000).Techomaterial("Zins");
        }

        public override void construirCocina()
        {
            casa.CementoCantidad(5).LadrilloCantidad(1200);
            
        }
    }

    public class ConstruirCasa1piso : ConstruirCasa
    {
        public override void construirBaño()
        {
            casa.CementoCantidad(2).LadrilloCantidad(500).Techomaterial("Madera");
        }

        public override void construirCocina()
        {
            casa.CementoCantidad(3).LadrilloCantidad(700);
        }
    }
}
