// <auto-generated/>
namespace FFXIVClientStructs.FFXIV.Component.Excel.Sheets;

[StructLayout(LayoutKind.Explicit, Size = 0x08)]
public unsafe partial struct BehaviorPath {
    [FieldOffset(0x00)] public float Speed;
    [FieldOffset(0x04)] public BitField04Flags BitField04;
    public bool IsTurnTransition => BitField04.HasFlag(BitField04Flags.IsTurnTransition);
    public bool IsFadeOut => BitField04.HasFlag(BitField04Flags.IsFadeOut);
    public bool IsFadeIn => BitField04.HasFlag(BitField04Flags.IsFadeIn);
    public bool IsWalking => BitField04.HasFlag(BitField04Flags.IsWalking);
    public bool Unknown0 => BitField04.HasFlag(BitField04Flags.Unknown0);

    [Flags]
    public enum BitField04Flags : byte {
    	IsTurnTransition = 1 << 0,
    	IsFadeOut = 1 << 1,
    	IsFadeIn = 1 << 2,
    	IsWalking = 1 << 3,
    	Unknown0 = 1 << 4,
    }
}