using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BreakfastForLumberjack
{
    public partial class Form1 : Form
    {
        private Stack<Lumberjack> breakfastLine = new Stack<Lumberjack>();
        private Lumberjack lumberjack;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lumberjack = new Lumberjack(this.lumberJackName.Text);
            breakfastLine.Push(lumberjack);
            lumberJackName.Clear();
            RedrawList();
            lumberJackName.Focus();

        }

        private void RedrawList()
        {
            line.Items.Clear();

            foreach (Lumberjack lumberjack in breakfastLine)
            {
                line.Items.Add(lumberjack.Name);
            }
        }

        private void addFlapjacks_Click(object sender, EventArgs e)
        {
            if (breakfastLine.Count == 0) return;
            Flapjack food;
            if (crispy.Checked == true)
                food = Flapjack.Crispy;
            else if (soggy.Checked == true)
                food = Flapjack.Soggy;
            else if (browned.Checked == true)
                food = Flapjack.Browned;
            else food = Flapjack.Banana;

            Lumberjack currentLumberjack = breakfastLine.Peek();
            currentLumberjack.TakeFlapjacks(food, (int)howMany.Value);
            ljBox.Text = currentLumberjack.Name + " has " + currentLumberjack.FlapJackCount + " flapjacks";

            RedrawList();
        }

        private void nextLumberjack_Click(object sender, EventArgs e)
        {
            Lumberjack currentLumberjack = breakfastLine.Pop() ;
            currentLumberjack.EatFlapjacks();
            RedrawList();
        }
    }
}
