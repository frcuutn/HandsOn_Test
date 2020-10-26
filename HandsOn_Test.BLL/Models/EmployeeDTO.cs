using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOn_Test.BLL.Models
{
    public class EmployeeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string RoleName { get; set; }
        public string ContractTypeName { get; set; }
        public double AnnualSalary { get; set; }
    }

    public class HourlyEmployeeDto : EmployeeDto {
        public double HourlySalary { get; set; }
    }

    public class MonthlyEmployeeDto : EmployeeDto {
        public double MonthlySalary { get; set; }
    }
}
