using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class BookEdition : MetroFramework.Forms.MetroForm
    {
        public BookEdition()
        {
            InitializeComponent();
        }

        private void BookEdition_Load(object sender, EventArgs e)
        {
            this.initializeAdditionalData();
            this.LoadBookEdition();
        }
        private void initializeAdditionalData()
        {
            var query = "select * from Book";
            string error;
            DataTable dtBk = DataAccess.GetData(query, out error);
            if (String.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show("Opps Something Went Wrong!");
                return;
            }
            bkedcmbBookName.DataSource = dtBk;
            bkedcmbBookName.DisplayMember = "Title";
            bkedcmbBookName.ValueMember = "Id";

            query = "select * from Publisher";
            DataTable dtPb = DataAccess.GetData(query, out error);
            if (String.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show("Opps Something Went Wrong!");
                return;
            }
            bkedcmbPubName.DataSource = dtPb;
            bkedcmbPubName.DisplayMember = "Name";
            bkedcmbPubName.ValueMember = "Id";
            this.NewData();
        }
        private void LoadBookEdition()
        {
            string query = "select Book_Edition.Id as 'Id', Title as 'Book Name' ,[Name] as 'Publisher Name' ,Year_Published as 'Published Year' From Book_Edition \r\ninner join Book on Book_Edition.Book_Id = Book.Id\r\ninner join Publisher on Book_Edition.Publisher_Id = Publisher.Id";
            string error;
            DataTable dt = DataAccess.GetData(query, out error);
            if (String.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show("Opps Something Went Wrong!");
                return;
            }
            dgvbked.AutoGenerateColumns = false;
            dgvbked.DataSource = dt;
            dgvbked.Refresh();
            dgvbked.ClearSelection();
        }
        private void NewData()
        {
            bkedtxtId.Text = "";
            bkedtxtpubYear.Text = "";
            bkedcmbBookName.SelectedValue = -1;
            bkedcmbPubName.SelectedValue = -1;
            dgvbked.ClearSelection();
        }

        private void bkedbtn1_Click(object sender, EventArgs e)
        {
            this.NewData();
        }

        private void bkedbtn2_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(bkedtxtId.Text))
            {
                MessageBox.Show("Please select a row to delete");
                return;
            }
            var result = MessageBox.Show("Are you sure?", "Confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                var query = "delete from Book_Edition where Id = " + bkedtxtId.Text + "";
                string error;
                DataAccess.ExecuteData(query, out error);
                if (String.IsNullOrEmpty(error) == false)
                {
                    MessageBox.Show(error);
                    return;
                }
                this.LoadBookEdition();
                this.NewData();
                MessageBox.Show("Successfully Deleted :) ");
            }
        }

        private void dgvbked_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string id = dgvbked.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.LoadDetail(id);
            }
        }
        private void LoadDetail(string id)
        {
            var query = "select * from Book_Edition where Id = " + id + "";
            string error;
            var dt = DataAccess.GetData(query, out error);
            if (String.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show("Opps Something Went Wrong!");
                return;
            }
            bkedtxtId.Text = dt.Rows[0]["Id"].ToString();
            bkedcmbBookName.SelectedValue = dt.Rows[0]["Book_Id"].ToString();
            bkedcmbPubName.SelectedValue = dt.Rows[0]["Publisher_Id"].ToString();
            bkedtxtpubYear.Text= dt.Rows[0]["Year_Published"].ToString();

        }

        private void bkedbtn3_Click(object sender, EventArgs e)
        {

            this.LoadBookEdition();
            this.NewData();
        }

        private void bkedbtn4_Click(object sender, EventArgs e)
        {

            string id = bkedtxtId.Text;
            string year = bkedtxtpubYear.Text;
            int Bookid = -1;
            int Publisherid = -1;
            try
            {
                Bookid = Int32.Parse(bkedcmbBookName.SelectedValue.ToString());
                Publisherid = Int32.Parse(bkedcmbPubName.SelectedValue.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Opps Something Went Wrong!");
            }
            if (Bookid == -1 || Publisherid == -1)
            {
                MessageBox.Show("Invalid Book Title/ Author Name");
                return;
            }
            if (String.IsNullOrEmpty(id))
            {
                var query = "insert into Book_Edition (Book_Id,Publisher_Id,Year_Published) output inserted.Id values ('"+Bookid+ "','" +Publisherid+ "','"+year+ "')";
                string error;
                var dt = DataAccess.GetData(query, out error);
                if (String.IsNullOrEmpty(error) == false) { MessageBox.Show(error); return; }
                bkedtxtId.Text = dt.Rows[0]["ID"].ToString();
                MessageBox.Show("Inserted Successfully.");


            }
            else
            {
                var query = "update Book_Edition set Book_Id = " + Bookid + ",Publisher_Id = " + Publisherid + ",Year_Published = '"+ year + "'where id = " + id + "";
                string error;
                DataAccess.ExecuteData(query, out error);
                if (String.IsNullOrEmpty(error) == false)
                {
                    MessageBox.Show(error);
                }
                MessageBox.Show("Updated");
            }
            this.LoadBookEdition();
            for (int i = 0; i < dgvbked.Rows.Count; i++)
            {
                if (dgvbked.Rows[i].Cells[0].Value.ToString() == bkedtxtId.Text)
                {
                    dgvbked.Rows[i].Selected = true;
                    break;
                }
            }
        }

        private void dgvbked_CellContentClick(object sender, DataGridViewCellEventArgs e)
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


