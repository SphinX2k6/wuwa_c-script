using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine.Interface
{
	// Token: 0x02002B15 RID: 11029
	[NullableContext(1)]
	public interface IUnrealStructProxy<[Nullable(2)] T>
	{
		// Token: 0x170099A5 RID: 39333
		// (get) Token: 0x060284D7 RID: 165079
		IntPtr NativePtr { get; }

		// Token: 0x170099A6 RID: 39334
		// (get) Token: 0x060284D8 RID: 165080
		int Size { get; }

		// Token: 0x170099A7 RID: 39335
		// (get) Token: 0x060284D9 RID: 165081
		int MinAlignment { get; }

		// Token: 0x060284DA RID: 165082
		public abstract static T Create(IntPtr Src);

		// Token: 0x060284DB RID: 165083
		public abstract static T Create(IntPtr Src, [Nullable(2)] UnrealObject MemoryOwner);

		// Token: 0x060284DC RID: 165084
		public abstract static void NativeConstruct(IntPtr Pointer, int ArrDim = 1);

		// Token: 0x060284DD RID: 165085
		public abstract static void NativeDestruct(IntPtr Pointer, int ArrDim = 1);

		// Token: 0x060284DE RID: 165086
		public abstract static void NativeCopy(IntPtr Dest, IntPtr Src, int ArrDim = 1);

		// Token: 0x060284DF RID: 165087
		public abstract static int NativeFindIndex(IntPtr Pointer, int ArrDim, IntPtr Value);
	}
}
