using System;
using System.Collections.Generic;
using System.Text;

namespace PersonBook
{
    interface IPersonService<Person>
    {
         ICollection<Person> ListPersons();
         void DeletePerson(int id);
         void AddPerson(string name, string surname);
         void UpdatePerson(int Id,string name,string surname);
    }
}
