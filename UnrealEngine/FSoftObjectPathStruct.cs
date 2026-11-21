using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace UnrealEngine
{
	// Token: 0x02000069 RID: 105
	[StructLayout(LayoutKind.Explicit)]
	public readonly struct FSoftObjectPathStruct : IEquatable<FSoftObjectPathStruct>
	{
		// Token: 0x06000A94 RID: 2708 RVA: 0x00011524 File Offset: 0x0000F724
		[NullableContext(1)]
		public unsafe static implicit operator FSoftObjectPath(in FSoftObjectPathStruct st)
		{
			fixed (FSoftObjectPathStruct* ptr = &st)
			{
				return new FSoftObjectPath(ptr, false, true);
			}
		}

		// Token: 0x06000A95 RID: 2709 RVA: 0x0001153C File Offset: 0x0000F73C
		public static bool operator ==(in FSoftObjectPathStruct a, in FSoftObjectPathStruct b)
		{
			return a.AssetPathName == b.AssetPathName && a.SubPathString == b.SubPathString;
		}

		// Token: 0x06000A96 RID: 2710 RVA: 0x00011564 File Offset: 0x0000F764
		public static bool operator !=(in FSoftObjectPathStruct a, in FSoftObjectPathStruct b)
		{
			return !(a == b);
		}

		// Token: 0x06000A97 RID: 2711 RVA: 0x00011570 File Offset: 0x0000F770
		public bool Equals(FSoftObjectPathStruct other)
		{
			return this.AssetPathName.Equals(other.AssetPathName) && this.SubPathString.Equals(other.SubPathString);
		}

		// Token: 0x06000A98 RID: 2712 RVA: 0x00011598 File Offset: 0x0000F798
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

		// Token: 0x06000A99 RID: 2713 RVA: 0x000115BD File Offset: 0x0000F7BD
		public override int GetHashCode()
		{
			return HashCode.Combine<FName, FString>(this.AssetPathName, this.SubPathString);
		}

		// Token: 0x06000A9A RID: 2714 RVA: 0x000115D0 File Offset: 0x0000F7D0
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

		// Token: 0x0400018B RID: 395
		[FieldOffset(0)]
		public readonly FName AssetPathName;

		// Token: 0x0400018C RID: 396
		[FieldOffset(16)]
		private readonly FString SubPathString;
	}
}
