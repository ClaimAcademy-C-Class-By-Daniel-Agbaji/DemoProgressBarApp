using System;
using System.Windows.Forms;

namespace DemoProgressBarApp
{
    public partial class ProgressBarAppForm : Form
    {
        public ProgressBarAppForm()
        {
            InitializeComponent();
        }

        private void rdbProgressorArray_CheckedChanged(object sender, EventArgs e)
        {
            //<summary>
            //Create an array of numbers, then iterate through the array to display it's members
            //</summary>
            // Loop through the various range value for the progress and display the step
            progressBar1.Value = 0;
            for (int count = progressBar1.Minimum; count <= progressBar1.Maximum; count++)
            {
                progressBar1.PerformStep();
            }
            richTextBox1.Text = "";
            var counter = 1;

            while (counter<=5)
            {
                richTextBox1.Text += $"X={counter}\n";// Each time a new value is shown for the range, create a new line for the next
                counter++;
            }

        }

        private void rdbRegressorArray_CheckedChanged(object sender, EventArgs e)
        {
            //<Summary>
            //Do a reverse enginerring of what we already have in the rdbProgressorArray_CheckedChanged method
            //</Summary>
            progressBar1.Value = 0;
            for (int count = progressBar1.Minimum; count <= (progressBar1.Value=80); count++)
            {
                progressBar1.PerformStep();
            }
            richTextBox1.Text = "";
            var counter = 3;
            while (counter >= 1)
            {
                richTextBox1.Text += $"X={counter}\n";
                counter--;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text !=string.Empty || progressBar1.Value==100)
            {
                richTextBox1.Clear();
                progressBar1.Value=0;
            }
            else
            {
                MessageBox.Show("Sorry, you don't have data in the rich text box area");
            }
        }
    }
}
