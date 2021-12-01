using System;

namespace Uc9ADO_AddressBook_AbilityToGetContact
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBookRepository repo = new AddressBookRepository();
            repo.UpdateQueryBasedonName();
            repo.DeletePersonBasedonName();
            //repo.DisplayEmployeeDetails();
            repo.PrintDataBasedOnCity("Washim","Maharastra");
            repo.PrintSortDataBasedOnCity();
            repo.PrintCountDataBasedOnCity();
            repo.ContactDataBasedOnType();
        }
    }
}
