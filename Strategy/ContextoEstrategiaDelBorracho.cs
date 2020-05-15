using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class ContextoEstrategiaDelBorracho
    {
        private IBorracho oBorracho;
        public enum Comportamiento
        {
            HacerOjitos,
            InvitarCerveza
        }

        public ContextoEstrategiaDelBorracho()
        {
            this.oBorracho = new EstrategiasOjitos();
        }
      
        public void conquistar(Comportamiento opcion)
        {
            switch (opcion)
            {
                case (Comportamiento.HacerOjitos):
                    {
                        this.oBorracho = new EstrategiasOjitos();
                    }
                    break;
                case (Comportamiento.InvitarCerveza):
                {
                        this.oBorracho = new EstrategiaInvitarCerveza();
                }
                    break;
            }
            this.oBorracho.Conquistar();
        }
    }
}
