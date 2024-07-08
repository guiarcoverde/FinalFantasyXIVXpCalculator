using XpLevelCalculator.Core.Interfaces;
using XpLevelCalculator.Core.Models.Requests;
using XpLevelCalculator.Core.Models.Responses;

namespace XpLevelCalculator.Core.UseCases;

public class RetrieveActivityAmountUseCase(ILevelReadOnlyRepository repository) : IRetrieveActivityAmountUseCase
{
    private readonly ILevelReadOnlyRepository _repository = repository;

    public async Task<ResponseLevelUpJson> Execute(RequestLevelUpJson request)
    {
        var result = await _repository.GetActivityAmount(request);

        return new ResponseLevelUpJson
        {
            ActivityAmount = result.ActivityAmount
        };
    }
}
