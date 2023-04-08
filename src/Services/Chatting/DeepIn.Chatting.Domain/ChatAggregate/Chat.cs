using DeepIn.Domain;

namespace DeepIn.Chatting.Domain.ChatAggregate;

public class Chat : Entity, IAggregateRoot
{
    public static string TableName => "chat";
    public ChatType ChatType { get; private set; }
    public string Name { get; set; }
    public string AvatarId { get; set; }
    public string Link { get; set; }
    public string Description { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    public bool IsPrivate { get; set; }
    public bool IsVerified { get; set; }
    public bool IsDeleted { get; set; }
    public Chat(ChatType chatType)
    {
        ChatType = chatType;
    }
}
