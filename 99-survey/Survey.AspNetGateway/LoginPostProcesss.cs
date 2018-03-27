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


namespace Survey.AspNetGateway
{
    public class LoginPostProcesss : IHttpPostProcessPlugin<AmpMessage>
    {
        
        public async Task<bool> PostProcessAsync(HttpRequest req, HttpResponse res, AmpMessage msg, HttpRouterOptionItem routeOption)
        {
            if(msg.Code == 0) //登录成功
            {
                var loginRsp = LoginRsp.Parser.ParseFrom(msg.Data);
                if(loginRsp != null)
                {                   
                    var claims = new[] { new Claim(ClaimTypes.Name, loginRsp.Account) };
                    var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    await res.HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(identity));
                   
                }
            }
            return false; //不拦截请求
        }
    }
}
