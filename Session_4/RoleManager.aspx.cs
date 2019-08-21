using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BuisnessObject;
using PropertyObject;

namespace Session_4
{
    public partial class RoleManager : System.Web.UI.Page
    {
        RoleBuisnessAccess rolBuisnessobj = new RoleBuisnessAccess();
        RoleFields rolefield = new RoleFields();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            rolefield = new RoleFields();
            rolefield._RoleName = txtRoleDetails.Text;
            rolefield._IsRoleEnabled = chkEnabled.Checked;
            if (rolBuisnessobj.SaveRoleDetails(rolefield))
            {
                lblmsg.InnerHtml = "Role is saved";
            }
            else
            {
                lblmsg.InnerHtml = "Role is not saved";
            }
        }
    }
}