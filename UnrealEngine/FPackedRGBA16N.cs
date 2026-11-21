using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000140 RID: 320
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 8)]
	[UnrealObjectPath("/Script/CoreUObject.PackedRGBA16N")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 8)]
	public struct FPackedRGBA16N : IEqualityOperators<FPackedRGBA16N, FPackedRGBA16N, bool>, IEquatable<FPackedRGBA16N>, IUnrealScriptStruct
	{
		// Token: 0x0600129D RID: 4765 RVA: 0x0001D776 File Offset: 0x0001B976
		public FPackedRGBA16N(int XY, int ZW)
		{
			this.XY = XY;
			this.ZW = ZW;
		}

		// Token: 0x0600129E RID: 4766 RVA: 0x0001D786 File Offset: 0x0001B986
		public static bool operator ==(FPackedRGBA16N left, FPackedRGBA16N right)
		{
			return left.XY == right.XY && left.ZW == right.ZW;
		}

		// Token: 0x0600129F RID: 4767 RVA: 0x0001D7A6 File Offset: 0x0001B9A6
		public static bool operator !=(FPackedRGBA16N left, FPackedRGBA16N right)
		{
			return !(left == right);
		}

		// Token: 0x060012A0 RID: 4768 RVA: 0x0001D7B2 File Offset: 0x0001B9B2
		public bool Equals(FPackedRGBA16N other)
		{
			return this == other;
		}

		// Token: 0x060012A1 RID: 4769 RVA: 0x0001D7C0 File Offset: 0x0001B9C0
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

		// Token: 0x060012A2 RID: 4770 RVA: 0x0001D7E5 File Offset: 0x0001B9E5
		public override int GetHashCode()
		{
			return HashCode.Combine<int, int>(this.XY, this.ZW);
		}

		// Token: 0x060012A3 RID: 4771 RVA: 0x0001D7F8 File Offset: 0x0001B9F8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPackedRGBA16N._ScriptStructPtr != 0) ? FPackedRGBA16N._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.PackedRGBA16N", ref FPackedRGBA16N._ScriptStructPtr);
		}

		// Token: 0x040005C6 RID: 1478
		[FieldOffset(0)]
		public int XY;

		// Token: 0x040005C7 RID: 1479
		[FieldOffset(4)]
		public int ZW;

		// Token: 0x040005C8 RID: 1480
		public const string __ObjectPath = "/Script/CoreUObject.PackedRGBA16N";

		// Token: 0x040005C9 RID: 1481
		private static IntPtr _ScriptStructPtr;
	}
}
