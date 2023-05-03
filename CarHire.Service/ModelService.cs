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
        private List<Model> Modelslist = new List<Model>
        {
            new Model
            {
                ModelCode = 5654,
                ModelName = "Vios",
                DailyHireRate = 400,
                ManufacturerCode = 444,

            }
        };
        public bool IsAlreadyRegistered(int modelCode)
        {
            var model = Modelslist.Where(a => a.ModelCode == modelCode).FirstOrDefault();
            return model != null;
        }


            public List<Model> GetModel()
        {
            return Modelslist;
        }

        public void Add(Model model)
        {
            Modelslist.Add(model);
        }

        public List<Model> Delete(Model model)
        {
            var selectedModel = Modelslist.Where(
             a => a.ModelCode == model.ModelCode).FirstOrDefault();
            Modelslist.Remove(selectedModel);
            return Modelslist;
        }

        public void Update(Model model)
        {
            Delete(model);
            Modelslist.Add(model);
        }

        //public Model? FindById(int modelCode)
        //{
        //    return Modelslist.Where(unit => unit.ModelCode == modelCode).FirstOrDefault();  
        //}
    }

}
