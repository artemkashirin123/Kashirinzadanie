using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Kashirin
{
    [SQLite.Table("Employees")]
    public class Employees
    {
        [PrimaryKey, AutoIncrement, SQLite.Column("_id")]
        public int IDEmployee { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string DateOfBirthday { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }
}
