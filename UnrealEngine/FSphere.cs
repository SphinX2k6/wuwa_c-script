using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200003B RID: 59
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 16)]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 16)]
	public struct FSphere : IEquatable<FSphere>, IEqualityOperators<FSphere, FSphere, bool>
	{
		// Token: 0x06000456 RID: 1110 RVA: 0x0000B279 File Offset: 0x00009479
		public FSphere()
		{
			this.Center = FVector.ZeroVector;
			this.W = 0f;
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x0000B291 File Offset: 0x00009491
		public FSphere(in FVector center, float radius)
		{
			this.Center = center;
			this.W = radius;
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x0000B2A6 File Offset: 0x000094A6
		[NullableContext(1)]
		public FSphere(FVector[] points)
		{
			this = new FSphere(points.AsSpan<FVector>());
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x0000B2B4 File Offset: 0x000094B4
		public static bool operator ==(FSphere left, FSphere right)
		{
			return left.Center == right.Center && left.W == right.W;
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x0000B2D9 File Offset: 0x000094D9
		public static bool operator !=(FSphere left, FSphere right)
		{
			return left.Center != right.Center || left.W != right.W;
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x0000B301 File Offset: 0x00009501
		public readonly bool Equals(FSphere other)
		{
			return this == other;
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x0000B310 File Offset: 0x00009510
		[NullableContext(2)]
		public override readonly bool Equals(object obj)
		{
			if (obj is FSphere)
			{
				FSphere right = (FSphere)obj;
				return this == right;
			}
			return false;
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x0000B33A File Offset: 0x0000953A
		public override readonly int GetHashCode()
		{
			return HashCode.Combine<FVector, float>(this.Center, this.W);
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x0000B350 File Offset: 0x00009550
		[NullableContext(1)]
		public override readonly string ToString()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(16, 2);
			defaultInterpolatedStringHandler.AppendLiteral("Center=");
			defaultInterpolatedStringHandler.AppendFormatted<FVector>(this.Center);
			defaultInterpolatedStringHandler.AppendLiteral(", Radius=");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.W);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x0600045F RID: 1119
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FSphere Internal_Ctor_FVectorArr(FVector* vectors, int count);

		// Token: 0x06000460 RID: 1120
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_Equals(in FSphere a, in FSphere b, float tolerance);

		// Token: 0x06000461 RID: 1121
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IsInside_FSphere(in FSphere a, in FSphere b, float tolerance);

		// Token: 0x06000462 RID: 1122
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IsInside_FVector(in FSphere a, in FVector vector, float tolerance);

		// Token: 0x06000463 RID: 1123
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_Intersects(in FSphere a, in FSphere b, float tolerance);

		// Token: 0x06000464 RID: 1124
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FSphere Internal_TransformBy_FMatrix(in FSphere sphere, in FMatrix matrix);

		// Token: 0x06000465 RID: 1125
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FSphere Internal_TransformBy_FTransform(in FSphere sphere, in FTransform transform);

		// Token: 0x06000466 RID: 1126
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_GetVolume(in FSphere sphere);

		// Token: 0x06000467 RID: 1127
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FSphere Internal_Add(in FSphere a, in FSphere b);

		// Token: 0x06000468 RID: 1128 RVA: 0x0000B3A0 File Offset: 0x000095A0
		public unsafe FSphere(Span<FVector> vectors)
		{
			fixed (FVector* pinnableReference = vectors.GetPinnableReference())
			{
				FVector* vectors2 = pinnableReference;
				fixed (FSphere* ptr = &this)
				{
					this = FSphere.Internal_Ctor_FVectorArr(vectors2, vectors.Length);
				}
			}
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x0000B3D8 File Offset: 0x000095D8
		public unsafe readonly bool Equals(in FSphere other, float tolerance = 0.0001f)
		{
			fixed (FSphere* ptr = &this)
			{
				fixed (FSphere* ptr2 = &other)
				{
					return FSphere.Internal_Equals(this, other, tolerance);
				}
			}
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x0000B3F8 File Offset: 0x000095F8
		public unsafe readonly bool IsInside(in FSphere other, float tolerance = 0.0001f)
		{
			fixed (FSphere* ptr = &this)
			{
				fixed (FSphere* ptr2 = &other)
				{
					return FSphere.Internal_IsInside_FSphere(this, other, tolerance);
				}
			}
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x0000B418 File Offset: 0x00009618
		public unsafe readonly bool IsInside(in FVector vector, float tolerance = 0.0001f)
		{
			fixed (FSphere* ptr = &this)
			{
				fixed (FVector* ptr2 = &vector)
				{
					return FSphere.Internal_IsInside_FVector(this, vector, tolerance);
				}
			}
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x0000B438 File Offset: 0x00009638
		public unsafe readonly bool Intersects(in FSphere other, float tolerance = 0.0001f)
		{
			fixed (FSphere* ptr = &this)
			{
				fixed (FSphere* ptr2 = &other)
				{
					return FSphere.Internal_Intersects(this, other, tolerance);
				}
			}
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x0000B458 File Offset: 0x00009658
		public unsafe readonly FSphere TransformBy(in FMatrix matrix)
		{
			fixed (FSphere* ptr = &this)
			{
				fixed (FMatrix* ptr2 = &matrix)
				{
					return FSphere.Internal_TransformBy_FMatrix(this, matrix);
				}
			}
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x0000B474 File Offset: 0x00009674
		public unsafe readonly FSphere TransformBy(in FTransform transform)
		{
			fixed (FSphere* ptr = &this)
			{
				fixed (FTransform* ptr2 = &transform)
				{
					return FSphere.Internal_TransformBy_FTransform(this, transform);
				}
			}
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x0000B490 File Offset: 0x00009690
		public unsafe readonly float GetVolume()
		{
			fixed (FSphere* ptr = &this)
			{
				return FSphere.Internal_GetVolume(this);
			}
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x0000B4A8 File Offset: 0x000096A8
		public unsafe static FSphere operator +(in FSphere a, in FSphere b)
		{
			fixed (FSphere* ptr = &a)
			{
				fixed (FSphere* ptr2 = &b)
				{
					return FSphere.Internal_Add(a, b);
				}
			}
		}

		// Token: 0x040000F0 RID: 240
		[FieldOffset(0)]
		public FVector Center;

		// Token: 0x040000F1 RID: 241
		[FieldOffset(12)]
		public float W;

		// Token: 0x040000F2 RID: 242
		public static readonly FSphere Empty = new FSphere();
	}
}
