using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000046 RID: 70
	[Nullable(new byte[]
	{
		0,
		0,
		1
	})]
	public sealed class TScriptInterfaceArrayProcessor<T> : PodBaseWithEqualityOperatorsArrayProcessor<TScriptInterface<T>> where T : IUnrealInterface
	{
		// Token: 0x060008AB RID: 2219 RVA: 0x0000DC60 File Offset: 0x0000BE60
		public TScriptInterfaceArrayProcessor()
		{
			this.HasGetTypeHash = false;
			this.Size = sizeof(FScriptInterface);
			this.MinAlignment = typeof(FScriptInterface).GetCustomAttribute<UnrealStructLayoutAttribute>().Pack;
		}
	}
}
