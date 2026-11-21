using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine.Interface
{
	// Token: 0x020008C6 RID: 2246
	[NullableContext(1)]
	public interface IUnrealStructProxyForward<[Nullable(2)] T, [Nullable(0)] Base> : IUnrealStructProxy<T> where Base : IUnrealStructProxy<Base>
	{
		// Token: 0x17002331 RID: 9009
		// (get) Token: 0x0600BE9A RID: 48794 RVA: 0x0013062C File Offset: 0x0012E82C
		int IUnrealStructProxy<!0>.Size
		{
			get
			{
				return IUnrealStructProxy<Base>.Size;
			}
		}

		// Token: 0x17002332 RID: 9010
		// (get) Token: 0x0600BE9B RID: 48795 RVA: 0x00130639 File Offset: 0x0012E839
		int IUnrealStructProxy<!0>.MinAlignment
		{
			get
			{
				return IUnrealStructProxy<Base>.MinAlignment;
			}
		}

		// Token: 0x0600BE9C RID: 48796
		private abstract static T Create(IntPtr Pointer);

		// Token: 0x0600BE9D RID: 48797 RVA: 0x00130646 File Offset: 0x0012E846
		private static void NativeConstruct(IntPtr Pointer, int ArrDim)
		{
			IUnrealStructProxy<Base>.NativeConstruct(Pointer, ArrDim);
		}

		// Token: 0x0600BE9E RID: 48798 RVA: 0x00130655 File Offset: 0x0012E855
		private static void NativeDestruct(IntPtr Pointer, int ArrDim)
		{
			IUnrealStructProxy<Base>.NativeDestruct(Pointer, ArrDim);
		}

		// Token: 0x0600BE9F RID: 48799 RVA: 0x00130664 File Offset: 0x0012E864
		private static void NativeCopy(IntPtr Dest, IntPtr Src, int ArrDim)
		{
			IUnrealStructProxy<Base>.NativeCopy(Dest, Src, ArrDim);
		}

		// Token: 0x0600BEA0 RID: 48800 RVA: 0x00130674 File Offset: 0x0012E874
		private static int NativeFindIndex(IntPtr Pointer, int ArrDim, IntPtr Value)
		{
			return IUnrealStructProxy<Base>.NativeFindIndex(Pointer, ArrDim, Value);
		}
	}
}
