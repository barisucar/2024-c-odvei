
using Ödev1.DataAccess.Abstract;
using Ödev1.Entities;

namespace Ödev1.Business;

public class CourseManager
{
    private readonly ICourseDal _courseDal;

    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }

    List<Course> GetAll()
    {
        return _courseDal.GetAll();
    }

    public void Add(Course course)
    {
        _courseDal.Add(course);
    }

    public void Delete(Course course)
    {
        _courseDal.Delete(course);
    }

    public Course Update(Course course)
    {
        return _courseDal.Update(course);
    }
}
