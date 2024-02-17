using Intro.Business.Concretes;
using Intro.DataAccess.Abstracts;
using Intro.DataAccess.Concretes;
using Intro.Entities.Concretes;
using System.Net.NetworkInformation;

internal class Program
{


    private static void Main(string[] args)
    {
        CourseManager courseManager = new CourseManager(new CourseDal());
        CategoryManager categoryManager = new CategoryManager(new CategoryDal());
        InstructorManager instructorManager = new InstructorManager(new InstructorDal());
        foreach (var category in categoryManager.GetAll())
        {
            Console.WriteLine(category.CategoryName);
        }

        foreach (var course in courseManager.GetAll())
        {
            Console.WriteLine(course.CourseName + course.CourseDescription);
        }


        foreach (var instructor in instructorManager.GetAll())
        {
            Console.WriteLine(instructor.InstructorName + " " + instructor.InstructorLastName);
        }

        Console.ReadLine();
    }
}