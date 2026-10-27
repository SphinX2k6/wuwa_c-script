using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200075A RID: 1882
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 8)]
	[UnrealObjectPath("/Script/CoreUObject.PackedRGBA16N")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 8)]
	public struct FPackedRGBA16N : IEqualityOperators<FPackedRGBA16N, FPackedRGBA16N, bool>, IEquatable<FPackedRGBA16N>, IUnrealScriptStruct
	{
		// Token: 0x06006341 RID: 25409 RVA: 0x0008E7F6 File Offset: 0x0008C9F6
		public FPackedRGBA16N(int XY, int ZW)
		{
			this.XY = XY;
			this.ZW = ZW;
		}

		// Token: 0x06006342 RID: 25410 RVA: 0x0008E806 File Offset: 0x0008CA06
		public static bool operator ==(FPackedRGBA16N left, FPackedRGBA16N right)
		{
			return left.XY == right.XY && left.ZW == right.ZW;
		}

		// Token: 0x06006343 RID: 25411 RVA: 0x0008E826 File Offset: 0x0008CA26
		public static bool operator !=(FPackedRGBA16N left, FPackedRGBA16N right)
		{
			return !(left == right);
		}

		// Token: 0x06006344 RID: 25412 RVA: 0x0008E832 File Offset: 0x0008CA32
		public bool Equals(FPackedRGBA16N other)
		{
			return this == other;
		}

		// Token: 0x06006345 RID: 25413 RVA: 0x0008E840 File Offset: 0x0008CA40
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FPackedRGBA16N)
			{
				FPackedRGBA16N other = (FPackedRGBA16N)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06006346 RID: 25414 RVA: 0x0008E865 File Offset: 0x0008CA65
		public override int GetHashCode()
		{
			return HashCode.Combine<int, int>(this.XY, this.ZW);
		}

		// Token: 0x06006347 RID: 25415 RVA: 0x0008E878 File Offset: 0x0008CA78
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPackedRGBA16N._ScriptStructPtr != 0) ? FPackedRGBA16N._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.PackedRGBA16N", ref FPackedRGBA16N._ScriptStructPtr);
		}

		// Token: 0x04002F90 RID: 12176
		[FieldOffset(0)]
		public int XY;

		// Token: 0x04002F91 RID: 12177
		[FieldOffset(4)]
		public int ZW;

		// Token: 0x04002F92 RID: 12178
		public const string __ObjectPath = "/Script/CoreUObject.PackedRGBA16N";

		// Token: 0x04002F93 RID: 12179
		private static IntPtr _ScriptStructPtr;
	}
}
