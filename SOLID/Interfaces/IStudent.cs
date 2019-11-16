using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Interfaces
{
    interface IStudent
    {
        int IdStudent { get; set; }
        string NameStudent { get; set; }
        DateTime YearBeth { get; set; }
        int RatingUse { get; set; }
        int IdGroup { get; set; }
        IGroup group { get; set; }
    }
}
