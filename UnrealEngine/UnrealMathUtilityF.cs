using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine
{
	// Token: 0x0200008D RID: 141
	public static class UnrealMathUtilityF
	{
		// Token: 0x040001E4 RID: 484
		public const float FLOAT_NON_FRACTIONAL = 8388608f;

		// Token: 0x040001E5 RID: 485
		public const float KINDA_SMALL_NUMBER = 0.0001f;

		// Token: 0x040001E6 RID: 486
		public const float SMALL_NUMBER = 1E-08f;

		// Token: 0x040001E7 RID: 487
		public const float THRESH_POINTS_ARE_SAME = 2E-05f;

		// Token: 0x040001E8 RID: 488
		public const float THRESH_VECTOR_NORMALIZED = 0.01f;

		// Token: 0x040001E9 RID: 489
		public const float THRESH_NORMALS_ARE_PARALLEL = 0.999845f;

		// Token: 0x040001EA RID: 490
		public const float THRESH_NORMALS_ARE_ORTHOGONAL = 0.017455f;

		// Token: 0x040001EB RID: 491
		public const float THRESH_POINT_ON_PLANE = 0.1f;

		// Token: 0x040001EC RID: 492
		public const float ZERO_ANIMWEIGHT_THRESH = 1E-08f;

		// Token: 0x040001ED RID: 493
		public const float BIG_NUMBER = 3.4E+38f;

		// Token: 0x040001EE RID: 494
		public const float INV_PI = 0.31830987f;

		// Token: 0x040001EF RID: 495
		public const float PI = 3.1415927f;

		// Token: 0x040001F0 RID: 496
		public const float HALF_PI = 1.5707964f;

		// Token: 0x040001F1 RID: 497
		public const float DELTA = 1E-05f;

		// Token: 0x040001F2 RID: 498
		public const float THRESH_QUAT_NORMALIZED = 0.01f;

		// Token: 0x040001F3 RID: 499
		public const float UE_INV_SQRT_2 = 0.70710677f;

		// Token: 0x040001F4 RID: 500
		public static readonly uint FloatPositiveInfinityBits = Unsafe.BitCast<float, uint>(float.PositiveInfinity);

		// Token: 0x040001F5 RID: 501
		public static readonly ulong DoublePositiveInfinityBits = Unsafe.BitCast<double, ulong>(double.PositiveInfinity);
	}
}
