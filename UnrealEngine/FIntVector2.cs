using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200002C RID: 44
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 8)]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 8)]
	public struct FIntVector2 : IEquatable<FIntVector2>, IEqualityOperators<FIntVector2, FIntVector2, bool>
	{
		// Token: 0x06000215 RID: 533 RVA: 0x00007EA8 File Offset: 0x000060A8
		public FIntVector2()
		{
			this.X = 0;
			this.Y = 0;
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00007EB8 File Offset: 0x000060B8
		public FIntVector2(int x, int y)
		{
			this.X = x;
			this.Y = y;
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00007EC8 File Offset: 0x000060C8
		public FIntVector2(int value)
		{
			this.X = value;
			this.Y = value;
		}

		// Token: 0x17000006 RID: 6
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

		// Token: 0x0600021A RID: 538 RVA: 0x00007F27 File Offset: 0x00006127
		public static bool operator ==(FIntVector2 a, FIntVector2 b)
		{
			return a.X == b.X && a.Y == b.Y;
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00007F47 File Offset: 0x00006147
		public static bool operator !=(FIntVector2 a, FIntVector2 b)
		{
			return a.X != b.X || a.Y != b.Y;
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00007F6A File Offset: 0x0000616A
		public readonly bool Equals(FIntVector2 other)
		{
			return this == other;
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00007F78 File Offset: 0x00006178
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

		// Token: 0x0600021E RID: 542 RVA: 0x00007FA2 File Offset: 0x000061A2
		public override readonly int GetHashCode()
		{
			return HashCode.Combine<int, int>(this.X, this.Y);
		}

		// Token: 0x040000A9 RID: 169
		[FieldOffset(0)]
		public int X;

		// Token: 0x040000AA RID: 170
		[FieldOffset(4)]
		public int Y;
	}
}
