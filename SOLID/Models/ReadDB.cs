using SOLID.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Models
{
    class ReadDB:IReadDB
    {
        List<string> dataBase;
        public List<string> ReadDBs(int use, int fac, int spec, int group, int student)
        {

            return dataBase;
        }
    }
}
