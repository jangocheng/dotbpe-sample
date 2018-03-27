// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: service/inner/qpaper_inner_20001.proto

#region Designer generated code

using DotBPE.Protocol.Amp;
using DotBPE.Rpc;
using Google.Protobuf;
using System.Threading.Tasks;

namespace Survey.Core
{
    //start for class AbstractQPaperInnerService
    public abstract class QPaperInnerServiceBase : ServiceActor
    {
        protected override int ServiceId => 20001;


        public override Task<AmpMessage> ProcessAsync(AmpMessage req)
        {
            switch (req.MessageId)
            {

                //方法 QPaperInnerService.SaveQPaper
                case 1: return this.ProcessSaveQPaperAsync(req);

                //方法 QPaperInnerService.QueryQPaperList
                case 2: return this.ProcessQueryQPaperListAsync(req);

                //方法 QPaperInnerService.GetQPaper
                case 3: return this.ProcessGetQPaperAsync(req);

                //方法 QPaperInnerService.GetQPaperFull
                case 4: return this.ProcessGetQPaperFullAsync(req);

                //方法 QPaperInnerService.AddAPaperCount
                case 5: return this.ProcessAddAPaperCountAsync(req);

                default: return base.ProcessNotFoundAsync(req);
            }
        }



        //调用委托
        private async Task<AmpMessage> ProcessSaveQPaperAsync(AmpMessage req)
        {
            SaveQPaperReq request = null;

            if (req.Data == null)
            {
                request = new SaveQPaperReq();
            }
            else
            {
                request = SaveQPaperReq.Parser.ParseFrom(req.Data);
            }

            req.FriendlyServiceName = "QPaperInnerService.SaveQPaper";

            var result = await SaveQPaperAsync(request);
            var response = AmpMessage.CreateResponseMessage(req.ServiceId, req.MessageId);

            response.FriendlyServiceName = "QPaperInnerService.SaveQPaper";
            response.Code = result.Code;
            if (result.Data != null)
            {
                response.Data = result.Data.ToByteArray();
            }
            return response;
        }
        //抽象方法
        public abstract Task<RpcResult<SaveQPaperRsp>> SaveQPaperAsync( SaveQPaperReq req);

        //调用委托
        private async Task<AmpMessage> ProcessQueryQPaperListAsync(AmpMessage req)
        {
            QueryQPaperReq request = null;

            if (req.Data == null)
            {
                request = new QueryQPaperReq();
            }
            else
            {
                request = QueryQPaperReq.Parser.ParseFrom(req.Data);
            }

            req.FriendlyServiceName = "QPaperInnerService.QueryQPaperList";

            var result = await QueryQPaperListAsync(request);
            var response = AmpMessage.CreateResponseMessage(req.ServiceId, req.MessageId);

            response.FriendlyServiceName = "QPaperInnerService.QueryQPaperList";
            response.Code = result.Code;
            if (result.Data != null)
            {
                response.Data = result.Data.ToByteArray();
            }
            return response;
        }
        //抽象方法
        public abstract Task<RpcResult<QPaperListRsp>> QueryQPaperListAsync( QueryQPaperReq req);

        //调用委托
        private async Task<AmpMessage> ProcessGetQPaperAsync(AmpMessage req)
        {
            GetQPaperReq request = null;

            if (req.Data == null)
            {
                request = new GetQPaperReq();
            }
            else
            {
                request = GetQPaperReq.Parser.ParseFrom(req.Data);
            }

            req.FriendlyServiceName = "QPaperInnerService.GetQPaper";

            var result = await GetQPaperAsync(request);
            var response = AmpMessage.CreateResponseMessage(req.ServiceId, req.MessageId);

            response.FriendlyServiceName = "QPaperInnerService.GetQPaper";
            response.Code = result.Code;
            if (result.Data != null)
            {
                response.Data = result.Data.ToByteArray();
            }
            return response;
        }
        //抽象方法
        public abstract Task<RpcResult<QPaperRsp>> GetQPaperAsync( GetQPaperReq req);

        //调用委托
        private async Task<AmpMessage> ProcessGetQPaperFullAsync(AmpMessage req)
        {
            GetQPaperReq request = null;

            if (req.Data == null)
            {
                request = new GetQPaperReq();
            }
            else
            {
                request = GetQPaperReq.Parser.ParseFrom(req.Data);
            }

            req.FriendlyServiceName = "QPaperInnerService.GetQPaperFull";

            var result = await GetQPaperFullAsync(request);
            var response = AmpMessage.CreateResponseMessage(req.ServiceId, req.MessageId);

            response.FriendlyServiceName = "QPaperInnerService.GetQPaperFull";
            response.Code = result.Code;
            if (result.Data != null)
            {
                response.Data = result.Data.ToByteArray();
            }
            return response;
        }
        //抽象方法
        public abstract Task<RpcResult<QPaperFullRsp>> GetQPaperFullAsync( GetQPaperReq req);

        //调用委托
        private async Task<AmpMessage> ProcessAddAPaperCountAsync(AmpMessage req)
        {
            AddAPaperReq request = null;

            if (req.Data == null)
            {
                request = new AddAPaperReq();
            }
            else
            {
                request = AddAPaperReq.Parser.ParseFrom(req.Data);
            }

            req.FriendlyServiceName = "QPaperInnerService.AddAPaperCount";

            var result = await AddAPaperCountAsync(request);
            var response = AmpMessage.CreateResponseMessage(req.ServiceId, req.MessageId);

            response.FriendlyServiceName = "QPaperInnerService.AddAPaperCount";
            response.Code = result.Code;
            if (result.Data != null)
            {
                response.Data = result.Data.ToByteArray();
            }
            return response;
        }
        //抽象方法
        public abstract Task<RpcResult<VoidRsp>> AddAPaperCountAsync( AddAPaperReq req);

    }

    //end for class AbstractQPaperInnerService
}

#endregion Designer generated code