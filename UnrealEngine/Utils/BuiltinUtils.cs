using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;

namespace UnrealEngine.Utils
{
	// Token: 0x02002AEA RID: 10986
	public static class BuiltinUtils
	{
		// Token: 0x0602842E RID: 164910
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern IntPtr AllocNativeUObject(UClassStackOnlyPtr UClassPtr, UnrealObject Outer = null, FName Name = default(FName), EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags);

		// Token: 0x0602842F RID: 164911 RVA: 0x003D3FB0 File Offset: 0x003D21B0
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

		// Token: 0x06028430 RID: 164912 RVA: 0x003D3FDC File Offset: 0x003D21DC
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

		// Token: 0x06028431 RID: 164913 RVA: 0x003D406C File Offset: 0x003D226C
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

		// Token: 0x06028432 RID: 164914
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern IntPtr GetNativePtrByIndexAndSerialNumberInternal(int ObjectIndex, int ObjectSerialNumber);

		// Token: 0x06028433 RID: 164915
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern UnrealUObject GetOrCreateUObjectByIndexAndSerialNumberInternal(int ObjectIndex, int ObjectSerialNumber);

		// Token: 0x06028434 RID: 164916 RVA: 0x003D40F9 File Offset: 0x003D22F9
		[return: Nullable(2)]
		public static T GetOrCreateUObjectByIndexAndSerialNumber<T>(int ObjectIndex, int ObjectSerialNumber) where T : UnrealUObject
		{
			return BuiltinUtils.GetOrCreateUObjectByIndexAndSerialNumberInternal(ObjectIndex, ObjectSerialNumber) as T;
		}

		// Token: 0x06028435 RID: 164917
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern long GetUObjectIndexAndSerialNumber(IntPtr NativeObjectPtr);

		// Token: 0x06028436 RID: 164918 RVA: 0x003D410C File Offset: 0x003D230C
		public static void GetUObjectIndexAndSerialNumber(IntPtr NativeObjectPtr, out int ObjectIndex, out int ObjectSerialNumber)
		{
			long uobjectIndexAndSerialNumber = BuiltinUtils.GetUObjectIndexAndSerialNumber(NativeObjectPtr);
			ObjectIndex = (int)(uobjectIndexAndSerialNumber >> 32);
			ObjectSerialNumber = (int)(uobjectIndexAndSerialNumber & (long)((ulong)-1));
		}

		// Token: 0x06028437 RID: 164919 RVA: 0x003D412E File Offset: 0x003D232E
		public static void GetClassIndexAndSerialNumber(UClassStackOnlyPtr StackOnlyClassPtr, out int ObjectIndex, out int ObjectSerialNumber)
		{
			BuiltinUtils.GetUObjectIndexAndSerialNumber(StackOnlyClassPtr.NativePtr, out ObjectIndex, out ObjectSerialNumber);
		}

		// Token: 0x06028438 RID: 164920 RVA: 0x003D413E File Offset: 0x003D233E
		public static UClassStackOnlyPtr GetClassPtrByIndexAndSerialNumber(int ObjectIndex, int ObjectSerialNumber)
		{
			return BuiltinUtils.GetNativePtrByIndexAndSerialNumberInternal(ObjectIndex, ObjectSerialNumber);
		}

		// Token: 0x06028439 RID: 164921
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void BindNativeUObject(UnrealUObject Object);

		// Token: 0x0602843A RID: 164922
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void UnbindNativeUObject_GCThread(IntPtr NativeObjectPtr);

		// Token: 0x0602843B RID: 164923 RVA: 0x003D414C File Offset: 0x003D234C
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void ObjectPropertySetter(void** PropertyPtr, [Nullable(2)] IUnrealUObject OtherObject)
		{
			*(IntPtr*)PropertyPtr = ((OtherObject == null) ? ((IntPtr)0) : OtherObject.NativePtr);
		}

		// Token: 0x0602843C RID: 164924 RVA: 0x003D4160 File Offset: 0x003D2360
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

		// Token: 0x0602843D RID: 164925
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern UnrealUObject GetUObjectByNativePointer_Internal(IntPtr NativeObjectPtr);

		// Token: 0x0602843E RID: 164926
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern UnrealUObject CreateUObjectByNativePointer_Internal(IntPtr NativeObjectPtr);

		// Token: 0x0602843F RID: 164927
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void AddRefForUUserDefinedStruct(IntPtr UUserDefinedStructPtr);

		// Token: 0x06028440 RID: 164928
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DecRefForUUserDefinedStruct(IntPtr UUserDefinedStructPtr);

		// Token: 0x06028441 RID: 164929
		[MethodImpl(MethodImplOptions.InternalCall)]
		public unsafe static extern void* Malloc(UIntPtr Size, uint Alignment = 0U);

		// Token: 0x06028442 RID: 164930
		[MethodImpl(MethodImplOptions.InternalCall)]
		public unsafe static extern void* Calloc(UIntPtr Size, uint Alignment = 0U);

		// Token: 0x06028443 RID: 164931
		[MethodImpl(MethodImplOptions.InternalCall)]
		public unsafe static extern void* Realloc(void* Ptr, UIntPtr Size, uint Alignment = 0U);

		// Token: 0x06028444 RID: 164932
		[MethodImpl(MethodImplOptions.InternalCall)]
		public unsafe static extern void Free(void* Size);

		// Token: 0x06028445 RID: 164933
		[MethodImpl(MethodImplOptions.InternalCall)]
		public unsafe static extern void Memmove(void* Dst, void* Src, UIntPtr Size);

		// Token: 0x06028446 RID: 164934
		[MethodImpl(MethodImplOptions.InternalCall)]
		public unsafe static extern void Memcpy(void* Dst, void* Src, UIntPtr Size);

		// Token: 0x06028447 RID: 164935
		[MethodImpl(MethodImplOptions.InternalCall)]
		public unsafe static extern void Memset(void* Dst, int Val, UIntPtr Size);

		// Token: 0x06028448 RID: 164936 RVA: 0x003D4185 File Offset: 0x003D2385
		public unsafe static T* StackAllocAligned<[IsUnmanaged] T>(Span<byte> Stack, int Alignment = 0) where T : struct, ValueType
		{
			if (Alignment == 0)
			{
				Alignment = ((sizeof(T) >= 16) ? 16 : 8);
			}
			return (T*)((byte*)Unsafe.AsPointer<byte>(MemoryMarshal.GetReference<byte>(Stack)) + ((IntPtr)Alignment - (IntPtr)1) & ~(Alignment - 1));
		}

		// Token: 0x06028449 RID: 164937 RVA: 0x003D41B2 File Offset: 0x003D23B2
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsNativePtrValidLowLevelFast(UnrealObject @object)
		{
			return BuiltinUtils.IsNativePtrValidLowLevelFast(@object._NativePtr);
		}

		// Token: 0x0602844A RID: 164938 RVA: 0x003D41BF File Offset: 0x003D23BF
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsNativePtrValidLowLevelFast(IntPtr @this)
		{
			return @this != 0 && @this >= (IntPtr)256 && (@this & (IntPtr)7) == 0;
		}

		// Token: 0x0602844B RID: 164939
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern int GetUFunctionParamsLayout(IntPtr UFunctionPtr, void* UFunctionParamsLayout, int ParamsNum);

		// Token: 0x0602844C RID: 164940 RVA: 0x003D41D8 File Offset: 0x003D23D8
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
