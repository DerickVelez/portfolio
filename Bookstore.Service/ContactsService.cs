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

        public List<Contacts> GetContacts()
        {
            return contactList;
        }

        public void Add(Contacts contacts)
        {
            contactList.Add(contacts);
        }

        public void Delete(Contacts contacts)
        {
            contactList.Remove(contacts);
        }

        public void Update(Contacts contacts)
        {
            var selectedcontacs = contactList.Where(a => a.CondtactID == contacts.CondtactID).FirstOrDefault();
            selectedcontacs = contacts;
        }

        public Contacts? FindById(int contactID)
        {
            return contactList.Where(a => a.CondtactID == contactID).FirstOrDefault();

        }
    }


}
