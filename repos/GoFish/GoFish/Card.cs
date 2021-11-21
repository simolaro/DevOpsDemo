using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFish
{

    enum Suits : int { Spades = 0, Clubs = 1, Diamonds = 2, Hearts = 3 };
    enum Values : int { Ace = 1, Two = 2, Three = 3, Four = 4, Five = 5, Six = 6, Seven = 7, Eigth = 8, Nine = 9, Ten = 10, Jack = 11, Queen = 12, King = 13 };

    class Card
    {
        public Suits Suit { get; set; }
        public Values Value { get; set; }

        public Card(Suits suit, Values value)
        {
            Suit = (Suits)suit;
            Value = (Values)value;
        }

        public string Name
        {
            get { return Value.ToString() + " of " + Suit.ToString(); }
        }

        public override string ToString()
        {
            return Name;
        }

        public static bool DoesCardMatch(Card cardToCheck, Suits suit)
        {
            if (cardToCheck.Suit == suit) return true;
            else return false;
        }

        public static bool DoesCardMatch(Card cardToCheck, Values value)
        {
            if (cardToCheck.Value == value) return true;
            else return false;
        }
        public static string Plural(Values value)
        {
            if(value == Values.Six) return "Sixes";
            else return value.ToString() + "s";
        }
    }
}
