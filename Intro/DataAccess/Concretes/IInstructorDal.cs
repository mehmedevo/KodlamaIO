using Intro.DataAccess.Abstracts;
using Intro.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.DataAccess.Concretes
{
    public class InstructorDal : IInstructorDal
    {
        List<Instructor> _instructors = new List<Instructor>();
        public InstructorDal()
        {
            _instructors = new List<Instructor>
            {
                new Instructor{Id=1, InstructorName = "Engin" , InstructorLastName ="Demiroğ"},
                new Instructor{Id=2, InstructorName="Halit Enes" , InstructorLastName = "Kalaycı"},
                
            };
        }
        public void Delete(int id)
        {
            var result = _instructors.FirstOrDefault(x => x.Id == id); 
            if(result != null)
            {
                _instructors.Remove(result);
            }
        }

        void IInstructorDal.Add(Instructor instructor)
        {
            _instructors.Add(instructor);
        }

        List<Instructor> IInstructorDal.GetAll()
        {
            return _instructors;
        }

        
        void IInstructorDal.Update(Instructor instructor)
        {
            var result = _instructors.FirstOrDefault(x => x.Id == instructor.Id);
            if(result != null)
            {
                result.InstructorName = instructor.InstructorName;
                result.InstructorLastName = instructor.InstructorLastName;
            }
        }
    }
}
