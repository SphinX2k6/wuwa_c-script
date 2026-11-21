using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnrealEngine
{
	// Token: 0x02000034 RID: 52
	public abstract class NativeArrayProcessorBase<[Nullable(2)] T>
	{
		// Token: 0x0600084C RID: 2124
		[NullableContext(2)]
		public abstract T Get(IntPtr Data, int Index);

		// Token: 0x0600084D RID: 2125 RVA: 0x0000D0C7 File Offset: 0x0000B2C7
		[NullableContext(1)]
		public virtual T GetRef_Unsafe(IntPtr Data, int Index, UnrealObject Caller)
		{
			return this.Get(Data, Index);
		}

		// Token: 0x0600084E RID: 2126
		[NullableContext(1)]
		public abstract void Set(IntPtr Data, int Index, T Value);

		// Token: 0x0600084F RID: 2127
		[NullableContext(1)]
		public abstract int FindIndex(IntPtr Data, int Num, T Value);

		// Token: 0x06000850 RID: 2128
		public abstract void ConstructValues(IntPtr Data, int Index, int Count);

		// Token: 0x06000851 RID: 2129 RVA: 0x0000D0D1 File Offset: 0x0000B2D1
		public virtual void DestructValues(IntPtr Data, int Index, int Count)
		{
		}

		// Token: 0x06000852 RID: 2130
		public abstract void CopyTo(IntPtr Data, IntPtr Dest, int Num);

		// Token: 0x06000853 RID: 2131 RVA: 0x0000D0D3 File Offset: 0x0000B2D3
		public unsafe virtual void* GetElementPtr([Nullable(1)] ref T Value, ref bool bRequireToDelete)
		{
			return null;
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x0000D0D7 File Offset: 0x0000B2D7
		public unsafe virtual void DeleteElementPtr(void* Data)
		{
			throw new UnreachableException();
		}

		// Token: 0x04000119 RID: 281
		public bool IsStructProxyProcessor;

		// Token: 0x0400011A RID: 282
		public bool RequireConstructAndDestruct;

		// Token: 0x0400011B RID: 283
		public bool HasGetTypeHash;

		// Token: 0x0400011C RID: 284
		public bool CanAsSpan;

		// Token: 0x0400011D RID: 285
		public int Size;

		// Token: 0x0400011E RID: 286
		public int MinAlignment;
	}
}
