// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Proto/EmblemItem.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace ReMastersLib {

  /// <summary>Holder for reflection information generated from Proto/EmblemItem.proto</summary>
  public static partial class EmblemItemReflection {

    #region Descriptor
    /// <summary>File descriptor for Proto/EmblemItem.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EmblemItemReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZQcm90by9FbWJsZW1JdGVtLnByb3RvEgxSZU1hc3RlcnNMaWIimgEKCkVt",
            "YmxlbUl0ZW0SDwoHaXRlbV9pZBgBIAEoAxIUCgxzdWJfY2F0ZWdvcnkYAiAB",
            "KAMSCgoCdTMYAyABKAUSDgoGcmFyaXR5GAQgASgFEgoKAnU1GAUgASgFEhAK",
            "CGltYWdlX2lkGAYgASgJEhMKC3NjaGVkdWxlX2lkGAcgASgJEgoKAnU4GAgg",
            "ASgFEgoKAnU5GAkgASgDIjwKD0VtYmxlbUl0ZW1UYWJsZRIpCgdlbnRyaWVz",
            "GAEgAygLMhguUmVNYXN0ZXJzTGliLkVtYmxlbUl0ZW1iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::ReMastersLib.EmblemItem), global::ReMastersLib.EmblemItem.Parser, new[]{ "ItemId", "SubCategory", "U3", "Rarity", "U5", "ImageId", "ScheduleId", "U8", "U9" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ReMastersLib.EmblemItemTable), global::ReMastersLib.EmblemItemTable.Parser, new[]{ "Entries" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class EmblemItem : pb::IMessage<EmblemItem> {
    private static readonly pb::MessageParser<EmblemItem> _parser = new pb::MessageParser<EmblemItem>(() => new EmblemItem());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<EmblemItem> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ReMastersLib.EmblemItemReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EmblemItem() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EmblemItem(EmblemItem other) : this() {
      itemId_ = other.itemId_;
      subCategory_ = other.subCategory_;
      u3_ = other.u3_;
      rarity_ = other.rarity_;
      u5_ = other.u5_;
      imageId_ = other.imageId_;
      scheduleId_ = other.scheduleId_;
      u8_ = other.u8_;
      u9_ = other.u9_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EmblemItem Clone() {
      return new EmblemItem(this);
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

    /// <summary>Field number for the "sub_category" field.</summary>
    public const int SubCategoryFieldNumber = 2;
    private long subCategory_;
    /// <summary>
    /// EmblemItemCategory.pb (sub_categories) / bardge_item_minor_category_xx.lsd
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long SubCategory {
      get { return subCategory_; }
      set {
        subCategory_ = value;
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

    /// <summary>Field number for the "rarity" field.</summary>
    public const int RarityFieldNumber = 4;
    private int rarity_;
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
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int U5 {
      get { return u5_; }
      set {
        u5_ = value;
      }
    }

    /// <summary>Field number for the "image_id" field.</summary>
    public const int ImageIdFieldNumber = 6;
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

    /// <summary>Field number for the "schedule_id" field.</summary>
    public const int ScheduleIdFieldNumber = 7;
    private string scheduleId_ = "";
    /// <summary>
    /// Schedule.pb
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ScheduleId {
      get { return scheduleId_; }
      set {
        scheduleId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "u8" field.</summary>
    public const int U8FieldNumber = 8;
    private int u8_;
    /// <summary>
    ///
    ///if u8 = 0: u9 is a quest_id or item_id
    ///if u8 = 1: u9 is a mission_id
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int U8 {
      get { return u8_; }
      set {
        u8_ = value;
      }
    }

    /// <summary>Field number for the "u9" field.</summary>
    public const int U9FieldNumber = 9;
    private long u9_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long U9 {
      get { return u9_; }
      set {
        u9_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as EmblemItem);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(EmblemItem other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ItemId != other.ItemId) return false;
      if (SubCategory != other.SubCategory) return false;
      if (U3 != other.U3) return false;
      if (Rarity != other.Rarity) return false;
      if (U5 != other.U5) return false;
      if (ImageId != other.ImageId) return false;
      if (ScheduleId != other.ScheduleId) return false;
      if (U8 != other.U8) return false;
      if (U9 != other.U9) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ItemId != 0L) hash ^= ItemId.GetHashCode();
      if (SubCategory != 0L) hash ^= SubCategory.GetHashCode();
      if (U3 != 0) hash ^= U3.GetHashCode();
      if (Rarity != 0) hash ^= Rarity.GetHashCode();
      if (U5 != 0) hash ^= U5.GetHashCode();
      if (ImageId.Length != 0) hash ^= ImageId.GetHashCode();
      if (ScheduleId.Length != 0) hash ^= ScheduleId.GetHashCode();
      if (U8 != 0) hash ^= U8.GetHashCode();
      if (U9 != 0L) hash ^= U9.GetHashCode();
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
      if (SubCategory != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(SubCategory);
      }
      if (U3 != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(U3);
      }
      if (Rarity != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Rarity);
      }
      if (U5 != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(U5);
      }
      if (ImageId.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(ImageId);
      }
      if (ScheduleId.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(ScheduleId);
      }
      if (U8 != 0) {
        output.WriteRawTag(64);
        output.WriteInt32(U8);
      }
      if (U9 != 0L) {
        output.WriteRawTag(72);
        output.WriteInt64(U9);
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
      if (SubCategory != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(SubCategory);
      }
      if (U3 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(U3);
      }
      if (Rarity != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Rarity);
      }
      if (U5 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(U5);
      }
      if (ImageId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ImageId);
      }
      if (ScheduleId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ScheduleId);
      }
      if (U8 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(U8);
      }
      if (U9 != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(U9);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(EmblemItem other) {
      if (other == null) {
        return;
      }
      if (other.ItemId != 0L) {
        ItemId = other.ItemId;
      }
      if (other.SubCategory != 0L) {
        SubCategory = other.SubCategory;
      }
      if (other.U3 != 0) {
        U3 = other.U3;
      }
      if (other.Rarity != 0) {
        Rarity = other.Rarity;
      }
      if (other.U5 != 0) {
        U5 = other.U5;
      }
      if (other.ImageId.Length != 0) {
        ImageId = other.ImageId;
      }
      if (other.ScheduleId.Length != 0) {
        ScheduleId = other.ScheduleId;
      }
      if (other.U8 != 0) {
        U8 = other.U8;
      }
      if (other.U9 != 0L) {
        U9 = other.U9;
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
            SubCategory = input.ReadInt64();
            break;
          }
          case 24: {
            U3 = input.ReadInt32();
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
          case 50: {
            ImageId = input.ReadString();
            break;
          }
          case 58: {
            ScheduleId = input.ReadString();
            break;
          }
          case 64: {
            U8 = input.ReadInt32();
            break;
          }
          case 72: {
            U9 = input.ReadInt64();
            break;
          }
        }
      }
    }

  }

  public sealed partial class EmblemItemTable : pb::IMessage<EmblemItemTable> {
    private static readonly pb::MessageParser<EmblemItemTable> _parser = new pb::MessageParser<EmblemItemTable>(() => new EmblemItemTable());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<EmblemItemTable> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ReMastersLib.EmblemItemReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EmblemItemTable() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EmblemItemTable(EmblemItemTable other) : this() {
      entries_ = other.entries_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EmblemItemTable Clone() {
      return new EmblemItemTable(this);
    }

    /// <summary>Field number for the "entries" field.</summary>
    public const int EntriesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::ReMastersLib.EmblemItem> _repeated_entries_codec
        = pb::FieldCodec.ForMessage(10, global::ReMastersLib.EmblemItem.Parser);
    private readonly pbc::RepeatedField<global::ReMastersLib.EmblemItem> entries_ = new pbc::RepeatedField<global::ReMastersLib.EmblemItem>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::ReMastersLib.EmblemItem> Entries {
      get { return entries_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as EmblemItemTable);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(EmblemItemTable other) {
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
    public void MergeFrom(EmblemItemTable other) {
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