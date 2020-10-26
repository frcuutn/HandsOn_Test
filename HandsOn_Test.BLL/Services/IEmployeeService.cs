using HandsOn_Test.BLL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HandsOn_Test.BLL.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<EmployeeDto>> GetInfoEmployees(int id);
    }
}
