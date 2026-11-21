using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000115 RID: 277
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 16)]
	[UnrealObjectPath("/Script/CoreUObject.Int32Range")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 16)]
	public struct FInt32Range : IEqualityOperators<FInt32Range, FInt32Range, bool>, IEquatable<FInt32Range>, IUnrealScriptStruct
	{
		// Token: 0x06001173 RID: 4467 RVA: 0x0001BA0A File Offset: 0x00019C0A
		public FInt32Range(FInt32RangeBound LowerBound, FInt32RangeBound UpperBound)
		{
			this.LowerBound = LowerBound;
			this.UpperBound = UpperBound;
		}

		// Token: 0x06001174 RID: 4468 RVA: 0x0001BA1A File Offset: 0x00019C1A
		public static bool operator ==(FInt32Range left, FInt32Range right)
		{
			return left.LowerBound == right.LowerBound && left.UpperBound == right.UpperBound;
		}

		// Token: 0x06001175 RID: 4469 RVA: 0x0001BA42 File Offset: 0x00019C42
		public static bool operator !=(FInt32Range left, FInt32Range right)
		{
			return !(left == right);
		}

		// Token: 0x06001176 RID: 4470 RVA: 0x0001BA4E File Offset: 0x00019C4E
		public bool Equals(FInt32Range other)
		{
			return this == other;
		}

		// Token: 0x06001177 RID: 4471 RVA: 0x0001BA5C File Offset: 0x00019C5C
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FInt32Range)
			{
				FInt32Range other = (FInt32Range)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06001178 RID: 4472 RVA: 0x0001BA81 File Offset: 0x00019C81
		public override int GetHashCode()
		{
			return HashCode.Combine<FInt32RangeBound, FInt32RangeBound>(this.LowerBound, this.UpperBound);
		}

		// Token: 0x06001179 RID: 4473 RVA: 0x0001BA94 File Offset: 0x00019C94
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FInt32Range._ScriptStructPtr != 0) ? FInt32Range._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.Int32Range", ref FInt32Range._ScriptStructPtr);
		}

		// Token: 0x04000508 RID: 1288
		[FieldOffset(0)]
		public FInt32RangeBound LowerBound;

		// Token: 0x04000509 RID: 1289
		[FieldOffset(8)]
		public FInt32RangeBound UpperBound;

		// Token: 0x0400050A RID: 1290
		public const string __ObjectPath = "/Script/CoreUObject.Int32Range";

		// Token: 0x0400050B RID: 1291
		private static IntPtr _ScriptStructPtr;
	}
}
