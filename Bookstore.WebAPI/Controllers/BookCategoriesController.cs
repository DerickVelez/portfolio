using Bookstore.Data.Entitites;
using Bookstore.Service;
using Bookstore.Service.DTO.BookCategories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bookstore.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookCategoriesController : ControllerBase
    {

        private static BookCategoriesService _BookCategoriesService { get; set; } = new BookCategoriesService();

        [HttpGet]
        public List<BookCategories> Get()
        {
            return _BookCategoriesService.GetBookCategories();
        }
        [HttpPost]

        public BookCategories Add(BookCategories bookCategories)
        {
            bool alreadyExist = _BookCategoriesService.IsAlreadyExist(bookCategories.BookCategoryCode,bookCategories.BookCategoryDescription);
            if (!alreadyExist)
            {  _BookCategoriesService.Add(bookCategories);
                return bookCategories;
            }
            else 
                return null;
        }

        [HttpPut]
        public BookCategories Update(BookCategories bookCategories)
        {
            _BookCategoriesService.Update(bookCategories);
            return bookCategories;
        }

        [HttpDelete]
        public BookCategories Delete(BookCategories bookCategories)
        {
            _BookCategoriesService.Delete(bookCategories);
            return bookCategories;
        }

    }

}
