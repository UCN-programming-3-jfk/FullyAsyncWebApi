using AsyncWebApi.DataAccess;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AsyncWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> Get()
        {
            var productsTask = ProductDataAccess.GetProductsAsync();
            await Logger.LogAsync("Call to main method");
            return Ok(await productsTask);
        }
    }
}