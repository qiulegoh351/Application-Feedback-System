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
        public AdminScreen()
        {
            InitializeComponent();
            DbConnector dbConn = new DbConnector();
            dbConn.connect();

            TemplateHandler tempHnd = new TemplateHandler();

            dgvList.DataSource = tempHnd.listAllTemplate(dbConn.getConn());
        }
        bool validateView = false;
        bool validateEdit = false;
        //Hide and Show Panel Control for Admin initial Main Screen 
        private void AdminScreen_Load(object sender, EventArgs e)
        {
            panelAdminBtn.Show();
            panelViewBtn.Hide();
            panelCreateTemplateBtn.Hide();
            panelCreateAndEdit.Hide();
            panelView.Hide();
            PanelViewTemplate.Show();
            panelEditTemplateBtn.Hide();
            logoutPanel3.Hide();


            panelAdminBtn.Width = 114;
            panelAdminBtn.Height = 457;
            panelAdminBtn.Location = new Point(3, 119);

            panelViewBtn.Width = 114;
            panelViewBtn.Height = 457;
            panelViewBtn.Location = new Point(3, 119);

            panelCreateTemplateBtn.Width = 114;
            panelCreateTemplateBtn.Height = 457;
            panelCreateTemplateBtn.Location = new Point(3, 119);

            panelCreateAndEdit.Width = 872;
            panelCreateAndEdit.Height = 561;
            panelCreateAndEdit.Location = new Point(124, 1);

            panelEditTemplateBtn.Width = 114;
            panelEditTemplateBtn.Height = 457;
            panelEditTemplateBtn.Location = new Point(3, 119);

            panelView.Width = 872;
            panelView.Height = 561;
            panelView.Location = new Point(124, 1);

            PanelViewTemplate.Width = 872;
            PanelViewTemplate.Height = 561;
            PanelViewTemplate.Location = new Point(124, 1);

            logoutPanel3.Location = new Point(314, 161);
        }

//----------------------------------------------------------------------Admin Main Screen-----------------------------------------------------------------------//
        //Create Button ----Main Screen
        private void createBtn_Click(object sender, EventArgs e)
        {
            panelCreateTemplateBtn.Show();
            panelAdminBtn.Hide();
            panelViewBtn.Hide();
            panelCreateAndEdit.Show();
            LabelCreateTemplate.Show();
            labelEditTemplate.Hide();

            LabelCreateTemplate.Width = 866;
            LabelCreateTemplate.Height = 85;
            LabelCreateTemplate.Location = new Point(-3, 0);
        }
        //Edit Button ----Main Screen
        private void editBtn_Click(object sender, EventArgs e)
        {
            if (validateEdit == true)
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
            else
            {
                MessageBox.Show("Please Select A Template to Edit");
            }
        }

        //View Button ----Main Screen
        private void viewBtn_Click(object sender, EventArgs e)
        {
            if (validateView == true)
            {
                panelEditTemplateBtn.Hide();
                panelCreateAndEdit.Hide();
                labelEditTemplate.Hide();
                panelCreateTemplateBtn.Hide();
                panelAdminBtn.Hide();
                panelView.Show();
                panelViewBtn.Show();
                LabelCreateTemplate.Hide();
            }
            else
            {
                MessageBox.Show("Please Select A Template to View");
            }
        }

        //Refresh Button ----Main Screen
        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            DbConnector dbConn = new DbConnector();
            dbConn.connect();

            TemplateHandler tempHnd = new TemplateHandler();

            dgvList.DataSource = tempHnd.listAllTemplate(dbConn.getConn());
        }

        //Logout Button ----Main Screen
        private void logoutMainScreen_Click(object sender, EventArgs e)
        {
            logoutPanel3.Show();
        }

//--------------------------------------------------------------------------Create Panel------------------------------------------------------------------------//
        // Clear Button ----Create Panel
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            codeText.Text = "";
            intervieweeText.Text = "";
            genderText.Text = "";
            ageText.Text = "";
            dateOfBirth.Text = "";
            emailText.Text = "";
            contactText.Text = "";
            typeText.Text = "";
            positionText.Text = "";
            cityText.Text = "";
            stateText.Text = "";
            addressText.Text = "";
            interviewerText.Text = "";
        }

        // Save Button ----Create Panel
        private void SaveCreateBtn_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception)
            {
                MessageBox.Show("Data Existing already or Save Null Value");
            }
        }

        //Exit Button ----Create Panel
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            if ((codeText.Text != "") || (codeText.Text == null))
            {
                DialogResult result = MessageBox.Show("Are you sure want exit without saving the template?",
                "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    validateEdit = false;
                    panelCreateTemplateBtn.Hide();
                    panelViewBtn.Hide();
                    panelAdminBtn.Show();
                    PanelViewTemplate.Show();
                    panelCreateAndEdit.Hide();
                }
                else if (result == DialogResult.No) { }
            }
            else
            {
                validateEdit = false;
                panelCreateTemplateBtn.Hide();
                panelViewBtn.Hide();
                panelAdminBtn.Show();
                PanelViewTemplate.Show();
                panelCreateAndEdit.Hide();
            }
        }
        //Logout Button ----Create Panel
        private void logOutBtn2_Click(object sender, EventArgs e)
        {
            logoutPanel3.Show();
        }
