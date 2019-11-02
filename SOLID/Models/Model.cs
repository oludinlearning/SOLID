using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID.Interfaces;

namespace SOLID
{
    class Model : IModel
    {
        public Model(IReadDB db)
        {

        }
    }
}
