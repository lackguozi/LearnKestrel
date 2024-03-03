using LearnKestrel.Application;
using LearnKestrel.Redis.Context;

namespace LearnKestrel.Redis.Middlewares
{
    /// <summary>
    /// 授权中间件
    /// </summary>
    public class AuthMiddleware : IRedisMiddleware
    {
        private readonly ILogger<AuthMiddleware> _logger;

        public AuthMiddleware(ILogger<AuthMiddleware> logger)
        {
            _logger = logger;
        }

        public Task InvokeAsync(ApplicationDelegate<RedisContext> next, RedisContext context)
        {
            //如果没有认证直接返回错误
            //如果认证了 下一个中间件

            // 如果本次要授权,如果授权码为空。则已授权下一个中间件，否则返回需要授权对的错误
        }
    }
}
