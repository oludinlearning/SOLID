using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID.Interfaces;
using System.Data.Linq.Mapping;
using System.Data.Linq;

namespace SOLID.Entities
{
    [Table(Name ="Facult")]
    public class Facult : IFacult
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true, Name ="IdFacult")]
        public int IdFacult { get; set; }
        [Column(Name = "NameFacult")]
        public string NameFacult { get; set; }
        [Column]
        public int IdUniver { get; set; }
        private EntityRef<University> _University;
        [Association(Storage = "_University", ThisKey = "IdUniver")]
        public University University
        {
            get { return this._University.Entity; }
            set { this._University.Entity = value; }
        }
    }
}
