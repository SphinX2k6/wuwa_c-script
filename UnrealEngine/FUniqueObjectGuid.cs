using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200006F RID: 111
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 16)]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 16)]
	public struct FUniqueObjectGuid : IEqualityOperators<FUniqueObjectGuid, FUniqueObjectGuid, bool>, IEquatable<FUniqueObjectGuid>
	{
		// Token: 0x06000B0B RID: 2827 RVA: 0x00011D28 File Offset: 0x0000FF28
		public static bool operator ==(FUniqueObjectGuid left, FUniqueObjectGuid right)
		{
			return left.Guid == right.Guid;
		}

		// Token: 0x06000B0C RID: 2828 RVA: 0x00011D3B File Offset: 0x0000FF3B
		public static bool operator !=(FUniqueObjectGuid left, FUniqueObjectGuid right)
		{
			return left.Guid != right.Guid;
		}

		// Token: 0x06000B0D RID: 2829 RVA: 0x00011D4E File Offset: 0x0000FF4E
		public bool Equals(FUniqueObjectGuid other)
		{
			return this.Guid == other.Guid;
		}

		// Token: 0x06000B0E RID: 2830 RVA: 0x00011D64 File Offset: 0x0000FF64
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FUniqueObjectGuid)
			{
				FUniqueObjectGuid other = (FUniqueObjectGuid)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06000B0F RID: 2831 RVA: 0x00011D89 File Offset: 0x0000FF89
		public override int GetHashCode()
		{
			return this.Guid.GetHashCode();
		}

		// Token: 0x0400019A RID: 410
		[FieldOffset(0)]
		public FGuid Guid;
	}
}
