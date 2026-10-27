using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000758 RID: 1880
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(4, 1, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 4)]
	[UnrealObjectPath("/Script/CoreUObject.PackedNormal")]
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 4)]
	public struct FPackedNormal : IEqualityOperators<FPackedNormal, FPackedNormal, bool>, IEquatable<FPackedNormal>, IUnrealScriptStruct
	{
		// Token: 0x06006333 RID: 25395 RVA: 0x0008E68D File Offset: 0x0008C88D
		public FPackedNormal(byte X, byte Y, byte Z, byte W)
		{
			this.X = X;
			this.Y = Y;
			this.Z = Z;
			this.W = W;
		}

		// Token: 0x06006334 RID: 25396 RVA: 0x0008E6AC File Offset: 0x0008C8AC
		public static bool operator ==(FPackedNormal left, FPackedNormal right)
		{
			return left.X == right.X && left.Y == right.Y && left.Z == right.Z && left.W == right.W;
		}

		// Token: 0x06006335 RID: 25397 RVA: 0x0008E6E8 File Offset: 0x0008C8E8
		public static bool operator !=(FPackedNormal left, FPackedNormal right)
		{
			return !(left == right);
		}

		// Token: 0x06006336 RID: 25398 RVA: 0x0008E6F4 File Offset: 0x0008C8F4
		public bool Equals(FPackedNormal other)
		{
			return this == other;
		}

		// Token: 0x06006337 RID: 25399 RVA: 0x0008E704 File Offset: 0x0008C904
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

		// Token: 0x06006338 RID: 25400 RVA: 0x0008E729 File Offset: 0x0008C929
		public override int GetHashCode()
		{
			return HashCode.Combine<byte, byte, byte, byte>(this.X, this.Y, this.Z, this.W);
		}

		// Token: 0x06006339 RID: 25401 RVA: 0x0008E748 File Offset: 0x0008C948
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPackedNormal._ScriptStructPtr != 0) ? FPackedNormal._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.PackedNormal", ref FPackedNormal._ScriptStructPtr);
		}

		// Token: 0x04002F87 RID: 12167
		[FieldOffset(0)]
		public byte X;

		// Token: 0x04002F88 RID: 12168
		[FieldOffset(1)]
		public byte Y;

		// Token: 0x04002F89 RID: 12169
		[FieldOffset(2)]
		public byte Z;

		// Token: 0x04002F8A RID: 12170
		[FieldOffset(3)]
		public byte W;

		// Token: 0x04002F8B RID: 12171
		public const string __ObjectPath = "/Script/CoreUObject.PackedNormal";

		// Token: 0x04002F8C RID: 12172
		private static IntPtr _ScriptStructPtr;
	}
}
