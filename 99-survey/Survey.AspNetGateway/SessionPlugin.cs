using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DotBPE.Plugin.AspNetGateway;
using DotBPE.Rpc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Survey.Core;

namespace Survey.AspNetGateway
{
    public class SessionPlugin : IHttpRequestPostParsePlugin
    {
        private readonly ILoginService _loginService;
        private readonly ILogger<SessionPlugin> _logger;
        public SessionPlugin(ILoginService loginService,ILogger<SessionPlugin> logger)
        {
            this._loginService = loginService;
            this._logger = logger;
        }
        public async Task<RpcContentResult> PostParseAsync(HttpRequest req, RequestData rd, HttpRouterOptionItem routeOption)
        {
            RpcContentResult res = new RpcContentResult();

            if (rd.Data.ContainsKey(Constants.SEESIONID_FIELD_NAME)) //存在SessionID
            {
                var sessionId = rd.Data[Constants.SEESIONID_FIELD_NAME];
                if (!rd.Data.ContainsKey(Constants.IDENTITY_FIELD_NAME))
                {
                    var user = await this._loginService.GetSessionUserAsync(sessionId);
                    if (user != null)
                    {
                        _logger.LogDebug("用户{identity},使用{method}方式请求页面{path},", user.Identity, req.Method , req.Path);
                        rd.Data.Add(Constants.IDENTITY_FIELD_NAME, user.Identity);
                    }
                }
            }

            return res;
        }
    }
}
