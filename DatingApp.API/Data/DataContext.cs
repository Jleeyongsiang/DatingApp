

using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    //Include a framework to add the table into the database 
    //Meta package removed EntityFrameworkCore hence the intellisense is not able to detect the missing namespace (Shared framework assembly are moved in Core 3.0)
    //Need to install using nuget
    //We would like to make DataContext available as a service 
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {}
        
        //tell the dbcontext class about the entity 
        public DbSet<Value> Values { get; set; }
    }
}