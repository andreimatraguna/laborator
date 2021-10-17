using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using _2.repo;
using _2.Models;
namespace _2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentRepController : ControllerBase
    {
        public StudentRepController()
        { 
        }

        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return StudentRep.Students;
        }
    
        [HttpGet("{id}")]
        public Student GetStudents(int id)
        {
            return StudentRep.Students.FirstOrDefault(s => s.Id == id);
        }
        
        [HttpPost]
        public void Post([FromBody] Student student)
        {
            StudentRep.Students.Add(student);
        }

        [HttpPut]
        public void HttpPut([FromBody] Student student)
        {
            StudentRep.Students.Where(s=> s.Id != student.Id).Append(student);
        }

        [HttpDelete("{id}")]
        public void HttpDelete(int id)
        {
            StudentRep.Students.ElementAtOrDefault(id);
        }
    }
}
