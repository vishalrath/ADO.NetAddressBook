using System;

namespace Uc8ADO_AddressBook_SortedAlphabetically
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBookRepository repo = new AddressBookRepository();
            repo.PrintSortDataBasedOnCity();
        }
    }
}
