using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000024 RID: 36
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 16)]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 16)]
	public struct FUintVector4 : IEquatable<FUintVector4>
	{
		// Token: 0x0600054F RID: 1359 RVA: 0x000099FB File Offset: 0x00007BFB
		public FUintVector4()
		{
			this.X = 0U;
			this.Y = 0U;
			this.Z = 0U;
			this.W = 0U;
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x00009A19 File Offset: 0x00007C19
		public FUintVector4(uint x, uint y, uint z, uint w)
		{
			this.X = x;
			this.Y = y;
			this.Z = z;
			this.W = w;
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x00009A38 File Offset: 0x00007C38
		public FUintVector4(uint value)
		{
			this.X = value;
			this.Y = value;
			this.Z = value;
			this.W = value;
		}

		// Token: 0x17000015 RID: 21
		public uint this[int index]
		{
			readonly get
			{
				uint result;
				switch (index)
				{
				case 0:
					result = this.X;
					break;
				case 1:
					result = this.Y;
					break;
				case 2:
					result = this.Z;
					break;
				case 3:
					result = this.W;
					break;
				default:
					throw new IndexOutOfRangeException();
				}
				return result;
			}
			set
			{
				switch (index)
				{
				case 0:
					this.X = value;
					return;
				case 1:
					this.Y = value;
					return;
				case 2:
					this.Z = value;
					return;
				case 3:
					this.W = value;
					return;
				default:
					throw new IndexOutOfRangeException();
				}
			}
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x00009AE7 File Offset: 0x00007CE7
		public static bool operator ==(FUintVector4 a, FUintVector4 b)
		{
			return a.X == b.X && a.Y == b.Y && a.Z == b.Z && a.W == b.W;
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x00009B23 File Offset: 0x00007D23
		public static bool operator !=(FUintVector4 a, FUintVector4 b)
		{
			return a.X != b.X || a.Y != b.Y || a.Z != b.Z || a.W != b.W;
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x00009B62 File Offset: 0x00007D62
		public readonly bool Equals(FUintVector4 other)
		{
			return this == other;
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x00009B70 File Offset: 0x00007D70
		[NullableContext(2)]
		public override readonly bool Equals(object obj)
		{
			if (obj is FUintVector4)
			{
				FUintVector4 b = (FUintVector4)obj;
				return this == b;
			}
			return false;
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x00009B9A File Offset: 0x00007D9A
		public override readonly int GetHashCode()
		{
			return HashCode.Combine<uint, uint, uint, uint>(this.X, this.Y, this.Z, this.W);
		}

		// Token: 0x040000BE RID: 190
		[FieldOffset(0)]
		public uint X;

		// Token: 0x040000BF RID: 191
		[FieldOffset(4)]
		public uint Y;

		// Token: 0x040000C0 RID: 192
		[FieldOffset(8)]
		public uint Z;

		// Token: 0x040000C1 RID: 193
		[FieldOffset(12)]
		public uint W;
	}
}
