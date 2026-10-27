using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnrealEngine
{
	// Token: 0x0200004F RID: 79
	public abstract class NativeArrayProcessorBase<[Nullable(2)] T>
	{
		// Token: 0x060008C7 RID: 2247
		[NullableContext(2)]
		public abstract T Get(IntPtr Data, int Index);

		// Token: 0x060008C8 RID: 2248 RVA: 0x0001085B File Offset: 0x0000EA5B
		[NullableContext(1)]
		public virtual T GetRef_Unsafe(IntPtr Data, int Index, UnrealObject Caller)
		{
			return this.Get(Data, Index);
		}

		// Token: 0x060008C9 RID: 2249
		[NullableContext(1)]
		public abstract void Set(IntPtr Data, int Index, T Value);

		// Token: 0x060008CA RID: 2250
		[NullableContext(1)]
		public abstract int FindIndex(IntPtr Data, int Num, T Value);

		// Token: 0x060008CB RID: 2251
		public abstract void ConstructValues(IntPtr Data, int Index, int Count);

		// Token: 0x060008CC RID: 2252 RVA: 0x00010865 File Offset: 0x0000EA65
		public virtual void DestructValues(IntPtr Data, int Index, int Count)
		{
		}

		// Token: 0x060008CD RID: 2253
		public abstract void CopyTo(IntPtr Data, IntPtr Dest, int Num);

		// Token: 0x060008CE RID: 2254 RVA: 0x00010867 File Offset: 0x0000EA67
		public unsafe virtual void* GetElementPtr([Nullable(1)] ref T Value, ref bool bRequireToDelete)
		{
			return null;
		}

		// Token: 0x060008CF RID: 2255 RVA: 0x0001086B File Offset: 0x0000EA6B
		public unsafe virtual void DeleteElementPtr(void* Data)
		{
			throw new UnreachableException();
		}

		// Token: 0x04000160 RID: 352
		public bool IsStructProxyProcessor;

		// Token: 0x04000161 RID: 353
		public bool RequireConstructAndDestruct;

		// Token: 0x04000162 RID: 354
		public bool HasGetTypeHash;

		// Token: 0x04000163 RID: 355
		public bool CanAsSpan;

		// Token: 0x04000164 RID: 356
		public int Size;

		// Token: 0x04000165 RID: 357
		public int MinAlignment;
	}
}
