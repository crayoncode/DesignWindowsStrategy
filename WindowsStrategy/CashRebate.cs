﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsStrategy
{
    class CashRebate:CashSuper
    {
        private double moneyRebate = 1d;

        public CashRebate(string moneyRebate)
        {
            this.moneyRebate = double.Parse(moneyRebate);
        }

        public override double acceptCash(double money)
        {
            return money * moneyRebate;
        }
    }
}
