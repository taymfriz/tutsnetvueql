using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GoodBooks.Web.Controllers
{
    [ApiController]
    // [Route("/api")]
    public class GoodBooksController : ControllerBase
    {

        private readonly ILogger<GoodBooksController> _logger;

        public GoodBooksController(ILogger<GoodBooksController> logger)
        {
            _logger = logger;
        }

        [HttpGet("/")]
        public StatusCodeResult GetSample()
        {

            // public static IEnumerable<int> sample = new List<int>{2,2,2,2};

            return new StatusCodeResult(400);
        }
    }
}
