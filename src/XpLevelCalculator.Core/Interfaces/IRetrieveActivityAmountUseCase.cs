using XpLevelCalculator.Core.Models.Requests;
using XpLevelCalculator.Core.Models.Responses;

namespace XpLevelCalculator.Core.Interfaces;
public interface IRetrieveActivityAmountUseCase
{
    Task<ResponseLevelUpJson> Execute(RequestLevelUpJson request);
}
