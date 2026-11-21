using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine.Extension
{
	// Token: 0x02000896 RID: 2198
	public static class VectorExtension
	{
		// Token: 0x0600BDC9 RID: 48585 RVA: 0x0012EE59 File Offset: 0x0012D059
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Set(this FVector vector, float x, float y, float z)
		{
			vector.X = x;
			vector.Y = y;
			vector.Z = z;
		}

		// Token: 0x0600BDCA RID: 48586 RVA: 0x0012EE70 File Offset: 0x0012D070
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Set(this FVector vector, double x, double y, double z)
		{
			vector.X = (float)x;
			vector.Y = (float)y;
			vector.Z = (float)z;
		}

		// Token: 0x0600BDCB RID: 48587 RVA: 0x0012EE8A File Offset: 0x0012D08A
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Set(this FVectorDouble vector, double x, double y, double z)
		{
			vector.X = x;
			vector.Y = y;
			vector.Z = z;
		}

		// Token: 0x0600BDCC RID: 48588 RVA: 0x0012EEA1 File Offset: 0x0012D0A1
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Set(this FVectorDouble vector, float x, float y, float z)
		{
			vector.X = (double)x;
			vector.Y = (double)y;
			vector.Z = (double)z;
		}
	}
}
