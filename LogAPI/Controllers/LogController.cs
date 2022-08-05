using LogAPI.Entities;
using LogAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogAPI.Controllers
{
    [ApiController]
    [Route("api/log")]
    public class LogController: ControllerBase
    {
        private readonly ILogService _logService;

        public LogController(ILogService logService)
        {
            _logService = logService ?? throw new ArgumentNullException(nameof(logService));
        }


        [HttpGet]
        public async Task<IActionResult> GetLog()
        {
            var result = new LogEntry();
            return new JsonResult(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateLog(LogEntry logEntry)
        {
            _logService.LogToDatabase(logEntry);
            await _logService.SaveAsync();
            return Ok();
        }
    }
}
