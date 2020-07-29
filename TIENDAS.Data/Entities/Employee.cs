using System;
using System.Collections.Generic;
using System.Text;

namespace TIENDAS.Data.Entities
{
    public class Employee : EntityBase
    {
        public virtual EmployeeType Type { get; set; }
        public int TypeID { get; set; }
        public DateTime EmploymentDate { get; set; }
        public string Address { get; set; }

        public Employee()
        {

        }

        
    }
}
