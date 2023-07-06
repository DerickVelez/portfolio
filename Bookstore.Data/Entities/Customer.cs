using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Data.Entitites
{
    public record Customer
    (
        int CustomerID,
         int CustomerCode,
        string CustomerName,
        string CustomerAddress,
        int CustomerPhone,
        string CustomerEmail
            );
}
