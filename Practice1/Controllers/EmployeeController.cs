﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Practice1.Models;

namespace Practice1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public EmployeeController(Practice1Context dbContext)
        {
            DbContext = dbContext;
        }

        public Practice1Context DbContext { get; }

        [HttpGet]
        public List<Employee> GetEmployees()
        {
            return DbContext.Employees.ToList();
        }

        [HttpPost]
        public Employee CreateEmployees(Employee employee)
        {
            var createdEmployee = DbContext.Employees.Add(employee);
            DbContext.SaveChanges();
            return createdEmployee.Entity;
        }

        [HttpPatch("{EmployeeId}")]
        public ActionResult<Employee> UpdateEmployees(int employeeId,Employee employee) 
        {
            var existingEmployee = DbContext.Employees.Find(employeeId);

       

            existingEmployee.FirstName = employee.FirstName;

            DbContext.SaveChanges();

            return new Employee
            {
                FirstName = employee.FirstName,
            };
        }

    
        [HttpDelete("{EmployeeId}")]
        public Employee DeleteEmployee(Employee employee)
        {
           var existingEmployee =  DbContext.Employees.Find(employee);
         

            DbContext.Employees.Remove(employee);
            DbContext.SaveChanges();
            return employee;
        }
    }
}


       
