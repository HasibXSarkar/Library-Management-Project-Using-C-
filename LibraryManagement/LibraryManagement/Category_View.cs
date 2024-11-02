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
    public partial class Category_View : Form
    {
        public Category_View()
        {
            InitializeComponent();
        }

        private void LoadCatInfo()
        {
            string query = "select Id ,Name from Category";
            string error = "";
            DataTable dt = DataAccess.GetData(query, out error);
            if (string.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show(error, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            cat_grid.AutoGenerateColumns = false;
            cat_grid.DataSource = dt;
            cat_grid.Refresh();
            cat_grid.ClearSelection();
        }

        private void New_Click(object sender, EventArgs e)
        {
            this.NewData();
        }

        private void NewData()
        {
            cat_id.Text = "";
            cat_nme_txt.Text = "";

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cat_id.Text))
            {
                MessageBox.Show("Please Select a row.");
                return;

            }

            var result = MessageBox.Show("Are You Sure!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {

                var query = "Delete from Category where id=" + cat_id.Text;
                string error;
                DataAccess.ExecuteData(query, out error);
                if (string.IsNullOrEmpty(error) == false)
                {
                    MessageBox.Show(error);
                    return;
                }
                this.LoadCatInfo();
                this.NewData();
                MessageBox.Show("Successfully Deleted.");

            }
        }

        private void Category_View_Load(object sender, EventArgs e)
        {
            this.LoadCatInfo();
        }

        private void cat_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            {
                if (e.RowIndex >= 0)
                {
                    var id = cat_grid.Rows[e.RowIndex].Cells[0].Value.ToString();
                    this.LoadDetails(id);


                }

            }
        }


        private void LoadDetails(string id)
        {
            string query = "select *from Category where Category.Id=" + id + "";

            string error = "";

            DataTable dt = DataAccess.GetData(query, out error);
            if (string.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show(error, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            cat_id.Text = dt.Rows[0]["Id"].ToString();
            cat_nme_txt.Text = dt.Rows[0]["Name"].ToString();





        }

        private void Save_Click(object sender, EventArgs e)
        {

        }

        private void Save_Click_1(object sender, EventArgs e)
        {
            string id = cat_id.Text;
            string updatedTitle = cat_nme_txt.Text;

            int updatedCatId = -1;
            if (string.IsNullOrEmpty(updatedTitle))
            {
                MessageBox.Show("Please Enter Category Name .");
                cat_nme_txt.Focus();
                return;

            }


            if (string.IsNullOrEmpty(id))
            {
                var query = "insert into Category(Name) output inserted.id " +
                    "values('" + updatedTitle + "')";
                string error;
                var dt = DataAccess.GetData(query, out error);
                if (string.IsNullOrEmpty(error) == false)
                {
                    MessageBox.Show(error);
                    return;
                }
                cat_id.Text = dt.Rows[0]["Id"].ToString();
                this.LoadCatInfo();
                MessageBox.Show("Inserted");




            }

            else
            {
                string query = "UPDATE Book SET " +
               "Title = '" + updatedTitle + "', " +
               "WHERE Id = " + id;

                string error;
                DataAccess.ExecuteData(query, out error);
                if (string.IsNullOrEmpty(error) == false)
                {
                    MessageBox.Show(error);
                    return;
                }
                this.LoadCatInfo();
                MessageBox.Show("Updated");
            }

            for (int i = 0; i < cat_grid.Rows.Count; i++)
            {
                if (cat_grid.Rows[i].Cells[0].Value.ToString() == cat_id.Text)
                {
                    cat_grid.Rows[i].Selected = true;
                    break;
                }
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            this.LoadCatInfo();
            this.NewData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BookInfo bookInfo = new BookInfo();
            bookInfo.Show();
            this.Hide();
        }
    }
}
