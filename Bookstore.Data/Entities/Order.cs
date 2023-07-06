using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Data.Entitites
{
    public record Order
    (
        DateTime OrderDate,

        string OrderValue,

        int CustomerID
    );
}

    