//----------------------------------Edit Panel & View Panel coding for connecting to database to return data to Text Box-----------------------------------------//
        //Cell Content Click Control
        private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DbConnector dbConn = new DbConnector();
            dbConn.connect();
            validateView = true;
            validateEdit = true;

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

                code.Text = row.Cells["code"].Value.ToString();
                interviewee.Text = row.Cells["interviewee"].Value.ToString();
                gender.Text = row.Cells["gender"].Value.ToString();
                age.Text = row.Cells["age"].Value.ToString();
                datebirth.Text = row.Cells["DateOfBirth"].Value.ToString();
                email.Text = row.Cells["email"].Value.ToString();
                contact.Text = row.Cells["contactNum"].Value.ToString();
                type.Text = row.Cells["type"].Value.ToString();
                position.Text = row.Cells["position"].Value.ToString();
                city.Text = row.Cells["city"].Value.ToString();
                state.Text = row.Cells["state"].Value.ToString();
                address.Text = row.Cells["address"].Value.ToString();
                interviewer.Text = row.Cells["interviewer"].Value.ToString();
                feedbackTypeText.Text = row.Cells["position"].Value.ToString();
            }
        }

        //Code Text Changed by mousce click on the cell of the Datagrid View
        private void codeText_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server=localhost;user=dbcli;database=se_assignment;port=3306;password=dbcli123");
            con.Open();
            if (codeText.Text != " ")
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM template where code =@code", con);
                cmd.Parameters.AddWithValue("@code", (codeText.Text));
                MySqlDataReader da = cmd.ExecuteReader();
                while (da.Read())
                {
                    codeText.Text = da.GetValue(0).ToString();
                    intervieweeText.Text = da.GetValue(1).ToString();
                    genderText.Text = da.GetValue(2).ToString();
                    ageText.Text = da.GetValue(3).ToString();
                    dateOfBirth.Text = da.GetValue(4).ToString();
                    emailText.Text = da.GetValue(5).ToString();
                    contactText.Text = da.GetValue(6).ToString();
                    typeText.Text = da.GetValue(7).ToString();
                    positionText.Text = da.GetValue(8).ToString();
                    cityText.Text = da.GetValue(9).ToString();
                    stateText.Text = da.GetValue(10).ToString();
                    addressText.Text = da.GetValue(11).ToString();
                    interviewerText.Text = da.GetValue(12).ToString();
                }
            }
        }
        //------------------------------------------------------------------------------Edit Panel-----------------------------------------------------------------------//
        //Clear Button -----Edit Panel
        private void clearBtnEdit_Click(object sender, EventArgs e)
        {
            codeText.Text = "";
            intervieweeText.Text = "";
            genderText.Text = "";
            ageText.Text = "";
            dateOfBirth.Text = "";
            emailText.Text = "";
            contactText.Text = "";
            typeText.Text = "";
            positionText.Text = "";
            cityText.Text = "";
            stateText.Text = "";
            addressText.Text = "";
            interviewerText.Text = "";
        }

        //Edit Save Button ----Edit Panel
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
            dbConn.getConn();
            TemplateHandler ADHandler = new TemplateHandler();
            int recordAdd = ADHandler.editTemplate(dbConn.getConn(), Ad);
            MessageBox.Show(recordAdd + " Template Successful Updated !!");
        }

        //Exit Button ----Edit Panel
        private void exitEditBtn_Click(object sender, EventArgs e)
        {
            validateEdit = false;
            panelCreateTemplateBtn.Hide();
            panelViewBtn.Hide();
            panelEditTemplateBtn.Hide();
            panelAdminBtn.Show();
            PanelViewTemplate.Show();
            panelCreateAndEdit.Hide();
        }

        //Logout Button ----Edit Panel
        private void logoutBtn_Click(object sender, EventArgs e)
        {
            logoutPanel3.Show();
        }
//-------------------------------------------------------------------------View A Template Panel---------------------------------------------------------------------//
        //Back Button ----A Template Panel
        private void back_Click(object sender, EventArgs e)
        {
            validateView = false;
            DbConnector dbConn = new DbConnector();
            dbConn.connect();

            TemplateHandler tempHnd = new TemplateHandler();

            dgvList.DataSource = tempHnd.listAllTemplate(dbConn.getConn());
            panelEditTemplateBtn.Hide();
            panelCreateAndEdit.Hide();
            labelEditTemplate.Hide();
            panelView.Hide();
            panelViewBtn.Hide();
            panelAdminRight.Show();
            panelAdminBtn.Show();
            LabelCreateTemplate.Hide();
        }

        //Logout Button ----A Template Panel
        private void logout_Click(object sender, EventArgs e)
        {
            logoutPanel3.Show();
        }
//-------------------------------------------------------------------------Logout Panel-------------------------------------------------------------------------//
        //Logout Button ----Logout Panel
        private void cLogOutButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            login_form loginForm = new login_form();
            loginForm.Show();
        }

        //Cancel Button ----Logout Panel
        private void cancelLogOutButton2_Click(object sender, EventArgs e)
        {
            logoutPanel3.Hide();
        }
    }
}
