using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID.Entities;

namespace SOLID.Interfaces
{
    public interface IStudent
    {
        int IdStudent { get; set; }
        string NameStudent { get; set; }
        DateTime YearBeth { get; set; }
        int IdFacult { get; set; }
        Facult Facult { get; set; }
    }
}
