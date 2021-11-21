using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class dbConnectionData
    {
        public static SqlConnection HamKetNoi()
        {
            SqlConnection Conn = new SqlConnection(@"Data Source=LAPTOP-QLLB0L9G\SQLEXPRESS;Initial Catalog=QlSinhVien;Integrated Security=True");
            return Conn;
        }
    }
}
