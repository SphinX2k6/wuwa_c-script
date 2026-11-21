using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Helper;
using UnrealEngine.Interface;

namespace UnrealEngine
{
	// Token: 0x02000045 RID: 69
	[Nullable(new byte[]
	{
		0,
		0,
		1
	})]
	public sealed class TSubclassOfArrayProcessor<T> : PodBaseWithEqualityOperatorsArrayProcessor<TSubclassOf<T>> where T : IUnrealUObject
	{
		// Token: 0x060008A9 RID: 2217 RVA: 0x0000DC2E File Offset: 0x0000BE2E
		public TSubclassOfArrayProcessor()
		{
			this.HasGetTypeHash = true;
			this.Size = IntPtrHelper.Size;
			this.MinAlignment = IntPtrHelper.Size;
		}

		// Token: 0x060008AA RID: 2218 RVA: 0x0000DC53 File Offset: 0x0000BE53
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
