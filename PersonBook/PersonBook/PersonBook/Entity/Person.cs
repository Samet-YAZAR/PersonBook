
using System.ComponentModel.DataAnnotations;

namespace PersonBook.Entity
{
    class Person 
    {
       // [Required]
        public int Id { get; set; }
        public int FirstName { get; set; }
        public int LastName { get; set; }
    }
}
