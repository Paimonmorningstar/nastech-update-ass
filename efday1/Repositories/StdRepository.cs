using efday1.Data;
using efday1.Models;
using efday1.Repositories;

namespace efday1.Repositories
{
    public class StdRepository : BaseRepository<Student>, IStdRepository
    {
        public StdRepository(StdManagementContext context) : base(context)
        {
        }
        
    }
}