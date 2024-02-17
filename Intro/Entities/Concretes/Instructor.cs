using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Entities.Concretes
{
    public class Instructor
    {
        public int Id { get; set; }
        public string InstructorName { get; set; }
        public string InstructorLastName { get; set; } 
        public List<Instructor> Instructors { get; set; }
    }
}
