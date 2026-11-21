using System;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace UnrealEngine
{
	// Token: 0x02000036 RID: 54
	public abstract class PodBaseWithEqualityOperatorsArrayProcessor<[IsUnmanaged] T> : PodBaseArrayProcessor<T> where T : struct, ValueType, IEqualityOperators<T, T, bool>
	{
		// Token: 0x0600085B RID: 2139 RVA: 0x0000D150 File Offset: 0x0000B350
		public sealed override int FindIndex(IntPtr Data, int Num, T Value)
		{
			for (int i = 0; i < Num; i++)
			{
				if (this.Get(Data, i) == Value)
				{
					return i;
				}
			}
			return -1;
		}
	}
}
