using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine
{
	// Token: 0x02000017 RID: 23
	public static class FQuatRotationTranslationMatrix
	{
		// Token: 0x06000280 RID: 640
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix Internal_Make(in FQuat a, in FVector b);

		// Token: 0x06000281 RID: 641 RVA: 0x00005E6C File Offset: 0x0000406C
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
