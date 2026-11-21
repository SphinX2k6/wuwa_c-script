using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine
{
	// Token: 0x0200004C RID: 76
	[Nullable(new byte[]
	{
		0,
		0,
		1
	})]
	public class Unmanaged_K_Managed_V_MapProcessor<[IsUnmanaged] K, V> : NativeMapProcessor<K, V> where K : struct, ValueType where V : UnrealObject
	{
	}
}
