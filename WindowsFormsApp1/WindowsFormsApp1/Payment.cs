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
    public partial class Payment : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=SQLSERVERDEV\ITE5233A;Initial Catalog=FINALDB;Integrated Security=True;");
        SqlCommand cmd;
        int tempuserid = 0,flag=0;
        float tempprice=0;
        public Payment(int userid)
        {
            InitializeComponent();
            conn.Open();
            cmd = new SqlCommand("select sum(price) from order_details where user_id='"+ userid +"'", conn);
            SqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {
                textBoxTotal.Text = da.GetValue(0).ToString() + "$";
                tempprice = float.Parse(da.GetValue(0).ToString());
            }
            tempuserid = userid;
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Do you want to close this window?", title, buttons);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                // 
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            
            if (textBoxCardName.Text == "" || textBoxCardNo.Text =="" || textBoxCvv.Text == "")
            {
                MessageBox.Show("Every payment field should be filled in order to complete the payment.","InComplete Details",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                
                if (textBoxCardNo.Text.Length != 16 )
                {
                     MessageBox.Show("Enter valid Card number of length 16.","Invalid Card No",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                else if(textBoxCvv.Text.Length != 3)
                {
                    MessageBox.Show("Enter valid Cvv of length 3.","Wrong CVV",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        long no = long.Parse(textBoxCardNo.Text);
                        int cvv = Int32.Parse(textBoxCvv.Text);
                        flag = 1;
                    }
                    catch
                    {
                        flag = 0;
                        MessageBox.Show("Enter only Numbers","Invalid Charectors",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    if (flag == 1)
                    {
                        string message = "Do you want to confirm Your Payment?";
                        string title = "Payment Confirmation!!";
                        MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                        DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
                        if (result == DialogResult.OK)
                        {
                            Summary summary = new Summary(tempuserid, tempprice);
                            this.Hide();
                            summary.Show();
                        }
                        else
                        {
                            // Do something  
                        }
                    }
                }
            }

        }
    }
}
