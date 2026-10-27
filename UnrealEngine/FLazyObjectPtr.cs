using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200007D RID: 125
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.LazyObject)]
	[UnrealStructLayout(28, 4, UnrealReflectionPropertyTypeCode.LazyObject, PropertiesSize = 28)]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 28)]
	public struct FLazyObjectPtr : IEqualityOperators<FLazyObjectPtr, FLazyObjectPtr, bool>, IEquatable<FLazyObjectPtr>
	{
		// Token: 0x06000E85 RID: 3717 RVA: 0x00015E44 File Offset: 0x00014044
		public FLazyObjectPtr()
		{
			this.WeakObjectPtr = default(FWeakObjectPtr);
			this.TagAtLastTest = 0;
			this.Guid = default(FUniqueObjectGuid);
		}

		// Token: 0x06000E86 RID: 3718 RVA: 0x00015E68 File Offset: 0x00014068
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

		// Token: 0x06000E87 RID: 3719 RVA: 0x00015EB0 File Offset: 0x000140B0
		public void Reset()
		{
			this = new FLazyObjectPtr();
		}

		// Token: 0x06000E88 RID: 3720 RVA: 0x00015EBD File Offset: 0x000140BD
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public readonly FUniqueObjectGuid GetUniqueID()
		{
			return this.Guid;
		}

		// Token: 0x06000E89 RID: 3721 RVA: 0x00015EC8 File Offset: 0x000140C8
		[NullableContext(2)]
		public unsafe readonly UnrealUObject Get()
		{
			fixed (FLazyObjectPtr* ptr = &this)
			{
				return BuiltinUtils.GetOrCreateUObjectByNativePointer(FLazyObjectPtr.Get(ptr));
			}
		}

		// Token: 0x06000E8A RID: 3722 RVA: 0x00015EE4 File Offset: 0x000140E4
		[NullableContext(2)]
		public unsafe readonly UnrealUObject Get(bool bEvenIfPendingKill)
		{
			fixed (FLazyObjectPtr* ptr = &this)
			{
				return BuiltinUtils.GetOrCreateUObjectByNativePointer(FLazyObjectPtr.Get_bool(ptr, bEvenIfPendingKill));
			}
		}

		// Token: 0x06000E8B RID: 3723 RVA: 0x00015F00 File Offset: 0x00014100
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public readonly bool IsValid()
		{
			return this.Get() != null;
		}

		// Token: 0x06000E8C RID: 3724 RVA: 0x00015F0B File Offset: 0x0001410B
		public readonly bool IsPending()
		{
			return this.Get() == null && this.Guid.Guid.IsValid();
		}

		// Token: 0x06000E8D RID: 3725 RVA: 0x00015F27 File Offset: 0x00014127
		public readonly bool IsNull()
		{
			return !this.Guid.Guid.IsValid();
		}

		// Token: 0x06000E8E RID: 3726 RVA: 0x00015F3C File Offset: 0x0001413C
		public static bool operator ==(FLazyObjectPtr left, FLazyObjectPtr right)
		{
			return left.Guid == right.Guid;
		}

		// Token: 0x06000E8F RID: 3727 RVA: 0x00015F4F File Offset: 0x0001414F
		public static bool operator !=(FLazyObjectPtr left, FLazyObjectPtr right)
		{
			return !(left == right);
		}

		// Token: 0x06000E90 RID: 3728 RVA: 0x00015F5B File Offset: 0x0001415B
		public readonly bool Equals(FLazyObjectPtr other)
		{
			return this.Guid == other.Guid;
		}

		// Token: 0x06000E91 RID: 3729 RVA: 0x00015F70 File Offset: 0x00014170
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

		// Token: 0x06000E92 RID: 3730 RVA: 0x00015F98 File Offset: 0x00014198
		public override readonly int GetHashCode()
		{
			return this.Guid.GetHashCode();
		}

		// Token: 0x06000E93 RID: 3731
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern void Construct(FLazyObjectPtr* LazyObjectPtr, IntPtr UObject);

		// Token: 0x06000E94 RID: 3732
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern IntPtr Get(FLazyObjectPtr* LazyObjectPtr);

		// Token: 0x06000E95 RID: 3733
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern IntPtr Get_bool(FLazyObjectPtr* LazyObjectPtr, bool bEvenIfPendingKill);

		// Token: 0x040001C2 RID: 450
		[FieldOffset(0)]
		private readonly FWeakObjectPtr WeakObjectPtr;

		// Token: 0x040001C3 RID: 451
		[FieldOffset(8)]
		private readonly int TagAtLastTest;

		// Token: 0x040001C4 RID: 452
		[FieldOffset(12)]
		private readonly FUniqueObjectGuid Guid;
	}
}
