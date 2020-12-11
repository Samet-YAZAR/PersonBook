using PersonBook.Entity;
using PersonBook.Service;
using System;
using System.Collections.Generic;

namespace PersonBook
{
    class Program
    {
       //
        static void Main(string[] args)
        {
            PersonService pservice = new PersonService();

            while (true)
            {
                Console.WriteLine("\n" + 
               "~~~~~~Welcome to Person Book Application~~~~~\n " +
               "Please Type\n " +
               "1- List Persons\n " +
               "2- Add new Person\n " +
               "3- Update Person\n " +
               "4- Delete Person\n " +
               "5- exit\n");
                string option = Console.ReadLine();
              
                switch (option)
                {
                    case  "1":

                            pservice.ListPersons().ForEach(p => {
                                Console.WriteLine("********************************\n");
                                Console.WriteLine("Id : " + p.Id + "\n" +
                                    "First Name : " + p.FirstName + "\n" +
                                    "Last Name : " + p.LastName);
                                Console.WriteLine("********************************\n");
                            });
                        break;

                    case "2":

                        Console.WriteLine("Enter name and surname");
                        string name = Console.ReadLine();
                        string surname = Console.ReadLine();
                        Person newPerson =new Person(name,surname);
                        pservice.AddPerson(newPerson);
                        break;

                    case "3":

                        Console.WriteLine("Please enter an ID and new Name, Surname ");
                        int inputId = int.Parse(Console.ReadLine());
                        string inputName = Console.ReadLine();
                        string inputSurname = Console.ReadLine();
                        Person pUpdate = new Person(inputId, inputName, inputSurname);
                        pservice.UpdatePerson(pUpdate);
                        break;

                    case "4":

                        Console.WriteLine("Please enter an ID ");
                        int deleteId = int.Parse(Console.ReadLine());
                        pservice.DeletePerson(deleteId);
                        break;
                    case "5":
                        Console.WriteLine("Bye - Wish to see you again");
                        return;

                    default:
                        Console.WriteLine("Please enter a valid number...");
                        break;
                }
            }
               
        }

    }
}
