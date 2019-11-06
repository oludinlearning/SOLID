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
    class Student : IStudent
    {
        [Column(IsPrimaryKey =true, Name ="IdStudent", IsDbGenerated =true)]
        public int IdStudent { get; set; }
        [Column(Name ="NameStudent")]
        public string NameStudent { get; set; }
        [Column(Name ="YearBirth")]
        public DateTime YearBeth { get; set; }
        [Column(Name ="RatingUSE")]
        public int RatingUse { get; set; }
        [Column]
        public int IdGroup { get; set; }
        private EntityRef<IGroup> _Group;
        [Association(Storage ="_Group",ThisKey ="IdGroup")]
        public IGroup group
        {
            get { return this._Group.Entity; }
            set { this._Group.Entity = value; }
        }

    }
}
