using DeepIn.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepIn.Chatting.Domain.ChatAggregate
{
    public interface IChatRepository : IRepository<Chat>
    {
        Chat Add(Chat chat);
    }
}
