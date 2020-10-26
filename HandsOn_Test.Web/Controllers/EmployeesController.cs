using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOn_Test.BLL.Models;
using HandsOn_Test.BLL.Services;
using Microsoft.AspNetCore.Mvc;

namespace HandsOn_Test.Web.Controllers
{
    [Route("api/[controller]")]
    public class EmployeesController : Controller
    {
        private readonly IEmployeeService _service;

        public EmployeesController(IEmployeeService service)
        {
            _service = service;
        }

        [HttpGet("[action]/{id}")]
        public async Task<IEnumerable<EmployeeDto>> EmployeesAsync([FromRoute] int id)
        {
            return await _service.GetInfoEmployees(id);
        }
    }
}