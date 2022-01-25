using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SmartSchool.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TeacherController : ControllerBase
    {
        public TeacherController(){}
        
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok("Teachers: Arnold, Garfield and Spider Man");
        }
    }
}