using Ödev1.Entities;

namespace Ödev1.DataAccess.Abstract;

public interface IInstructorDal
{
    List<Instructor> GetAll();
    void Add(Instructor instructor);
    void Delete(Instructor instructor);
    Instructor Update(Instructor instructor);
}