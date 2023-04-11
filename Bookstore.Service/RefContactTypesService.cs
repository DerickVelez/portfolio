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
    public class RefContactTypesService
    {
        private List<RefContactTypes> refcontacttypesList = new List<RefContactTypes>
        {
            //new RefContactTypes
            //{
            //    ContactCode = 56,
            //    ContactDescription = "No Description",

            //}
        };
        public string connectionString;

        public RefContactTypesService(String connectionString)
        {
            this.connectionString = connectionString;   
        }
        public bool IsAlreadyRegistered(int contactCode)
        {
            var refcontact = refcontacttypesList.Where(a => a.ContactCode == contactCode).FirstOrDefault();
            return refcontact != null;


        }
        public List<RefContactTypes> GetRefContactTypes()
        {
            using var con = new SqlConnection(connectionString);
            con.Open();

            var refContactTypes = con.Query<RefContactTypes>("SELECT * FROM RefContactTypes");

            return refContactTypes.ToList();
        }

        public RefContactTypes Add(RefContactTypes refcontacttype)
        {
            using var con = new SqlConnection(connectionString);
            con.Open();

            var createdAuthor = con.QuerySingle<RefContactTypes>("INSERT INTO RefContactTypes (ContactDescription) OUTPUT INSERTED.ContactCode VALUES (@ContactDescription);", refcontacttype);
            return createdAuthor;

        }

        public RefContactTypes Delete(RefContactTypes refcontacttype)
        {
            using var con = new SqlConnection(connectionString);
            con.Open();

            var createdAuthor = con.Execute("DELETE FROM RefContactTypes WHERE (ContactCode = @ContactCode)", refcontacttype);
            return refcontacttype;
        }

        public RefContactTypes Update(RefContactTypes refcontacttype)
        {
            using var con = new SqlConnection(connectionString);
            con.Open();

            var createdAuthor = con.Execute("UPDATE RefContactTypes SET ContactDescription= @ContactDescription WHERE (ContactCode = @ContactCode)", refcontacttype);
            return refcontacttype;

        }

        public RefContactTypes? FindById(int ContactCode)
        {
            return refcontacttypesList.Where(a => a.ContactCode == ContactCode).FirstOrDefault();
        }
    }

    
}
