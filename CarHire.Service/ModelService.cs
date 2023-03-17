using CarHire_.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarHire.Service
{
    public class ModelService
    {
        private List<Model> Models = new List<Model>
        {
            new Model
            {
                ModelCode = 5654,
                ModelName = "Vios",
                DailyHireRate = 400,
                ManufacturerCode = 444,

            }
        };

        public List<Model> GetModel()
        {
            return Models;
        }

        public void Add(Model model)
        {
            Models.Add(model);
        }

        public void Delete(Model model)
        {
            Models.Remove(model);
        }

        public void Update(Model model)
        {
            var selectedModel = Models.Where(unit => unit.ModelCode == model.ModelCode).FirstOrDefault();
            selectedModel = model;
        }

        public Model? FindById(int modelCode)
        {
            return Models.Where(unit => unit.ModelCode == modelCode).FirstOrDefault();  
        }
    }

}
