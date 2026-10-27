using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine
{
	// Token: 0x0200006A RID: 106
	public static class NativeMapProcessorFactory
	{
		// Token: 0x06000DAC RID: 3500 RVA: 0x00013AE4 File Offset: 0x00011CE4
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
