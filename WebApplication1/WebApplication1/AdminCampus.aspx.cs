using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace WebApplication1
{
    public partial class AdminCampus : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            dataSourceCampussen.DataBind();
        }

        protected void btnCampus_Click(object sender, EventArgs e)
        {
            DatabaseDataClassesDataContext db = new DatabaseDataClassesDataContext();
            tblCampus campus = new tblCampus();
            string plaats = txtboxCampusPlaats.Text;
            if (!String.IsNullOrEmpty(plaats))
            {
                campus.Plaats = plaats;
                db.tblCampus.InsertOnSubmit(campus);
                db.SubmitChanges();
            }
            else
            {
                MessageBox.Show("Plaats is leeg!");
            }
            

            Response.Redirect("AdminCampus.aspx");
            
        }
    }
}