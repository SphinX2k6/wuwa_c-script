using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine
{
	// Token: 0x0200006B RID: 107
	[NullableContext(1)]
	public interface INativeSetProcessor<[Nullable(2)] T>
	{
		// Token: 0x06000DAD RID: 3501
		[NullableContext(2)]
		T Get(IntPtr data, int index);

		// Token: 0x06000DAE RID: 3502
		void Set(IntPtr data, int index, T value);

		// Token: 0x06000DAF RID: 3503
		int Add(T value);

		// Token: 0x06000DB0 RID: 3504
		public static extern void AllocNativeMemory();

		// Token: 0x06000DB1 RID: 3505
		public static extern void CopyNativeMemory(IntPtr Src);
	}
}
