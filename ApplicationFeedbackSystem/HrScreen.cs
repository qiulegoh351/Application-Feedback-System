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
using System.Net;
using System.Net.Mail;


namespace ApplicationFeedbackSystem
{
    public partial class HrScreen : Form
    {
        public HrScreen()
        {
            InitializeComponent();
            DbConnector dbConn = new DbConnector();
            dbConn.connect();

            TemplateHandler tempHnd = new TemplateHandler();

            dgvList.DataSource = tempHnd.listAllTemplate(dbConn.getConn());
        }

        bool validateFeedback = false;
        bool validateCompleteFeedback = false;

        private void HrScreen_Load(object sender, EventArgs e)
        {
            panelAdminBtn.Show();
            panelCreateTemplateBtn.Hide();
            panelFeedCompleteBtn.Hide();

            PanelViewTemplate.Show();
            panelCompleteFeedback.Hide();
            panelFeedback.Hide();

            logoutPanel2.Hide();

            emailPanel.Hide();

            panelAdminBtn.Width = 116;
            panelAdminBtn.Height = 430;
            panelAdminBtn.Location = new Point(3, 119);

            panelCreateTemplateBtn.Width = 114;
            panelCreateTemplateBtn.Height = 430;
            panelCreateTemplateBtn.Location = new Point(3, 119);

            panelFeedCompleteBtn.Width = 114;
            panelFeedCompleteBtn.Height = 430;
            panelFeedCompleteBtn.Location = new Point(3, 119);

            PanelViewTemplate.Width = 872;
            PanelViewTemplate.Height = 561;
            PanelViewTemplate.Location = new Point(124, 1);

            panelCompleteFeedback.Width = 872;
            panelCompleteFeedback.Height = 561;
            panelCompleteFeedback.Location = new Point(124, 1);

            panelFeedback.Width = 872;
            panelFeedback.Height = 561;
            panelFeedback.Location = new Point(124, 1);

            logoutPanel2.Location = new Point(314, 161);
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            if (validateFeedback == true)
            {
                panelCreateTemplateBtn.Hide();
                panelFeedback.Show();
                panelCreateTemplateBtn.Hide();
                panelAdminBtn.Hide();
                panelFeedCompleteBtn.Show();
                panelCompleteFeedback.Hide();

            }
            else
            {
                MessageBox.Show("Please Select A Template to feedback...");
            }
            //eFirstNameTextBox.Clear();
            //textBox1.Clear();
            //textBox2.Clear();
            //textBox3.Clear();
            //textBox4.Clear();
            //textBox5.Clear();

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

            Template temp = new Template();
            DbConnector dbConn = new DbConnector();
            dbConn.connect();

            TemplateHandler tempHnd = new TemplateHandler();

            dgvList.DataSource = tempHnd.listAllTemplate(dbConn.getConn());
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
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM template where code =@code", con);
                cmd.Parameters.AddWithValue("@code", (eFirstNameTextBox.Text));
                MySqlDataReader da = cmd.ExecuteReader();
                while (da.Read())
                {
                    textBox1.Text = da.GetValue(1).ToString();
                    textBox2.Text = da.GetValue(5).ToString();

                    textBox3.Text = da.GetValue(7).ToString();
                    textBox4.Text = da.GetValue(12).ToString();
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

            e.Graphics.DrawString(labelGradientColor8.Text, new Font("Arial", 50, FontStyle.Regular), Brushes.Black, new Point(295, 0));
            e.Graphics.DrawString(labelGradientColor4.Text, new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(2, 84));

            e.Graphics.DrawString("Code: " + afeedback.Code, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(37, 142));
            e.Graphics.DrawString("Interviewee: " + afeedback.Interviewee, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(322, 142));
            e.Graphics.DrawString("Email: " + afeedback.Email, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(600, 142));

            e.Graphics.DrawString("Description: " + afeedback.Describe, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(37, 200));
            e.Graphics.DrawString("FeedbackType: " + afeedback.FeedbackType, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(488, 476));
            e.Graphics.DrawString("Interviewer: " + afeedback.Interviewer, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(488, 508));

        }

        private void button3_Click(object sender, EventArgs e)
        {
            feedbackPrint.Print();

            DbConnector dbConn = new DbConnector();
            dbConn.connect();

            completeFeedback cpFB = new completeFeedback();
            cpFB.File_name = int.Parse(eFirstNameTextBox.Text);
            cpFB.Email = textBox2.Text;
           

            completeFeedbackHandler cpFbHr = new completeFeedbackHandler();
            int recordCnt = cpFbHr.addNewCompleteFeedback(dbConn.getConn(), cpFB);
            MessageBox.Show(recordCnt + " data has been inserted");

        }

        private void displayBtn_Click(object sender, EventArgs e)
        {
            DbConnector dbConn = new DbConnector();
            dbConn.connect();

            TemplateHandler tempHnd = new TemplateHandler();

            dgvList.DataSource = tempHnd.listAllTemplate(dbConn.getConn());
        }

        private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DbConnector dbConn = new DbConnector();
            dbConn.connect();
            validateFeedback = true;

            if (e.RowIndex >= 0)

            {
                DataGridViewRow row = this.dgvList.Rows[e.RowIndex];


                eFirstNameTextBox.Text = row.Cells["code"].Value.ToString();
                textBox1.Text = row.Cells["interviewee"].Value.ToString();
                //row.Cells["gender"].Value.ToString();
                //row.Cells["age"].Value.ToString();
                //row.Cells["DateOfBirth"].Value.ToString();
                textBox2.Text = row.Cells["email"].Value.ToString();
                //row.Cells["contactNum"].Value.ToString();
                textBox3.Text = row.Cells["type"].Value.ToString();
                //row.Cells["position"].Value.ToString();
                //row.Cells["city"].Value.ToString();
                //row.Cells["state"].Value.ToString();
                //row.Cells["address"].Value.ToString();
                textBox4.Text = row.Cells["interviewer"].Value.ToString();



                ////panelAdminBtn.Hide();
                ////panelFeedCompleteBtn.Show();
                ////panelCreateTemplateBtn.Hide();
                ////PanelViewTemplate.Hide();
                ////panelCompleteFeedback.Hide();
                ////panelFeedback.Show();


            }
        }

