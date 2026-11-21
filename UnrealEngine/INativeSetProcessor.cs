using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine
{
	// Token: 0x02000050 RID: 80
	[NullableContext(1)]
	public interface INativeSetProcessor<[Nullable(2)] T>
	{
		// Token: 0x0600093B RID: 2363
		[NullableContext(2)]
		T Get(IntPtr data, int index);

		// Token: 0x0600093C RID: 2364
		void Set(IntPtr data, int index, T value);

		// Token: 0x0600093D RID: 2365
		int Add(T value);

		// Token: 0x0600093E RID: 2366
		public static extern void AllocNativeMemory();

		// Token: 0x0600093F RID: 2367
		public static extern void CopyNativeMemory(IntPtr Src);
	}
}
