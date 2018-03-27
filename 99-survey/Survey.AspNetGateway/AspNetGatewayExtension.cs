using DotBPE.AspNetGateway;
using DotBPE.Protobuf;
using DotBPE.Protocol.Amp;
using DotBPE.Rpc;
using DotBPE.Rpc.Client;
using DotBPE.Rpc.Codes;
using DotBPE.Rpc.Netty;
using Microsoft.Extensions.DependencyInjection;
using Survey.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Survey.AspNetGateway
{
    public static class AspNetGatewayExtension
    {
       /// <summary>
        /// 扩展路由配置信息
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public static IServiceCollection AddRoutes(this IServiceCollection services)
        {
            services.Configure<HttpRouterOption>(opt =>
            {


                if(opt.Items == null)
                {
                    opt.Items = new List<HttpRouterOptionItem>();
                }

                foreach(var item in HttpApiRouterOptions.GetList())
                {
                    opt.Items.Add(new HttpRouterOptionItem()
                    {
                        ServiceId = item.ServiceId,
                        MessageId = item.MessageId,
                        Method = item.Method,
                        Path = item.Path,
                        Description = item.Description,
                        TimeOut = item.Timeout,
                        PluginName = item.Plugin
                    });
                }
            });
            return services;
        }


    }
}
