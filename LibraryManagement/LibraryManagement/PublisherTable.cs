using Newtonsoft.Json.Bson;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class PublisherTable : MetroFramework.Forms.MetroForm
    {
        public PublisherTable()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PublisherTable_Load(object sender, EventArgs e)
        {
            String query = " Select * from Publisher ";
            string error;

            DataTable dt = DataAccess.GetData(query, out error);
            if (String.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show(text: error, caption: "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            PublisherGrid.DataSource = dt;
            PublisherGrid.Refresh();
            PublisherGrid.ClearSelection();

        }


        private void LoadPublisher()
        {



            String query = " Select * from Publisher ";
            string error;

            DataTable dt = DataAccess.GetData(query, out error);
            if (String.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show(text: error, caption: "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            PublisherGrid.DataSource = dt;
            PublisherGrid.Refresh();
            PublisherGrid.ClearSelection();



        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {
            this.LoadPublisher();


        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LoadPublisher();
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {
            this.LoadPublisher();
        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {
            this.LoadPublisher();
        }

        private void PublisherGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)

            {
                string id = PublisherGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.LoadPublisher(id);


            }
        }


        private void LoadPublisher(string id)
        {
            var query = "select * from Publisher where id= " + id + "";

            string error;
            var dt = DataAccess.GetData(query, out error);


            if (string.IsNullOrEmpty(error) == false)
            {

                MessageBox.Show(error);
                return;

            }

            PublisherId.Text = dt.Rows[0]["ID"].ToString();

            PublisherName.Text = dt.Rows[0]["Name"].ToString();







        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.NewData();

        }

        private void NewData()
        {

            PublisherId.Text = "";
            PublisherName.Text = "";

            PublisherGrid.ClearSelection();



        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            string id = PublisherId.Text;

            if (string.IsNullOrEmpty(PublisherId.Text))

            {

                MessageBox.Show(text: "Please select a row");
                return;

            }

            var result = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)

            {
                var query = "Delete from Publisher where id =" + id + "";
                string error;
                DataAccess.ExecuteData(query, out error);

                if (string.IsNullOrEmpty(error) == false)
                {

                    MessageBox.Show(error);
                    return;

                }
                this.LoadPublisher();
                this.NewData();
                MessageBox.Show("Deleted");


            }


        }

        private void metroButton4_Click(object sender, EventArgs e)
        {

            string id = PublisherId.Text;
            string name = PublisherName.Text;

            if (string.IsNullOrEmpty(Name))

            {
                MessageBox.Show("Invalid Name");
                PublisherName.Focus();
                return;
            }

            if (string.IsNullOrEmpty(id))
            {
                var query = "insert into publisher (Name) output inserted.Id values ('" + name + "')";


                string error;
                var dt = DataAccess.GetData(query, out error);

                if (string.IsNullOrEmpty(error) == false)

                {
                    MessageBox.Show(error);
                    return;



                }
                PublisherId.Text = dt.Rows[0]["ID"].ToString();
                MessageBox.Show("Inserted Successfully.");


            }

            else
            {
                var query = " update Publisher set Name = '" + name + "' where id = '" + id + "'";
                string error;

                DataAccess.ExecuteData(query, out error);

                if (string.IsNullOrEmpty(error) == false)
                {
                    MessageBox.Show(error);
                    return;
                }

                MessageBox.Show("Update is done");




            }

            this.LoadPublisher();

            for (int i = 0; i < PublisherGrid.Rows.Count; i++)
            {
                if (PublisherGrid.Rows[i].Cells[0].Value.ToString() == PublisherId.Text)
                {
                    PublisherGrid.Rows[i].Selected = true;
                    break;
                }
            }





        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            this.LoadPublisher();
            this.NewData();
        }
    }

}




