using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000020 RID: 32
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 16)]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 16)]
	public struct FSphere : IEquatable<FSphere>, IEqualityOperators<FSphere, FSphere, bool>
	{
		// Token: 0x060003DB RID: 987 RVA: 0x00007AE5 File Offset: 0x00005CE5
		public FSphere()
		{
			this.Center = FVector.ZeroVector;
			this.W = 0f;
		}

		// Token: 0x060003DC RID: 988 RVA: 0x00007AFD File Offset: 0x00005CFD
		public FSphere(in FVector center, float radius)
		{
			this.Center = center;
			this.W = radius;
		}

		// Token: 0x060003DD RID: 989 RVA: 0x00007B12 File Offset: 0x00005D12
		[NullableContext(1)]
		public FSphere(FVector[] points)
		{
			this = new FSphere(points.AsSpan<FVector>());
		}

		// Token: 0x060003DE RID: 990 RVA: 0x00007B20 File Offset: 0x00005D20
		public static bool operator ==(FSphere left, FSphere right)
		{
			return left.Center == right.Center && left.W == right.W;
		}

		// Token: 0x060003DF RID: 991 RVA: 0x00007B45 File Offset: 0x00005D45
		public static bool operator !=(FSphere left, FSphere right)
		{
			return left.Center != right.Center || left.W != right.W;
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x00007B6D File Offset: 0x00005D6D
		public readonly bool Equals(FSphere other)
		{
			return this == other;
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x00007B7C File Offset: 0x00005D7C
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

		// Token: 0x060003E2 RID: 994 RVA: 0x00007BA6 File Offset: 0x00005DA6
		public override readonly int GetHashCode()
		{
			return HashCode.Combine<FVector, float>(this.Center, this.W);
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x00007BBC File Offset: 0x00005DBC
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

		// Token: 0x060003E4 RID: 996
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FSphere Internal_Ctor_FVectorArr(FVector* vectors, int count);

		// Token: 0x060003E5 RID: 997
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_Equals(in FSphere a, in FSphere b, float tolerance);

		// Token: 0x060003E6 RID: 998
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IsInside_FSphere(in FSphere a, in FSphere b, float tolerance);

		// Token: 0x060003E7 RID: 999
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IsInside_FVector(in FSphere a, in FVector vector, float tolerance);

		// Token: 0x060003E8 RID: 1000
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_Intersects(in FSphere a, in FSphere b, float tolerance);

		// Token: 0x060003E9 RID: 1001
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FSphere Internal_TransformBy_FMatrix(in FSphere sphere, in FMatrix matrix);

		// Token: 0x060003EA RID: 1002
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FSphere Internal_TransformBy_FTransform(in FSphere sphere, in FTransform transform);

		// Token: 0x060003EB RID: 1003
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_GetVolume(in FSphere sphere);

		// Token: 0x060003EC RID: 1004
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FSphere Internal_Add(in FSphere a, in FSphere b);

		// Token: 0x060003ED RID: 1005 RVA: 0x00007C0C File Offset: 0x00005E0C
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

		// Token: 0x060003EE RID: 1006 RVA: 0x00007C44 File Offset: 0x00005E44
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

		// Token: 0x060003EF RID: 1007 RVA: 0x00007C64 File Offset: 0x00005E64
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

		// Token: 0x060003F0 RID: 1008 RVA: 0x00007C84 File Offset: 0x00005E84
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

		// Token: 0x060003F1 RID: 1009 RVA: 0x00007CA4 File Offset: 0x00005EA4
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

		// Token: 0x060003F2 RID: 1010 RVA: 0x00007CC4 File Offset: 0x00005EC4
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

		// Token: 0x060003F3 RID: 1011 RVA: 0x00007CE0 File Offset: 0x00005EE0
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

		// Token: 0x060003F4 RID: 1012 RVA: 0x00007CFC File Offset: 0x00005EFC
		public unsafe readonly float GetVolume()
		{
			fixed (FSphere* ptr = &this)
			{
				return FSphere.Internal_GetVolume(this);
			}
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x00007D14 File Offset: 0x00005F14
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

		// Token: 0x040000A9 RID: 169
		[FieldOffset(0)]
		public FVector Center;

		// Token: 0x040000AA RID: 170
		[FieldOffset(12)]
		public float W;

		// Token: 0x040000AB RID: 171
		public static readonly FSphere Empty = new FSphere();
	}
}
