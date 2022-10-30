using code_api.Model;

namespace code_api.Services
{
    public class PersonService : IPersonService
    {
        public static List<PersonModel> _people = new List<PersonModel>
        {
            new PersonModel
            {
                FirstName = "Loc",
                LastName = "Nguyen Thanh",
                Gender = "Male",
                DateOfBirth = new DateTime(2000, 01, 21),
                PhoneNumber = "0961564730",
                BirthPlace = "Bac Ninh",
                IsGraduated = false
            },
            new PersonModel
            {
                FirstName = "Hung",
                LastName = "Vu Trong",
                Gender = "Male",
                DateOfBirth = new DateTime(2000, 07, 26),
                PhoneNumber = "0123456789",
                BirthPlace = "Lao Cai",
                IsGraduated = true
            },
            new PersonModel
            {
                FirstName = "Linh",
                LastName = "Nguyen Nhat",
                Gender = "Female",
                DateOfBirth = new DateTime(2000, 07, 24),
                PhoneNumber = "0977652575",
                BirthPlace = "Ha Noi",
                IsGraduated = true
            }
        };

        public PersonModel Create(PersonModel model)
        {
            throw new NotImplementedException();
        }

        public PersonModel? Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<PersonModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public PersonModel? GetOne(Guid id)
        {
            throw new NotImplementedException();
        }

        public PersonModel? Update(Guid id, PersonModel model)
        {
            throw new NotImplementedException();
        }
    }
}
