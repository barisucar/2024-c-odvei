using Ödev1.DataAccess.Abstract;
using Ödev1.Entities;

namespace Ödev1.DataAccess.Concrete;

public class CategoryDal:ICategoryDal
{
    private List<Category> categories;

    public CategoryDal()
    {
        Category cat1 = new Category();
        cat1.CategoryId = 1;
        cat1.CategoryName = "All";
        
        Category cat2 = new Category();
        cat2.CategoryId = 2;
        cat2.CategoryName = "Programing";
        
        Category cat3 = new Category();
        cat3.CategoryId = 3;
        cat3.CategoryName = "Marketing";

        categories = new List<Category> { cat1, cat2, cat3 };
    }
    
    public List<Category> GetAll()
    {
        return categories;
    }

    public void Add(Category category)
    {
        categories.Add(category);
    }

    public void Delete(Category category)
    {
        categories.Remove(category);
    }

    public Category Update(Category category)
    {
        var catItem = categories.Where(c => c.CategoryId == category.CategoryId).FirstOrDefault();
        catItem.CategoryId = category.CategoryId;
        catItem.CategoryName = category.CategoryName;

        return catItem;
    }
}