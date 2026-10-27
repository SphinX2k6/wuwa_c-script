using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine
{
	// Token: 0x02000066 RID: 102
	public class Unmanaged_KV_MapProcessor<[IsUnmanaged] K, [IsUnmanaged] V> : NativeMapProcessor<K, V> where K : struct, ValueType where V : struct, ValueType
	{
	}
}
