using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DATABASE
{
    public class database
    {
        string connectionString = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=QLCHNUOCHOA;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";

        public string GetDatabase()
        {
            return connectionString;
        }
    }
}
