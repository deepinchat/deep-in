namespace DeepIn.EventBus;

public abstract record IntegrationEvent
{
    public IntegrationEvent()
    {
        Id = Guid.NewGuid();
        CreatedAt = DateTime.Now;
    }
    public IntegrationEvent(Guid id, DateTime createdAt)
    {
        Id = id;
        CreatedAt = createdAt;
    }
    public Guid Id { get; private set; }
    public DateTime CreatedAt { get; private set; }
}
