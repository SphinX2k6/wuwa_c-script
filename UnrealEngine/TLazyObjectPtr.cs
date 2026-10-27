using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000090 RID: 144
	[NullableContext(2)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.LazyObject)]
	[UnrealStructLayout(28, 4, UnrealReflectionPropertyTypeCode.LazyObject, PropertiesSize = 28)]
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct TLazyObjectPtr<[Nullable(0)] T> : IEqualityOperators<TLazyObjectPtr<T>, TLazyObjectPtr<T>, bool>, IEquatable<TLazyObjectPtr<T>> where T : UnrealUObject, IUnrealUObject
	{
		// Token: 0x06000FD9 RID: 4057 RVA: 0x0001818C File Offset: 0x0001638C
		public TLazyObjectPtr()
		{
			this.LazyObjectPtr = default(FLazyObjectPtr);
		}

		// Token: 0x06000FDA RID: 4058 RVA: 0x0001819A File Offset: 0x0001639A
		public TLazyObjectPtr(T obj)
		{
			this.LazyObjectPtr = new FLazyObjectPtr(obj);
		}

		// Token: 0x06000FDB RID: 4059 RVA: 0x000181AD File Offset: 0x000163AD
		public TLazyObjectPtr(in FLazyObjectPtr lazyObjectPtr)
		{
			this.LazyObjectPtr = lazyObjectPtr;
		}

		// Token: 0x06000FDC RID: 4060 RVA: 0x000181BB File Offset: 0x000163BB
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public FUniqueObjectGuid GetUniqueID()
		{
			return this.LazyObjectPtr.GetUniqueID();
		}

		// Token: 0x06000FDD RID: 4061 RVA: 0x000181C8 File Offset: 0x000163C8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public T Get()
		{
			return (T)((object)this.LazyObjectPtr.Get());
		}

		// Token: 0x06000FDE RID: 4062 RVA: 0x000181DA File Offset: 0x000163DA
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool IsValid()
		{
			return this.Get() != null;
		}

		// Token: 0x06000FDF RID: 4063 RVA: 0x000181EA File Offset: 0x000163EA
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

		// Token: 0x06000FE0 RID: 4064 RVA: 0x000181FD File Offset: 0x000163FD
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

		// Token: 0x06000FE1 RID: 4065 RVA: 0x00018210 File Offset: 0x00016410
		public bool Equals([Nullable(new byte[]
		{
			0,
			1
		})] TLazyObjectPtr<T> other)
		{
			return this.LazyObjectPtr.Equals(other.LazyObjectPtr);
		}

		// Token: 0x06000FE2 RID: 4066 RVA: 0x00018224 File Offset: 0x00016424
		public override bool Equals(object obj)
		{
			if (obj is TLazyObjectPtr<T>)
			{
				TLazyObjectPtr<T> other = (TLazyObjectPtr<T>)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06000FE3 RID: 4067 RVA: 0x00018249 File Offset: 0x00016449
		public override int GetHashCode()
		{
			return this.LazyObjectPtr.GetHashCode();
		}

		// Token: 0x06000FE4 RID: 4068 RVA: 0x0001825C File Offset: 0x0001645C
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static implicit operator TLazyObjectPtr<T>(in T obj)
		{
			return new TLazyObjectPtr<T>(obj);
		}

		// Token: 0x06000FE5 RID: 4069 RVA: 0x00018269 File Offset: 0x00016469
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static implicit operator TLazyObjectPtr<T>(in FLazyObjectPtr lazyObjectPtr)
		{
			return new TLazyObjectPtr<T>(ref lazyObjectPtr);
		}

		// Token: 0x06000FE6 RID: 4070 RVA: 0x00018271 File Offset: 0x00016471
		public static implicit operator FLazyObjectPtr([Nullable(new byte[]
		{
			0,
			1
		})] in TLazyObjectPtr<T> lazyObjectPtr)
		{
			return lazyObjectPtr.LazyObjectPtr;
		}

		// Token: 0x040001F8 RID: 504
		private FLazyObjectPtr LazyObjectPtr;
	}
}
