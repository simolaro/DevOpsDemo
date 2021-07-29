using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumbledSetOfCard
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of 5 random cards
            Random random = new Random();
            List<Card> cards = new List<Card>
            {
                new Card(random.Next(4), random.Next(1,14)),
                new Card(random.Next(4), random.Next(1,14)),
                new Card(random.Next(4), random.Next(1,14)),
                new Card(random.Next(4), random.Next(1,14)),
                new Card(random.Next(4), random.Next(1,14)),
            };

            Console.WriteLine("Five Random cards:");
            PrintCards(cards);

            Console.WriteLine("Those same cards, sorted:");
            CardComparer_byValue cardComparer = new CardComparer_byValue();
            cards.Sort(cardComparer);
            PrintCards(cards);
            Console.ReadKey();

        }

        public static void PrintCards(List<Card> cards)
        {
            foreach (Card card in cards)
                Console.WriteLine(card.Name);
            Console.WriteLine("End of cards!");
        }
    }
}
