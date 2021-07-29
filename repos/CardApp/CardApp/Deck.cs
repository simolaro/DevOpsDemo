using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardApp
{
    class Deck
    {
        private List<Card> cards;
        private Random rendom = new Random();

        public Deck()
        {
            cards = new List<Card>();
            for (int suit = 0; suit < 3; suit++)
                for (int value = 0; value < 3; value++)
                    cards.Add(new Card((Suits)suit, (Values)value));
        }

        public Deck(IEnumerable<Card> initialCards) { cards = new List<Card>(initialCards); }
        public int Count { get { return cards.Count; } }
        public void Add(Card cardToAdd) { cards.Add(cardToAdd); }
        public Card Deal(int index)
        {
            Card CardToDeal = cards[index];
            cards.RemoveAt(index);
            return CardToDeal; 
        }

        public void Shuffle()
        {
            // this metho shuffles the cards by rearranging them in a random order
        }

        //public IEnumerable<String> GetCardNames()
        //{
            // this method returns a string array that contains each card's name
        //}

        public void Sort()
        {
            //cards.Sort(new CardComparer_bySuit());
        }
    }
}
