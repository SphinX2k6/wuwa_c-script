using System;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace UnrealEngine
{
	// Token: 0x02000051 RID: 81
	public abstract class PodBaseWithEqualityOperatorsArrayProcessor<[IsUnmanaged] T> : PodBaseArrayProcessor<T> where T : struct, ValueType, IEqualityOperators<T, T, bool>
	{
		// Token: 0x060008D6 RID: 2262 RVA: 0x000108E4 File Offset: 0x0000EAE4
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
