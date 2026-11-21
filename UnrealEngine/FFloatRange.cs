using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200010B RID: 267
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 16)]
	[UnrealObjectPath("/Script/CoreUObject.FloatRange")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 16)]
	public struct FFloatRange : IEqualityOperators<FFloatRange, FFloatRange, bool>, IEquatable<FFloatRange>, IUnrealScriptStruct
	{
		// Token: 0x06001125 RID: 4389 RVA: 0x0001B306 File Offset: 0x00019506
		public FFloatRange(FFloatRangeBound LowerBound, FFloatRangeBound UpperBound)
		{
			this.LowerBound = LowerBound;
			this.UpperBound = UpperBound;
		}

		// Token: 0x06001126 RID: 4390 RVA: 0x0001B316 File Offset: 0x00019516
		public static bool operator ==(FFloatRange left, FFloatRange right)
		{
			return left.LowerBound == right.LowerBound && left.UpperBound == right.UpperBound;
		}

		// Token: 0x06001127 RID: 4391 RVA: 0x0001B33E File Offset: 0x0001953E
		public static bool operator !=(FFloatRange left, FFloatRange right)
		{
			return !(left == right);
		}

		// Token: 0x06001128 RID: 4392 RVA: 0x0001B34A File Offset: 0x0001954A
		public bool Equals(FFloatRange other)
		{
			return this == other;
		}

		// Token: 0x06001129 RID: 4393 RVA: 0x0001B358 File Offset: 0x00019558
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

		// Token: 0x0600112A RID: 4394 RVA: 0x0001B37D File Offset: 0x0001957D
		public override int GetHashCode()
		{
			return HashCode.Combine<FFloatRangeBound, FFloatRangeBound>(this.LowerBound, this.UpperBound);
		}

		// Token: 0x0600112B RID: 4395 RVA: 0x0001B390 File Offset: 0x00019590
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FFloatRange._ScriptStructPtr != 0) ? FFloatRange._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.FloatRange", ref FFloatRange._ScriptStructPtr);
		}

		// Token: 0x040004E0 RID: 1248
		[FieldOffset(0)]
		public FFloatRangeBound LowerBound;

		// Token: 0x040004E1 RID: 1249
		[FieldOffset(8)]
		public FFloatRangeBound UpperBound;

		// Token: 0x040004E2 RID: 1250
		public const string __ObjectPath = "/Script/CoreUObject.FloatRange";

		// Token: 0x040004E3 RID: 1251
		private static IntPtr _ScriptStructPtr;
	}
}
