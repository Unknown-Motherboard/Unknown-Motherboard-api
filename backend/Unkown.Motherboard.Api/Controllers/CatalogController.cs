using Microsoft.AspNetCore.Mvc;
using Unkown.Motherboard.Domain.Catalog;

namespace Unkown.Motherboard.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CatalogController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetItems()
        {
            return Ok("Hello World");
        }
    }
    
}
