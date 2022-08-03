using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public interface IEmployee
    {
        public List<Employee> getAllEmployees();

        public Employee getEmployeeById(int id);

        public Employee createEmployee(Employee obj);
        public Employee updateEmployee(Employee obj);

        public Employee deleteEmployee(int id);
    }
}