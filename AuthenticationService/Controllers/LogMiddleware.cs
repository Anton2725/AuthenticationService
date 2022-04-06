using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationService.Controllers
{
    public class LogMiddleware
    {
        private readonly ILogger _logger;
        private readonly RequestDelegate _next;

        public LogMiddleware(RequestDelegate next, ILogger logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            _logger.WriteEvent("Я твой Middleware");
            //_logger.WriteEvent($"IP: {httpContext.Connection.RemoteIpAddress} : {httpContext.Connection.LocalPort}");
            //_logger.WriteEvent($"IP: {httpContext.Request.Host.Host}");
            
            await _next(httpContext);
        }
    }
}
