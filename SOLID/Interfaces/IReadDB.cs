using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Interfaces
{
    public interface IReadDB
    {
        public List<string> ReadDBs(int use, int fac, int spec, int group, int student);
    }
}
