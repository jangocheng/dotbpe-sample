// Generated by the protocol buffer compiler. DO NOT EDIT!
// source: service/inner/apaper_inner_20002.proto
#region Designer generated code

using System;
using System.Threading.Tasks;
using DotBPE.Rpc;
using DotBPE.Protocol.Amp;
using DotBPE.Rpc.Exceptions;
using Google.Protobuf;
using DotBPE.Rpc.Client;

namespace Survey.Core {

    //start for class APaperInnerServiceClient
    public sealed class APaperInnerServiceClient : AmpInvokeClient
    {
        public APaperInnerServiceClient(ICallInvoker<AmpMessage> callInvoker) : base(callInvoker)
        {

        }

        //同步方法
        public RpcResult<SaveAPaperRsp> SaveAPaper(SaveAPaperReq req)
        {
            AmpMessage message = AmpMessage.CreateRequestMessage(20002, 1);

            message.FriendlyServiceName = "APaperInnerService.SaveAPaper";


            message.Data = req.ToByteArray();
            var response = base.CallInvoker.BlockingCall(message);
            if (response == null)
            {
                throw new RpcException("error,response is null !");
            }
            var result = new RpcResult<SaveAPaperRsp>();
            if (response.Code != 0)
            {
                result.Code = response.Code;
            }
            else if (response.Data == null)
            {
                result.Code = ErrorCodes.CODE_INTERNAL_ERROR;
            }
            else
            {
                result.Data = SaveAPaperRsp.Parser.ParseFrom(response.Data);
            }
            return result;
        }

        public async Task<RpcResult<SaveAPaperRsp>> SaveAPaperAsync(SaveAPaperReq req, int timeOut = 3000)
        {
            AmpMessage message = AmpMessage.CreateRequestMessage(20002, 1);
            message.FriendlyServiceName = "APaperInnerService.SaveAPaper";
            message.Data = req.ToByteArray();
            var response = await base.CallInvoker.AsyncCall(message, timeOut);
            if (response == null)
            {
                throw new RpcException("error,response is null !");
            }
           var result = new RpcResult<SaveAPaperRsp>();
            if (response.Code != 0)
            {
                result.Code = response.Code;
            }
            else if (response.Data == null)
            {
                result.Code = ErrorCodes.CODE_INTERNAL_ERROR;
            }
            else
            {
                result.Data = SaveAPaperRsp.Parser.ParseFrom(response.Data);
            }

            return result;
        }

        //同步方法
        public RpcResult<APaperListRsp> QueryAPaperList(QueryAPaperReq req)
        {
            AmpMessage message = AmpMessage.CreateRequestMessage(20002, 2);

            message.FriendlyServiceName = "APaperInnerService.QueryAPaperList";


            message.Data = req.ToByteArray();
            var response = base.CallInvoker.BlockingCall(message);
            if (response == null)
            {
                throw new RpcException("error,response is null !");
            }
            var result = new RpcResult<APaperListRsp>();
            if (response.Code != 0)
            {
                result.Code = response.Code;
            }
            else if (response.Data == null)
            {
                result.Code = ErrorCodes.CODE_INTERNAL_ERROR;
            }
            else
            {
                result.Data = APaperListRsp.Parser.ParseFrom(response.Data);
            }
            return result;
        }

        public async Task<RpcResult<APaperListRsp>> QueryAPaperListAsync(QueryAPaperReq req, int timeOut = 3000)
        {
            AmpMessage message = AmpMessage.CreateRequestMessage(20002, 2);
            message.FriendlyServiceName = "APaperInnerService.QueryAPaperList";
            message.Data = req.ToByteArray();
            var response = await base.CallInvoker.AsyncCall(message, timeOut);
            if (response == null)
            {
                throw new RpcException("error,response is null !");
            }
           var result = new RpcResult<APaperListRsp>();
            if (response.Code != 0)
            {
                result.Code = response.Code;
            }
            else if (response.Data == null)
            {
                result.Code = ErrorCodes.CODE_INTERNAL_ERROR;
            }
            else
            {
                result.Data = APaperListRsp.Parser.ParseFrom(response.Data);
            }

            return result;
        }

        //同步方法
        public RpcResult<APaperRsp> GetAPaper(GetAPaperReq req)
        {
            AmpMessage message = AmpMessage.CreateRequestMessage(20002, 3);

            message.FriendlyServiceName = "APaperInnerService.GetAPaper";


            message.Data = req.ToByteArray();
            var response = base.CallInvoker.BlockingCall(message);
            if (response == null)
            {
                throw new RpcException("error,response is null !");
            }
            var result = new RpcResult<APaperRsp>();
            if (response.Code != 0)
            {
                result.Code = response.Code;
            }
            else if (response.Data == null)
            {
                result.Code = ErrorCodes.CODE_INTERNAL_ERROR;
            }
            else
            {
                result.Data = APaperRsp.Parser.ParseFrom(response.Data);
            }
            return result;
        }

        public async Task<RpcResult<APaperRsp>> GetAPaperAsync(GetAPaperReq req, int timeOut = 3000)
        {
            AmpMessage message = AmpMessage.CreateRequestMessage(20002, 3);
            message.FriendlyServiceName = "APaperInnerService.GetAPaper";
            message.Data = req.ToByteArray();
            var response = await base.CallInvoker.AsyncCall(message, timeOut);
            if (response == null)
            {
                throw new RpcException("error,response is null !");
            }
           var result = new RpcResult<APaperRsp>();
            if (response.Code != 0)
            {
                result.Code = response.Code;
            }
            else if (response.Data == null)
            {
                result.Code = ErrorCodes.CODE_INTERNAL_ERROR;
            }
            else
            {
                result.Data = APaperRsp.Parser.ParseFrom(response.Data);
            }

            return result;
        }

        //同步方法
        public RpcResult<APaperStaDetailRsp> GetAPaperSta(GetAPaperStaDetailReq req)
        {
            AmpMessage message = AmpMessage.CreateRequestMessage(20002, 4);

            message.FriendlyServiceName = "APaperInnerService.GetAPaperSta";


            message.Data = req.ToByteArray();
            var response = base.CallInvoker.BlockingCall(message);
            if (response == null)
            {
                throw new RpcException("error,response is null !");
            }
            var result = new RpcResult<APaperStaDetailRsp>();
            if (response.Code != 0)
            {
                result.Code = response.Code;
            }
            else if (response.Data == null)
            {
                result.Code = ErrorCodes.CODE_INTERNAL_ERROR;
            }
            else
            {
                result.Data = APaperStaDetailRsp.Parser.ParseFrom(response.Data);
            }
            return result;
        }

        public async Task<RpcResult<APaperStaDetailRsp>> GetAPaperStaAsync(GetAPaperStaDetailReq req, int timeOut = 3000)
        {
            AmpMessage message = AmpMessage.CreateRequestMessage(20002, 4);
            message.FriendlyServiceName = "APaperInnerService.GetAPaperSta";
            message.Data = req.ToByteArray();
            var response = await base.CallInvoker.AsyncCall(message, timeOut);
            if (response == null)
            {
                throw new RpcException("error,response is null !");
            }
           var result = new RpcResult<APaperStaDetailRsp>();
            if (response.Code != 0)
            {
                result.Code = response.Code;
            }
            else if (response.Data == null)
            {
                result.Code = ErrorCodes.CODE_INTERNAL_ERROR;
            }
            else
            {
                result.Data = APaperStaDetailRsp.Parser.ParseFrom(response.Data);
            }

            return result;
        }

    }
    //end for class APaperInnerServiceClient
}
#endregion