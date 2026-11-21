using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000062 RID: 98
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.LazyObject)]
	[UnrealStructLayout(28, 4, UnrealReflectionPropertyTypeCode.LazyObject, PropertiesSize = 28)]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 28)]
	public struct FLazyObjectPtr : IEqualityOperators<FLazyObjectPtr, FLazyObjectPtr, bool>, IEquatable<FLazyObjectPtr>
	{
		// Token: 0x06000A18 RID: 2584 RVA: 0x00010B64 File Offset: 0x0000ED64
		public FLazyObjectPtr()
		{
			this.WeakObjectPtr = default(FWeakObjectPtr);
			this.TagAtLastTest = 0;
			this.Guid = default(FUniqueObjectGuid);
		}

		// Token: 0x06000A19 RID: 2585 RVA: 0x00010B88 File Offset: 0x0000ED88
		[NullableContext(2)]
		public unsafe FLazyObjectPtr(UnrealObject obj)
		{
			this.WeakObjectPtr = default(FWeakObjectPtr);
			this.TagAtLastTest = 0;
			this.Guid = default(FUniqueObjectGuid);
			if (obj != null)
			{
				IntPtr nativePtr = obj._NativePtr;
				fixed (FLazyObjectPtr* ptr = &this)
				{
					FLazyObjectPtr.Construct(ptr, obj._NativePtr);
				}
			}
		}

		// Token: 0x06000A1A RID: 2586 RVA: 0x00010BD0 File Offset: 0x0000EDD0
		public void Reset()
		{
			this = new FLazyObjectPtr();
		}

		// Token: 0x06000A1B RID: 2587 RVA: 0x00010BDD File Offset: 0x0000EDDD
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public readonly FUniqueObjectGuid GetUniqueID()
		{
			return this.Guid;
		}

		// Token: 0x06000A1C RID: 2588 RVA: 0x00010BE8 File Offset: 0x0000EDE8
		[NullableContext(2)]
		public unsafe readonly UnrealUObject Get()
		{
			fixed (FLazyObjectPtr* ptr = &this)
			{
				return BuiltinUtils.GetOrCreateUObjectByNativePointer(FLazyObjectPtr.Get(ptr));
			}
		}

		// Token: 0x06000A1D RID: 2589 RVA: 0x00010C04 File Offset: 0x0000EE04
		[NullableContext(2)]
		public unsafe readonly UnrealUObject Get(bool bEvenIfPendingKill)
		{
			fixed (FLazyObjectPtr* ptr = &this)
			{
				return BuiltinUtils.GetOrCreateUObjectByNativePointer(FLazyObjectPtr.Get_bool(ptr, bEvenIfPendingKill));
			}
		}

		// Token: 0x06000A1E RID: 2590 RVA: 0x00010C20 File Offset: 0x0000EE20
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public readonly bool IsValid()
		{
			return this.Get() != null;
		}

		// Token: 0x06000A1F RID: 2591 RVA: 0x00010C2B File Offset: 0x0000EE2B
		public readonly bool IsPending()
		{
			return this.Get() == null && this.Guid.Guid.IsValid();
		}

		// Token: 0x06000A20 RID: 2592 RVA: 0x00010C47 File Offset: 0x0000EE47
		public readonly bool IsNull()
		{
			return !this.Guid.Guid.IsValid();
		}

		// Token: 0x06000A21 RID: 2593 RVA: 0x00010C5C File Offset: 0x0000EE5C
		public static bool operator ==(FLazyObjectPtr left, FLazyObjectPtr right)
		{
			return left.Guid == right.Guid;
		}

		// Token: 0x06000A22 RID: 2594 RVA: 0x00010C6F File Offset: 0x0000EE6F
		public static bool operator !=(FLazyObjectPtr left, FLazyObjectPtr right)
		{
			return !(left == right);
		}

		// Token: 0x06000A23 RID: 2595 RVA: 0x00010C7B File Offset: 0x0000EE7B
		public readonly bool Equals(FLazyObjectPtr other)
		{
			return this.Guid == other.Guid;
		}

		// Token: 0x06000A24 RID: 2596 RVA: 0x00010C90 File Offset: 0x0000EE90
		[NullableContext(2)]
		public override readonly bool Equals(object obj)
		{
			if (obj is FLazyObjectPtr)
			{
				FLazyObjectPtr other = (FLazyObjectPtr)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06000A25 RID: 2597 RVA: 0x00010CB8 File Offset: 0x0000EEB8
		public override readonly int GetHashCode()
		{
			return this.Guid.GetHashCode();
		}

		// Token: 0x06000A26 RID: 2598
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern void Construct(FLazyObjectPtr* LazyObjectPtr, IntPtr UObject);

		// Token: 0x06000A27 RID: 2599
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern IntPtr Get(FLazyObjectPtr* LazyObjectPtr);

		// Token: 0x06000A28 RID: 2600
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern IntPtr Get_bool(FLazyObjectPtr* LazyObjectPtr, bool bEvenIfPendingKill);

		// Token: 0x0400017B RID: 379
		[FieldOffset(0)]
		private readonly FWeakObjectPtr WeakObjectPtr;

		// Token: 0x0400017C RID: 380
		[FieldOffset(8)]
		private readonly int TagAtLastTest;

		// Token: 0x0400017D RID: 381
		[FieldOffset(12)]
		private readonly FUniqueObjectGuid Guid;
	}
}
