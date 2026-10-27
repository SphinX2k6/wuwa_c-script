using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Helper;
using UnrealEngine.Utils;

namespace UnrealEngine.Marshal
{
	// Token: 0x02002B0E RID: 11022
	internal class UnrealUObjectMarshallingProcessor<[Nullable(2)] T> : IPropertyMarshallingProcessor<!0>
	{
		// Token: 0x170099A2 RID: 39330
		// (get) Token: 0x060284C8 RID: 165064 RVA: 0x003D522A File Offset: 0x003D342A
		public static int Size { get; } = sizeof(void*);

		// Token: 0x060284C9 RID: 165065 RVA: 0x003D5231 File Offset: 0x003D3431
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void Write(byte* buffer, ref int offset, [Nullable(1)] in T value)
		{
			ref IntPtr ptr = ref *(IntPtr*)(buffer + offset);
			UnrealUObject unrealUObject = value as UnrealUObject;
			ptr = ((unrealUObject != null) ? unrealUObject._NativePtr : ((IntPtr)0));
			offset += IntPtrHelper.Size;
		}

		// Token: 0x060284CA RID: 165066 RVA: 0x003D525F File Offset: 0x003D345F
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		[return: Nullable(2)]
		public unsafe static T Read(byte* buffer, ref int offset)
		{
			IntPtr nativeObjectPtr = *(IntPtr*)(buffer + offset);
			offset += IntPtrHelper.Size;
			return (T)((object)BuiltinUtils.GetOrCreateUObjectByNativePointer(nativeObjectPtr));
		}

		// Token: 0x060284CD RID: 165069 RVA: 0x003D528F File Offset: 0x003D348F
		unsafe void IPropertyMarshallingProcessor<!0>.Write(byte* buffer, ref int offset, [Nullable(1)] in T value)
		{
			UnrealUObjectMarshallingProcessor<T>.Write(buffer, ref offset, value);
		}
	}
}
