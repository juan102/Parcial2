using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Ingrediente Ingrediente1 = new Ingrediente("carne", 200, 20, "kilos");
            Ingrediente Ingrediente2 = new Ingrediente("tortillas bimbo", 20, 2, "");

            TacosComposite Tacos = new TacosComposite("Tacos De Carne");
            Tacos.Add(Ingrediente1);
            Tacos.Add(Ingrediente2);
            Console.WriteLine(Tacos.CostoTotal);
        }
    }
}
