using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class AdminSlots : System.Web.UI.Page
    {
        DatabaseDataClassesDataContext db = new DatabaseDataClassesDataContext();

        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataBind();
        }

        protected void btnAddSlot_Click(object sender, EventArgs e)
        {
            var qry = from m in db.tblCampus
                      where m.Plaats == DropDownList1.SelectedValue
                      select m.Id;
            tblSlot slot = new tblSlot();

            slot.Campus = DropDownList1.SelectedItem.Text;
            slot.Capacity = int.Parse(txtboxCapacity.Text);
            slot.Date = txtboxDate.Text;
            slot.Digital = Convert.ToByte(RadioButtonList1.SelectedValue);
            slot.Duration = txtboxDuration.Text;
            slot.Start = txtboxStart.Text;
            slot.End = txtboxEnd.Text;
            slot.Reserved = int.Parse(txtboxReserved.Text);

            db.tblSlots.InsertOnSubmit(slot);
            db.SubmitChanges();
            GridView1.DataBind();
        }
    }
}