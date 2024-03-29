// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Proto/Battle.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace ReMastersLib {

  /// <summary>Holder for reflection information generated from Proto/Battle.proto</summary>
  public static partial class BattleReflection {

    #region Descriptor
    /// <summary>File descriptor for Proto/Battle.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BattleReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJQcm90by9CYXR0bGUucHJvdG8SDFJlTWFzdGVyc0xpYiKKAgoGQmF0dGxl",
            "EhEKCWJhdHRsZV9pZBgBIAEoAxIbChNiYXR0bGVfcGFyYW1ldGVyX2lkGAIg",
            "ASgFEhgKEGJhdHRsZV9yZXdhcmRfaWQYAyABKAUSEgoKYmFzZV9sZXZlbBgE",
            "IAEoBRIKCgJ1NRgFIAEoBRIVCg1iYXR0bGVfYmdtX2lkGAYgASgJEhUKDXJl",
            "c3VsdF9iZ21faWQYByABKAkSCgoCdTgYCCABKAUSCgoCdTkYCSABKAUSCwoD",
            "dTEwGAogASgFEgsKA3UxMRgLIAEoBRIcChRkZWNrX3ByZXNldF9ncm91cF9p",
            "ZBgMIAEoBRILCgN1MTMYDSABKAUSCwoDdTE0GA4gASgFIjQKC0JhdHRsZVRh",
            "YmxlEiUKB2VudHJpZXMYASADKAsyFC5SZU1hc3RlcnNMaWIuQmF0dGxlYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::ReMastersLib.Battle), global::ReMastersLib.Battle.Parser, new[]{ "BattleId", "BattleParameterId", "BattleRewardId", "BaseLevel", "U5", "BattleBgmId", "ResultBgmId", "U8", "U9", "U10", "U11", "DeckPresetGroupId", "U13", "U14" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ReMastersLib.BattleTable), global::ReMastersLib.BattleTable.Parser, new[]{ "Entries" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Battle : pb::IMessage<Battle>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Battle> _parser = new pb::MessageParser<Battle>(() => new Battle());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Battle> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ReMastersLib.BattleReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Battle() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Battle(Battle other) : this() {
      battleId_ = other.battleId_;
      battleParameterId_ = other.battleParameterId_;
      battleRewardId_ = other.battleRewardId_;
      baseLevel_ = other.baseLevel_;
      u5_ = other.u5_;
      battleBgmId_ = other.battleBgmId_;
      resultBgmId_ = other.resultBgmId_;
      u8_ = other.u8_;
      u9_ = other.u9_;
      u10_ = other.u10_;
      u11_ = other.u11_;
      deckPresetGroupId_ = other.deckPresetGroupId_;
      u13_ = other.u13_;
      u14_ = other.u14_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Battle Clone() {
      return new Battle(this);
    }

    /// <summary>Field number for the "battle_id" field.</summary>
    public const int BattleIdFieldNumber = 1;
    private long battleId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long BattleId {
      get { return battleId_; }
      set {
        battleId_ = value;
      }
    }

    /// <summary>Field number for the "battle_parameter_id" field.</summary>
    public const int BattleParameterIdFieldNumber = 2;
    private int battleParameterId_;
    /// <summary>
    /// BattleParameter.pb
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int BattleParameterId {
      get { return battleParameterId_; }
      set {
        battleParameterId_ = value;
      }
    }

    /// <summary>Field number for the "battle_reward_id" field.</summary>
    public const int BattleRewardIdFieldNumber = 3;
    private int battleRewardId_;
    /// <summary>
    /// BattleReward.pb
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int BattleRewardId {
      get { return battleRewardId_; }
      set {
        battleRewardId_ = value;
      }
    }

    /// <summary>Field number for the "base_level" field.</summary>
    public const int BaseLevelFieldNumber = 4;
    private int baseLevel_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int BaseLevel {
      get { return baseLevel_; }
      set {
        baseLevel_ = value;
      }
    }

    /// <summary>Field number for the "u5" field.</summary>
    public const int U5FieldNumber = 5;
    private int u5_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int U5 {
      get { return u5_; }
      set {
        u5_ = value;
      }
    }

    /// <summary>Field number for the "battle_bgm_id" field.</summary>
    public const int BattleBgmIdFieldNumber = 6;
    private string battleBgmId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string BattleBgmId {
      get { return battleBgmId_; }
      set {
        battleBgmId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "result_bgm_id" field.</summary>
    public const int ResultBgmIdFieldNumber = 7;
    private string resultBgmId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResultBgmId {
      get { return resultBgmId_; }
      set {
        resultBgmId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "u8" field.</summary>
    public const int U8FieldNumber = 8;
    private int u8_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int U8 {
      get { return u8_; }
      set {
        u8_ = value;
      }
    }

    /// <summary>Field number for the "u9" field.</summary>
    public const int U9FieldNumber = 9;
    private int u9_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int U9 {
      get { return u9_; }
      set {
        u9_ = value;
      }
    }

    /// <summary>Field number for the "u10" field.</summary>
    public const int U10FieldNumber = 10;
    private int u10_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int U10 {
      get { return u10_; }
      set {
        u10_ = value;
      }
    }

    /// <summary>Field number for the "u11" field.</summary>
    public const int U11FieldNumber = 11;
    private int u11_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int U11 {
      get { return u11_; }
      set {
        u11_ = value;
      }
    }

    /// <summary>Field number for the "deck_preset_group_id" field.</summary>
    public const int DeckPresetGroupIdFieldNumber = 12;
    private int deckPresetGroupId_;
    /// <summary>
    /// DeckPresetGroup.pb
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int DeckPresetGroupId {
      get { return deckPresetGroupId_; }
      set {
        deckPresetGroupId_ = value;
      }
    }

    /// <summary>Field number for the "u13" field.</summary>
    public const int U13FieldNumber = 13;
    private int u13_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int U13 {
      get { return u13_; }
      set {
        u13_ = value;
      }
    }

    /// <summary>Field number for the "u14" field.</summary>
    public const int U14FieldNumber = 14;
    private int u14_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int U14 {
      get { return u14_; }
      set {
        u14_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Battle);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Battle other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (BattleId != other.BattleId) return false;
      if (BattleParameterId != other.BattleParameterId) return false;
      if (BattleRewardId != other.BattleRewardId) return false;
      if (BaseLevel != other.BaseLevel) return false;
      if (U5 != other.U5) return false;
      if (BattleBgmId != other.BattleBgmId) return false;
      if (ResultBgmId != other.ResultBgmId) return false;
      if (U8 != other.U8) return false;
      if (U9 != other.U9) return false;
      if (U10 != other.U10) return false;
      if (U11 != other.U11) return false;
      if (DeckPresetGroupId != other.DeckPresetGroupId) return false;
      if (U13 != other.U13) return false;
      if (U14 != other.U14) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (BattleId != 0L) hash ^= BattleId.GetHashCode();
      if (BattleParameterId != 0) hash ^= BattleParameterId.GetHashCode();
      if (BattleRewardId != 0) hash ^= BattleRewardId.GetHashCode();
      if (BaseLevel != 0) hash ^= BaseLevel.GetHashCode();
      if (U5 != 0) hash ^= U5.GetHashCode();
      if (BattleBgmId.Length != 0) hash ^= BattleBgmId.GetHashCode();
      if (ResultBgmId.Length != 0) hash ^= ResultBgmId.GetHashCode();
      if (U8 != 0) hash ^= U8.GetHashCode();
      if (U9 != 0) hash ^= U9.GetHashCode();
      if (U10 != 0) hash ^= U10.GetHashCode();
      if (U11 != 0) hash ^= U11.GetHashCode();
      if (DeckPresetGroupId != 0) hash ^= DeckPresetGroupId.GetHashCode();
      if (U13 != 0) hash ^= U13.GetHashCode();
      if (U14 != 0) hash ^= U14.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (BattleId != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(BattleId);
      }
      if (BattleParameterId != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(BattleParameterId);
      }
      if (BattleRewardId != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(BattleRewardId);
      }
      if (BaseLevel != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(BaseLevel);
      }
      if (U5 != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(U5);
      }
      if (BattleBgmId.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(BattleBgmId);
      }
      if (ResultBgmId.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(ResultBgmId);
      }
      if (U8 != 0) {
        output.WriteRawTag(64);
        output.WriteInt32(U8);
      }
      if (U9 != 0) {
        output.WriteRawTag(72);
        output.WriteInt32(U9);
      }
      if (U10 != 0) {
        output.WriteRawTag(80);
        output.WriteInt32(U10);
      }
      if (U11 != 0) {
        output.WriteRawTag(88);
        output.WriteInt32(U11);
      }
      if (DeckPresetGroupId != 0) {
        output.WriteRawTag(96);
        output.WriteInt32(DeckPresetGroupId);
      }
      if (U13 != 0) {
        output.WriteRawTag(104);
        output.WriteInt32(U13);
      }
      if (U14 != 0) {
        output.WriteRawTag(112);
        output.WriteInt32(U14);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (BattleId != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(BattleId);
      }
      if (BattleParameterId != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(BattleParameterId);
      }
      if (BattleRewardId != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(BattleRewardId);
      }
      if (BaseLevel != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(BaseLevel);
      }
      if (U5 != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(U5);
      }
      if (BattleBgmId.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(BattleBgmId);
      }
      if (ResultBgmId.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(ResultBgmId);
      }
      if (U8 != 0) {
        output.WriteRawTag(64);
        output.WriteInt32(U8);
      }
      if (U9 != 0) {
        output.WriteRawTag(72);
        output.WriteInt32(U9);
      }
      if (U10 != 0) {
        output.WriteRawTag(80);
        output.WriteInt32(U10);
      }
      if (U11 != 0) {
        output.WriteRawTag(88);
        output.WriteInt32(U11);
      }
      if (DeckPresetGroupId != 0) {
        output.WriteRawTag(96);
        output.WriteInt32(DeckPresetGroupId);
      }
      if (U13 != 0) {
        output.WriteRawTag(104);
        output.WriteInt32(U13);
      }
      if (U14 != 0) {
        output.WriteRawTag(112);
        output.WriteInt32(U14);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (BattleId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(BattleId);
      }
      if (BattleParameterId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(BattleParameterId);
      }
      if (BattleRewardId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(BattleRewardId);
      }
      if (BaseLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(BaseLevel);
      }
      if (U5 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(U5);
      }
      if (BattleBgmId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(BattleBgmId);
      }
      if (ResultBgmId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResultBgmId);
      }
      if (U8 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(U8);
      }
      if (U9 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(U9);
      }
      if (U10 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(U10);
      }
      if (U11 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(U11);
      }
      if (DeckPresetGroupId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(DeckPresetGroupId);
      }
      if (U13 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(U13);
      }
      if (U14 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(U14);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Battle other) {
      if (other == null) {
        return;
      }
      if (other.BattleId != 0L) {
        BattleId = other.BattleId;
      }
      if (other.BattleParameterId != 0) {
        BattleParameterId = other.BattleParameterId;
      }
      if (other.BattleRewardId != 0) {
        BattleRewardId = other.BattleRewardId;
      }
      if (other.BaseLevel != 0) {
        BaseLevel = other.BaseLevel;
      }
      if (other.U5 != 0) {
        U5 = other.U5;
      }
      if (other.BattleBgmId.Length != 0) {
        BattleBgmId = other.BattleBgmId;
      }
      if (other.ResultBgmId.Length != 0) {
        ResultBgmId = other.ResultBgmId;
      }
      if (other.U8 != 0) {
        U8 = other.U8;
      }
      if (other.U9 != 0) {
        U9 = other.U9;
      }
      if (other.U10 != 0) {
        U10 = other.U10;
      }
      if (other.U11 != 0) {
        U11 = other.U11;
      }
      if (other.DeckPresetGroupId != 0) {
        DeckPresetGroupId = other.DeckPresetGroupId;
      }
      if (other.U13 != 0) {
        U13 = other.U13;
      }
      if (other.U14 != 0) {
        U14 = other.U14;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            BattleId = input.ReadInt64();
            break;
          }
          case 16: {
            BattleParameterId = input.ReadInt32();
            break;
          }
          case 24: {
            BattleRewardId = input.ReadInt32();
            break;
          }
          case 32: {
            BaseLevel = input.ReadInt32();
            break;
          }
          case 40: {
            U5 = input.ReadInt32();
            break;
          }
          case 50: {
            BattleBgmId = input.ReadString();
            break;
          }
          case 58: {
            ResultBgmId = input.ReadString();
            break;
          }
          case 64: {
            U8 = input.ReadInt32();
            break;
          }
          case 72: {
            U9 = input.ReadInt32();
            break;
          }
          case 80: {
            U10 = input.ReadInt32();
            break;
          }
          case 88: {
            U11 = input.ReadInt32();
            break;
          }
          case 96: {
            DeckPresetGroupId = input.ReadInt32();
            break;
          }
          case 104: {
            U13 = input.ReadInt32();
            break;
          }
          case 112: {
            U14 = input.ReadInt32();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            BattleId = input.ReadInt64();
            break;
          }
          case 16: {
            BattleParameterId = input.ReadInt32();
            break;
          }
          case 24: {
            BattleRewardId = input.ReadInt32();
            break;
          }
          case 32: {
            BaseLevel = input.ReadInt32();
            break;
          }
          case 40: {
            U5 = input.ReadInt32();
            break;
          }
          case 50: {
            BattleBgmId = input.ReadString();
            break;
          }
          case 58: {
            ResultBgmId = input.ReadString();
            break;
          }
          case 64: {
            U8 = input.ReadInt32();
            break;
          }
          case 72: {
            U9 = input.ReadInt32();
            break;
          }
          case 80: {
            U10 = input.ReadInt32();
            break;
          }
          case 88: {
            U11 = input.ReadInt32();
            break;
          }
          case 96: {
            DeckPresetGroupId = input.ReadInt32();
            break;
          }
          case 104: {
            U13 = input.ReadInt32();
            break;
          }
          case 112: {
            U14 = input.ReadInt32();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class BattleTable : pb::IMessage<BattleTable>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BattleTable> _parser = new pb::MessageParser<BattleTable>(() => new BattleTable());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<BattleTable> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ReMastersLib.BattleReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BattleTable() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BattleTable(BattleTable other) : this() {
      entries_ = other.entries_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BattleTable Clone() {
      return new BattleTable(this);
    }

    /// <summary>Field number for the "entries" field.</summary>
    public const int EntriesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::ReMastersLib.Battle> _repeated_entries_codec
        = pb::FieldCodec.ForMessage(10, global::ReMastersLib.Battle.Parser);
    private readonly pbc::RepeatedField<global::ReMastersLib.Battle> entries_ = new pbc::RepeatedField<global::ReMastersLib.Battle>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::ReMastersLib.Battle> Entries {
      get { return entries_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as BattleTable);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(BattleTable other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!entries_.Equals(other.entries_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= entries_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      entries_.WriteTo(output, _repeated_entries_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      entries_.WriteTo(ref output, _repeated_entries_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += entries_.CalculateSize(_repeated_entries_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(BattleTable other) {
      if (other == null) {
        return;
      }
      entries_.Add(other.entries_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            entries_.AddEntriesFrom(input, _repeated_entries_codec);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            entries_.AddEntriesFrom(ref input, _repeated_entries_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
