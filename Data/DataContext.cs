using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext>  options) : base (options) {}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=localhost;Database=DatingApp;Username=postgres;Password=321lely");
        public DbSet<Value> Values { get; set; }
        public DbSet<User> Users { get; set; }      
        public DbSet<Photo> Photos { get; set; }  
    }
}