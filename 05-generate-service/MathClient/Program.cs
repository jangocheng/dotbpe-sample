using DotBPE.Protocol.Amp;
using DotBPE.Rpc.Client;
using DotBPE.Rpc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Text;
using MathCommon;
using Google.Protobuf;
using System.Threading.Tasks;

namespace MathClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Task.Run(RunClient).Wait();
        }

        public async static Task RunClient()
        {
            var proxy = new ClientProxyBuilder().UseServer("127.0.0.1:6201").ConfigureServices(services=>services.AddLogging()).BuildDefault();
            using (var client = proxy.GetClient<MathCommon.MathClient>())
            {
                Console.WriteLine("ready to send message");

                var random = new Random();

                AddReq req = new AddReq
                {
                    A = random.Next(1, 10000),
                    B = random.Next(1, 10000)
                };

                Console.WriteLine("call sever MathService.Add  --> {0}+{1} ", req.A, req.B);

                try
                {
                    var res = await client.AddAsync(req);
                    Console.WriteLine("server repsonse:<-----{0}+{1}={2}", req.A, req.B, res.Data.C);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("error occ {0}", ex.Message);
                }

            }
            Console.WriteLine("channel is closed!");
        }
    }
}
