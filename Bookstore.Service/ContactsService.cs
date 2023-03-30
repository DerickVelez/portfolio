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
            new Contacts
            {
                CondtactID = 454,
                ContactFirstName = "jan Derick",
                ContactLastName = "velez",
                ContactWorkPhoneNumber = 66545611,
                ContactCellPhoneNumber = 44454,
                ContactOtherDetails = " sdlkfjsaldj",

            }
        };
        //function fot no duplicates
        public bool IsAlreadyExist(int contactID)
        {
            var alreadyexist = contactList.Where(a => a.CondtactID == contactID).FirstOrDefault();
            return alreadyexist != null;
        }
        

        
        public List<Contacts> GetContacts()
        {
            var cs = @"Server=DESKTOP-F3KVDMV\MSSQLSERVER01;Database=Bookstore;Trusted_Connection=True;";

            using var con = new SqlConnection(cs);
            con.Open();

            var contacts = con.Query<Contacts>("SELECT * FROM Contacts");
            return contacts.ToList();
        }

        public Contacts Add(Contacts contact)
        {
            // TODO: test
            //var cs = @"Server=DESKTOP-F3KVDMV\MSSQLSERVER01;Database=Bookstore;Trusted_Connection=True;";

            //using var con = new SqlConnection(cs);
            //con.Open();

            //var createdContacts = con.QuerySingle<Contacts>("INSERT INTO Contacts (ContactFirstName,ContactLastName,ContactWorkPhoneNumber,ContactCellPhoneNumber,ContactOtherDetails) OUTPUT INSERTED.ContactID, INSERTED.FirstName, INSERTED.LastName VALUES (@FirstName,@LastName);", request);
            return contact;
        }

        public List<Contacts>  Delete(Contacts contact)
        {
  var selectedcontacs = contactList.Where(
                a => a.CondtactID == contact.CondtactID).FirstOrDefault();
            contactList.Remove(selectedcontacs);
            return contactList;
        }

        public void Update(Contacts contact)
        {
            var selectedcontacs = contactList.Where(
                a => a.CondtactID == contact.CondtactID).FirstOrDefault();
            contactList.Remove(selectedcontacs);
            contactList.Add(contact);
        }

        public Contacts? FindById(int contactID)
        {
            return contactList.Where(a => a.CondtactID == contactID).FirstOrDefault();
        }
    }


}
