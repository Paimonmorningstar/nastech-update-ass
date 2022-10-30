using efass2.Models;

namespace efass2.Repositories;

public class CategoryRepository : BaseRepository<Category>, Interface.ICategoryRepository
{
    public CategoryRepository(ProductStoreContext context) : base(context)
    {
    }
}
