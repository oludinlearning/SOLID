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
    [Table(Name ="Spec")]
    class Specialty : ISpecialty
    {
        [Column(IsPrimaryKey =true,IsDbGenerated =true,Name ="IdSpec")]
        public int IdSpec { get; set; }
        [Column(Name ="NameSpec")]
        public string NameSpec { get; set; }
        [Column]
        public int IdFacult { get; set; }
        private EntityRef<IFacult> _Facult;
        [Association(Storage ="_Facult",ThisKey ="IdFacult")]
        public IFacult facult
        {
            get { return this._Facult.Entity; }
            set { this._Facult.Entity = value; }
        }
    }
}
