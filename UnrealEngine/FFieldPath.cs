using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200007C RID: 124
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.FieldPath, PropertiesSize = 32)]
	[StructLayout(LayoutKind.Explicit, Pack = 8, Size = 32)]
	public struct FFieldPath : IEqualityOperators<FFieldPath, FFieldPath, bool>, IEquatable<FFieldPath>
	{
		// Token: 0x06000E7F RID: 3711 RVA: 0x00015DD7 File Offset: 0x00013FD7
		public FFieldPath()
		{
			this.ResolvedField = (IntPtr)0;
			this.ResolvedOwner = default(TWeakObjectPtr<UStruct>);
			this.Path = default(FScriptArray_NativeStruct);
		}

		// Token: 0x06000E80 RID: 3712 RVA: 0x00015DF9 File Offset: 0x00013FF9
		public static bool operator ==(FFieldPath left, FFieldPath right)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000E81 RID: 3713 RVA: 0x00015E00 File Offset: 0x00014000
		public static bool operator !=(FFieldPath left, FFieldPath right)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000E82 RID: 3714 RVA: 0x00015E07 File Offset: 0x00014007
		public bool Equals(FFieldPath other)
		{
			return this == other;
		}

		// Token: 0x06000E83 RID: 3715 RVA: 0x00015E18 File Offset: 0x00014018
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is FFieldPath)
			{
				FFieldPath other = (FFieldPath)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06000E84 RID: 3716 RVA: 0x00015E3D File Offset: 0x0001403D
		public override int GetHashCode()
		{
			throw new NotImplementedException();
		}

		// Token: 0x040001BF RID: 447
		[FieldOffset(0)]
		private IntPtr ResolvedField;

		// Token: 0x040001C0 RID: 448
		[Nullable(new byte[]
		{
			0,
			1
		})]
		[FieldOffset(8)]
		private TWeakObjectPtr<UStruct> ResolvedOwner;

		// Token: 0x040001C1 RID: 449
		[FieldOffset(16)]
		private FScriptArray_NativeStruct Path;
	}
}
