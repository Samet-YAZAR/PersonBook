using System;

namespace PersonBook
{
    using Entity;
    using Service;

    class Program
    {
        static void Main(string[] args)
        {
            var personService = new PersonService();
            bool flag = true;

            while (flag)
            {
                PrintOptions();
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        foreach (Person item in personService.ListPersons())
                        {
                            ShowPerson(item);
                        }
                        break;

                    case "2":

                        Console.WriteLine("Name: \nSurname : ");
                        string name = Console.ReadLine();
                        string surname = Console.ReadLine();                     
                        personService.AddPerson(name,surname);
                        break;

                    case "3":

                        Console.WriteLine("Id : \nName: \nSurname : ");
                        int inputId;
                        Int32.TryParse(Console.ReadLine(), out inputId);
                        string inputName = Console.ReadLine();
                        string inputSurname = Console.ReadLine();
                        personService.UpdatePerson(inputId,inputName,inputSurname);
                        break;

                    case "4":
                        Console.WriteLine("Id: ");
                        int number;
                        Int32.TryParse(Console.ReadLine(),out number);
                        personService.DeletePerson(number);
                        break;

                    case "5":
                        Console.WriteLine("Good Bye!");
                        flag = false;
                        break;

                    default:
                        Console.WriteLine("Please enter a valid number...");
                        break;
                }
            }

        }

        private static void ShowPerson(Person p)
        {
            Console.WriteLine("********************************\n");
            Console.WriteLine("Id : " + p.Id + "\n" +
                "First Name : " + p.FirstName + "\n" +
                "Last Name : " + p.LastName);
            Console.WriteLine("********************************\n");
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
