using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Data.Entitites
{
    
    public record Author
    (
         int AuthorID ,
         string FirstName,
         string LastName
    );
}



