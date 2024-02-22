using Ödev1.DataAccess.Abstract;
using Ödev1.Entities;

namespace Ödev1.Business;

public class InstructorManager
{
    private readonly IInstructorDal _instructorDal;

    public InstructorManager(IInstructorDal instructorDal)
    {
        _instructorDal = instructorDal;
    }

    List<Instructor> GetAll()
    {
        return _instructorDal.GetAll();
    }

    public void Add(Instructor instructor)
    {
        _instructorDal.Add(instructor);
    }

    public void Delete(Instructor instructor)
    {
        _instructorDal.Delete(instructor);
    }

    public Instructor Update(Instructor instructor)
    {
        return _instructorDal.Update(instructor);
    }
}