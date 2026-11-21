using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine
{
	// Token: 0x02000018 RID: 24
	public static class FRotationAboutPointMatrix
	{
		// Token: 0x06000282 RID: 642
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix Internal_Make_FQuat_FVector(in FQuat a, in FVector b);

		// Token: 0x06000283 RID: 643
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix Internal_Make_FRotator_FVector(in FRotator a, in FVector b);

		// Token: 0x06000284 RID: 644 RVA: 0x00005E88 File Offset: 0x00004088
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

		// Token: 0x06000285 RID: 645 RVA: 0x00005EA4 File Offset: 0x000040A4
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
