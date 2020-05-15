using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class EstrategiaInvitarCerveza : IBorracho
    {
        public void Conquistar()
        {
            throw new InvalidOperationException("Invito cerveza");
        }
    }
}
