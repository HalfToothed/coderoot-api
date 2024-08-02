using coderoot.Entities;
using Microsoft.EntityFrameworkCore;

namespace coderoot.DataLayer
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public virtual DbSet<Problem> Problem { get; set; }
        public virtual DbSet<Topic> Topic { get; set; }

    }
}
