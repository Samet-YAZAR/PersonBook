using System;

namespace PersonBook
{
    using Entity;
    using CustomExceptions;
    using Service;

    class Program
    {
        private const string Show   = "1";
        private const string Add    = "2";
        private const string Update = "3";
        private const string Delete = "4";
        private const string Exit   = "5";

        static void Main(string[] args)
        {
            var personService = new PersonService();
            var isContinued = true;
            

            while (isContinued)
            {
                PrintOptions();
                string option = Console.ReadLine();

                switch (option)
                {
                    case Show:
                            ShowPersons();             
                        break;

                    case Add:
                        Console.WriteLine("Name: \nSurname : ");
                        string name = Console.ReadLine();
                        string surname = Console.ReadLine();                     
                        personService.AddPerson(name,surname);
                        break;

                    case Update:
                        Console.WriteLine("Id : \nName: \nSurname : ");
                        Int32.TryParse(Console.ReadLine(), out var id);
                        string inputName = Console.ReadLine();
                        string inputSurname = Console.ReadLine();
                        try
                        {
                            personService.UpdatePerson(id, inputName, inputSurname);
                        }
                        catch (IdNotExistException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;

                    case Delete:
                        Console.WriteLine("Id: ");
                        Int32.TryParse(Console.ReadLine(),out var number);
                        try 
                        {
                            personService.DeletePerson(number);
                        }
                        catch(IdNotExistException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        
                        break;

                    case Exit:
                        Console.WriteLine("Good Bye!");
                        isContinued = false;
                        break;

                    default:
                        Console.WriteLine("Please enter a valid number...");
                        break;
                }
            }

        }

        private static void ShowPersons()
        {
            var personService = new PersonService();
            foreach (Person p in personService.ListPersons())
            {

                Console.WriteLine("********************************\n");
                Console.WriteLine("Id : " + p.Id + "\n" +
                    "First Name : " + p.FirstName + "\n" +
                    "Last Name : " + p.LastName);
                Console.WriteLine("********************************\n");
            }
        }

        private static void PrintOptions()
        {
            Console.WriteLine("\n" +
                           "~~~~~~Welcome to Person Book Application~~~~~\n " +
                           "Please Type\n " +
                           "1- List Persons\n " +
                           "2- Add new Person\n " +
                           "3- Update Person\n " +
                           "4- Delete Person\n " +
                           "5- exit\n");
        }
    }
}
