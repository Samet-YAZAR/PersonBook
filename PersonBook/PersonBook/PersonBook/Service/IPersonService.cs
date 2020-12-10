using System;
using System.Collections.Generic;
using System.Text;

namespace PersonBook
{
    interface IPersonService<Person>
    {
        public List<Person> ListPersons();
        public void DeletePerson(int id);
        public void AddPerson(Person person);
        public void UpdatePerson(Person person);
    }
}
