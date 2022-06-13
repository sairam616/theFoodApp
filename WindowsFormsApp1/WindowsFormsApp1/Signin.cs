using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class Signin : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=SQLSERVERDEV\ITE5233A;Initial Catalog=FINALDB;Integrated Security=True;");
        SqlCommand cmd1,cmd2,cmd3;
        int count = 0, rcount = 0;
        public Signin()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "")
            {
                MessageBox.Show("Please Enter You Registered Name", "Mandatory Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBoxPhone.Text == "")
            {
                MessageBox.Show("Please Enter You Registered PhoneNumber", "Mandatory Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                conn.Open();
                cmd1 = new SqlCommand("select count(*) from user_details where name=@NAME and phone_number=@PHONE", conn);
                cmd1.Parameters.AddWithValue("@NAME", textBoxName.Text.Trim());
                cmd1.Parameters.AddWithValue("@PHONE", textBoxPhone.Text.Trim());
                SqlDataReader da = cmd1.ExecuteReader();
                while (da.Read())
                {
                    rcount = da.GetInt32(0);
                }
                conn.Close();
                if (rcount == 1)
                {
                    conn.Open();
                    cmd2 = new SqlCommand("select user_id from user_details where name=@NAME", conn);
                    cmd2.Parameters.AddWithValue("@NAME", textBoxName.Text.Trim());
                    SqlDataReader sda = cmd2.ExecuteReader();
                    while (sda.Read())
                    {
                        count = sda.GetInt32(0);
                    }
                    conn.Close();

                    conn.Open();
                    cmd3 = new SqlCommand("Delete from order_details where user_id=@USERID",conn);
                    cmd3.Parameters.AddWithValue("@USERID", count);
                    cmd3.ExecuteNonQuery();
                    conn.Close();
                    FoodOrder fo = new FoodOrder(count);
                    this.Hide();
                    fo.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Sorry, Invalid User, Try Loging in again.", "Ivalid Login Details", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
        }
    }
}
