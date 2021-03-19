using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using HowManyCaloriesIn.Models;

namespace HowManyCaloriesIn.Data
{
    public class ItemInformationContext : IdentityDbContext
    {
        public ItemInformationContext(DbContextOptions<ItemInformationContext> options)
            : base(options)
        {
        }
        public DbSet<HowManyCaloriesIn.Models.Item> Item { get; set; }
        
    }
}
