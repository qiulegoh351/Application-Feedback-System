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
    }
}
