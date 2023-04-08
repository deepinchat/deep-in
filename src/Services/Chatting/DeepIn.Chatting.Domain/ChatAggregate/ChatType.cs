using DeepIn.Chatting.Domain.Exceptions;
using DeepIn.Domain;

namespace DeepIn.Chatting.Domain.ChatAggregate
{
    public class ChatType : Enumeration
    {
        public static ChatType Dialogue = new ChatType(1, nameof(Dialogue).ToLowerInvariant());
        public static ChatType Group = new ChatType(2, nameof(Group).ToLowerInvariant());
        public static ChatType Channel = new ChatType(3, nameof(Channel).ToLowerInvariant());
        public static ChatType Public = new ChatType(4, nameof(Public).ToLowerInvariant());
        public ChatType(int id, string name) : base(id, name) { }
        public static IEnumerable<ChatType> List() =>
            new[] { Dialogue, Group, Channel, Public };
        public static ChatType FromName(string name)
        {
            var state = List()
                .SingleOrDefault(s => string.Equals(s.Name, name, StringComparison.CurrentCultureIgnoreCase));

            if (state == null)
            {
                throw new ChattingDomainException($"Possible values for ChatType: {string.Join(",", List().Select(s => s.Name))}");
            }

            return state;
        }

        public static ChatType From(int id)
        {
            var state = List().SingleOrDefault(s => s.Id == id);

            if (state == null)
            {
                throw new ChattingDomainException($"Possible values for ChatType: {string.Join(",", List().Select(s => s.Name))}");
            }

            return state;
        }
    }
}
