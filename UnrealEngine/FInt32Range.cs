using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200072F RID: 1839
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 16)]
	[UnrealObjectPath("/Script/CoreUObject.Int32Range")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 16)]
	public struct FInt32Range : IEqualityOperators<FInt32Range, FInt32Range, bool>, IEquatable<FInt32Range>, IUnrealScriptStruct
	{
		// Token: 0x06006210 RID: 25104 RVA: 0x0008C9B6 File Offset: 0x0008ABB6
		public FInt32Range(FInt32RangeBound LowerBound, FInt32RangeBound UpperBound)
		{
			this.LowerBound = LowerBound;
			this.UpperBound = UpperBound;
		}

		// Token: 0x06006211 RID: 25105 RVA: 0x0008C9C6 File Offset: 0x0008ABC6
		public static bool operator ==(FInt32Range left, FInt32Range right)
		{
			return left.LowerBound == right.LowerBound && left.UpperBound == right.UpperBound;
		}

		// Token: 0x06006212 RID: 25106 RVA: 0x0008C9EE File Offset: 0x0008ABEE
		public static bool operator !=(FInt32Range left, FInt32Range right)
		{
			return !(left == right);
		}

		// Token: 0x06006213 RID: 25107 RVA: 0x0008C9FA File Offset: 0x0008ABFA
		public bool Equals(FInt32Range other)
		{
			return this == other;
		}

		// Token: 0x06006214 RID: 25108 RVA: 0x0008CA08 File Offset: 0x0008AC08
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

		// Token: 0x06006215 RID: 25109 RVA: 0x0008CA2D File Offset: 0x0008AC2D
		public override int GetHashCode()
		{
			return HashCode.Combine<FInt32RangeBound, FInt32RangeBound>(this.LowerBound, this.UpperBound);
		}

		// Token: 0x06006216 RID: 25110 RVA: 0x0008CA40 File Offset: 0x0008AC40
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FInt32Range._ScriptStructPtr != 0) ? FInt32Range._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.Int32Range", ref FInt32Range._ScriptStructPtr);
		}

		// Token: 0x04002ED2 RID: 11986
		[FieldOffset(0)]
		public FInt32RangeBound LowerBound;

		// Token: 0x04002ED3 RID: 11987
		[FieldOffset(8)]
		public FInt32RangeBound UpperBound;

		// Token: 0x04002ED4 RID: 11988
		public const string __ObjectPath = "/Script/CoreUObject.Int32Range";

		// Token: 0x04002ED5 RID: 11989
		private static IntPtr _ScriptStructPtr;
	}
}
