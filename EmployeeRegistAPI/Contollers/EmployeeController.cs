using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using EmployeeRegistAPI.Data;
using EmployeeRegistAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EmployeeRegistAPI.Contollers
{
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        private readonly EmployeeDbContext _context;

        public EmployeeController(EmployeeDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        // public IActionResult Error()
        // {
        //     return View("Error!");
        // }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employee>>> GetEmployee()
        {
           return await _context.Employees.ToListAsync();
        }

       [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<Employee>>> GetEmployees(int id)
        {
            var employee = await _context.Employees.FindAsync(id);

            if (employee == null)
            {
                return NotFound();
            }

            return new List<Employee> { employee }; 
           
        }


        [HttpPost]
        public async Task<ActionResult<IEnumerable<Employee>>> PostEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();
            return StatusCode(201);
        }
    }
}