using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine
{
	// Token: 0x0200006C RID: 108
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class NativeSetProcessor<[Nullable(2)] T> : INativeSetProcessor<T>
	{
		// Token: 0x06000DB2 RID: 3506
		[NullableContext(2)]
		public abstract T Get(IntPtr data, int index);

		// Token: 0x06000DB3 RID: 3507
		public abstract void Set(IntPtr data, int index, T value);

		// Token: 0x06000DB4 RID: 3508
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern int Add(T value);

		// Token: 0x06000DB5 RID: 3509
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern IntPtr AllocNativeMemory();

		// Token: 0x06000DB6 RID: 3510
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern IntPtr CopyNativeMemory(IntPtr Src);
	}
}
