using DotBPE.AspNetGateway;
using DotBPE.Protobuf;
using DotBPE.Protocol.Amp;
using DotBPE.Rpc;
using DotBPE.Rpc.Options;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Caching.Redis;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Survey.Core;
using DotBPE.Rpc.Netty;
namespace Survey.AspNetGateway
{
    public class Startup
    {
        public Startup(IConfiguration config)
        {
            this.Configuration = config;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddOptions();

            //内部服务地址，也可以使用服务发现的方式，这里使用本地配置
            services.Configure<RemoteServicesOption>(Configuration.GetSection("remoteServices"));

            //redis 配置信息
            services.Configure<RedisCacheOptions>(Configuration.GetSection("redis"));

            //添加分布式缓存的实现
            services.AddSingleton<IDistributedCache, RedisCache>();

   

            //添加路由信息
            services.AddRoutes();

            //添加默认AspNetGateWay相关依赖
            services.AddSingleton<IProtobufObjectFactory, ProtobufObjectFactory>();
            services.AddSingleton<IMessageParser<AmpMessage>, MessageParser>();
            services.AddProtocolPipe<AmpMessage>();


            //添加DotBPE的Amp协议支持
            //services.AddDotBPE();

            //添加转发服务配置
            services.AddGatewayClient().AddNettyClient<AmpMessage>();

            //cookie 认证相关
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                 .AddCookie(options => {
                     options.Cookie.Name = ".Survey";
                     options.Cookie.HttpOnly = true;
                     options.LoginPath = "/html/login.html";
                 });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //如果是单独的Gateway 需要设置一下， ProxyBuilder和默认的服务HostBuilder中已经默认添加
            DotBPE.Rpc.Environment.SetServiceProvider(app.ApplicationServices);

            //静态文件，默认目录是wwwroot
            app.UseDefaultFiles();
            app.UseStaticFiles();

            app.UseAuthentication();
            //使用网关
            app.UseGateway();
        }
    }
}
