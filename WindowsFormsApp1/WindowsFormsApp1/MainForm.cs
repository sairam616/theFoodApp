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

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=SQLSERVERDEV\ITE5233A;Initial Catalog=FINALDB;Integrated Security=True;");
        SqlCommand cmd;
        int count = 0;
        
        public MainForm()
        {
            InitializeComponent();
            conn.Open();
            cmd = new SqlCommand("select count(*) from user_details", conn);
            SqlDataReader sda = cmd.ExecuteReader();
            while (sda.Read())
            {
                count = Int32.Parse(sda.GetValue(0).ToString());
            }
            count = count + 1;
            conn.Close();

            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (textBoxAge.Text == "" || textBoxName.Text =="" || textBoxPhone.Text =="" || textBoxAlternate.Text =="")
            {
                MessageBox.Show("Please Fill every Text Box to save.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                conn.Open();
                string name = textBoxName.Text;
                int age = Int32.Parse(textBoxAge.Text);
                long phone = long.Parse(textBoxPhone.Text);
                long alternate = long.Parse(textBoxAlternate.Text);
                cmd = new SqlCommand("insert into user_details values ('"+ count +"','" + name + "','" + age + "','" + phone + "','" + alternate + "')", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data is saved in the Database","DataBase Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                conn.Close();
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            Signin s = new Signin();
            s.ShowDialog();    
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to close the app", "Close", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
