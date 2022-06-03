using LibraryApi.Data;
using Microsoft.AspNetCore.Mvc;

namespace LIbraryApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly ILogger<HomeController> _logger;
        private readonly LibraryDbContext context;

        public HomeController(ILogger<HomeController> logger, LibraryDbContext context)
        {
            _logger = logger;
            this.context = context;
        }

        [HttpGet(Name = "Sample")]
        public IActionResult Get()
        {
            int count = context.Books.Count();
            return Ok("count = " + count);
        }
    }
}