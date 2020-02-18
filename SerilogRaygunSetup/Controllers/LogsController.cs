using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SerilogRaygunSetup.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LogsController : ControllerBase
    {
        private readonly ILogger<LogsController> _logger;

        public LogsController(ILogger<LogsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public void Get()
        {
            _logger.LogError(new Exception("Test Exception Message"), "Test Log Message {Name}", "Will Joe");
            throw new Exception("Test Unhandled Exception Message");
        }
    }
}
