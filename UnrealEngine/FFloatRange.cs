using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000725 RID: 1829
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 16)]
	[UnrealObjectPath("/Script/CoreUObject.FloatRange")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 16)]
	public struct FFloatRange : IEqualityOperators<FFloatRange, FFloatRange, bool>, IEquatable<FFloatRange>, IUnrealScriptStruct
	{
		// Token: 0x060061BE RID: 25022 RVA: 0x0008C26A File Offset: 0x0008A46A
		public FFloatRange(FFloatRangeBound LowerBound, FFloatRangeBound UpperBound)
		{
			this.LowerBound = LowerBound;
			this.UpperBound = UpperBound;
		}

		// Token: 0x060061BF RID: 25023 RVA: 0x0008C27A File Offset: 0x0008A47A
		public static bool operator ==(FFloatRange left, FFloatRange right)
		{
			return left.LowerBound == right.LowerBound && left.UpperBound == right.UpperBound;
		}

		// Token: 0x060061C0 RID: 25024 RVA: 0x0008C2A2 File Offset: 0x0008A4A2
		public static bool operator !=(FFloatRange left, FFloatRange right)
		{
			return !(left == right);
		}

		// Token: 0x060061C1 RID: 25025 RVA: 0x0008C2AE File Offset: 0x0008A4AE
		public bool Equals(FFloatRange other)
		{
			return this == other;
		}

		// Token: 0x060061C2 RID: 25026 RVA: 0x0008C2BC File Offset: 0x0008A4BC
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FFloatRange)
			{
				FFloatRange other = (FFloatRange)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x060061C3 RID: 25027 RVA: 0x0008C2E1 File Offset: 0x0008A4E1
		public override int GetHashCode()
		{
			return HashCode.Combine<FFloatRangeBound, FFloatRangeBound>(this.LowerBound, this.UpperBound);
		}

		// Token: 0x060061C4 RID: 25028 RVA: 0x0008C2F4 File Offset: 0x0008A4F4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FFloatRange._ScriptStructPtr != 0) ? FFloatRange._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.FloatRange", ref FFloatRange._ScriptStructPtr);
		}

		// Token: 0x04002EAA RID: 11946
		[FieldOffset(0)]
		public FFloatRangeBound LowerBound;

		// Token: 0x04002EAB RID: 11947
		[FieldOffset(8)]
		public FFloatRangeBound UpperBound;

		// Token: 0x04002EAC RID: 11948
		public const string __ObjectPath = "/Script/CoreUObject.FloatRange";

		// Token: 0x04002EAD RID: 11949
		private static IntPtr _ScriptStructPtr;
	}
}
