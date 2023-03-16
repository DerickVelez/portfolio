using Bookstore.Data.Entitites;
using Bookstore.Service;
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
            _BookCategoriesService.Add(bookCategories);
            return bookCategories;
        }

    }

}
