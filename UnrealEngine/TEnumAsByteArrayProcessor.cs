using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine
{
	// Token: 0x0200003D RID: 61
	[Nullable(new byte[]
	{
		0,
		0,
		1
	})]
	public sealed class TEnumAsByteArrayProcessor<T> : PodBaseWithEqualityOperatorsArrayProcessor<TEnumAsByte<T>> where T : Enum
	{
		// Token: 0x06000871 RID: 2161 RVA: 0x0000D55D File Offset: 0x0000B75D
		public TEnumAsByteArrayProcessor()
		{
			this.HasGetTypeHash = true;
			this.Size = 1;
			this.MinAlignment = 1;
		}
	}
}
