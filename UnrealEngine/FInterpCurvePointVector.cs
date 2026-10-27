using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200073B RID: 1851
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(44, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 44)]
	[UnrealObjectPath("/Script/CoreUObject.InterpCurvePointVector")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 44)]
	public struct FInterpCurvePointVector : IEqualityOperators<FInterpCurvePointVector, FInterpCurvePointVector, bool>, IEquatable<FInterpCurvePointVector>, IUnrealScriptStruct
	{
		// Token: 0x06006274 RID: 25204 RVA: 0x0008D38E File Offset: 0x0008B58E
		public FInterpCurvePointVector(float InVal, FVector OutVal, FVector ArriveTangent, FVector LeaveTangent, TEnumAsByte<EInterpCurveMode> InterpMode)
		{
			this.InVal = InVal;
			this.OutVal = OutVal;
			this.ArriveTangent = ArriveTangent;
			this.LeaveTangent = LeaveTangent;
			this.InterpMode = InterpMode;
		}

		// Token: 0x06006275 RID: 25205 RVA: 0x0008D3B8 File Offset: 0x0008B5B8
		public static bool operator ==(FInterpCurvePointVector left, FInterpCurvePointVector right)
		{
			return left.InVal == right.InVal && left.OutVal == right.OutVal && left.ArriveTangent == right.ArriveTangent && left.LeaveTangent == right.LeaveTangent && left.InterpMode == right.InterpMode;
		}

		// Token: 0x06006276 RID: 25206 RVA: 0x0008D41F File Offset: 0x0008B61F
		public static bool operator !=(FInterpCurvePointVector left, FInterpCurvePointVector right)
		{
			return !(left == right);
		}

		// Token: 0x06006277 RID: 25207 RVA: 0x0008D42B File Offset: 0x0008B62B
		public bool Equals(FInterpCurvePointVector other)
		{
			return this == other;
		}

		// Token: 0x06006278 RID: 25208 RVA: 0x0008D43C File Offset: 0x0008B63C
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FInterpCurvePointVector)
			{
				FInterpCurvePointVector other = (FInterpCurvePointVector)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06006279 RID: 25209 RVA: 0x0008D461 File Offset: 0x0008B661
		public override int GetHashCode()
		{
			return HashCode.Combine<float, FVector, FVector, FVector, TEnumAsByte<EInterpCurveMode>>(this.InVal, this.OutVal, this.ArriveTangent, this.LeaveTangent, this.InterpMode);
		}

		// Token: 0x0600627A RID: 25210 RVA: 0x0008D486 File Offset: 0x0008B686
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FInterpCurvePointVector._ScriptStructPtr != 0) ? FInterpCurvePointVector._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.InterpCurvePointVector", ref FInterpCurvePointVector._ScriptStructPtr);
		}

		// Token: 0x04002F0E RID: 12046
		[FieldOffset(0)]
		public float InVal;

		// Token: 0x04002F0F RID: 12047
		[FieldOffset(4)]
		public FVector OutVal;

		// Token: 0x04002F10 RID: 12048
		[FieldOffset(16)]
		public FVector ArriveTangent;

		// Token: 0x04002F11 RID: 12049
		[FieldOffset(28)]
		public FVector LeaveTangent;

		// Token: 0x04002F12 RID: 12050
		[FieldOffset(40)]
		public TEnumAsByte<EInterpCurveMode> InterpMode;

		// Token: 0x04002F13 RID: 12051
		public const string __ObjectPath = "/Script/CoreUObject.InterpCurvePointVector";

		// Token: 0x04002F14 RID: 12052
		private static IntPtr _ScriptStructPtr;
	}
}
