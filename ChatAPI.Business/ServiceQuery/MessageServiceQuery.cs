using ChatAPI.Core.Business_Interface.ServiceQuery;
using ChatAPI.Core.Repository_Interfaces;
using DomainChat.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChatAPI.Business.ServiceQuery
{
    public class MessageServiceQuery : IMessageServiceQuery
    {
        private readonly IUnitOfWork unitOfWork;
        public MessageServiceQuery(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        IEnumerable<Message> IMessageServiceQuery.GetAll()
        {
            try
            {
                var messages = this.unitOfWork.Repository<Message>().Get().ToList();
                return messages;
            }
            catch (Exception)
            {

                throw;
            }

        }
        IEnumerable<Message> IMessageServiceQuery.GetReceivedMessages(string userId)
        {
            try
            {
                var messages = this.unitOfWork.Repository<Message>().Get().Where(x => x.Receiver == userId).ToList();
                return messages;
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}

