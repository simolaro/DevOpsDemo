using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcuseManager
{
    public partial class Form1 : Form
    {
        Excuse currentExcuse = new Excuse();
        private bool formChanged;

        public Form1()
        {
            InitializeComponent();
            currentExcuse.LastUsed = lastUsed.Value;
        }

        private void folderButton_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();

            openFileDialog1.InitialDirectory = folderBrowserDialog1.SelectedPath;

            if (!(openFileDialog1.InitialDirectory == " "))
            {
                // si un folder a été sélectionné
                saveButton.Enabled = true;
                openButton.Enabled = true;
                randomButton.Enabled = true;
            }
             
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // Vérifier si le fichier existe déjà
            if (File.Exists(currentExcuse.ExcusePath))
            {
                // rafraichir l'objet avec les données de l'écran
                // Mettre à jour les champs de l'EXCUSE
                currentExcuse.Description = description.Text;
                currentExcuse.Results = results.Text;
                currentExcuse.LastUsed = lastUsed.Value;

                // Utiliser les fonctions de la classe Excuse
                currentExcuse.Save(currentExcuse.ExcusePath);
                //saveFileDialog1.FileName = saveFileDialog1.FileName.Replace(")", "");
                //currentExcuse.Save(saveFileDialog1.FileName);

                // Enlever le '*' de l'entête 
                this.Text = this.Text.Replace("*", "");
                currentExcuse.formChanged = false;
            }

            else {  

                saveFileDialog1 = new SaveFileDialog(); 
                saveFileDialog1.InitialDirectory = openFileDialog1.InitialDirectory;
                saveFileDialog1.Filter = "Text Files (*.txt)|(*.txt)|" + "Comma-Delimited Files (*.csv)|*.csv|All Files (*.*)|*.*";
                saveFileDialog1.FileName = description.Text;
                DialogResult resultD = saveFileDialog1.ShowDialog();

                if (resultD == DialogResult.OK)
                {
                    // Mettre à jour les champs de l'EXCUSE
                    currentExcuse.Description = description.Text;
                    currentExcuse.Results     = results.Text;
                    currentExcuse.LastUsed = DateTime.Now ;

                    // Utiliser les fonctions de la classe Excuse
                    saveFileDialog1.FileName = saveFileDialog1.FileName.Replace(")", "");
                    currentExcuse.Save(saveFileDialog1.FileName);

                    // Enlever le '*' de l'entête 
                    this.Text = this.Text.Replace("*", "");
                    currentExcuse.formChanged = false;

                }
            }


        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void currentExcuse_TextChanged(object sender, EventArgs e)
        {
            String strText = this.Text.ToString();
            int position = strText.IndexOf('*');

            if ( position == -1) { 
                this.Text += " *";
                saveButton.Enabled = true;
                currentExcuse.formChanged = true;
            }
           
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = folderBrowserDialog1.SelectedPath;
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            DialogResult resultMB = System.Windows.Forms.DialogResult.Yes;

            // The current excuse is not saved
            if (currentExcuse.formChanged)
            {
                resultMB = MessageBox.Show("The current excuse has not been saved. Continue ?", "Question", MessageBoxButtons.YesNo); 
            }

            if (resultMB == System.Windows.Forms.DialogResult.Yes)
            { 

                openFileDialog1.Filter = "Text Files (*.txt)|(*.txt)|" + "Comma-Delimited Files (*.csv)|*.csv|All Files (*.*)|*.*";
                openFileDialog1.FileName = "*.txt";
                openFileDialog1.CheckFileExists = true;
                openFileDialog1.CheckPathExists = false;
                DialogResult result = openFileDialog1.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // Utiliser les fonctions de la classe Excuse
                    saveFileDialog1.FileName = openFileDialog1.FileName.Replace(")", "");
                    currentExcuse.OpenFile(openFileDialog1);
                    // Excuse currentExcuse = new Excuse(openFileDialog1);
                    UpdateForm(false);

                }
            }

        }

        private void UpdateForm(bool changed)
        {
            if (!changed)
            {
                this.description.Text = currentExcuse.Description;
                this.results.Text = currentExcuse.Results;
                this.lastUsed.Value = currentExcuse.LastUsed;

                if (!String.IsNullOrEmpty(currentExcuse.ExcusePath))
                    fileDate.Text = File.GetLastWriteTime(currentExcuse.ExcusePath).ToString();
                this.Text = "Excuse Manager";

                currentExcuse.formChanged = changed;
            }
            else
            { 
                this.Text = "Excuse Manager *";
                currentExcuse.formChanged = true;
            }

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void result_TextChanged(object sender, EventArgs e)
        {
            String strText = this.Text.ToString();
            int position = strText.IndexOf('*');

            if (position == -1)
            {
                this.Text += " *";
                saveButton.Enabled = true;
                currentExcuse.formChanged = true;
            }

        }

        private void lastUsed_ValueChanged(object sender, EventArgs e)
        {
            String strText = this.Text.ToString();
            int position = strText.IndexOf('*');

            if (position == -1)
            {
                this.Text += " *";
                saveButton.Enabled = true;
            }

        }

        private void randomButton_Click(object sender, EventArgs e)
        {
            //Excuse currentExcuse = new Excuse();
            DialogResult resultMB = System.Windows.Forms.DialogResult.Yes;

            // The current excuse is not saved
            if (currentExcuse.formChanged)
            {
                resultMB = MessageBox.Show("The current excuse has not been saved. Continue ?", "Question", MessageBoxButtons.YesNo);
            }

            if (resultMB == System.Windows.Forms.DialogResult.Yes)
            {
                // Create a list of excuses
                var rand = new Random();
                //OpenFileDialog openFileDialog1 = new OpenFileDialog();
                var files = Directory.GetFiles(openFileDialog1.InitialDirectory, "*.*");
                if (files.Length > 0 ) { 

                    // Ramdomly select an excuse
                    openFileDialog1.FileName = files[rand.Next(files.Length)];

                    // Open the excuse selected
                    currentExcuse.OpenFile(openFileDialog1);

                    UpdateForm(false);
                }
            }

        }
    }
}
