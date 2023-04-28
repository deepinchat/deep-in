using DeepIn.Chatting.Domain.ChatAggregate;
using DeepIn.Chatting.Domain.Entities;
using DeepIn.Chatting.Infrastructure.EntityTypeConfigurations;
using DeepIn.EntityFrameworkCore;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace DeepIn.Chatting.Infrastructure
{
    public class ChattingContext : DbContextBase<ChattingContext>
    {
        public ChattingContext(DbContextOptions<ChattingContext> options, IMediator mediator) : base(options, mediator) { }

        public const string DEFAULT_SCHEMA = "chatting";
        public DbSet<Chat> Chats { get; set; }
        public DbSet<ChatMember> ChatMembers { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ChatEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ChatMemberEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ContactEntityTypeConfiguration());
        }
    }
}
