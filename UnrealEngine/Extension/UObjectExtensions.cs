using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Utils;

namespace UnrealEngine.Extension
{
	// Token: 0x02000895 RID: 2197
	[NullableContext(2)]
	[Nullable(0)]
	public static class UObjectExtensions
	{
		// Token: 0x0600BDC5 RID: 48581
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr Internal_GetWorld(IntPtr UObject);

		// Token: 0x0600BDC6 RID: 48582
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr Internal_GetOuter(IntPtr UObject);

		// Token: 0x0600BDC7 RID: 48583 RVA: 0x0012EE1B File Offset: 0x0012D01B
		public static UWorld GetWorld(this UObject Object)
		{
			if (Object != null && Object._NativePtr != 0)
			{
				return BuiltinUtils.GetOrCreateUObjectByNativePointer<UWorld>(UObjectExtensions.Internal_GetWorld(Object._NativePtr));
			}
			return null;
		}

		// Token: 0x0600BDC8 RID: 48584 RVA: 0x0012EE3A File Offset: 0x0012D03A
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
