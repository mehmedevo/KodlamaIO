using Intro.DataAccess.Abstracts;
using Intro.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Intro.DataAccess.Concretes
{
    public class CourseDal : ICourseDal
    {
        private readonly List<Course> _courses = new List<Course>();
        public CourseDal()
        {
            _courses = new List<Course>
            {
                new Course{Id=1, CourseName = "C#", CourseDescription ="2024 Yazılım Geliştirici Yetiştirme Kampı (C#)"},
                new Course{Id=2, CourseName="Java" , CourseDescription = "(2022) Yazılım Geliştirici Yetiştirme Kampı - JAVA"},
                new Course{Id=3, CourseName="Python" , CourseDescription = "(2023) Yazılım Geliştirici Yetiştirme Kampı - Python & Selenium"}
            };
        }

        public void Delete(int id)
        {
            var result = _courses.FirstOrDefault(o => o.Id == id);
            if(result != null)
            _courses.Remove(result);
        }

       

        void ICourseDal.Add(Course course)
        {
            _courses.Add(course);
        }

        List<Course> ICourseDal.GetAll()
        {
            return _courses;
        }

        void ICourseDal.Update(Course course)
        {
            var result = _courses.FirstOrDefault(o => o.Id == course.Id);
            if(result != null)
            {
                result.CourseName = course.CourseName;
                result.CourseDescription = course.CourseDescription;
                
            }
        }
    }
}
