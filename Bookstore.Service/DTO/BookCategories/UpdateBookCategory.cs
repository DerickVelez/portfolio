using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Service.DTO.BookCategories
{
    public class UpdateBookCategory
    {
        public int BookCategoryCode { get; set; }

        public string BookCategoryDescription { get; set; }
    }
}
