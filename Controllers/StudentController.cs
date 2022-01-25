using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing.Constraints;
using SmartSchool.WebAPI.Models;

namespace SmartSchool.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        public List<Student> Students = new List<Student>()
        {
            new Student() {
                Id = 1,
                FirstName = "Marcus",
                LastName = "Hitchcook",
                Phone = "123456"
            },
            new Student() {
                Id = 2,
                FirstName = "Martha",
                LastName = "Hitchcook",
                Phone = "123456"
            },
                  new Student() {
                Id = 3,
                FirstName = "Lucas",
                LastName = "Hitchcook",
                Phone = "123456"
            }
        };
        public StudentController(){}

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Students);
        }
        [HttpGet]
        [Route("byId/{id}")]
        public IActionResult GetById(int id)
        {
            var student = Students.FirstOrDefault(a => a.Id == id);
            if(student == null) return BadRequest("Student not found"); 
            
            return Ok(student);
        }

        [HttpGet]
        [Route("byName")]
        public IActionResult GetByName(string firstName, string lastName)
        {
            var student = Students.FirstOrDefault(a => 
                a.FirstName.Contains(firstName) &&  a.LastName.Contains(lastName)
            );
            if(student == null) return BadRequest("Student not found"); 
            
            return Ok(student);
        }

        [HttpPost]
        public IActionResult AddStudent(Student student)
        {
            return Ok(student);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateStudent(int id, Student student)
        {
            return Ok(student);
        }

        [HttpPatch("{id}")]
        public async Task<IActionResult> PatchStudent(int id, Student student)
        {
            return Ok(student);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudent(int id)
        {
            return Ok();
        }
        
            
    
    }
}