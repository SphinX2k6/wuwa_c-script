using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200073C RID: 1852
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(32, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 32)]
	[UnrealObjectPath("/Script/CoreUObject.InterpCurvePointVector2D")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 32)]
	public struct FInterpCurvePointVector2D : IEqualityOperators<FInterpCurvePointVector2D, FInterpCurvePointVector2D, bool>, IEquatable<FInterpCurvePointVector2D>, IUnrealScriptStruct
	{
		// Token: 0x0600627B RID: 25211 RVA: 0x0008D4AA File Offset: 0x0008B6AA
		public FInterpCurvePointVector2D(float InVal, FVector2D OutVal, FVector2D ArriveTangent, FVector2D LeaveTangent, TEnumAsByte<EInterpCurveMode> InterpMode)
		{
			this.InVal = InVal;
			this.OutVal = OutVal;
			this.ArriveTangent = ArriveTangent;
			this.LeaveTangent = LeaveTangent;
			this.InterpMode = InterpMode;
		}

		// Token: 0x0600627C RID: 25212 RVA: 0x0008D4D4 File Offset: 0x0008B6D4
		public static bool operator ==(FInterpCurvePointVector2D left, FInterpCurvePointVector2D right)
		{
			return left.InVal == right.InVal && left.OutVal == right.OutVal && left.ArriveTangent == right.ArriveTangent && left.LeaveTangent == right.LeaveTangent && left.InterpMode == right.InterpMode;
		}

		// Token: 0x0600627D RID: 25213 RVA: 0x0008D53B File Offset: 0x0008B73B
		public static bool operator !=(FInterpCurvePointVector2D left, FInterpCurvePointVector2D right)
		{
			return !(left == right);
		}

		// Token: 0x0600627E RID: 25214 RVA: 0x0008D547 File Offset: 0x0008B747
		public bool Equals(FInterpCurvePointVector2D other)
		{
			return this == other;
		}

		// Token: 0x0600627F RID: 25215 RVA: 0x0008D558 File Offset: 0x0008B758
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FInterpCurvePointVector2D)
			{
				FInterpCurvePointVector2D other = (FInterpCurvePointVector2D)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06006280 RID: 25216 RVA: 0x0008D57D File Offset: 0x0008B77D
		public override int GetHashCode()
		{
			return HashCode.Combine<float, FVector2D, FVector2D, FVector2D, TEnumAsByte<EInterpCurveMode>>(this.InVal, this.OutVal, this.ArriveTangent, this.LeaveTangent, this.InterpMode);
		}

		// Token: 0x06006281 RID: 25217 RVA: 0x0008D5A2 File Offset: 0x0008B7A2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FInterpCurvePointVector2D._ScriptStructPtr != 0) ? FInterpCurvePointVector2D._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.InterpCurvePointVector2D", ref FInterpCurvePointVector2D._ScriptStructPtr);
		}

		// Token: 0x04002F15 RID: 12053
		[FieldOffset(0)]
		public float InVal;

		// Token: 0x04002F16 RID: 12054
		[FieldOffset(4)]
		public FVector2D OutVal;

		// Token: 0x04002F17 RID: 12055
		[FieldOffset(12)]
		public FVector2D ArriveTangent;

		// Token: 0x04002F18 RID: 12056
		[FieldOffset(20)]
		public FVector2D LeaveTangent;

		// Token: 0x04002F19 RID: 12057
		[FieldOffset(28)]
		public TEnumAsByte<EInterpCurveMode> InterpMode;

		// Token: 0x04002F1A RID: 12058
		public const string __ObjectPath = "/Script/CoreUObject.InterpCurvePointVector2D";

		// Token: 0x04002F1B RID: 12059
		private static IntPtr _ScriptStructPtr;
	}
}
