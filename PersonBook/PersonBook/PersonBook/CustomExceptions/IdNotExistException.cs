using System;


namespace PersonBook.CustomExceptions
{
    class IdNotExistException:Exception
    {
        public IdNotExistException(int Id)
            :base($"{Id} : id not exist!")
        {
         
        }
    }
}
