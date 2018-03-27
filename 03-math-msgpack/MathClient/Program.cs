using DotBPE.Protocol.Amp;
using DotBPE.Rpc.Client;
using DotBPE.Rpc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Text;
using MathCommon;
using MessagePack;

namespace MathClient
{
    class Program
    {
        static void Main(string[] args)
        {

            new ClientProxyBuilder().UseServer("127.0.0.1:6201").BuildDefault();

            using (var caller = DotBPE.Rpc.Environment.ServiceProvider.GetService<ICallInvoker<AmpMessage>>())
            {
                Console.WriteLine("ready to send message");
                ushort serviceId = 10002; // 10001 = MathService ,1 = ADd
                AmpMessage reqMsg = AmpMessage.CreateRequestMessage(serviceId, 1);

                var random =new Random();
                AddReq req= new AddReq();
                req.A = random.Next(1,10000) ;
                req.B = random.Next(1,10000) ;

                reqMsg.Data = MessagePackSerializer.Serialize(req) ;

                Console.WriteLine("call sever MathService.Add  --> {0}+{1} ",req.A,req.B);

                try
                {
                    var res = caller.BlockingCall(reqMsg);

                    if (res.Code == 0)
                    {
                        var addRes = MessagePackSerializer.Deserialize<AddRes>(res.Data);

                        Console.WriteLine("server repsonse:<-----{0}+{1}={2}", req.A,req.B , addRes.C);
                    }
                    else
                    {
                        Console.WriteLine("server error,code={0}", res.Code);
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine("error occ {0}", ex.Message);
                }

            }
            Console.WriteLine("channel is closed!");

        }
    }
}
