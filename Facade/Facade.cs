using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class Facade 
    {
        Impresora impresora;
        public Facade(String texto)
        {
            
            impresora = new Impresora();
            impresora.color=true;
            impresora.hoja="A4";
            impresora.TipoDocumento="PDF";
            impresora.texto= texto;
        }

        public void imprimir()
        {

            impresora.Imprimir();
        }
    }
}
