using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TIENDAS.Business.Modules.Employee.Models;
using TIENDAS.Data;

namespace TIENDAS.Business.Modules.Employee
{
    public class EmployeeModule : IEmployeeModule
    {
        private readonly TiendasContext _context;

        public EmployeeModule(TiendasContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateAsync(EmployeeModel model)
        {
            try
            {
                
                await _context.Employees.AddAsync(model.ToEntity());
                var result = await _context.SaveChangesAsync();
                _context.DisposeAsync();
                return result > 0;
            }
            catch
            {
                return false;
            }
        }

        public Task<bool> Delete(int id)
        {
            try
            {

            }
            catch
            {

            }
        }

        public Task<EmployeeModel> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IList<EmployeeModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(EmployeeModel model)
        {
            throw new NotImplementedException();
        }
    }
}
