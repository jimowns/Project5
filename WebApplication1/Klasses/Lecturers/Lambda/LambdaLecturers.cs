using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Windows.Forms;
using WebApplication1.Klasses.Algemeen;
using WebApplication1.Klasses.Connection;

namespace WebApplication1.Klasses.Login.linq
{
    public class LambdaLecturers
    {
        #region Fields
        public string EMail { set; get; }
        public string Password { set; get; }
        private string Firstname { set; get; }
        private string Lastname { set; get; }
        #endregion

        #region Constructors
        public LambdaLecturers(string email, string password)
        {
            this.EMail = email;
            this.Password = password;
        }
        public LambdaLecturers(string email, string password, string firstname, string lastname)
            :this(email, password)
        {
            this.Firstname = firstname;
            this.Lastname = lastname;
        }
        #endregion

        public Boolean GetCheckLectorInfo()
        {
            var list = new Entity();
            var result = list.DB_Lecturers
                .Any(x =>
                        x.Password.Equals(this.Password)
                        && x.EMail.Equals(this.EMail)
                    );
            return result;
        }
        public Lecturers GetCheckLecturersInfo_DatabaseFields()
        {
            var list = new Entity();
            Lecturers lector = list.DB_Lecturers
                .Where(x =>
                        x.Password.Equals(this.Password)
                        && x.EMail.Equals(this.EMail)
                    ).First();
            return lector;
        }
        public Boolean GetCheckUniekEmail()
        {
            var list = new Entity();
            var result = list.DB_Lecturers
                .Any(x =>
                        !x.EMail.Equals(this.EMail)
                    );
            return result;
        }

        public Lecturer SetLecturersInsertData()
        {
            var list = new Entity();
            Lecturer lecturers = new Lecturer()
            {
                Firstname = this.Firstname,
                Lastname = this.Lastname,
                Email = this.EMail,
                Access = 1,
                Password = Hash.Password_Encryption_md5(this.Password)
            };
            list.dataClassContext.Lecturers.InsertOnSubmit(lecturers);
            list.dataClassContext.SubmitChanges();

            return lecturers;
        }
    }
}































































/* public string EMail { set; get; }
 public string Password { set; get; }
 public LinqLecturers(string email, string password)
 {
     this.EMail = email;
     this.Password = password;
 }

 public Boolean GetCheckLectorInfo()
 {
     var list = new Entity();
     var result = list.DB_Lecturers.Any(x =>
                                         x.Password.Equals(this.Password)
                                         && x.EMail.Equals(this.EMail)
                                     );
     return result;
 }*/