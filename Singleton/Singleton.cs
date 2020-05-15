using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public class Singleton
    {
        private static Singleton instancia = null;
        private Singleton()
        {

        }

        public static Singleton GetSingleton()
        {
            if (instancia == null)
            {
                instancia = new Singleton();
                throw new InvalidOperationException("El objeto ha sido creado");
            }
            else
            {
                throw new InvalidOperationException("Ya existe el objeto");
            }
            //return instancia;
        }
    }
}
