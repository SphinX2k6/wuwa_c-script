using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200008B RID: 139
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.WeakObject)]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.WeakObject, PropertiesSize = 8)]
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct FWeakObjectPtr : IEqualityOperators<FWeakObjectPtr, FWeakObjectPtr, bool>, IEquatable<FWeakObjectPtr>
	{
		// Token: 0x06000F7D RID: 3965 RVA: 0x00017078 File Offset: 0x00015278
		public FWeakObjectPtr(int InObjectIndex = -1, int InObjectSerialNumber = 0)
		{
			this.ObjectIndex = InObjectIndex;
			this.ObjectSerialNumber = InObjectSerialNumber;
		}

		// Token: 0x06000F7E RID: 3966 RVA: 0x00017088 File Offset: 0x00015288
		[NullableContext(2)]
		public FWeakObjectPtr(UnrealUObject Object)
		{
			this.ObjectIndex = 0;
			this.ObjectSerialNumber = 0;
			if (Object != null && Object.IsValid())
			{
				BuiltinUtils.GetUObjectIndexAndSerialNumber(Object._NativePtr, out this.ObjectIndex, out this.ObjectSerialNumber);
				return;
			}
			this.Reset();
		}

		// Token: 0x06000F7F RID: 3967 RVA: 0x000170C1 File Offset: 0x000152C1
		public FWeakObjectPtr(UClassStackOnlyPtr ClassPtr)
		{
			this.ObjectIndex = 0;
			this.ObjectSerialNumber = 0;
			if (ClassPtr._NativePtr != IntPtr.Zero && ClassPtr.IsValid())
			{
				BuiltinUtils.GetClassIndexAndSerialNumber(ClassPtr, out this.ObjectIndex, out this.ObjectSerialNumber);
				return;
			}
			this.Reset();
		}

		// Token: 0x06000F80 RID: 3968 RVA: 0x00017100 File Offset: 0x00015300
		public void Reset()
		{
			this.ObjectIndex = -1;
			this.ObjectSerialNumber = 0;
		}

		// Token: 0x06000F81 RID: 3969 RVA: 0x00017110 File Offset: 0x00015310
		public unsafe readonly bool IsValid(bool bEvenIfPendingKill = false, bool bThreadsafeTest = false)
		{
			if (this.ObjectIndex < 0 || this.ObjectSerialNumber == 0)
			{
				return false;
			}
			fixed (FWeakObjectPtr* ptr = &this)
			{
				return FWeakObjectPtr.Internal_IsValid(ptr, bEvenIfPendingKill, bThreadsafeTest);
			}
		}

		// Token: 0x06000F82 RID: 3970 RVA: 0x0001713B File Offset: 0x0001533B
		[NullableContext(2)]
		public readonly UnrealUObject Get()
		{
			return BuiltinUtils.GetOrCreateUObjectByIndexAndSerialNumberInternal(this.ObjectIndex, this.ObjectSerialNumber);
		}

		// Token: 0x06000F83 RID: 3971 RVA: 0x0001714E File Offset: 0x0001534E
		public readonly IntPtr GetNativePtr()
		{
			return BuiltinUtils.GetNativePtrByIndexAndSerialNumberInternal(this.ObjectIndex, this.ObjectSerialNumber);
		}

		// Token: 0x06000F84 RID: 3972 RVA: 0x00017161 File Offset: 0x00015361
		[NullableContext(1)]
		public readonly string GetName()
		{
			return UObjectGlobals.GetName(this.GetNativePtr());
		}

		// Token: 0x06000F85 RID: 3973 RVA: 0x0001716E File Offset: 0x0001536E
		public readonly FName GetFName()
		{
			return UObjectGlobals.GetFName(this.GetNativePtr());
		}

		// Token: 0x06000F86 RID: 3974 RVA: 0x0001717B File Offset: 0x0001537B
		public static bool operator ==(FWeakObjectPtr left, FWeakObjectPtr right)
		{
			return left.ObjectIndex == right.ObjectIndex && left.ObjectSerialNumber == right.ObjectSerialNumber;
		}

		// Token: 0x06000F87 RID: 3975 RVA: 0x0001719B File Offset: 0x0001539B
		public static bool operator !=(FWeakObjectPtr left, FWeakObjectPtr right)
		{
			return !(left == right);
		}

		// Token: 0x06000F88 RID: 3976 RVA: 0x000171A7 File Offset: 0x000153A7
		public readonly bool Equals(FWeakObjectPtr other)
		{
			return this.ObjectIndex == other.ObjectIndex && this.ObjectSerialNumber == other.ObjectSerialNumber;
		}

		// Token: 0x06000F89 RID: 3977 RVA: 0x000171C8 File Offset: 0x000153C8
		[NullableContext(2)]
		public override readonly bool Equals(object obj)
		{
			if (obj is FWeakObjectPtr)
			{
				FWeakObjectPtr other = (FWeakObjectPtr)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06000F8A RID: 3978 RVA: 0x000171ED File Offset: 0x000153ED
		public override readonly int GetHashCode()
		{
			return HashCode.Combine<int, int>(this.ObjectIndex, this.ObjectSerialNumber);
		}

		// Token: 0x06000F8B RID: 3979
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal unsafe static extern bool Internal_IsValid(FWeakObjectPtr* Ptr, bool bEvenIfPendingKill, bool bThreadsafeTest);

		// Token: 0x06000F8C RID: 3980 RVA: 0x00017200 File Offset: 0x00015400
		[NullableContext(1)]
		public override readonly string ToString()
		{
			IntPtr nativePtr = this.GetNativePtr();
			if (nativePtr == 0)
			{
				return "(null)";
			}
			return UObjectGlobals.GetName(nativePtr);
		}

		// Token: 0x040001E2 RID: 482
		internal int ObjectIndex;

		// Token: 0x040001E3 RID: 483
		internal int ObjectSerialNumber;
	}
}
