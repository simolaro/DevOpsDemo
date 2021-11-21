using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoFish
{
    class Player
    {
        private string name; 
        public string Name { get { return name; } }
        private Random random;
        private Deck cards;
        private TextBox textBoxOnForm; 

        public Player(String inName, Random inRandom, TextBox inTextBoxOnForm)
        {
            // The constructor for the Player class initializes four private fields, and then
            // add a line to the TextBox control on the form that says, "Joe Has just
            // joined the game"-but use the name in the private field, and don't forget to 
            // add a line break at the end of every line you add to the TextBox.
            this.name = inName;
            this.textBoxOnForm = inTextBoxOnForm;
            this.random = inRandom;

            //IEnumerable<Card> initialCards = null;
            this.cards = new Deck(new Card[] { });

            inTextBoxOnForm.Text = inTextBoxOnForm.Text + inName + " has just joined the game " + Environment.NewLine ;
        }

        public IEnumerable<Values> PullOutBooks()
        {
            List<Values> books = new List<Values>();
            for (int i =1; i<=13; i++)
            {
                Values value = (Values)i;
                int howMany = 0;
                for (int card = 0; card < cards.Count; card++)
                    if (cards.Peek(card).Value == value) howMany++;
                if (howMany == 4)
                {
                    books.Add(value);
                    cards.PullOutValues(value);
                }
            }
            return books;
        } 
        //public Values GetRandomValue()
        //{
            // This method gets a random value-but it has to be a value that's in the deck!

        //}
        public Deck DoYouHaveAny(Values value)
        {
            // This is where an opponent asks if I have any cards of a certain value
            // Use Deck.PullOutValues() to pull out the values. Add a line to the TextBox
            // that says, "Joe has 2 sixes"-use the new Card"Plural() static method
            Deck deckToReturn; 
            deckToReturn = cards.PullOutValues(value);
            Form1._Form1.updateTextProgress(this.Name + " ask " + Card.Plural(value) + " " + value);

            // retourner les cartes extraites
            return deckToReturn;
        }

        public void AskForACard(List<Player> players, int myIndex, Deck stock)
        {
            // Utiliser pour les joueur du PC
            // Here's an overloaded version of AskForACard()- choose a rendom value
            // from the deck using GetRandomValue() and ask form it using AskFroACard()
        }

        public void AskForACard(List<Player> players, int myIndex, Deck stock, Values value)
        {
            // Ask the other players for a value. 
            // First add a line to the TextBox: "Joe asks if anyone has a Queen'. 
            Form1._Form1.updateTextProgress(this.Name + " ask if anyone has a " + value);

            // Then go through the list of players that was passed in 
            // as a parameter and ask each player if he has any of the value (using his 
            // DoYouHaveAny() method). 
            foreach(Player player in players)
            {
                player.DoYouHaveAny(value);
            }
            
            // He'll pass you a deck of cards-add them to my deck. 
            // Keep track of how many cards were added. If there weren't any, you'll need
            // to deal yourself a card from the stock (which was also passed as a parameter),
            // ans you'll have to add a line to the TextBox: "Joe had to draw from the stock"


        }
        // Here's a property and a few short methods that were already written for you
        public int CardCount { get { return cards.Count; } }
        public void TakeCard(Card card) { cards.Add(card); }
        public IEnumerable<String> GetCardNames() { return cards.GetCardNames(); }
        public Card Peek(int cardNumber) { return cards.Peek(cardNumber); }
        public void SortHand() { cards.SortByValue(); }
        //{

        //}
    }
}
