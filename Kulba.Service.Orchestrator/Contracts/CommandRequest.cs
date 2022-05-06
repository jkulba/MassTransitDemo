namespace Kulba.Service.Orchestrator.Contracts
{
    public record CommandRequest
    {
        public string Name { get; init; }
    }
}