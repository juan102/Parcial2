﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public class ComputadorBase : Computador
    {
        public override decimal CalcularCosto()
        {
            return 0M;
        }
    }
}
