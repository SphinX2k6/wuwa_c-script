using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200008A RID: 138
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 16)]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 16)]
	public struct FUniqueObjectGuid : IEqualityOperators<FUniqueObjectGuid, FUniqueObjectGuid, bool>, IEquatable<FUniqueObjectGuid>
	{
		// Token: 0x06000F78 RID: 3960 RVA: 0x00017004 File Offset: 0x00015204
		public static bool operator ==(FUniqueObjectGuid left, FUniqueObjectGuid right)
		{
			return left.Guid == right.Guid;
		}

		// Token: 0x06000F79 RID: 3961 RVA: 0x00017017 File Offset: 0x00015217
		public static bool operator !=(FUniqueObjectGuid left, FUniqueObjectGuid right)
		{
			return left.Guid != right.Guid;
		}

		// Token: 0x06000F7A RID: 3962 RVA: 0x0001702A File Offset: 0x0001522A
		public bool Equals(FUniqueObjectGuid other)
		{
			return this.Guid == other.Guid;
		}

		// Token: 0x06000F7B RID: 3963 RVA: 0x00017040 File Offset: 0x00015240
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

		// Token: 0x06000F7C RID: 3964 RVA: 0x00017065 File Offset: 0x00015265
		public override int GetHashCode()
		{
			return this.Guid.GetHashCode();
		}

		// Token: 0x040001E1 RID: 481
		[FieldOffset(0)]
		public FGuid Guid;
	}
}
