using System.ComponentModel.DataAnnotations;

namespace PersonBook.Entity
{
    class Person 
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
