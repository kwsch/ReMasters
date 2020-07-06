// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Proto/EggItem.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace ReMastersLib {

  /// <summary>Holder for reflection information generated from Proto/EggItem.proto</summary>
  public static partial class EggItemReflection {

    #region Descriptor
    /// <summary>File descriptor for Proto/EggItem.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EggItemReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNQcm90by9FZ2dJdGVtLnByb3RvEgxSZU1hc3RlcnNMaWIijQEKB0VnZ0l0",
            "ZW0SDwoHaXRlbV9pZBgBIAEoAxIPCgd0ZXh0X2lkGAIgASgFEhAKCGltYWdl",
            "X2lkGAMgASgJEg4KBnJhcml0eRgEIAEoBRIKCgJ1NRgFIAEoBRIKCgJ1NhgG",
            "IAEoBRIYChBlZ2dfbG90X2dyb3VwX2lkGAcgASgFEgwKBHRpbWUYCCABKAUi",
            "NgoMRWdnSXRlbVRhYmxlEiYKB2VudHJpZXMYASADKAsyFS5SZU1hc3RlcnNM",
            "aWIuRWdnSXRlbWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::ReMastersLib.EggItem), global::ReMastersLib.EggItem.Parser, new[]{ "ItemId", "TextId", "ImageId", "Rarity", "U5", "U6", "EggLotGroupId", "Time" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ReMastersLib.EggItemTable), global::ReMastersLib.EggItemTable.Parser, new[]{ "Entries" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class EggItem : pb::IMessage<EggItem> {
    private static readonly pb::MessageParser<EggItem> _parser = new pb::MessageParser<EggItem>(() => new EggItem());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<EggItem> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ReMastersLib.EggItemReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EggItem() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EggItem(EggItem other) : this() {
      itemId_ = other.itemId_;
      textId_ = other.textId_;
      imageId_ = other.imageId_;
      rarity_ = other.rarity_;
      u5_ = other.u5_;
      u6_ = other.u6_;
      eggLotGroupId_ = other.eggLotGroupId_;
      time_ = other.time_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EggItem Clone() {
      return new EggItem(this);
    }

    /// <summary>Field number for the "item_id" field.</summary>
    public const int ItemIdFieldNumber = 1;
    private long itemId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long ItemId {
      get { return itemId_; }
      set {
        itemId_ = value;
      }
    }

    /// <summary>Field number for the "text_id" field.</summary>
    public const int TextIdFieldNumber = 2;
    private int textId_;
    /// <summary>
    /// egg_item_description_xx.lsd
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int TextId {
      get { return textId_; }
      set {
        textId_ = value;
      }
    }

    /// <summary>Field number for the "image_id" field.</summary>
    public const int ImageIdFieldNumber = 3;
    private string imageId_ = "";
    /// <summary>
    /// ui/image/Item
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ImageId {
      get { return imageId_; }
      set {
        imageId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "rarity" field.</summary>
    public const int RarityFieldNumber = 4;
    private int rarity_;
    /// <summary>
    /// egg_item_name_xx.lsd
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Rarity {
      get { return rarity_; }
      set {
        rarity_ = value;
      }
    }

    /// <summary>Field number for the "u5" field.</summary>
    public const int U5FieldNumber = 5;
    private int u5_;
    /// <summary>
    /// type?
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int U5 {
      get { return u5_; }
      set {
        u5_ = value;
      }
    }

    /// <summary>Field number for the "u6" field.</summary>
    public const int U6FieldNumber = 6;
    private int u6_;
    /// <summary>
    /// u5 = 0: not present, u5 = 1: 12, u5 = 2: FarmMonster.pb
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int U6 {
      get { return u6_; }
      set {
        u6_ = value;
      }
    }

    /// <summary>Field number for the "egg_lot_group_id" field.</summary>
    public const int EggLotGroupIdFieldNumber = 7;
    private int eggLotGroupId_;
    /// <summary>
    /// EggLotGroup.pb
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int EggLotGroupId {
      get { return eggLotGroupId_; }
      set {
        eggLotGroupId_ = value;
      }
    }

    /// <summary>Field number for the "time" field.</summary>
    public const int TimeFieldNumber = 8;
    private int time_;
    /// <summary>
    /// in seconds
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Time {
      get { return time_; }
      set {
        time_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as EggItem);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(EggItem other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ItemId != other.ItemId) return false;
      if (TextId != other.TextId) return false;
      if (ImageId != other.ImageId) return false;
      if (Rarity != other.Rarity) return false;
      if (U5 != other.U5) return false;
      if (U6 != other.U6) return false;
      if (EggLotGroupId != other.EggLotGroupId) return false;
      if (Time != other.Time) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ItemId != 0L) hash ^= ItemId.GetHashCode();
      if (TextId != 0) hash ^= TextId.GetHashCode();
      if (ImageId.Length != 0) hash ^= ImageId.GetHashCode();
      if (Rarity != 0) hash ^= Rarity.GetHashCode();
      if (U5 != 0) hash ^= U5.GetHashCode();
      if (U6 != 0) hash ^= U6.GetHashCode();
      if (EggLotGroupId != 0) hash ^= EggLotGroupId.GetHashCode();
      if (Time != 0) hash ^= Time.GetHashCode();
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
      if (ItemId != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(ItemId);
      }
      if (TextId != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(TextId);
      }
      if (ImageId.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(ImageId);
      }
      if (Rarity != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Rarity);
      }
      if (U5 != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(U5);
      }
      if (U6 != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(U6);
      }
      if (EggLotGroupId != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(EggLotGroupId);
      }
      if (Time != 0) {
        output.WriteRawTag(64);
        output.WriteInt32(Time);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ItemId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(ItemId);
      }
      if (TextId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(TextId);
      }
      if (ImageId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ImageId);
      }
      if (Rarity != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Rarity);
      }
      if (U5 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(U5);
      }
      if (U6 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(U6);
      }
      if (EggLotGroupId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(EggLotGroupId);
      }
      if (Time != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Time);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(EggItem other) {
      if (other == null) {
        return;
      }
      if (other.ItemId != 0L) {
        ItemId = other.ItemId;
      }
      if (other.TextId != 0) {
        TextId = other.TextId;
      }
      if (other.ImageId.Length != 0) {
        ImageId = other.ImageId;
      }
      if (other.Rarity != 0) {
        Rarity = other.Rarity;
      }
      if (other.U5 != 0) {
        U5 = other.U5;
      }
      if (other.U6 != 0) {
        U6 = other.U6;
      }
      if (other.EggLotGroupId != 0) {
        EggLotGroupId = other.EggLotGroupId;
      }
      if (other.Time != 0) {
        Time = other.Time;
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
            ItemId = input.ReadInt64();
            break;
          }
          case 16: {
            TextId = input.ReadInt32();
            break;
          }
          case 26: {
            ImageId = input.ReadString();
            break;
          }
          case 32: {
            Rarity = input.ReadInt32();
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
            EggLotGroupId = input.ReadInt32();
            break;
          }
          case 64: {
            Time = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class EggItemTable : pb::IMessage<EggItemTable> {
    private static readonly pb::MessageParser<EggItemTable> _parser = new pb::MessageParser<EggItemTable>(() => new EggItemTable());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<EggItemTable> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ReMastersLib.EggItemReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EggItemTable() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EggItemTable(EggItemTable other) : this() {
      entries_ = other.entries_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EggItemTable Clone() {
      return new EggItemTable(this);
    }

    /// <summary>Field number for the "entries" field.</summary>
    public const int EntriesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::ReMastersLib.EggItem> _repeated_entries_codec
        = pb::FieldCodec.ForMessage(10, global::ReMastersLib.EggItem.Parser);
    private readonly pbc::RepeatedField<global::ReMastersLib.EggItem> entries_ = new pbc::RepeatedField<global::ReMastersLib.EggItem>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::ReMastersLib.EggItem> Entries {
      get { return entries_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as EggItemTable);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(EggItemTable other) {
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
    public void MergeFrom(EggItemTable other) {
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
