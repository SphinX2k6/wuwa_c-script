using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine
{
	// Token: 0x02000032 RID: 50
	public static class FQuatRotationTranslationMatrix
	{
		// Token: 0x060002FB RID: 763
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix Internal_Make(in FQuat a, in FVector b);

		// Token: 0x060002FC RID: 764 RVA: 0x00009600 File Offset: 0x00007800
		public unsafe static FMatrix Make(in FQuat q, in FVector origin)
		{
			fixed (FQuat* ptr = &q)
			{
				fixed (FVector* ptr2 = &origin)
				{
					return FQuatRotationTranslationMatrix.Internal_Make(q, origin);
				}
			}
		}
	}
}
