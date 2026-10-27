using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine
{
	// Token: 0x02000058 RID: 88
	[Nullable(new byte[]
	{
		0,
		0,
		1
	})]
	public sealed class TEnumAsByteArrayProcessor<T> : PodBaseWithEqualityOperatorsArrayProcessor<TEnumAsByte<T>> where T : Enum
	{
		// Token: 0x060008EC RID: 2284 RVA: 0x00010CF1 File Offset: 0x0000EEF1
		public TEnumAsByteArrayProcessor()
		{
			this.HasGetTypeHash = true;
			this.Size = 1;
			this.MinAlignment = 1;
		}
	}
}
