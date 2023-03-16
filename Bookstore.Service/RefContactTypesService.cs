using Bookstore.Data.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Service
{
    public class RefContactTypesService
    {
        private List<RefContactTypes> refcontacttypesList = new List<RefContactTypes>
        {
            new RefContactTypes
            {
                ContactCode = 56,
                ContactDescription = "No Description",

            }
        };

        public List<RefContactTypes> GetRefContactTypes()
        {
            return refcontacttypesList;
        }

        public void Add(RefContactTypes refcontacttypes)
        {
            refcontacttypesList.Add(refcontacttypes);
        }

        public void Delete(RefContactTypes refcontacttypes)
        {
            refcontacttypesList.Remove(refcontacttypes);    
        }

        public void Update(RefContactTypes refcontacttypes)
        {
            var selectedrefcontacttypes = refcontacttypesList.Where(a => a.ContactCode == refcontacttypes.ContactCode).FirstOrDefault();
            selectedrefcontacttypes = refcontacttypes;
        }

        public RefContactTypes? FindById(int ContactCode)
        {
            return refcontacttypesList.Where(a => a.ContactCode == ContactCode).FirstOrDefault();
        }
    }

    
}
