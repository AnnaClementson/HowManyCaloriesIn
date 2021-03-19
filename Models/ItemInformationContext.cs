using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HowManyCaloriesIn.Models
{
    public class ItemInformationContext : DbContext
    {
        public DbSet<Item> Items { get; set; }
        public DbSet<Nutrients> Nutrients { get; set; }
    }   
}   



