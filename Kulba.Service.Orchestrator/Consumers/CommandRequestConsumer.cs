namespace Kulba.Service.Orchestrator.Consumers
{
    using System.Threading.Tasks;

    using Kulba.Service.Orchestrator.Contracts;

    using MassTransit;

    using Microsoft.Extensions.Logging;

    public class CommandRequestConsumer :
        IConsumer<CommandRequest>
    {
        readonly ILogger<CommandRequestConsumer> _logger;

        public CommandRequestConsumer(ILogger<CommandRequestConsumer> logger)
        {
            _logger = logger;
        }

        public Task Consume(ConsumeContext<CommandRequest> context)
        {
            _logger.LogInformation("Hello {name}", context.Message.Name);
            return Task.CompletedTask;
        }
    }
}