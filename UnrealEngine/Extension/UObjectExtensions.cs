using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Utils;

namespace UnrealEngine.Extension
{
	// Token: 0x02002AE6 RID: 10982
	[NullableContext(2)]
	[Nullable(0)]
	public static class UObjectExtensions
	{
		// Token: 0x06028410 RID: 164880
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr Internal_GetWorld(IntPtr UObject);

		// Token: 0x06028411 RID: 164881
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr Internal_GetOuter(IntPtr UObject);

		// Token: 0x06028412 RID: 164882 RVA: 0x003D3B0B File Offset: 0x003D1D0B
		public static UWorld GetWorld(this UObject Object)
		{
			if (Object != null && Object._NativePtr != 0)
			{
				return BuiltinUtils.GetOrCreateUObjectByNativePointer<UWorld>(UObjectExtensions.Internal_GetWorld(Object._NativePtr));
			}
			return null;
		}

		// Token: 0x06028413 RID: 164883 RVA: 0x003D3B2A File Offset: 0x003D1D2A
		public static UObject GetOuter(this UObject Object)
		{
			if (Object != null && Object._NativePtr != 0)
			{
				return BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(UObjectExtensions.Internal_GetOuter(Object._NativePtr));
			}
			return null;
		}
	}
}
