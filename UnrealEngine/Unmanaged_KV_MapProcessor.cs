using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine
{
	// Token: 0x0200004B RID: 75
	public class Unmanaged_KV_MapProcessor<[IsUnmanaged] K, [IsUnmanaged] V> : NativeMapProcessor<K, V> where K : struct, ValueType where V : struct, ValueType
	{
	}
}
