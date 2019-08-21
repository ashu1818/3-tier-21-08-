using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyObject
{
    public class RoleFields
    {
        private int RoleId;
        private string RoleName;
        private bool IsRoleEnabled;

        public bool  _IsRoleEnabled
        {
            get { return IsRoleEnabled; }
            set { IsRoleEnabled = value; }
        }


        public string _RoleName
        {
            get { return RoleName; }
            set { RoleName = value; }
        }


        public int _RoleId
        {
            get { return RoleId; }
            set { RoleId = value; }
        }

    }
}
