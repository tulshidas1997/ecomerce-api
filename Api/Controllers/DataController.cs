using CleanArchitecture.Core.Interfaces.Services;
using CleanArchitecture.Core.Types;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class DataController:ApiController
{
    private readonly IDataService _data;

    public DataController(IDataService data)
    {
        _data = data;
    }

    [HttpGet("Seed")]
    public async Task<ActionResult<ApiResult<bool>>> SeedData()
    {
        var isSucces = await _data.SeedData();
        return OkResult(isSucces);
    }
}

