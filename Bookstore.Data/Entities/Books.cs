using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Data.Entitites
{
    public  record Books
    ( 
         int BookID,
         int ISBN, 
         string BookTitle, 
         DateTime PublicationDate, 
         string BookComment,  
         int AuthorID,  
         int ItemNumber,
         int BookCategoryCode
    );
}
