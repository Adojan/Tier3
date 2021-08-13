using Microsoft.EntityFrameworkCore;
using TierThree.Model;

namespace TierThree.DataAccess
{
    public class PokemonContext : DbContext
    {
        public DbSet<UserModel> Users { get; set; }
        public DbSet<AdministratorModel> Administrators { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = C:\Users\Alexa\Desktop\CodSEP3\TierThree");
        }

       
    }
}