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
            // foreach (Player aPlayer in players)
            for (int i = 0; i<players.Count; i++)
            {
                if (players[i].Name == players[0].Name)
                    { players[i].AskForACard(players, selectedPlayerCard, stock, selectedCard); }
                else players[i].AskForACard(players, i, stock);

                // Then call PullOutBooks() - if it returns true, then the
                // Player ran out of cards and needs to draw e new hand. 
                if (this.PullOutBooks(players[i]))
                {
                    for (int x = 0; x < 5 ;)
                    {
                        if (stock.Count > 0)
                        {
                            players[x].TakeCard(stock.Deal(0));
                        }
                        else
                        {
                            // Then check the stock to see if it's out of cards. If it is, reset the 
                            // TextBox on the form to say, "The stock is out of cards. Game over!" and return
                            // true. Otherwise, the game isn't over yet, so return false. 
                            // foreach (Player aPlayer in players)
                            textBoxOnForm.ResetText();
                            textBoxOnForm.Text = "The stock is out of cards. Game over!" + Environment.NewLine;
                           
                            return true;

                        }
                    }
                    
                } 

            }


            //After all the players 
            // have gone, sort the human player's hand (so it looks nice in the form). 
            players[0].SortHand();

            
            return false; 
        }

        public bool PullOutBooks(Player player)
        {
            IEnumerable<Values> booksToAdd = new List<Values>();

            // Pull out a player's books.    
            booksToAdd =  player.PullOutBooks();

            // Each book is added to the Books dictionary.
            foreach(Values bookToAdd in booksToAdd)
            {
                books.Add(bookToAdd, player);
            }

            // Return true if the player ran out of cards, otherwise return false.
            if (player.CardCount == 0)
            {
                // Aplayer runs out of cards when he's used all of ths cards
                // to make books-and he wins the game.

                return true;
            }
            else return false; 
        }

        public string DescribeBooks()
        {

            // Return a long string that describes everyone's books by looking at the Books
            // dictionary: "Joe ahs a book of sixes. (line break) Ed has a book of Aces. "
            Player player;

            // Player result;
            String stringResult = null; 
            if (books.Count > 0)
            {
                for (int i = 0; i < books.Count; i++)
                {

                    //stringResult += books[i].Name + " has a book of " + (Values)i + Environment.NewLine;
                    player = books[books.Keys.ElementAt(i)];
                    stringResult += player.Name + " has a book of " + books.Keys.ElementAt(i) + Environment.NewLine;
                    //stringResult += books[books.Keys.ElementAt(i)].Name + " has a book of " + (Values)i + Environment.NewLine;
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
            int maxBooks = 0;
            string returnString = " ";
            int winnersCount = 0;

            // This method is called at the end of the game. It uses its own dictionary 
            // (Dictionary < string, int > winners) to keep track of how many books each player 
            // ended up with in the books dictionary. 
            Dictionary<string, int> winners = new Dictionary<string, int>();
            foreach(Player player in players) { winners.Add(player.Name, 0); }

            // First it uses a foreach loop 
            // on books.Keys— foreach (Values value in books.Keys)— to populate 
            // its winners dictionary with the number of books each player ended up with. 
            foreach (KeyValuePair<Values, Player> book in books)
            {
                winners[book.Value.Name] = winners[book.Value.Name] +1;
            }
            // Then it loops through that dictionary to find the largest number of books 
            // any winner has. 
            foreach (KeyValuePair<string, int> winner in winners)
            {
                if (maxBooks < winner.Value) { maxBooks = winner.Value; }
            }

            // And finally it makes one last pass through winners to come 
            // up with a list of winners in a string (" Joe and Ed"). 
            foreach (KeyValuePair<string, int> winner in winners)
            {
                if (maxBooks == winner.Value)
                {
                    if (returnString == " ") { returnString = winner.Key; }
                    else { returnString = returnString + " and " + winner.Key; }
                    winnersCount += 1;
                }
            }

            // If there's one winner, 
            // it returns a string like this: "Ed with 3 books". Otherwise, it returns a 
            // string like this: "A tie between Joe and Bob with 2 books." 
            if (winnersCount == 1) { returnString = returnString + " with " + maxBooks + " books" + Environment.NewLine; }
            else { returnString = "A tie between " + returnString + " with " + maxBooks + " books" + Environment.NewLine; }

            return returnString;
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
