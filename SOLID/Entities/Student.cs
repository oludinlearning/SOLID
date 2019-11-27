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
    [Table(Name ="Student")]
    public class Student : IStudent
    {
        [Column(IsPrimaryKey =true, Name ="IdStudent", IsDbGenerated =true)]
        public int IdStudent { get; set; }
        [Column(Name ="NameStudent")]
        public string NameStudent { get; set; }
        [Column(Name ="YearBirth")]
        public DateTime YearBeth { get; set; }
        [Column]
        public int IdFacult { get; set; }
        private EntityRef<Facult> _Facult;
        [Association(Storage = "_Facult", ThisKey = "IdFacult")]
        public Facult Facult
        {
            get { return this._Facult.Entity; }
            set { this._Facult.Entity = value; }
        }

    }
}
