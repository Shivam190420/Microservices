using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace WebApplication1.Models
{
    public class Employees1 : IEmployee
    {
        EmployeeDbContext _context;

        public Employees1(EmployeeDbContext context)
        {
            _context = context;
        }
        public Employee createEmployee(Employee obj)
        {
            _context.employees.Add(obj);
            _context.SaveChanges();
            return obj;
        }

        public Employee deleteEmployee(int id)
        {
            var obj = _context.employees.Find(id);
            _context.employees.Remove(obj);
            _context.SaveChanges();
            return obj;
        }

        public List<Employee> getAllEmployees()
        {
            return _context.employees.ToList();
        }

        public Employee getEmployeeById(int id)
        {

            return _context.employees.Find(id);

        }

        public Employee updateEmployee(Employee obj)
        {
            _context.employees.Update(obj);
            _context.SaveChanges();
            return obj;
        }
    }
}