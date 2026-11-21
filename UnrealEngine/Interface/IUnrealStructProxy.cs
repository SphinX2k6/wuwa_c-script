using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine.Interface
{
	// Token: 0x020008C5 RID: 2245
	[NullableContext(1)]
	public interface IUnrealStructProxy<[Nullable(2)] T>
	{
		// Token: 0x1700232E RID: 9006
		// (get) Token: 0x0600BE91 RID: 48785
		IntPtr NativePtr { get; }

		// Token: 0x1700232F RID: 9007
		// (get) Token: 0x0600BE92 RID: 48786
		int Size { get; }

		// Token: 0x17002330 RID: 9008
		// (get) Token: 0x0600BE93 RID: 48787
		int MinAlignment { get; }

		// Token: 0x0600BE94 RID: 48788
		public abstract static T Create(IntPtr Src);

		// Token: 0x0600BE95 RID: 48789
		public abstract static T Create(IntPtr Src, [Nullable(2)] UnrealObject MemoryOwner);

		// Token: 0x0600BE96 RID: 48790
		public abstract static void NativeConstruct(IntPtr Pointer, int ArrDim = 1);

		// Token: 0x0600BE97 RID: 48791
		public abstract static void NativeDestruct(IntPtr Pointer, int ArrDim = 1);

		// Token: 0x0600BE98 RID: 48792
		public abstract static void NativeCopy(IntPtr Dest, IntPtr Src, int ArrDim = 1);

		// Token: 0x0600BE99 RID: 48793
		public abstract static int NativeFindIndex(IntPtr Pointer, int ArrDim, IntPtr Value);
	}
}
