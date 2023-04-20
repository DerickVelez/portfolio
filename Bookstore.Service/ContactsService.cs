 using Bookstore.Data.Entitites;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Service
{
    public class ContactsService
    {
        private List<Contacts> contactList = new List<Contacts>
        {
          
        };

        public string connectionString;
        // Integrate connection string 
        public ContactsService(string connectionString)
        {
            this.connectionString = connectionString;
        }


        //function for no duplicates
        public bool IsAlreadyExist(int contactID, string contactFirstName, string contactLastName)
        {
            var alreadyexist = contactList.Where(a => a.CondtactID == contactID && a.ContactFirstName == contactFirstName && a.ContactLastName == contactLastName).FirstOrDefault();
            return alreadyexist != null;
        }
        

        public List<Contacts> GetContacts()
        {
            using var con = new SqlConnection(connectionString);
            con.Open();

            var contacts = con.Query<Contacts>("SELECT * FROM Contacts");
            return contacts.ToList();
        }

        public Contacts Add(Contacts contact)
        {
            // TODO: test
       
            using var con = new SqlConnection(connectionString);
            con.Open();

            var createdContacts = con.QuerySingle<Contacts>("INSERT INTO Contacts (ContactFirstName,ContactLastName,ContactWorkPhoneNumber,ContactCellPhoneNumber,ContactOtherDetails) OUTPUT INSERTED.ContactID, INSERTED.ContactFirstName, INSERTED.ContactLastName, INSERTED.ContactWorkPhoneNumber, INSERTED.ContactCellPhoneNumber, INSERTED.ContactOtherDetails VALUES (@ContactFirstName,@ContactLastName,@ContactWorkPhoneNumber,@ContactCellPhoneNumber,@ContactOtherDetails);", contact);
            return createdContacts;
        }

        public Contacts  Delete(Contacts contact)
        {

            using var con = new SqlConnection(connectionString);
            con.Open();

            var createdAuthor = con.Execute("DELETE FROM Contacts WHERE (ContactID = @ContactID)", contact);
            return contact;

        }

        public Contacts Update(Contacts contact)
        {

            using var con = new SqlConnection(connectionString);
            con.Open();

            var createdAuthor = con.Execute("UPDATE Contacts SET ContactFirstName = @ContactFirstName, ContactLastName = @ContactLastName, ContactWorkPhoneNumber = @ContactWorkPhoneNumber, ContactCellPhoneNumber = @ContactCellPhoneNumber, ContactOtherDetails = @ContactOtherDetails WHERE (ContactID = @ContactID);", contact);
            return contact;

        }

        public Contacts? FindById(int contactID)
        {
            return contactList.Where(a => a.CondtactID == contactID).FirstOrDefault();
        }
    }


}
