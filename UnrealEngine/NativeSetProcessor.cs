using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine
{
	// Token: 0x02000051 RID: 81
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class NativeSetProcessor<[Nullable(2)] T> : INativeSetProcessor<T>
	{
		// Token: 0x06000940 RID: 2368
		[NullableContext(2)]
		public abstract T Get(IntPtr data, int index);

		// Token: 0x06000941 RID: 2369
		public abstract void Set(IntPtr data, int index, T value);

		// Token: 0x06000942 RID: 2370
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern int Add(T value);

		// Token: 0x06000943 RID: 2371
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern IntPtr AllocNativeMemory();

		// Token: 0x06000944 RID: 2372
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern IntPtr CopyNativeMemory(IntPtr Src);
	}
}
