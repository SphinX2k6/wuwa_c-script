using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine
{
	// Token: 0x02000034 RID: 52
	public static class FRotationMatrix
	{
		// Token: 0x06000301 RID: 769
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix Internal_Make_FRotator(in FRotator rotator);

		// Token: 0x06000302 RID: 770
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix Internal_Make_FQuat(in FQuat quat);

		// Token: 0x06000303 RID: 771
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix Internal_MakeFromX(in FVector xAxis);

		// Token: 0x06000304 RID: 772
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix Internal_MakeFromY(in FVector yAxis);

		// Token: 0x06000305 RID: 773
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix Internal_MakeFromZ(in FVector zAxis);

		// Token: 0x06000306 RID: 774
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix Internal_MakeFromXY(in FVector xAxis, in FVector yAxis);

		// Token: 0x06000307 RID: 775
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix Internal_MakeFromXZ(in FVector xAxis, in FVector zAxis);

		// Token: 0x06000308 RID: 776
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix Internal_MakeFromYX(in FVector yAxis, in FVector xAxis);

		// Token: 0x06000309 RID: 777
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix Internal_MakeFromYZ(in FVector yAxis, in FVector zAxis);

		// Token: 0x0600030A RID: 778
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix Internal_MakeFromZX(in FVector zAxis, in FVector xAxis);

		// Token: 0x0600030B RID: 779
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix Internal_MakeFromZY(in FVector zAxis, in FVector yAxis);

		// Token: 0x0600030C RID: 780 RVA: 0x00009654 File Offset: 0x00007854
		public unsafe static FMatrix Make(in FRotator rot)
		{
			fixed (FRotator* ptr = &rot)
			{
				return FRotationMatrix.Internal_Make_FRotator(rot);
			}
		}

		// Token: 0x0600030D RID: 781 RVA: 0x0000966C File Offset: 0x0000786C
		public unsafe static FMatrix Make(in FQuat q)
		{
			fixed (FQuat* ptr = &q)
			{
				return FRotationMatrix.Internal_Make_FQuat(q);
			}
		}

		// Token: 0x0600030E RID: 782 RVA: 0x00009684 File Offset: 0x00007884
		public unsafe static FMatrix MakeFromX(in FVector xAxis)
		{
			fixed (FVector* ptr = &xAxis)
			{
				return FRotationMatrix.Internal_MakeFromX(xAxis);
			}
		}

		// Token: 0x0600030F RID: 783 RVA: 0x0000969C File Offset: 0x0000789C
		public unsafe static FMatrix MakeFromY(in FVector yAxis)
		{
			fixed (FVector* ptr = &yAxis)
			{
				return FRotationMatrix.Internal_MakeFromY(yAxis);
			}
		}

		// Token: 0x06000310 RID: 784 RVA: 0x000096B4 File Offset: 0x000078B4
		public unsafe static FMatrix MakeFromZ(in FVector zAxis)
		{
			fixed (FVector* ptr = &zAxis)
			{
				return FRotationMatrix.Internal_MakeFromZ(zAxis);
			}
		}

		// Token: 0x06000311 RID: 785 RVA: 0x000096CC File Offset: 0x000078CC
		public unsafe static FMatrix MakeFromXY(in FVector xAxis, in FVector yAxis)
		{
			fixed (FVector* ptr = &xAxis)
			{
				fixed (FVector* ptr2 = &yAxis)
				{
					return FRotationMatrix.Internal_MakeFromXY(xAxis, yAxis);
				}
			}
		}

		// Token: 0x06000312 RID: 786 RVA: 0x000096E8 File Offset: 0x000078E8
		public unsafe static FMatrix MakeFromXZ(in FVector xAxis, in FVector zAxis)
		{
			fixed (FVector* ptr = &xAxis)
			{
				fixed (FVector* ptr2 = &zAxis)
				{
					return FRotationMatrix.Internal_MakeFromXZ(xAxis, zAxis);
				}
			}
		}

		// Token: 0x06000313 RID: 787 RVA: 0x00009704 File Offset: 0x00007904
		public unsafe static FMatrix MakeFromYX(in FVector yAxis, in FVector xAxis)
		{
			fixed (FVector* ptr = &yAxis)
			{
				fixed (FVector* ptr2 = &xAxis)
				{
					return FRotationMatrix.Internal_MakeFromYX(yAxis, xAxis);
				}
			}
		}

		// Token: 0x06000314 RID: 788 RVA: 0x00009720 File Offset: 0x00007920
		public unsafe static FMatrix MakeFromYZ(in FVector yAxis, in FVector zAxis)
		{
			fixed (FVector* ptr = &yAxis)
			{
				fixed (FVector* ptr2 = &zAxis)
				{
					return FRotationMatrix.Internal_MakeFromYZ(yAxis, zAxis);
				}
			}
		}

		// Token: 0x06000315 RID: 789 RVA: 0x0000973C File Offset: 0x0000793C
		public unsafe static FMatrix MakeFromZX(in FVector zAxis, in FVector xAxis)
		{
			fixed (FVector* ptr = &zAxis)
			{
				fixed (FVector* ptr2 = &xAxis)
				{
					return FRotationMatrix.Internal_MakeFromZX(zAxis, xAxis);
				}
			}
		}

		// Token: 0x06000316 RID: 790 RVA: 0x00009758 File Offset: 0x00007958
		public unsafe static FMatrix MakeFromZY(in FVector zAxis, in FVector yAxis)
		{
			fixed (FVector* ptr = &zAxis)
			{
				fixed (FVector* ptr2 = &yAxis)
				{
					return FRotationMatrix.Internal_MakeFromZY(zAxis, yAxis);
				}
			}
		}
	}
}
