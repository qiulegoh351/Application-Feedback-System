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
    public partial class ManagerScreen : Form
    {
        public ManagerScreen()
        {
            InitializeComponent();
        }

        private void ManagerScreen_Load(object sender, EventArgs e)
        {
            panelAdminBtn.Show();
            panelGradientColor1.Hide();
            PanelViewTemplate.Show();
            logoutPanel.Hide();

            panelAdminBtn.Width = 114;
            panelAdminBtn.Height = 457;
            panelAdminBtn.Location = new Point(3, 119);

            PanelViewTemplate.Width = 866;
            PanelViewTemplate.Height = 561;
            PanelViewTemplate.Location = new Point(130, 9);

            panelGradientColor1.Width = 866;
            panelGradientColor1.Height = 561;
            panelGradientColor1.Location = new Point(130, 9);


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
    }
}
