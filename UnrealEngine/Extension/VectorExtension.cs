using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine.Extension
{
	// Token: 0x02002AE7 RID: 10983
	public static class VectorExtension
	{
		// Token: 0x06028414 RID: 164884 RVA: 0x003D3B49 File Offset: 0x003D1D49
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Set(this FVector vector, float x, float y, float z)
		{
			vector.X = x;
			vector.Y = y;
			vector.Z = z;
		}

		// Token: 0x06028415 RID: 164885 RVA: 0x003D3B60 File Offset: 0x003D1D60
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Set(this FVector vector, double x, double y, double z)
		{
			vector.X = (float)x;
			vector.Y = (float)y;
			vector.Z = (float)z;
		}

		// Token: 0x06028416 RID: 164886 RVA: 0x003D3B7A File Offset: 0x003D1D7A
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Set(this FVectorDouble vector, double x, double y, double z)
		{
			vector.X = x;
			vector.Y = y;
			vector.Z = z;
		}

		// Token: 0x06028417 RID: 164887 RVA: 0x003D3B91 File Offset: 0x003D1D91
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Set(this FVectorDouble vector, float x, float y, float z)
		{
			vector.X = (double)x;
			vector.Y = (double)y;
			vector.Z = (double)z;
		}
	}
}
