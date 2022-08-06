using ChatAPI.Controllers;
using ChatAPI.Core.Business_Interface;
using ChatAPI.Core.Business_Interface.ServiceQuery;
using DomainChat.Entities;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using Xunit;

namespace ChatAPI.Test
{
    public class MessageControllerTests
    {
        public Mock<IMessageServiceQuery> messageServiceQuery;
        public Mock<IMessageService> messageService;

        private MessageController sut;
        public MessageControllerTests()
        {
            this.messageServiceQuery = new Mock<IMessageServiceQuery>();
            this.messageService = new Mock<IMessageService>();
            sut = new MessageController(this.messageServiceQuery.Object, this.messageService.Object);
        }

        [Fact]
        public void GetAll_should_return_data_saved_in_database()
        {
            var messages = new List<Message>
            {
                new Message{Id=Guid.NewGuid().ToString(),Content="Hi Bapak/Ibuk Rakamin Academy", Sender="Anggit", Receiver="RakaminAcademy"},
                new Message{Id=Guid.NewGuid().ToString(),Content="Hi Mas Anggit", Sender="RakaminAcademy", Receiver="Anggit"},
            };
            this.messageServiceQuery.Setup(x => x.GetAll()).Returns(messages);
            var result = sut.GetAll() as OkObjectResult;
            result.StatusCode.Should().Be(200);
        }
    }
}
