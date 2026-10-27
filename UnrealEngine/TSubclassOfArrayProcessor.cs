using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Helper;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x02000060 RID: 96
	[Nullable(new byte[]
	{
		0,
		0,
		1
	})]
	public sealed class TSubclassOfArrayProcessor<T> : PodBaseWithEqualityOperatorsArrayProcessor<TSubclassOf<T>> where T : IUnrealUObject
	{
		// Token: 0x06000924 RID: 2340 RVA: 0x000113C2 File Offset: 0x0000F5C2
		public TSubclassOfArrayProcessor()
		{
			this.HasGetTypeHash = true;
			this.Size = IntPtrHelper.Size;
			this.MinAlignment = IntPtrHelper.Size;
		}

		// Token: 0x06000925 RID: 2341 RVA: 0x000113E7 File Offset: 0x0000F5E7
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe override void* GetElementPtr([Nullable(new byte[]
		{
			0,
			1
		})] ref TSubclassOf<T> Value, ref bool bRequireToDelete)
		{
			return Unsafe.As<TSubclassOf<T>, UClassStackOnlyPtr>(ref Value)._NativePtr;
		}
	}
}
