using PersonBook.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonBook.Service
{
    class PersonService : IPersonService<Person>
    {
        private List<Person> _personList;
        private readonly Random _random = new Random();

        public PersonService()
        {
            _personList = new List<Person>();
        }
        public void AddPerson(Person person)
        {
            person.Id = _random.Next(1000, 9999);
            _personList.Add(person);
        }

        public void DeletePerson(int id)
        {
            Person p = _personList.FirstOrDefault(i => i.Id == id);

            if (p != null)
            {
                _personList.Remove(p);
            }
        }

        public List<Person> ListPersons()
        {

            return _personList;
        }

        public void UpdatePerson(Person person)
        {
            Person p = _personList.FirstOrDefault(i => i.Id == person.Id);
            p.FirstName = person.FirstName;
            p.LastName = person.LastName;
        }
    }
}

