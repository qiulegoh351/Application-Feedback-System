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

        private void createBtn_Click(object sender, EventArgs e)
        {
            panelCreateAndEdit.Show();
            LabelCreateTemplate.Show();
            labelEditTemplate.Hide();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            panelCreateAndEdit.Show();
            LabelCreateTemplate.Hide();
            labelEditTemplate.Show();
        }
    }
}
