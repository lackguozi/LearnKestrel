using Microsoft.AspNetCore.Connections;

namespace LearnKestrel.Redis.ConnectionHandlers
{
    public sealed class RedisConnectionHandler : ConnectionHandler
    {
        private readonly ILogger<RedisConnectionHandler> _logger;

        public RedisConnectionHandler(ILogger<RedisConnectionHandler> logger)
        {
            _logger = logger;
        }

        public override async Task OnConnectedAsync(ConnectionContext connection)
        {
            try
            {
                await HanderRequestAsync(connection);
            }
            catch (Exception ex)
            {
                _logger.LogDebug(ex.Message);
            }
            finally
            {
                await connection.DisposeAsync();
            }
        }

        /// <summary>
        /// handle request
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        private async Task HanderRequestAsync(ConnectionContext context)
        {
           
            var input = context.Transport.Input;
            
            while(context.ConnectionClosed.IsCancellationRequested ==false)
            {
                var result = await input.ReadAsync();
                if(result.IsCanceled)
                {
                    break;
                }

            }
        }
    }
}
