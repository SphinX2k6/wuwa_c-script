using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000061 RID: 97
	[Nullable(new byte[]
	{
		0,
		0,
		1
	})]
	public sealed class TScriptInterfaceArrayProcessor<T> : PodBaseWithEqualityOperatorsArrayProcessor<TScriptInterface<T>> where T : IUnrealInterface
	{
		// Token: 0x06000926 RID: 2342 RVA: 0x000113F4 File Offset: 0x0000F5F4
		public TScriptInterfaceArrayProcessor()
		{
			this.HasGetTypeHash = false;
			this.Size = sizeof(FScriptInterface);
			this.MinAlignment = typeof(FScriptInterface).GetCustomAttribute<UnrealStructLayoutAttribute>().Pack;
		}
	}
}
