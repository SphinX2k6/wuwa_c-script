using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002931 RID: 10545
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(3, 1, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 3)]
	[UnrealObjectPath("/Script/TriggerEffect.VibrationMode")]
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 3)]
	public struct FVibrationMode : IEqualityOperators<FVibrationMode, FVibrationMode, bool>, IEquatable<FVibrationMode>, IUnrealScriptStruct
	{
		// Token: 0x06027032 RID: 159794 RVA: 0x003B81E9 File Offset: 0x003B63E9
		public FVibrationMode(byte Position, byte Frequency, byte Amplitude)
		{
			this.Position = Position;
			this.Frequency = Frequency;
			this.Amplitude = Amplitude;
		}

		// Token: 0x06027033 RID: 159795 RVA: 0x003B8200 File Offset: 0x003B6400
		public static bool operator ==(FVibrationMode left, FVibrationMode right)
		{
			return left.Position == right.Position && left.Frequency == right.Frequency && left.Amplitude == right.Amplitude;
		}

		// Token: 0x06027034 RID: 159796 RVA: 0x003B822E File Offset: 0x003B642E
		public static bool operator !=(FVibrationMode left, FVibrationMode right)
		{
			return !(left == right);
		}

		// Token: 0x06027035 RID: 159797 RVA: 0x003B823A File Offset: 0x003B643A
		public bool Equals(FVibrationMode other)
		{
			return this == other;
		}

		// Token: 0x06027036 RID: 159798 RVA: 0x003B8248 File Offset: 0x003B6448
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FVibrationMode)
			{
				FVibrationMode other = (FVibrationMode)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06027037 RID: 159799 RVA: 0x003B826D File Offset: 0x003B646D
		public override int GetHashCode()
		{
			return HashCode.Combine<byte, byte, byte>(this.Position, this.Frequency, this.Amplitude);
		}

		// Token: 0x06027038 RID: 159800 RVA: 0x003B8286 File Offset: 0x003B6486
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FVibrationMode._ScriptStructPtr != 0) ? FVibrationMode._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/TriggerEffect.VibrationMode", ref FVibrationMode._ScriptStructPtr);
		}

		// Token: 0x040156FF RID: 87807
		[FieldOffset(0)]
		public byte Position;

		// Token: 0x04015700 RID: 87808
		[FieldOffset(1)]
		public byte Frequency;

		// Token: 0x04015701 RID: 87809
		[FieldOffset(2)]
		public byte Amplitude;

		// Token: 0x04015702 RID: 87810
		public const string __ObjectPath = "/Script/TriggerEffect.VibrationMode";

		// Token: 0x04015703 RID: 87811
		private static IntPtr _ScriptStructPtr;
	}
}
