using Bookstore.Data.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Service
{
    public class BookCategoriesService
    {
        private List<BookCategories> bookcategoriesList = new List<BookCategories>
        {
            new BookCategories
            {
                BookCategoryCode = 1,
                BookCategoryDescription = "Horror",

            }
        };


        public List<BookCategories> GetBookCategories()
        {
            return bookcategoriesList;
        }

        public void Add(BookCategories bookcategories)
        {
            bookcategoriesList.Add(bookcategories);
        }

        public void Delete(BookCategories bookcategories)
        {
            bookcategoriesList.Remove(bookcategories);
        }

        public void Update(BookCategories bookcategories)
        {
            var selectedBookCategories = bookcategoriesList.Where(a => a.BookCategoryCode == bookcategories.BookCategoryCode).FirstOrDefault();
            selectedBookCategories = bookcategories;
                
        }

        public BookCategories? FindById(int bookcategorycode)
        {
            return bookcategoriesList.Where(a => a.BookCategoryCode == bookcategorycode).FirstOrDefault();
        }

    }

}
