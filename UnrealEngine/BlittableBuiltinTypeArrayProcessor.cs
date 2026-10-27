using System;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace UnrealEngine
{
	// Token: 0x02000052 RID: 82
	public sealed class BlittableBuiltinTypeArrayProcessor<[IsUnmanaged] T> : PodBaseWithEqualityOperatorsArrayProcessor<T> where T : struct, ValueType, IEqualityOperators<T, T, bool>
	{
		// Token: 0x060008D8 RID: 2264 RVA: 0x00010920 File Offset: 0x0000EB20
		public BlittableBuiltinTypeArrayProcessor()
		{
			this.HasGetTypeHash = true;
			this.Size = (this.MinAlignment = sizeof(T));
		}
	}
}
