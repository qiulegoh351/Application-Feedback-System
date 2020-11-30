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

        private void test2Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome 秋乐大爷 和 峰仔大爷, 你们是在Manager 的Screen.");
        }
    }
}
