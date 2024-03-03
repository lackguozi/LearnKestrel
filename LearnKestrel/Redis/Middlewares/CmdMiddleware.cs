using LearnKestrel.Application;
using LearnKestrel.Redis.Context;

namespace LearnKestrel.Redis.Middlewares
{
    public class CmdMiddleware : IRedisMiddleware
    {
        private readonly ILogger<CmdMiddleware> _logger;
        private readonly IEnumerable<I>
        public CmdMiddleware(ILogger<CmdMiddleware>logger)
        {
            _logger = logger;
        }

        public Task InvokeAsync(ApplicationDelegate<RedisContext> next, RedisContext context)
        {
            
        }
    }
}
