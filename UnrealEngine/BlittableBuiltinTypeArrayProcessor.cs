using System;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace UnrealEngine
{
	// Token: 0x02000037 RID: 55
	public sealed class BlittableBuiltinTypeArrayProcessor<[IsUnmanaged] T> : PodBaseWithEqualityOperatorsArrayProcessor<T> where T : struct, ValueType, IEqualityOperators<T, T, bool>
	{
		// Token: 0x0600085D RID: 2141 RVA: 0x0000D18C File Offset: 0x0000B38C
		public BlittableBuiltinTypeArrayProcessor()
		{
			this.HasGetTypeHash = true;
			this.Size = (this.MinAlignment = sizeof(T));
		}
	}
}
