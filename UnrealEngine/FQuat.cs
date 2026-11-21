using System;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200001D RID: 29
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(16, 16, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 16)]
	[UnrealObjectPath("/Script/CoreUObject.Quat")]
	[StructLayout(LayoutKind.Explicit, Pack = 16, Size = 16)]
	public struct FQuat : IEquatable<FQuat>, IEqualityOperators<FQuat, FQuat, bool>, IQuat, IUnrealScriptStruct
	{
		// Token: 0x060002DE RID: 734 RVA: 0x0000679A File Offset: 0x0000499A
		[Conditional("ENABLE_NAN_DIAGNOSTIC")]
		public void DiagnosticCheckNaN()
		{
			if (!SharpherealAssert.Ensure(!this.ContainsNaN(), "FQuat contains NaN: {0}", new object[]
			{
				this
			}))
			{
				this = FQuat.Identity;
			}
		}

		// Token: 0x060002DF RID: 735 RVA: 0x000067D0 File Offset: 0x000049D0
		public FQuat()
		{
			this.X = 0f;
			this.Y = 0f;
			this.Z = 0f;
			this.W = 0f;
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x000067FE File Offset: 0x000049FE
		public static bool operator ==(FQuat a, FQuat b)
		{
			return a.X == b.X && a.Y == b.Y && a.Z == b.Z && a.W == b.W;
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x0000683A File Offset: 0x00004A3A
		public static bool operator !=(FQuat a, FQuat b)
		{
			return a.X != b.X || a.Y != b.Y || a.Z != b.Z || a.W != b.W;
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x00006879 File Offset: 0x00004A79
		public readonly bool Equals(FQuat other)
		{
			return this == other;
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x00006888 File Offset: 0x00004A88
		[NullableContext(2)]
		public override readonly bool Equals(object obj)
		{
			if (obj is FQuat)
			{
				FQuat b = (FQuat)obj;
				return this == b;
			}
			return false;
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x000068B2 File Offset: 0x00004AB2
		public override readonly int GetHashCode()
		{
			return HashCode.Combine<float, float, float, float>(this.X, this.Y, this.Z, this.W);
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x000068D4 File Offset: 0x00004AD4
		[NullableContext(1)]
		public override readonly string ToString()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(11, 4);
			defaultInterpolatedStringHandler.AppendLiteral("X=");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.X);
			defaultInterpolatedStringHandler.AppendLiteral(" Y=");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.Y);
			defaultInterpolatedStringHandler.AppendLiteral(" Z=");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.Z);
			defaultInterpolatedStringHandler.AppendLiteral(" W=");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.W);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x00006956 File Offset: 0x00004B56
		public readonly FQuat Inverse()
		{
			return new FQuat(-this.X, -this.Y, -this.Z, this.W);
		}

		// Token: 0x060002E7 RID: 743
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat Internal_Ctor_XYZW(float x, float y, float z, float w);

		// Token: 0x060002E8 RID: 744
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat Internal_Ctor_FRotator(in FRotator rotator);

		// Token: 0x060002E9 RID: 745
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat Internal_Ctor_FMatrix(in FMatrix matrix);

		// Token: 0x060002EA RID: 746
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat Internal_Ctor_FVector_float(in FVector axis, float angleRad);

		// Token: 0x060002EB RID: 747
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat Internal_MakeFromEuler(in FVector euler);

		// Token: 0x060002EC RID: 748
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat Internal_FindBetween(in FVector a, in FVector b);

		// Token: 0x060002ED RID: 749
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat Internal_FindBetweenNormals(in FVector a, in FVector b);

		// Token: 0x060002EE RID: 750
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat Internal_FindBetweenVectors(in FVector a, in FVector b);

		// Token: 0x060002EF RID: 751
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat Internal_Add(in FQuat a, in FQuat b);

		// Token: 0x060002F0 RID: 752
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat Internal_Sub(in FQuat a, in FQuat b);

		// Token: 0x060002F1 RID: 753
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat Internal_Mul(in FQuat a, in FQuat b);

		// Token: 0x060002F2 RID: 754
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat Internal_MulFloat(in FQuat a, float scale);

		// Token: 0x060002F3 RID: 755
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_MulFVector(in FQuat a, in FVector v);

		// Token: 0x060002F4 RID: 756
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_MulFVectorDouble(in FQuat a, in FVectorDouble v);

		// Token: 0x060002F5 RID: 757
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix Internal_MulFMatrix(in FQuat a, in FMatrix m);

		// Token: 0x060002F6 RID: 758
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat Internal_DivFloat(in FQuat a, float scale);

		// Token: 0x060002F7 RID: 759
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_Or(in FQuat a, in FQuat b);

		// Token: 0x060002F8 RID: 760
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_Equals(in FQuat a, in FQuat b, float tolerance);

		// Token: 0x060002F9 RID: 761
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_Identical(in FQuat a, in FQuat b, uint portFlags);

		// Token: 0x060002FA RID: 762
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IsIdentity(in FQuat a, float tolerance);

		// Token: 0x060002FB RID: 763
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_Euler(in FQuat a);

		// Token: 0x060002FC RID: 764
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Normalize(ref FQuat a, float tolerance);

		// Token: 0x060002FD RID: 765
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat Internal_GetNormalized(in FQuat a, float tolerance);

		// Token: 0x060002FE RID: 766
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IsNormalized(in FQuat a);

		// Token: 0x060002FF RID: 767
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_Size(in FQuat a);

		// Token: 0x06000300 RID: 768
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_SizeSquared(in FQuat a);

		// Token: 0x06000301 RID: 769
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_GetAngle(in FQuat a);

		// Token: 0x06000302 RID: 770
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_ToAxisAndAngle(in FQuat a, out FVector axis, out float angle);

		// Token: 0x06000303 RID: 771
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_ToSwingTwist(in FQuat a, in FVector inTwistAxis, out FQuat outSwing, out FQuat outTwist);

		// Token: 0x06000304 RID: 772
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_GetTwistAngle(in FQuat a, in FVector twistAxis);

		// Token: 0x06000305 RID: 773
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_RotateVector(in FQuat a, in FVector v);

		// Token: 0x06000306 RID: 774
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_RotateVectorDouble(in FQuat a, in FVectorDouble v);

		// Token: 0x06000307 RID: 775
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_UnrotateVector(in FQuat a, in FVector v);

		// Token: 0x06000308 RID: 776
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_UnrotateVectorDouble(in FQuat a, in FVectorDouble v);

		// Token: 0x06000309 RID: 777
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat Internal_Log(in FQuat a);

		// Token: 0x0600030A RID: 778
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat Internal_Exp(in FQuat a);

		// Token: 0x0600030B RID: 779
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_EnforceShortestArcWith(ref FQuat a, in FQuat b);

		// Token: 0x0600030C RID: 780
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_GetAxisX(in FQuat a);

		// Token: 0x0600030D RID: 781
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_GetAxisY(in FQuat a);

		// Token: 0x0600030E RID: 782
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_GetAxisZ(in FQuat a);

		// Token: 0x0600030F RID: 783
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_GetForwardVector(in FQuat a);

		// Token: 0x06000310 RID: 784
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_GetRightVector(in FQuat a);

		// Token: 0x06000311 RID: 785
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_GetUpVector(in FQuat a);

		// Token: 0x06000312 RID: 786
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_Vector(in FQuat a);

		// Token: 0x06000313 RID: 787
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator Internal_Rotator(in FQuat a);

		// Token: 0x06000314 RID: 788
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_GetRotationAxis(in FQuat a);

		// Token: 0x06000315 RID: 789
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_AngularDistance(in FQuat a, in FQuat b);

		// Token: 0x06000316 RID: 790
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_ContainsNaN(in FQuat a);

		// Token: 0x06000317 RID: 791
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_Error(in FQuat a, in FQuat b);

		// Token: 0x06000318 RID: 792
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_ErrorAutoNormalize(in FQuat a, in FQuat b);

		// Token: 0x06000319 RID: 793
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat Internal_FastLerp(in FQuat a, in FQuat b, float alpha);

		// Token: 0x0600031A RID: 794
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat Internal_FastBilerp(in FQuat p00, in FQuat p10, in FQuat p01, in FQuat p11, float fracX, float fracY);

		// Token: 0x0600031B RID: 795
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat Internal_Slerp(in FQuat a, in FQuat b, float slerp);

		// Token: 0x0600031C RID: 796
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat Internal_Slerp_NotNormalized(in FQuat a, in FQuat b, float slerp);

		// Token: 0x0600031D RID: 797
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat Internal_SlerpFullPath_NotNormalized(in FQuat a, in FQuat b, float alpha);

		// Token: 0x0600031E RID: 798
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat Internal_SlerpFullPath(in FQuat a, in FQuat b, float alpha);

		// Token: 0x0600031F RID: 799
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat Internal_Squad(in FQuat quat1, in FQuat tang1, in FQuat quat2, in FQuat tang2, float alpha);

		// Token: 0x06000320 RID: 800
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat Internal_SquadFullPath(in FQuat quat1, in FQuat tang1, in FQuat quat2, in FQuat tang2, float alpha);

		// Token: 0x06000321 RID: 801
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_CalcTangents(in FQuat prevP, in FQuat p, in FQuat nextP, float tension, out FQuat outTan);

		// Token: 0x06000322 RID: 802
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_InitFromString(ref FQuat a, in FCSharpStringView str);

		// Token: 0x06000323 RID: 803 RVA: 0x00006978 File Offset: 0x00004B78
		public FQuat(float x, float y, float z, float w)
		{
			this.X = x;
			this.Y = y;
			this.Z = z;
			this.W = w;
		}

		// Token: 0x06000324 RID: 804 RVA: 0x00006997 File Offset: 0x00004B97
		public FQuat(in FRotator rotator)
		{
			this = rotator.Quaternion();
		}

		// Token: 0x06000325 RID: 805 RVA: 0x000069A8 File Offset: 0x00004BA8
		public unsafe FQuat(in FMatrix matrix)
		{
			fixed (FMatrix* ptr = &matrix)
			{
				fixed (FQuat* ptr2 = &this)
				{
					this = FQuat.Internal_Ctor_FMatrix(matrix);
				}
			}
		}

		// Token: 0x06000326 RID: 806 RVA: 0x000069D0 File Offset: 0x00004BD0
		public unsafe FQuat(in FVector axis, float angleRad)
		{
			fixed (FVector* ptr = &axis)
			{
				fixed (FQuat* ptr2 = &this)
				{
					this = FQuat.Internal_Ctor_FVector_float(axis, angleRad);
				}
			}
		}

		// Token: 0x06000327 RID: 807 RVA: 0x000069F8 File Offset: 0x00004BF8
		public unsafe static FQuat MakeFromEuler(in FVector euler)
		{
			fixed (FVector* ptr = &euler)
			{
				return FQuat.Internal_MakeFromEuler(euler);
			}
		}

		// Token: 0x06000328 RID: 808 RVA: 0x00006A10 File Offset: 0x00004C10
		public unsafe static FQuat FindBetween(in FVector a, in FVector b)
		{
			fixed (FVector* ptr = &a)
			{
				fixed (FVector* ptr2 = &b)
				{
					return FQuat.Internal_FindBetween(a, b);
				}
			}
		}

		// Token: 0x06000329 RID: 809 RVA: 0x00006A2C File Offset: 0x00004C2C
		public unsafe static FQuat FindBetweenNormals(in FVector a, in FVector b)
		{
			fixed (FVector* ptr = &a)
			{
				fixed (FVector* ptr2 = &b)
				{
					return FQuat.Internal_FindBetweenNormals(a, b);
				}
			}
		}

		// Token: 0x0600032A RID: 810 RVA: 0x00006A48 File Offset: 0x00004C48
		public unsafe static FQuat FindBetweenVectors(in FVector a, in FVector b)
		{
			fixed (FVector* ptr = &a)
			{
				fixed (FVector* ptr2 = &b)
				{
					return FQuat.Internal_FindBetweenVectors(a, b);
				}
			}
		}

		// Token: 0x0600032B RID: 811 RVA: 0x00006A64 File Offset: 0x00004C64
		public unsafe static FQuat operator +(in FQuat a, in FQuat b)
		{
			fixed (FQuat* ptr = &a)
			{
				fixed (FQuat* ptr2 = &b)
				{
					return FQuat.Internal_Add(a, b);
				}
			}
		}

		// Token: 0x0600032C RID: 812 RVA: 0x00006A80 File Offset: 0x00004C80
		public unsafe static FQuat operator -(in FQuat a, in FQuat b)
		{
			fixed (FQuat* ptr = &a)
			{
				fixed (FQuat* ptr2 = &b)
				{
					return FQuat.Internal_Sub(a, b);
				}
			}
		}

		// Token: 0x0600032D RID: 813 RVA: 0x00006A9C File Offset: 0x00004C9C
		public unsafe static FQuat operator *(in FQuat a, in FQuat b)
		{
			fixed (FQuat* ptr = &a)
			{
				fixed (FQuat* ptr2 = &b)
				{
					return FQuat.Internal_Mul(a, b);
				}
			}
		}

		// Token: 0x0600032E RID: 814 RVA: 0x00006AB8 File Offset: 0x00004CB8
		public unsafe static FQuat operator *(in FQuat a, float scale)
		{
			fixed (FQuat* ptr = &a)
			{
				return FQuat.Internal_MulFloat(a, scale);
			}
		}

		// Token: 0x0600032F RID: 815 RVA: 0x00006AD0 File Offset: 0x00004CD0
		public unsafe static FVector operator *(in FQuat a, in FVector v)
		{
			fixed (FQuat* ptr = &a)
			{
				fixed (FVector* ptr2 = &v)
				{
					return FQuat.Internal_MulFVector(a, v);
				}
			}
		}

		// Token: 0x06000330 RID: 816 RVA: 0x00006AEC File Offset: 0x00004CEC
		public unsafe static FVectorDouble operator *(in FQuat a, in FVectorDouble v)
		{
			fixed (FQuat* ptr = &a)
			{
				fixed (FVectorDouble* ptr2 = &v)
				{
					return FQuat.Internal_MulFVectorDouble(a, v);
				}
			}
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00006B08 File Offset: 0x00004D08
		public unsafe static FMatrix operator *(in FQuat a, in FMatrix m)
		{
			fixed (FQuat* ptr = &a)
			{
				fixed (FMatrix* ptr2 = &m)
				{
					return FQuat.Internal_MulFMatrix(a, m);
				}
			}
		}

		// Token: 0x06000332 RID: 818 RVA: 0x00006B24 File Offset: 0x00004D24
		public unsafe static FQuat operator /(in FQuat a, float scale)
		{
			fixed (FQuat* ptr = &a)
			{
				return FQuat.Internal_DivFloat(a, scale);
			}
		}

		// Token: 0x06000333 RID: 819 RVA: 0x00006B3C File Offset: 0x00004D3C
		public unsafe static float operator |(in FQuat a, in FQuat b)
		{
			fixed (FQuat* ptr = &a)
			{
				fixed (FQuat* ptr2 = &b)
				{
					return FQuat.Internal_Or(a, b);
				}
			}
		}

		// Token: 0x06000334 RID: 820 RVA: 0x00006B58 File Offset: 0x00004D58
		public unsafe readonly bool Equals(in FQuat other, float tolerance = 0.0001f)
		{
			fixed (FQuat* ptr = &this)
			{
				fixed (FQuat* ptr2 = &other)
				{
					return FQuat.Internal_Equals(this, other, tolerance);
				}
			}
		}

		// Token: 0x06000335 RID: 821 RVA: 0x00006B78 File Offset: 0x00004D78
		public unsafe readonly bool Identical(in FQuat other, uint portFlags = 0U)
		{
			fixed (FQuat* ptr = &this)
			{
				fixed (FQuat* ptr2 = &other)
				{
					return FQuat.Internal_Identical(this, other, portFlags);
				}
			}
		}

		// Token: 0x06000336 RID: 822 RVA: 0x00006B98 File Offset: 0x00004D98
		public unsafe readonly bool IsIdentity(float tolerance = 1E-08f)
		{
			fixed (FQuat* ptr = &this)
			{
				return FQuat.Internal_IsIdentity(this, tolerance);
			}
		}

		// Token: 0x06000337 RID: 823 RVA: 0x00006BB0 File Offset: 0x00004DB0
		public unsafe readonly FVector Euler()
		{
			fixed (FQuat* ptr = &this)
			{
				return FQuat.Internal_Euler(this);
			}
		}

		// Token: 0x06000338 RID: 824 RVA: 0x00006BC8 File Offset: 0x00004DC8
		public unsafe void Normalize(float tolerance = 1E-08f)
		{
			fixed (FQuat* ptr = &this)
			{
				FQuat.Internal_Normalize(ref this, tolerance);
			}
		}

		// Token: 0x06000339 RID: 825 RVA: 0x00006BE4 File Offset: 0x00004DE4
		public unsafe readonly FQuat GetNormalized(float tolerance = 1E-08f)
		{
			fixed (FQuat* ptr = &this)
			{
				return FQuat.Internal_GetNormalized(this, tolerance);
			}
		}

		// Token: 0x0600033A RID: 826 RVA: 0x00006BFC File Offset: 0x00004DFC
		public unsafe readonly bool IsNormalized()
		{
			fixed (FQuat* ptr = &this)
			{
				return FQuat.Internal_IsNormalized(this);
			}
		}

		// Token: 0x0600033B RID: 827 RVA: 0x00006C14 File Offset: 0x00004E14
		public unsafe readonly float Size()
		{
			fixed (FQuat* ptr = &this)
			{
				return FQuat.Internal_Size(this);
			}
		}

		// Token: 0x0600033C RID: 828 RVA: 0x00006C2C File Offset: 0x00004E2C
		public unsafe readonly float SizeSquared()
		{
			fixed (FQuat* ptr = &this)
			{
				return FQuat.Internal_SizeSquared(this);
			}
		}

		// Token: 0x0600033D RID: 829 RVA: 0x00006C44 File Offset: 0x00004E44
		public unsafe readonly float GetAngle()
		{
			fixed (FQuat* ptr = &this)
			{
				return FQuat.Internal_GetAngle(this);
			}
		}

		// Token: 0x0600033E RID: 830 RVA: 0x00006C5C File Offset: 0x00004E5C
		public unsafe readonly void ToAxisAndAngle(out FVector axis, out float angle)
		{
			fixed (FQuat* ptr = &this)
			{
				fixed (FVector* ptr2 = &axis)
				{
					fixed (float* ptr3 = &angle)
					{
						FQuat.Internal_ToAxisAndAngle(this, out axis, out angle);
					}
				}
			}
		}

		// Token: 0x0600033F RID: 831 RVA: 0x00006C88 File Offset: 0x00004E88
		public unsafe readonly void ToSwingTwist(in FVector inTwistAxis, out FQuat outSwing, out FQuat outTwist)
		{
			fixed (FQuat* ptr = &this)
			{
				fixed (FVector* ptr2 = &inTwistAxis)
				{
					fixed (FQuat* ptr3 = &outSwing)
					{
						fixed (FQuat* ptr4 = &outTwist)
						{
							FQuat.Internal_ToSwingTwist(this, inTwistAxis, out outSwing, out outTwist);
						}
					}
				}
			}
		}

		// Token: 0x06000340 RID: 832 RVA: 0x00006CBC File Offset: 0x00004EBC
		public unsafe readonly float GetTwistAngle(in FVector twistAxis)
		{
			fixed (FQuat* ptr = &this)
			{
				fixed (FVector* ptr2 = &twistAxis)
				{
					return FQuat.Internal_GetTwistAngle(this, twistAxis);
				}
			}
		}

		// Token: 0x06000341 RID: 833 RVA: 0x00006CD8 File Offset: 0x00004ED8
		public unsafe readonly FVector RotateVector(in FVector v)
		{
			fixed (FQuat* ptr = &this)
			{
				fixed (FVector* ptr2 = &v)
				{
					return FQuat.Internal_RotateVector(this, v);
				}
			}
		}

		// Token: 0x06000342 RID: 834 RVA: 0x00006CF4 File Offset: 0x00004EF4
		public unsafe readonly FVectorDouble RotateVectorDouble(in FVectorDouble v)
		{
			fixed (FQuat* ptr = &this)
			{
				fixed (FVectorDouble* ptr2 = &v)
				{
					return FQuat.Internal_RotateVectorDouble(this, v);
				}
			}
		}

		// Token: 0x06000343 RID: 835 RVA: 0x00006D10 File Offset: 0x00004F10
		public unsafe readonly FVector UnrotateVector(in FVector v)
		{
			fixed (FQuat* ptr = &this)
			{
				fixed (FVector* ptr2 = &v)
				{
					return FQuat.Internal_UnrotateVector(this, v);
				}
			}
		}

		// Token: 0x06000344 RID: 836 RVA: 0x00006D2C File Offset: 0x00004F2C
		public unsafe readonly FVectorDouble UnrotateVectorDouble(in FVectorDouble v)
		{
			fixed (FQuat* ptr = &this)
			{
				fixed (FVectorDouble* ptr2 = &v)
				{
					return FQuat.Internal_UnrotateVectorDouble(this, v);
				}
			}
		}

		// Token: 0x06000345 RID: 837 RVA: 0x00006D48 File Offset: 0x00004F48
		public unsafe readonly FQuat Log()
		{
			fixed (FQuat* ptr = &this)
			{
				return FQuat.Internal_Log(this);
			}
		}

		// Token: 0x06000346 RID: 838 RVA: 0x00006D60 File Offset: 0x00004F60
		public unsafe readonly FQuat Exp()
		{
			fixed (FQuat* ptr = &this)
			{
				return FQuat.Internal_Exp(this);
			}
		}

		// Token: 0x06000347 RID: 839 RVA: 0x00006D78 File Offset: 0x00004F78
		public unsafe void EnforceShortestArcWith(in FQuat b)
		{
			fixed (FQuat* ptr = &this)
			{
				fixed (FQuat* ptr2 = &b)
				{
					FQuat.Internal_EnforceShortestArcWith(ref this, b);
				}
			}
		}

		// Token: 0x06000348 RID: 840 RVA: 0x00006D9C File Offset: 0x00004F9C
		public unsafe readonly FVector GetAxisX()
		{
			fixed (FQuat* ptr = &this)
			{
				return FQuat.Internal_GetAxisX(this);
			}
		}

		// Token: 0x06000349 RID: 841 RVA: 0x00006DB4 File Offset: 0x00004FB4
		public unsafe readonly FVector GetAxisY()
		{
			fixed (FQuat* ptr = &this)
			{
				return FQuat.Internal_GetAxisY(this);
			}
		}

		// Token: 0x0600034A RID: 842 RVA: 0x00006DCC File Offset: 0x00004FCC
		public unsafe readonly FVector GetAxisZ()
		{
			fixed (FQuat* ptr = &this)
			{
				return FQuat.Internal_GetAxisZ(this);
			}
		}

		// Token: 0x0600034B RID: 843 RVA: 0x00006DE4 File Offset: 0x00004FE4
		public unsafe readonly FVector GetForwardVector()
		{
			fixed (FQuat* ptr = &this)
			{
				return FQuat.Internal_GetForwardVector(this);
			}
		}

		// Token: 0x0600034C RID: 844 RVA: 0x00006DFC File Offset: 0x00004FFC
		public unsafe readonly FVector GetRightVector()
		{
			fixed (FQuat* ptr = &this)
			{
				return FQuat.Internal_GetRightVector(this);
			}
		}

		// Token: 0x0600034D RID: 845 RVA: 0x00006E14 File Offset: 0x00005014
		public unsafe readonly FVector GetUpVector()
		{
			fixed (FQuat* ptr = &this)
			{
				return FQuat.Internal_GetUpVector(this);
			}
		}

		// Token: 0x0600034E RID: 846 RVA: 0x00006E2C File Offset: 0x0000502C
		public unsafe readonly FVector Vector()
		{
			fixed (FQuat* ptr = &this)
			{
				return FQuat.Internal_Vector(this);
			}
		}

		// Token: 0x0600034F RID: 847 RVA: 0x00006E44 File Offset: 0x00005044
		public unsafe readonly FRotator Rotator()
		{
			fixed (FQuat* ptr = &this)
			{
				return FQuat.Internal_Rotator(this);
			}
		}

		// Token: 0x06000350 RID: 848 RVA: 0x00006E5C File Offset: 0x0000505C
		public unsafe readonly FVector GetRotationAxis()
		{
			fixed (FQuat* ptr = &this)
			{
				return FQuat.Internal_GetRotationAxis(this);
			}
		}

		// Token: 0x06000351 RID: 849 RVA: 0x00006E74 File Offset: 0x00005074
		public unsafe readonly float AngularDistance(in FQuat other)
		{
			fixed (FQuat* ptr = &this)
			{
				fixed (FQuat* ptr2 = &other)
				{
					return FQuat.Internal_AngularDistance(this, other);
				}
			}
		}

		// Token: 0x06000352 RID: 850 RVA: 0x00006E90 File Offset: 0x00005090
		public unsafe readonly bool ContainsNaN()
		{
			fixed (FQuat* ptr = &this)
			{
				return FQuat.Internal_ContainsNaN(this);
			}
		}

		// Token: 0x06000353 RID: 851 RVA: 0x00006EA8 File Offset: 0x000050A8
		public unsafe static float Error(in FQuat a, in FQuat b)
		{
			fixed (FQuat* ptr = &a)
			{
				fixed (FQuat* ptr2 = &b)
				{
					return FQuat.Internal_Error(a, b);
				}
			}
		}

		// Token: 0x06000354 RID: 852 RVA: 0x00006EC4 File Offset: 0x000050C4
		public unsafe static float ErrorAutoNormalize(in FQuat a, in FQuat b)
		{
			fixed (FQuat* ptr = &a)
			{
				fixed (FQuat* ptr2 = &b)
				{
					return FQuat.Internal_ErrorAutoNormalize(a, b);
				}
			}
		}

		// Token: 0x06000355 RID: 853 RVA: 0x00006EE0 File Offset: 0x000050E0
		public unsafe static FQuat FastLerp(in FQuat a, in FQuat b, float alpha)
		{
			fixed (FQuat* ptr = &a)
			{
				fixed (FQuat* ptr2 = &b)
				{
					return FQuat.Internal_FastLerp(a, b, alpha);
				}
			}
		}

		// Token: 0x06000356 RID: 854 RVA: 0x00006F00 File Offset: 0x00005100
		public unsafe static FQuat FastBilerp(in FQuat p00, in FQuat p10, in FQuat p01, in FQuat p11, float fracX, float fracY)
		{
			fixed (FQuat* ptr = &p00)
			{
				fixed (FQuat* ptr2 = &p10)
				{
					fixed (FQuat* ptr3 = &p01)
					{
						fixed (FQuat* ptr4 = &p11)
						{
							return FQuat.Internal_FastBilerp(p00, p10, p01, p11, fracX, fracY);
						}
					}
				}
			}
		}

		// Token: 0x06000357 RID: 855 RVA: 0x00006F2C File Offset: 0x0000512C
		public unsafe static FQuat Slerp(in FQuat a, in FQuat b, float slerp)
		{
			fixed (FQuat* ptr = &a)
			{
				fixed (FQuat* ptr2 = &b)
				{
					return FQuat.Internal_Slerp(a, b, slerp);
				}
			}
		}

		// Token: 0x06000358 RID: 856 RVA: 0x00006F4C File Offset: 0x0000514C
		public unsafe static FQuat Slerp_NotNormalized(in FQuat a, in FQuat b, float slerp)
		{
			fixed (FQuat* ptr = &a)
			{
				fixed (FQuat* ptr2 = &b)
				{
					return FQuat.Internal_Slerp_NotNormalized(a, b, slerp);
				}
			}
		}

		// Token: 0x06000359 RID: 857 RVA: 0x00006F6C File Offset: 0x0000516C
		public unsafe static FQuat SlerpFullPath_NotNormalized(in FQuat a, in FQuat b, float alpha)
		{
			fixed (FQuat* ptr = &a)
			{
				fixed (FQuat* ptr2 = &b)
				{
					return FQuat.Internal_SlerpFullPath_NotNormalized(a, b, alpha);
				}
			}
		}

		// Token: 0x0600035A RID: 858 RVA: 0x00006F8C File Offset: 0x0000518C
		public unsafe static FQuat SlerpFullPath(in FQuat a, in FQuat b, float alpha)
		{
			fixed (FQuat* ptr = &a)
			{
				fixed (FQuat* ptr2 = &b)
				{
					return FQuat.Internal_SlerpFullPath(a, b, alpha);
				}
			}
		}

		// Token: 0x0600035B RID: 859 RVA: 0x00006FAC File Offset: 0x000051AC
		public unsafe static FQuat Squad(in FQuat quat1, in FQuat tang1, in FQuat quat2, in FQuat tang2, float alpha)
		{
			fixed (FQuat* ptr = &quat1)
			{
				fixed (FQuat* ptr2 = &tang1)
				{
					fixed (FQuat* ptr3 = &quat2)
					{
						fixed (FQuat* ptr4 = &tang2)
						{
							return FQuat.Internal_Squad(quat1, tang1, quat2, tang2, alpha);
						}
					}
				}
			}
		}

		// Token: 0x0600035C RID: 860 RVA: 0x00006FD4 File Offset: 0x000051D4
		public unsafe static FQuat SquadFullPath(in FQuat quat1, in FQuat tang1, in FQuat quat2, in FQuat tang2, float alpha)
		{
			fixed (FQuat* ptr = &quat1)
			{
				fixed (FQuat* ptr2 = &tang1)
				{
					fixed (FQuat* ptr3 = &quat2)
					{
						fixed (FQuat* ptr4 = &tang2)
						{
							return FQuat.Internal_SquadFullPath(quat1, tang1, quat2, tang2, alpha);
						}
					}
				}
			}
		}

		// Token: 0x0600035D RID: 861 RVA: 0x00006FFC File Offset: 0x000051FC
		public unsafe static void CalcTangents(in FQuat prevP, in FQuat p, in FQuat nextP, float tension, out FQuat outTan)
		{
			fixed (FQuat* ptr = &prevP)
			{
				fixed (FQuat* ptr2 = &p)
				{
					fixed (FQuat* ptr3 = &nextP)
					{
						fixed (FQuat* ptr4 = &outTan)
						{
							FQuat.Internal_CalcTangents(prevP, p, nextP, tension, out outTan);
						}
					}
				}
			}
		}

		// Token: 0x0600035E RID: 862 RVA: 0x00007034 File Offset: 0x00005234
		[NullableContext(2)]
		public unsafe bool InitFromString(string str)
		{
			if (str == null || str.Length == 0)
			{
				this.X = (this.Y = (this.Z = 0f));
				this.W = 1f;
				return false;
			}
			fixed (FQuat* ptr = &this)
			{
				char* ptr2;
				if (str == null)
				{
					ptr2 = null;
				}
				else
				{
					fixed (char* pinnableReference = str.GetPinnableReference())
					{
						ptr2 = pinnableReference;
					}
				}
				char* ptr3 = ptr2;
				FCSharpStringView fcsharpStringView = new FCSharpStringView(ptr3, str.Length);
				return FQuat.Internal_InitFromString(ref this, fcsharpStringView);
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600035F RID: 863 RVA: 0x000070A1 File Offset: 0x000052A1
		// (set) Token: 0x06000360 RID: 864 RVA: 0x000070AA File Offset: 0x000052AA
		double IQuat.X
		{
			get
			{
				return (double)this.X;
			}
			set
			{
				this.X = (float)value;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000361 RID: 865 RVA: 0x000070B4 File Offset: 0x000052B4
		// (set) Token: 0x06000362 RID: 866 RVA: 0x000070BD File Offset: 0x000052BD
		double IQuat.Y
		{
			get
			{
				return (double)this.Y;
			}
			set
			{
				this.Y = (float)value;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000363 RID: 867 RVA: 0x000070C7 File Offset: 0x000052C7
		// (set) Token: 0x06000364 RID: 868 RVA: 0x000070D0 File Offset: 0x000052D0
		double IQuat.Z
		{
			get
			{
				return (double)this.Z;
			}
			set
			{
				this.Z = (float)value;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000365 RID: 869 RVA: 0x000070DA File Offset: 0x000052DA
		// (set) Token: 0x06000366 RID: 870 RVA: 0x000070E3 File Offset: 0x000052E3
		double IQuat.W
		{
			get
			{
				return (double)this.W;
			}
			set
			{
				this.W = (float)value;
			}
		}

		// Token: 0x06000367 RID: 871 RVA: 0x000070ED File Offset: 0x000052ED
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FQuat._ScriptStructPtr != 0) ? FQuat._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.Quat", ref FQuat._ScriptStructPtr);
		}

		// Token: 0x04000098 RID: 152
		public static readonly FQuat Identity = new FQuat(0f, 0f, 0f, 1f);

		// Token: 0x04000099 RID: 153
		[FieldOffset(0)]
		public float X;

		// Token: 0x0400009A RID: 154
		[FieldOffset(4)]
		public float Y;

		// Token: 0x0400009B RID: 155
		[FieldOffset(8)]
		public float Z;

		// Token: 0x0400009C RID: 156
		[FieldOffset(12)]
		public float W;

		// Token: 0x0400009D RID: 157
		public const string __ObjectPath = "/Script/CoreUObject.Quat";

		// Token: 0x0400009E RID: 158
		private static IntPtr _ScriptStructPtr;
	}
}
