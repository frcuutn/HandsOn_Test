using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOn_Test.BLL.Models
{
    abstract public class EmployeeFactory
    {
        public abstract EmployeeDto GetEmployee();
    }

    class HourlyFactory : EmployeeFactory
    {
        private int _id;
        private string _name;
        private string _roleName;
        private double _salary;

        public HourlyFactory(int id, string name, string roleName, double salary)
        {
            _id = id;
            _name = name;
            _roleName = roleName;
            _salary = salary;
        }

        public override EmployeeDto GetEmployee()
        {
            return new HourlyEmployeeDto
            {
                Id = _id,
                HourlySalary = _salary,
                Name = _name,
                RoleName = _roleName,
                ContractTypeName = "Hourly",
                AnnualSalary = 120 * _salary * 12
            };
        }
    }

    class MonthlyFactory : EmployeeFactory
    {
        private int _id;
        private string _name;
        private string _roleName;
        private double _salary;

        public MonthlyFactory(int id, string name, string roleName, double salary)
        {
            _id = id;
            _name = name;
            _roleName = roleName;
            _salary = salary;
        }

        public override EmployeeDto GetEmployee()
        {
            return new MonthlyEmployeeDto
            {
                Id = _id,
                Name = _name,
                RoleName = _roleName,
                MonthlySalary = _salary,
                ContractTypeName = "Monthly",
                AnnualSalary = _salary * 12
            };
        }
    }
}
