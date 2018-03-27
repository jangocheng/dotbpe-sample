// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: service/gate/user_gate_10001.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Survey.Core {

  /// <summary>Holder for reflection information generated from service/gate/user_gate_10001.proto</summary>
  public static partial class UserGate10001Reflection {

    #region Descriptor
    /// <summary>File descriptor for service/gate/user_gate_10001.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UserGate10001Reflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJzZXJ2aWNlL2dhdGUvdXNlcl9nYXRlXzEwMDAxLnByb3RvEgZkb3RicGUa",
            "E2RvdGJwZV9vcHRpb24ucHJvdG8aEm1lc3NhZ2UvdXNlci5wcm90byJKCg1D",
            "aGVja0xvZ2luUmVxEhEKCWNsaWVudF9pcBgBIAEoCRIQCghpZGVudGl0eRgC",
            "IAEoCRIUCgx4X3JlcXVlc3RfaWQYAyABKAky+gMKD1VzZXJHYXRlU2Vydmlj",
            "ZRJmCghSZWdpc3RlchITLmRvdGJwZS5SZWdpc3RlclJlcRoTLmRvdGJwZS5S",
            "ZWdpc3RlclJzcCIw0PMYH9rzGCgKEi9hcGkvdXNlci9yZWdpc3RlchIEcG9z",
            "dBoM5rOo5YaM55So5oi3EpcBCgVMb2dpbhIQLmRvdGJwZS5Mb2dpblJlcRoQ",
            "LmRvdGJwZS5Mb2dpblJzcCJq0PMYINrzGGIKDy9hcGkvZ2F0ZS9sb2dpbhIE",
            "cG9zdBoM55So5oi355m75b2VKjtTdXJ2ZXkuQXNwTmV0R2F0ZXdheS5Mb2dp",
            "blBvc3RQcm9jZXNzcyxTdXJ2ZXkuQXNwTmV0R2F0ZXdheRJxCghFZGl0VXNl",
            "chITLmRvdGJwZS5FZGl0VXNlclJlcRoTLmRvdGJwZS5FZGl0VXNlclJzcCI7",
            "0PMYIdrzGDMKDi9hcGkvdXNlci9zYXZlEgRwb3N0Ghvkv53lrZjkv67mlLnn",
            "moTnlKjmiLfkv6Hmga8SawoKQ2hlY2tMb2dpbhIVLmRvdGJwZS5DaGVja0xv",
            "Z2luUmVxGhIuZG90YnBlLkdldFVzZXJSc3AiMtDzGCLa8xgqCg8vYXBpL2dh",
            "dGUvY2hlY2sSA2dldBoS6I635Y+W55So5oi35L+h5oGvGgXI8xiRTkIcSAGq",
            "AgtTdXJ2ZXkuQ29yZfDzGAH48xgB6PMYAVAAYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::DotBPE.Protobuf.DotbpeOptionReflection.Descriptor, global::Survey.Core.UserReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Survey.Core.CheckLoginReq), global::Survey.Core.CheckLoginReq.Parser, new[]{ "ClientIp", "Identity", "XRequestId" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CheckLoginReq : pb::IMessage<CheckLoginReq> {
    private static readonly pb::MessageParser<CheckLoginReq> _parser = new pb::MessageParser<CheckLoginReq>(() => new CheckLoginReq());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CheckLoginReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Survey.Core.UserGate10001Reflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CheckLoginReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CheckLoginReq(CheckLoginReq other) : this() {
      clientIp_ = other.clientIp_;
      identity_ = other.identity_;
      xRequestId_ = other.xRequestId_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CheckLoginReq Clone() {
      return new CheckLoginReq(this);
    }

    /// <summary>Field number for the "client_ip" field.</summary>
    public const int ClientIpFieldNumber = 1;
    private string clientIp_ = "";
    /// <summary>
    /// 用户端IP
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ClientIp {
      get { return clientIp_; }
      set {
        clientIp_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "identity" field.</summary>
    public const int IdentityFieldNumber = 2;
    private string identity_ = "";
    /// <summary>
    ///  用户标识
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Identity {
      get { return identity_; }
      set {
        identity_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "x_request_id" field.</summary>
    public const int XRequestIdFieldNumber = 3;
    private string xRequestId_ = "";
    /// <summary>
    /// 请求的唯一标识，用于服务间传递
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string XRequestId {
      get { return xRequestId_; }
      set {
        xRequestId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CheckLoginReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CheckLoginReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ClientIp != other.ClientIp) return false;
      if (Identity != other.Identity) return false;
      if (XRequestId != other.XRequestId) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ClientIp.Length != 0) hash ^= ClientIp.GetHashCode();
      if (Identity.Length != 0) hash ^= Identity.GetHashCode();
      if (XRequestId.Length != 0) hash ^= XRequestId.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (ClientIp.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ClientIp);
      }
      if (Identity.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Identity);
      }
      if (XRequestId.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(XRequestId);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ClientIp.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ClientIp);
      }
      if (Identity.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Identity);
      }
      if (XRequestId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(XRequestId);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CheckLoginReq other) {
      if (other == null) {
        return;
      }
      if (other.ClientIp.Length != 0) {
        ClientIp = other.ClientIp;
      }
      if (other.Identity.Length != 0) {
        Identity = other.Identity;
      }
      if (other.XRequestId.Length != 0) {
        XRequestId = other.XRequestId;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            ClientIp = input.ReadString();
            break;
          }
          case 18: {
            Identity = input.ReadString();
            break;
          }
          case 26: {
            XRequestId = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
