using System;

namespace Uc3ADO.Net_EditContact_AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AddressBookRepository repo = new AddressBookRepository();
            repo.UpdateQueryBasedonName();
        }
    }
}
