using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200011D RID: 285
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 20)]
	[UnrealObjectPath("/Script/CoreUObject.InterpCurvePointFloat")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 20)]
	public struct FInterpCurvePointFloat : IEqualityOperators<FInterpCurvePointFloat, FInterpCurvePointFloat, bool>, IEquatable<FInterpCurvePointFloat>, IUnrealScriptStruct
	{
		// Token: 0x060011AE RID: 4526 RVA: 0x0001BF17 File Offset: 0x0001A117
		public FInterpCurvePointFloat(float InVal, float OutVal, float ArriveTangent, float LeaveTangent, TEnumAsByte<EInterpCurveMode> InterpMode)
		{
			this.InVal = InVal;
			this.OutVal = OutVal;
			this.ArriveTangent = ArriveTangent;
			this.LeaveTangent = LeaveTangent;
			this.InterpMode = InterpMode;
		}

		// Token: 0x060011AF RID: 4527 RVA: 0x0001BF40 File Offset: 0x0001A140
		public static bool operator ==(FInterpCurvePointFloat left, FInterpCurvePointFloat right)
		{
			return left.InVal == right.InVal && left.OutVal == right.OutVal && left.ArriveTangent == right.ArriveTangent && left.LeaveTangent == right.LeaveTangent && left.InterpMode == right.InterpMode;
		}

		// Token: 0x060011B0 RID: 4528 RVA: 0x0001BF98 File Offset: 0x0001A198
		public static bool operator !=(FInterpCurvePointFloat left, FInterpCurvePointFloat right)
		{
			return !(left == right);
		}

		// Token: 0x060011B1 RID: 4529 RVA: 0x0001BFA4 File Offset: 0x0001A1A4
		public bool Equals(FInterpCurvePointFloat other)
		{
			return this == other;
		}

		// Token: 0x060011B2 RID: 4530 RVA: 0x0001BFB4 File Offset: 0x0001A1B4
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FInterpCurvePointFloat)
			{
				FInterpCurvePointFloat other = (FInterpCurvePointFloat)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x060011B3 RID: 4531 RVA: 0x0001BFD9 File Offset: 0x0001A1D9
		public override int GetHashCode()
		{
			return HashCode.Combine<float, float, float, float, TEnumAsByte<EInterpCurveMode>>(this.InVal, this.OutVal, this.ArriveTangent, this.LeaveTangent, this.InterpMode);
		}

		// Token: 0x060011B4 RID: 4532 RVA: 0x0001BFFE File Offset: 0x0001A1FE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FInterpCurvePointFloat._ScriptStructPtr != 0) ? FInterpCurvePointFloat._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.InterpCurvePointFloat", ref FInterpCurvePointFloat._ScriptStructPtr);
		}

		// Token: 0x04000528 RID: 1320
		[FieldOffset(0)]
		public float InVal;

		// Token: 0x04000529 RID: 1321
		[FieldOffset(4)]
		public float OutVal;

		// Token: 0x0400052A RID: 1322
		[FieldOffset(8)]
		public float ArriveTangent;

		// Token: 0x0400052B RID: 1323
		[FieldOffset(12)]
		public float LeaveTangent;

		// Token: 0x0400052C RID: 1324
		[FieldOffset(16)]
		public TEnumAsByte<EInterpCurveMode> InterpMode;

		// Token: 0x0400052D RID: 1325
		public const string __ObjectPath = "/Script/CoreUObject.InterpCurvePointFloat";

		// Token: 0x0400052E RID: 1326
		private static IntPtr _ScriptStructPtr;
	}
}
