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

        public bool IsAlreadyRegistered(int contactCode)
        {
            var refcontact = refcontacttypesList.Where(a => a.ContactCode == contactCode).FirstOrDefault();
            return refcontact != null;


        }
        public List<RefContactTypes> GetRefContactTypes()
        {
            return refcontacttypesList;
        }

        public void Add(RefContactTypes refcontacttype)
        {
            refcontacttypesList.Add(refcontacttype);
        }

        public void Delete(RefContactTypes refcontacttype)
        {
            refcontacttypesList.Remove(refcontacttype);    
        }

        public void Update(RefContactTypes refcontacttype)
        {
            var selectedrefcontacttypes = refcontacttypesList.Where(
                a => a.ContactCode == refcontacttype.ContactCode).FirstOrDefault();
            refcontacttypesList.Remove(selectedrefcontacttypes);
            refcontacttypesList.Add(refcontacttype);
        }

        public RefContactTypes? FindById(int ContactCode)
        {
            return refcontacttypesList.Where(a => a.ContactCode == ContactCode).FirstOrDefault();
        }
    }

    
}
