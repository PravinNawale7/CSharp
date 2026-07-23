using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqToSqlProject
{
    public partial class Form2 : Form
    {
        CompanyDBDataContext dc;

        public Form2()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        private void LoadData()
        {
            dc = new CompanyDBDataContext();
            dgView.DataSource = dc.Employees;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.ShowDialog();

            LoadData();

        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (dgView.SelectedRows.Count > 0)
            {
                Form3 f = new Form3();
                f.textBox1.ReadOnly = true;
                f.Clear.Enabled = false;
                f.Save.Text = "Update";
                f.textBox1.Text = dgView.SelectedRows[0].Cells[0].Value.ToString();
                f.textBox2.Text = dgView.SelectedRows[0].Cells[1].Value.ToString();
                f.textBox3.Text = dgView.SelectedRows[0].Cells[2].Value.ToString();
                f.textBox4.Text = dgView.SelectedRows[0].Cells[3].Value.ToString();
                f.textBox5.Text = dgView.SelectedRows[0].Cells[4].Value.ToString();
                f.ShowDialog();
                LoadData();
            }
            else
            {
                MessageBox.Show("Please Select a Record for update.","Information",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }




        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if(dgView.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are You sure of Deleting a record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
                {
                    int Eno = Convert.ToInt32(dgView.SelectedRows[0].Cells[0].Value);
                    Employee obj = dc.Employees.SingleOrDefault(E => E.Eno == Eno);
                    dc.Employees.DeleteOnSubmit(obj);
                    dc.SubmitChanges();
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Please Select a Record for Deletion.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
