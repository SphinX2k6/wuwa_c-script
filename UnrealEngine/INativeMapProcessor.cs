using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine
{
	// Token: 0x02000049 RID: 73
	[NullableContext(2)]
	public interface INativeMapProcessor<K, V>
	{
		// Token: 0x06000931 RID: 2353
		public static extern void AllocNativeMemory();

		// Token: 0x06000932 RID: 2354
		public static extern void CopyNativeMemory(IntPtr Src);
	}
}
