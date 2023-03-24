using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Service.DTO.Author;

public class CreateAuthorRequest
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}
