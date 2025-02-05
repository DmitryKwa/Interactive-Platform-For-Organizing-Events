using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace InteractivePlatformForOrganizingEvents
{
    public class DB
    {
        public static SqlConnection SQLConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Дмитрий\source\repos\InteractivePlatformForOrganizingEvents\InteractivePlatformForOrganizingEvents\DataBase\InteractivePlatformForOrganizingEvents.mdf;Integrated Security=True");
        public SqlConnection sqlConnectGetConnection()
        {
            return SQLConnection;
        }
    }
}
