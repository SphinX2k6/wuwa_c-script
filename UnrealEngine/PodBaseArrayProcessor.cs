using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	// Token: 0x02000035 RID: 53
	public abstract class PodBaseArrayProcessor<[IsUnmanaged] T> : NativeArrayProcessorBase<T> where T : struct, ValueType
	{
		// Token: 0x06000856 RID: 2134 RVA: 0x0000D0E6 File Offset: 0x0000B2E6
		public PodBaseArrayProcessor()
		{
			this.CanAsSpan = true;
		}

		// Token: 0x06000857 RID: 2135 RVA: 0x0000D0F5 File Offset: 0x0000B2F5
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe sealed override T Get(IntPtr Data, int Index)
		{
			return *(Data + (IntPtr)(Index * this.Size));
		}

		// Token: 0x06000858 RID: 2136 RVA: 0x0000D107 File Offset: 0x0000B307
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe sealed override void Set(IntPtr Data, int Index, T Value)
		{
			*(Data + (IntPtr)(Index * this.Size)) = Value;
		}

		// Token: 0x06000859 RID: 2137 RVA: 0x0000D11A File Offset: 0x0000B31A
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe override void ConstructValues(IntPtr Data, int Index, int Count)
		{
			NativeMemory.Clear((void*)(Data + (byte*)((IntPtr)(Index * this.Size))), (UIntPtr)((IntPtr)(Count * this.Size)));
		}

		// Token: 0x0600085A RID: 2138 RVA: 0x0000D135 File Offset: 0x0000B335
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override void CopyTo(IntPtr Data, IntPtr Dest, int Num)
		{
			Buffer.MemoryCopy(Data, Dest, (long)(this.Size * Num), (long)(this.Size * Num));
		}
	}
}
