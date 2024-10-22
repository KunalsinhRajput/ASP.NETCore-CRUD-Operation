using Microsoft.EntityFrameworkCore;
using System.Data;

namespace CRUDCoreOperations.Models
{
    public class EmpContext:DbContext
    {
        public EmpContext(DbContextOptions<EmpContext> options) : base(options) 
        {
        }
        public DbSet<Emp> Emps { get; set; }

    }
}
