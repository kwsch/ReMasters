// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Proto/ScoutUnitRate.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace ReMastersLib {

  /// <summary>Holder for reflection information generated from Proto/ScoutUnitRate.proto</summary>
  public static partial class ScoutUnitRateReflection {

    #region Descriptor
    /// <summary>File descriptor for Proto/ScoutUnitRate.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ScoutUnitRateReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlQcm90by9TY291dFVuaXRSYXRlLnByb3RvEgxSZU1hc3RlcnNMaWIibQoN",
            "U2NvdXRVbml0UmF0ZRISCgpzY291dF9uYW1lGAEgASgJEhIKCnRyYWluZXJf",
            "aWQYAiABKAQSEQoJZHJvcF9yYXRlGAMgASgNEhUKDWRpc3BsYXlfb3JkZXIY",
            "BCABKA0SCgoCdTUYBSABKA0iQgoSU2NvdXRVbml0UmF0ZVRhYmxlEiwKB2Vu",
            "dHJpZXMYASADKAsyGy5SZU1hc3RlcnNMaWIuU2NvdXRVbml0UmF0ZWIGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::ReMastersLib.ScoutUnitRate), global::ReMastersLib.ScoutUnitRate.Parser, new[]{ "ScoutName", "TrainerId", "DropRate", "DisplayOrder", "U5" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ReMastersLib.ScoutUnitRateTable), global::ReMastersLib.ScoutUnitRateTable.Parser, new[]{ "Entries" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ScoutUnitRate : pb::IMessage<ScoutUnitRate>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ScoutUnitRate> _parser = new pb::MessageParser<ScoutUnitRate>(() => new ScoutUnitRate());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ScoutUnitRate> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ReMastersLib.ScoutUnitRateReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ScoutUnitRate() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ScoutUnitRate(ScoutUnitRate other) : this() {
      scoutName_ = other.scoutName_;
      trainerId_ = other.trainerId_;
      dropRate_ = other.dropRate_;
      displayOrder_ = other.displayOrder_;
      u5_ = other.u5_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ScoutUnitRate Clone() {
      return new ScoutUnitRate(this);
    }

    /// <summary>Field number for the "scout_name" field.</summary>
    public const int ScoutNameFieldNumber = 1;
    private string scoutName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ScoutName {
      get { return scoutName_; }
      set {
        scoutName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "trainer_id" field.</summary>
    public const int TrainerIdFieldNumber = 2;
    private ulong trainerId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong TrainerId {
      get { return trainerId_; }
      set {
        trainerId_ = value;
      }
    }

    /// <summary>Field number for the "drop_rate" field.</summary>
    public const int DropRateFieldNumber = 3;
    private uint dropRate_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DropRate {
      get { return dropRate_; }
      set {
        dropRate_ = value;
      }
    }

    /// <summary>Field number for the "display_order" field.</summary>
    public const int DisplayOrderFieldNumber = 4;
    private uint displayOrder_;
    /// <summary>
    /// the greater this value is, the higher
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DisplayOrder {
      get { return displayOrder_; }
      set {
        displayOrder_ = value;
      }
    }

    /// <summary>Field number for the "u5" field.</summary>
    public const int U5FieldNumber = 5;
    private uint u5_;
    /// <summary>
    /// 1 for Christmas Rosa/Siebold in their banners
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint U5 {
      get { return u5_; }
      set {
        u5_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ScoutUnitRate);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ScoutUnitRate other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ScoutName != other.ScoutName) return false;
      if (TrainerId != other.TrainerId) return false;
      if (DropRate != other.DropRate) return false;
      if (DisplayOrder != other.DisplayOrder) return false;
      if (U5 != other.U5) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ScoutName.Length != 0) hash ^= ScoutName.GetHashCode();
      if (TrainerId != 0UL) hash ^= TrainerId.GetHashCode();
      if (DropRate != 0) hash ^= DropRate.GetHashCode();
      if (DisplayOrder != 0) hash ^= DisplayOrder.GetHashCode();
      if (U5 != 0) hash ^= U5.GetHashCode();
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
      if (ScoutName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ScoutName);
      }
      if (TrainerId != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(TrainerId);
      }
      if (DropRate != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(DropRate);
      }
      if (DisplayOrder != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(DisplayOrder);
      }
      if (U5 != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(U5);
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
      if (ScoutName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ScoutName);
      }
      if (TrainerId != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(TrainerId);
      }
      if (DropRate != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(DropRate);
      }
      if (DisplayOrder != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(DisplayOrder);
      }
      if (U5 != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(U5);
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
      if (ScoutName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ScoutName);
      }
      if (TrainerId != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(TrainerId);
      }
      if (DropRate != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DropRate);
      }
      if (DisplayOrder != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(DisplayOrder);
      }
      if (U5 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(U5);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ScoutUnitRate other) {
      if (other == null) {
        return;
      }
      if (other.ScoutName.Length != 0) {
        ScoutName = other.ScoutName;
      }
      if (other.TrainerId != 0UL) {
        TrainerId = other.TrainerId;
      }
      if (other.DropRate != 0) {
        DropRate = other.DropRate;
      }
      if (other.DisplayOrder != 0) {
        DisplayOrder = other.DisplayOrder;
      }
      if (other.U5 != 0) {
        U5 = other.U5;
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
          case 10: {
            ScoutName = input.ReadString();
            break;
          }
          case 16: {
            TrainerId = input.ReadUInt64();
            break;
          }
          case 24: {
            DropRate = input.ReadUInt32();
            break;
          }
          case 32: {
            DisplayOrder = input.ReadUInt32();
            break;
          }
          case 40: {
            U5 = input.ReadUInt32();
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
            ScoutName = input.ReadString();
            break;
          }
          case 16: {
            TrainerId = input.ReadUInt64();
            break;
          }
          case 24: {
            DropRate = input.ReadUInt32();
            break;
          }
          case 32: {
            DisplayOrder = input.ReadUInt32();
            break;
          }
          case 40: {
            U5 = input.ReadUInt32();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class ScoutUnitRateTable : pb::IMessage<ScoutUnitRateTable>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ScoutUnitRateTable> _parser = new pb::MessageParser<ScoutUnitRateTable>(() => new ScoutUnitRateTable());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ScoutUnitRateTable> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ReMastersLib.ScoutUnitRateReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ScoutUnitRateTable() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ScoutUnitRateTable(ScoutUnitRateTable other) : this() {
      entries_ = other.entries_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ScoutUnitRateTable Clone() {
      return new ScoutUnitRateTable(this);
    }

    /// <summary>Field number for the "entries" field.</summary>
    public const int EntriesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::ReMastersLib.ScoutUnitRate> _repeated_entries_codec
        = pb::FieldCodec.ForMessage(10, global::ReMastersLib.ScoutUnitRate.Parser);
    private readonly pbc::RepeatedField<global::ReMastersLib.ScoutUnitRate> entries_ = new pbc::RepeatedField<global::ReMastersLib.ScoutUnitRate>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::ReMastersLib.ScoutUnitRate> Entries {
      get { return entries_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ScoutUnitRateTable);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ScoutUnitRateTable other) {
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
    public void MergeFrom(ScoutUnitRateTable other) {
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