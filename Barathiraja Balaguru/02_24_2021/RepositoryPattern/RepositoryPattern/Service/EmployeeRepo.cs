using RepositoryPattern.Data;
using RepositoryPattern.Infrastructure;
using RepositoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPattern.Service
{
    public class EmployeeRepo : IEmployee
    {
        private EmployeeContext _context;

        public EmployeeRepo(EmployeeContext context)
        {
            _context = context;
        }
        public void Delete(Employee employee)
        {
            _context.Employeesss.Remove(employee);
        }

        public List<Employee> GetAll()
        {
            return _context.Employeesss.ToList();
        }

        public Employee GetById(int Id)
        {
            return _context.Employeesss.Where(x => x.Id == Id).FirstOrDefault();
        }

        public void Insert(Employee employee)
        {
            _context.Employeesss.Add(employee);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Employee employee)
        {
            _context.Employeesss.Update(employee);
        }
    }
}
