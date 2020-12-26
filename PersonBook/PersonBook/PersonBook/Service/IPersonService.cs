
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonBook
{
    using Entity;
    interface IPersonService
    {
        ICollection<Person> ListPersons();
        void DeletePerson(int id);
        void AddPerson(string name, string surname);
        void UpdatePerson(int id, string name, string surname);
    }
}
