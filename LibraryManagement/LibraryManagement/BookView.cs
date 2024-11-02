using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class BookView : Form
    {
        public BookView()
        {
            InitializeComponent();
        }

        private void BookView_Load(object sender, EventArgs e)
        {
            this.InitialSupportingData();
            this.LoadBookInfo();

        }


        private void InitialSupportingData()
        {
            var query = "select *from Category";
            string error;
            DataTable dt = DataAccess.GetData(query, out error);
            if (string.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show(error, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            book_cat_combo.DataSource = dt;
            book_cat_combo.DisplayMember = "Name";
            book_cat_combo.ValueMember = "Id";
            this.NewData();


        }
        private void LoadBookInfo()
        {
            string query = "select Book.Id,Book.Title,Category.[Name]'Category' ,Count,A_count from Book inner join Category on Book.Category_Id=Category.Id";
            string error = "";
            DataTable dt = DataAccess.GetData(query, out error);
            if (string.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show(error, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            book_grid.AutoGenerateColumns = false;
            book_grid.DataSource = dt;
            book_grid.Refresh();
            book_grid.ClearSelection();
        }

        private void New_Click(object sender, EventArgs e)
        {
            this.NewData();
        }

        private void NewData()
        {
            book_id_txt.Text = "";
            book_title_txt.Text = "";
            book_cat_combo.SelectedItem = null;
            book_count_txt.Text = "";
            book_a_txt.Text = "";

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(book_id_txt.Text))
            {
                MessageBox.Show("Please Select a row.");
                return;

            }

            var result = MessageBox.Show("Are You Sure!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {

                var query = "Delete from Book where id=" + book_id_txt.Text;
                string error;
                DataAccess.ExecuteData(query, out error);
                if (string.IsNullOrEmpty(error) == false)
                {
                    MessageBox.Show(error);
                    return;
                }
                this.LoadBookInfo();
                this.NewData();
                MessageBox.Show("Successfully Deleted.");

            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            this.LoadBookInfo();
            this.NewData();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            string id = book_id_txt.Text;
            string updatedTitle = book_title_txt.Text;
            string updatedCount = book_count_txt.Text;
            string updatedAc = book_a_txt.Text;
            int updatedCatId = -1;
            if (string.IsNullOrEmpty(updatedTitle))
            {
                MessageBox.Show("Please Enter Title Name .");
                book_title_txt.Focus();
                return;

            }

            try
            {
                updatedCatId = Int32.Parse(book_cat_combo.SelectedValue.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Went Wrong");
            }

            if (updatedCatId == -1)
            {
                MessageBox.Show("Invalid Category ID");
                return;

            }
            if (string.IsNullOrEmpty(id))
            {
                var query = "insert into Book(Title,Category_Id,Count,A_count) output inserted.id " +
                    "values('" + updatedTitle + "'," + updatedCatId + ",'" + updatedCount + "'," + updatedAc + ")";
                string error;
                var dt = DataAccess.GetData(query, out error);
                if (string.IsNullOrEmpty(error) == false)
                {
                    MessageBox.Show(error);
                    return;
                }
                book_title_txt.Text = dt.Rows[0]["Id"].ToString();
                this.LoadBookInfo();
                MessageBox.Show("Inserted");




            }

            else
            {
                string query = "UPDATE Book SET " +
               "Title = '" + updatedTitle + "', " +
               "Category_Id = '" + updatedCatId + "', " +
               "Count = '" + updatedCount + "', " +
               "A_count = '" + updatedAc + "' " +
               "WHERE Id = " + id;

                string error;
                DataAccess.ExecuteData(query, out error);
                if (string.IsNullOrEmpty(error) == false)
                {
                    MessageBox.Show(error);
                    return;
                }
                this.LoadBookInfo();
                MessageBox.Show("Updated");
            }

            for (int i = 0; i < book_grid.Rows.Count; i++)
            {
                if (book_grid.Rows[i].Cells[0].Value.ToString() == book_id_txt.Text)
                {
                    book_grid.Rows[i].Selected = true;
                    break;
                }
            }
        }

        private void book_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var id = book_grid.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.LoadDetails(id);


            }
        }
        private void LoadDetails(string id)
        {
            string query = "select *from Book where Book.Id=" + id + "";

            string error = "";

            DataTable dt = DataAccess.GetData(query, out error);
            if (string.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show(error, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            book_id_txt.Text = dt.Rows[0]["Id"].ToString();
            book_title_txt.Text = dt.Rows[0]["Title"].ToString();
            book_cat_combo.SelectedValue = dt.Rows[0]["Category_Id"];

            //if (dt.Rows.Count >= 0)
            //{
            //    string category = dt.Rows[0]["Category_Id"].ToString().Trim(); // Trim to remove whitespace


            //    if (book_cat_combo.Items.Contains(category))
            //    {
            //        book_cat_combo.SelectedItem = category;
            //    }
            //    else
            //    {

            //        Console.WriteLine("User Type not found in ComboBox items.");
            //    }
            //}
            book_count_txt.Text = dt.Rows[0]["Count"].ToString();
            book_a_txt.Text = dt.Rows[0]["A_count"].ToString();




        }

        private void book_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BookInfo book = new BookInfo();
            book.Show();
            this.Hide();
        }
    }
}
