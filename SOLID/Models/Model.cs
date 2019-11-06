using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using SOLID.Interfaces;

namespace SOLID
{
    class Model : IModel
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        public Model(IReadDB db)
        {
            db.ReadStudent(connectionString);
        }
    }
}
