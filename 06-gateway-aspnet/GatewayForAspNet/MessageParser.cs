﻿using DotBPE.Plugin.AspNetGateway;
using DotBPE.Protocol.Amp;
using Google.Protobuf;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace GatewayForAspNet
{
    public class MessageParser : IMessageParser<AmpMessage>
    {
        static readonly JsonFormatter AmpJsonFormatter = new JsonFormatter(new JsonFormatter.Settings(true));

        private readonly ILogger<MessageParser> _logger;
        public MessageParser(ILogger<MessageParser> logger)
        {
            _logger = logger;
        }
        public string ToJson(AmpMessage message)
        {
            if (message.Code == 0)
            {
                var return_code = 0;
                var return_message = "";
                string ret = "";
                if (message != null)
                {
                    var rspTemp = ProtobufObjectFactory.GetResponseTemplate(message.ServiceId, message.MessageId);
                    if (rspTemp == null)
                    {
                        return ret;
                    }

                    if (message.Data != null)
                    {
                        rspTemp.MergeFrom(message.Data);
                    }

                    //提取return_message
                    var field_msg = rspTemp.Descriptor.FindFieldByName("return_message");
                    if (field_msg != null)
                    {
                        var retObjV = field_msg.Accessor.GetValue(rspTemp);
                        if (retObjV != null)
                        {
                            return_message = retObjV.ToString();
                        }
                    }


                    ret = AmpJsonFormatter.Format(rspTemp);

                    //TODO:清理内部的return_message ;
                }

                return "{\"return_code\":" + return_code + ",\"return_message\":\"" + return_message + "\",data:" + ret + "}";
            }
            else
            {
                return "{\"return_code\":" + message.Code + ",\"return_message\":\"\"}";
            }

        }

        public AmpMessage ToMessage(RequestData reqData)
        {
            ushort serviceId = (ushort)reqData.ServiceId;
            ushort messageId = (ushort)reqData.MessageId;
            AmpMessage message = AmpMessage.CreateRequestMessage(serviceId, messageId);

            IMessage reqTemp = ProtobufObjectFactory.GetRequestTemplate(serviceId, messageId);
            if (reqTemp == null)
            {
                this._logger.LogError("serviceId={0},messageId={1}的消息不存在", serviceId, messageId);
                return null;
            }

            try
            {
                var descriptor = reqTemp.Descriptor;
                if (!string.IsNullOrEmpty(reqData.RawBody))
                {
                    reqTemp = descriptor.Parser.ParseJson(reqData.RawBody);
                }

                if (reqData.Data.Count > 0)
                {
                    foreach (var field in descriptor.Fields.InDeclarationOrder())
                    {
                        if (reqData.Data.ContainsKey(field.Name))
                        {
                            field.Accessor.SetValue(reqTemp, reqData.Data[field.Name]);
                        }
                        else if (reqData.Data.ContainsKey(field.JsonName))
                        {
                            field.Accessor.SetValue(reqTemp, reqData.Data[field.JsonName]);
                        }

                    }
                }
                message.Data = reqTemp.ToByteArray();

            }
            catch (Exception ex)
            {
                this._logger.LogError(ex, "从HTTP请求中解析数据错误:" + ex.Message);
                message = null;
            }

            return message;
        }
    }
}
