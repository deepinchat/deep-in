using DeepIn.Chatting.Domain.ChatAggregate;
using DeepIn.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepIn.Chatting.Infrastructure.Repositories
{
    public class ChatRepository : IChatRepository
    {
        private readonly ChattingContext _context;
        public ChatRepository(ChattingContext context)
        {
            _context = context;
        }
        public IUnitOfWork UnitOfWork => _context;

        public Chat Add(Chat chat)
        {
            return _context.Chats.Add(chat).Entity;
        }
    }
}
