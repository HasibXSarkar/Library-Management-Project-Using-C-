using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class Author : MetroFramework.Forms.MetroForm
    {
        public Author()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.LoadAuthor();
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void Author_Load(object sender, EventArgs e)
        {
            this.LoadAuthor();
            this.NewData();
        }
        private void LoadAuthor()
        {
            string query = "select * from Author";
            string error;
            DataTable dt = DataAccess.GetData(query, out error);
            if (String.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show("Opps Something Went Wrong!");
                return;
            }
            dgvAuthor.AutoGenerateColumns = false;
            dgvAuthor.DataSource = dt;
            dgvAuthor.Refresh();
            dgvAuthor.ClearSelection();
        }

        private void dgvAuthor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >=0) {
                string id = dgvAuthor.Rows[e.RowIndex].Cells[0].Value.ToString(); 
                this.LoadDetail(id);
            }

        }
        private void LoadDetail(string id)
        {
            var query = "select * from Author where Id = " + id + "";
            string error;
            var dt = DataAccess.GetData(query, out error);
            if(String.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show("Opps Something Went Wrong!");
                return;
            }
            athrIdtxt.Text = dt.Rows[0]["Id"].ToString();
            athrNmtxt.Text = dt.Rows[0]["Name"].ToString();

        }

        private void athrbtn1_Click(object sender, EventArgs e)
        {
            this.NewData();
        }
        private void NewData()
        {
            athrIdtxt.Text = "";
            athrNmtxt.Text = "";
            dgvAuthor.ClearSelection();
        }

        private void athrbtn2_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(athrIdtxt.Text))
            {
                MessageBox.Show("Please select a row to delete");
                return;
            }
            var result = MessageBox.Show("Are you sure?", "Confirmation!", MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
            if( result == DialogResult.Yes)
            {
                var query = "delete from Author where Id = " + athrIdtxt.Text + "";
                string error;
                DataAccess.ExecuteData(query, out error);
                if(String.IsNullOrEmpty(error) == false)
                {
                    MessageBox.Show(error);
                    return;
                }
                this.LoadAuthor();
                this.NewData();
                MessageBox.Show("Successfully Deleted :) ");
            }
        }

        private void athrbtn4_Click(object sender, EventArgs e)
        {
            string id = athrIdtxt.Text;
            string name = athrNmtxt.Text;
            if (String.IsNullOrEmpty(name))
            {
                MessageBox.Show("Invalid Name");
                athrNmtxt.Focus();
            }
            if (String.IsNullOrEmpty(id))
            {
                var query = "insert into Author(name) output inserted.Id  values ('"+name+"')";
                string error;
                var dt = DataAccess.GetData(query, out error);
                if (String.IsNullOrEmpty(error) == false) { MessageBox.Show(error); return; }
                athrIdtxt.Text = dt.Rows[0]["ID"].ToString();
                MessageBox.Show("Inserted Successfully.");


            }
            else
            {
                var query = "update Author set[Name] = '" + name + "' where id = " + id + "";
                string error;
                DataAccess.ExecuteData(query, out error);
                if(String.IsNullOrEmpty(error) == false)
                {
                    MessageBox.Show(error);
                }
                MessageBox.Show("Updated");
            }
            this.LoadAuthor();
            for(int i = 0;i<dgvAuthor.Rows.Count;i++)
            {
                if (dgvAuthor.Rows[i].Cells[0].Value.ToString()==athrIdtxt.Text)
                {
                    dgvAuthor.Rows[i].Selected = true;
                    break;
                }
            }
        }

        private void dgvAuthor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BookInfo bookInfo = new BookInfo();
            bookInfo.Show();
            this.Hide();
        }
    }
}
