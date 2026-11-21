using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000122 RID: 290
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(32, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 32)]
	[UnrealObjectPath("/Script/CoreUObject.InterpCurvePointVector2D")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 32)]
	public struct FInterpCurvePointVector2D : IEqualityOperators<FInterpCurvePointVector2D, FInterpCurvePointVector2D, bool>, IEquatable<FInterpCurvePointVector2D>, IUnrealScriptStruct
	{
		// Token: 0x060011DB RID: 4571 RVA: 0x0001C49A File Offset: 0x0001A69A
		public FInterpCurvePointVector2D(float InVal, FVector2D OutVal, FVector2D ArriveTangent, FVector2D LeaveTangent, TEnumAsByte<EInterpCurveMode> InterpMode)
		{
			this.InVal = InVal;
			this.OutVal = OutVal;
			this.ArriveTangent = ArriveTangent;
			this.LeaveTangent = LeaveTangent;
			this.InterpMode = InterpMode;
		}

		// Token: 0x060011DC RID: 4572 RVA: 0x0001C4C4 File Offset: 0x0001A6C4
		public static bool operator ==(FInterpCurvePointVector2D left, FInterpCurvePointVector2D right)
		{
			return left.InVal == right.InVal && left.OutVal == right.OutVal && left.ArriveTangent == right.ArriveTangent && left.LeaveTangent == right.LeaveTangent && left.InterpMode == right.InterpMode;
		}

		// Token: 0x060011DD RID: 4573 RVA: 0x0001C52B File Offset: 0x0001A72B
		public static bool operator !=(FInterpCurvePointVector2D left, FInterpCurvePointVector2D right)
		{
			return !(left == right);
		}

		// Token: 0x060011DE RID: 4574 RVA: 0x0001C537 File Offset: 0x0001A737
		public bool Equals(FInterpCurvePointVector2D other)
		{
			return this == other;
		}

		// Token: 0x060011DF RID: 4575 RVA: 0x0001C548 File Offset: 0x0001A748
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

		// Token: 0x060011E0 RID: 4576 RVA: 0x0001C56D File Offset: 0x0001A76D
		public override int GetHashCode()
		{
			return HashCode.Combine<float, FVector2D, FVector2D, FVector2D, TEnumAsByte<EInterpCurveMode>>(this.InVal, this.OutVal, this.ArriveTangent, this.LeaveTangent, this.InterpMode);
		}

		// Token: 0x060011E1 RID: 4577 RVA: 0x0001C592 File Offset: 0x0001A792
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FInterpCurvePointVector2D._ScriptStructPtr != 0) ? FInterpCurvePointVector2D._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.InterpCurvePointVector2D", ref FInterpCurvePointVector2D._ScriptStructPtr);
		}

		// Token: 0x0400054B RID: 1355
		[FieldOffset(0)]
		public float InVal;

		// Token: 0x0400054C RID: 1356
		[FieldOffset(4)]
		public FVector2D OutVal;

		// Token: 0x0400054D RID: 1357
		[FieldOffset(12)]
		public FVector2D ArriveTangent;

		// Token: 0x0400054E RID: 1358
		[FieldOffset(20)]
		public FVector2D LeaveTangent;

		// Token: 0x0400054F RID: 1359
		[FieldOffset(28)]
		public TEnumAsByte<EInterpCurveMode> InterpMode;

		// Token: 0x04000550 RID: 1360
		public const string __ObjectPath = "/Script/CoreUObject.InterpCurvePointVector2D";

		// Token: 0x04000551 RID: 1361
		private static IntPtr _ScriptStructPtr;
	}
}
