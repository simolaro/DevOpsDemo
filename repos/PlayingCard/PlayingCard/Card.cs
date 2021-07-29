using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingCard
{
    class Card
    {
        public Enum Suit { get; set; } 
        public Enum Value { get; set; }
        public string Name { get; }

        private enum Suits:int {Spades=0, Clubs=1, Diamonds=2, Hearts=3};
        private enum Values:int {Ace=1, Two=2, Three = 3, Four = 4, Five = 5, Six = 6, Seven = 7, Eigth = 8, Nine = 9, Ten = 10, Jack = 11, Queen = 12, King = 13 };
 


        public Card(int suit, int value)
        {
            Name = (Suits)suit + " of " + (Values)value ;
        }
    }
}
