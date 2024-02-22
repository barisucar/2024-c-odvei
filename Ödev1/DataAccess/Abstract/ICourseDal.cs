using Ödev1.Entities;

namespace Ödev1.DataAccess.Abstract;

public interface ICourseDal
{
    List<Course> GetAll();
    void Add(Course course);
    void Delete(Course course);
    Course Update(Course course);
}