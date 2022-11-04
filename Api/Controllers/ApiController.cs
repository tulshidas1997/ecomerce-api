using CleanArchitecture.Core.Types;
using CleanArchitecture.Core.Utilities;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Api.Controllers;

public class ApiController : ControllerBase
{
    protected ActionResult<ApiResult<T>> OkResult<T>(T data)
    {
        var result = new ApiResult<T>(data);
        return Ok(result);
    }

    protected ActionResult<ApiResult<object>> Error(object error,string message)
    {
        var result = new Utility().GetErrorResponse(error,message);
        return BadRequest(result);
    }
}
