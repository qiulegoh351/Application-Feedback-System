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
    public partial class AdminScreen : Form
    {
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

        private void editBtn_Click(object sender, EventArgs e)
        {
            panelCreateTemplateBtn.Show();
            panelAdminBtn.Hide();
            panelCreateAndEdit.Show();
            LabelCreateTemplate.Hide();
            labelEditTemplate.Show();

            labelEditTemplate.Width = 866;
            labelEditTemplate.Height = 85;
            labelEditTemplate.Location = new Point(-3, 0);

           
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            panelCreateTemplateBtn.Hide();
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
    }
}
