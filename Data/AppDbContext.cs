using DarpinosPizzaria.Models;
using Microsoft.EntityFrameworkCore;

namespace DarpinosPizzaria.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
             
        }

        public DbSet<PizzaModel> Pizzas { get; set; }
    }
}