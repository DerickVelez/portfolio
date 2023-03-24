using Bookstore.Data.Entitites;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            var cs = @"Server=DESKTOP-F3KVDMV\MSSQLSERVER01;Database=Bookstore;Trusted_Connection=True;";

            using var con = new SqlConnection(cs);
            con.Open();

            var bookCategories = con.Query<BookCategories>("SELECT * FROM BookCategories");

            return bookCategories.ToList();
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
