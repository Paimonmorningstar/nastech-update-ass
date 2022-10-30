using code_api.Model;

namespace code_api.Services
{
    public class PersonServiceExtended : IPersonService
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

        public List<PersonModel> GetAll()
        {
            return _people;
        }

        public PersonModel? GetOne(Guid id)
        {
            return _people.SingleOrDefault(p => p.Id.Equals(id));
        }

        public PersonModel Create(PersonModel model)
        {
            _people.Add(model);

            return model;
        }

        public PersonModel? Update(Guid id, PersonModel model)
        {
            var index = _people.FindIndex(p => p.Id.Equals(id));

            if (index >= 0)
            {
                _people[index] = model;

                return _people[index];
            }

            return null;
        }

        public PersonModel? Delete(Guid id)
        {
            var index = _people.FindIndex(p => p.Id.Equals(id));

            if (index >= 0)
            {
                _people.RemoveAt(index);

                return _people[index];
            }

            return null;
        }

        public PersonModel? FilterName(string name)
        {
            PersonModel[] names = _people.ToArray();
            var result = new PersonModel[names.Length];
            var j = 0;

            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].FirstName.Equals(name))
                {
                    result[j] = names[j];
                    j++;
                }
            }

            foreach (var item in result)
            {
                return item;
            }

            return null;
        }
    }
}