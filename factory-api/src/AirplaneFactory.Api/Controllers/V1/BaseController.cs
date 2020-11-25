using AirplaneFactory.Common;
using Microsoft.AspNetCore.Mvc;

namespace AirplaneFactory.Api.Controllers.V1
{
    public abstract class BaseController : ControllerBase
    {
        protected IActionResult ProcessResponseResult<TModel>(ResponseResult<TModel> result)
        {
            if (result.ValidationResult.IsValid)
            {
                return Ok(new { success = true, result.Data });

            }
            else
            {
                return Ok(new { success = false, result.ValidationResult.Errors });
            }
        }
    }
}
