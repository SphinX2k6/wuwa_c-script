using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Helper;
using UnrealEngine.Utils;

namespace UnrealEngine.Marshal
{
	// Token: 0x020008BE RID: 2238
	internal class UnrealUObjectMarshallingProcessor<[Nullable(2)] T> : IPropertyMarshallingProcessor<!0>
	{
		// Token: 0x1700232B RID: 9003
		// (get) Token: 0x0600BE82 RID: 48770 RVA: 0x00130586 File Offset: 0x0012E786
		public static int Size { get; } = sizeof(void*);

		// Token: 0x0600BE83 RID: 48771 RVA: 0x0013058D File Offset: 0x0012E78D
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void Write(byte* buffer, ref int offset, [Nullable(1)] in T value)
		{
			ref IntPtr ptr = ref *(IntPtr*)(buffer + offset);
			UnrealUObject unrealUObject = value as UnrealUObject;
			ptr = ((unrealUObject != null) ? unrealUObject._NativePtr : ((IntPtr)0));
			offset += IntPtrHelper.Size;
		}

		// Token: 0x0600BE84 RID: 48772 RVA: 0x001305BB File Offset: 0x0012E7BB
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		[return: Nullable(2)]
		public unsafe static T Read(byte* buffer, ref int offset)
		{
			IntPtr nativeObjectPtr = *(IntPtr*)(buffer + offset);
			offset += IntPtrHelper.Size;
			return (T)((object)BuiltinUtils.GetOrCreateUObjectByNativePointer(nativeObjectPtr));
		}

		// Token: 0x0600BE87 RID: 48775 RVA: 0x001305EB File Offset: 0x0012E7EB
		unsafe void IPropertyMarshallingProcessor<!0>.Write(byte* buffer, ref int offset, [Nullable(1)] in T value)
		{
			UnrealUObjectMarshallingProcessor<T>.Write(buffer, ref offset, value);
		}
	}
}
