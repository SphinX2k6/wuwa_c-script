using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000074 RID: 116
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.FieldPath)]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.FieldPath, PropertiesSize = 32)]
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct TFieldPath<T> : IEqualityOperators<TFieldPath<T>, TFieldPath<T>, bool>, IEquatable<TFieldPath<T>>
	{
		// Token: 0x06000B67 RID: 2919 RVA: 0x00012E6E File Offset: 0x0001106E
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

		// Token: 0x06000B68 RID: 2920 RVA: 0x00012E75 File Offset: 0x00011075
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

		// Token: 0x06000B69 RID: 2921 RVA: 0x00012E7C File Offset: 0x0001107C
		public bool Equals([Nullable(new byte[]
		{
			0,
			1
		})] TFieldPath<T> other)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000B6A RID: 2922 RVA: 0x00012E84 File Offset: 0x00011084
		public override bool Equals(object obj)
		{
			if (obj is TFieldPath<T>)
			{
				TFieldPath<T> other = (TFieldPath<T>)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06000B6B RID: 2923 RVA: 0x00012EA9 File Offset: 0x000110A9
		public override int GetHashCode()
		{
			throw new NotImplementedException();
		}

		// Token: 0x040001B0 RID: 432
		private FFieldPath FieldPath;
	}
}
