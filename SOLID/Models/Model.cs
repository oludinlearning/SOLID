using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using SOLID.Interfaces;
using System.Data.Linq.Mapping;
using System.Data.Linq;
using SOLID.Models;

namespace SOLID
{
    class Model : IModel
    {
        string connectionString;
        private ReadDB readDB;

        public Model()
        {
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        public Model(ReadDB readDB)
        {
            this.readDB = readDB;
        }

        public Model(IReadDB db, out Table<IStudent> tabStud)
        {
            db.ReadStudent(connectionString,out Table<IStudent> tabS);
            tabStud = tabS;

        }
    }
}
