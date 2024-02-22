using Ödev1.DataAccess.Abstract;
using Ödev1.Entities;

namespace Ödev1.DataAccess.Concrete;

public class CourseDal:ICourseDal
{
    private List<Course> courses;

    public CourseDal()
    {
        Course course1 = new Course();
        course1.CourseId = 1;
        course1.CourseName = "Java";
        
        Course course2 = new Course();
        course2.CourseId = 2;
        course2.CourseName = "C#";
        
        Course course3 = new Course();
        course3.CourseId = 3;
        course3.CourseName = "Blender";

        courses = new List<Course> { course1, course2, course3 };
    }
    
    
    public List<Course> GetAll()
    {
        return courses;
    }

    public void Add(Course course)
    {
        courses.Add(course);
    }

    public void Delete(Course course)
    {
        courses.Remove(course);
    }
    
    public Course Update(Course course)
    {
        var courseItem = courses.Where(c => c.CourseId == course.CourseId).FirstOrDefault();
        courseItem.CourseId = course.CourseId;
        courseItem.CourseName = course.CourseName;

        return courseItem;
    }
}