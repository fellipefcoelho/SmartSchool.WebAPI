using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSchool.WebAPI.Models
{
    public class Class
    {
        public Class() {}

        public Class(int id, string name, int teacherId) 
        {
            this.Id = id;
            this.Name = name;
            this.TeacherId = teacherId;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int TeacherId { get; set; }
        //One teacher many disciplines
        public Teacher Teacher { get; set; }

        //many students many classes
        public IEnumerable<Student> StudentsClasses { get; set; }
    }
}