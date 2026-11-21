using System;
using System.Runtime.CompilerServices;

namespace UnrealEngine
{
	// Token: 0x02000072 RID: 114
	public static class UnrealMathUtilityF
	{
		// Token: 0x0400019D RID: 413
		public const float FLOAT_NON_FRACTIONAL = 8388608f;

		// Token: 0x0400019E RID: 414
		public const float KINDA_SMALL_NUMBER = 0.0001f;

		// Token: 0x0400019F RID: 415
		public const float SMALL_NUMBER = 1E-08f;

		// Token: 0x040001A0 RID: 416
		public const float THRESH_POINTS_ARE_SAME = 2E-05f;

		// Token: 0x040001A1 RID: 417
		public const float THRESH_VECTOR_NORMALIZED = 0.01f;

		// Token: 0x040001A2 RID: 418
		public const float THRESH_NORMALS_ARE_PARALLEL = 0.999845f;

		// Token: 0x040001A3 RID: 419
		public const float THRESH_NORMALS_ARE_ORTHOGONAL = 0.017455f;

		// Token: 0x040001A4 RID: 420
		public const float THRESH_POINT_ON_PLANE = 0.1f;

		// Token: 0x040001A5 RID: 421
		public const float ZERO_ANIMWEIGHT_THRESH = 1E-08f;

		// Token: 0x040001A6 RID: 422
		public const float BIG_NUMBER = 3.4E+38f;

		// Token: 0x040001A7 RID: 423
		public const float INV_PI = 0.31830987f;

		// Token: 0x040001A8 RID: 424
		public const float PI = 3.1415927f;

		// Token: 0x040001A9 RID: 425
		public const float HALF_PI = 1.5707964f;

		// Token: 0x040001AA RID: 426
		public const float DELTA = 1E-05f;

		// Token: 0x040001AB RID: 427
		public const float THRESH_QUAT_NORMALIZED = 0.01f;

		// Token: 0x040001AC RID: 428
		public const float UE_INV_SQRT_2 = 0.70710677f;

		// Token: 0x040001AD RID: 429
		public static readonly uint FloatPositiveInfinityBits = Unsafe.BitCast<float, uint>(float.PositiveInfinity);

		// Token: 0x040001AE RID: 430
		public static readonly ulong DoublePositiveInfinityBits = Unsafe.BitCast<double, ulong>(double.PositiveInfinity);
	}
}
