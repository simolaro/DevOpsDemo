using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayingCard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int numberBetween0and3 = random.Next(4);
            int numberBetween1and14 = random.Next(1,14);

            Card card = new Card(numberBetween0and3, numberBetween1and14);
            textBox1.Text = card.Name;
        }
    }
}
