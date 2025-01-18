using CleanArchitecture.Core.Interfaces.Services;
using CleanArchitecture.Core.Types;
using Core.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class CowController:ApiController
{
    private readonly ICowService _cow;

    public CowController(ICowService cow)
    {
        _cow = cow;
    }

    [Authorize]
    [HttpGet("all")]
    public async Task<ActionResult<ApiResult<List<CowDto>>>> GetAll()
    {
        var cows = await _cow.GetAll();
        return OkResult(cows);
    }

    [HttpPost]
    public async Task<ActionResult<ApiResult<CowDto>>> Create(CowDto cow)
    {
        var cows = await _cow.Create(cow);
        return OkResult(cows);
    }


}