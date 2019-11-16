using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Interfaces
{
    interface ISpecialty
    {
        int IdSpec { get; set; }
        string NameSpec { get; set; }
        int IdFacult { get; set; }
        IFacult facult { get; set; }
    }
}
