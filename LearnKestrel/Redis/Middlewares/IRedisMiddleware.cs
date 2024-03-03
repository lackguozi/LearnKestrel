using LearnKestrel.Application;
using LearnKestrel.Redis.Context;

namespace LearnKestrel.Redis.Middlewares
{
    public interface IRedisMiddleware : IApplicationMiddleware<RedisContext>
    {
        
    }
}
