using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000070 RID: 112
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.WeakObject)]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.WeakObject, PropertiesSize = 8)]
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct FWeakObjectPtr : IEqualityOperators<FWeakObjectPtr, FWeakObjectPtr, bool>, IEquatable<FWeakObjectPtr>
	{
		// Token: 0x06000B10 RID: 2832 RVA: 0x00011D9C File Offset: 0x0000FF9C
		public FWeakObjectPtr(int InObjectIndex = -1, int InObjectSerialNumber = 0)
		{
			this.ObjectIndex = InObjectIndex;
			this.ObjectSerialNumber = InObjectSerialNumber;
		}

		// Token: 0x06000B11 RID: 2833 RVA: 0x00011DAC File Offset: 0x0000FFAC
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

		// Token: 0x06000B12 RID: 2834 RVA: 0x00011DE5 File Offset: 0x0000FFE5
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

		// Token: 0x06000B13 RID: 2835 RVA: 0x00011E24 File Offset: 0x00010024
		public void Reset()
		{
			this.ObjectIndex = -1;
			this.ObjectSerialNumber = 0;
		}

		// Token: 0x06000B14 RID: 2836 RVA: 0x00011E34 File Offset: 0x00010034
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

		// Token: 0x06000B15 RID: 2837 RVA: 0x00011E5F File Offset: 0x0001005F
		[NullableContext(2)]
		public readonly UnrealUObject Get()
		{
			return BuiltinUtils.GetOrCreateUObjectByIndexAndSerialNumberInternal(this.ObjectIndex, this.ObjectSerialNumber);
		}

		// Token: 0x06000B16 RID: 2838 RVA: 0x00011E72 File Offset: 0x00010072
		public readonly IntPtr GetNativePtr()
		{
			return BuiltinUtils.GetNativePtrByIndexAndSerialNumberInternal(this.ObjectIndex, this.ObjectSerialNumber);
		}

		// Token: 0x06000B17 RID: 2839 RVA: 0x00011E85 File Offset: 0x00010085
		[NullableContext(1)]
		public readonly string GetName()
		{
			return UObjectGlobals.GetName(this.GetNativePtr());
		}

		// Token: 0x06000B18 RID: 2840 RVA: 0x00011E92 File Offset: 0x00010092
		public readonly FName GetFName()
		{
			return UObjectGlobals.GetFName(this.GetNativePtr());
		}

		// Token: 0x06000B19 RID: 2841 RVA: 0x00011E9F File Offset: 0x0001009F
		public static bool operator ==(FWeakObjectPtr left, FWeakObjectPtr right)
		{
			return left.ObjectIndex == right.ObjectIndex && left.ObjectSerialNumber == right.ObjectSerialNumber;
		}

		// Token: 0x06000B1A RID: 2842 RVA: 0x00011EBF File Offset: 0x000100BF
		public static bool operator !=(FWeakObjectPtr left, FWeakObjectPtr right)
		{
			return !(left == right);
		}

		// Token: 0x06000B1B RID: 2843 RVA: 0x00011ECB File Offset: 0x000100CB
		public readonly bool Equals(FWeakObjectPtr other)
		{
			return this.ObjectIndex == other.ObjectIndex && this.ObjectSerialNumber == other.ObjectSerialNumber;
		}

		// Token: 0x06000B1C RID: 2844 RVA: 0x00011EEC File Offset: 0x000100EC
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

		// Token: 0x06000B1D RID: 2845 RVA: 0x00011F11 File Offset: 0x00010111
		public override readonly int GetHashCode()
		{
			return HashCode.Combine<int, int>(this.ObjectIndex, this.ObjectSerialNumber);
		}

		// Token: 0x06000B1E RID: 2846
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal unsafe static extern bool Internal_IsValid(FWeakObjectPtr* Ptr, bool bEvenIfPendingKill, bool bThreadsafeTest);

		// Token: 0x06000B1F RID: 2847 RVA: 0x00011F24 File Offset: 0x00010124
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

		// Token: 0x0400019B RID: 411
		internal int ObjectIndex;

		// Token: 0x0400019C RID: 412
		internal int ObjectSerialNumber;
	}
}
