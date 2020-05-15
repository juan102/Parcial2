using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class Inmobiliaria
    {
        private ConstruirCasa Construircasa;
        public void establecerConstructor(ConstruirCasa cc) { this.Construircasa = cc; }

        public Casa obtenerCasa() => Construircasa.obtenerCasa(); 



        public void construirCasa()

        {

            Construircasa.nuevo();

            Construircasa.construirBaño();

            Construircasa.construirCocina();
            throw new InvalidOperationException("Casa Construida");
        }

    }
}
