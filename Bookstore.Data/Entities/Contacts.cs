using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Data.Entitites
{
    public class Contacts
    {
        public int CondtactID { get; set; }

        public string ContactFirstName { get; set; }

        public string ContactLastName { get; set; }   

        public int ContactWorkPhoneNumber { get; set; }

        public int ContactCellPhoneNumber { get; set; }

        public string ContactOtherDetails { get; set; }


    }
}
