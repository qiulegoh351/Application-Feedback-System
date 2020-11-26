using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationFeedbackSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            homeButton.Show();
            feedbackRightPanel.Show();
            createPanel.Hide();
            editPanel.Hide();
            saveConvertButton.Hide();
            clearButton.Hide();
            saveButton.Hide();
            backbutton.Hide();
            logOutButton.Hide();

            feedbackRightPanel.Width = 780;
            feedbackRightPanel.Height = 632;
            feedbackRightPanel.Location = new Point(117, 0);

            createPanel.Width = 779;
            createPanel.Height = 629;
            createPanel.Location = new Point(117, 0);

            editPanel.Width = 779;
            editPanel.Height = 629;
            editPanel.Location = new Point(117, 0);

            homeButton.Width = 80;
            homeButton.Height = 50;
            homeButton.Location = new Point(24, 121);

            saveConvertButton.Width = 80;
            saveConvertButton.Height = 59;
            saveConvertButton.Location = new Point(24, 181);

            clearButton.Width = 80;
            clearButton.Height = 50;
            clearButton.Location = new Point(24, 181);

            saveButton.Width = 80;
            saveButton.Height = 50;
            saveButton.Location = new Point(24, 254);

            backbutton.Width = 80;
            backbutton.Height = 50;
            backbutton.Location = new Point(24, 330);

            logOutButton.Width = 80;
            logOutButton.Height = 50;
            logOutButton.Location = new Point(24, 446);
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            homeButton.Show();
            feedbackRightPanel.Hide();
            createPanel.Hide();
            editPanel.Hide();
            saveConvertButton.Show();
            clearButton.Hide();
            saveButton.Hide();
            backbutton.Hide();
            logOutButton.Hide();
        }

        private void saveConvertButton_Click(object sender, EventArgs e)
        {
            homeButton.Show();
            feedbackRightPanel.Hide();
            createPanel.Show();
            editPanel.Hide();
            saveConvertButton.Show();
            clearButton.Hide();
            saveButton.Show();
            backbutton.Hide();
            logOutButton.Hide();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            homeButton.Show();
            feedbackRightPanel.Hide();
            createPanel.Hide();
            editPanel.Show();
            saveConvertButton.Show();
            clearButton.Hide();
            saveButton.Show();
            backbutton.Show();
            logOutButton.Show();
        }
    }
    
}
