using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class LoginView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private WebApplication1.Klasses.Login.Login login;
        protected void buttonLogin_Click(object sender, EventArgs e)
        {
            this.login = new Klasses.Login.Login(this.textboxUsername.Text, this.textboxPassword.Text);
            this.Label1.Text = login.ControleInvoer();
        }
    }
}