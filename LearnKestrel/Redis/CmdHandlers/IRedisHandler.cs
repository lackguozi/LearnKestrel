using LearnKestrel.Redis.Context;

namespace LearnKestrel.Redis.CmdHandlers
{
    public interface IRedisHandler
    {
        public RedisCmd Cmd { get; }

        Task HandlerAsync (RedisContext context);
    }
}
