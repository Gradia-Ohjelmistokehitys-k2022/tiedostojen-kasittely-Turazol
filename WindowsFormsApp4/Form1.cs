using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // create a datatable
            DataTable table = new DataTable();

            // add columns to datatable
            table.Columns.Add("id");
            table.Columns.Add("username");

            // add rows to datatable
            table.Rows.Add("1", "PHP");
            table.Rows.Add("2", "C#");
            table.Rows.Add("3", "Java");
            table.Rows.Add("4", "Javascript");
            table.Rows.Add("5", "C++");

            comboBox1.DataSource = table;
            comboBox1.DisplayMember = "id";
        }
    }
}
