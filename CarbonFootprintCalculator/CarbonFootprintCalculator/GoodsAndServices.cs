﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarbonFootprintCalculator
{
    class GoodsAndServices : Consumption
    {
        private const double GTPC = .0022;
        public double Category{get; set;}
        public GoodsAndServices(double amount, double cat)
            : base(amount)
        {
            Category = cat;
        }

        public override double getCarbonAmount()
        {
            return DollarsSpent * Category * 12 * GTPC;
        }
    }
}
