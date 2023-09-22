using Microsoft.EntityFrameworkCore;
using ProjectStructure;

namespace PostgreDB
{
    public class PgContext : DbContext
    {
        private readonly string connectionString;
        public DbSet<Project> Projects { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<City> Cities { get; set; }
        public PgContext(string connectionString)
        {
            
            if(string.IsNullOrEmpty(connectionString))
                throw new ArgumentNullException("Value should not be empty.");
            this.connectionString = connectionString;

            UpdDB();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(connectionString);
        }

        private void UpdDB()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();

            Cities.AddRange(CitiesParser.Parse());
            //Dictionary<string, ICollection> materialDictionary = MaterialParser.Parse();
            //Materials.AddRange((List<Material>)materialDictionary["Material"]);
            //MaterialContractors.AddRange((List<MaterialContractor>)materialDictionary["Contractor"]);
            //MaterialTypes.AddRange((List<MaterialType>)materialDictionary["Type"]);

            SaveChanges();
        }
    }
}