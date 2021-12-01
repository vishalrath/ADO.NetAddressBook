using System;

namespace Uc4ADO_AddressBook_AbilityToDelete
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AddressBookRepository repo = new AddressBookRepository();
            //repo.UpdateQueryBasedonName();
            repo.DeletePersonBasedonName();
            Console.ReadLine();
        }
    }
}
