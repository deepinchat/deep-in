﻿using DeepIn.Domain;

namespace DeepIn.Chatting.Domain.ChatAggregate;

public class Chat : Entity, IAggregateRoot
{
    public static string TableName => "chat";
    private ICollection<ChatMember> _chatMembers;
    public ChatType Type { get; private set; }
    public string Name { get; set; }
    public string AvatarId { get; set; }
    public string Link { get; set; }
    public string Description { get; set; }
    public string CreatedBy { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    public bool IsPrivate { get; set; }
    public bool IsVerified { get; set; }
    public bool IsDeleted { get; set; }
    public Chat() { }
    public Chat(ChatType chatType, string userId)
    {
        Type = chatType;
        this.CreatedBy = userId;
        this.AddMember(userId, true, true);
    }
    public void AddMember(string userId, bool isOwner = false, bool isAdmin = false, bool isBot = false)
    {
        this.ChatMembers.Add(new ChatMember
        {
            UserId = userId,
            Alias = null,
            CreatedAt = DateTime.UtcNow,
            IsAdmin = isAdmin,
            IsBot = isBot,
            IsOwner = isOwner,
        });

    }
    public ICollection<ChatMember> ChatMembers
    {
        get => _chatMembers ??= new List<ChatMember>();
        private set => _chatMembers = value;
    }
}
