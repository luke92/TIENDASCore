using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TIENDAS.Business.Modules.Employee.Models;

namespace TIENDAS.Business.Modules.Employee
{
    public interface IEmployeeModule
    {
        Task<EmployeeModel> Get(int id);
        Task<IList<EmployeeModel>> GetAll();
        Task<bool> CreateAsync(EmployeeModel model);
        Task<bool> Update(EmployeeModel model);
        Task<bool> Delete(int id);
    }
}
