﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsStrategy
{
    class CashNormal:CashSuper
    {
        public override double acceptCash(double money)
        {
            return money;
        }
    }
}
