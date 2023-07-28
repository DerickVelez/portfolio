using Microsoft.EntityFrameworkCore;
using Practice1.Models;

namespace Practice1
{
    public class Practice1Context : DbContext
    {
        public virtual DbSet<Employee> Employees { get; set; }

        public Practice1Context(DbContextOptions<Practice1Context> options)
            : base(options){}
    }
}
