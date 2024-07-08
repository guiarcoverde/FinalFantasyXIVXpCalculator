using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using XpLevelCalculator.Core.Interfaces;
using XpLevelCalculator.Core.Models.Requests;
using XpLevelCalculator.Core.Models.Responses;

namespace XpLevelCalculator.Api.Controllers;
[Route("[controller]")]
[ApiController]
public class LevelController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseLevelUpJson), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAllLevelInfos([FromBody]RequestLevelUpJson request, [FromServices]IRetrieveActivityAmountUseCase useCase)
    {
        var response = await useCase.Execute(request);

        return Ok(response);
    }
}
