using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace UnrealEngine
{
	// Token: 0x02000084 RID: 132
	[StructLayout(LayoutKind.Explicit)]
	public readonly struct FSoftObjectPathStruct : IEquatable<FSoftObjectPathStruct>
	{
		// Token: 0x06000F01 RID: 3841 RVA: 0x000167F0 File Offset: 0x000149F0
		[NullableContext(1)]
		public unsafe static implicit operator FSoftObjectPath(in FSoftObjectPathStruct st)
		{
			fixed (FSoftObjectPathStruct* ptr = &st)
			{
				return new FSoftObjectPath(ptr, false, true);
			}
		}

		// Token: 0x06000F02 RID: 3842 RVA: 0x00016808 File Offset: 0x00014A08
		public static bool operator ==(in FSoftObjectPathStruct a, in FSoftObjectPathStruct b)
		{
			return a.AssetPathName == b.AssetPathName && a.SubPathString == b.SubPathString;
		}

		// Token: 0x06000F03 RID: 3843 RVA: 0x00016830 File Offset: 0x00014A30
		public static bool operator !=(in FSoftObjectPathStruct a, in FSoftObjectPathStruct b)
		{
			return !(a == b);
		}

		// Token: 0x06000F04 RID: 3844 RVA: 0x0001683C File Offset: 0x00014A3C
		public bool Equals(FSoftObjectPathStruct other)
		{
			return this.AssetPathName.Equals(other.AssetPathName) && this.SubPathString.Equals(other.SubPathString);
		}

		// Token: 0x06000F05 RID: 3845 RVA: 0x00016864 File Offset: 0x00014A64
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FSoftObjectPathStruct)
			{
				FSoftObjectPathStruct other = (FSoftObjectPathStruct)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06000F06 RID: 3846 RVA: 0x00016889 File Offset: 0x00014A89
		public override int GetHashCode()
		{
			return HashCode.Combine<FName, FString>(this.AssetPathName, this.SubPathString);
		}

		// Token: 0x06000F07 RID: 3847 RVA: 0x0001689C File Offset: 0x00014A9C
		[NullableContext(1)]
		public override string ToString()
		{
			if (!this.SubPathString.IsEmpty())
			{
				StringBuilder stringBuilder = new StringBuilder();
				FName assetPathName = this.AssetPathName;
				if (!assetPathName.IsNone())
				{
					stringBuilder.Append(assetPathName.ToString());
				}
				FString subPathString = this.SubPathString;
				stringBuilder.Append(':');
				stringBuilder.Append(subPathString.ToString());
				return stringBuilder.ToString();
			}
			return this.AssetPathName.ToString();
		}

		// Token: 0x040001D2 RID: 466
		[FieldOffset(0)]
		public readonly FName AssetPathName;

		// Token: 0x040001D3 RID: 467
		[FieldOffset(16)]
		private readonly FString SubPathString;
	}
}
