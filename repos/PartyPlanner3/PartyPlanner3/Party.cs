﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyPlanner3
{
    class Party
    {
        public const int CostOfFoodPerPerson = 25;

        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }

        virtual public decimal Cost
        {
            get
            {
                decimal totalCost = CalculateCostOfDecorations();
                if(NumberOfPeople > 12) { totalCost += 100; }
                return totalCost;
            }
        }

        private decimal CalculateCostOfDecorations()
        {
            decimal costOfDecorations;
            if (FancyDecorations) costOfDecorations = (NumberOfPeople * 15.00M) + 50M;
            else costOfDecorations = (NumberOfPeople * 7.50M) + 30M;

            return costOfDecorations;
        }
    }
}
