
using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonBook.Service
{
    using CustomExceptions;
    using Entity;

    public class PersonService : IPersonService<Person>
    {
        private ICollection<Person> _personList;
        public PersonService()
        {
            _personList = new List<Person>();
        }

        public void AddPerson(string name, string surname)
        {
            int id = GenerateId();

            _personList.Add(
                   new Person
                   {
                       Id = id,
                       FirstName = name,
                       LastName = surname
                   });
        }

        public void DeletePerson(int id)
        {

            var person = _personList.FirstOrDefault(p => p.Id == id);

            if (person == null)
            {
                throw new IdNotExistException(id);
            }

            _personList.Remove(person);

        }

        public ICollection<Person> ListPersons()
        {
            return _personList;
        }

        public void UpdatePerson(int id, string name, string surname)
        {
            var p = _personList.FirstOrDefault(i => i.Id == id);

            if (p == null)
            {
                throw new IdNotExistException(id);
            }
            p.FirstName = name;
            p.LastName = surname;
        }
        private int GenerateId()
        {
            return _personList.Count > 0 ? _personList.Max(p => p.Id) + 1 : 1;
        }
    }

}