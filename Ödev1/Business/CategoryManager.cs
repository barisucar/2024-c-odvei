using Ödev1.DataAccess.Abstract;
using Ödev1.Entities;

namespace Ödev1.Business;

public class CategoryManager
{
    private readonly ICategoryDal _categoryDal;

    public CategoryManager(ICategoryDal categoryDal)
    {
        _categoryDal = categoryDal;
    }

    public List<Category> GetAll()
    {
        return _categoryDal.GetAll();
    }

    public void Add(Category category)
    {
        _categoryDal.Add(category);
    }

    public void Delete(Category category)
    {
        _categoryDal.Delete(category);
    }

    public Category Update(Category category)
    {
       return _categoryDal.Update(category);
    }
}