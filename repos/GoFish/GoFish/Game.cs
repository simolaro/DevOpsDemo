using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoFish
{
    class Game
    {
        private List<Player> players;
        private Dictionary<Values, Player> books;
        private Deck stock;
        private TextBox textBoxOnForm; 

        public Game(string playerName, IEnumerable<string> opponentNames, TextBox textBoxOnForm)
        {
            Random random = new Random();
            this.textBoxOnForm = textBoxOnForm;
            players = new List<Player>();
            players.Add(new Player(playerName, random, textBoxOnForm));
            foreach (string player in opponentNames)
                players.Add(new Player(player, random, textBoxOnForm));

            books = new Dictionary<Values, Player>();

            //Player emptyPlayer = new Player(" ", random, textBoxOnForm);
            //for (int i = 1; i < 14 ; i++){ books.Add((Values)i, emptyPlayer); }
           
            stock = new Deck();
            Deal();
            players[0].SortHand();
        }
        private void Deal()
        {
            //IEnumerable<Card> initialCards ;

            // This is where the game starts-this method's only called at the beginning
            // of the game. Shuffle the stock, deal five cards to each player, then use a 
            // foreach loop to call each player's PullOutBooks() method. 
            
            // Shuffle the stock
            stock.Shuffle();

            // Deal 5 cards to each player
            for (int i = 0; i < 3; i++)
            {
                for (int x = 0; x < 5; x++) { players[i].TakeCard(stock.Deal(1)); }
                //for (int x = 0; x < 5; x++) { initialCards[x] = stock.Deal(1); }
            }
        }

        internal IEnumerable<string> GetPlayerCardNames()
        {
            return players[0].GetCardNames(); 
        }

        public bool PlayOneRound(int selectedPlayerCard)
        {
            // Play one round of the game. 
            // The parameter is the card the player selected from his hand-get its value.
            Card cardName = players[0].Peek(selectedPlayerCard);
            Values selectedCard = cardName.Value;

            // Then go through all of the players and call 
            // each one's AskForACard() methods, starting with the human player (who's
            // at index zero in the Players list-make sure he asks for the selected
            // card's value). Then call PullOutBooks() - if it returns true, then the 
            // Player ran out of cards and needs to draw e new hand. After all the players 
            // have gone, sort the human player's hand (so it looks nice in the form). 
            // Then check the stock to see if it's out of cards. If it is, reset the 
            // TextBox on the form to say, "The stock is out of cards. Game over!" and return
            // true. Otherwise, the game isn't over yet, so return false. 
            foreach (Player aPlayer in players)
            {
                // ??? comment on fait pour savoir que c'est le joueur 0 ???
                if (aPlayer.Name == Form1._Form1.getTextName())
                { aPlayer.AskForACard(players, selectedPlayerCard, stock, selectedCard); }
                else aPlayer.AskForACard(players, selectedPlayerCard, stock, selectedCard);
            }
            return true; 
        }

        public bool PullOutBooks(Player player)
        {
            return true;
            // Pull out a player's books. Return trueif the player ran out of cards, otherwise
            // return false. Each book is added to the Books dictionary. Aplayer runs out of 
            // cards when he's used all of ths cards to make books-and he wins the game. 
        }

        public string DescribeBooks()
        {

            // Return a long string that describes everyone's books by looking at the Books
            // dictionary: "Joe ahs a book of sixes. (line break) Ed has a book of Aces. "

            // Player result;
            String stringResult = null; 
            if (books.Count > 0)
            {            
                for (int i = 1; i < books.Count; i++)
                {
                    stringResult += books[books.Keys.ElementAt(i)] + " has a book of " + (Values)i + Environment.NewLine;
                    //books.TryGetValue((Values)i, out result);
                    //if (result.Name != " ")
                    //{
                    //    stringResult += result.Name + " has a book of " + (Values)i + Environment.NewLine;  
                    //}
                }
            }
            return stringResult;
        }

        public string GetWinnerName()
        {
            return "return";
            // This method is called at the end of the game. It uses its own dictionary 
            // (Dictionary < string, int > winners) to keep track of how many books each player 
            // ended up with in the books dictionary. First it uses a foreach loop 
            // on books.Keys— foreach (Values value in books.Keys)— to populate 
            // its winners dictionary with the number of books each player ended up with. 
            // Then it loops through that dictionary to find the largest number of books 
            // any winner has. And finally it makes one last pass through winners to come 
            // up with a list of winners in a string (" Joe and Ed"). If there's one winner, 
            // it returns a string like this: "Ed with 3 books". Otherwise, it returns a 
            // string like this: "A tie between Joe and Bob with 2 books." 
        } 

        public string DescribePlayerHands() 
        {
            string description = "";
            for (int i = 0; i < players.Count; i ++)
            {
                description += players[i]. Name + " has " + players[i]. CardCount;
                if (players[i].CardCount == 1)
                    description += " card." + Environment.NewLine;
                else
                    description += " cards." + Environment.NewLine;
            }
            description += "The stock has " + stock.Count + " cards left.";
            return description;
        }
            
    }
}
