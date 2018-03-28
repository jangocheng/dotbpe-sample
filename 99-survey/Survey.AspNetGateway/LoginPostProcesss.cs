using DotBPE.AspNetGateway;
using DotBPE.Protocol.Amp;
using Microsoft.AspNetCore.Http;
using Survey.Core;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.Extensions.Logging;

namespace Survey.AspNetGateway
{
    public class LoginPostProcesss : IHttpPostProcessPlugin<AmpMessage>
    {
        private static ILogger<LoginPostProcesss> _logger;
        public LoginPostProcesss(ILogger<LoginPostProcesss> logger)
        {
            _logger = logger;
        }

        public async Task<bool> PostProcessAsync(HttpRequest req, HttpResponse res, AmpMessage msg, HttpRouterOptionItem routeOption)
        {
            _logger.LogWarning("登录返回");
            if (msg.Code == 0) //登录成功
            {
                _logger.LogWarning("登录成功1");
                var loginRsp = LoginRsp.Parser.ParseFrom(msg.Data);
                if(loginRsp != null)
                {
                    _logger.LogWarning("登录成功2");
                    var claims = new[] { new Claim(ClaimTypes.Name, loginRsp.Account) };
                    var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    await res.HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(identity));
                    _logger.LogWarning("登录成功3");
                }
            }
            return false; //不拦截请求
        }
    }
}
