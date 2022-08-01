using CleanArchitecture.Core.Types;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Api.Controllers;

public class ApiController : ControllerBase
{
    protected ActionResult<ApiResult<T>> OkResult<T>(T data)
    {
        var result = new ApiResult<T>(data);
        return Ok(result);
    }
}
