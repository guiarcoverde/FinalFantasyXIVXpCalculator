using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using XpLevelCalculator.Core.DataAccess;

namespace XpLevelCalculator.Core.Migrations;

public class DatabaseMigration
{
    public static async Task MigrateDatabase(IServiceProvider serviceProvider)
    {
        var dbContext = serviceProvider.GetRequiredService<XpCalculatorDbContext>();

        await dbContext.Database.MigrateAsync();
    }
}
