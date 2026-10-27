using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001091 RID: 4241
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(28, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 28)]
	[UnrealObjectPath("/Script/Engine.RichCurveKey")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 28)]
	public struct FRichCurveKey : IEqualityOperators<FRichCurveKey, FRichCurveKey, bool>, IEquatable<FRichCurveKey>, IUnrealScriptStruct
	{
		// Token: 0x0600F267 RID: 62055 RVA: 0x00167998 File Offset: 0x00165B98
		public FRichCurveKey(TEnumAsByte<ERichCurveInterpMode> InterpMode, TEnumAsByte<ERichCurveTangentMode> TangentMode, TEnumAsByte<ERichCurveTangentWeightMode> TangentWeightMode, float Time, float Value, float ArriveTangent, float ArriveTangentWeight, float LeaveTangent, float LeaveTangentWeight)
		{
			this.InterpMode = InterpMode;
			this.TangentMode = TangentMode;
			this.TangentWeightMode = TangentWeightMode;
			this.Time = Time;
			this.Value = Value;
			this.ArriveTangent = ArriveTangent;
			this.ArriveTangentWeight = ArriveTangentWeight;
			this.LeaveTangent = LeaveTangent;
			this.LeaveTangentWeight = LeaveTangentWeight;
		}

		// Token: 0x0600F268 RID: 62056 RVA: 0x001679EC File Offset: 0x00165BEC
		public static bool operator ==(FRichCurveKey left, FRichCurveKey right)
		{
			return left.InterpMode == right.InterpMode && left.TangentMode == right.TangentMode && left.TangentWeightMode == right.TangentWeightMode && left.Time == right.Time && left.Value == right.Value && left.ArriveTangent == right.ArriveTangent && left.ArriveTangentWeight == right.ArriveTangentWeight && left.LeaveTangent == right.LeaveTangent && left.LeaveTangentWeight == right.LeaveTangentWeight;
		}

		// Token: 0x0600F269 RID: 62057 RVA: 0x00167A88 File Offset: 0x00165C88
		public static bool operator !=(FRichCurveKey left, FRichCurveKey right)
		{
			return !(left == right);
		}

		// Token: 0x0600F26A RID: 62058 RVA: 0x00167A94 File Offset: 0x00165C94
		public bool Equals(FRichCurveKey other)
		{
			return this == other;
		}

		// Token: 0x0600F26B RID: 62059 RVA: 0x00167AA4 File Offset: 0x00165CA4
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FRichCurveKey)
			{
				FRichCurveKey other = (FRichCurveKey)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0600F26C RID: 62060 RVA: 0x00167ACC File Offset: 0x00165CCC
		public override int GetHashCode()
		{
			HashCode hashCode = default(HashCode);
			hashCode.Add<TEnumAsByte<ERichCurveInterpMode>>(this.InterpMode);
			hashCode.Add<TEnumAsByte<ERichCurveTangentMode>>(this.TangentMode);
			hashCode.Add<TEnumAsByte<ERichCurveTangentWeightMode>>(this.TangentWeightMode);
			hashCode.Add<float>(this.Time);
			hashCode.Add<float>(this.Value);
			hashCode.Add<float>(this.ArriveTangent);
			hashCode.Add<float>(this.ArriveTangentWeight);
			hashCode.Add<float>(this.LeaveTangent);
			hashCode.Add<float>(this.LeaveTangentWeight);
			return hashCode.ToHashCode();
		}

		// Token: 0x0600F26D RID: 62061 RVA: 0x00167B5D File Offset: 0x00165D5D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRichCurveKey._ScriptStructPtr != 0) ? FRichCurveKey._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.RichCurveKey", ref FRichCurveKey._ScriptStructPtr);
		}

		// Token: 0x0400837F RID: 33663
		[FieldOffset(0)]
		public TEnumAsByte<ERichCurveInterpMode> InterpMode;

		// Token: 0x04008380 RID: 33664
		[FieldOffset(1)]
		public TEnumAsByte<ERichCurveTangentMode> TangentMode;

		// Token: 0x04008381 RID: 33665
		[FieldOffset(2)]
		public TEnumAsByte<ERichCurveTangentWeightMode> TangentWeightMode;

		// Token: 0x04008382 RID: 33666
		[FieldOffset(4)]
		public float Time;

		// Token: 0x04008383 RID: 33667
		[FieldOffset(8)]
		public float Value;

		// Token: 0x04008384 RID: 33668
		[FieldOffset(12)]
		public float ArriveTangent;

		// Token: 0x04008385 RID: 33669
		[FieldOffset(16)]
		public float ArriveTangentWeight;

		// Token: 0x04008386 RID: 33670
		[FieldOffset(20)]
		public float LeaveTangent;

		// Token: 0x04008387 RID: 33671
		[FieldOffset(24)]
		public float LeaveTangentWeight;

		// Token: 0x04008388 RID: 33672
		public const string __ObjectPath = "/Script/Engine.RichCurveKey";

		// Token: 0x04008389 RID: 33673
		private static IntPtr _ScriptStructPtr;
	}
}
