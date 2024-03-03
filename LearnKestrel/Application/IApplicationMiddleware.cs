using System.Threading.Tasks;
namespace LearnKestrel.Application
{
    public interface IApplicationMiddleware<TContext>
    {
        Task InvokeAsync(ApplicationDelegate<TContext> next , TContext context);
    }
}
