using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace ApplicationFeedbackSystem
{
    public partial class AdminScreen : Form
    {
        DataTable table = new DataTable();
        public AdminScreen()
        {
            InitializeComponent();
        }

        private void AdminScreen_Load(object sender, EventArgs e)
        {
            panelAdminBtn.Show();
            panelCreateTemplateBtn.Hide();
            panelCreateAndEdit.Hide();
            panelGradientColor1.Hide();
            PanelViewTemplate.Show();
            panelEditTemplateBtn.Hide();
            logoutPanel3.Hide();


            panelAdminBtn.Width = 114;
            panelAdminBtn.Height = 457;
            panelAdminBtn.Location = new Point(3, 119);

            panelCreateTemplateBtn.Width = 114;
            panelCreateTemplateBtn.Height = 457;
            panelCreateTemplateBtn.Location = new Point(3, 119);

            panelCreateAndEdit.Width = 866;
            panelCreateAndEdit.Height = 561;
            panelCreateAndEdit.Location = new Point(130, 9);

            panelEditTemplateBtn.Width = 114;
            panelEditTemplateBtn.Height = 457;
            panelEditTemplateBtn.Location = new Point(3, 119);

            panelGradientColor1.Width = 866;
            panelGradientColor1.Height = 561;
            panelGradientColor1.Location = new Point(130, 9);

            PanelViewTemplate.Width = 866;
            PanelViewTemplate.Height = 561;
            PanelViewTemplate.Location = new Point(130, 9);

            logoutPanel3.Location = new Point(314, 161);

        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            panelCreateTemplateBtn.Show();
            panelAdminBtn.Hide();
            panelCreateAndEdit.Show();
            LabelCreateTemplate.Show();
            labelEditTemplate.Hide();

            LabelCreateTemplate.Width = 866;
            LabelCreateTemplate.Height = 85;
            LabelCreateTemplate.Location = new Point(-3, 0);
        }



        private void ExitBtn_Click(object sender, EventArgs e)
        {
            panelCreateTemplateBtn.Hide();
            panelAdminBtn.Show();
            PanelViewTemplate.Show();
            panelCreateAndEdit.Hide();
        }

        private void exitEditBtn_Click(object sender, EventArgs e)
        {
            panelCreateTemplateBtn.Hide();
            panelEditTemplateBtn.Hide();
            panelAdminBtn.Show();
            PanelViewTemplate.Show();
            panelCreateAndEdit.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panelAdminBtn.Show();
            PanelViewTemplate.Show();
            panelCreateAndEdit.Hide();
        }

        private void logOutBtn2_Click(object sender, EventArgs e)
        {
            logoutPanel3.Show();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            logoutPanel3.Show();
        }

        private void cLogOutButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            login_form loginForm = new login_form();
            loginForm.Show();
        }

        private void cancelLogOutButton2_Click(object sender, EventArgs e)
        {
            logoutPanel3.Hide();
        }

        private void SaveCreateBtn_Click(object sender, EventArgs e)
        {
            DbConnector dbConn = new DbConnector();
            dbConn.connect();

            Template Ad = new Template();
            Ad.Code = int.Parse(codeText.Text);
            Ad.Interviewee = intervieweeText.Text;
            Ad.Gender = genderText.Text;
            Ad.Age = int.Parse(ageText.Text);
            Ad.DateOfBirth = DateTime.Parse(dateOfBirth.Text);
            Ad.Email = emailText.Text;
            Ad.ContactNum = contactText.Text;
            Ad.Type = typeText.Text;
            Ad.Position = positionText.Text;
            Ad.City = cityText.Text;
            Ad.State = stateText.Text;
            Ad.Address = addressText.Text;
            Ad.Interviewer = interviewerText.Text;

            TemplateHandler ADHandler = new TemplateHandler();
            int recordAdd = ADHandler.addNewTemplate(dbConn.getConn(), Ad);
            MessageBox.Show(recordAdd + " New Template has been Added !!");
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            panelEditTemplateBtn.Show();
            panelCreateAndEdit.Show();
            labelEditTemplate.Show();
            panelCreateTemplateBtn.Hide();
            panelAdminBtn.Hide();
            LabelCreateTemplate.Hide();

            labelEditTemplate.Width = 866;
            labelEditTemplate.Height = 85;
            labelEditTemplate.Location = new Point(-3, 0);
        }

        private void displayBtn_Click(object sender, EventArgs e)
        {
            Template temp = new Template();
            DbConnector dbConn = new DbConnector();
            dbConn.connect();

            TemplateHandler tempHnd = new TemplateHandler();
            
            dgvList.DataSource = tempHnd.listAllTemplate(dbConn.getConn());
        }

        private void saveEditBtn_Click(object sender, EventArgs e)
        {
            DbConnector dbConn = new DbConnector();
            dbConn.connect();

            Template Ad = new Template();
            Ad.Code = int.Parse(codeText.Text);
            Ad.Interviewee = intervieweeText.Text;
            Ad.Gender = genderText.Text;
            Ad.Age = int.Parse(ageText.Text);
            Ad.DateOfBirth = DateTime.Parse(dateOfBirth.Text);
            Ad.Email = emailText.Text;
            Ad.ContactNum = contactText.Text;
            Ad.Type = typeText.Text;
            Ad.Position = positionText.Text;
            Ad.City = cityText.Text;
            Ad.State = stateText.Text;
            Ad.Address = addressText.Text;
            Ad.Interviewer = interviewerText.Text;

            TemplateHandler ADHandler = new TemplateHandler();
            int recordAdd = ADHandler.editTemplate(dbConn.getConn(), Ad);
            MessageBox.Show(recordAdd + " Template Successful Updated !!");
        }

        private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DbConnector dbConn = new DbConnector();
            dbConn.connect();

            if (e.RowIndex >= 0)

            {
                DataGridViewRow row = this.dgvList.Rows[e.RowIndex];


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


                panelEditTemplateBtn.Show();
                panelCreateAndEdit.Show();
                labelEditTemplate.Show();
                panelCreateTemplateBtn.Hide();
                panelAdminBtn.Hide();
                LabelCreateTemplate.Hide();

                labelEditTemplate.Width = 866;
                labelEditTemplate.Height = 85;
                labelEditTemplate.Location = new Point(-3, 0);
            }
        }
    }
}
