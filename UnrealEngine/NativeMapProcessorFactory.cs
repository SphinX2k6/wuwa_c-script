using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine
{
	// Token: 0x0200004F RID: 79
	public static class NativeMapProcessorFactory
	{
		// Token: 0x0600093A RID: 2362 RVA: 0x0000E78C File Offset: 0x0000C98C
		[NullableContext(2)]
		[return: Nullable(1)]
		public static INativeMapProcessor<K, V> GetProcessor<K, V>()
		{
			if (typeof(K).IsValueType)
			{
				if (typeof(V).IsValueType)
				{
					return (INativeMapProcessor<K, V>)Activator.CreateInstance(typeof(Unmanaged_KV_MapProcessor<, >).MakeGenericType(new Type[]
					{
						typeof(K),
						typeof(V)
					}));
				}
				return (INativeMapProcessor<K, V>)Activator.CreateInstance(typeof(Unmanaged_K_Managed_V_MapProcessor<, >).MakeGenericType(new Type[]
				{
					typeof(K),
					typeof(UnrealObject)
				}));
			}
			else
			{
				if (typeof(V).IsValueType)
				{
					return (INativeMapProcessor<K, V>)Activator.CreateInstance(typeof(Managed_K_Unmanaged_V_MapProcessor<, >).MakeGenericType(new Type[]
					{
						typeof(UnrealObject),
						typeof(V)
					}));
				}
				return (INativeMapProcessor<K, V>)Activator.CreateInstance(typeof(Managed_KV_MapProcessor<, >).MakeGenericType(new Type[]
				{
					typeof(UnrealObject),
					typeof(UnrealObject)
				}));
			}
		}
	}
}
