using System;
using System.Collections.Generic;
using System.Text;
using TIENDAS.Business.Modules.EmployeeType.Models;
using TIENDAS.Business.Modules.Shared.Models;
using TIENDAS.Data.Entities;

namespace TIENDAS.Business.Modules.Employee.Models
{
    public class EmployeeModel : BaseModel
    {
        public DateTime EmploymentDate { get; set; }
        public string Address { get; set; }
        public virtual EmployeeTypeModel Type { get; set; }
        public int TypeID { get; set; }

        public EmployeeModel()
        {
        }

        public TIENDAS.Data.Entities.Employee ToEntity()
        {
            return new Data.Entities.Employee
            {
                ID = ID,
                Name = Name,
                Address = Address,
                EmploymentDate = EmploymentDate,
                Type = Type.ToEntity(),
                TypeID = TypeID
            };
        }
    }
}
