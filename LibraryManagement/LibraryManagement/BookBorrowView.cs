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
    public partial class BookBorrowView : Form
    {
        public BookBorrowView()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BookBorrowView_Load(object sender, EventArgs e)
        {
            //this.InitialSupportingData();
            this.LoadBookInfo();
        }
        private void InitialSupportingData()
        {
            var query = "SELECT * FROM UserInfo";
            string error;
            DataTable dt = DataAccess.GetData(query, out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            aiub_id_txt.Text = dt.Rows[0]["Aiub_Id"].ToString();
            //this.NewData();


        }
        private void LoadBookInfo()
        {
            string query = "select Book_Borrow.Id,Book_Borrow.Date_Borrowed,Book_Borrow.Date_Returned,Book_Borrow.Due_Date,UserInfo.Aiub_Id,Book_Edition.Id 'Book Edition',Book_Borrow.Is_Returned,Book_Borrow.Report from Book_Borrow inner join Book_Edition on Book_Borrow.Book_Edition_Id=Book_Edition.Id inner join UserInfo on Book_Borrow.[User_Id]=UserInfo.Id";
            string error = "";
            DataTable dt = DataAccess.GetData(query, out error);
            if (string.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show(error, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            bookBorrow_grid.AutoGenerateColumns = false;
            bookBorrow_grid.DataSource = dt;
            bookBorrow_grid.Refresh();
            bookBorrow_grid.ClearSelection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string id = aiub_id_txt.Text;

                if (string.IsNullOrEmpty(id))
                {
                    MessageBox.Show("Please Enter Aiub ID.");
                    aiub_id_txt.Focus();
                    return;
                }

                var query = $@"
            SELECT 
                Book_Borrow.Id,
                Book_Borrow.Date_Borrowed,
                Book_Borrow.Date_Returned,
                Book_Borrow.Due_Date,
                UserInfo.Aiub_Id,
                Book_Edition.Id AS 'Book Edition',
                Book_Borrow.Is_Returned,
                Book_Borrow.Report 
            FROM 
                Book_Borrow 
            INNER JOIN 
                Book_Edition ON Book_Borrow.Book_Edition_Id = Book_Edition.Id
            INNER JOIN 
                UserInfo ON Book_Borrow.[User_Id] = UserInfo.Id
            where Book_Borrow.User_Id = '"+id+"'";

                string error;
                var dt = DataAccess.GetData(query, out error);

                if (!string.IsNullOrEmpty(error))
                {
                    MessageBox.Show(error);
                    return;
                }

                if (dt.Rows.Count > 0)
                {
                    book_id_txt.Text = dt.Rows[0]["Id"].ToString();
                    MessageBox.Show("Found");
                }
                else
                {
                    MessageBox.Show("No records found for the specified Aiub ID.");
                    return;
                }

                for (int i = 0; i < bookBorrow_grid.Rows.Count; i++)
                {
                    if (bookBorrow_grid.Rows[i].Cells[0].Value.ToString() == book_id_txt.Text)
                    {
                        bookBorrow_grid.Rows[i].Selected = true;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }


        private void bookBorrow_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bookBorrow_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var id = bookBorrow_grid.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.LoadDetails(id);


            }
        }

        private void LoadDetails(string id)
        {
            string query = "select *from Book_Borrow where Book_Borrow.Id=" + id + "";

            string error = "";

            DataTable dt = DataAccess.GetData(query, out error);
            if (string.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show(error, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            book_id_txt.Text = dt.Rows[0]["Id"].ToString();
            //aiub_id_txt.Text = dt.Rows[0]["User_Id"].ToString();
            string dueDateAsString = dt.Rows[0]["Due_Date"].ToString();
            if (DateTime.TryParse(dueDateAsString, out DateTime dueDate))
            {
                due_date.Value = dueDate;
            }
            else
            {
                // Handle the case where the conversion fails
                // You may want to set a default value or log an error
            }

            string returnDateAsString = dt.Rows[0]["Due_Date"].ToString();
            if (DateTime.TryParse(dueDateAsString, out DateTime returnDate))
            {
                due_date.Value = returnDate;
            }
            else
            {
                // Handle the case where the conversion fails
                // You may want to set a default value or log an error
            }
            //return_date.Value = (DateTime)dt.Rows[0]["Date_Returned"];


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
            if (dt.Rows.Count >0)
            {
                string Return = dt.Rows[0]["Is_Returned"].ToString().Trim(); // Trim to remove whitespace

                if (String.Equals(Return, "Yes", StringComparison.OrdinalIgnoreCase))
                {
                    return_yes.Checked = true;

                }
                else if (String.Equals(Return, "No", StringComparison.OrdinalIgnoreCase))
                {
                    return_no.Checked = true;

                }
            }




        }

        private void Save_Click(object sender, EventArgs e)
        {

            string id = book_id_txt.Text;
            string updatedDue = due_date.Value.ToString("yyyy-MM-dd");
            string returndate = return_date.Value.ToString("yyyy-MM-dd");
            string updatedReturn = "";
            if (return_yes.Checked == true) { updatedReturn = "Yes"; }
            else if (return_no.Checked == true) { updatedReturn = "No"; }
            // int updatedCatId = -1;
            string query = "UPDATE Book_Borrow SET " +
   "Due_Date = '" + updatedDue + "', " +
   "Date_Returned = '" + returndate + "', " +
   "Is_Returned = '" + updatedReturn + "' " +
   "WHERE Id = " + id;


            string error;
            DataAccess.ExecuteData(query, out error);
            if (string.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show(error);
                return;
            }
            //this.LoadBookInfo();
            string title = txtbkname.Text;
            query = "update book set A_count = A_count+1 Where Title = '" + title + "'";
            DataAccess.ExecuteData(query, out error);
            if (String.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show(error);
                return;
            }
            MessageBox.Show("Updated");

            for (int i = 0; i < bookBorrow_grid.Rows.Count; i++)
            {
                if (bookBorrow_grid.Rows[i].Cells[0].Value.ToString() == aiub_id_txt.Text)
                {
                    bookBorrow_grid.Rows[i].Selected = true;
                    break;
                }
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            this.NewData();
        }

        private void NewData()
        {
            book_id_txt.Text = "";
            aiub_id_txt.Text = "";
            due_date.Value = DateTime.Today;
            return_date.Value = DateTime.Today;
            return_yes.Checked = false;
            return_no.Checked = false;
            bookBorrow_grid.ClearSelection();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            BookInfo bookInfo = new BookInfo();
            bookInfo.Show();
            this.Hide();
        }
    }
}
