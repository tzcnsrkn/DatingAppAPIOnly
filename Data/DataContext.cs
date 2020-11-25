using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext>  options) : base (options) {}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            // => optionsBuilder.UseNpgsql("Host=localhost;Database=DatingApp;Username=postgres;Password=321lely");
            => optionsBuilder.UseNpgsql(
                @"Host=ec2-52-206-44-27.compute-1.amazonaws.com;Database=dc65dm8pteg7v2;Username=ximhpeyexhvcda;Password=6fb4c86d18c96fff31e0a347321544191849f80c11724e6a4993e2e9083a986e"
                );        
        public DbSet<Value> Values { get; set; }
        public DbSet<User> Users { get; set; }      
        public DbSet<Photo> Photos { get; set; }  
    }
}