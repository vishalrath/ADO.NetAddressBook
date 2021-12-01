using System;

namespace Uc7ADO_Addressbook_AbilityToCountCityState
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBookRepository repo = new AddressBookRepository();
            repo.PrintCountDataBasedOnCity();
            Console.ReadLine();
        }
    }
}
