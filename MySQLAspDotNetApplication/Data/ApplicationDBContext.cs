using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;
using MySql.EntityFrameworkCore.Extensions;
using MySQLAspDotNetApplication.Model;

namespace MySQLAspDotNetApplication.Data
{
    public class ApplicationDBContext:DbContext
    {
    public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) :base(options) 
        {
        
        }
        public DbSet<Product> Product { get; set; }
    }
    public class MysqlEntityFrameworkDesignTimeServices : IDesignTimeServices
    {
        public void ConfigureDesignTimeServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddEntityFrameworkMySQL();
            new EntityFrameworkRelationalServicesBuilder(serviceCollection).TryAddCoreServices();

        }
    }
}
