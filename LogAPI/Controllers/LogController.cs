using LogAPI.Entities;
using LogAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
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
        public async Task<IActionResult> GetLog() // Just For Test, Retrun Empty Log
        {
            var result = new LogEntry();
            return new JsonResult(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateLog(IEnumerable<LogEntry> logEntries)
        {
            await _logService.LogToDatabase(logEntries);
            await _logService.LogToFile(logEntries);
            //await _logService.LogToFlatFile(logEntries);
            //await _logService.LogToKafka(logEntries);
            //await _logService.LogToMQ(logEntries);
            return Accepted();                     
        }
    }
}
