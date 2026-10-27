using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020010EC RID: 4332
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 8)]
	[UnrealObjectPath("/Script/Engine.SimpleCurveKey")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 8)]
	public struct FSimpleCurveKey : IEqualityOperators<FSimpleCurveKey, FSimpleCurveKey, bool>, IEquatable<FSimpleCurveKey>, IUnrealScriptStruct
	{
		// Token: 0x0600F893 RID: 63635 RVA: 0x0016FAB6 File Offset: 0x0016DCB6
		public FSimpleCurveKey(float Time, float Value)
		{
			this.Time = Time;
			this.Value = Value;
		}

		// Token: 0x0600F894 RID: 63636 RVA: 0x0016FAC6 File Offset: 0x0016DCC6
		public static bool operator ==(FSimpleCurveKey left, FSimpleCurveKey right)
		{
			return left.Time == right.Time && left.Value == right.Value;
		}

		// Token: 0x0600F895 RID: 63637 RVA: 0x0016FAE6 File Offset: 0x0016DCE6
		public static bool operator !=(FSimpleCurveKey left, FSimpleCurveKey right)
		{
			return !(left == right);
		}

		// Token: 0x0600F896 RID: 63638 RVA: 0x0016FAF2 File Offset: 0x0016DCF2
		public bool Equals(FSimpleCurveKey other)
		{
			return this == other;
		}

		// Token: 0x0600F897 RID: 63639 RVA: 0x0016FB00 File Offset: 0x0016DD00
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FSimpleCurveKey)
			{
				FSimpleCurveKey other = (FSimpleCurveKey)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0600F898 RID: 63640 RVA: 0x0016FB25 File Offset: 0x0016DD25
		public override int GetHashCode()
		{
			return HashCode.Combine<float, float>(this.Time, this.Value);
		}

		// Token: 0x0600F899 RID: 63641 RVA: 0x0016FB38 File Offset: 0x0016DD38
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSimpleCurveKey._ScriptStructPtr != 0) ? FSimpleCurveKey._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SimpleCurveKey", ref FSimpleCurveKey._ScriptStructPtr);
		}

		// Token: 0x0400864D RID: 34381
		[FieldOffset(0)]
		public float Time;

		// Token: 0x0400864E RID: 34382
		[FieldOffset(4)]
		public float Value;

		// Token: 0x0400864F RID: 34383
		public const string __ObjectPath = "/Script/Engine.SimpleCurveKey";

		// Token: 0x04008650 RID: 34384
		private static IntPtr _ScriptStructPtr;
	}
}
