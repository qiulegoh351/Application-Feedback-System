using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace ApplicationFeedbackSystem
{
    public partial class HrScreen : Form
    {
        public HrScreen()
        {
            InitializeComponent();
        }

        private void HrScreen_Load(object sender, EventArgs e)
        {
            panelAdminBtn.Show();
            panelCreateTemplateBtn.Hide();
            panelFeedCompleteBtn.Hide();

            PanelViewTemplate.Show();
            panelCompleteFeedback.Hide();
            panelFeedback.Hide();

            logoutPanel2.Hide();

            panelAdminBtn.Width = 116;
            panelAdminBtn.Height = 430;
            panelAdminBtn.Location = new Point(3, 119);

            panelCreateTemplateBtn.Width = 114;
            panelCreateTemplateBtn.Height = 430;
            panelCreateTemplateBtn.Location = new Point(3, 119);

            panelFeedCompleteBtn.Width = 114;
            panelFeedCompleteBtn.Height = 430;
            panelFeedCompleteBtn.Location = new Point(3, 119);

            PanelViewTemplate.Width = 866;
            PanelViewTemplate.Height = 561;
            PanelViewTemplate.Location = new Point(130, 9);

            panelCompleteFeedback.Width = 866;
            panelCompleteFeedback.Height = 561;
            panelCompleteFeedback.Location = new Point(130, 9);

            panelFeedback.Width = 866;
            panelFeedback.Height = 561;
            panelFeedback.Location = new Point(130, 9);

            logoutPanel2.Location = new Point(314, 161);
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            panelFeedCompleteBtn.Show();
            panelAdminBtn.Hide();
            panelFeedback.Show();

        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            panelAdminBtn.Hide();
            panelCompleteFeedback.Show();
            panelFeedCompleteBtn.Hide();
            panelCreateTemplateBtn.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelFeedCompleteBtn.Hide();
            panelAdminBtn.Hide();
            panelCreateTemplateBtn.Hide();
            panelAdminBtn.Show();
            PanelViewTemplate.Show();
            panelCompleteFeedback.Hide();
            panelFeedback.Hide();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            panelAdminBtn.Show();
            panelCreateTemplateBtn.Hide();
            PanelViewTemplate.Show();
            panelCompleteFeedback.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            logoutPanel2.Show();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            logoutPanel2.Show();
        }

        private void logOutBtn2_Click(object sender, EventArgs e)
        {
            logoutPanel2.Show();
        }

        private void cLogOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            login_form loginForm = new login_form();
            loginForm.Show();
        }

        private void cancelLogOutButton_Click(object sender, EventArgs e)
        {
            logoutPanel2.Hide();

        }

        private void eFirstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server=localhost;user=dbcli;database=se_assignment;port=3306;password=dbcli123");
            con.Open();
            if (eFirstNameTextBox.Text != " ")
            {
                MySqlCommand cmd = new MySqlCommand("Select Interviewee, Email, Description, FeedbackType, Interviewer from feedback where Code =@Code", con);
                cmd.Parameters.AddWithValue("@Code", (eFirstNameTextBox.Text));
                MySqlDataReader da = cmd.ExecuteReader();
                while (da.Read())
                {
                    textBox1.Text = da.GetValue(0).ToString();
                    textBox2.Text = da.GetValue(1).ToString();
                    textBox5.Text = da.GetValue(2).ToString();
                    textBox3.Text = da.GetValue(3).ToString();
                    textBox4.Text = da.GetValue(4).ToString();
                }
                con.Close();
            }
        }

        private void feedbackPrint_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            FeedBackPage afeedback = new FeedBackPage();

            afeedback.Code = eFirstNameTextBox.Text;
            afeedback.Interviewee = textBox1.Text;
            afeedback.Email = textBox2.Text;
            afeedback.Describe = textBox5.Text;
            afeedback.FeedbackType = textBox3.Text;
            afeedback.Interviewer = textBox4.Text;

            e.Graphics.DrawString(labelGradientColor8.Text, new Font("Arial", 50, FontStyle.Regular), Brushes.Black, new Point(2, 0));
            e.Graphics.DrawString(labelGradientColor4.Text, new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(2, 84));

            e.Graphics.DrawString("Code: " + afeedback.Code, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(37, 142));
            e.Graphics.DrawString("Interviewee: " + afeedback.Interviewee, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(322, 142));
            e.Graphics.DrawString("Email: " + afeedback.Email, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(600, 142));
            e.Graphics.DrawString(labelGradientColor38.Text, new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(0, 299));

            e.Graphics.DrawString("Description: " + afeedback.Describe, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(41, 369));
            e.Graphics.DrawString("FeedbackType: " + afeedback.FeedbackType, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(488, 476));
            e.Graphics.DrawString("Interviewer: " + afeedback.Interviewer, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(488, 508));

        }

        private void button3_Click(object sender, EventArgs e)
        {
            feedbackPrint.Print();

            
        }
    }
       
}
