using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000120 RID: 288
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(80, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 80)]
	[UnrealObjectPath("/Script/CoreUObject.InterpCurvePointTwoVectors")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 80)]
	public struct FInterpCurvePointTwoVectors : IEqualityOperators<FInterpCurvePointTwoVectors, FInterpCurvePointTwoVectors, bool>, IEquatable<FInterpCurvePointTwoVectors>, IUnrealScriptStruct
	{
		// Token: 0x060011CD RID: 4557 RVA: 0x0001C263 File Offset: 0x0001A463
		public FInterpCurvePointTwoVectors(float InVal, FTwoVectors OutVal, FTwoVectors ArriveTangent, FTwoVectors LeaveTangent, TEnumAsByte<EInterpCurveMode> InterpMode)
		{
			this.InVal = InVal;
			this.OutVal = OutVal;
			this.ArriveTangent = ArriveTangent;
			this.LeaveTangent = LeaveTangent;
			this.InterpMode = InterpMode;
		}

		// Token: 0x060011CE RID: 4558 RVA: 0x0001C28C File Offset: 0x0001A48C
		public static bool operator ==(FInterpCurvePointTwoVectors left, FInterpCurvePointTwoVectors right)
		{
			return left.InVal == right.InVal && left.OutVal == right.OutVal && left.ArriveTangent == right.ArriveTangent && left.LeaveTangent == right.LeaveTangent && left.InterpMode == right.InterpMode;
		}

		// Token: 0x060011CF RID: 4559 RVA: 0x0001C2F3 File Offset: 0x0001A4F3
		public static bool operator !=(FInterpCurvePointTwoVectors left, FInterpCurvePointTwoVectors right)
		{
			return !(left == right);
		}

		// Token: 0x060011D0 RID: 4560 RVA: 0x0001C2FF File Offset: 0x0001A4FF
		public bool Equals(FInterpCurvePointTwoVectors other)
		{
			return this == other;
		}

		// Token: 0x060011D1 RID: 4561 RVA: 0x0001C310 File Offset: 0x0001A510
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FInterpCurvePointTwoVectors)
			{
				FInterpCurvePointTwoVectors other = (FInterpCurvePointTwoVectors)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x060011D2 RID: 4562 RVA: 0x0001C335 File Offset: 0x0001A535
		public override int GetHashCode()
		{
			return HashCode.Combine<float, FTwoVectors, FTwoVectors, FTwoVectors, TEnumAsByte<EInterpCurveMode>>(this.InVal, this.OutVal, this.ArriveTangent, this.LeaveTangent, this.InterpMode);
		}

		// Token: 0x060011D3 RID: 4563 RVA: 0x0001C35A File Offset: 0x0001A55A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FInterpCurvePointTwoVectors._ScriptStructPtr != 0) ? FInterpCurvePointTwoVectors._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.InterpCurvePointTwoVectors", ref FInterpCurvePointTwoVectors._ScriptStructPtr);
		}

		// Token: 0x0400053D RID: 1341
		[FieldOffset(0)]
		public float InVal;

		// Token: 0x0400053E RID: 1342
		[FieldOffset(4)]
		public FTwoVectors OutVal;

		// Token: 0x0400053F RID: 1343
		[FieldOffset(28)]
		public FTwoVectors ArriveTangent;

		// Token: 0x04000540 RID: 1344
		[FieldOffset(52)]
		public FTwoVectors LeaveTangent;

		// Token: 0x04000541 RID: 1345
		[FieldOffset(76)]
		public TEnumAsByte<EInterpCurveMode> InterpMode;

		// Token: 0x04000542 RID: 1346
		public const string __ObjectPath = "/Script/CoreUObject.InterpCurvePointTwoVectors";

		// Token: 0x04000543 RID: 1347
		private static IntPtr _ScriptStructPtr;
	}
}
