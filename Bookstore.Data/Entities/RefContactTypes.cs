using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Data.Entitites
{
    public  record RefContactTypes
    (
        int ContactCode,
        string ContactDescription,
        int ContactID
   );
}
