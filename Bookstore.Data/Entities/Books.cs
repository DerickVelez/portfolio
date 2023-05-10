using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Data.Entitites
{
    public  class Books
    {
        public int BookID { get; set; }

        public int ISBN { get; set; }

        public string BookTitle { get; set; }

        public DateTime PublicationDate { get; set; }

        public string BookComment { get; set; }

        public int AuthorID { get; set; }

        public int ItemNumber { get; set; }

        public int BookCategoryCode { get; set; }
    }
}
