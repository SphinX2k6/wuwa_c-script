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
	// Token: 0x02000038 RID: 56
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(16, 16, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 16)]
	[UnrealObjectPath("/Script/CoreUObject.Quat")]
	[StructLayout(LayoutKind.Explicit, Pack = 16, Size = 16)]
	public struct FQuat : IEquatable<FQuat>, IEqualityOperators<FQuat, FQuat, bool>, IQuat, IUnrealScriptStruct
	{
		// Token: 0x06000359 RID: 857 RVA: 0x00009F2E File Offset: 0x0000812E
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

		// Token: 0x0600035A RID: 858 RVA: 0x00009F64 File Offset: 0x00008164
		public FQuat()
		{
			this.X = 0f;
			this.Y = 0f;
			this.Z = 0f;
			this.W = 0f;
		}

		// Token: 0x0600035B RID: 859 RVA: 0x00009F92 File Offset: 0x00008192
		public static bool operator ==(FQuat a, FQuat b)
		{
			return a.X == b.X && a.Y == b.Y && a.Z == b.Z && a.W == b.W;
		}

		// Token: 0x0600035C RID: 860 RVA: 0x00009FCE File Offset: 0x000081CE
		public static bool operator !=(FQuat a, FQuat b)
		{
			return a.X != b.X || a.Y != b.Y || a.Z != b.Z || a.W != b.W;
		}

		// Token: 0x0600035D RID: 861 RVA: 0x0000A00D File Offset: 0x0000820D
		public readonly bool Equals(FQuat other)
		{
			return this == other;
		}

		// Token: 0x0600035E RID: 862 RVA: 0x0000A01C File Offset: 0x0000821C
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

		// Token: 0x0600035F RID: 863 RVA: 0x0000A046 File Offset: 0x00008246
		public override readonly int GetHashCode()
		{
			return HashCode.Combine<float, float, float, float>(this.X, this.Y, this.Z, this.W);
		}

		// Token: 0x06000360 RID: 864 RVA: 0x0000A068 File Offset: 0x00008268
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

		// Token: 0x06000361 RID: 865 RVA: 0x0000A0EA File Offset: 0x000082EA
		public readonly FQuat Inverse()
		{
			return new FQuat(-this.X, -this.Y, -this.Z, this.W);
		}

		// Token: 0x06000362 RID: 866
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat Internal_Ctor_XYZW(float x, float y, float z, float w);

		// Token: 0x06000363 RID: 867
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat Internal_Ctor_FRotator(in FRotator rotator);

		// Token: 0x06000364 RID: 868
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat Internal_Ctor_FMatrix(in FMatrix matrix);

		// Token: 0x06000365 RID: 869
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat Internal_Ctor_FVector_float(in FVector axis, float angleRad);

		// Token: 0x06000366 RID: 870
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat Internal_MakeFromEuler(in FVector euler);

		// Token: 0x06000367 RID: 871
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat Internal_FindBetween(in FVector a, in FVector b);

		// Token: 0x06000368 RID: 872
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat Internal_FindBetweenNormals(in FVector a, in FVector b);

		// Token: 0x06000369 RID: 873
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat Internal_FindBetweenVectors(in FVector a, in FVector b);

		// Token: 0x0600036A RID: 874
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat Internal_Add(in FQuat a, in FQuat b);

		// Token: 0x0600036B RID: 875
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat Internal_Sub(in FQuat a, in FQuat b);

		// Token: 0x0600036C RID: 876
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat Internal_Mul(in FQuat a, in FQuat b);

		// Token: 0x0600036D RID: 877
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat Internal_MulFloat(in FQuat a, float scale);

		// Token: 0x0600036E RID: 878
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_MulFVector(in FQuat a, in FVector v);

		// Token: 0x0600036F RID: 879
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_MulFVectorDouble(in FQuat a, in FVectorDouble v);

		// Token: 0x06000370 RID: 880
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix Internal_MulFMatrix(in FQuat a, in FMatrix m);

		// Token: 0x06000371 RID: 881
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat Internal_DivFloat(in FQuat a, float scale);

		// Token: 0x06000372 RID: 882
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_Or(in FQuat a, in FQuat b);

		// Token: 0x06000373 RID: 883
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_Equals(in FQuat a, in FQuat b, float tolerance);

		// Token: 0x06000374 RID: 884
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_Identical(in FQuat a, in FQuat b, uint portFlags);

		// Token: 0x06000375 RID: 885
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IsIdentity(in FQuat a, float tolerance);

		// Token: 0x06000376 RID: 886
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_Euler(in FQuat a);

		// Token: 0x06000377 RID: 887
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Normalize(ref FQuat a, float tolerance);

		// Token: 0x06000378 RID: 888
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat Internal_GetNormalized(in FQuat a, float tolerance);

		// Token: 0x06000379 RID: 889
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IsNormalized(in FQuat a);

		// Token: 0x0600037A RID: 890
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_Size(in FQuat a);

		// Token: 0x0600037B RID: 891
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_SizeSquared(in FQuat a);

		// Token: 0x0600037C RID: 892
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_GetAngle(in FQuat a);

		// Token: 0x0600037D RID: 893
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_ToAxisAndAngle(in FQuat a, out FVector axis, out float angle);

		// Token: 0x0600037E RID: 894
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_ToSwingTwist(in FQuat a, in FVector inTwistAxis, out FQuat outSwing, out FQuat outTwist);

		// Token: 0x0600037F RID: 895
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_GetTwistAngle(in FQuat a, in FVector twistAxis);

		// Token: 0x06000380 RID: 896
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_RotateVector(in FQuat a, in FVector v);

		// Token: 0x06000381 RID: 897
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_RotateVectorDouble(in FQuat a, in FVectorDouble v);

		// Token: 0x06000382 RID: 898
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_UnrotateVector(in FQuat a, in FVector v);

		// Token: 0x06000383 RID: 899
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_UnrotateVectorDouble(in FQuat a, in FVectorDouble v);

		// Token: 0x06000384 RID: 900
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat Internal_Log(in FQuat a);

		// Token: 0x06000385 RID: 901
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat Internal_Exp(in FQuat a);

		// Token: 0x06000386 RID: 902
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_EnforceShortestArcWith(ref FQuat a, in FQuat b);

		// Token: 0x06000387 RID: 903
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_GetAxisX(in FQuat a);

		// Token: 0x06000388 RID: 904
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_GetAxisY(in FQuat a);

		// Token: 0x06000389 RID: 905
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_GetAxisZ(in FQuat a);

		// Token: 0x0600038A RID: 906
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_GetForwardVector(in FQuat a);

		// Token: 0x0600038B RID: 907
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_GetRightVector(in FQuat a);

		// Token: 0x0600038C RID: 908
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_GetUpVector(in FQuat a);

		// Token: 0x0600038D RID: 909
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_Vector(in FQuat a);

		// Token: 0x0600038E RID: 910
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator Internal_Rotator(in FQuat a);

		// Token: 0x0600038F RID: 911
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_GetRotationAxis(in FQuat a);

		// Token: 0x06000390 RID: 912
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_AngularDistance(in FQuat a, in FQuat b);

		// Token: 0x06000391 RID: 913
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_ContainsNaN(in FQuat a);

		// Token: 0x06000392 RID: 914
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_Error(in FQuat a, in FQuat b);

		// Token: 0x06000393 RID: 915
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_ErrorAutoNormalize(in FQuat a, in FQuat b);

		// Token: 0x06000394 RID: 916
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat Internal_FastLerp(in FQuat a, in FQuat b, float alpha);

		// Token: 0x06000395 RID: 917
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat Internal_FastBilerp(in FQuat p00, in FQuat p10, in FQuat p01, in FQuat p11, float fracX, float fracY);

		// Token: 0x06000396 RID: 918
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat Internal_Slerp(in FQuat a, in FQuat b, float slerp);

		// Token: 0x06000397 RID: 919
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat Internal_Slerp_NotNormalized(in FQuat a, in FQuat b, float slerp);

		// Token: 0x06000398 RID: 920
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat Internal_SlerpFullPath_NotNormalized(in FQuat a, in FQuat b, float alpha);

		// Token: 0x06000399 RID: 921
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat Internal_SlerpFullPath(in FQuat a, in FQuat b, float alpha);

		// Token: 0x0600039A RID: 922
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat Internal_Squad(in FQuat quat1, in FQuat tang1, in FQuat quat2, in FQuat tang2, float alpha);

		// Token: 0x0600039B RID: 923
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat Internal_SquadFullPath(in FQuat quat1, in FQuat tang1, in FQuat quat2, in FQuat tang2, float alpha);

		// Token: 0x0600039C RID: 924
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_CalcTangents(in FQuat prevP, in FQuat p, in FQuat nextP, float tension, out FQuat outTan);

		// Token: 0x0600039D RID: 925
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_InitFromString(ref FQuat a, in FCSharpStringView str);

		// Token: 0x0600039E RID: 926 RVA: 0x0000A10C File Offset: 0x0000830C
		public FQuat(float x, float y, float z, float w)
		{
			this.X = x;
			this.Y = y;
			this.Z = z;
			this.W = w;
		}

		// Token: 0x0600039F RID: 927 RVA: 0x0000A12B File Offset: 0x0000832B
		public FQuat(in FRotator rotator)
		{
			this = rotator.Quaternion();
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x0000A13C File Offset: 0x0000833C
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

		// Token: 0x060003A1 RID: 929 RVA: 0x0000A164 File Offset: 0x00008364
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

		// Token: 0x060003A2 RID: 930 RVA: 0x0000A18C File Offset: 0x0000838C
		public unsafe static FQuat MakeFromEuler(in FVector euler)
		{
			fixed (FVector* ptr = &euler)
			{
				return FQuat.Internal_MakeFromEuler(euler);
			}
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x0000A1A4 File Offset: 0x000083A4
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

		// Token: 0x060003A4 RID: 932 RVA: 0x0000A1C0 File Offset: 0x000083C0
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

		// Token: 0x060003A5 RID: 933 RVA: 0x0000A1DC File Offset: 0x000083DC
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

		// Token: 0x060003A6 RID: 934 RVA: 0x0000A1F8 File Offset: 0x000083F8
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

		// Token: 0x060003A7 RID: 935 RVA: 0x0000A214 File Offset: 0x00008414
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

		// Token: 0x060003A8 RID: 936 RVA: 0x0000A230 File Offset: 0x00008430
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

		// Token: 0x060003A9 RID: 937 RVA: 0x0000A24C File Offset: 0x0000844C
		public unsafe static FQuat operator *(in FQuat a, float scale)
		{
			fixed (FQuat* ptr = &a)
			{
				return FQuat.Internal_MulFloat(a, scale);
			}
		}

		// Token: 0x060003AA RID: 938 RVA: 0x0000A264 File Offset: 0x00008464
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

		// Token: 0x060003AB RID: 939 RVA: 0x0000A280 File Offset: 0x00008480
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

		// Token: 0x060003AC RID: 940 RVA: 0x0000A29C File Offset: 0x0000849C
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

		// Token: 0x060003AD RID: 941 RVA: 0x0000A2B8 File Offset: 0x000084B8
		public unsafe static FQuat operator /(in FQuat a, float scale)
		{
			fixed (FQuat* ptr = &a)
			{
				return FQuat.Internal_DivFloat(a, scale);
			}
		}

		// Token: 0x060003AE RID: 942 RVA: 0x0000A2D0 File Offset: 0x000084D0
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

		// Token: 0x060003AF RID: 943 RVA: 0x0000A2EC File Offset: 0x000084EC
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

		// Token: 0x060003B0 RID: 944 RVA: 0x0000A30C File Offset: 0x0000850C
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

		// Token: 0x060003B1 RID: 945 RVA: 0x0000A32C File Offset: 0x0000852C
		public unsafe readonly bool IsIdentity(float tolerance = 1E-08f)
		{
			fixed (FQuat* ptr = &this)
			{
				return FQuat.Internal_IsIdentity(this, tolerance);
			}
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x0000A344 File Offset: 0x00008544
		public unsafe readonly FVector Euler()
		{
			fixed (FQuat* ptr = &this)
			{
				return FQuat.Internal_Euler(this);
			}
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x0000A35C File Offset: 0x0000855C
		public unsafe void Normalize(float tolerance = 1E-08f)
		{
			fixed (FQuat* ptr = &this)
			{
				FQuat.Internal_Normalize(ref this, tolerance);
			}
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x0000A378 File Offset: 0x00008578
		public unsafe readonly FQuat GetNormalized(float tolerance = 1E-08f)
		{
			fixed (FQuat* ptr = &this)
			{
				return FQuat.Internal_GetNormalized(this, tolerance);
			}
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x0000A390 File Offset: 0x00008590
		public unsafe readonly bool IsNormalized()
		{
			fixed (FQuat* ptr = &this)
			{
				return FQuat.Internal_IsNormalized(this);
			}
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x0000A3A8 File Offset: 0x000085A8
		public unsafe readonly float Size()
		{
			fixed (FQuat* ptr = &this)
			{
				return FQuat.Internal_Size(this);
			}
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x0000A3C0 File Offset: 0x000085C0
		public unsafe readonly float SizeSquared()
		{
			fixed (FQuat* ptr = &this)
			{
				return FQuat.Internal_SizeSquared(this);
			}
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x0000A3D8 File Offset: 0x000085D8
		public unsafe readonly float GetAngle()
		{
			fixed (FQuat* ptr = &this)
			{
				return FQuat.Internal_GetAngle(this);
			}
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x0000A3F0 File Offset: 0x000085F0
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

		// Token: 0x060003BA RID: 954 RVA: 0x0000A41C File Offset: 0x0000861C
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

		// Token: 0x060003BB RID: 955 RVA: 0x0000A450 File Offset: 0x00008650
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

		// Token: 0x060003BC RID: 956 RVA: 0x0000A46C File Offset: 0x0000866C
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

		// Token: 0x060003BD RID: 957 RVA: 0x0000A488 File Offset: 0x00008688
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

		// Token: 0x060003BE RID: 958 RVA: 0x0000A4A4 File Offset: 0x000086A4
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

		// Token: 0x060003BF RID: 959 RVA: 0x0000A4C0 File Offset: 0x000086C0
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

		// Token: 0x060003C0 RID: 960 RVA: 0x0000A4DC File Offset: 0x000086DC
		public unsafe readonly FQuat Log()
		{
			fixed (FQuat* ptr = &this)
			{
				return FQuat.Internal_Log(this);
			}
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x0000A4F4 File Offset: 0x000086F4
		public unsafe readonly FQuat Exp()
		{
			fixed (FQuat* ptr = &this)
			{
				return FQuat.Internal_Exp(this);
			}
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x0000A50C File Offset: 0x0000870C
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

		// Token: 0x060003C3 RID: 963 RVA: 0x0000A530 File Offset: 0x00008730
		public unsafe readonly FVector GetAxisX()
		{
			fixed (FQuat* ptr = &this)
			{
				return FQuat.Internal_GetAxisX(this);
			}
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x0000A548 File Offset: 0x00008748
		public unsafe readonly FVector GetAxisY()
		{
			fixed (FQuat* ptr = &this)
			{
				return FQuat.Internal_GetAxisY(this);
			}
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x0000A560 File Offset: 0x00008760
		public unsafe readonly FVector GetAxisZ()
		{
			fixed (FQuat* ptr = &this)
			{
				return FQuat.Internal_GetAxisZ(this);
			}
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x0000A578 File Offset: 0x00008778
		public unsafe readonly FVector GetForwardVector()
		{
			fixed (FQuat* ptr = &this)
			{
				return FQuat.Internal_GetForwardVector(this);
			}
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x0000A590 File Offset: 0x00008790
		public unsafe readonly FVector GetRightVector()
		{
			fixed (FQuat* ptr = &this)
			{
				return FQuat.Internal_GetRightVector(this);
			}
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x0000A5A8 File Offset: 0x000087A8
		public unsafe readonly FVector GetUpVector()
		{
			fixed (FQuat* ptr = &this)
			{
				return FQuat.Internal_GetUpVector(this);
			}
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x0000A5C0 File Offset: 0x000087C0
		public unsafe readonly FVector Vector()
		{
			fixed (FQuat* ptr = &this)
			{
				return FQuat.Internal_Vector(this);
			}
		}

		// Token: 0x060003CA RID: 970 RVA: 0x0000A5D8 File Offset: 0x000087D8
		public unsafe readonly FRotator Rotator()
		{
			fixed (FQuat* ptr = &this)
			{
				return FQuat.Internal_Rotator(this);
			}
		}

		// Token: 0x060003CB RID: 971 RVA: 0x0000A5F0 File Offset: 0x000087F0
		public unsafe readonly FVector GetRotationAxis()
		{
			fixed (FQuat* ptr = &this)
			{
				return FQuat.Internal_GetRotationAxis(this);
			}
		}

		// Token: 0x060003CC RID: 972 RVA: 0x0000A608 File Offset: 0x00008808
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

		// Token: 0x060003CD RID: 973 RVA: 0x0000A624 File Offset: 0x00008824
		public unsafe readonly bool ContainsNaN()
		{
			fixed (FQuat* ptr = &this)
			{
				return FQuat.Internal_ContainsNaN(this);
			}
		}

		// Token: 0x060003CE RID: 974 RVA: 0x0000A63C File Offset: 0x0000883C
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

		// Token: 0x060003CF RID: 975 RVA: 0x0000A658 File Offset: 0x00008858
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

		// Token: 0x060003D0 RID: 976 RVA: 0x0000A674 File Offset: 0x00008874
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

		// Token: 0x060003D1 RID: 977 RVA: 0x0000A694 File Offset: 0x00008894
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

		// Token: 0x060003D2 RID: 978 RVA: 0x0000A6C0 File Offset: 0x000088C0
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

		// Token: 0x060003D3 RID: 979 RVA: 0x0000A6E0 File Offset: 0x000088E0
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

		// Token: 0x060003D4 RID: 980 RVA: 0x0000A700 File Offset: 0x00008900
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

		// Token: 0x060003D5 RID: 981 RVA: 0x0000A720 File Offset: 0x00008920
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

		// Token: 0x060003D6 RID: 982 RVA: 0x0000A740 File Offset: 0x00008940
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

		// Token: 0x060003D7 RID: 983 RVA: 0x0000A768 File Offset: 0x00008968
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

		// Token: 0x060003D8 RID: 984 RVA: 0x0000A790 File Offset: 0x00008990
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

		// Token: 0x060003D9 RID: 985 RVA: 0x0000A7C8 File Offset: 0x000089C8
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

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x060003DA RID: 986 RVA: 0x0000A835 File Offset: 0x00008A35
		// (set) Token: 0x060003DB RID: 987 RVA: 0x0000A83E File Offset: 0x00008A3E
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

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x060003DC RID: 988 RVA: 0x0000A848 File Offset: 0x00008A48
		// (set) Token: 0x060003DD RID: 989 RVA: 0x0000A851 File Offset: 0x00008A51
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

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x060003DE RID: 990 RVA: 0x0000A85B File Offset: 0x00008A5B
		// (set) Token: 0x060003DF RID: 991 RVA: 0x0000A864 File Offset: 0x00008A64
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

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x060003E0 RID: 992 RVA: 0x0000A86E File Offset: 0x00008A6E
		// (set) Token: 0x060003E1 RID: 993 RVA: 0x0000A877 File Offset: 0x00008A77
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

		// Token: 0x060003E2 RID: 994 RVA: 0x0000A881 File Offset: 0x00008A81
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FQuat._ScriptStructPtr != 0) ? FQuat._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.Quat", ref FQuat._ScriptStructPtr);
		}

		// Token: 0x040000DF RID: 223
		public static readonly FQuat Identity = new FQuat(0f, 0f, 0f, 1f);

		// Token: 0x040000E0 RID: 224
		[FieldOffset(0)]
		public float X;

		// Token: 0x040000E1 RID: 225
		[FieldOffset(4)]
		public float Y;

		// Token: 0x040000E2 RID: 226
		[FieldOffset(8)]
		public float Z;

		// Token: 0x040000E3 RID: 227
		[FieldOffset(12)]
		public float W;

		// Token: 0x040000E4 RID: 228
		public const string __ObjectPath = "/Script/CoreUObject.Quat";

		// Token: 0x040000E5 RID: 229
		private static IntPtr _ScriptStructPtr;
	}
}
