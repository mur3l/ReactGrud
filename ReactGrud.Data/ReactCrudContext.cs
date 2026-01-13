using Microsoft.EntityFrameworkCore;
using ReactCrud.Core.Domain;

namespace ReactGrud.Data
{
    public class ReactCrudContext : DbContext
    {
        public ReactCrudContext(DbContextOptions<ReactCrudContext> options) : base(options)
        {
            
        }

        public DbSet<School> Schools { get; set; }

    }
}
