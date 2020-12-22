
using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonBook.Service
{
    using CustomExceptions;
    using Entity;

    class PersonService : IPersonService<Person>
    {
        private ICollection<Person> _personList;
        public PersonService()
        {
            _personList = new List<Person>();
        }

        public void AddPerson(string name, string surname)
        {
            int Id = IdGenerator();

            _personList.Add(
                   new Person
                   {
                       Id = Id,
                       FirstName = name,
                       LastName = surname
                   });
        }

        public void DeletePerson(int id)
        {

            var personToRemove = _personList.Single(p => p.Id == id);

            if (personToRemove==null)
            {
                throw new IdNotExistException(id);
            }

            _personList.Remove(personToRemove);

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
        private int IdGenerator()
        {
            return _personList.Count > 0 ? _personList.Max(p => p.Id) + 1 : 1;
        }
    }

}