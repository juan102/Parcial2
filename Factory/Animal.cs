using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public abstract class Animal
    {
        public int Pata { get; set; }
        public string Nombre { get; set; }
        public abstract void HacerRuido();
    }
}
