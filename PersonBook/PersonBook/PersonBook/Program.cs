using System;

namespace PersonBook
{
    using Entity;
    using CustomExceptions;
    using Service;

    class Program
    {
        
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
                    case "1":
                            ShowPersons();             
                        break;

                    case "2":
                        Console.WriteLine("Name: \nSurname : ");
                        string name = Console.ReadLine();
                        string surname = Console.ReadLine();                     
                        personService.AddPerson(name,surname);
                        break;

                    case "3":
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

                    case "4":
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

                    case "5":
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
