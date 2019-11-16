using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Interfaces
{
    interface IGroup
    {
        int IdGroup { get; set; }
        string NameGroup { get; set; }
        int IdSpec { get; set; }
        ISpecialty specialty { get; set; }
    }
}
