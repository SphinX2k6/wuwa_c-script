using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine
{
	// Token: 0x02000031 RID: 49
	public static class FRotationTranslationMatrix
	{
		// Token: 0x060002F9 RID: 761
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix Internal_Make(in FRotator a, in FVector b);

		// Token: 0x060002FA RID: 762 RVA: 0x000095E4 File Offset: 0x000077E4
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
