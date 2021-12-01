using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uc1ADO.Net_DatabsaseConnection_AddressBook
{
    class AddressBookRepository
    {
        //Give path for Database Connection
        public static string connection = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Address_Book;TrustServerCertificate=False;";
        //Represents a connection to Sql Server Database
        SqlConnection sqlConnection = new SqlConnection(connection);
    }
}
