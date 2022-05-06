namespace Kulba.Service.Orchestrator.Consumers
{
    using MassTransit;

    public class CommandRequestConsumerDefinition :
        ConsumerDefinition<CommandRequestConsumer>
    {
        protected override void ConfigureConsumer(IReceiveEndpointConfigurator endpointConfigurator, IConsumerConfigurator<CommandRequestConsumer> consumerConfigurator)
        {
            endpointConfigurator.UseMessageRetry(r => r.Intervals(500, 1000));
        }
    }
}