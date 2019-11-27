using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;
using System.Data.Linq;
using SOLID.Interfaces;

namespace SOLID.Entities
{
    [Table(Name ="Subject")]
    public class Subject : ISubject
    {
        [Column(IsPrimaryKey = true, Name = "IdSubject", IsDbGenerated = true)]
        public int IdSubject { get; set; }
        [Column(Name = "NameSub")]
        public string NameSub { get; set; }
    }
}
