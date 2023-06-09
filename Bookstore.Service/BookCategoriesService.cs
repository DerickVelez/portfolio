﻿using Bookstore.Data.Entitites;
using Bookstore.Service.DTO.BookCategories;
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
        private List<BookCategories> bookcategoriesList = new List<BookCategories>();
        private string connectionString;
        public BookCategoriesService (string connectionString)
        {
            this.connectionString = connectionString;
        }
       
        public bool IsAlreadyExist(int bookCategoryCode,string bookCategoryDescription)
        {
            var bookCategotyCode = bookcategoriesList.Where(c => c.BookCategoryCode == bookCategoryCode && c.BookCategoryDescription == bookCategoryDescription).FirstOrDefault();
            return bookCategotyCode != null;
        }
        public List<BookCategories> GetBookCategories()
        {
            using var con = new SqlConnection(connectionString);
            con.Open();

            var bookCategories = con.Query<BookCategories>("SELECT * FROM BookCategories");

            return bookCategories.ToList();
        }

        public CreateBookCategoryRequest Add(CreateBookCategoryRequest bookcategory)
        {
            using var con = new SqlConnection(connectionString);
            con.Open();

            var createdBookCategory = con.QuerySingle<CreateBookCategoryRequest>("INSERT INTO BookCategories " +
                "(BookCategoryDescription) OUTPUT INSERTED.BookCategoryCode, INSERTED.BookCategoryDescription " +
                "VALUES (@BookCategoryDescription);",bookcategory);
            return createdBookCategory;
        }

        public BookCategories Delete(BookCategories bookcategory)
        {
            using var con = new SqlConnection(connectionString);
            con.Open();

            var createdAuthor = con.Execute("DELETE FROM BookCategories WHERE (BookCategoryCode = @BookCategoryCode)",bookcategory);
            return bookcategory;
        }

        public BookCategories Update(BookCategories bookcategory)
        {
            using var con = new SqlConnection(connectionString);
            con.Open();

            var createdAuthor = con.Execute("UPDATE BookCategories SET BookCategoryDescription = @BookCategoryDescription WHERE (BookCategoryCode = @BookCategoryCode)", bookcategory);
            return bookcategory; 
        }

        

    }

}
