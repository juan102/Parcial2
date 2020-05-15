using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public class TacosComposite:Componente
    {
        private List<Componente> ingredientes = new List<Componente>();

        public TacosComposite(string Nombre, decimal Costo = 0) : base(Nombre, Costo)
        {
        }

        public decimal CostoTotal
        {
            get
            {
                decimal costo = 0;
                foreach (var Elemento in ingredientes)
                {
                    if (Elemento.GetType().Name == "TacosComposite")
                        costo += ((TacosComposite)Elemento).CostoTotal;
                    else
                        costo += Elemento.Costo;
                }

                return costo;

            }
        }

        public void Add(Componente Elemento)
        {
            ingredientes.Add(Elemento);
        }

        public void Remove(Componente Elemento)
        {
            ingredientes.Remove(Elemento);
        }

       
    }
}
