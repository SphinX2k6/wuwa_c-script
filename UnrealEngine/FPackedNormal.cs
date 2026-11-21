using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200013E RID: 318
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(4, 1, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 4)]
	[UnrealObjectPath("/Script/CoreUObject.PackedNormal")]
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 4)]
	public struct FPackedNormal : IEqualityOperators<FPackedNormal, FPackedNormal, bool>, IEquatable<FPackedNormal>, IUnrealScriptStruct
	{
		// Token: 0x0600128F RID: 4751 RVA: 0x0001D60D File Offset: 0x0001B80D
		public FPackedNormal(byte X, byte Y, byte Z, byte W)
		{
			this.X = X;
			this.Y = Y;
			this.Z = Z;
			this.W = W;
		}

		// Token: 0x06001290 RID: 4752 RVA: 0x0001D62C File Offset: 0x0001B82C
		public static bool operator ==(FPackedNormal left, FPackedNormal right)
		{
			return left.X == right.X && left.Y == right.Y && left.Z == right.Z && left.W == right.W;
		}

		// Token: 0x06001291 RID: 4753 RVA: 0x0001D668 File Offset: 0x0001B868
		public static bool operator !=(FPackedNormal left, FPackedNormal right)
		{
			return !(left == right);
		}

		// Token: 0x06001292 RID: 4754 RVA: 0x0001D674 File Offset: 0x0001B874
		public bool Equals(FPackedNormal other)
		{
			return this == other;
		}

		// Token: 0x06001293 RID: 4755 RVA: 0x0001D684 File Offset: 0x0001B884
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FPackedNormal)
			{
				FPackedNormal other = (FPackedNormal)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06001294 RID: 4756 RVA: 0x0001D6A9 File Offset: 0x0001B8A9
		public override int GetHashCode()
		{
			return HashCode.Combine<byte, byte, byte, byte>(this.X, this.Y, this.Z, this.W);
		}

		// Token: 0x06001295 RID: 4757 RVA: 0x0001D6C8 File Offset: 0x0001B8C8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPackedNormal._ScriptStructPtr != 0) ? FPackedNormal._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.PackedNormal", ref FPackedNormal._ScriptStructPtr);
		}

		// Token: 0x040005BD RID: 1469
		[FieldOffset(0)]
		public byte X;

		// Token: 0x040005BE RID: 1470
		[FieldOffset(1)]
		public byte Y;

		// Token: 0x040005BF RID: 1471
		[FieldOffset(2)]
		public byte Z;

		// Token: 0x040005C0 RID: 1472
		[FieldOffset(3)]
		public byte W;

		// Token: 0x040005C1 RID: 1473
		public const string __ObjectPath = "/Script/CoreUObject.PackedNormal";

		// Token: 0x040005C2 RID: 1474
		private static IntPtr _ScriptStructPtr;
	}
}
