﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumbledSetOfCard
{

    enum Suits : int { Spades = 0, Clubs = 1, Diamonds = 2, Hearts = 3 };
    enum Values : int { Ace = 1, Two = 2, Three = 3, Four = 4, Five = 5, Six = 6, Seven = 7, Eigth = 8, Nine = 9, Ten = 10, Jack = 11, Queen = 12, King = 13 };

    class Card
    {
        public Suits Suit { get; set; }
        public Values Value { get; set; }

        public Card(int suit, int value)
        {
            Suit = (Suits)suit ;
            Value = (Values)value ; 
        }

        public string Name
        {
            get { return Value.ToString() + " of " + Suit.ToString(); }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
