
//------------------------------------------------------------------------------
// 
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// 
//------------------------------------------------------------------------------

// Generated from: Sys.proto
namespace RoyNet.GateServer.Entity
{
    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"G2G_ToGameLogin")]
    public partial class G2G_ToGameLogin : global::ProtoBuf.IExtensible
    {
      public G2G_ToGameLogin() {}
      
    private string _UserName;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"UserName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string UserName
    {
      get { return _UserName; }
      set { _UserName = value; }
    }
      private global::ProtoBuf.IExtension extensionObject;
      global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }
  
    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"G2G_ToGameLogOut")]
    public partial class G2G_ToGameLogOut : global::ProtoBuf.IExtensible
    {
      public G2G_ToGameLogOut() {}
      

    private string _Reason = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Reason", DataFormat = global::ProtoBuf.DataFormat.Default)][global::System.ComponentModel.DefaultValue("")]
    public string Reason
    {
      get { return _Reason; }
      set { _Reason = value; }
    }
      private global::ProtoBuf.IExtension extensionObject;
      global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }
  
    [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"G2G_ToGateDisconnect")]
    public partial class G2G_ToGateDisconnect : global::ProtoBuf.IExtensible
    {
      public G2G_ToGateDisconnect() {}
      

    private string _Reason = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Reason", DataFormat = global::ProtoBuf.DataFormat.Default)][global::System.ComponentModel.DefaultValue("")]
    public string Reason
    {
      get { return _Reason; }
      set { _Reason = value; }
    }
      private global::ProtoBuf.IExtension extensionObject;
      global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
    }
  
    public enum CMD_G2G
    {
      ToGameLogin = 1,
    ToGameLogOut = 2,
    ToGateDisconnect = 3
    }
  
}