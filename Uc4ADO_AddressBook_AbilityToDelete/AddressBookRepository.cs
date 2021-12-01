using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uc4ADO_AddressBook_AbilityToDelete
{
    class AddressBookRepository
    {
        //Give path for Database Connection
        public static string connection = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Address_Book;TrustServerCertificate=False;";
        //Represents a connection to Sql Server Database
        SqlConnection sqlConnection = new SqlConnection(connection);
        private object addressBook;

        public int InsertIntoTable(Contact addressBook) //parameterize method AddressBook is para
        {
            int result = 0;
            try
            {
                using (sqlConnection)
                {
                    SqlCommand sqlCommand = new SqlCommand("spInsertIntoTableAddresBook", this.sqlConnection);
                    //setting command type as stored procedure
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@id", addressBook.ID_Abook);
                    sqlCommand.Parameters.AddWithValue("@FirstName", addressBook.FirstName);
                    sqlCommand.Parameters.AddWithValue("@LastName", addressBook.LastName);
                    sqlCommand.Parameters.AddWithValue("@Address", addressBook.Address);
                    sqlCommand.Parameters.AddWithValue("@City", addressBook.City);
                    sqlCommand.Parameters.AddWithValue("@State", addressBook.State);
                    sqlCommand.Parameters.AddWithValue("@zip", addressBook.zip);
                    sqlCommand.Parameters.AddWithValue("@PhoneNumber", addressBook.PhoneNumber);
                    sqlCommand.Parameters.AddWithValue("@Email", addressBook.Email);
                    sqlCommand.Parameters.AddWithValue("@addressBookName", addressBook.AddressBookName);
                    sqlCommand.Parameters.AddWithValue("@addressBookType", addressBook.Type);
                    sqlConnection.Open();
                    //Return the number of rows updated
                    result = sqlCommand.ExecuteNonQuery();
                    if (result != 0)
                    {
                        Console.WriteLine("Inserted");
                    }
                    else
                    {
                        Console.WriteLine("Not Inserted");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
            return result;
        }
        //UseCase 3: Modify Existing Contact using their name
        public int UpdateQueryBasedonName()
        {
            //Open Connection
            sqlConnection.Open();
            string query = "Update ADO_EMPAddressBook1 set Email = 'vishal@gmail.com' where FirstName = 'Vishal'";
            //Pass query to TSql
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            int result = sqlCommand.ExecuteNonQuery();
            if (result != 0)
            {
                Console.WriteLine("Updated!");
            }
            else
            {
                Console.WriteLine("Not Updated!");
            }

            //Close Connection
            sqlConnection.Close();
            return result;
        }
        //UseCase 4-Delete Contact using their name
        public int DeletePersonBasedonName()
        {
            //Open Connection
            sqlConnection.Open();
            string query = "delete from ADO_EMPAddressBook1 where FirstName = 'Rakesh' and LastName = 'Musle'";
            //Pass query to TSql
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            int result = sqlCommand.ExecuteNonQuery();
            if (result != 0)
            {
                Console.WriteLine("Deleted!");
            }
            else
            {
                Console.WriteLine("Not Deleted!");
            }

            //Close Connection
            sqlConnection.Close();
            return result;
        }

        public void DisplayEmployeeDetails(SqlDataReader sqlDataReader)
        {

            addressBook.FirstName = Convert.ToString(sqlDataReader["FirstName"]);
            addressBook.LastName = Convert.ToString(sqlDataReader["LastName"]);
            addressBook.Address = Convert.ToString(sqlDataReader["Address"] + " " + sqlDataReader["City"] + " " + sqlDataReader["State"] + " " + sqlDataReader["zip"]);
            addressBook.PhoneNumber = Convert.ToInt64(sqlDataReader["PhoneNumber"]);
            addressBook.Email = Convert.ToString(sqlDataReader["email"]);
            addressBook.AddressBookName = Convert.ToString(sqlDataReader["AddressBookName"]);
            addressBook.Type = Convert.ToString(sqlDataReader["TypeOfAddressBook"]);
            Console.WriteLine("{0} | {1} | {2} | {3} | {4} | {5} | {6}", addressBook.FirstName, addressBook.LastName, addressBook.Address, addressBook.PhoneNumber, addressBook.Email, addressBook.AddressBookName, addressBook.Type);

        }
    }
}
