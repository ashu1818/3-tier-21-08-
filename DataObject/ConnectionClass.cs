using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObject
{
    public class ConnectionClass
    {
        protected SqlConnection _sqlConnection;
        protected SqlCommand _sqlCommand;
        protected SqlDataAdapter _sqlDataAdapter;
        protected DataTable _dt;


      public  ConnectionClass (){
            _sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["connStr"].ConnectionString);
        }

        protected void execSQLNonQuery(CommandType type, Dictionary<string, object> fields)

        {
            _sqlCommand.CommandType = type;

            foreach (string key in fields.Keys)
            {
                _sqlCommand.Parameters.AddWithValue(key, fields[key]); 
            }
            _sqlConnection.Open();
            _sqlCommand.ExecuteNonQuery();
            _sqlConnection.Close();

        }

    }
}
