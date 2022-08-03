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

    protected ActionResult<ApiResult<object>> Error(object error)
    {
        var result = new ApiResult<object>(){Error = error,IsSuccess = false};
        return BadRequest(result);
    }
}
