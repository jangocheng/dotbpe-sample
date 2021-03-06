// Generated by the protocol buffer compiler. DO NOT EDIT!
// source: service/inner/qpaper_inner_20001.proto
#region Designer generated code

using System;
using System.Threading.Tasks;
using DotBPE.Rpc;
using DotBPE.Protocol.Amp;
using DotBPE.Rpc.Exceptions;
using Google.Protobuf;
using DotBPE.Rpc.Client;

namespace Survey.Core {

    //start for class QPaperInnerServiceClient
    public sealed class QPaperInnerServiceClient : AmpInvokeClient
    {
        public QPaperInnerServiceClient(ICallInvoker<AmpMessage> callInvoker) : base(callInvoker)
        {

        }

        //同步方法
        public RpcResult<SaveQPaperRsp> SaveQPaper(SaveQPaperReq req)
        {
            AmpMessage message = AmpMessage.CreateRequestMessage(20001, 1);

            message.FriendlyServiceName = "QPaperInnerService.SaveQPaper";


            message.Data = req.ToByteArray();
            var response = base.CallInvoker.BlockingCall(message);
            if (response == null)
            {
                throw new RpcException("error,response is null !");
            }
            var result = new RpcResult<SaveQPaperRsp>();
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
                result.Data = SaveQPaperRsp.Parser.ParseFrom(response.Data);
            }
            return result;
        }

        public async Task<RpcResult<SaveQPaperRsp>> SaveQPaperAsync(SaveQPaperReq req, int timeOut = 3000)
        {
            AmpMessage message = AmpMessage.CreateRequestMessage(20001, 1);
            message.FriendlyServiceName = "QPaperInnerService.SaveQPaper";
            message.Data = req.ToByteArray();
            var response = await base.CallInvoker.AsyncCall(message, timeOut);
            if (response == null)
            {
                throw new RpcException("error,response is null !");
            }
           var result = new RpcResult<SaveQPaperRsp>();
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
                result.Data = SaveQPaperRsp.Parser.ParseFrom(response.Data);
            }

            return result;
        }

        //同步方法
        public RpcResult<QPaperListRsp> QueryQPaperList(QueryQPaperReq req)
        {
            AmpMessage message = AmpMessage.CreateRequestMessage(20001, 2);

            message.FriendlyServiceName = "QPaperInnerService.QueryQPaperList";


            message.Data = req.ToByteArray();
            var response = base.CallInvoker.BlockingCall(message);
            if (response == null)
            {
                throw new RpcException("error,response is null !");
            }
            var result = new RpcResult<QPaperListRsp>();
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
                result.Data = QPaperListRsp.Parser.ParseFrom(response.Data);
            }
            return result;
        }

        public async Task<RpcResult<QPaperListRsp>> QueryQPaperListAsync(QueryQPaperReq req, int timeOut = 3000)
        {
            AmpMessage message = AmpMessage.CreateRequestMessage(20001, 2);
            message.FriendlyServiceName = "QPaperInnerService.QueryQPaperList";
            message.Data = req.ToByteArray();
            var response = await base.CallInvoker.AsyncCall(message, timeOut);
            if (response == null)
            {
                throw new RpcException("error,response is null !");
            }
           var result = new RpcResult<QPaperListRsp>();
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
                result.Data = QPaperListRsp.Parser.ParseFrom(response.Data);
            }

            return result;
        }

        //同步方法
        public RpcResult<QPaperRsp> GetQPaper(GetQPaperReq req)
        {
            AmpMessage message = AmpMessage.CreateRequestMessage(20001, 3);

            message.FriendlyServiceName = "QPaperInnerService.GetQPaper";


            message.Data = req.ToByteArray();
            var response = base.CallInvoker.BlockingCall(message);
            if (response == null)
            {
                throw new RpcException("error,response is null !");
            }
            var result = new RpcResult<QPaperRsp>();
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
                result.Data = QPaperRsp.Parser.ParseFrom(response.Data);
            }
            return result;
        }

        public async Task<RpcResult<QPaperRsp>> GetQPaperAsync(GetQPaperReq req, int timeOut = 3000)
        {
            AmpMessage message = AmpMessage.CreateRequestMessage(20001, 3);
            message.FriendlyServiceName = "QPaperInnerService.GetQPaper";
            message.Data = req.ToByteArray();
            var response = await base.CallInvoker.AsyncCall(message, timeOut);
            if (response == null)
            {
                throw new RpcException("error,response is null !");
            }
           var result = new RpcResult<QPaperRsp>();
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
                result.Data = QPaperRsp.Parser.ParseFrom(response.Data);
            }

            return result;
        }

        //同步方法
        public RpcResult<QPaperFullRsp> GetQPaperFull(GetQPaperReq req)
        {
            AmpMessage message = AmpMessage.CreateRequestMessage(20001, 4);

            message.FriendlyServiceName = "QPaperInnerService.GetQPaperFull";


            message.Data = req.ToByteArray();
            var response = base.CallInvoker.BlockingCall(message);
            if (response == null)
            {
                throw new RpcException("error,response is null !");
            }
            var result = new RpcResult<QPaperFullRsp>();
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
                result.Data = QPaperFullRsp.Parser.ParseFrom(response.Data);
            }
            return result;
        }

        public async Task<RpcResult<QPaperFullRsp>> GetQPaperFullAsync(GetQPaperReq req, int timeOut = 3000)
        {
            AmpMessage message = AmpMessage.CreateRequestMessage(20001, 4);
            message.FriendlyServiceName = "QPaperInnerService.GetQPaperFull";
            message.Data = req.ToByteArray();
            var response = await base.CallInvoker.AsyncCall(message, timeOut);
            if (response == null)
            {
                throw new RpcException("error,response is null !");
            }
           var result = new RpcResult<QPaperFullRsp>();
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
                result.Data = QPaperFullRsp.Parser.ParseFrom(response.Data);
            }

            return result;
        }

        //同步方法
        public RpcResult<VoidRsp> AddAPaperCount(AddAPaperReq req)
        {
            AmpMessage message = AmpMessage.CreateRequestMessage(20001, 5);

            message.FriendlyServiceName = "QPaperInnerService.AddAPaperCount";


            message.Data = req.ToByteArray();
            var response = base.CallInvoker.BlockingCall(message);
            if (response == null)
            {
                throw new RpcException("error,response is null !");
            }
            var result = new RpcResult<VoidRsp>();
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
                result.Data = VoidRsp.Parser.ParseFrom(response.Data);
            }
            return result;
        }

        public async Task<RpcResult<VoidRsp>> AddAPaperCountAsync(AddAPaperReq req, int timeOut = 3000)
        {
            AmpMessage message = AmpMessage.CreateRequestMessage(20001, 5);
            message.FriendlyServiceName = "QPaperInnerService.AddAPaperCount";
            message.Data = req.ToByteArray();
            var response = await base.CallInvoker.AsyncCall(message, timeOut);
            if (response == null)
            {
                throw new RpcException("error,response is null !");
            }
           var result = new RpcResult<VoidRsp>();
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
                result.Data = VoidRsp.Parser.ParseFrom(response.Data);
            }

            return result;
        }

    }
    //end for class QPaperInnerServiceClient
}
#endregion