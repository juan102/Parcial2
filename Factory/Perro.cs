using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public class Perro : Animal
    {
        public override void HacerRuido()
        {
            throw new InvalidOperationException("Guaaauu Guaauuu");
        }
    }
}
