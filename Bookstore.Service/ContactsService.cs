 using Bookstore.Data.Entitites;
using System;
using System.Collections.Generic;
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
            return contactList;
        }

        public void Add(Contacts contact)
        {
            contactList.Add(contact);
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
