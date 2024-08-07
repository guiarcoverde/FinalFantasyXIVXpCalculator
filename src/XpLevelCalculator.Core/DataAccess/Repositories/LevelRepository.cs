using Microsoft.EntityFrameworkCore;
using XpLevelCalculator.Core.Interfaces;
using XpLevelCalculator.Core.Models.Requests;
using XpLevelCalculator.Core.Models.Responses;

namespace XpLevelCalculator.Core.DataAccess.Repositories;

public class LevelRepository(XpCalculatorDbContext dbContext) : ILevelReadOnlyRepository
{
    private readonly XpCalculatorDbContext _dbContext = dbContext;
    public async Task<ResponseLevelUpJson> GetActivityAmount(RequestLevelUpJson request)
    {
        var sumNecessaryXp = await _dbContext.Levels
            .Where(l => l.Level > request.Level && l.Level <= request.LevelToAchieve)
            .SumAsync(l => l.LevelXp);

        var xpPossess = request.XpPossessed;

        var necessaryXp = sumNecessaryXp - xpPossess;

        var activityAmount = Math.Ceiling((double)necessaryXp / request.XpGivenByActivity);

        return new ResponseLevelUpJson
        {
            ActivityAmount = (int)activityAmount
        };
            
    }
}
