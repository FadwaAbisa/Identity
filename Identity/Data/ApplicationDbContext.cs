using Identity.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Identity.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<Curriculums> Curriculums { get; set; }
        public DbSet<Specialties> Specialties { get; set; }
        public DbSet<PDF> PDFs { get; set; }
        public DbSet<ContactUS> ContactUs { get; set; }
    }
}
