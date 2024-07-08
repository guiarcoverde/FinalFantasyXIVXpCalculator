using XpLevelCalculator.Core.Models.Requests;
using XpLevelCalculator.Core.Models.Responses;

namespace XpLevelCalculator.Core.Interfaces;
public interface ILevelReadOnlyRepository
{
    Task<ResponseLevelUpJson> GetActivityAmount(RequestLevelUpJson request);
}
