using DotBPE.Protocol.Amp;
using DotBPE.Rpc;
using Microsoft.Extensions.DependencyInjection;
using DotBPE.Rpc.Client;
using Microsoft.Extensions.Logging;
using System;
using System.Text;
using MathCommon;

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
                ushort serviceId = 10001; // 10001 = MathService ,1 = ADd
                AmpMessage reqMsg = AmpMessage.CreateRequestMessage(serviceId, 1);

                var random =new Random();
                AddReq req= new AddReq();
                req.A = random.Next(1,10000) ;
                req.B = random.Next(1,10000) ;
                var reqJson = Jil.JSON.Serialize(req);
                reqMsg.Data = Encoding.UTF8.GetBytes(reqJson);

                Console.WriteLine("call sever MathService.Add  --> {0}+{1} ",req.A,req.B);

                try
                {
                    var res = caller.BlockingCall(reqMsg);

                    if (res.Code == 0)
                    {
                        string jsonRes = Encoding.UTF8.GetString(res.Data);
                        var addRes = Jil.JSON.Deserialize<AddRes>(jsonRes);

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
