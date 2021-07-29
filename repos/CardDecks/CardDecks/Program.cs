using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardDecks
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DeckOfCard());

           
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
