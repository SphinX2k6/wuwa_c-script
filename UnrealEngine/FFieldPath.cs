using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000061 RID: 97
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.FieldPath, PropertiesSize = 32)]
	[StructLayout(LayoutKind.Explicit, Pack = 8, Size = 32)]
	public struct FFieldPath : IEqualityOperators<FFieldPath, FFieldPath, bool>, IEquatable<FFieldPath>
	{
		// Token: 0x06000A12 RID: 2578 RVA: 0x00010AF7 File Offset: 0x0000ECF7
		public FFieldPath()
		{
			this.ResolvedField = (IntPtr)0;
			this.ResolvedOwner = default(TWeakObjectPtr<UStruct>);
			this.Path = default(FScriptArray_NativeStruct);
		}

		// Token: 0x06000A13 RID: 2579 RVA: 0x00010B19 File Offset: 0x0000ED19
		public static bool operator ==(FFieldPath left, FFieldPath right)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000A14 RID: 2580 RVA: 0x00010B20 File Offset: 0x0000ED20
		public static bool operator !=(FFieldPath left, FFieldPath right)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000A15 RID: 2581 RVA: 0x00010B27 File Offset: 0x0000ED27
		public bool Equals(FFieldPath other)
		{
			return this == other;
		}

		// Token: 0x06000A16 RID: 2582 RVA: 0x00010B38 File Offset: 0x0000ED38
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

		// Token: 0x06000A17 RID: 2583 RVA: 0x00010B5D File Offset: 0x0000ED5D
		public override int GetHashCode()
		{
			throw new NotImplementedException();
		}

		// Token: 0x04000178 RID: 376
		[FieldOffset(0)]
		private IntPtr ResolvedField;

		// Token: 0x04000179 RID: 377
		[Nullable(new byte[]
		{
			0,
			1
		})]
		[FieldOffset(8)]
		private TWeakObjectPtr<UStruct> ResolvedOwner;

		// Token: 0x0400017A RID: 378
		[FieldOffset(16)]
		private FScriptArray_NativeStruct Path;
	}
}
