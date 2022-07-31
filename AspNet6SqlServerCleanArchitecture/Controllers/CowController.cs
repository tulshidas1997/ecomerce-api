using Core.Dtos;
using Core.Interfaces.Services;
using Core.Models;
using Core.Types;
using Microsoft.AspNetCore.Mvc;

namespace AspNet6SqlServerCleanArchitecture.Controllers;

[ApiController]
[Route("[controller]")]
public class CowController:ApiController
{
    private readonly ICowService _cow;

    public CowController(ICowService cow)
    {
        _cow = cow;
    }

    [HttpGet("all")]
    public async Task<ActionResult<ApiResult<List<CowDto>>>> GetAll()
    {
        var cows = await _cow.GetAll();
        return OkResult(cows);
    }
}