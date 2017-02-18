using System.Data.Entity;
using Core.Model;
using MySql.Data.Entity;

namespace Core
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class DataBaseContext : DbContext
    {
        public  DataBaseContext() : base(nameOrConnectionString: "DBContext")
        {
            
        }
        
        public DbSet<CookBook> CookBooks { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<User> Users { get; set; }
    }
}