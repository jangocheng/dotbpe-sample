using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using DotBPE.Protocol.Amp;
using DotBPE.Rpc;
using DotBPE.Rpc.Hosting;
using Microsoft.Extensions.Logging;
using MessagePack;
using MathCommon;
using Microsoft.Extensions.DependencyInjection;
using DotBPE.Hosting;

namespace MathServer
{
    class Program
    {
        static void Main(string[] args)
        {

            string ip = "127.0.0.1";
            int port = 6201;

            var builder = new HostBuilder()
               .UseServer(ip, port)
               .ConfigureServices(services =>
               {
                    //添加协议支持
                    services.AddDotBPE();

                    //注册服务
                    services.AddServiceActors<AmpMessage>((actors) =>
                   {
                       actors.Add<MathService>();
                   });

                    //添加挂载的宿主服务
                    services.AddScoped<IHostedService, RpcHostedService>();
               });



            builder.RunConsoleAsync().Wait();

        }
    }

    public class MathService : ServiceActor
    {

        /// <summary>
        /// 服务的标识,这里的服务号是10001
        /// </summary>
        protected override int ServiceId => 10002;

        /// <summary>
        /// 处理消息请求
        /// </summary>
        /// <param name="req">请求的消息</param>
        /// <returns>返回消息</returns>
        public override Task<AmpMessage> ProcessAsync(AmpMessage req)
        {
            Logger.LogDebug("receive message:ServiceId={0},MessageId = {1},Sequence={2}",req.ServiceId,req.MessageId,req.Sequence) ;
            switch(req.MessageId){
                case 1: //  1 = Add
                    return  AddAsync(req);
                default:
                    return base.ProcessNotFoundAsync(req);
            }
        }

        public Task<AmpMessage> AddAsync(AmpMessage reqMsg){

            var rsp = AmpMessage.CreateResponseMessage(reqMsg.ServiceId, reqMsg.MessageId);

            AddReq req =  MessagePackSerializer.Deserialize<AddReq>(reqMsg.Data);

            if(req !=null){
                var res = new AddRes();
                res.C  = req.A + req.B ;

                rsp.Data = MessagePackSerializer.Serialize(res);

                Logger.LogDebug("{0}${1}${2}  ,code=0  ,req={3}  ,res={4}",reqMsg.ServiceId,reqMsg.MessageId,reqMsg.Sequence, MessagePackSerializer.ToJson(req), MessagePackSerializer.ToJson(res));
            }
            else{
                rsp.Code = ErrorCodes.CODE_INTERNAL_ERROR;
                Logger.LogError("{0}${1}${2}  ,code={3}  ,req={4}  ,res=null",reqMsg.ServiceId,reqMsg.MessageId,reqMsg.Sequence,rsp.Code, MessagePackSerializer.ToJson(req));
            }
            return Task.FromResult(rsp);
        }
    }

}
