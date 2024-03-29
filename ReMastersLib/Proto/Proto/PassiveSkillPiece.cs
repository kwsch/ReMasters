// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Proto/PassiveSkillPiece.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace ReMastersLib {

  /// <summary>Holder for reflection information generated from Proto/PassiveSkillPiece.proto</summary>
  public static partial class PassiveSkillPieceReflection {

    #region Descriptor
    /// <summary>File descriptor for Proto/PassiveSkillPiece.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PassiveSkillPieceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1Qcm90by9QYXNzaXZlU2tpbGxQaWVjZS5wcm90bxIMUmVNYXN0ZXJzTGli",
            "IogBChFQYXNzaXZlU2tpbGxQaWVjZRISCgpwYXNzaXZlX2lkGAEgASgFEgoK",
            "AnUyGAIgASgFEgoKAnU0GAQgASgFEgoKAnU1GAUgASgFEgoKAnU2GAYgASgF",
            "EgoKAnU3GAcgASgFEgoKAnU4GAggASgFEgoKAnU5GAkgASgFEgsKA3UxMBgK",
            "IAEoBSJKChZQYXNzaXZlU2tpbGxQaWVjZVRhYmxlEjAKB2VudHJpZXMYASAD",
            "KAsyHy5SZU1hc3RlcnNMaWIuUGFzc2l2ZVNraWxsUGllY2ViBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::ReMastersLib.PassiveSkillPiece), global::ReMastersLib.PassiveSkillPiece.Parser, new[]{ "PassiveId", "U2", "U4", "U5", "U6", "U7", "U8", "U9", "U10" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ReMastersLib.PassiveSkillPieceTable), global::ReMastersLib.PassiveSkillPieceTable.Parser, new[]{ "Entries" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PassiveSkillPiece : pb::IMessage<PassiveSkillPiece>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PassiveSkillPiece> _parser = new pb::MessageParser<PassiveSkillPiece>(() => new PassiveSkillPiece());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PassiveSkillPiece> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ReMastersLib.PassiveSkillPieceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PassiveSkillPiece() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PassiveSkillPiece(PassiveSkillPiece other) : this() {
      passiveId_ = other.passiveId_;
      u2_ = other.u2_;
      u4_ = other.u4_;
      u5_ = other.u5_;
      u6_ = other.u6_;
      u7_ = other.u7_;
      u8_ = other.u8_;
      u9_ = other.u9_;
      u10_ = other.u10_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PassiveSkillPiece Clone() {
      return new PassiveSkillPiece(this);
    }

    /// <summary>Field number for the "passive_id" field.</summary>
    public const int PassiveIdFieldNumber = 1;
    private int passiveId_;
    /// <summary>
    /// passive_skill_name_xx.lsd / passive_skill_description_xx.lsd
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int PassiveId {
      get { return passiveId_; }
      set {
        passiveId_ = value;
      }
    }

    /// <summary>Field number for the "u2" field.</summary>
    public const int U2FieldNumber = 2;
    private int u2_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int U2 {
      get { return u2_; }
      set {
        u2_ = value;
      }
    }

    /// <summary>Field number for the "u4" field.</summary>
    public const int U4FieldNumber = 4;
    private int u4_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int U4 {
      get { return u4_; }
      set {
        u4_ = value;
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

    /// <summary>Field number for the "u6" field.</summary>
    public const int U6FieldNumber = 6;
    private int u6_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int U6 {
      get { return u6_; }
      set {
        u6_ = value;
      }
    }

    /// <summary>Field number for the "u7" field.</summary>
    public const int U7FieldNumber = 7;
    private int u7_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int U7 {
      get { return u7_; }
      set {
        u7_ = value;
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

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PassiveSkillPiece);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PassiveSkillPiece other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PassiveId != other.PassiveId) return false;
      if (U2 != other.U2) return false;
      if (U4 != other.U4) return false;
      if (U5 != other.U5) return false;
      if (U6 != other.U6) return false;
      if (U7 != other.U7) return false;
      if (U8 != other.U8) return false;
      if (U9 != other.U9) return false;
      if (U10 != other.U10) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (PassiveId != 0) hash ^= PassiveId.GetHashCode();
      if (U2 != 0) hash ^= U2.GetHashCode();
      if (U4 != 0) hash ^= U4.GetHashCode();
      if (U5 != 0) hash ^= U5.GetHashCode();
      if (U6 != 0) hash ^= U6.GetHashCode();
      if (U7 != 0) hash ^= U7.GetHashCode();
      if (U8 != 0) hash ^= U8.GetHashCode();
      if (U9 != 0) hash ^= U9.GetHashCode();
      if (U10 != 0) hash ^= U10.GetHashCode();
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
      if (PassiveId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(PassiveId);
      }
      if (U2 != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(U2);
      }
      if (U4 != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(U4);
      }
      if (U5 != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(U5);
      }
      if (U6 != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(U6);
      }
      if (U7 != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(U7);
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
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (PassiveId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(PassiveId);
      }
      if (U2 != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(U2);
      }
      if (U4 != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(U4);
      }
      if (U5 != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(U5);
      }
      if (U6 != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(U6);
      }
      if (U7 != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(U7);
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
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (PassiveId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(PassiveId);
      }
      if (U2 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(U2);
      }
      if (U4 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(U4);
      }
      if (U5 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(U5);
      }
      if (U6 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(U6);
      }
      if (U7 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(U7);
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
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PassiveSkillPiece other) {
      if (other == null) {
        return;
      }
      if (other.PassiveId != 0) {
        PassiveId = other.PassiveId;
      }
      if (other.U2 != 0) {
        U2 = other.U2;
      }
      if (other.U4 != 0) {
        U4 = other.U4;
      }
      if (other.U5 != 0) {
        U5 = other.U5;
      }
      if (other.U6 != 0) {
        U6 = other.U6;
      }
      if (other.U7 != 0) {
        U7 = other.U7;
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
            PassiveId = input.ReadInt32();
            break;
          }
          case 16: {
            U2 = input.ReadInt32();
            break;
          }
          case 32: {
            U4 = input.ReadInt32();
            break;
          }
          case 40: {
            U5 = input.ReadInt32();
            break;
          }
          case 48: {
            U6 = input.ReadInt32();
            break;
          }
          case 56: {
            U7 = input.ReadInt32();
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
            PassiveId = input.ReadInt32();
            break;
          }
          case 16: {
            U2 = input.ReadInt32();
            break;
          }
          case 32: {
            U4 = input.ReadInt32();
            break;
          }
          case 40: {
            U5 = input.ReadInt32();
            break;
          }
          case 48: {
            U6 = input.ReadInt32();
            break;
          }
          case 56: {
            U7 = input.ReadInt32();
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
        }
      }
    }
    #endif

  }

  public sealed partial class PassiveSkillPieceTable : pb::IMessage<PassiveSkillPieceTable>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PassiveSkillPieceTable> _parser = new pb::MessageParser<PassiveSkillPieceTable>(() => new PassiveSkillPieceTable());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PassiveSkillPieceTable> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ReMastersLib.PassiveSkillPieceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PassiveSkillPieceTable() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PassiveSkillPieceTable(PassiveSkillPieceTable other) : this() {
      entries_ = other.entries_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PassiveSkillPieceTable Clone() {
      return new PassiveSkillPieceTable(this);
    }

    /// <summary>Field number for the "entries" field.</summary>
    public const int EntriesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::ReMastersLib.PassiveSkillPiece> _repeated_entries_codec
        = pb::FieldCodec.ForMessage(10, global::ReMastersLib.PassiveSkillPiece.Parser);
    private readonly pbc::RepeatedField<global::ReMastersLib.PassiveSkillPiece> entries_ = new pbc::RepeatedField<global::ReMastersLib.PassiveSkillPiece>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::ReMastersLib.PassiveSkillPiece> Entries {
      get { return entries_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PassiveSkillPieceTable);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PassiveSkillPieceTable other) {
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
    public void MergeFrom(PassiveSkillPieceTable other) {
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
