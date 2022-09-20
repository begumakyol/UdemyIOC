using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UdemyIOC.Web.Models
{
    public class DateService : ISingletonDateService, IScopedDateService, ITransientDateService
    {
        private readonly ILogger<DateService> _logger;

        public DateService(ILogger<DateService> logger)
        {
            _logger = logger;

            _logger.LogWarning("DataService constructor'ına girdi.");
        }

        public DateTime GetDateTime { get; } = DateTime.Now;
    }
}
