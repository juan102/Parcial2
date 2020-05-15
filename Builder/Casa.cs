using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class Casa
    {
        private int CantidadCemento = 0;

        private int CantidadLadrillo = 0;

        private string MaterialTecho= "";

        



        public Casa CementoCantidad(int cemento)

        {

            this.CantidadCemento = cemento;

            return this;

        }



        public Casa LadrilloCantidad(int ladrillo)

        {

            this.CantidadLadrillo = ladrillo;

            return this;

        }



        public Casa Techomaterial(String tipo)

        {

            this.MaterialTecho = tipo;

            return this;

        }


    }
}
