
using System.ComponentModel.DataAnnotations;

namespace PersonBook.Entity
{
    class Person 
    {
       // [Required]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person( string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public Person(int id,string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
