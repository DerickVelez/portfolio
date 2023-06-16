using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Data.Entitites
{
    public record Contacts
    (
         int CondtactID,
        string ContactFirstName, 
        string ContactLastName,
        int ContactWorkPhoneNumber, 
        int ContactCellPhoneNumber,
        string ContactOtherDetails    
      );
}
