using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Klasses;
using WebApplication1.Klasses.Login.linq;

namespace WebApplication1
{
    public partial class LoginView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!HttpContext.Current.Session.Equals(string.Empty))
            //    HttpContext.Current.Response.Redirect("SlotsView.aspx");
        }

        private LambdaLecturers lectors;
        private const string NEXT_PAGE = "SlotsView.aspx";
        protected void buttonLogin_Click(object sender, EventArgs e)
        {
              this.lectors = new LambdaLecturers(this.textboxUsername.Text, this.textboxPassword.Text);
              if (this.lectors.GetCheckLectorInfo())
              {
                  HttpContext.Current.Session.Add(SessionEnum.SessionNames.LecturorsID.ToString(), this.lectors.GetCheckLecturersInfo_DatabaseFields().ID);
                  HttpContext.Current.Response.Redirect(NEXT_PAGE);
              }
        }
    }
}