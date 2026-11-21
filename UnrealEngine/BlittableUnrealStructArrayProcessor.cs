using System;
using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000038 RID: 56
	public sealed class BlittableUnrealStructArrayProcessor<[IsUnmanaged] T> : PodBaseWithEqualityOperatorsArrayProcessor<T> where T : struct, ValueType, IEqualityOperators<T, T, bool>
	{
		// Token: 0x0600085E RID: 2142 RVA: 0x0000D1BC File Offset: 0x0000B3BC
		public BlittableUnrealStructArrayProcessor()
		{
			this.HasGetTypeHash = typeof(T).IsDefined(typeof(HasGetTypeHashAttribute));
			this.Size = sizeof(T);
			this.MinAlignment = typeof(T).GetCustomAttribute<UnrealStructLayoutAttribute>().Pack;
		}
	}
}
