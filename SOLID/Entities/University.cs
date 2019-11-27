using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID.Interfaces;
using System.Data.Linq.Mapping;

namespace SOLID.Entities
{
    [Table(Name ="University")]
    public class University : IUniversity
    {
        [Column(IsPrimaryKey =true,IsDbGenerated =true,Name ="IdUniver")]
        public int IdUniver { get; set; }
        [Column(Name ="NameUniver")]
        public string NameUniver { get; set; }
    }
}
