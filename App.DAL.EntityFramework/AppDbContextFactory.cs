using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace App.DAL.EntityFramework;

public class AppDbContextFactory: IDesignTimeDbContextFactory<AppDbContext>
{
    public AppDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
        
        //TODO: Add Your Postgres Database Connection String (Host=YOUR_HOST;Port=YOUR_PORT;UsernameYOUR_USERNAME;Password=YOUR_PASSWORD;database=YOUR_DATABASE)
        optionsBuilder.UseNpgsql("");

        return new AppDbContext(optionsBuilder.Options);
    }
}
