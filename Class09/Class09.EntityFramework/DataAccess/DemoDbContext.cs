using Microsoft.EntityFrameworkCore;

namespace Class09.EntityFramework.DataAccess
{
    public class DemoDbContext : DbContext
    {
        public DemoDbContext(DbContextOptions options) : base(options){}
    }
}
