using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class DetailedSummary : Form
    {
        public DetailedSummary(DataTable dt)
        {
            InitializeComponent();
            dataGridView.DataSource = dt;
        }
        private void DetailedSummary_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Visible = false;
        }
    }
}
