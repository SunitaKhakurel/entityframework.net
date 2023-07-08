using Microsoft.EntityFrameworkCore;

namespace Entityframeworkcore
{
    public class EntityFrameWorkcoreEntity:DbContext
    {
        public DbSet<Country> Countries { get; set; }
        public DbSet<District> Districts { get; set; }
        public EntityFrameWorkcoreEntity(DbContextOptions options) : base(options) { }
        

    }
}
