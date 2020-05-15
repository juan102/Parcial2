using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class EstrategiasOjitos : IBorracho
    {
        public void Conquistar()
        {
            throw new InvalidOperationException("Le Hago Ojitos A La Muchacha");
        }
    }
}
