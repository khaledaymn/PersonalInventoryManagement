using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalInventoryManagement.BL.Helper
{
    public class DapperHelper
    {
        private static readonly SqlConnection _connection;

        static DapperHelper()
        {
            _connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PersonalInventoryManagement;Integrated Security=True;Trust Server Certificate=True");
        }

        public static SqlConnection ConnectionString()
        {
            return _connection;
        }
    }
}
