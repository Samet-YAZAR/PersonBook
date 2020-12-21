
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonBook.Service
{
    using Entity;

     class PersonService : IPersonService<Person>
    {
        private ICollection<Person> _personList;

        private readonly Random _random = new Random();

        public PersonService() 
        {
            _personList = new List<Person>();
        }
        public void AddPerson(string name,string surname)
        {
            var Id = _random.Next(1000, 9999);
            _personList.Add(
                new Person
                {
                   Id = Id,
                   FirstName= name,
                   LastName=surname
                }) ; 
        }

        public void DeletePerson(int id)
        {
            Person p = _personList.FirstOrDefault(i => i.Id == id);

            if (p != null)
            {
                _personList.Remove(p);
            }
        }

        public ICollection<Person> ListPersons()
        {

            return _personList;
        }

        public void UpdatePerson(int Id,string name,string surname)
        {
            Person p = _personList.FirstOrDefault(i => i.Id == Id);
            p.FirstName =name;
            p.LastName = surname;
        }
    }
}

