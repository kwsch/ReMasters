// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Proto/MonsterBase.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace ReMastersLib {

  /// <summary>Holder for reflection information generated from Proto/MonsterBase.proto</summary>
  public static partial class MonsterBaseReflection {

    #region Descriptor
    /// <summary>File descriptor for Proto/MonsterBase.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MonsterBaseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdQcm90by9Nb25zdGVyQmFzZS5wcm90bxIMUmVNYXN0ZXJzTGliIo0CCgtN",
            "b25zdGVyQmFzZRIXCg9tb25zdGVyX2Jhc2VfaWQYASABKAUSEAoIYWN0b3Jf",
            "aWQYAiABKAkSFAoMYWN0b3JfbnVtYmVyGAMgASgFEhUKDWFjdG9yX3Zhcmlh",
            "bnQYBCABKAUSCgoCdTUYBSABKAUSDwoHanBfbmFtZRgGIAEoCRIKCgJ1NxgH",
            "IAEoBRIOCgZnZW5kZXIYCCABKAUSCgoCdTkYCSABKAUSEAoIc3RyZW5ndGgY",
            "CiABKAUSCwoDdTExGAsgASgFEhcKD2Zvcm1fcGFzc2l2ZV9pZBgMIAEoBRIL",
            "CgN1MTMYDSABKAUSCwoDdTE0GA4gASgFEg8KB2Zvcm1faWQYDyABKAUiPgoQ",
            "TW9uc3RlckJhc2VUYWJsZRIqCgdlbnRyaWVzGAEgAygLMhkuUmVNYXN0ZXJz",
            "TGliLk1vbnN0ZXJCYXNlYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::ReMastersLib.MonsterBase), global::ReMastersLib.MonsterBase.Parser, new[]{ "MonsterBaseId", "ActorId", "ActorNumber", "ActorVariant", "U5", "JpName", "U7", "Gender", "U9", "Strength", "U11", "FormPassiveId", "U13", "U14", "FormId" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ReMastersLib.MonsterBaseTable), global::ReMastersLib.MonsterBaseTable.Parser, new[]{ "Entries" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class MonsterBase : pb::IMessage<MonsterBase> {
    private static readonly pb::MessageParser<MonsterBase> _parser = new pb::MessageParser<MonsterBase>(() => new MonsterBase());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MonsterBase> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ReMastersLib.MonsterBaseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MonsterBase() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MonsterBase(MonsterBase other) : this() {
      monsterBaseId_ = other.monsterBaseId_;
      actorId_ = other.actorId_;
      actorNumber_ = other.actorNumber_;
      actorVariant_ = other.actorVariant_;
      u5_ = other.u5_;
      jpName_ = other.jpName_;
      u7_ = other.u7_;
      gender_ = other.gender_;
      u9_ = other.u9_;
      strength_ = other.strength_;
      u11_ = other.u11_;
      formPassiveId_ = other.formPassiveId_;
      u13_ = other.u13_;
      u14_ = other.u14_;
      formId_ = other.formId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MonsterBase Clone() {
      return new MonsterBase(this);
    }

    /// <summary>Field number for the "monster_base_id" field.</summary>
    public const int MonsterBaseIdFieldNumber = 1;
    private int monsterBaseId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int MonsterBaseId {
      get { return monsterBaseId_; }
      set {
        monsterBaseId_ = value;
      }
    }

    /// <summary>Field number for the "actor_id" field.</summary>
    public const int ActorIdFieldNumber = 2;
    private string actorId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ActorId {
      get { return actorId_; }
      set {
        actorId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "actor_number" field.</summary>
    public const int ActorNumberFieldNumber = 3;
    private int actorNumber_;
    /// <summary>
    /// not actual dex numbers for Gen 6/7
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ActorNumber {
      get { return actorNumber_; }
      set {
        actorNumber_ = value;
      }
    }

    /// <summary>Field number for the "actor_variant" field.</summary>
    public const int ActorVariantFieldNumber = 4;
    private int actorVariant_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ActorVariant {
      get { return actorVariant_; }
      set {
        actorVariant_ = value;
      }
    }

    /// <summary>Field number for the "u5" field.</summary>
    public const int U5FieldNumber = 5;
    private int u5_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int U5 {
      get { return u5_; }
      set {
        u5_ = value;
      }
    }

    /// <summary>Field number for the "jp_name" field.</summary>
    public const int JpNameFieldNumber = 6;
    private string jpName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string JpName {
      get { return jpName_; }
      set {
        jpName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "u7" field.</summary>
    public const int U7FieldNumber = 7;
    private int u7_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int U7 {
      get { return u7_; }
      set {
        u7_ = value;
      }
    }

    /// <summary>Field number for the "gender" field.</summary>
    public const int GenderFieldNumber = 8;
    private int gender_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Gender {
      get { return gender_; }
      set {
        gender_ = value;
      }
    }

    /// <summary>Field number for the "u9" field.</summary>
    public const int U9FieldNumber = 9;
    private int u9_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int U9 {
      get { return u9_; }
      set {
        u9_ = value;
      }
    }

    /// <summary>Field number for the "strength" field.</summary>
    public const int StrengthFieldNumber = 10;
    private int strength_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Strength {
      get { return strength_; }
      set {
        strength_ = value;
      }
    }

    /// <summary>Field number for the "u11" field.</summary>
    public const int U11FieldNumber = 11;
    private int u11_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int U11 {
      get { return u11_; }
      set {
        u11_ = value;
      }
    }

    /// <summary>Field number for the "form_passive_id" field.</summary>
    public const int FormPassiveIdFieldNumber = 12;
    private int formPassiveId_;
    /// <summary>
    /// If this passive is set, the game displays it above the others
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int FormPassiveId {
      get { return formPassiveId_; }
      set {
        formPassiveId_ = value;
      }
    }

    /// <summary>Field number for the "u13" field.</summary>
    public const int U13FieldNumber = 13;
    private int u13_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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
    public int U14 {
      get { return u14_; }
      set {
        u14_ = value;
      }
    }

    /// <summary>Field number for the "form_id" field.</summary>
    public const int FormIdFieldNumber = 15;
    private int formId_;
    /// <summary>
    /// monster_form_xx.json
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int FormId {
      get { return formId_; }
      set {
        formId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MonsterBase);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MonsterBase other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MonsterBaseId != other.MonsterBaseId) return false;
      if (ActorId != other.ActorId) return false;
      if (ActorNumber != other.ActorNumber) return false;
      if (ActorVariant != other.ActorVariant) return false;
      if (U5 != other.U5) return false;
      if (JpName != other.JpName) return false;
      if (U7 != other.U7) return false;
      if (Gender != other.Gender) return false;
      if (U9 != other.U9) return false;
      if (Strength != other.Strength) return false;
      if (U11 != other.U11) return false;
      if (FormPassiveId != other.FormPassiveId) return false;
      if (U13 != other.U13) return false;
      if (U14 != other.U14) return false;
      if (FormId != other.FormId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (MonsterBaseId != 0) hash ^= MonsterBaseId.GetHashCode();
      if (ActorId.Length != 0) hash ^= ActorId.GetHashCode();
      if (ActorNumber != 0) hash ^= ActorNumber.GetHashCode();
      if (ActorVariant != 0) hash ^= ActorVariant.GetHashCode();
      if (U5 != 0) hash ^= U5.GetHashCode();
      if (JpName.Length != 0) hash ^= JpName.GetHashCode();
      if (U7 != 0) hash ^= U7.GetHashCode();
      if (Gender != 0) hash ^= Gender.GetHashCode();
      if (U9 != 0) hash ^= U9.GetHashCode();
      if (Strength != 0) hash ^= Strength.GetHashCode();
      if (U11 != 0) hash ^= U11.GetHashCode();
      if (FormPassiveId != 0) hash ^= FormPassiveId.GetHashCode();
      if (U13 != 0) hash ^= U13.GetHashCode();
      if (U14 != 0) hash ^= U14.GetHashCode();
      if (FormId != 0) hash ^= FormId.GetHashCode();
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
      if (MonsterBaseId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(MonsterBaseId);
      }
      if (ActorId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(ActorId);
      }
      if (ActorNumber != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(ActorNumber);
      }
      if (ActorVariant != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(ActorVariant);
      }
      if (U5 != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(U5);
      }
      if (JpName.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(JpName);
      }
      if (U7 != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(U7);
      }
      if (Gender != 0) {
        output.WriteRawTag(64);
        output.WriteInt32(Gender);
      }
      if (U9 != 0) {
        output.WriteRawTag(72);
        output.WriteInt32(U9);
      }
      if (Strength != 0) {
        output.WriteRawTag(80);
        output.WriteInt32(Strength);
      }
      if (U11 != 0) {
        output.WriteRawTag(88);
        output.WriteInt32(U11);
      }
      if (FormPassiveId != 0) {
        output.WriteRawTag(96);
        output.WriteInt32(FormPassiveId);
      }
      if (U13 != 0) {
        output.WriteRawTag(104);
        output.WriteInt32(U13);
      }
      if (U14 != 0) {
        output.WriteRawTag(112);
        output.WriteInt32(U14);
      }
      if (FormId != 0) {
        output.WriteRawTag(120);
        output.WriteInt32(FormId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (MonsterBaseId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MonsterBaseId);
      }
      if (ActorId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ActorId);
      }
      if (ActorNumber != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ActorNumber);
      }
      if (ActorVariant != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ActorVariant);
      }
      if (U5 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(U5);
      }
      if (JpName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(JpName);
      }
      if (U7 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(U7);
      }
      if (Gender != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Gender);
      }
      if (U9 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(U9);
      }
      if (Strength != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Strength);
      }
      if (U11 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(U11);
      }
      if (FormPassiveId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(FormPassiveId);
      }
      if (U13 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(U13);
      }
      if (U14 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(U14);
      }
      if (FormId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(FormId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MonsterBase other) {
      if (other == null) {
        return;
      }
      if (other.MonsterBaseId != 0) {
        MonsterBaseId = other.MonsterBaseId;
      }
      if (other.ActorId.Length != 0) {
        ActorId = other.ActorId;
      }
      if (other.ActorNumber != 0) {
        ActorNumber = other.ActorNumber;
      }
      if (other.ActorVariant != 0) {
        ActorVariant = other.ActorVariant;
      }
      if (other.U5 != 0) {
        U5 = other.U5;
      }
      if (other.JpName.Length != 0) {
        JpName = other.JpName;
      }
      if (other.U7 != 0) {
        U7 = other.U7;
      }
      if (other.Gender != 0) {
        Gender = other.Gender;
      }
      if (other.U9 != 0) {
        U9 = other.U9;
      }
      if (other.Strength != 0) {
        Strength = other.Strength;
      }
      if (other.U11 != 0) {
        U11 = other.U11;
      }
      if (other.FormPassiveId != 0) {
        FormPassiveId = other.FormPassiveId;
      }
      if (other.U13 != 0) {
        U13 = other.U13;
      }
      if (other.U14 != 0) {
        U14 = other.U14;
      }
      if (other.FormId != 0) {
        FormId = other.FormId;
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
            MonsterBaseId = input.ReadInt32();
            break;
          }
          case 18: {
            ActorId = input.ReadString();
            break;
          }
          case 24: {
            ActorNumber = input.ReadInt32();
            break;
          }
          case 32: {
            ActorVariant = input.ReadInt32();
            break;
          }
          case 40: {
            U5 = input.ReadInt32();
            break;
          }
          case 50: {
            JpName = input.ReadString();
            break;
          }
          case 56: {
            U7 = input.ReadInt32();
            break;
          }
          case 64: {
            Gender = input.ReadInt32();
            break;
          }
          case 72: {
            U9 = input.ReadInt32();
            break;
          }
          case 80: {
            Strength = input.ReadInt32();
            break;
          }
          case 88: {
            U11 = input.ReadInt32();
            break;
          }
          case 96: {
            FormPassiveId = input.ReadInt32();
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
          case 120: {
            FormId = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class MonsterBaseTable : pb::IMessage<MonsterBaseTable> {
    private static readonly pb::MessageParser<MonsterBaseTable> _parser = new pb::MessageParser<MonsterBaseTable>(() => new MonsterBaseTable());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MonsterBaseTable> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ReMastersLib.MonsterBaseReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MonsterBaseTable() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MonsterBaseTable(MonsterBaseTable other) : this() {
      entries_ = other.entries_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MonsterBaseTable Clone() {
      return new MonsterBaseTable(this);
    }

    /// <summary>Field number for the "entries" field.</summary>
    public const int EntriesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::ReMastersLib.MonsterBase> _repeated_entries_codec
        = pb::FieldCodec.ForMessage(10, global::ReMastersLib.MonsterBase.Parser);
    private readonly pbc::RepeatedField<global::ReMastersLib.MonsterBase> entries_ = new pbc::RepeatedField<global::ReMastersLib.MonsterBase>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::ReMastersLib.MonsterBase> Entries {
      get { return entries_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MonsterBaseTable);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MonsterBaseTable other) {
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
    public void MergeFrom(MonsterBaseTable other) {
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
