using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExploreTheHouse
{
    public partial class Form1 : Form
    {
        private string currentLocation;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }

        public void MoveToANewLocation(string location)
        {
            currentLocation = location;
            comboBox1.Items.Clear();

        }
     
    }
}
