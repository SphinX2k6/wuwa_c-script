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
	// Token: 0x02000009 RID: 9
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(28, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 28)]
	[UnrealObjectPath("/Script/CoreUObject.BoxSphereBounds")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 28)]
	public struct FBoxSphereBounds : IEquatable<FBoxSphereBounds>, IEqualityOperators<FBoxSphereBounds, FBoxSphereBounds, bool>, IUnrealScriptStruct
	{
		// Token: 0x06000090 RID: 144 RVA: 0x00002F92 File Offset: 0x00001192
		public FBoxSphereBounds()
		{
			this.Origin = default(FVector);
			this.BoxExtent = default(FVector);
			this.SphereRadius = 0f;
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00002FB7 File Offset: 0x000011B7
		[NullableContext(1)]
		public FBoxSphereBounds(FVector[] points)
		{
			this = new FBoxSphereBounds(points.AsSpan<FVector>());
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00002FC8 File Offset: 0x000011C8
		[NullableContext(2)]
		public override readonly bool Equals(object obj)
		{
			if (obj is FBoxSphereBounds)
			{
				FBoxSphereBounds right = (FBoxSphereBounds)obj;
				return this == right;
			}
			return false;
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00002FF2 File Offset: 0x000011F2
		public readonly bool Equals(FBoxSphereBounds other)
		{
			return this == other;
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00003000 File Offset: 0x00001200
		public override readonly int GetHashCode()
		{
			return HashCode.Combine<FVector, FVector, float>(this.Origin, this.BoxExtent, this.SphereRadius);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x0000301C File Offset: 0x0000121C
		[NullableContext(1)]
		public override readonly string ToString()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(36, 3);
			defaultInterpolatedStringHandler.AppendLiteral("Origin=");
			defaultInterpolatedStringHandler.AppendFormatted<FVector>(this.Origin);
			defaultInterpolatedStringHandler.AppendLiteral(", BoxExtent=(");
			defaultInterpolatedStringHandler.AppendFormatted<FVector>(this.BoxExtent);
			defaultInterpolatedStringHandler.AppendLiteral("), SphereRadius=");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.SphereRadius);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00003088 File Offset: 0x00001288
		[Conditional("ENABLE_NAN_DIAGNOSTIC")]
		public void DiagnosticCheckNaN()
		{
			if (!SharpherealAssert.Ensure(!this.Origin.ContainsNaN(), "Origin contains NaN: {0}", new object[]
			{
				this.Origin
			}))
			{
				this.Origin = FVector.ZeroVector;
			}
			if (!SharpherealAssert.Ensure(!this.BoxExtent.ContainsNaN(), "BoxExtent contains NaN: {0}", new object[]
			{
				this.BoxExtent
			}))
			{
				this.BoxExtent = FVector.ZeroVector;
			}
			if (!SharpherealAssert.Ensure(!float.IsNaN(this.SphereRadius) && float.IsFinite(this.SphereRadius), "SphereRadius contains NaN: {0}", new object[]
			{
				this.SphereRadius
			}))
			{
				this.SphereRadius = 0f;
			}
		}

		// Token: 0x06000097 RID: 151
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBoxSphereBounds Internal_Ctor_FBox(in FBox box);

		// Token: 0x06000098 RID: 152
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBoxSphereBounds Internal_Ctor_FSphere(in FSphere s);

		// Token: 0x06000099 RID: 153
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBoxSphereBounds Internal_Ctor_FBox_FSphere(in FBox box, in FSphere s);

		// Token: 0x0600009A RID: 154
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBoxSphereBounds Internal_Ctor_FVector_FVector_float(in FVector origin, in FVector extent, float radius);

		// Token: 0x0600009B RID: 155
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FBoxSphereBounds Internal_Ctor_FVectorArr(FVector* data, int num);

		// Token: 0x0600009C RID: 156
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_Eq(in FBoxSphereBounds a, in FBoxSphereBounds b);

		// Token: 0x0600009D RID: 157
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_NotEq(in FBoxSphereBounds a, in FBoxSphereBounds b);

		// Token: 0x0600009E RID: 158
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_ContainsNaN(in FBoxSphereBounds a);

		// Token: 0x0600009F RID: 159
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBoxSphereBounds Internal_Add_FBoxSphereBounds(in FBoxSphereBounds a, in FBoxSphereBounds b);

		// Token: 0x060000A0 RID: 160
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBoxSphereBounds Internal_Mul_float(in FBoxSphereBounds a, float f);

		// Token: 0x060000A1 RID: 161
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_ComputeSquaredDistanceFromBoxToPoint(in FBoxSphereBounds a, in FVector v);

		// Token: 0x060000A2 RID: 162
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_SpheresIntersect(in FBoxSphereBounds a, in FBoxSphereBounds b, float tolerance);

		// Token: 0x060000A3 RID: 163
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_BoxesIntersect(in FBoxSphereBounds a, in FBoxSphereBounds b);

		// Token: 0x060000A4 RID: 164
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBox Internal_GetBox(in FBoxSphereBounds a);

		// Token: 0x060000A5 RID: 165
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_GetBoxExtrema(in FBoxSphereBounds a, uint u);

		// Token: 0x060000A6 RID: 166
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FSphere Internal_GetSphere(in FBoxSphereBounds a);

		// Token: 0x060000A7 RID: 167
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBoxSphereBounds Internal_ExpandBy(in FBoxSphereBounds a, float fAbs);

		// Token: 0x060000A8 RID: 168
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBoxSphereBounds Internal_TransformBy_FMatrix(in FBoxSphereBounds a, in FMatrix m);

		// Token: 0x060000A9 RID: 169
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBoxSphereBounds Internal_TransformBy_FTransform(in FBoxSphereBounds a, in FTransform tf);

		// Token: 0x060000AA RID: 170
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBoxSphereBounds Internal_Union(in FBoxSphereBounds a, in FBoxSphereBounds b);

		// Token: 0x060000AB RID: 171 RVA: 0x00003150 File Offset: 0x00001350
		public unsafe FBoxSphereBounds(in FBox box)
		{
			fixed (FBoxSphereBounds* ptr = &this)
			{
				fixed (FBox* ptr2 = &box)
				{
					this = FBoxSphereBounds.Internal_Ctor_FBox(box);
				}
			}
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00003178 File Offset: 0x00001378
		public unsafe FBoxSphereBounds(in FSphere sphere)
		{
			fixed (FBoxSphereBounds* ptr = &this)
			{
				fixed (FSphere* ptr2 = &sphere)
				{
					this = FBoxSphereBounds.Internal_Ctor_FSphere(sphere);
				}
			}
		}

		// Token: 0x060000AD RID: 173 RVA: 0x000031A0 File Offset: 0x000013A0
		public unsafe FBoxSphereBounds(in FBox box, in FSphere sphere)
		{
			fixed (FBoxSphereBounds* ptr = &this)
			{
				fixed (FBox* ptr2 = &box)
				{
					fixed (FSphere* ptr3 = &sphere)
					{
						this = FBoxSphereBounds.Internal_Ctor_FBox_FSphere(box, sphere);
					}
				}
			}
		}

		// Token: 0x060000AE RID: 174 RVA: 0x000031CF File Offset: 0x000013CF
		public FBoxSphereBounds(in FVector inOrigin, in FVector inBoxExtent, float inSphereRadius)
		{
			this.Origin = inOrigin;
			this.BoxExtent = inBoxExtent;
			this.SphereRadius = inSphereRadius;
		}

		// Token: 0x060000AF RID: 175 RVA: 0x000031F0 File Offset: 0x000013F0
		public unsafe FBoxSphereBounds(Span<FVector> points)
		{
			fixed (FBoxSphereBounds* ptr = &this)
			{
				fixed (FVector* pinnableReference = points.GetPinnableReference())
				{
					FVector* data = pinnableReference;
					this = FBoxSphereBounds.Internal_Ctor_FVectorArr(data, points.Length);
				}
			}
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00003225 File Offset: 0x00001425
		public static bool operator ==(FBoxSphereBounds left, FBoxSphereBounds right)
		{
			return FBoxSphereBounds.Internal_Eq(left, right);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00003230 File Offset: 0x00001430
		public static bool operator !=(FBoxSphereBounds left, FBoxSphereBounds right)
		{
			return FBoxSphereBounds.Internal_NotEq(left, right);
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x0000323C File Offset: 0x0000143C
		public unsafe readonly bool ContainsNaN()
		{
			fixed (FBoxSphereBounds* ptr = &this)
			{
				return FBoxSphereBounds.Internal_ContainsNaN(this);
			}
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00003254 File Offset: 0x00001454
		public unsafe static FBoxSphereBounds operator +(in FBoxSphereBounds a, in FBoxSphereBounds b)
		{
			fixed (FBoxSphereBounds* ptr = &a)
			{
				fixed (FBoxSphereBounds* ptr2 = &b)
				{
					return FBoxSphereBounds.Internal_Add_FBoxSphereBounds(a, b);
				}
			}
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00003270 File Offset: 0x00001470
		public unsafe static FBoxSphereBounds operator *(in FBoxSphereBounds a, float scale)
		{
			fixed (FBoxSphereBounds* ptr = &a)
			{
				return FBoxSphereBounds.Internal_Mul_float(a, scale);
			}
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00003288 File Offset: 0x00001488
		public unsafe readonly float ComputeSquaredDistanceFromBoxToPoint(in FVector point)
		{
			fixed (FBoxSphereBounds* ptr = &this)
			{
				fixed (FVector* ptr2 = &point)
				{
					return FBoxSphereBounds.Internal_ComputeSquaredDistanceFromBoxToPoint(this, point);
				}
			}
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x000032A4 File Offset: 0x000014A4
		public unsafe static bool SpheresIntersect(in FBoxSphereBounds a, in FBoxSphereBounds b, float tolerance = 0.0001f)
		{
			fixed (FBoxSphereBounds* ptr = &a)
			{
				fixed (FBoxSphereBounds* ptr2 = &b)
				{
					return FBoxSphereBounds.Internal_SpheresIntersect(a, b, tolerance);
				}
			}
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x000032C4 File Offset: 0x000014C4
		public unsafe static bool BoxesIntersect(in FBoxSphereBounds a, in FBoxSphereBounds b)
		{
			fixed (FBoxSphereBounds* ptr = &a)
			{
				fixed (FBoxSphereBounds* ptr2 = &b)
				{
					return FBoxSphereBounds.Internal_BoxesIntersect(a, b);
				}
			}
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x000032E0 File Offset: 0x000014E0
		public unsafe readonly FBox GetBox()
		{
			fixed (FBoxSphereBounds* ptr = &this)
			{
				return FBoxSphereBounds.Internal_GetBox(this);
			}
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x000032F8 File Offset: 0x000014F8
		public unsafe readonly FVector GetBoxExtrema(uint extrema)
		{
			fixed (FBoxSphereBounds* ptr = &this)
			{
				return FBoxSphereBounds.Internal_GetBoxExtrema(this, extrema);
			}
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00003310 File Offset: 0x00001510
		public unsafe readonly FSphere GetSphere()
		{
			fixed (FBoxSphereBounds* ptr = &this)
			{
				return FBoxSphereBounds.Internal_GetSphere(this);
			}
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00003328 File Offset: 0x00001528
		public unsafe readonly FBoxSphereBounds ExpandBy(float amount)
		{
			fixed (FBoxSphereBounds* ptr = &this)
			{
				return FBoxSphereBounds.Internal_ExpandBy(this, amount);
			}
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00003340 File Offset: 0x00001540
		public unsafe readonly FBoxSphereBounds TransformBy(in FMatrix matrix)
		{
			fixed (FBoxSphereBounds* ptr = &this)
			{
				fixed (FMatrix* ptr2 = &matrix)
				{
					return FBoxSphereBounds.Internal_TransformBy_FMatrix(this, matrix);
				}
			}
		}

		// Token: 0x060000BD RID: 189 RVA: 0x0000335C File Offset: 0x0000155C
		public unsafe readonly FBoxSphereBounds TransformBy(in FTransform transform)
		{
			fixed (FBoxSphereBounds* ptr = &this)
			{
				fixed (FTransform* ptr2 = &transform)
				{
					return FBoxSphereBounds.Internal_TransformBy_FTransform(this, transform);
				}
			}
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00003378 File Offset: 0x00001578
		public unsafe static FBoxSphereBounds Union(in FBoxSphereBounds a, in FBoxSphereBounds b)
		{
			fixed (FBoxSphereBounds* ptr = &a)
			{
				fixed (FBoxSphereBounds* ptr2 = &b)
				{
					return FBoxSphereBounds.Internal_Union(a, b);
				}
			}
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00003394 File Offset: 0x00001594
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBoxSphereBounds._ScriptStructPtr != 0) ? FBoxSphereBounds._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.BoxSphereBounds", ref FBoxSphereBounds._ScriptStructPtr);
		}

		// Token: 0x04000020 RID: 32
		public static readonly FBoxSphereBounds Empty = new FBoxSphereBounds();

		// Token: 0x04000021 RID: 33
		[FieldOffset(0)]
		public FVector Origin;

		// Token: 0x04000022 RID: 34
		[FieldOffset(12)]
		public FVector BoxExtent;

		// Token: 0x04000023 RID: 35
		[FieldOffset(24)]
		public float SphereRadius;

		// Token: 0x04000024 RID: 36
		public const string __ObjectPath = "/Script/CoreUObject.BoxSphereBounds";

		// Token: 0x04000025 RID: 37
		private static IntPtr _ScriptStructPtr;
	}
}
