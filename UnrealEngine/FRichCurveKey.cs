using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000272 RID: 626
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(28, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 28)]
	[UnrealObjectPath("/Script/Engine.RichCurveKey")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 28)]
	public struct FRichCurveKey : IEqualityOperators<FRichCurveKey, FRichCurveKey, bool>, IEquatable<FRichCurveKey>, IUnrealScriptStruct
	{
		// Token: 0x0600403B RID: 16443 RVA: 0x0005C27C File Offset: 0x0005A47C
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

		// Token: 0x0600403C RID: 16444 RVA: 0x0005C2D0 File Offset: 0x0005A4D0
		public static bool operator ==(FRichCurveKey left, FRichCurveKey right)
		{
			return left.InterpMode == right.InterpMode && left.TangentMode == right.TangentMode && left.TangentWeightMode == right.TangentWeightMode && left.Time == right.Time && left.Value == right.Value && left.ArriveTangent == right.ArriveTangent && left.ArriveTangentWeight == right.ArriveTangentWeight && left.LeaveTangent == right.LeaveTangent && left.LeaveTangentWeight == right.LeaveTangentWeight;
		}

		// Token: 0x0600403D RID: 16445 RVA: 0x0005C36C File Offset: 0x0005A56C
		public static bool operator !=(FRichCurveKey left, FRichCurveKey right)
		{
			return !(left == right);
		}

		// Token: 0x0600403E RID: 16446 RVA: 0x0005C378 File Offset: 0x0005A578
		public bool Equals(FRichCurveKey other)
		{
			return this == other;
		}

		// Token: 0x0600403F RID: 16447 RVA: 0x0005C388 File Offset: 0x0005A588
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

		// Token: 0x06004040 RID: 16448 RVA: 0x0005C3B0 File Offset: 0x0005A5B0
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

		// Token: 0x06004041 RID: 16449 RVA: 0x0005C441 File Offset: 0x0005A641
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRichCurveKey._ScriptStructPtr != 0) ? FRichCurveKey._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.RichCurveKey", ref FRichCurveKey._ScriptStructPtr);
		}

		// Token: 0x04001920 RID: 6432
		[FieldOffset(0)]
		public TEnumAsByte<ERichCurveInterpMode> InterpMode;

		// Token: 0x04001921 RID: 6433
		[FieldOffset(1)]
		public TEnumAsByte<ERichCurveTangentMode> TangentMode;

		// Token: 0x04001922 RID: 6434
		[FieldOffset(2)]
		public TEnumAsByte<ERichCurveTangentWeightMode> TangentWeightMode;

		// Token: 0x04001923 RID: 6435
		[FieldOffset(4)]
		public float Time;

		// Token: 0x04001924 RID: 6436
		[FieldOffset(8)]
		public float Value;

		// Token: 0x04001925 RID: 6437
		[FieldOffset(12)]
		public float ArriveTangent;

		// Token: 0x04001926 RID: 6438
		[FieldOffset(16)]
		public float ArriveTangentWeight;

		// Token: 0x04001927 RID: 6439
		[FieldOffset(20)]
		public float LeaveTangent;

		// Token: 0x04001928 RID: 6440
		[FieldOffset(24)]
		public float LeaveTangentWeight;

		// Token: 0x04001929 RID: 6441
		public const string __ObjectPath = "/Script/Engine.RichCurveKey";

		// Token: 0x0400192A RID: 6442
		private static IntPtr _ScriptStructPtr;
	}
}
