﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beehive
{
    public partial class Form1 : Form
    {
        private Queen queen;

        public Form1()
        {
            InitializeComponent(); 

            Worker[] workers = new Worker[4];
            workers[0] = new Worker(new string[] { "Nectar collector", "Honey manufacturing" });
            workers[1] = new Worker(new string[] { "Egg care", "Baby bee tutoring" });
            workers[2] = new Worker(new string[] { "Hive maintenance", "Sting patrol" });
            workers[3] = new Worker(new string[] { "Nectar collector", "Honey manufacturing", "Egg care",
                "Baby bee tutoring", "Hive maintenance", "Sting patrol" });

            queen = new Queen(workers);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void assignJob_Click(object sender, EventArgs e)
        {
            if(queen.AssignWork(workerBeeJob.Text, Decimal.ToInt32(shifts.Value) ) == true)
            {
                MessageBox.Show("The job '" + workerBeeJob.Text + "' will be done in " + shifts.Value + " shifts");
            }
            else
            {
                MessageBox.Show("There are no bees available to do this job.");
            }
        }

        private void nextShift_Click(object sender, EventArgs e)
        {
            report.Text=queen.WorkTheNextShift(report.Text );
        }
    }
}
