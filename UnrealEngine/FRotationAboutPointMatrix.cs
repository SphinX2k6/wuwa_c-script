using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine
{
	// Token: 0x02000033 RID: 51
	public static class FRotationAboutPointMatrix
	{
		// Token: 0x060002FD RID: 765
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix Internal_Make_FQuat_FVector(in FQuat a, in FVector b);

		// Token: 0x060002FE RID: 766
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix Internal_Make_FRotator_FVector(in FRotator a, in FVector b);

		// Token: 0x060002FF RID: 767 RVA: 0x0000961C File Offset: 0x0000781C
		public unsafe static FMatrix Make(in FQuat q, in FVector origin)
		{
			fixed (FQuat* ptr = &q)
			{
				fixed (FVector* ptr2 = &origin)
				{
					return FRotationAboutPointMatrix.Internal_Make_FQuat_FVector(q, origin);
				}
			}
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00009638 File Offset: 0x00007838
		public unsafe static FMatrix Make(in FRotator rot, in FVector origin)
		{
			fixed (FRotator* ptr = &rot)
			{
				fixed (FVector* ptr2 = &origin)
				{
					return FRotationAboutPointMatrix.Internal_Make_FRotator_FVector(rot, origin);
				}
			}
		}
	}
}
