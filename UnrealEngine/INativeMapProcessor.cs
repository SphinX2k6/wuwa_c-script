using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine
{
	// Token: 0x02000064 RID: 100
	[NullableContext(2)]
	public interface INativeMapProcessor<K, V>
	{
		// Token: 0x06000DA3 RID: 3491
		public static extern void AllocNativeMemory();

		// Token: 0x06000DA4 RID: 3492
		public static extern void CopyNativeMemory(IntPtr Src);
	}
}
