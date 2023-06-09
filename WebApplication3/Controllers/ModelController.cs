﻿using CarHire.Service;
using CarHire_.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarHire.WebAPI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelController : ControllerBase
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
            bool alreadyexist = _modelService.IsAlreadyRegistered(model.ModelCode);
            if (alreadyexist)
                return null;
            _modelService.Add(model);
            return model;
        }
        [HttpPut]
        public Model Update(Model model)
        { _modelService.Update(model);
            return model;
        }
        [HttpDelete]
        public Model Delete(Model model)
        {
            _modelService.Delete(model);
            return model;
        }
    }
}
