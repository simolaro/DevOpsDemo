using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyPlanner
{
    class DinnerParty
    {
        //public int NumberOfPeople;
        //public decimal CostOfBeveragesPerPerson;
        //public decimal CostOfDecoration;

        public const int CostOfFoodPerPerson = 25 ;

        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
        public bool HealthyOption { get; set; }
        public decimal Cost {
            get {
                decimal totalCost = CalculateCostOfDecorations();
                totalCost += ((CalculateCostOfBeveragesPerPerson() + CostOfFoodPerPerson) *
                    NumberOfPeople);

                if (HealthyOption) { totalCost *=  .95M; }

                return totalCost;
            } }

        //public void SetHealthyOption(bool healthyOption)
        //{
        //    if (HealthyOption) { CostOfBeveragesPerPerson = 5.00M; }
        //    else               { CostOfBeveragesPerPerson = 20.00M; }
        //}

        private decimal CalculateCostOfDecorations()
        {
            decimal costOfDecorations;

            if (FancyDecorations) { costOfDecorations = (NumberOfPeople * 15.00M) + 50M; }
            else                       { costOfDecorations = (NumberOfPeople * 7.50M) + 30M ; }

            return costOfDecorations;
        }

        public decimal CalculateCostOfBeveragesPerPerson()
        {
            decimal costOfBeveragesPerPerson = 0;

            if (HealthyOption ) { costOfBeveragesPerPerson = 5.00M ; }
            else                { costOfBeveragesPerPerson = 20.00M; }

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
