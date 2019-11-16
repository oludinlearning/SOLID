using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Interfaces
{
    interface IFacult
    {
        int IdFacult { get; set; }
        string NameFacult { get; set; }
        int IdUniver { get; set; }
        IUniversity university { get; set; }
    }
}
