using efday1.DTOs;
using efday1.Models;

namespace efday1.Services
{
    public interface IStdService
    {
        AddStdResponse Create(AddStdRequest createModel);
        IEnumerable<Student> GetAll();
        bool Delete(int id);
        UpdateResponse Update(int id, UpdateRequest updateRequest);
    }
}