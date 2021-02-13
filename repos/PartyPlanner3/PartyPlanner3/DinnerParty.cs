using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyPlanner3
{
    class DinnerParty:Party
    {
        public bool HealthyOption { get; set; }
        override public decimal Cost
        {
            get
            {
                decimal totalCost = base.Cost;
                //totalCost = CalculateCostOfDecorations();
                totalCost += ((CalculateCostOfBeveragesPerPerson() + CostOfFoodPerPerson) *
                    NumberOfPeople);

                if (HealthyOption) { totalCost *= .95M; }
                if (NumberOfPeople > 12) totalCost += 100.00M;

                return totalCost;
            }
        }

        public decimal CalculateCostOfBeveragesPerPerson()
        {
            decimal costOfBeveragesPerPerson = 0;

            if (HealthyOption) { costOfBeveragesPerPerson = 5.00M; }
            else { costOfBeveragesPerPerson = 20.00M; }

            return costOfBeveragesPerPerson;
        }

        public DinnerParty(int numberOfPeople, bool healthyOption, bool fancyDecorations)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            HealthyOption = healthyOption;
        }
    }
}