using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public class Fabrica
    {
        public enum ANIMAL{
            PERRO,
            Gato
        }

        public static Animal Factory(ANIMAL Tipo)
        {
            switch (Tipo)
            {
                case ANIMAL.PERRO:
                    return new Perro();
                case ANIMAL.Gato:
                    return new Gato();
                default: return null;

            }
        }
    }
}
