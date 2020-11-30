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

        private void test1Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are in HR Screen! Welcome 秋乐大爷 和 峰仔大爷!");
        }
    }
}
