using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine
{
	// Token: 0x02000065 RID: 101
	[NullableContext(2)]
	[Nullable(0)]
	public abstract class NativeMapProcessor<K, V> : INativeMapProcessor<K, V>
	{
		// Token: 0x06000DA5 RID: 3493
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern IntPtr AllocNativeMemory();

		// Token: 0x06000DA6 RID: 3494
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern IntPtr CopyNativeMemory(IntPtr Src);
	}
}
