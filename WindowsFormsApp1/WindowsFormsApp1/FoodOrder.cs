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
    public partial class FoodOrder : Form
    {
        float Totalprice = 0;
        SqlConnection conn = new SqlConnection(@"Data Source=SQLSERVERDEV\ITE5233A;Initial Catalog=FINALDB;Integrated Security=True;");
        SqlCommand cmd,command;
        int rowcount = 0;

        public FoodOrder(int count)
        {
            InitializeComponent();
            rowcount = count;
            conn.Open();
            cmd = new SqlCommand("select * from food_items",conn);
            SqlDataReader fda = cmd.ExecuteReader();
            while (fda.Read())
            {
                comboBoxFood.Items.Add(fda.GetString(0).Trim()+"-"+fda.GetInt32(1)+" $");
            }
            conn.Close();

            conn.Open();
            command = new SqlCommand("Select * from beverage_items", conn);
            SqlDataReader bda = command.ExecuteReader();
            while (bda.Read())
            {
                comboBoxBeverages.Items.Add(bda.GetString(0).Trim()+"-"+bda.GetInt32(1)+ " $");
            }
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //btn Add Beverage
            if (comboBoxBeverages.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Beverage Before adding.","Void Item",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

            if (comboBoxBeverages.SelectedIndex > -1)
            {

                listBoxNames.Visible = true;
                listBoxPrice.Visible = true;
                labelTotal.Visible = true;
                labelItemNames.Visible = true;
                labelPrice.Visible = true;
                buttonClearCart.Visible = true;
                string item = comboBoxBeverages.SelectedItem.ToString();
                string[] details = item.Split('-');
                string[] temp = details[1].Split(' ');
                Totalprice = Totalprice + float.Parse(temp[0]);
                listBoxNames.Items.Add(details[0]);
                listBoxPrice.Items.Add(details[1]);
                labelTotal.Text = "Total:" + Totalprice + "$";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //btn Continue
           
            string message = "Are You sure to Place the Order?";
            string title = "Order Confirmation!!";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(message, title, buttons,MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                conn.Open();
                for (int i = 0; i < listBoxNames.Items.Count; i++)
                {
                    string Name = listBoxNames.Items[i].ToString();
                    string temp = listBoxPrice.Items[i].ToString();
                    string[] cost = temp.Split(' ');
                    cmd = new SqlCommand("insert into order_details values('"+ rowcount +"','"+ Name +"','"+ cost[0] +"')", conn);
                    cmd.ExecuteNonQuery();  
                }
                conn.Close();
                MessageBox.Show("Your Order is Added to the cart.","Cart Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Payment paymentform = new Payment(rowcount);
                paymentform.Visible = true;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (comboBoxFood.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a food item Before adding.","Void Item",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

            //btn Food
            if(comboBoxFood.SelectedIndex > -1)
            {
                listBoxNames.Visible = true;
                listBoxPrice.Visible = true;
                labelTotal.Visible = true;
                labelItemNames.Visible = true;
                labelPrice.Visible = true;
                buttonClearCart.Visible = true;
                string item = comboBoxFood.SelectedItem.ToString();
                string[] details = item.Split('-');
                string[] temp = details[1].Split(' ');
                Totalprice = Totalprice + float.Parse(temp[0]);
                listBoxNames.Items.Add(details[0]);
                listBoxPrice.Items.Add(details[1]);
                labelTotal.Text = "Total:" + Totalprice + "$";
            }
        }

        private void listBoxNames_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxPrice_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelTotal_Click(object sender, EventArgs e)
        {

        }

        private void buttonClearCart_Click(object sender, EventArgs e)
        {
                listBoxNames.Items.Clear();
                listBoxPrice.Items.Clear();
                Totalprice = 0;
                labelTotal.Text = " ";
        }

        private void buttonClearSelected_Click(object sender, EventArgs e)
        {
            int indexVal = 0;
            if(listBoxNames.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an item to clear from the cart.", "Void Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (listBoxNames.SelectedIndex > -1)
            {
                indexVal = listBoxNames.SelectedIndex;
                listBoxNames.Items.RemoveAt(listBoxNames.SelectedIndex);
                string cost = listBoxPrice.Items[indexVal].ToString();
                listBoxPrice.Items.RemoveAt(indexVal);
                string[] temp = cost.Split(' ');
                Totalprice = Totalprice - float.Parse(temp[0]);
                labelTotal.Text = "Total:" + Totalprice;
            }
        }
    }
}
