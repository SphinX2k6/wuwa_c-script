using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine
{
	// Token: 0x02000016 RID: 22
	public static class FRotationTranslationMatrix
	{
		// Token: 0x0600027E RID: 638
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix Internal_Make(in FRotator a, in FVector b);

		// Token: 0x0600027F RID: 639 RVA: 0x00005E50 File Offset: 0x00004050
		public unsafe static FMatrix Make(in FRotator rot, in FVector origin)
		{
			fixed (FRotator* ptr = &rot)
			{
				fixed (FVector* ptr2 = &origin)
				{
					return FRotationTranslationMatrix.Internal_Make(rot, origin);
				}
			}
		}
	}
}
