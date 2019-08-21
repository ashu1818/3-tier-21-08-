using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataObject;
using PropertyObject;

namespace BuisnessObject
{
    public class RoleBuisnessAccess
    {
        RoleDataAccess roleObj = new RoleDataAccess();
        public bool SaveRoleDetails(RoleFields fields)
        {
            try
            {
                roleObj.InsertCommand(fields._RoleName);
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }

        public bool ModifiedRoleDetails(RoleFields fields)
        {
            try
            {
                roleObj.UpdateCommand(fields._RoleId,fields._RoleName);
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }

        public bool IsRoleEnabled(RoleFields fields)
        {
            try
            {
                roleObj.UpdateCommand(fields._RoleId, fields._RoleName, fields._IsRoleEnabled);
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }
        public DataTable GetRoleDetail(int? id=0)
        {
            return null;
        }
    }
}
