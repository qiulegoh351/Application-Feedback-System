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
        private bool validateCreateSingleton = false;
        private bool validateSentEmailSingleton = false;
        private bool validateExit = false;
        private bool IsHeaderCheckBoxClicked = false;
        private bool validateFeedback = false;
        private bool validateCompleteFeedback = false;
        private bool validateTitle = false;
        public HrScreen()
        {
            InitializeComponent();
            DbConnector dbConn = DbConnector.Instance;
            dbConn.connect();

            TemplateHandler tempHnd = TemplateHandler.TH_instance;

            dgvList.DataSource = tempHnd.listAllTemplate(dbConn.getConn());
        }
        CheckBox HeaderCheckBox = null;
        //Hide and Show Control for initian HR Main Screen
        private void HrScreen_Load(object sender, EventArgs e)
        {
            panelHRBtn.Show();
            panelCompleteFeedbackBtn.Hide();
            panelFeedBtn.Hide();
            PanelViewTemplate.Show();
            panelViewBtn.Hide();
            panelView.Hide();
            panelCompleteFeedback.Hide();
            panelFeedback.Hide();
            logoutPanel2.Hide();
            emailPanel.Hide();

            panelHRBtn.Width = 116;
            panelHRBtn.Height = 430;
            panelHRBtn.Location = new Point(3, 119);

            panelViewBtn.Width = 116;
            panelViewBtn.Height = 430;
            panelViewBtn.Location = new Point(3, 119);

            panelCompleteFeedbackBtn.Width = 114;
            panelCompleteFeedbackBtn.Height = 430;
            panelCompleteFeedbackBtn.Location = new Point(3, 119);

            panelFeedBtn.Width = 114;
            panelFeedBtn.Height = 430;
            panelFeedBtn.Location = new Point(3, 119);

            PanelViewTemplate.Width = 872;
            PanelViewTemplate.Height = 561;
            PanelViewTemplate.Location = new Point(124, 1);

            emailPanel.Width = 429;
            emailPanel.Height = 143;
            emailPanel.Location = new Point(334, 208);

            panelView.Width = 872;
            panelView.Height = 561;
            panelView.Location = new Point(124, 1);

            panelCompleteFeedback.Width = 872;
            panelCompleteFeedback.Height = 561;
            panelCompleteFeedback.Location = new Point(124, 1);

            panelFeedback.Width = 872;
            panelFeedback.Height = 561;
            panelFeedback.Location = new Point(124, 1);

            logoutPanel2.Location = new Point(314, 161);
            //call this method of header checkbox mouse click.
            //first add header checkbox than mouseClick without checkbox 
            AddHeaderChecBox();
            HeaderCheckBox.MouseClick += new MouseEventHandler(HeaderCheckBox_MouseClick);
        }
//-------------------------------------------------------------------HR Main Screen-------------------------------------------------------//
        //Create Button -----HR Main Screen
        private void createBtn_Click(object sender, EventArgs e)
        {
            validateCreateSingleton = false;
            if (validateFeedback == true)
            {
                panelCompleteFeedbackBtn.Hide();
                panelFeedback.Show();
                panelCompleteFeedbackBtn.Hide();
                panelHRBtn.Hide();
                panelFeedBtn.Show();
                panelCompleteFeedback.Hide();
                panelView.Hide();
                panelViewBtn.Hide();
            }
            else
            {
                MessageBox.Show("Please Select A Template to feedback...");
            }
        }
        //Connect to database to return the value to template's text box
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
        //Complete Feedback list Button -----HR Main Screen
        private void editBtn_Click(object sender, EventArgs e)
        {
            validateSentEmailSingleton = false;
            panelHRBtn.Hide();
            panelCompleteFeedback.Show();
            panelFeedBtn.Hide();
            panelCompleteFeedbackBtn.Show();
            panelView.Hide();
            panelViewBtn.Hide();
            DbConnector dbConn = DbConnector.Instance;
            dbConn.connect();
            dbConn.Close();
            completeFeedbackHandler comhr = completeFeedbackHandler.FH_instance;
            dataGridView1.DataSource = comhr.listCompleteFeedback(dbConn.getConn());
        }
        private void viewBtn_Click(object sender, EventArgs e)
        {
            panelHRBtn.Hide();
            panelCompleteFeedback.Hide();
            panelFeedBtn.Hide();
            panelCompleteFeedbackBtn.Hide();
            panelView.Show();
            panelViewBtn.Show();
        }
        //Refresh Button ----HR Main Screen
        private void displayBtn_Click(object sender, EventArgs e)
        {
            DbConnector dbConn = DbConnector.Instance;
            dbConn.connect();

            TemplateHandler tempHnd = TemplateHandler.TH_instance;

            dgvList.DataSource = tempHnd.listAllTemplate(dbConn.getConn());
        }
        //Logout Button ------HR Main Screen
        private void logoutBtn_Click(object sender, EventArgs e)
        {
            logoutPanel2.Show();
        }

