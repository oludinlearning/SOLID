using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID.Entities;

namespace SOLID.Interfaces
{
    public interface IFacult
    {
        int IdFacult { get; set; }
        string NameFacult { get; set; }
        int IdUniver { get; set; }
        University University { get; set; }
    }
}
