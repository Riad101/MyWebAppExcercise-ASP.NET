using Login_Form.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Login_Form.Services.Data
{
    public class SecurityDAO
    {
        //connect to the database
        string connectionString = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Test;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        internal bool findByUser(userModel user)
        {
            //return (user.UserName =="Admin" && user.Password =="Security");
            
            //assuming that nothing is found in the user
            bool success = false;

            //write the sql expression
            string queryString = "SELECT * FROM dbo.users WHERE userName=@UserName AND password=@Password";


            //create and open a database connection inside a using block
            //this ensure that all resources are closed properly when the query is done

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //create the command and parameter objects
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@UserName", System.Data.SqlDbType.VarChar, 50).Value = user.UserName;

            }

        }
    }
}