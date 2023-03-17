using CarHire.Service;
using CarHire_.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarHire.WebAPI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleCategoryController : ControllerBase
    {
        private static ModelService _modelService { get; set; } = new ModelService();

        [HttpGet]
        public List<Model> Get()
        {
            return _modelService.GetModel();
        }
        [HttpPost]
        public Model Add(Model model)
        {
            _modelService.Add(model);
                return model;
        }
    }
}
