using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200073A RID: 1850
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(80, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 80)]
	[UnrealObjectPath("/Script/CoreUObject.InterpCurvePointTwoVectors")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 80)]
	public struct FInterpCurvePointTwoVectors : IEqualityOperators<FInterpCurvePointTwoVectors, FInterpCurvePointTwoVectors, bool>, IEquatable<FInterpCurvePointTwoVectors>, IUnrealScriptStruct
	{
		// Token: 0x0600626D RID: 25197 RVA: 0x0008D274 File Offset: 0x0008B474
		public FInterpCurvePointTwoVectors(float InVal, FTwoVectors OutVal, FTwoVectors ArriveTangent, FTwoVectors LeaveTangent, TEnumAsByte<EInterpCurveMode> InterpMode)
		{
			this.InVal = InVal;
			this.OutVal = OutVal;
			this.ArriveTangent = ArriveTangent;
			this.LeaveTangent = LeaveTangent;
			this.InterpMode = InterpMode;
		}

		// Token: 0x0600626E RID: 25198 RVA: 0x0008D29C File Offset: 0x0008B49C
		public static bool operator ==(FInterpCurvePointTwoVectors left, FInterpCurvePointTwoVectors right)
		{
			return left.InVal == right.InVal && left.OutVal == right.OutVal && left.ArriveTangent == right.ArriveTangent && left.LeaveTangent == right.LeaveTangent && left.InterpMode == right.InterpMode;
		}

		// Token: 0x0600626F RID: 25199 RVA: 0x0008D303 File Offset: 0x0008B503
		public static bool operator !=(FInterpCurvePointTwoVectors left, FInterpCurvePointTwoVectors right)
		{
			return !(left == right);
		}

		// Token: 0x06006270 RID: 25200 RVA: 0x0008D30F File Offset: 0x0008B50F
		public bool Equals(FInterpCurvePointTwoVectors other)
		{
			return this == other;
		}

		// Token: 0x06006271 RID: 25201 RVA: 0x0008D320 File Offset: 0x0008B520
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

		// Token: 0x06006272 RID: 25202 RVA: 0x0008D345 File Offset: 0x0008B545
		public override int GetHashCode()
		{
			return HashCode.Combine<float, FTwoVectors, FTwoVectors, FTwoVectors, TEnumAsByte<EInterpCurveMode>>(this.InVal, this.OutVal, this.ArriveTangent, this.LeaveTangent, this.InterpMode);
		}

		// Token: 0x06006273 RID: 25203 RVA: 0x0008D36A File Offset: 0x0008B56A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FInterpCurvePointTwoVectors._ScriptStructPtr != 0) ? FInterpCurvePointTwoVectors._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.InterpCurvePointTwoVectors", ref FInterpCurvePointTwoVectors._ScriptStructPtr);
		}

		// Token: 0x04002F07 RID: 12039
		[FieldOffset(0)]
		public float InVal;

		// Token: 0x04002F08 RID: 12040
		[FieldOffset(4)]
		public FTwoVectors OutVal;

		// Token: 0x04002F09 RID: 12041
		[FieldOffset(28)]
		public FTwoVectors ArriveTangent;

		// Token: 0x04002F0A RID: 12042
		[FieldOffset(52)]
		public FTwoVectors LeaveTangent;

		// Token: 0x04002F0B RID: 12043
		[FieldOffset(76)]
		public TEnumAsByte<EInterpCurveMode> InterpMode;

		// Token: 0x04002F0C RID: 12044
		public const string __ObjectPath = "/Script/CoreUObject.InterpCurvePointTwoVectors";

		// Token: 0x04002F0D RID: 12045
		private static IntPtr _ScriptStructPtr;
	}
}
