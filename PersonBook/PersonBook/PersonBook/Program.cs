using System;

namespace PersonBook
{
    class Program
    {
       //
        static void Main(string[] args)
        {


            while (true)
            {
                Console.WriteLine("Welcome to Person Book Application\n " +
               "Please Type\n " +
               "1- List Persons\n " +
               "2- Add new Person\n " +
               "3- Update Person\n " +
               "4- Delete Person\n " +
               "5- exit");
                string option = Console.ReadLine();
                if (option.Equals("5"))
                {
                    Console.WriteLine("Bye - Wish to see you again");
                    break;
                }
                switch (option)
                {
                    case  "1":
                           
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    default:

                        break;
                }
            }
               
        }

    }
}
