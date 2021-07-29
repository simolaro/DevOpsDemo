using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardDecks
{
    class Deck
    {
        private List<Card> cards;
        private Random random = new Random();

        public Deck()
        {
            cards = new List<Card>();
            for (int suit = 0; suit <= 3; suit++)
                for (int value = 1; value <= 13; value++)
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
            // this method shuffles the cards by rearranging them in a random order 
            List<Card> newCards = new List<Card>() ;
            Random random = new Random();

            while (cards.Count > 0)
            {
                int CardToMove = random.Next(cards.Count);
                newCards.Add(cards[CardToMove]);
                cards.RemoveAt(CardToMove);
            }
            cards = newCards;
        }

        public IEnumerable<String> GetCardNames()
        {
            string[] CardNames = new string[cards.Count] ;

            // get the cards names
            for(int i = 0; i < cards.Count; i++) { CardNames[i] = cards[i].Name; }

            // this method returns a string array that contains each card's name
            return CardNames; 
        }

        public void Sort()
        {
            //cards.Sort(new CardComparer_bySuit());
        }

    }
}
