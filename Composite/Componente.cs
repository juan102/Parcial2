using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public abstract  class Componente
    {
        public string Nombre { get; set; }
        public decimal Costo { get; set; }

        public Componente(string Nombre, decimal Costo)
        {
            this.Nombre = Nombre;
            this.Costo = Costo;
        }
    }
}
