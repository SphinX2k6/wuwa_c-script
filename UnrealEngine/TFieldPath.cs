using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200008F RID: 143
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.FieldPath)]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.FieldPath, PropertiesSize = 32)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct TFieldPath<T> : IEqualityOperators<TFieldPath<T>, TFieldPath<T>, bool>, IEquatable<TFieldPath<T>>
	{
		// Token: 0x06000FD4 RID: 4052 RVA: 0x0001814A File Offset: 0x0001634A
		public static bool operator ==([Nullable(new byte[]
		{
			0,
			1
		})] TFieldPath<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] TFieldPath<T> right)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000FD5 RID: 4053 RVA: 0x00018151 File Offset: 0x00016351
		public static bool operator !=([Nullable(new byte[]
		{
			0,
			1
		})] TFieldPath<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] TFieldPath<T> right)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000FD6 RID: 4054 RVA: 0x00018158 File Offset: 0x00016358
		public bool Equals([Nullable(new byte[]
		{
			0,
			1
		})] TFieldPath<T> other)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000FD7 RID: 4055 RVA: 0x00018160 File Offset: 0x00016360
		public override bool Equals(object obj)
		{
			if (obj is TFieldPath<T>)
			{
				TFieldPath<T> other = (TFieldPath<T>)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06000FD8 RID: 4056 RVA: 0x00018185 File Offset: 0x00016385
		public override int GetHashCode()
		{
			throw new NotImplementedException();
		}

		// Token: 0x040001F7 RID: 503
		private FFieldPath FieldPath;
	}
}