//----------------------------------------------------------------Feedback Panel------------------------------------------------------------------//
        //Clear Button -----Feedback Panel
        private void clear_Click(object sender, EventArgs e)
        {
            commentsTextBox.Clear();
        }

        //Save Button ----Feedback Panel
        private void button3_Click(object sender, EventArgs e)
        {
            if(suggestionBtn.Checked == true && commentBtn.Checked == false && questionBtn.Checked == false)
            {
                validateTitle = true; 
            }else if(suggestionBtn.Checked == false && commentBtn.Checked == true && questionBtn.Checked == false)
            {
                validateTitle = true;
            }
            else if (suggestionBtn.Checked == false && commentBtn.Checked == false && questionBtn.Checked == true)
            {
                validateTitle = true;
            }else
            {
                validateTitle = false;
            }

            if (validateTitle == true)
            {
                panelHRBtn.Show();
                PanelViewTemplate.Show();
                panelCompleteFeedback.Hide();
                panelFeedBtn.Hide();
                panelFeedback.Hide();
                panelCompleteFeedbackBtn.Hide();
                panelView.Hide();
                panelViewBtn.Hide();
                validateExit = true;
                ConvertPDF.Print();

                DbConnector dbConn = DbConnector.Instance;
                dbConn.connect();

                completeFeedback cpFB = new completeFeedback();
                FeedBackPage fbp = new FeedBackPage();
                cpFB.File_name = int.Parse(eFirstNameTextBox.Text);
                fbp.Code = int.Parse(eFirstNameTextBox.Text);
                fbp.Interviewee = textBox1.Text;
                fbp.Email = textBox2.Text;
                fbp.Describe = commentsTextBox.Text;
                fbp.FeedbackType = textBox3.Text;
                fbp.Interviewer = textBox4.Text;
                cpFB.Email = textBox2.Text;
                cpFB.Status = "Incomplete";

                Template Ad = new Template();
                Ad.Code = int.Parse(codeText.Text);
                TemplateHandler ADHandler = TemplateHandler.TH_instance;
                ADHandler.deleteATemplate(dbConn.getConn(), Ad);

                feedbackHandler fbHr = feedbackHandler.TH_instance;
                if (validateCreateSingleton == false)
                {
                    int countRecord = fbHr.addNewfeedback(dbConn.getConn(), fbp);
                    fbHr.Close();
                    MessageBox.Show(countRecord + "data has benn inserted into Feedback");
                    fbHr.Open();
                }
                else if (validateCreateSingleton == true)
                {
                    fbHr.Close();
                }

                completeFeedbackHandler cpFbHr = completeFeedbackHandler.FH_instance;
                int recordCnt = cpFbHr.addNewCompleteFeedback(dbConn.getConn(), cpFB);
                MessageBox.Show(recordCnt + " data has been inserted into Complete Feedback");
            }else
            {
                MessageBox.Show("Please select a Title's checkbox and don't select more than one title's checkbox.");
            }

        }
        //Exit Button ----Feedback Panel
        private void button2_Click(object sender, EventArgs e)
        {
            if ((commentsTextBox.Text != "") || (commentsTextBox.Text != null))
            {
                DialogResult result = MessageBox.Show("Are you sure want exit without saving the Feedback?",
                "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    panelFeedBtn.Hide();
                    panelHRBtn.Hide();
                    panelCompleteFeedbackBtn.Hide();
                    panelHRBtn.Show();
                    PanelViewTemplate.Show();
                    panelCompleteFeedback.Hide();
                    panelFeedback.Hide();
                    panelView.Hide();
                    panelViewBtn.Hide();
                }else if (result == DialogResult.No) { }
            }
            else if((validateExit == true) || (commentsTextBox.Text == "") || (commentsTextBox.Text == null))
            {
                panelFeedBtn.Hide();
                panelHRBtn.Hide();
                panelCompleteFeedbackBtn.Hide();
                panelHRBtn.Show();
                PanelViewTemplate.Show();
                panelCompleteFeedback.Hide();
                panelFeedback.Hide();
                panelView.Hide();
                panelViewBtn.Hide();
            }
            DbConnector dbConn = DbConnector.Instance;
            dbConn.connect();
            TemplateHandler tempHnd = TemplateHandler.TH_instance;
            dgvList.DataSource = tempHnd.listAllTemplate(dbConn.getConn());
        }
        //Feedback Print ----Feedback Panel
        private void ConvertPDF_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            FeedBackPage afeedback = new FeedBackPage();

            afeedback.Code = int.Parse(eFirstNameTextBox.Text);
            afeedback.Interviewee = textBox1.Text;
            afeedback.Email = textBox2.Text;
            if (suggestionBtn.Checked == true)
            {
                afeedback.Title = "Suggestion";
            }
            else if (commentBtn.Checked == true)
            {
                afeedback.Title = "Comment";
            }
            else if (questionBtn.Checked == true)
            {
                afeedback.Title = "Question";
            }
            afeedback.Describe = commentsTextBox.Text;
            afeedback.FeedbackType = textBox3.Text;
            afeedback.Interviewer = textBox4.Text;

            e.Graphics.DrawString(labelGradientColor8.Text, new Font("Arial", 50, FontStyle.Regular), Brushes.Black, new Point(295, 0));
            e.Graphics.DrawString(labelGradientColor4.Text, new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(2, 84));

            e.Graphics.DrawString("Code: " + afeedback.Code, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(37, 142));
            e.Graphics.DrawString("Interviewee: " + afeedback.Interviewee, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(322, 142));
            e.Graphics.DrawString("Email: " + afeedback.Email, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(600, 142));
            e.Graphics.DrawString("Title: " + afeedback.Title, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(227, 130));
            e.Graphics.DrawString("Description: " + afeedback.Describe, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(37, 200));
            e.Graphics.DrawString("FeedbackType: " + afeedback.FeedbackType, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(488, 476));
            e.Graphics.DrawString("Interviewer: " + afeedback.Interviewer, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(488, 508));
        }
        //Logout Button -----Feedback Panel
        private void button1_Click(object sender, EventArgs e)
        {
            validateCreateSingleton = false;
            if ((commentsTextBox.Text != "") || (commentsTextBox.Text == null))
            {
                DialogResult result = MessageBox.Show("Are you sure want to Logout without saving the Feedback?",
                "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    logoutPanel2.Show();
                }
                else if (result == DialogResult.No) { }
            }
            else
            {
                logoutPanel2.Show();
            }   
        }
