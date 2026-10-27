using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine
{
	// Token: 0x02000068 RID: 104
	[Nullable(new byte[]
	{
		0,
		1,
		0
	})]
	public class Managed_K_Unmanaged_V_MapProcessor<K, [IsUnmanaged] V> : NativeMapProcessor<K, V> where K : UnrealObject where V : struct, ValueType
	{
	}
}
