using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class AdminSlotsUpdate : System.Web.UI.Page
    {
        DatabaseDataClassesDataContext db = new DatabaseDataClassesDataContext();

        protected void Page_Load(object sender, EventArgs e)
        {
            var query = from m in db.tblSlots
                        where m.Id == Convert.ToInt32(Request.QueryString["id"])
                        select m;
            foreach (var q in query)
            {
                txtboxCapacity.Text = (q.Capacity).ToString();
                txtboxDate.Text = q.Date;
                txtboxDuration.Text = q.Duration;
                txtboxEnd.Text = q.End;
                txtboxReserved.Text = (q.Reserved).ToString();
                txtboxStart.Text = q.Start;
                DropDownList1.SelectedValue = q.Campus;
                RadioButtonList1.SelectedValue = (q.Digital).ToString();


            }
        }

        protected void btnAddSlot_Click(object sender, EventArgs e)
        {
            var query = from m in db.tblSlots
                        where m.Id == Convert.ToInt32(Request.QueryString["id"])
                        select m;
            foreach (var q in query)
            {
                q.Campus = DropDownList1.SelectedItem.Text;
                q.Capacity = int.Parse(txtboxCapacity.Text);
                q.Date = txtboxDate.Text;
                q.Digital = Convert.ToByte(RadioButtonList1.SelectedValue);
                q.Duration = txtboxDuration.Text;
                q.Start = txtboxStart.Text;
                q.End = txtboxEnd.Text;
                int reserved = int.Parse(txtboxReserved.Text);
                q.Reserved = reserved;
                db.SubmitChanges();
                Response.Redirect("AdminSlots.aspx");
            }
        }
    }
}