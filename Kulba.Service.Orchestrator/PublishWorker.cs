namespace Kulba.Service.Orchestrator
{
    using System.Threading;
    using System.Threading.Tasks;

    using Kulba.Service.Orchestrator.Contracts;

    using MassTransit;

    using Microsoft.Extensions.Hosting;

    public class PublishWorker : BackgroundService
    {

        readonly IBus _bus;

        public PublishWorker(IBus bus)
        {
            _bus = bus;

        }
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {

            while (!stoppingToken.IsCancellationRequested)
            {
                await _bus.Publish(new CommandRequest
                {
                    Name = "Yo Joe"
                }, stoppingToken);

                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}