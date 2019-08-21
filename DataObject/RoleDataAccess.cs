 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataObject
{
    public class RoleDataAccess:ConnectionClass
    {
        public void InsertCommand(string roleName, bool isEnabled = true) {

            _sqlCommand = new SqlCommand("sp_RoleInsert",_sqlConnection);
            //_sqlCommand.Parameters.AddWithValue("@roleName", roleName);
           // _sqlCommand.Parameters.AddWithValue("@isEnabled", isEnabled);
            Dictionary<string, object> fields = new Dictionary<string, object>();
            fields["@roleName"] = roleName;
            fields["@isEnabled"] = isEnabled;
   
            execSQLNonQuery(CommandType.StoredProcedure,fields);
            

        }

        public void UpdateCommand(int roleId,string roleName, bool isEnabled = true )
        {

            _sqlCommand = new SqlCommand("sp_RoleUpdate", _sqlConnection);
            //_sqlCommand.Parameters.AddWithValue("@roleName", roleName);
            // _sqlCommand.Parameters.AddWithValue("@isEnabled", isEnabled);
            Dictionary<string, object> fields = new Dictionary<string, object>();
            fields["@roleName"] = roleName;
            fields["@isEnabled"] = isEnabled;
            fields["@roleId"] = roleId;

            execSQLNonQuery(CommandType.StoredProcedure, fields);


        }

        public void SetDisabledCommand( bool isEnabled = true)
        {

            _sqlCommand = new SqlCommand("sp_RoleUpdate", _sqlConnection);
            //_sqlCommand.Parameters.AddWithValue("@roleName", roleName);
            // _sqlCommand.Parameters.AddWithValue("@isEnabled", isEnabled);
            Dictionary<string, object> fields = new Dictionary<string, object>();
           
            fields["@isEnabled"] = isEnabled;

            execSQLNonQuery(CommandType.StoredProcedure, fields);


        }
    }
}
