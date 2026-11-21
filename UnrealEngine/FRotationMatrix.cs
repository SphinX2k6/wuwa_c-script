using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine
{
	// Token: 0x02000019 RID: 25
	public static class FRotationMatrix
	{
		// Token: 0x06000286 RID: 646
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix Internal_Make_FRotator(in FRotator rotator);

		// Token: 0x06000287 RID: 647
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix Internal_Make_FQuat(in FQuat quat);

		// Token: 0x06000288 RID: 648
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix Internal_MakeFromX(in FVector xAxis);

		// Token: 0x06000289 RID: 649
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix Internal_MakeFromY(in FVector yAxis);

		// Token: 0x0600028A RID: 650
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix Internal_MakeFromZ(in FVector zAxis);

		// Token: 0x0600028B RID: 651
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix Internal_MakeFromXY(in FVector xAxis, in FVector yAxis);

		// Token: 0x0600028C RID: 652
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix Internal_MakeFromXZ(in FVector xAxis, in FVector zAxis);

		// Token: 0x0600028D RID: 653
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix Internal_MakeFromYX(in FVector yAxis, in FVector xAxis);

		// Token: 0x0600028E RID: 654
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix Internal_MakeFromYZ(in FVector yAxis, in FVector zAxis);

		// Token: 0x0600028F RID: 655
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix Internal_MakeFromZX(in FVector zAxis, in FVector xAxis);

		// Token: 0x06000290 RID: 656
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix Internal_MakeFromZY(in FVector zAxis, in FVector yAxis);

		// Token: 0x06000291 RID: 657 RVA: 0x00005EC0 File Offset: 0x000040C0
		public unsafe static FMatrix Make(in FRotator rot)
		{
			fixed (FRotator* ptr = &rot)
			{
				return FRotationMatrix.Internal_Make_FRotator(rot);
			}
		}

		// Token: 0x06000292 RID: 658 RVA: 0x00005ED8 File Offset: 0x000040D8
		public unsafe static FMatrix Make(in FQuat q)
		{
			fixed (FQuat* ptr = &q)
			{
				return FRotationMatrix.Internal_Make_FQuat(q);
			}
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00005EF0 File Offset: 0x000040F0
		public unsafe static FMatrix MakeFromX(in FVector xAxis)
		{
			fixed (FVector* ptr = &xAxis)
			{
				return FRotationMatrix.Internal_MakeFromX(xAxis);
			}
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00005F08 File Offset: 0x00004108
		public unsafe static FMatrix MakeFromY(in FVector yAxis)
		{
			fixed (FVector* ptr = &yAxis)
			{
				return FRotationMatrix.Internal_MakeFromY(yAxis);
			}
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00005F20 File Offset: 0x00004120
		public unsafe static FMatrix MakeFromZ(in FVector zAxis)
		{
			fixed (FVector* ptr = &zAxis)
			{
				return FRotationMatrix.Internal_MakeFromZ(zAxis);
			}
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00005F38 File Offset: 0x00004138
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

		// Token: 0x06000297 RID: 663 RVA: 0x00005F54 File Offset: 0x00004154
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

		// Token: 0x06000298 RID: 664 RVA: 0x00005F70 File Offset: 0x00004170
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

		// Token: 0x06000299 RID: 665 RVA: 0x00005F8C File Offset: 0x0000418C
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

		// Token: 0x0600029A RID: 666 RVA: 0x00005FA8 File Offset: 0x000041A8
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

		// Token: 0x0600029B RID: 667 RVA: 0x00005FC4 File Offset: 0x000041C4
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
