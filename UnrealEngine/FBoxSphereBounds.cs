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
	// Token: 0x02000024 RID: 36
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(28, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 28)]
	[UnrealObjectPath("/Script/CoreUObject.BoxSphereBounds")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 28)]
	public struct FBoxSphereBounds : IEquatable<FBoxSphereBounds>, IEqualityOperators<FBoxSphereBounds, FBoxSphereBounds, bool>, IUnrealScriptStruct
	{
		// Token: 0x0600010B RID: 267 RVA: 0x00006726 File Offset: 0x00004926
		public FBoxSphereBounds()
		{
			this.Origin = default(FVector);
			this.BoxExtent = default(FVector);
			this.SphereRadius = 0f;
		}

		// Token: 0x0600010C RID: 268 RVA: 0x0000674B File Offset: 0x0000494B
		[NullableContext(1)]
		public FBoxSphereBounds(FVector[] points)
		{
			this = new FBoxSphereBounds(points.AsSpan<FVector>());
		}

		// Token: 0x0600010D RID: 269 RVA: 0x0000675C File Offset: 0x0000495C
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

		// Token: 0x0600010E RID: 270 RVA: 0x00006786 File Offset: 0x00004986
		public readonly bool Equals(FBoxSphereBounds other)
		{
			return this == other;
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00006794 File Offset: 0x00004994
		public override readonly int GetHashCode()
		{
			return HashCode.Combine<FVector, FVector, float>(this.Origin, this.BoxExtent, this.SphereRadius);
		}

		// Token: 0x06000110 RID: 272 RVA: 0x000067B0 File Offset: 0x000049B0
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

		// Token: 0x06000111 RID: 273 RVA: 0x0000681C File Offset: 0x00004A1C
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

		// Token: 0x06000112 RID: 274
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBoxSphereBounds Internal_Ctor_FBox(in FBox box);

		// Token: 0x06000113 RID: 275
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBoxSphereBounds Internal_Ctor_FSphere(in FSphere s);

		// Token: 0x06000114 RID: 276
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBoxSphereBounds Internal_Ctor_FBox_FSphere(in FBox box, in FSphere s);

		// Token: 0x06000115 RID: 277
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBoxSphereBounds Internal_Ctor_FVector_FVector_float(in FVector origin, in FVector extent, float radius);

		// Token: 0x06000116 RID: 278
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FBoxSphereBounds Internal_Ctor_FVectorArr(FVector* data, int num);

		// Token: 0x06000117 RID: 279
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_Eq(in FBoxSphereBounds a, in FBoxSphereBounds b);

		// Token: 0x06000118 RID: 280
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_NotEq(in FBoxSphereBounds a, in FBoxSphereBounds b);

		// Token: 0x06000119 RID: 281
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_ContainsNaN(in FBoxSphereBounds a);

		// Token: 0x0600011A RID: 282
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBoxSphereBounds Internal_Add_FBoxSphereBounds(in FBoxSphereBounds a, in FBoxSphereBounds b);

		// Token: 0x0600011B RID: 283
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBoxSphereBounds Internal_Mul_float(in FBoxSphereBounds a, float f);

		// Token: 0x0600011C RID: 284
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_ComputeSquaredDistanceFromBoxToPoint(in FBoxSphereBounds a, in FVector v);

		// Token: 0x0600011D RID: 285
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_SpheresIntersect(in FBoxSphereBounds a, in FBoxSphereBounds b, float tolerance);

		// Token: 0x0600011E RID: 286
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_BoxesIntersect(in FBoxSphereBounds a, in FBoxSphereBounds b);

		// Token: 0x0600011F RID: 287
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBox Internal_GetBox(in FBoxSphereBounds a);

		// Token: 0x06000120 RID: 288
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_GetBoxExtrema(in FBoxSphereBounds a, uint u);

		// Token: 0x06000121 RID: 289
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FSphere Internal_GetSphere(in FBoxSphereBounds a);

		// Token: 0x06000122 RID: 290
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBoxSphereBounds Internal_ExpandBy(in FBoxSphereBounds a, float fAbs);

		// Token: 0x06000123 RID: 291
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBoxSphereBounds Internal_TransformBy_FMatrix(in FBoxSphereBounds a, in FMatrix m);

		// Token: 0x06000124 RID: 292
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBoxSphereBounds Internal_TransformBy_FTransform(in FBoxSphereBounds a, in FTransform tf);

		// Token: 0x06000125 RID: 293
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBoxSphereBounds Internal_Union(in FBoxSphereBounds a, in FBoxSphereBounds b);

		// Token: 0x06000126 RID: 294 RVA: 0x000068E4 File Offset: 0x00004AE4
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

		// Token: 0x06000127 RID: 295 RVA: 0x0000690C File Offset: 0x00004B0C
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

		// Token: 0x06000128 RID: 296 RVA: 0x00006934 File Offset: 0x00004B34
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

		// Token: 0x06000129 RID: 297 RVA: 0x00006963 File Offset: 0x00004B63
		public FBoxSphereBounds(in FVector inOrigin, in FVector inBoxExtent, float inSphereRadius)
		{
			this.Origin = inOrigin;
			this.BoxExtent = inBoxExtent;
			this.SphereRadius = inSphereRadius;
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00006984 File Offset: 0x00004B84
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

		// Token: 0x0600012B RID: 299 RVA: 0x000069B9 File Offset: 0x00004BB9
		public static bool operator ==(FBoxSphereBounds left, FBoxSphereBounds right)
		{
			return FBoxSphereBounds.Internal_Eq(left, right);
		}

		// Token: 0x0600012C RID: 300 RVA: 0x000069C4 File Offset: 0x00004BC4
		public static bool operator !=(FBoxSphereBounds left, FBoxSphereBounds right)
		{
			return FBoxSphereBounds.Internal_NotEq(left, right);
		}

		// Token: 0x0600012D RID: 301 RVA: 0x000069D0 File Offset: 0x00004BD0
		public unsafe readonly bool ContainsNaN()
		{
			fixed (FBoxSphereBounds* ptr = &this)
			{
				return FBoxSphereBounds.Internal_ContainsNaN(this);
			}
		}

		// Token: 0x0600012E RID: 302 RVA: 0x000069E8 File Offset: 0x00004BE8
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

		// Token: 0x0600012F RID: 303 RVA: 0x00006A04 File Offset: 0x00004C04
		public unsafe static FBoxSphereBounds operator *(in FBoxSphereBounds a, float scale)
		{
			fixed (FBoxSphereBounds* ptr = &a)
			{
				return FBoxSphereBounds.Internal_Mul_float(a, scale);
			}
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00006A1C File Offset: 0x00004C1C
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

		// Token: 0x06000131 RID: 305 RVA: 0x00006A38 File Offset: 0x00004C38
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

		// Token: 0x06000132 RID: 306 RVA: 0x00006A58 File Offset: 0x00004C58
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

		// Token: 0x06000133 RID: 307 RVA: 0x00006A74 File Offset: 0x00004C74
		public unsafe readonly FBox GetBox()
		{
			fixed (FBoxSphereBounds* ptr = &this)
			{
				return FBoxSphereBounds.Internal_GetBox(this);
			}
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00006A8C File Offset: 0x00004C8C
		public unsafe readonly FVector GetBoxExtrema(uint extrema)
		{
			fixed (FBoxSphereBounds* ptr = &this)
			{
				return FBoxSphereBounds.Internal_GetBoxExtrema(this, extrema);
			}
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00006AA4 File Offset: 0x00004CA4
		public unsafe readonly FSphere GetSphere()
		{
			fixed (FBoxSphereBounds* ptr = &this)
			{
				return FBoxSphereBounds.Internal_GetSphere(this);
			}
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00006ABC File Offset: 0x00004CBC
		public unsafe readonly FBoxSphereBounds ExpandBy(float amount)
		{
			fixed (FBoxSphereBounds* ptr = &this)
			{
				return FBoxSphereBounds.Internal_ExpandBy(this, amount);
			}
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00006AD4 File Offset: 0x00004CD4
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

		// Token: 0x06000138 RID: 312 RVA: 0x00006AF0 File Offset: 0x00004CF0
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

		// Token: 0x06000139 RID: 313 RVA: 0x00006B0C File Offset: 0x00004D0C
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

		// Token: 0x0600013A RID: 314 RVA: 0x00006B28 File Offset: 0x00004D28
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBoxSphereBounds._ScriptStructPtr != 0) ? FBoxSphereBounds._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.BoxSphereBounds", ref FBoxSphereBounds._ScriptStructPtr);
		}

		// Token: 0x04000067 RID: 103
		public static readonly FBoxSphereBounds Empty = new FBoxSphereBounds();

		// Token: 0x04000068 RID: 104
		[FieldOffset(0)]
		public FVector Origin;

		// Token: 0x04000069 RID: 105
		[FieldOffset(12)]
		public FVector BoxExtent;

		// Token: 0x0400006A RID: 106
		[FieldOffset(24)]
		public float SphereRadius;

		// Token: 0x0400006B RID: 107
		public const string __ObjectPath = "/Script/CoreUObject.BoxSphereBounds";

		// Token: 0x0400006C RID: 108
		private static IntPtr _ScriptStructPtr;
	}
}
