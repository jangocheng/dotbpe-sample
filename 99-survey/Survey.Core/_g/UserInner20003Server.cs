// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: service/inner/user_inner_20003.proto
#region Designer generated code

using System; 
using System.Threading.Tasks; 
using DotBPE.Rpc; 
using DotBPE.Protocol.Amp; 
using Google.Protobuf; 

namespace Survey.Core {

//start for class AbstractUserInnerService
   public abstract class UserInnerServiceBase : ServiceActor 
   {
      protected override int ServiceId => 20003;
      //调用委托
      private async Task<AmpMessage> ProcessRegisterAsync(AmpMessage req)
      {
         RegisterReq request = null;

         if(req.Data == null ){
            request = new RegisterReq();
         }
         else {
            request = RegisterReq.Parser.ParseFrom(req.Data);
         }

         var result = await RegisterAsync(request);
         var response = AmpMessage.CreateResponseMessage(req.ServiceId, req.MessageId);
         response.Code = result.Code;
         if( result.Data !=null )
         {
             response.Data = result.Data.ToByteArray();
         }
         return response;
      }

      //抽象方法
      public abstract Task<RpcResult<RegisterRsp>> RegisterAsync(RegisterReq request);
      //调用委托
      private async Task<AmpMessage> ProcessLoginAsync(AmpMessage req)
      {
         LoginReq request = null;

         if(req.Data == null ){
            request = new LoginReq();
         }
         else {
            request = LoginReq.Parser.ParseFrom(req.Data);
         }

         var result = await LoginAsync(request);
         var response = AmpMessage.CreateResponseMessage(req.ServiceId, req.MessageId);
         response.Code = result.Code;
         if( result.Data !=null )
         {
             response.Data = result.Data.ToByteArray();
         }
         return response;
      }

      //抽象方法
      public abstract Task<RpcResult<LoginRsp>> LoginAsync(LoginReq request);
      //调用委托
      private async Task<AmpMessage> ProcessEditAsync(AmpMessage req)
      {
         EditUserReq request = null;

         if(req.Data == null ){
            request = new EditUserReq();
         }
         else {
            request = EditUserReq.Parser.ParseFrom(req.Data);
         }

         var result = await EditAsync(request);
         var response = AmpMessage.CreateResponseMessage(req.ServiceId, req.MessageId);
         response.Code = result.Code;
         if( result.Data !=null )
         {
             response.Data = result.Data.ToByteArray();
         }
         return response;
      }

      //抽象方法
      public abstract Task<RpcResult<EditUserRsp>> EditAsync(EditUserReq request);
      //调用委托
      private async Task<AmpMessage> ProcessGetUserInfoAsync(AmpMessage req)
      {
         GetUserReq request = null;

         if(req.Data == null ){
            request = new GetUserReq();
         }
         else {
            request = GetUserReq.Parser.ParseFrom(req.Data);
         }

         var result = await GetUserInfoAsync(request);
         var response = AmpMessage.CreateResponseMessage(req.ServiceId, req.MessageId);
         response.Code = result.Code;
         if( result.Data !=null )
         {
             response.Data = result.Data.ToByteArray();
         }
         return response;
      }

      //抽象方法
      public abstract Task<RpcResult<GetUserRsp>> GetUserInfoAsync(GetUserReq request);
      public override Task<AmpMessage> ProcessAsync(AmpMessage req)
      {
         switch(req.MessageId){
            //方法UserInnerService.Register
            case 1: return this.ProcessRegisterAsync(req);
            //方法UserInnerService.Login
            case 2: return this.ProcessLoginAsync(req);
            //方法UserInnerService.Edit
            case 3: return this.ProcessEditAsync(req);
            //方法UserInnerService.GetUserInfo
            case 4: return this.ProcessGetUserInfoAsync(req);
            default: return base.ProcessNotFoundAsync(req);
         }
      }
   }
//end for class AbstractUserInnerService
}

#endregion

