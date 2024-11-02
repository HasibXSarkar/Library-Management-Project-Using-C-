using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class SignUp : MetroFramework.Forms.MetroForm
    {

        public SignUp()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void sufstnme_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Log_In log_In = new Log_In();
            log_In.Show();
            this.Hide();
        }

        private void sufntxt_Click(object sender, EventArgs e)
        {

        }

        private void subttn_Click(object sender, EventArgs e)
        {
            string query;
            string error;
            string U_nme = sufntxt.Text;
            string email = suemailtx.Text;
            string aiub_id = aiub_id_txt.Text;
            query = "select email,aiub_id from UserInfo where email = '" + email + "' or Aiub_Id = '" + aiub_id + "'";

            var dt = DataAccess.GetData(query, out error);
            if (String.IsNullOrEmpty(error) == false)
            {
                MessageBox.Show("Opps Something Went Wrong!");
                return;
            }
            try
            {
                if (String.IsNullOrEmpty(dt.Rows[0]["email"].ToString()) == false || String.IsNullOrEmpty(dt.Rows[0]["aiub_id"].ToString()) == false)
                {
                    MessageBox.Show("Account already exist");
                    return;
                }
            }
            catch (Exception ex)
            {
            }
                string usr_tpe = usr_type_com.SelectedItem?.ToString();
                string pass = supasstxt.Text;
                string c_pass = sucpasstxt.Text;
                string add = sutxtb1.Text;
                string phn = suphn.Text;
                string gender = "";
                string Status = "";
            
                if (male.Checked == true) { gender = "Male"; }
                else if (female.Checked == true) { gender = "Female"; }
                if (usr_valid.Checked == true) { Status = "Valid"; }
               else if (usr_invalid.Checked == true) { Status = "Invalid"; }
            else
                {
                    MessageBox.Show("Invalid Gender");
                }


                if (pass == c_pass)
                {
                    query = "insert into UserInfo(Name,Aiub_Id,User_Type,Status,Gender,Email,Password,Phone,Address) values('" + U_nme + "','" + aiub_id + "','" + usr_tpe + "','" + Status + "','" + gender + "','" + email + "','" + pass + "','" + phn + "','" + add + "')";
                    DataAccess.ExecuteData(query, out error);

                    if (string.IsNullOrEmpty(error) == false)

                    {
                        MessageBox.Show(error);
                        return;
                    }

                    else
                    {
                        MessageBox.Show("Success!!");
                        subttn.Visible = false;
                    }


                }
                else
                {
                    MessageBox.Show("Plz Recheck Password");
                }

            


        }

        private void male_CheckedChanged(object sender, EventArgs e)
        {

        }
        GenerateNumber gs = new GenerateNumber();
        private void suVbtn_Click(object sender, EventArgs e)
        {
            string eml = suemailtx.Text;
            string fromMail = "unilibrarymailservice@gmail.com";
            string fromPassword = "xlvewfpyaghskkvv";

            MailMessage message = new MailMessage();
            message.From = new MailAddress(fromMail);
            message.Subject = "verification Mail";
            message.To.Add(new MailAddress(eml));
            message.Body = "<html><body> Your Verification Code is :  " + gs.getValue() + " Dont share this code </body></html>";
            message.IsBodyHtml = true;

            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(fromMail, fromPassword),
                EnableSsl = true,
            };
            try
            {
                smtpClient.Send(message);
                suvlbl.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            smtpClient.Dispose();
        }

        private void suvybtn_Click(object sender, EventArgs e)
        {
            if (int.Parse(suvtxtbx.Text) == gs.getValue())
            {
                MessageBox.Show("Verification successful");
                subttn.Visible = true;
            }
            else
            {
                MessageBox.Show("Invalid code");
            }
        }
    }
}