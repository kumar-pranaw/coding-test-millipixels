using Crud.Repository.DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Crud.Repository
{
    public class DataContext: DbContext
    {
        public DataContext()
        {

        }
        public DataContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected readonly IConfiguration Configuration;
        public DbSet<Employee> Employees { get; set; }
       
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("WebApiDatabase"));
        }
    }
}
