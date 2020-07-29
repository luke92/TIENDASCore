using System;
using System.Collections.Generic;
using System.Text;
using TIENDAS.Business.Modules.Shared.Models;

namespace TIENDAS.Business.Modules.EmployeeType.Models
{
    public class EmployeeTypeModel : BaseModel
    {
        public decimal Salary { get; set; }

        public TIENDAS.Data.Entities.EmployeeType ToEntity()
        {
            return new TIENDAS.Data.Entities.EmployeeType
            {
                ID = ID,
                Name = Name,
                Salary = Salary
            };
        }
    }
}
