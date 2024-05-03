
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Practice.Models;

namespace Practice.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Practice.Models.Person> Person { get; set; } = default!;
        public DbSet<Practice.Models.Category> Category { get; set; } = default!;
        public DbSet<Practice.Models.Transaction> Transaction { get; set; } = default!;
        

    }
}
