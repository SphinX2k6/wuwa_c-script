using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine.Utils
{
	// Token: 0x02000899 RID: 2201
	public static class BuiltinUtils
	{
		// Token: 0x0600BDE3 RID: 48611
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern IntPtr AllocNativeUObject(UClassStackOnlyPtr UClassPtr, UnrealObject Outer = null, FName Name = default(FName), EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags);

		// Token: 0x0600BDE4 RID: 48612 RVA: 0x0012F2C0 File Offset: 0x0012D4C0
		[NullableContext(2)]
		public static UnrealUObject GetOrCreateUObjectByNativePointer(IntPtr NativeObjectPtr)
		{
			if (NativeObjectPtr == IntPtr.Zero)
			{
				return null;
			}
			UnrealUObject unrealUObject = BuiltinUtils.GetUObjectByNativePointer_Internal(NativeObjectPtr);
			if (unrealUObject == null)
			{
				unrealUObject = BuiltinUtils.CreateUObjectByNativePointer_Internal(NativeObjectPtr);
			}
			return unrealUObject;
		}

		// Token: 0x0600BDE5 RID: 48613 RVA: 0x0012F2EC File Offset: 0x0012D4EC
		[return: Nullable(2)]
		public static T GetOrCreateUObjectByNativePointer<T>(IntPtr NativeObjectPtr) where T : UnrealUObject
		{
			if (NativeObjectPtr == IntPtr.Zero)
			{
				return default(T);
			}
			UnrealUObject unrealUObject = BuiltinUtils.GetUObjectByNativePointer_Internal(NativeObjectPtr);
			if (unrealUObject == null)
			{
				unrealUObject = BuiltinUtils.CreateUObjectByNativePointer_Internal(NativeObjectPtr);
			}
			T t = unrealUObject as T;
			if (t == null)
			{
				SharpherealAssert.Assert(false, "CastFail: Except " + typeof(T).Name + ", Actual " + (((unrealUObject != null) ? unrealUObject.GetType().Name : null) ?? "null"));
				return default(T);
			}
			return t;
		}

		// Token: 0x0600BDE6 RID: 48614 RVA: 0x0012F37C File Offset: 0x0012D57C
		[NullableContext(1)]
		[return: Nullable(2)]
		public static T GetOrCreateUObjectAsInterfaceByNativePointer<T>(IntPtr NativeObjectPtr) where T : class, IUnrealObject
		{
			if (NativeObjectPtr == IntPtr.Zero)
			{
				return default(T);
			}
			UnrealUObject unrealUObject = BuiltinUtils.GetUObjectByNativePointer_Internal(NativeObjectPtr);
			if (unrealUObject == null)
			{
				unrealUObject = BuiltinUtils.CreateUObjectByNativePointer_Internal(NativeObjectPtr);
			}
			T t = unrealUObject as T;
			if (t == null)
			{
				SharpherealAssert.Assert(false, "CastFail: Except " + typeof(T).Name + ", Actual " + (((unrealUObject != null) ? unrealUObject.GetType().Name : null) ?? "null"));
				return default(T);
			}
			return t;
		}

		// Token: 0x0600BDE7 RID: 48615
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern IntPtr GetNativePtrByIndexAndSerialNumberInternal(int ObjectIndex, int ObjectSerialNumber);

		// Token: 0x0600BDE8 RID: 48616
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern UnrealUObject GetOrCreateUObjectByIndexAndSerialNumberInternal(int ObjectIndex, int ObjectSerialNumber);

		// Token: 0x0600BDE9 RID: 48617 RVA: 0x0012F409 File Offset: 0x0012D609
		[return: Nullable(2)]
		public static T GetOrCreateUObjectByIndexAndSerialNumber<T>(int ObjectIndex, int ObjectSerialNumber) where T : UnrealUObject
		{
			return BuiltinUtils.GetOrCreateUObjectByIndexAndSerialNumberInternal(ObjectIndex, ObjectSerialNumber) as T;
		}

		// Token: 0x0600BDEA RID: 48618
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern long GetUObjectIndexAndSerialNumber(IntPtr NativeObjectPtr);

		// Token: 0x0600BDEB RID: 48619 RVA: 0x0012F41C File Offset: 0x0012D61C
		public static void GetUObjectIndexAndSerialNumber(IntPtr NativeObjectPtr, out int ObjectIndex, out int ObjectSerialNumber)
		{
			long uobjectIndexAndSerialNumber = BuiltinUtils.GetUObjectIndexAndSerialNumber(NativeObjectPtr);
			ObjectIndex = (int)(uobjectIndexAndSerialNumber >> 32);
			ObjectSerialNumber = (int)(uobjectIndexAndSerialNumber & (long)((ulong)-1));
		}

		// Token: 0x0600BDEC RID: 48620 RVA: 0x0012F43E File Offset: 0x0012D63E
		public static void GetClassIndexAndSerialNumber(UClassStackOnlyPtr StackOnlyClassPtr, out int ObjectIndex, out int ObjectSerialNumber)
		{
			BuiltinUtils.GetUObjectIndexAndSerialNumber(StackOnlyClassPtr.NativePtr, out ObjectIndex, out ObjectSerialNumber);
		}

		// Token: 0x0600BDED RID: 48621 RVA: 0x0012F44E File Offset: 0x0012D64E
		public static UClassStackOnlyPtr GetClassPtrByIndexAndSerialNumber(int ObjectIndex, int ObjectSerialNumber)
		{
			return BuiltinUtils.GetNativePtrByIndexAndSerialNumberInternal(ObjectIndex, ObjectSerialNumber);
		}

		// Token: 0x0600BDEE RID: 48622
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void BindNativeUObject(UnrealUObject Object);

		// Token: 0x0600BDEF RID: 48623
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void UnbindNativeUObject_GCThread(IntPtr NativeObjectPtr);

		// Token: 0x0600BDF0 RID: 48624 RVA: 0x0012F45C File Offset: 0x0012D65C
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void ObjectPropertySetter(void** PropertyPtr, [Nullable(2)] IUnrealUObject OtherObject)
		{
			*(IntPtr*)PropertyPtr = ((OtherObject == null) ? ((IntPtr)0) : OtherObject.NativePtr);
		}

		// Token: 0x0600BDF1 RID: 48625 RVA: 0x0012F470 File Offset: 0x0012D670
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		[return: Nullable(2)]
		public unsafe static T ObjectPropertyGetter<T>(void** PropertyPtr) where T : UnrealUObject
		{
			void* ptr = *(IntPtr*)PropertyPtr;
			if (ptr == null)
			{
				return default(T);
			}
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<T>(ptr);
		}

		// Token: 0x0600BDF2 RID: 48626
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern UnrealUObject GetUObjectByNativePointer_Internal(IntPtr NativeObjectPtr);

		// Token: 0x0600BDF3 RID: 48627
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern UnrealUObject CreateUObjectByNativePointer_Internal(IntPtr NativeObjectPtr);

		// Token: 0x0600BDF4 RID: 48628
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void AddRefForUUserDefinedStruct(IntPtr UUserDefinedStructPtr);

		// Token: 0x0600BDF5 RID: 48629
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DecRefForUUserDefinedStruct(IntPtr UUserDefinedStructPtr);

		// Token: 0x0600BDF6 RID: 48630
		[MethodImpl(MethodImplOptions.InternalCall)]
		public unsafe static extern void* Malloc(UIntPtr Size, uint Alignment = 0U);

		// Token: 0x0600BDF7 RID: 48631
		[MethodImpl(MethodImplOptions.InternalCall)]
		public unsafe static extern void* Calloc(UIntPtr Size, uint Alignment = 0U);

		// Token: 0x0600BDF8 RID: 48632
		[MethodImpl(MethodImplOptions.InternalCall)]
		public unsafe static extern void* Realloc(void* Ptr, UIntPtr Size, uint Alignment = 0U);

		// Token: 0x0600BDF9 RID: 48633
		[MethodImpl(MethodImplOptions.InternalCall)]
		public unsafe static extern void Free(void* Size);

		// Token: 0x0600BDFA RID: 48634
		[MethodImpl(MethodImplOptions.InternalCall)]
		public unsafe static extern void Memmove(void* Dst, void* Src, UIntPtr Size);

		// Token: 0x0600BDFB RID: 48635
		[MethodImpl(MethodImplOptions.InternalCall)]
		public unsafe static extern void Memcpy(void* Dst, void* Src, UIntPtr Size);

		// Token: 0x0600BDFC RID: 48636
		[MethodImpl(MethodImplOptions.InternalCall)]
		public unsafe static extern void Memset(void* Dst, int Val, UIntPtr Size);

		// Token: 0x0600BDFD RID: 48637 RVA: 0x0012F495 File Offset: 0x0012D695
		public unsafe static T* StackAllocAligned<[IsUnmanaged] T>(Span<byte> Stack, int Alignment = 0) where T : struct, ValueType
		{
			if (Alignment == 0)
			{
				Alignment = ((sizeof(T) >= 16) ? 16 : 8);
			}
			return (T*)((byte*)Unsafe.AsPointer<byte>(MemoryMarshal.GetReference<byte>(Stack)) + ((IntPtr)Alignment - (IntPtr)1) & ~(Alignment - 1));
		}

		// Token: 0x0600BDFE RID: 48638 RVA: 0x0012F4C2 File Offset: 0x0012D6C2
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsNativePtrValidLowLevelFast(UnrealObject @object)
		{
			return BuiltinUtils.IsNativePtrValidLowLevelFast(@object._NativePtr);
		}

		// Token: 0x0600BDFF RID: 48639 RVA: 0x0012F4CF File Offset: 0x0012D6CF
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsNativePtrValidLowLevelFast(IntPtr @this)
		{
			return @this != 0 && @this >= (IntPtr)256 && (@this & (IntPtr)7) == 0;
		}

		// Token: 0x0600BE00 RID: 48640
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern int GetUFunctionParamsLayout(IntPtr UFunctionPtr, void* UFunctionParamsLayout, int ParamsNum);

		// Token: 0x0600BE01 RID: 48641 RVA: 0x0012F4E8 File Offset: 0x0012D6E8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static void GetUFunctionParamsLayoutCheck(IntPtr UFunctionPtr, void* UFunctionParamsLayout, int ParamsNum)
		{
			if (BuiltinUtils.GetUFunctionParamsLayout(UFunctionPtr, UFunctionParamsLayout, ParamsNum) != ParamsNum)
			{
				throw new UFunctionBindingException();
			}
		}
	}
}
