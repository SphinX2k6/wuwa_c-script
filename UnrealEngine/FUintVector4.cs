using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200003F RID: 63
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 16)]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 16)]
	public struct FUintVector4 : IEquatable<FUintVector4>
	{
		// Token: 0x060005CA RID: 1482 RVA: 0x0000D18F File Offset: 0x0000B38F
		public FUintVector4()
		{
			this.X = 0U;
			this.Y = 0U;
			this.Z = 0U;
			this.W = 0U;
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x0000D1AD File Offset: 0x0000B3AD
		public FUintVector4(uint x, uint y, uint z, uint w)
		{
			this.X = x;
			this.Y = y;
			this.Z = z;
			this.W = w;
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x0000D1CC File Offset: 0x0000B3CC
		public FUintVector4(uint value)
		{
			this.X = value;
			this.Y = value;
			this.Z = value;
			this.W = value;
		}

		// Token: 0x17000016 RID: 22
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

		// Token: 0x060005CF RID: 1487 RVA: 0x0000D27B File Offset: 0x0000B47B
		public static bool operator ==(FUintVector4 a, FUintVector4 b)
		{
			return a.X == b.X && a.Y == b.Y && a.Z == b.Z && a.W == b.W;
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x0000D2B7 File Offset: 0x0000B4B7
		public static bool operator !=(FUintVector4 a, FUintVector4 b)
		{
			return a.X != b.X || a.Y != b.Y || a.Z != b.Z || a.W != b.W;
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x0000D2F6 File Offset: 0x0000B4F6
		public readonly bool Equals(FUintVector4 other)
		{
			return this == other;
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x0000D304 File Offset: 0x0000B504
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

		// Token: 0x060005D3 RID: 1491 RVA: 0x0000D32E File Offset: 0x0000B52E
		public override readonly int GetHashCode()
		{
			return HashCode.Combine<uint, uint, uint, uint>(this.X, this.Y, this.Z, this.W);
		}

		// Token: 0x04000105 RID: 261
		[FieldOffset(0)]
		public uint X;

		// Token: 0x04000106 RID: 262
		[FieldOffset(4)]
		public uint Y;

		// Token: 0x04000107 RID: 263
		[FieldOffset(8)]
		public uint Z;

		// Token: 0x04000108 RID: 264
		[FieldOffset(12)]
		public uint W;
	}
}
