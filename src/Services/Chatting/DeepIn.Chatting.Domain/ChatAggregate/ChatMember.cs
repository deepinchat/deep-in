namespace DeepIn.Chatting.Domain.ChatAggregate
{
    public class ChatMember
    {
        public static string TableName => "chat_member";
        public long ChatId { get; set; }
        public string UserId { get; set; }
        public string Alias { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsOwner { get; set; }
        public bool IsBot { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}