// --------------------------------------------------------------------------View A Template Panel--------------------------------------------------------//
        //Back Button----View A Template Panel
        private void back_Click(object sender, EventArgs e)
        {
            panelFeedBtn.Hide();
            panelCompleteFeedbackBtn.Hide();
            panelHRBtn.Show();
            PanelViewTemplate.Show();
            panelCompleteFeedback.Hide();
            panelFeedback.Hide();
            panelView.Hide();
            panelViewBtn.Hide();
        }
        //Logout Button----View A Template Panel
        private void logout3_Click(object sender, EventArgs e)
        {
            logoutPanel2.Show();
        }
//------------------------------------------------------------Complete Feedback List Panel-------------------------------------------------------//
        //Select Button ----Complete Feedback List
        private void selectBtn_Click(object sender, EventArgs e)
        {
            if (validateCompleteFeedback == true)
            {
                DbConnector dbConn = DbConnector.Instance;
                dbConn.connect();
                ///FeedBackPage fb = new FeedBackPage();
                ///fb.Code = int.Parse(eFirstNameTextBox.Text);
                ///feedbackHandler FBHandler = new feedbackHandler();
                ///FBHandler.deleteAFeedback(dbConn.getConn(),fb);
                openFileDialog1.ShowDialog();
                lblLocation.Text = openFileDialog1.FileName;

                panelCompleteFeedbackBtn.Hide();
                panelFeedback.Hide();
                panelCompleteFeedbackBtn.Show();
                panelHRBtn.Hide();
                panelFeedBtn.Hide();
                panelCompleteFeedback.Show();
                panelViewBtn.Hide();
                panelView.Hide();
                emailPanel.Show();
            }
            else
            {
                MessageBox.Show("Please Select A Complete Feedback");
            }
        }
        //Refresh Button ----Complete Feedback List
        private void displayBtn2_Click(object sender, EventArgs e)
        {
            DbConnector dbConn = DbConnector.Instance;
            dbConn.connect();

            completeFeedbackHandler comhr = completeFeedbackHandler.FH_instance;

            dataGridView1.DataSource = comhr.listCompleteFeedback(dbConn.getConn());
        }


        //Back Button -----Complete Feedback List
        private void backBtn_Click(object sender, EventArgs e)
        {
            validateSentEmailSingleton = false;
            panelHRBtn.Show();
            panelCompleteFeedbackBtn.Hide();
            PanelViewTemplate.Show();
            panelCompleteFeedback.Hide();
            panelView.Hide();
            panelViewBtn.Hide();
        }
        //Logout Button ------Complete Feedback List
        private void logOutBtn2_Click(object sender, EventArgs e)
        {
            logoutPanel2.Show();
        }
