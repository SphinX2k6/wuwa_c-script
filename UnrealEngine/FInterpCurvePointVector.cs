using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000121 RID: 289
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(44, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 44)]
	[UnrealObjectPath("/Script/CoreUObject.InterpCurvePointVector")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 44)]
	public struct FInterpCurvePointVector : IEqualityOperators<FInterpCurvePointVector, FInterpCurvePointVector, bool>, IEquatable<FInterpCurvePointVector>, IUnrealScriptStruct
	{
		// Token: 0x060011D4 RID: 4564 RVA: 0x0001C37E File Offset: 0x0001A57E
		public FInterpCurvePointVector(float InVal, FVector OutVal, FVector ArriveTangent, FVector LeaveTangent, TEnumAsByte<EInterpCurveMode> InterpMode)
		{
			this.InVal = InVal;
			this.OutVal = OutVal;
			this.ArriveTangent = ArriveTangent;
			this.LeaveTangent = LeaveTangent;
			this.InterpMode = InterpMode;
		}

		// Token: 0x060011D5 RID: 4565 RVA: 0x0001C3A8 File Offset: 0x0001A5A8
		public static bool operator ==(FInterpCurvePointVector left, FInterpCurvePointVector right)
		{
			return left.InVal == right.InVal && left.OutVal == right.OutVal && left.ArriveTangent == right.ArriveTangent && left.LeaveTangent == right.LeaveTangent && left.InterpMode == right.InterpMode;
		}

		// Token: 0x060011D6 RID: 4566 RVA: 0x0001C40F File Offset: 0x0001A60F
		public static bool operator !=(FInterpCurvePointVector left, FInterpCurvePointVector right)
		{
			return !(left == right);
		}

		// Token: 0x060011D7 RID: 4567 RVA: 0x0001C41B File Offset: 0x0001A61B
		public bool Equals(FInterpCurvePointVector other)
		{
			return this == other;
		}

		// Token: 0x060011D8 RID: 4568 RVA: 0x0001C42C File Offset: 0x0001A62C
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

		// Token: 0x060011D9 RID: 4569 RVA: 0x0001C451 File Offset: 0x0001A651
		public override int GetHashCode()
		{
			return HashCode.Combine<float, FVector, FVector, FVector, TEnumAsByte<EInterpCurveMode>>(this.InVal, this.OutVal, this.ArriveTangent, this.LeaveTangent, this.InterpMode);
		}

		// Token: 0x060011DA RID: 4570 RVA: 0x0001C476 File Offset: 0x0001A676
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FInterpCurvePointVector._ScriptStructPtr != 0) ? FInterpCurvePointVector._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.InterpCurvePointVector", ref FInterpCurvePointVector._ScriptStructPtr);
		}

		// Token: 0x04000544 RID: 1348
		[FieldOffset(0)]
		public float InVal;

		// Token: 0x04000545 RID: 1349
		[FieldOffset(4)]
		public FVector OutVal;

		// Token: 0x04000546 RID: 1350
		[FieldOffset(16)]
		public FVector ArriveTangent;

		// Token: 0x04000547 RID: 1351
		[FieldOffset(28)]
		public FVector LeaveTangent;

		// Token: 0x04000548 RID: 1352
		[FieldOffset(40)]
		public TEnumAsByte<EInterpCurveMode> InterpMode;

		// Token: 0x04000549 RID: 1353
		public const string __ObjectPath = "/Script/CoreUObject.InterpCurvePointVector";

		// Token: 0x0400054A RID: 1354
		private static IntPtr _ScriptStructPtr;
	}
}
