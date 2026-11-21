using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine
{
	// Token: 0x0200004A RID: 74
	[NullableContext(2)]
	[Nullable(0)]
	public abstract class NativeMapProcessor<K, V> : INativeMapProcessor<K, V>
	{
		// Token: 0x06000933 RID: 2355
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern IntPtr AllocNativeMemory();

		// Token: 0x06000934 RID: 2356
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern IntPtr CopyNativeMemory(IntPtr Src);
	}
}
