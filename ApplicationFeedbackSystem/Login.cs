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
using System.Data;

namespace ApplicationFeedbackSystem
{
    public partial class login_form : Form
    {
        MySqlConnection con = new MySqlConnection(@"Data Source=localhost;port=3306;Initial Catalog=se_assignment;User Id=dbcli;password=dbcli123");
        public login_form()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            int x = 0;

            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM user WHERE username='" + textBox2.Text + "' AND password ='" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            x = Convert.ToInt32(dt.Rows.Count.ToString());

            if(dt.Rows.Count>0)
            {
                for(x=0; x<dt.Rows.Count; x++)
                {
                    if(dt.Rows[x]["role"].ToString() == "1" )
                    {
                        AdminScreen MainScreen = new AdminScreen();
                        MainScreen.Show();
                        this.Hide();
                    }
                    else if (dt.Rows[x]["role"].ToString() == "2")
                    {
                        ManagerScreen managerScreen = new ManagerScreen();
                        managerScreen.Show();
                        this.Hide();
                    }
                    else if (dt.Rows[x]["role"].ToString() == "3")
                    {
                        HrScreen hrScreen = new HrScreen();
                        hrScreen.Show();
                        this.Hide();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please try again!");
            }
            
            con.Close();  
        }
    }
}
