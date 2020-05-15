using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = Fabrica.Factory(Fabrica.ANIMAL.PERRO);
            animal.HacerRuido();
        }
    }
}
