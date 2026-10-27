using System;
using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000053 RID: 83
	public sealed class BlittableUnrealStructArrayProcessor<[IsUnmanaged] T> : PodBaseWithEqualityOperatorsArrayProcessor<T> where T : struct, ValueType, IEqualityOperators<T, T, bool>
	{
		// Token: 0x060008D9 RID: 2265 RVA: 0x00010950 File Offset: 0x0000EB50
		public BlittableUnrealStructArrayProcessor()
		{
			this.HasGetTypeHash = typeof(T).IsDefined(typeof(HasGetTypeHashAttribute));
			this.Size = sizeof(T);
			this.MinAlignment = typeof(T).GetCustomAttribute<UnrealStructLayoutAttribute>().Pack;
		}
	}
}
