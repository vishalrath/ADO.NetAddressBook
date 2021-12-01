using System;

namespace Uc5ADO_Addressbook_Retrive_CityAndState
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeRepository repo = new EmployeeRepository();
            repo.PrintDataBasedOnCity("Washim","Maharastra");
            Console.ReadLine();
        }
    }
}
