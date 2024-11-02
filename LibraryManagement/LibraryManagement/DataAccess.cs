using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    internal class DataAccess
    {

        public static string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\sarka\\source\\Database File\\LibraryManagement.mdf\";Integrated Security=True;Connect Timeout=30";
        public static void ExecuteData(string query, out string error)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConnectionString);

                con.Open();

                SqlCommand sqlCommand = new SqlCommand(query, con);
                // MessageBox.Show(Query);
                sqlCommand.ExecuteNonQuery();



                con.Close();
                error = "";


            }

            catch (Exception expection)
            {

                error = expection.Message;


            }
        }


        public static DataTable GetData(string Query, out string error)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConnectionString);

                con.Open();

                SqlCommand sqlCommand = new SqlCommand(Query, con);
                // MessageBox.Show(Query);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);

                DataTable dt = dataSet.Tables[0];



                con.Close();
                error = "";

                return dt;
            }

            catch (Exception expection)
            {

                error = expection.Message;
                return null;

            }

        }
    }
}
