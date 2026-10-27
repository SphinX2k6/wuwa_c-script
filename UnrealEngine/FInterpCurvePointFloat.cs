using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000737 RID: 1847
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 20)]
	[UnrealObjectPath("/Script/CoreUObject.InterpCurvePointFloat")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 20)]
	public struct FInterpCurvePointFloat : IEqualityOperators<FInterpCurvePointFloat, FInterpCurvePointFloat, bool>, IEquatable<FInterpCurvePointFloat>, IUnrealScriptStruct
	{
		// Token: 0x0600624D RID: 25165 RVA: 0x0008CEFC File Offset: 0x0008B0FC
		public FInterpCurvePointFloat(float InVal, float OutVal, float ArriveTangent, float LeaveTangent, TEnumAsByte<EInterpCurveMode> InterpMode)
		{
			this.InVal = InVal;
			this.OutVal = OutVal;
			this.ArriveTangent = ArriveTangent;
			this.LeaveTangent = LeaveTangent;
			this.InterpMode = InterpMode;
		}

		// Token: 0x0600624E RID: 25166 RVA: 0x0008CF24 File Offset: 0x0008B124
		public static bool operator ==(FInterpCurvePointFloat left, FInterpCurvePointFloat right)
		{
			return left.InVal == right.InVal && left.OutVal == right.OutVal && left.ArriveTangent == right.ArriveTangent && left.LeaveTangent == right.LeaveTangent && left.InterpMode == right.InterpMode;
		}

		// Token: 0x0600624F RID: 25167 RVA: 0x0008CF7C File Offset: 0x0008B17C
		public static bool operator !=(FInterpCurvePointFloat left, FInterpCurvePointFloat right)
		{
			return !(left == right);
		}

		// Token: 0x06006250 RID: 25168 RVA: 0x0008CF88 File Offset: 0x0008B188
		public bool Equals(FInterpCurvePointFloat other)
		{
			return this == other;
		}

		// Token: 0x06006251 RID: 25169 RVA: 0x0008CF98 File Offset: 0x0008B198
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

		// Token: 0x06006252 RID: 25170 RVA: 0x0008CFBD File Offset: 0x0008B1BD
		public override int GetHashCode()
		{
			return HashCode.Combine<float, float, float, float, TEnumAsByte<EInterpCurveMode>>(this.InVal, this.OutVal, this.ArriveTangent, this.LeaveTangent, this.InterpMode);
		}

		// Token: 0x06006253 RID: 25171 RVA: 0x0008CFE2 File Offset: 0x0008B1E2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FInterpCurvePointFloat._ScriptStructPtr != 0) ? FInterpCurvePointFloat._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.InterpCurvePointFloat", ref FInterpCurvePointFloat._ScriptStructPtr);
		}

		// Token: 0x04002EF2 RID: 12018
		[FieldOffset(0)]
		public float InVal;

		// Token: 0x04002EF3 RID: 12019
		[FieldOffset(4)]
		public float OutVal;

		// Token: 0x04002EF4 RID: 12020
		[FieldOffset(8)]
		public float ArriveTangent;

		// Token: 0x04002EF5 RID: 12021
		[FieldOffset(12)]
		public float LeaveTangent;

		// Token: 0x04002EF6 RID: 12022
		[FieldOffset(16)]
		public TEnumAsByte<EInterpCurveMode> InterpMode;

		// Token: 0x04002EF7 RID: 12023
		public const string __ObjectPath = "/Script/CoreUObject.InterpCurvePointFloat";

		// Token: 0x04002EF8 RID: 12024
		private static IntPtr _ScriptStructPtr;
	}
}
