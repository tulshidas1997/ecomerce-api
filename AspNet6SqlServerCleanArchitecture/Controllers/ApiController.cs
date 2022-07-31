using Core.Types;
using Microsoft.AspNetCore.Mvc;

namespace AspNet6SqlServerCleanArchitecture.Controllers;

public class ApiController:ControllerBase
{
    protected ActionResult<ApiResult<T>> OkResult<T>(T data)
    {
        var result = new ApiResult<T>(data);
        return Ok(result);
    }
}
