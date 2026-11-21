using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200011E RID: 286
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(56, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 56)]
	[UnrealObjectPath("/Script/CoreUObject.InterpCurvePointLinearColor")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 56)]
	public struct FInterpCurvePointLinearColor : IEqualityOperators<FInterpCurvePointLinearColor, FInterpCurvePointLinearColor, bool>, IEquatable<FInterpCurvePointLinearColor>, IUnrealScriptStruct
	{
		// Token: 0x060011B5 RID: 4533 RVA: 0x0001C022 File Offset: 0x0001A222
		public FInterpCurvePointLinearColor(float InVal, FLinearColor OutVal, FLinearColor ArriveTangent, FLinearColor LeaveTangent, TEnumAsByte<EInterpCurveMode> InterpMode)
		{
			this.InVal = InVal;
			this.OutVal = OutVal;
			this.ArriveTangent = ArriveTangent;
			this.LeaveTangent = LeaveTangent;
			this.InterpMode = InterpMode;
		}

		// Token: 0x060011B6 RID: 4534 RVA: 0x0001C04C File Offset: 0x0001A24C
		public static bool operator ==(FInterpCurvePointLinearColor left, FInterpCurvePointLinearColor right)
		{
			return left.InVal == right.InVal && left.OutVal == right.OutVal && left.ArriveTangent == right.ArriveTangent && left.LeaveTangent == right.LeaveTangent && left.InterpMode == right.InterpMode;
		}

		// Token: 0x060011B7 RID: 4535 RVA: 0x0001C0B3 File Offset: 0x0001A2B3
		public static bool operator !=(FInterpCurvePointLinearColor left, FInterpCurvePointLinearColor right)
		{
			return !(left == right);
		}

		// Token: 0x060011B8 RID: 4536 RVA: 0x0001C0BF File Offset: 0x0001A2BF
		public bool Equals(FInterpCurvePointLinearColor other)
		{
			return this == other;
		}

		// Token: 0x060011B9 RID: 4537 RVA: 0x0001C0D0 File Offset: 0x0001A2D0
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

		// Token: 0x060011BA RID: 4538 RVA: 0x0001C0F5 File Offset: 0x0001A2F5
		public override int GetHashCode()
		{
			return HashCode.Combine<float, FLinearColor, FLinearColor, FLinearColor, TEnumAsByte<EInterpCurveMode>>(this.InVal, this.OutVal, this.ArriveTangent, this.LeaveTangent, this.InterpMode);
		}

		// Token: 0x060011BB RID: 4539 RVA: 0x0001C11A File Offset: 0x0001A31A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FInterpCurvePointLinearColor._ScriptStructPtr != 0) ? FInterpCurvePointLinearColor._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.InterpCurvePointLinearColor", ref FInterpCurvePointLinearColor._ScriptStructPtr);
		}

		// Token: 0x0400052F RID: 1327
		[FieldOffset(0)]
		public float InVal;

		// Token: 0x04000530 RID: 1328
		[FieldOffset(4)]
		public FLinearColor OutVal;

		// Token: 0x04000531 RID: 1329
		[FieldOffset(20)]
		public FLinearColor ArriveTangent;

		// Token: 0x04000532 RID: 1330
		[FieldOffset(36)]
		public FLinearColor LeaveTangent;

		// Token: 0x04000533 RID: 1331
		[FieldOffset(52)]
		public TEnumAsByte<EInterpCurveMode> InterpMode;

		// Token: 0x04000534 RID: 1332
		public const string __ObjectPath = "/Script/CoreUObject.InterpCurvePointLinearColor";

		// Token: 0x04000535 RID: 1333
		private static IntPtr _ScriptStructPtr;
	}
}
