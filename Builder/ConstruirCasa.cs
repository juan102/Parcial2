using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public abstract class ConstruirCasa
    {
        protected Casa casa;



        public void nuevo() { casa = new Casa(); }

        public Casa obtenerCasa() { return casa; }



        public abstract void construirCocina();

        public abstract void construirBaño();

    }
}
