using Microsoft.EntityFrameworkCore;
using DatingApp.API.Models;

namespace DatingApp.API.Data
{
    public class DataContext : DbContext // : means inheriting from this class so we can use methods in class
    {
        public DataContext(DbContextOptions<DataContext> options): base (options)
        {
            
        }

        public DbSet<Value> Values {get; set;} //  Telling Entity the property #endregion
        //Values will be the name of the table that we will 
    }
}