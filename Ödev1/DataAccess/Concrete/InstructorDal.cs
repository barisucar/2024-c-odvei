using Ödev1.DataAccess.Abstract;
using Ödev1.Entities;

namespace Ödev1.DataAccess.Concrete;

public class InstructorDal:IInstructorDal
{
    private List<Instructor> instructors;

    public InstructorDal()
    {
        Instructor instructor1 = new Instructor();
        instructor1.InstructorId = 1;
        instructor1.Name = "Ahmet";
        instructor1.NationalityId = 12345;
        
        Instructor instructor2 = new Instructor();
        instructor2.InstructorId = 1;
        instructor2.Name = "Mehmet";
        instructor2.NationalityId = 678910;

        instructors = new List<Instructor> { instructor1, instructor2 };
    }
    
    
    public List<Instructor> GetAll()
    {
        return instructors;
    }

    public void Add(Instructor instructor)
    {
        instructors.Add(instructor);
    }

    public void Delete(Instructor instructor)
    {
        instructors.Remove(instructor);
    }
    
    public Instructor Update(Instructor instructor)
    {
        var instructorItem = instructors.Where(i => i.InstructorId == instructor.InstructorId).FirstOrDefault();
        instructorItem.InstructorId = instructor.InstructorId;
        instructorItem.Name = instructor.Name;
        instructorItem.NationalityId = instructor.NationalityId;

        return instructorItem;
    }
}