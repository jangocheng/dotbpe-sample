using DotBPE.Plugin.AspNetGateway;
using DotBPE.Protobuf;
using DotBPE.Protocol.Amp;
using DotBPE.Rpc;
using Google.Protobuf;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace Survey.AspNetGateway
{
    public class AmpGatewayService : DefaultGateService<AmpMessage>
    {
        private readonly IProtobufObjectFactory _factory;
        public AmpGatewayService(
            IOptions<HttpRouterOption> optionsAccessor, 
            IMessageParser<AmpMessage> parser,
            IProtobufObjectFactory factory
            ) 
            : base(optionsAccessor, parser)
        {
            this._factory = factory;
        }

        protected override string GetSessionIdFromMessage(AmpMessage message)
        {
            if(message ==null)
            {
                return "";
            }

            var rspTemp = this._factory.GetResponseTemplate(message.ServiceId, message.MessageId);
           
            if (message.Data != null)
            {
                rspTemp.MergeFrom(message.Data);
            }

            //提取return_message
            var field_msg = rspTemp.Descriptor.FindFieldByName(Constants.SEESIONID_FIELD_NAME);
            if (field_msg != null)
            {
                var retObjV = field_msg.Accessor.GetValue(rspTemp);
                if (retObjV != null)
                {
                    return retObjV.ToString();
                }
            }


            return base.GetSessionIdFromMessage(message);
        }
    }
}
