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
    public partial class Summary : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=SQLSERVERDEV\ITE5233A;Initial Catalog=FINALDB;Integrated Security=True;");
        SqlCommand cmd;
        int user = 0;
        public Summary(int userid, float tempprice)
        {
            InitializeComponent();
            conn.Open();
            cmd = new SqlCommand("select * from user_details where user_id='" + userid + "'", conn);
            SqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            { 
                labelInputName.Text = da.GetValue(1).ToString();
                labelInputPhone.Text = da.GetValue(3).ToString();
            }
            conn.Close();
            labelInputTotal.Text = tempprice.ToString()+"$";
            user = userid;
        }

        private void buttonDetailedSummary_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("Select food_item,price from order_details where user_id='" + user + "'", conn);
            {
                cmd.CommandType = CommandType.Text;
            }
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            using(DataTable dt = new DataTable())
            {
                sda.Fill(dt);
                using(DetailedSummary ds = new DetailedSummary(dt))
                {
                    ds.ShowDialog();
                }
            }
            conn.Close();
        }

        private void Summary_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}