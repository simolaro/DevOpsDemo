using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farmer
{
    class Farmer
    {
        // public const int FeedMultiplier = 30 ;
        private int numberOfCows;
        private int bagsOfFeed;
        private int feedMultiplier;

        public int FeedMutiplier { get { return feedMultiplier; } }

        public int NumberOfCows
        {
            get { return numberOfCows; }
            set
            {
                numberOfCows = value;
                BagsOfFeed = numberOfCows * FeedMutiplier;
            }
        }

        public int BagsOfFeed { get; private set; }

        public Farmer(int numberOfCows, int feedMultiplier)
        {
            this.feedMultiplier = feedMultiplier;
            NumberOfCows = numberOfCows;
        }

    }
}
