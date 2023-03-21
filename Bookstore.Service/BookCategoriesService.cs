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
       
        public bool IsAlreadyExist(int bookCategoryCode,string bookCategoryDescription)
        {
            var bookCategotyCode = bookcategoriesList.Where(c => c.BookCategoryCode == bookCategoryCode && c.BookCategoryDescription == bookCategoryDescription).FirstOrDefault();
            return bookCategotyCode != null;
        }
        public List<BookCategories> GetBookCategories()
        {
            return bookcategoriesList;
        }

        public void Add(BookCategories bookcategory)
        {
            bookcategoriesList.Add(bookcategory);
        }

        public List<BookCategories> Delete(BookCategories bookcategory)
        {
            bookcategoriesList = bookcategoriesList.Where(a => a.BookCategoryCode != bookcategory.BookCategoryCode).ToList();
            return bookcategoriesList;
        }

        public void Update(BookCategories bookcategory)
        {
            var selectedBookCategories = bookcategoriesList.Where(
                a => a.BookCategoryCode == bookcategory.BookCategoryCode).FirstOrDefault();
            bookcategoriesList.Remove(selectedBookCategories);
            bookcategoriesList.Add(bookcategory);
        }

        public BookCategories? FindById(int bookcategorycode)
        {
            return bookcategoriesList.Where(a => a.BookCategoryCode == bookcategorycode).FirstOrDefault();
        }

    }

}
