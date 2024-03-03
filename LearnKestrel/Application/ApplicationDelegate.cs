namespace LearnKestrel.Application
{
    /// <summary>
    /// 处理应用请求的委托
    /// </summary>
    /// <typeparam name="TContext"></typeparam>
    /// <param name="context"></param>
    /// <returns></returns>
   public delegate Task ApplicationDelegate<TContext>(TContext context);
}
