using code_api.Model;

namespace code_api.Services
{
    public interface IPersonService
    {
        List<PersonModel> GetAll();
        PersonModel? GetOne(Guid id);
        PersonModel Create(PersonModel model);
        PersonModel? Update(Guid id, PersonModel model);
        PersonModel? Delete(Guid id);
    }
}