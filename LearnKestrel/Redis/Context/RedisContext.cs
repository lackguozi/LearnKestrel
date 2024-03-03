using LearnKestrel.Application;
using Microsoft.AspNetCore.Http.Features;

namespace LearnKestrel.Redis.Context
{
    public class RedisContext: ApplicationContext
    {
        public RedisContext(IFeatureCollection features, RedisRequest request, RedisResponse response, RedisClient client) : base(features)
        {
            Client = client;
            Request = request;
            Response = response;
        }

        /// <summary>
        /// redis客户端
        /// </summary>
        public RedisClient Client { get; set; }

        /// <summary>
        /// redis请求
        /// </summary>
        public RedisRequest Request { get; set; }

        /// <summary>
        /// redis返回
        /// </summary>
        public RedisResponse Response { get; set; }

        public override string ToString()
        {
            return $"{this.Client} {this.Request}";
        }
    }
}
