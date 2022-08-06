using Autofac;
using ChatAPI.Business;
using ChatAPI.Business.ServiceQuery;
using ChatAPI.Core.Business_Interface;
using ChatAPI.Core.Business_Interface.ServiceQuery;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace ChatAPI.DependencyResolver
{
    public static class BusinessAutofacModule
    {
        public static ContainerBuilder CreateAutofacBusinessContainer(this IServiceCollection services, ContainerBuilder builder)
        {
            builder.RegisterType<IMessageService>().As<MessageService>();
            builder.RegisterType<IMessageServiceQuery>().As<MessageServiceQuery>();
            return builder;
        }
    }

    public class BusinessAutofacModule1 : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<MessageService>().As<IMessageService>();
            builder.RegisterType<MessageServiceQuery>().As<IMessageServiceQuery>();
        }
    }
}
