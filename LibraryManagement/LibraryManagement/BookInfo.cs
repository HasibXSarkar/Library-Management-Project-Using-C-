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
    public partial class BookInfo : Form
    {
        public BookInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BookView bookView = new BookView(); 
            bookView.Show();
            this.Hide();
        }

        private void btnauthor_Click(object sender, EventArgs e)
        {
            Author author = new Author();
            author.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Category_View categoryView = new Category_View();
            categoryView.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BookAuthor author = new BookAuthor();
            author.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BookEdition bookEdition = new BookEdition();
            bookEdition.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BookBorrowView bookBorrowView = new BookBorrowView();
            bookBorrowView.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Log_In log_In = new Log_In();
            log_In.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            PublisherTable publisherTable = new PublisherTable();
            publisherTable.Show();
            this.Hide();
        }
    }
}