//-------------------------------------------------------------Datagrid View Control-------------------------------------------------------------//
        //Add Header checkBox Method
        private void AddHeaderChecBox()
        {
            HeaderCheckBox = new CheckBox();
            Point headerCellLocation = this.dataGridView1.GetCellDisplayRectangle(0, -1, true).Location;
            HeaderCheckBox.Location = new Point(headerCellLocation.X + 23, headerCellLocation.Y + 8);
            HeaderCheckBox.BackColor = Color.White;
            HeaderCheckBox.Size = new Size(23, 23);
            this.dataGridView1.Controls.Add(HeaderCheckBox);
        }

        //header checkbox clickevent
        private void HeaderCheckBoxClick(CheckBox HCheckBox)
        {
            IsHeaderCheckBoxClicked = true;
            foreach (DataGridViewRow Row in dataGridView1.Rows)
                ((DataGridViewCheckBoxCell)Row.Cells["chk"]).Value = HCheckBox.Checked;

            IsHeaderCheckBoxClicked = false;
        }

        //mouse click event for Header Check Box on DataGridView
        private void HeaderCheckBox_MouseClick(object sender, MouseEventArgs e)
        {
            HeaderCheckBoxClick((CheckBox)sender);
        }
        //Complete Feedback List Panel Cell Content Click
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DbConnector dbConn = DbConnector.Instance;
            dbConn.connect();
            validateCompleteFeedback = true;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                lbToEmail.Text = row.Cells[2].Value.ToString();
                lbCode.Text = row.Cells[1].Value.ToString();
            }
        }
        //HR Main Screen Cell Content Click
        private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DbConnector dbConn = DbConnector.Instance;
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

                codeText.Text = row.Cells["code"].Value.ToString();
                intervieweeText.Text = row.Cells["interviewee"].Value.ToString();
                genderText.Text = row.Cells["gender"].Value.ToString();
                ageText.Text = row.Cells["age"].Value.ToString();
                dateOfBirth.Text = row.Cells["DateOfBirth"].Value.ToString();
                emailText.Text = row.Cells["email"].Value.ToString();
                contactText.Text = row.Cells["contactNum"].Value.ToString();
                typeText.Text = row.Cells["type"].Value.ToString();
                positionText.Text = row.Cells["position"].Value.ToString();
                cityText.Text = row.Cells["city"].Value.ToString();
                stateText.Text = row.Cells["state"].Value.ToString();
                addressText.Text = row.Cells["address"].Value.ToString();
                interviewerText.Text = row.Cells["interviewer"].Value.ToString();
            }
        }
//----------------------------------------------------------------------------Logout Panel------------------------------------------------------------------------
        //Logout Button ----Logout Panel
        private void cLogOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            login_form loginForm = new login_form();
            loginForm.Show();
        }
        //Cancel Logout Button ------HR Main Screen
        private void cancelLogOutButton_Click(object sender, EventArgs e)
        {
            logoutPanel2.Hide();
        }
//---------------------------------------------------------------------------------Email Panel------------------------------
        //Link Label -----Email Panel
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //openFileDialog1.ShowDialog();
            //lblLocation.Text = openFileDialog1.FileName;
        }
        //Send Email Button ----Email Panel
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

            DbConnector dbConn = DbConnector.Instance;
            dbConn.connect();

            if (lblLocation.Text != "")
            {
                completeFeedback cpFB = new completeFeedback();

                cpFB.File_name = int.Parse(lbCode.Text);
                cpFB.Email = lbToEmail.Text;
                cpFB.Status = "Successful";
                completeFeedbackHandler cpHand = completeFeedbackHandler.FH_instance;
                if (validateSentEmailSingleton == false)
                {
                    
                    //cpHand.deleteCompleteRow(dbConn.getConn(), cpFB);
                    cpHand.editCompleteFeedback(dbConn.getConn(), cpFB);
                    cpHand.Close();
                    cpHand.Open();             
                }
                else if (validateSentEmailSingleton == true)
                {
                    cpHand.Close();
                }
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
        //Select Btn -----Complete Feedback List
       

        private void TestBtn_Click(object sender, EventArgs e)
        {
            validateSentEmailSingleton = false;
            panelView.Hide();
            panelViewBtn.Hide();
            panelCompleteFeedbackBtn.Show();
            panelFeedback.Hide();
            panelHRBtn.Hide();
            panelFeedBtn.Hide();
            panelCompleteFeedback.Show();
            emailPanel.Hide();
        }

        private void suggestionBtn_CheckedChanged(object sender, EventArgs e)
        {

        }
    }     
}
