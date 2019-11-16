using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using SOLID.Interfaces;

namespace SOLID.Entities
{
    [Table(Name ="Group")]
    class Group : IGroup
    {
        [Column(IsPrimaryKey =true,Name ="IdGroup",IsDbGenerated =true)]
        public int IdGroup { get; set; }
        [Column(Name ="NameGroup")]
        public string NameGroup { get; set; }
        [Column]
        public int IdSpec { get; set; }
        private EntityRef<ISpecialty> _Specialty;
        [Association(Storage ="_Specialty",ThisKey ="IdSpec")]
        public ISpecialty specialty
        {
            get { return this._Specialty.Entity; }
            set { this._Specialty.Entity = value; }
        }
    }
}
