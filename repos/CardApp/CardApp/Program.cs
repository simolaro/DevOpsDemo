using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rendom = new Random();
            List<Card> deck1 = new List<Card>();
            List<Card> deck2 = new List<Card>();

            // Fill deck # 1 wigth 10 cards
            for (int i = 0; i<10; i++)
            {
                deck1.Add(new Card((Suits)rendom.Next(9), (Values)rendom.Next(1, 14)));
            }

            // Fill deck # 2 wigth 10 cards
            for (int i = 0; i < 52; i++)
            {
                deck2.Add(new Card((Suits)rendom.Next(9), (Values)rendom.Next(1, 14)));
            }

            //Card cardToCheck = new Card(Suits.Clubs, Values.Three);
            //bool doesItMatch = Card.DoesCardMatch(cardToCheck, Suits.Hearts);
            //Console.WriteLine(doesItMatch);
        }


        //private void RedrawDeck(int DeckNumber)
        //{
        //    if (DeckNumber == 1)
        //    {
        //        listBox1.Items.Clear();
        //        foreach (string cardName in deck1.GetCardNames())
        //            listBox1.Items.Add(cardName);
        //        label1.Text = "Deck #1 (" + deck1.Count + "cards)";
        //    }
        //    else
        //    {
        //        listBox2.Items.Clear();
        //        foreach (string cardName in deck2.GetCardNames())
        //            listBox2.Items.Add(cardName);
        //        label2.Text = "Deck #2 (" + deck2.Count + "cards)";
        //    }
        //}
    }
}
