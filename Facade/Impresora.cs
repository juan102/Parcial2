using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class Impresora
    {
      

        public String hoja { get; set; }
        public Boolean color { get; set; }
        public String texto { get; set; }
        public String TipoDocumento { get; set; }


        public void Imprimir()
        {
            throw new InvalidOperationException("imprimiendo:" + texto + ",color:"
        + color + ",tipo:" + TipoDocumento + ",hoja :" + hoja);
        }
    }
}
