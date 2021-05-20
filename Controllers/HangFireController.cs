using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HangFirePOC.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HangFireController : ControllerBase
    {

        private readonly ILogger<HangFireController> _logger;

        public HangFireController(ILogger<HangFireController> logger)
        {
            _logger = logger;
        }
    }
}
