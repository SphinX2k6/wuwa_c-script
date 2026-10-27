using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine.Interface
{
	// Token: 0x02002B16 RID: 11030
	[NullableContext(1)]
	public interface IUnrealStructProxyForward<[Nullable(2)] T, [Nullable(0)] Base> : IUnrealStructProxy<T> where Base : IUnrealStructProxy<Base>
	{
		// Token: 0x170099A8 RID: 39336
		// (get) Token: 0x060284E0 RID: 165088 RVA: 0x003D52D0 File Offset: 0x003D34D0
		int IUnrealStructProxy<!0>.Size
		{
			get
			{
				return IUnrealStructProxy<Base>.Size;
			}
		}

		// Token: 0x170099A9 RID: 39337
		// (get) Token: 0x060284E1 RID: 165089 RVA: 0x003D52DD File Offset: 0x003D34DD
		int IUnrealStructProxy<!0>.MinAlignment
		{
			get
			{
				return IUnrealStructProxy<Base>.MinAlignment;
			}
		}

		// Token: 0x060284E2 RID: 165090
		private abstract static T Create(IntPtr Pointer);

		// Token: 0x060284E3 RID: 165091 RVA: 0x003D52EA File Offset: 0x003D34EA
		private static void NativeConstruct(IntPtr Pointer, int ArrDim)
		{
			IUnrealStructProxy<Base>.NativeConstruct(Pointer, ArrDim);
		}

		// Token: 0x060284E4 RID: 165092 RVA: 0x003D52F9 File Offset: 0x003D34F9
		private static void NativeDestruct(IntPtr Pointer, int ArrDim)
		{
			IUnrealStructProxy<Base>.NativeDestruct(Pointer, ArrDim);
		}

		// Token: 0x060284E5 RID: 165093 RVA: 0x003D5308 File Offset: 0x003D3508
		private static void NativeCopy(IntPtr Dest, IntPtr Src, int ArrDim)
		{
			IUnrealStructProxy<Base>.NativeCopy(Dest, Src, ArrDim);
		}

		// Token: 0x060284E6 RID: 165094 RVA: 0x003D5318 File Offset: 0x003D3518
		private static int NativeFindIndex(IntPtr Pointer, int ArrDim, IntPtr Value)
		{
			return IUnrealStructProxy<Base>.NativeFindIndex(Pointer, ArrDim, Value);
		}
	}
}
