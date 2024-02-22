using Ödev1.Entities;

namespace Ödev1.DataAccess.Abstract;

public interface ICategoryDal
{
    List<Category> GetAll();
    void Add(Category category);
    void Delete(Category category);
    Category Update(Category category);//void olmamasinin sebebi update ile dondurecegimiz nesne category nesnesi oldugu icin.
}