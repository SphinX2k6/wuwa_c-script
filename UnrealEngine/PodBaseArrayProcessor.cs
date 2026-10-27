using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	// Token: 0x02000050 RID: 80
	public abstract class PodBaseArrayProcessor<[IsUnmanaged] T> : NativeArrayProcessorBase<T> where T : struct, ValueType
	{
		// Token: 0x060008D1 RID: 2257 RVA: 0x0001087A File Offset: 0x0000EA7A
		public PodBaseArrayProcessor()
		{
			this.CanAsSpan = true;
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x00010889 File Offset: 0x0000EA89
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe sealed override T Get(IntPtr Data, int Index)
		{
			return *(Data + (IntPtr)(Index * this.Size));
		}

		// Token: 0x060008D3 RID: 2259 RVA: 0x0001089B File Offset: 0x0000EA9B
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe sealed override void Set(IntPtr Data, int Index, T Value)
		{
			*(Data + (IntPtr)(Index * this.Size)) = Value;
		}

		// Token: 0x060008D4 RID: 2260 RVA: 0x000108AE File Offset: 0x0000EAAE
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe override void ConstructValues(IntPtr Data, int Index, int Count)
		{
			NativeMemory.Clear((void*)(Data + (byte*)((IntPtr)(Index * this.Size))), (UIntPtr)((IntPtr)(Count * this.Size)));
		}

		// Token: 0x060008D5 RID: 2261 RVA: 0x000108C9 File Offset: 0x0000EAC9
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public sealed override void CopyTo(IntPtr Data, IntPtr Dest, int Num)
		{
			Buffer.MemoryCopy(Data, Dest, (long)(this.Size * Num), (long)(this.Size * Num));
		}
	}
}
