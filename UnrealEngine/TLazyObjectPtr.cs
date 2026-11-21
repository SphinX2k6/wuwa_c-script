using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000075 RID: 117
	[NullableContext(2)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.LazyObject)]
	[UnrealStructLayout(28, 4, UnrealReflectionPropertyTypeCode.LazyObject, PropertiesSize = 28)]
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct TLazyObjectPtr<[Nullable(0)] T> : IEqualityOperators<TLazyObjectPtr<T>, TLazyObjectPtr<T>, bool>, IEquatable<TLazyObjectPtr<T>> where T : UnrealUObject, IUnrealUObject
	{
		// Token: 0x06000B6C RID: 2924 RVA: 0x00012EB0 File Offset: 0x000110B0
		public TLazyObjectPtr()
		{
			this.LazyObjectPtr = default(FLazyObjectPtr);
		}

		// Token: 0x06000B6D RID: 2925 RVA: 0x00012EBE File Offset: 0x000110BE
		public TLazyObjectPtr(T obj)
		{
			this.LazyObjectPtr = new FLazyObjectPtr(obj);
		}

		// Token: 0x06000B6E RID: 2926 RVA: 0x00012ED1 File Offset: 0x000110D1
		public TLazyObjectPtr(in FLazyObjectPtr lazyObjectPtr)
		{
			this.LazyObjectPtr = lazyObjectPtr;
		}

		// Token: 0x06000B6F RID: 2927 RVA: 0x00012EDF File Offset: 0x000110DF
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public FUniqueObjectGuid GetUniqueID()
		{
			return this.LazyObjectPtr.GetUniqueID();
		}

		// Token: 0x06000B70 RID: 2928 RVA: 0x00012EEC File Offset: 0x000110EC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public T Get()
		{
			return (T)((object)this.LazyObjectPtr.Get());
		}

		// Token: 0x06000B71 RID: 2929 RVA: 0x00012EFE File Offset: 0x000110FE
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool IsValid()
		{
			return this.Get() != null;
		}

		// Token: 0x06000B72 RID: 2930 RVA: 0x00012F0E File Offset: 0x0001110E
		public static bool operator ==([Nullable(new byte[]
		{
			0,
			1
		})] TLazyObjectPtr<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] TLazyObjectPtr<T> right)
		{
			return left.LazyObjectPtr == right.LazyObjectPtr;
		}

		// Token: 0x06000B73 RID: 2931 RVA: 0x00012F21 File Offset: 0x00011121
		public static bool operator !=([Nullable(new byte[]
		{
			0,
			1
		})] TLazyObjectPtr<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] TLazyObjectPtr<T> right)
		{
			return left.LazyObjectPtr != right.LazyObjectPtr;
		}

		// Token: 0x06000B74 RID: 2932 RVA: 0x00012F34 File Offset: 0x00011134
		public bool Equals([Nullable(new byte[]
		{
			0,
			1
		})] TLazyObjectPtr<T> other)
		{
			return this.LazyObjectPtr.Equals(other.LazyObjectPtr);
		}

		// Token: 0x06000B75 RID: 2933 RVA: 0x00012F48 File Offset: 0x00011148
		public override bool Equals(object obj)
		{
			if (obj is TLazyObjectPtr<T>)
			{
				TLazyObjectPtr<T> other = (TLazyObjectPtr<T>)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06000B76 RID: 2934 RVA: 0x00012F6D File Offset: 0x0001116D
		public override int GetHashCode()
		{
			return this.LazyObjectPtr.GetHashCode();
		}

		// Token: 0x06000B77 RID: 2935 RVA: 0x00012F80 File Offset: 0x00011180
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static implicit operator TLazyObjectPtr<T>(in T obj)
		{
			return new TLazyObjectPtr<T>(obj);
		}

		// Token: 0x06000B78 RID: 2936 RVA: 0x00012F8D File Offset: 0x0001118D
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static implicit operator TLazyObjectPtr<T>(in FLazyObjectPtr lazyObjectPtr)
		{
			return new TLazyObjectPtr<T>(ref lazyObjectPtr);
		}

		// Token: 0x06000B79 RID: 2937 RVA: 0x00012F95 File Offset: 0x00011195
		public static implicit operator FLazyObjectPtr([Nullable(new byte[]
		{
			0,
			1
		})] in TLazyObjectPtr<T> lazyObjectPtr)
		{
			return lazyObjectPtr.LazyObjectPtr;
		}

		// Token: 0x040001B1 RID: 433
		private FLazyObjectPtr LazyObjectPtr;
	}
}
