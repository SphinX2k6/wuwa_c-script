using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000738 RID: 1848
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(56, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 56)]
	[UnrealObjectPath("/Script/CoreUObject.InterpCurvePointLinearColor")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 56)]
	public struct FInterpCurvePointLinearColor : IEqualityOperators<FInterpCurvePointLinearColor, FInterpCurvePointLinearColor, bool>, IEquatable<FInterpCurvePointLinearColor>, IUnrealScriptStruct
	{
		// Token: 0x06006254 RID: 25172 RVA: 0x0008D006 File Offset: 0x0008B206
		public FInterpCurvePointLinearColor(float InVal, FLinearColor OutVal, FLinearColor ArriveTangent, FLinearColor LeaveTangent, TEnumAsByte<EInterpCurveMode> InterpMode)
		{
			this.InVal = InVal;
			this.OutVal = OutVal;
			this.ArriveTangent = ArriveTangent;
			this.LeaveTangent = LeaveTangent;
			this.InterpMode = InterpMode;
		}

		// Token: 0x06006255 RID: 25173 RVA: 0x0008D030 File Offset: 0x0008B230
		public static bool operator ==(FInterpCurvePointLinearColor left, FInterpCurvePointLinearColor right)
		{
			return left.InVal == right.InVal && left.OutVal == right.OutVal && left.ArriveTangent == right.ArriveTangent && left.LeaveTangent == right.LeaveTangent && left.InterpMode == right.InterpMode;
		}

		// Token: 0x06006256 RID: 25174 RVA: 0x0008D097 File Offset: 0x0008B297
		public static bool operator !=(FInterpCurvePointLinearColor left, FInterpCurvePointLinearColor right)
		{
			return !(left == right);
		}

		// Token: 0x06006257 RID: 25175 RVA: 0x0008D0A3 File Offset: 0x0008B2A3
		public bool Equals(FInterpCurvePointLinearColor other)
		{
			return this == other;
		}

		// Token: 0x06006258 RID: 25176 RVA: 0x0008D0B4 File Offset: 0x0008B2B4
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FInterpCurvePointLinearColor)
			{
				FInterpCurvePointLinearColor other = (FInterpCurvePointLinearColor)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06006259 RID: 25177 RVA: 0x0008D0D9 File Offset: 0x0008B2D9
		public override int GetHashCode()
		{
			return HashCode.Combine<float, FLinearColor, FLinearColor, FLinearColor, TEnumAsByte<EInterpCurveMode>>(this.InVal, this.OutVal, this.ArriveTangent, this.LeaveTangent, this.InterpMode);
		}

		// Token: 0x0600625A RID: 25178 RVA: 0x0008D0FE File Offset: 0x0008B2FE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FInterpCurvePointLinearColor._ScriptStructPtr != 0) ? FInterpCurvePointLinearColor._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.InterpCurvePointLinearColor", ref FInterpCurvePointLinearColor._ScriptStructPtr);
		}

		// Token: 0x04002EF9 RID: 12025
		[FieldOffset(0)]
		public float InVal;

		// Token: 0x04002EFA RID: 12026
		[FieldOffset(4)]
		public FLinearColor OutVal;

		// Token: 0x04002EFB RID: 12027
		[FieldOffset(20)]
		public FLinearColor ArriveTangent;

		// Token: 0x04002EFC RID: 12028
		[FieldOffset(36)]
		public FLinearColor LeaveTangent;

		// Token: 0x04002EFD RID: 12029
		[FieldOffset(52)]
		public TEnumAsByte<EInterpCurveMode> InterpMode;

		// Token: 0x04002EFE RID: 12030
		public const string __ObjectPath = "/Script/CoreUObject.InterpCurvePointLinearColor";

		// Token: 0x04002EFF RID: 12031
		private static IntPtr _ScriptStructPtr;
	}
}
