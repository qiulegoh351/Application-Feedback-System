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
    public partial class ManagerScreen : Form
    {
        public ManagerScreen()
        {
            InitializeComponent();
        }
        bool validateView = false;
        private void ManagerScreen_Load(object sender, EventArgs e)
        {
            panelManagerBtn.Show();
            panelViewBtn.Hide();
            panelView.Hide();
            PanelViewTemplate.Show();
            logoutPanel.Hide();

            panelManagerBtn.Width = 114;
            panelManagerBtn.Height = 457;
            panelManagerBtn.Location = new Point(3, 119);

            panelViewBtn.Width = 114;
            panelViewBtn.Height = 457;
            panelViewBtn.Location = new Point(3, 119);

            PanelViewTemplate.Width = 872;
            PanelViewTemplate.Height = 561;
            PanelViewTemplate.Location = new Point(124, 1);

            panelView.Width = 872;
            panelView.Height = 561;
            panelView.Location = new Point(124, 1);


            logoutPanel.Location = new Point(314, 161);

        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            logoutPanel.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            login_form loginForm = new login_form();
            loginForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            logoutPanel.Hide();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DbConnector dbConn = new DbConnector();
            dbConn.connect();
            Template Ad = new Template();
      
            TemplateHandler tempHnd = new TemplateHandler();
            Ad.Code = int.Parse(codeText.Text);
            if (Ad.Code != 0)
            {
                TemplateHandler ADHandler = new TemplateHandler();
                int recordAdd = ADHandler.deleteATemplate(dbConn.getConn(), Ad);
                MessageBox.Show(recordAdd + " Template Successful Updated !!");
                MessageBox.Show("Record Deleted Successfully!");
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }

        }


        private void displayBtn_Click(object sender, EventArgs e)
        {
            Template temp = new Template();
            DbConnector dbConn = new DbConnector();
            dbConn.connect();

            TemplateHandler tempHnd = new TemplateHandler();

            dgvList.DataSource = tempHnd.listAllTemplate(dbConn.getConn());
            validateView = false;
        }

        private void viewBtn_Click(object sender, EventArgs b)
        {
            if(validateView == true)
            {
                panelManagerBtn.Hide();
                panelViewBtn.Show();
                panelView.Show();
                PanelViewTemplate.Hide();
            }
            else
            {
                MessageBox.Show("Please Select A Template to View");
            }
            
        }

        public void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DbConnector dbConn = new DbConnector();
            dbConn.connect();
            validateView = true;
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
                feedbackTypeText.Text = row.Cells["type"].Value.ToString();
            }
        }   

        private void back_Click(object sender, EventArgs e)
        {
            validateView = false;
            panelManagerBtn.Show();
            panelViewBtn.Hide();
            panelView.Hide();
            PanelViewTemplate.Show();

            Template temp = new Template();
            DbConnector dbConn = new DbConnector();
            dbConn.connect();

            TemplateHandler tempHnd = new TemplateHandler();

            dgvList.DataSource = tempHnd.listAllTemplate(dbConn.getConn());
        }
    }
}
