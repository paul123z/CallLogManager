using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CallLogManager
{
    internal class Connection
    {
        public SqlConnection con; // COMMUNICATE between c# app and database
        public SqlCommand cmdl; //initialize new instance of command class
        public SqlDataAdapter sda; // communication between dataset and the databaset
        public string pkk; // we can show some messages

        public void connection() {

            con = new SqlConnection(@"Data Source=.;Initial Catalog=CallManagement;Integrated Security=True");
            con.Open();
        }


        public void dataSend(string SQL)
        {
            try
            {
                connection(); //calling our connection method
                cmdl = new SqlCommand(SQL, con); //initialize new instace of sql command, we are giving sql query
                cmdl.ExecuteNonQuery(); //very frequent command, used executing statements that do not return result
                pkk = ""; //we pass empty string
            }
            catch (Exception)
            {
                pkk = "Please check your data";
            }
            con.Close(); //we close the connection
        }

        public void dataGet(string SQL) //we pass SQL query
        {
            try
            {
                connection();
                sda = new SqlDataAdapter(SQL, con); //fetch data records from database
            }
            catch (Exception)
            {
            
            
            }
        }
    }
}
