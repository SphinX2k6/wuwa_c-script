using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000011 RID: 17
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 8)]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 8)]
	public struct FIntVector2 : IEquatable<FIntVector2>, IEqualityOperators<FIntVector2, FIntVector2, bool>
	{
		// Token: 0x0600019A RID: 410 RVA: 0x00004714 File Offset: 0x00002914
		public FIntVector2()
		{
			this.X = 0;
			this.Y = 0;
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00004724 File Offset: 0x00002924
		public FIntVector2(int x, int y)
		{
			this.X = x;
			this.Y = y;
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00004734 File Offset: 0x00002934
		public FIntVector2(int value)
		{
			this.X = value;
			this.Y = value;
		}

		// Token: 0x17000005 RID: 5
		public int this[int index]
		{
			readonly get
			{
				int result;
				if (index != 0)
				{
					if (index != 1)
					{
						throw new IndexOutOfRangeException();
					}
					result = this.Y;
				}
				else
				{
					result = this.X;
				}
				return result;
			}
			set
			{
				if (index == 0)
				{
					this.X = value;
					return;
				}
				if (index != 1)
				{
					throw new IndexOutOfRangeException();
				}
				this.Y = value;
			}
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00004793 File Offset: 0x00002993
		public static bool operator ==(FIntVector2 a, FIntVector2 b)
		{
			return a.X == b.X && a.Y == b.Y;
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x000047B3 File Offset: 0x000029B3
		public static bool operator !=(FIntVector2 a, FIntVector2 b)
		{
			return a.X != b.X || a.Y != b.Y;
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x000047D6 File Offset: 0x000029D6
		public readonly bool Equals(FIntVector2 other)
		{
			return this == other;
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x000047E4 File Offset: 0x000029E4
		[NullableContext(2)]
		public override readonly bool Equals(object obj)
		{
			if (obj is FIntVector2)
			{
				FIntVector2 b = (FIntVector2)obj;
				return this == b;
			}
			return false;
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x0000480E File Offset: 0x00002A0E
		public override readonly int GetHashCode()
		{
			return HashCode.Combine<int, int>(this.X, this.Y);
		}

		// Token: 0x04000062 RID: 98
		[FieldOffset(0)]
		public int X;

		// Token: 0x04000063 RID: 99
		[FieldOffset(4)]
		public int Y;
	}
}
