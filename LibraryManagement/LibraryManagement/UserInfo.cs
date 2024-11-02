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
    public partial class UserInfo : Form
    {
        public UserInfo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void UserInfo_Load(object sender, EventArgs e)
        {
            this.LoadUserInfo();
        }



        private void LoadUserInfo()
        {
            string query = "select Id,Name,Gender,Phone,Email,Password,User_Type,Status,Address from UserInfo";
            string error = "";
            DataTable dt = DataAccess.GetData(query, out error);
            if (string.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show(error, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            user_grid.AutoGenerateColumns = false;
            user_grid.DataSource = dt;
            user_grid.Refresh();
            user_grid.ClearSelection();
        }



        private void Refresh_Click(object sender, EventArgs e)
        {
            this.LoadUserInfo();
            this.NewData();
        }

        private void user_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var id = user_grid.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.LoadDetails(id);
                //MessageBox.Show(id);

            }


            //MessageBox.Show(e.RowIndex + "");
        }

        private void LoadDetails(string id)
        {
            string query = "select *from UserInfo where Id=" + id + "";

            string error = "";

            DataTable dt = DataAccess.GetData(query, out error);
            if (string.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show(error, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            usr_id_txt.Text = dt.Rows[0]["Id"].ToString();
            user_name_txt.Text = dt.Rows[0]["Name"].ToString();
            if (dt.Rows.Count >= 0)
            {
                string gender = dt.Rows[0]["Gender"].ToString().Trim(); // Trim to remove whitespace

                if (String.Equals(gender, "Male", StringComparison.OrdinalIgnoreCase))
                {
                    usr_male.Checked = true;

                }
                else if (String.Equals(gender, "Female", StringComparison.OrdinalIgnoreCase))
                {
                    usr_female.Checked = true;

                }
            }

            usr_phn_txt.Text = dt.Rows[0]["Phone"].ToString();
            usr_eml_txt.Text = dt.Rows[0]["Email"].ToString();
            usr_pass_txt.Text = dt.Rows[0]["Password"].ToString();
            usr_add_txt.Text = dt.Rows[0]["Address"].ToString();
            if (dt.Rows.Count >= 0)
            {
                string userType = dt.Rows[0]["User_Type"].ToString().Trim(); // Trim to remove whitespace

                // Debugging/logging
                // Console.WriteLine("User Type from Database: " + userType);

                // Check ComboBox items before setting SelectedItem
                if (user_type_com.Items.Contains(userType))
                {
                    user_type_com.SelectedItem = userType;
                }
                else
                {
                    // Handle the case when the user type is not in the ComboBox items
                    // You might want to add a default or handle it differently based on your requirements.
                    Console.WriteLine("User Type not found in ComboBox items.");
                }
            }

            if (dt.Rows.Count >= 0)
            {
                string status = dt.Rows[0]["Status"].ToString().Trim(); // Trim to remove whitespace

                // Debugging/logging
                //Console.WriteLine("Status from Database: " + status);

                // Check status values before setting Checked property
                if (String.Equals(status, "Valid", StringComparison.OrdinalIgnoreCase))
                {
                    user_valid.Checked = true;
                    return;
                }
                else if (String.Equals(status, "Invalid", StringComparison.OrdinalIgnoreCase))
                {
                    user_invalid.Checked = true;
                    return;
                }
            }



        }

        private void New_Click(object sender, EventArgs e)
        {
            this.NewData();
        }

        private void NewData()
        {
            usr_id_txt.Text = "";
            user_name_txt.Text = "";
            usr_male.Checked = false;
            usr_female.Checked = false;
            usr_phn_txt.Text = "";
            usr_eml_txt.Text = "";
            usr_pass_txt.Text = "";
            usr_add_txt.Text = "";
            user_type_com.SelectedItem = null;
            user_valid.Checked = false;
            user_grid.ClearSelection();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(usr_id_txt.Text))
            {
                MessageBox.Show("Please Select a row.");
                return;

            }

            var result = MessageBox.Show("Are You Sure!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {

                var query = "Delete from userinfo where id=" + usr_id_txt.Text;
                string error;
                DataAccess.ExecuteData(query, out error);
                if (string.IsNullOrEmpty(error) == false)
                {
                    MessageBox.Show(error);
                    return;
                }
                this.LoadUserInfo();
                this.NewData();
                MessageBox.Show("Successfully Deleted.");

            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            string id = usr_id_txt.Text;
            string updatedName = user_name_txt.Text;
            string updatedGender = usr_male.Checked ? "Male" : "Female";
            string updatedPhone = usr_phn_txt.Text;
            string updatedEmail = usr_eml_txt.Text;
            string updatedPassword = usr_pass_txt.Text;
            string updatedAddress = usr_add_txt.Text;
            string updatedUserType = user_type_com.SelectedItem?.ToString();
            string updatedStatus = user_valid.Checked ? "Valid" : "Invalid";
            if (string.IsNullOrEmpty(updatedName))
            {
                MessageBox.Show("Please Enter Your Name .");
                user_name_txt.Focus();
                return;

            }
            if (string.IsNullOrEmpty(id))
            {
                var query = "insert into UserInfo(Name,Gender,phone,Email,Password,User_Type,Status,Address) output inserted.id values('" + updatedName + "','" + updatedGender + "'," + updatedPhone + ",'" + updatedEmail + "','" + updatedPassword + "','" + updatedUserType + "','" + updatedStatus + "','" + updatedAddress + "')";
                string error;
                var dt = DataAccess.GetData(query, out error);
                if (string.IsNullOrEmpty(error) == false)
                {
                    MessageBox.Show(error);
                    return;
                }
                usr_id_txt.Text = dt.Rows[0]["Id"].ToString();
                this.LoadUserInfo();
                MessageBox.Show("Inserted");

            }
            else
            {
                string query = "UPDATE UserInfo SET " +
               "Name = '" + updatedName + "', " +
               "Gender = '" + updatedGender + "', " +
               "Phone = '" + updatedPhone + "', " +
               "Email = '" + updatedEmail + "', " +
               "Password = '" + updatedPassword + "', " +
               "Address = '" + updatedAddress + "', " +
               "User_Type = '" + updatedUserType + "', " +
               "Status = '" + updatedStatus + "' " +
               "WHERE Id = " + id;
                string error;
                DataAccess.ExecuteData(query, out error);
                if (string.IsNullOrEmpty(error) == false)
                {
                    MessageBox.Show(error);
                    return;
                }
                this.LoadUserInfo();
                MessageBox.Show("Updated");
            }

            for (int i = 0; i < user_grid.Rows.Count; i++)
            {
                if (user_grid.Rows[i].Cells[0].Value.ToString() == usr_id_txt.Text)
                {
                    user_grid.Rows[i].Selected = true;
                    break;
                }
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Hide();
        }
    }
}
