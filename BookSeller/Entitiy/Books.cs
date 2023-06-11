using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSeller.Entitiy
{
    public class Books
    {
        public int BookId { get; set; }
        public int ISBN { get; set; }
        public string BookTitle { get; set; }
        public DateTime PublicationDate { get; set; }
        public string BookComments { get; set; }
    }
}
