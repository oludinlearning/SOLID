using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID.Entities;

namespace SOLID.Interfaces
{
    public interface IGPA
    {
        int IdRecord { get; set; }
        int Gpa { get; set; }
        int IdStudent { get; set; }
        Student Student { get; set; }
        int IdSubject { get; set; }
        Subject Subject { get; set; }
    }
}
