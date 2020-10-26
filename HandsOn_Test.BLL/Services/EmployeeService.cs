using HandsOn_Test.BLL.Models;
using HandsOn_Test.DAL.Repositories;
using HandsOn_Test.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace HandsOn_Test.BLL.Services
{
    public class EmployeeService : IEmployeeService 
    {
        private readonly IRepository _employeeRepo;

        public EmployeeService(IRepository employeeRepo)
        {
            _employeeRepo = employeeRepo;
        }

        public async Task<IEnumerable<EmployeeDto>> GetInfoEmployees(int id)
        {
            var employees = await _employeeRepo.GetAllAsync();

            var result = new List<EmployeeDto>();

            EmployeeFactory factory = null;
            foreach (var employee in employees)
            {
                switch (employee.ContractTypeName.ToLower())
                {
                    case "hourlysalaryemployee":
                        factory = new HourlyFactory(employee.Id, employee.Name, employee.RoleName, employee.HourlySalary);
                        break;
                    case "monthlysalaryemployee":
                        factory = new MonthlyFactory(employee.Id, employee.Name, employee.RoleName, employee.MonthlySalary);
                        break;
                    default:
                        break;
                }

                result.Add(factory.GetEmployee());
            }

            if(id != 0)
            {
                result = result.FindAll(x => x.Id == id);
            }

            return result;
        }
    }
}
