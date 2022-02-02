using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App9
{
    public partial class Form2 : Form
    {
        DataTable table=new DataTable();
        public Form2(DataTable table,string roll)
        {
            InitializeComponent();
            this.table=table;
            foreach (DataRow row in this.table.Rows)
            {
                if (row["Roll#"].ToString() == roll)
                {
                    Roll_No.Text = row["Roll#"].ToString();
                    Name.Text= row["Name"].ToString();
                    Age.Text=row["Age"].ToString();
                }
            }
        }

        private void save_record_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(Age.Text) && !String.IsNullOrWhiteSpace(Name.Text))
            {
                foreach (DataRow row in table.Rows)
                {
                    if (row["Roll#"].ToString() == Roll_No.Text)
                    {
                        row["Name"] = Name.Text;
                        row["Age"] = Age.Text;
                        break;
                    }
                }
                Form1 f1 = new Form1(this.table);
                this.Hide();
                f1.Show();
            }
            else
            {
                MessageBox.Show("Kindly Fill the Requirements!");
            }
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1(this.table);
            this.Hide();
            f1.Show();
        }
    }
}
