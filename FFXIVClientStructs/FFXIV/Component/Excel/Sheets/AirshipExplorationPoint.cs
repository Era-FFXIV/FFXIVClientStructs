// <auto-generated/>
namespace FFXIVClientStructs.FFXIV.Component.Excel.Sheets;

[StructLayout(LayoutKind.Explicit, Size = 0x1C)]
public unsafe partial struct AirshipExplorationPoint {
    [FieldOffset(0x00)] public int Name_Offset;
    [FieldOffset(0x04)] public int NameShort_Offset;
    [FieldOffset(0x08)] public uint ExpReward;
    [FieldOffset(0x0C)] public ushort CeruleumTankReq;
    [FieldOffset(0x0E)] public ushort SurveyDurationmin;
    [FieldOffset(0x10)] public ushort SurveyDistance;
    [FieldOffset(0x12)] public short X;
    [FieldOffset(0x14)] public short Y;
    [FieldOffset(0x16)] public byte RankReq;
    [FieldOffset(0x17)] public byte Unknown0;
    [FieldOffset(0x18)] public byte Unknown1;
    [FieldOffset(0x19)] public byte SurveillanceReq;
    [FieldOffset(0x1A)] public byte Unknown2;
    [FieldOffset(0x1B)] public bool Passengers;
}