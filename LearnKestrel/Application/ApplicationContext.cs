using Microsoft.AspNetCore.Http.Features;
using System.Security.Claims;
using System.Security.Principal;

namespace LearnKestrel.Application
{
    public abstract class ApplicationContext
    {
       
        /// <summary>
        /// 获取特征集合
        /// </summary>
        public IFeatureCollection Features { get; }

        /// <summary>
        /// 应用程序请求上下文
        /// </summary>
        /// <param name="features"></param>
        public ApplicationContext(IFeatureCollection features)
        {
            this.Features = new FeatureCollection(features);
        }

    }

}
