using DomainChat.Entities;
using DomainChat.Model;
using System.Threading.Tasks;

namespace ChatAPI.Core.Business_Interface
{
    public interface IMessageService
    {
        void Add(Message message);
        Task<Message> DeleteMessage(MessageDeleteModel messageDeleteModel);
    }
}
