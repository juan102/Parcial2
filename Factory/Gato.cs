using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public class Gato : Animal
    {
        public override void HacerRuido()
        {
            throw new InvalidOperationException("Miauu Miauuuu");
        }
    }
}
