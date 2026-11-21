using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Text.Json.Serialization.Metadata
{
	// Token: 0x020000E6 RID: 230
	internal readonly struct PropertyRef : IEquatable<PropertyRef>
	{
		// Token: 0x06000C69 RID: 3177 RVA: 0x00031465 File Offset: 0x0002F665
		public PropertyRef(ulong key, JsonPropertyInfo info, byte[] utf8PropertyName)
		{
			this.Key = key;
			this.Info = info;
			this.Utf8PropertyName = utf8PropertyName;
		}

		// Token: 0x06000C6A RID: 3178 RVA: 0x0003147C File Offset: 0x0002F67C
		public bool Equals(PropertyRef other)
		{
			return this.Equals(other.Utf8PropertyName, other.Key);
		}

		// Token: 0x06000C6B RID: 3179 RVA: 0x00031498 File Offset: 0x0002F698
		public override bool Equals(object obj)
		{
			if (obj is PropertyRef)
			{
				PropertyRef other = (PropertyRef)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06000C6C RID: 3180 RVA: 0x000314BD File Offset: 0x0002F6BD
		public override int GetHashCode()
		{
			return this.Key.GetHashCode();
		}

		// Token: 0x06000C6D RID: 3181 RVA: 0x000314CA File Offset: 0x0002F6CA
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool Equals(ReadOnlySpan<byte> propertyName, ulong key)
		{
			return key == this.Key && (propertyName.Length <= 7 || propertyName.SequenceEqual(this.Utf8PropertyName));
		}

		// Token: 0x06000C6E RID: 3182 RVA: 0x000314F4 File Offset: 0x0002F6F4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static ulong GetKey(ReadOnlySpan<byte> name)
		{
			ref byte reference = ref MemoryMarshal.GetReference<byte>(name);
			int length = name.Length;
			ulong num = (ulong)((byte)length) << 56;
			switch (length)
			{
			case 0:
				return num;
			case 1:
				break;
			case 2:
				return num | (ulong)Unsafe.ReadUnaligned<ushort>(ref reference);
			case 3:
				num |= (ulong)Unsafe.ReadUnaligned<ushort>(ref reference);
				break;
			case 4:
				return num | (ulong)Unsafe.ReadUnaligned<uint>(ref reference);
			case 5:
				num |= (ulong)Unsafe.ReadUnaligned<uint>(ref reference);
				break;
			case 6:
				return num | ((ulong)Unsafe.ReadUnaligned<uint>(ref reference) | (ulong)Unsafe.ReadUnaligned<ushort>(Unsafe.Add<byte>(ref reference, 4)) << 32);
			case 7:
				num |= ((ulong)Unsafe.ReadUnaligned<uint>(ref reference) | (ulong)Unsafe.ReadUnaligned<ushort>(Unsafe.Add<byte>(ref reference, 4)) << 32);
				break;
			default:
				return num | (Unsafe.ReadUnaligned<ulong>(ref reference) & 72057594037927935UL);
			}
			int num2 = length - 1;
			num |= (ulong)(*Unsafe.Add<byte>(ref reference, num2)) << num2 * 8;
			return num;
		}

		// Token: 0x04000408 RID: 1032
		public readonly ulong Key;

		// Token: 0x04000409 RID: 1033
		public readonly JsonPropertyInfo Info;

		// Token: 0x0400040A RID: 1034
		public readonly byte[] Utf8PropertyName;
	}
}
