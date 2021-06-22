// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Proto/Inherit.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace ReMastersLib {

  /// <summary>Holder for reflection information generated from Proto/Inherit.proto</summary>
  public static partial class InheritReflection {

    #region Descriptor
    /// <summary>File descriptor for Proto/Inherit.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static InheritReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNQcm90by9Jbmhlcml0LnByb3RvEgxSZU1hc3RlcnNMaWIiOwoHSW5oZXJp",
            "dBIWCg5xdWVzdF9ncm91cF9pZBgBIAEoBRIMCgRkYXlzGAIgASgFEgoKAnUz",
            "GAMgASgFIjYKDEluaGVyaXRUYWJsZRImCgdlbnRyaWVzGAEgAygLMhUuUmVN",
            "YXN0ZXJzTGliLkluaGVyaXRiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::ReMastersLib.Inherit), global::ReMastersLib.Inherit.Parser, new[]{ "QuestGroupId", "Days", "U3" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ReMastersLib.InheritTable), global::ReMastersLib.InheritTable.Parser, new[]{ "Entries" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Inherit : pb::IMessage<Inherit> {
    private static readonly pb::MessageParser<Inherit> _parser = new pb::MessageParser<Inherit>(() => new Inherit());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Inherit> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ReMastersLib.InheritReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Inherit() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Inherit(Inherit other) : this() {
      questGroupId_ = other.questGroupId_;
      days_ = other.days_;
      u3_ = other.u3_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Inherit Clone() {
      return new Inherit(this);
    }

    /// <summary>Field number for the "quest_group_id" field.</summary>
    public const int QuestGroupIdFieldNumber = 1;
    private int questGroupId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int QuestGroupId {
      get { return questGroupId_; }
      set {
        questGroupId_ = value;
      }
    }

    /// <summary>Field number for the "days" field.</summary>
    public const int DaysFieldNumber = 2;
    private int days_;
    /// <summary>
    /// days before the quest are automatically reset
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Days {
      get { return days_; }
      set {
        days_ = value;
      }
    }

    /// <summary>Field number for the "u3" field.</summary>
    public const int U3FieldNumber = 3;
    private int u3_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int U3 {
      get { return u3_; }
      set {
        u3_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Inherit);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Inherit other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (QuestGroupId != other.QuestGroupId) return false;
      if (Days != other.Days) return false;
      if (U3 != other.U3) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (QuestGroupId != 0) hash ^= QuestGroupId.GetHashCode();
      if (Days != 0) hash ^= Days.GetHashCode();
      if (U3 != 0) hash ^= U3.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (QuestGroupId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(QuestGroupId);
      }
      if (Days != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Days);
      }
      if (U3 != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(U3);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (QuestGroupId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(QuestGroupId);
      }
      if (Days != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Days);
      }
      if (U3 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(U3);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Inherit other) {
      if (other == null) {
        return;
      }
      if (other.QuestGroupId != 0) {
        QuestGroupId = other.QuestGroupId;
      }
      if (other.Days != 0) {
        Days = other.Days;
      }
      if (other.U3 != 0) {
        U3 = other.U3;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            QuestGroupId = input.ReadInt32();
            break;
          }
          case 16: {
            Days = input.ReadInt32();
            break;
          }
          case 24: {
            U3 = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class InheritTable : pb::IMessage<InheritTable> {
    private static readonly pb::MessageParser<InheritTable> _parser = new pb::MessageParser<InheritTable>(() => new InheritTable());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<InheritTable> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ReMastersLib.InheritReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InheritTable() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InheritTable(InheritTable other) : this() {
      entries_ = other.entries_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InheritTable Clone() {
      return new InheritTable(this);
    }

    /// <summary>Field number for the "entries" field.</summary>
    public const int EntriesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::ReMastersLib.Inherit> _repeated_entries_codec
        = pb::FieldCodec.ForMessage(10, global::ReMastersLib.Inherit.Parser);
    private readonly pbc::RepeatedField<global::ReMastersLib.Inherit> entries_ = new pbc::RepeatedField<global::ReMastersLib.Inherit>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::ReMastersLib.Inherit> Entries {
      get { return entries_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as InheritTable);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(InheritTable other) {
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
    public override int GetHashCode() {
      int hash = 1;
      hash ^= entries_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      entries_.WriteTo(output, _repeated_entries_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += entries_.CalculateSize(_repeated_entries_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(InheritTable other) {
      if (other == null) {
        return;
      }
      entries_.Add(other.entries_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
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
    }

  }

  #endregion

}

#endregion Designer generated code