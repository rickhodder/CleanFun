using Microsoft.AspNetCore.Mvc;

namespace CleanFun.Web.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseApiController : Controller
    {
    }
}
