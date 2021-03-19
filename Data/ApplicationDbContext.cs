using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using HowManyCaloriesIn.Models;

namespace HowManyCaloriesIn.Data
{
	public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Item> Item { get; set; }
        public DbSet<Nutrients> Nutrients { get; set; }
    }
}
