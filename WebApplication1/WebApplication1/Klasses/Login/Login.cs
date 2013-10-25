using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication1.Klasses.Login
{
    public class Login
    {
        public string Username { set; get; }
        public string Password { set; get; }
        private const string TABLE_NAME_ACCESS = "access";
        private const string TABLE_NAME = "Login";
        public Connection.Connection MSSQConnection { set; get; }

        public Login(string username, string password)
        {
            this.Username = username;
            this.Password = password;
            this.MSSQConnection = new Connection.Connection();
        }

        public string ControleInvoer()
        {
            if (this.Username.Equals("") && this.Password.Equals(""))
                return "please enter username and password.";
            else if (this.Username.Equals(""))
                return "please enter username";
            else if (this.Password.Equals(""))
                return "please enter password";

            SqlCommand sqlCommand = null;
            SqlDataReader sqlDataReader = null;
            try
            {
                sqlCommand = new SqlCommand("select * from [dbo].[Login] where username='" + this.Username + "' and password_md5='" + Algemeen.Hash.Password_Encryption_md5(this.Password) + "';", this.MSSQConnection.MSSQLConnection);
                sqlDataReader = sqlCommand.ExecuteReader();
                if (sqlDataReader.HasRows)
                {
                    if (sqlDataReader.Read())
                        if (sqlDataReader.GetInt32(4) == 0) // table: access 
                            return sqlDataReader.GetString(1);
                        else
                            return "you're banned. please contact admin";
                }
            }
            catch (Exception e)
            {
            }
            finally
            {

                this.MSSQConnection.MSSQLConnection.Close();
            }
            return "wrong username or password";
        }
    }
}