        private void displayBtn2_Click(object sender, EventArgs e)
        {
            DbConnector dbConn = new DbConnector();
            dbConn.connect();

            completeFeedbackHandler comhr = new completeFeedbackHandler();

            dataGridView1.DataSource = comhr.listCompleteFeedback(dbConn.getConn());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            eFirstNameTextBox.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DbConnector dbConn = new DbConnector();
            dbConn.connect();
            validateCompleteFeedback = true;

            if (e.RowIndex >= 0)

            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                lbToEmail.Text = row.Cells[2].Value.ToString();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.ShowDialog();
            lblLocation.Text = openFileDialog1.FileName;
        }

        private void sendEmailBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //send mail content
                MailMessage mail = new MailMessage();
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("ngshi901@gmail.com");
                mail.To.Add(lbToEmail.Text);
                mail.Subject = "Interview Feedback from HappyTech";
                mail.Body = "";

                //send attachment file
                System.Net.Mail.Attachment attachment;
                attachment = new System.Net.Mail.Attachment(lblLocation.Text);
                mail.Attachments.Add(attachment);

                //mail resources
                smtp.Port = 587;
                smtp.Credentials = new System.Net.NetworkCredential("ngshi901@gmail.com", "m9b5h62gc");
                smtp.EnableSsl = true;
                smtp.Send(mail);
                MessageBox.Show("Mail has sent","Email sent", MessageBoxButtons.OK,MessageBoxIcon.Information);

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            emailPanel.Hide();
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            if (validateCompleteFeedback == true)
            {
                panelCreateTemplateBtn.Hide();
                panelFeedback.Hide();
                panelCreateTemplateBtn.Show();
                panelAdminBtn.Hide();
                panelFeedCompleteBtn.Hide();
                panelCompleteFeedback.Show();
                emailPanel.Show();

            }
            else
            {
                MessageBox.Show("Please Select A Template to send email");
            }
        }

        private void TestBtn_Click(object sender, EventArgs e)
        {

        }
    }
       
}
