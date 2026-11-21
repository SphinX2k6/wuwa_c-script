using System;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000015 RID: 21
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(64, 16, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 64)]
	[UnrealObjectPath("/Script/CoreUObject.Matrix")]
	[StructLayout(LayoutKind.Explicit, Pack = 16, Size = 64)]
	public struct FMatrix : IEquatable<FMatrix>, IEqualityOperators<FMatrix, FMatrix, bool>, IUnrealScriptStruct
	{
		// Token: 0x06000213 RID: 531 RVA: 0x0000523C File Offset: 0x0000343C
		public FMatrix(in FPlane x, in FPlane y, in FPlane z, in FPlane w)
		{
			this.Row0 = new FVector4(x.X, x.Y, x.Z, x.W);
			this.Row1 = new FVector4(y.X, y.Y, y.Z, y.W);
			this.Row2 = new FVector4(z.X, z.Y, z.Z, z.W);
			this.Row3 = new FVector4(w.X, w.Y, w.Z, w.W);
		}

		// Token: 0x06000214 RID: 532 RVA: 0x000052DC File Offset: 0x000034DC
		public FMatrix(in FVector x, in FVector y, in FVector z, in FVector w)
		{
			this.Row0 = new FVector4(ref x, 0f);
			this.Row1 = new FVector4(ref y, 0f);
			this.Row2 = new FVector4(ref z, 0f);
			this.Row3 = new FVector4(ref w, 1f);
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00005330 File Offset: 0x00003530
		public unsafe FMatrix(float m00, float m01, float m02, float m03, float m10, float m11, float m12, float m13, float m20, float m21, float m22, float m23, float m30, float m31, float m32, float m33)
		{
			this.Row0 = default(FVector4);
			this.Row1 = default(FVector4);
			this.Row2 = default(FVector4);
			this.Row3 = default(FVector4);
			ref FMatrixView ptr = ref Unsafe.As<FMatrix, FMatrixView>(ref this);
			ptr.Arr.FixedElementField = m00;
			*(ref ptr.Arr.FixedElementField + 4) = m01;
			*(ref ptr.Arr.FixedElementField + (IntPtr)2 * 4) = m02;
			*(ref ptr.Arr.FixedElementField + (IntPtr)3 * 4) = m03;
			*(ref ptr.Arr.FixedElementField + (IntPtr)4 * 4) = m10;
			*(ref ptr.Arr.FixedElementField + (IntPtr)5 * 4) = m11;
			*(ref ptr.Arr.FixedElementField + (IntPtr)6 * 4) = m12;
			*(ref ptr.Arr.FixedElementField + (IntPtr)7 * 4) = m13;
			*(ref ptr.Arr.FixedElementField + (IntPtr)8 * 4) = m20;
			*(ref ptr.Arr.FixedElementField + (IntPtr)9 * 4) = m21;
			*(ref ptr.Arr.FixedElementField + (IntPtr)10 * 4) = m22;
			*(ref ptr.Arr.FixedElementField + (IntPtr)11 * 4) = m23;
			*(ref ptr.Arr.FixedElementField + (IntPtr)12 * 4) = m30;
			*(ref ptr.Arr.FixedElementField + (IntPtr)13 * 4) = m31;
			*(ref ptr.Arr.FixedElementField + (IntPtr)14 * 4) = m32;
			*(ref ptr.Arr.FixedElementField + (IntPtr)15 * 4) = m33;
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000216 RID: 534 RVA: 0x0000549E File Offset: 0x0000369E
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public readonly ref FMatrixView View
		{
			get
			{
				return Unsafe.As<FMatrix, FMatrixView>(Unsafe.AsRef<FMatrix>(ref this));
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000217 RID: 535 RVA: 0x000054AB File Offset: 0x000036AB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref FMatrixView RwView
		{
			get
			{
				return Unsafe.As<FMatrix, FMatrixView>(Unsafe.AsRef<FMatrix>(ref this));
			}
		}

		// Token: 0x06000218 RID: 536 RVA: 0x000054B8 File Offset: 0x000036B8
		public unsafe readonly ReadOnlySpan<float> AsReadOnlySpan()
		{
			fixed (float* ptr = &this.View.Arr.FixedElementField)
			{
				return new Span<float>((void*)ptr, 16);
			}
		}

		// Token: 0x06000219 RID: 537 RVA: 0x000054E4 File Offset: 0x000036E4
		public unsafe Span<float> AsSpan()
		{
			fixed (float* ptr = &this.RwView.Arr.FixedElementField)
			{
				return new Span<float>((void*)ptr, 16);
			}
		}

		// Token: 0x17000009 RID: 9
		public unsafe float this[int row, int column]
		{
			readonly get
			{
				return *(ref this.View.Arr.FixedElementField + (IntPtr)(row * 4 + column) * 4);
			}
			set
			{
				*(ref this.RwView.Arr.FixedElementField + (IntPtr)(row * 4 + column) * 4) = value;
			}
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00005544 File Offset: 0x00003744
		public void SetIdentity()
		{
			this = FMatrix.Identity;
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00005551 File Offset: 0x00003751
		public readonly bool Equals(FMatrix other)
		{
			return this == other;
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00005560 File Offset: 0x00003760
		[NullableContext(2)]
		public override readonly bool Equals(object obj)
		{
			if (obj is FMatrix)
			{
				FMatrix b = (FMatrix)obj;
				return this == b;
			}
			return false;
		}

		// Token: 0x0600021F RID: 543 RVA: 0x0000558C File Offset: 0x0000378C
		[NullableContext(1)]
		public unsafe override readonly string ToString()
		{
			ref FMatrixView view = ref this.View;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(38, 16);
			defaultInterpolatedStringHandler.AppendLiteral("[");
			defaultInterpolatedStringHandler.AppendFormatted<float>(view.Arr.FixedElementField);
			defaultInterpolatedStringHandler.AppendLiteral(", ");
			defaultInterpolatedStringHandler.AppendFormatted<float>(*(ref view.Arr.FixedElementField + 4));
			defaultInterpolatedStringHandler.AppendLiteral(", ");
			defaultInterpolatedStringHandler.AppendFormatted<float>(*(ref view.Arr.FixedElementField + (IntPtr)2 * 4));
			defaultInterpolatedStringHandler.AppendLiteral(", ");
			defaultInterpolatedStringHandler.AppendFormatted<float>(*(ref view.Arr.FixedElementField + (IntPtr)3 * 4));
			defaultInterpolatedStringHandler.AppendLiteral("]\r\n[");
			defaultInterpolatedStringHandler.AppendFormatted<float>(*(ref view.Arr.FixedElementField + (IntPtr)4 * 4));
			defaultInterpolatedStringHandler.AppendLiteral(", ");
			defaultInterpolatedStringHandler.AppendFormatted<float>(*(ref view.Arr.FixedElementField + (IntPtr)5 * 4));
			defaultInterpolatedStringHandler.AppendLiteral(", ");
			defaultInterpolatedStringHandler.AppendFormatted<float>(*(ref view.Arr.FixedElementField + (IntPtr)6 * 4));
			defaultInterpolatedStringHandler.AppendLiteral(", ");
			defaultInterpolatedStringHandler.AppendFormatted<float>(*(ref view.Arr.FixedElementField + (IntPtr)7 * 4));
			defaultInterpolatedStringHandler.AppendLiteral("]\r\n[");
			defaultInterpolatedStringHandler.AppendFormatted<float>(*(ref view.Arr.FixedElementField + (IntPtr)8 * 4));
			defaultInterpolatedStringHandler.AppendLiteral(", ");
			defaultInterpolatedStringHandler.AppendFormatted<float>(*(ref view.Arr.FixedElementField + (IntPtr)9 * 4));
			defaultInterpolatedStringHandler.AppendLiteral(", ");
			defaultInterpolatedStringHandler.AppendFormatted<float>(*(ref view.Arr.FixedElementField + (IntPtr)10 * 4));
			defaultInterpolatedStringHandler.AppendLiteral(", ");
			defaultInterpolatedStringHandler.AppendFormatted<float>(*(ref view.Arr.FixedElementField + (IntPtr)11 * 4));
			defaultInterpolatedStringHandler.AppendLiteral("]\r\n[");
			defaultInterpolatedStringHandler.AppendFormatted<float>(*(ref view.Arr.FixedElementField + (IntPtr)12 * 4));
			defaultInterpolatedStringHandler.AppendLiteral(", ");
			defaultInterpolatedStringHandler.AppendFormatted<float>(*(ref view.Arr.FixedElementField + (IntPtr)13 * 4));
			defaultInterpolatedStringHandler.AppendLiteral(", ");
			defaultInterpolatedStringHandler.AppendFormatted<float>(*(ref view.Arr.FixedElementField + (IntPtr)14 * 4));
			defaultInterpolatedStringHandler.AppendLiteral(", ");
			defaultInterpolatedStringHandler.AppendFormatted<float>(*(ref view.Arr.FixedElementField + (IntPtr)15 * 4));
			defaultInterpolatedStringHandler.AppendLiteral("]");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00005800 File Offset: 0x00003A00
		public override readonly int GetHashCode()
		{
			int num = 17;
			ref FMatrixView view = ref this.View;
			for (int i = 0; i < 16; i++)
			{
				num = num * 31 + (ref view.Arr.FixedElementField + (IntPtr)i * 4).GetHashCode();
			}
			return num;
		}

		// Token: 0x06000221 RID: 545
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_Eq(in FMatrix a, in FMatrix b);

		// Token: 0x06000222 RID: 546
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_Equals(in FMatrix a, in FMatrix b, float tolerance);

		// Token: 0x06000223 RID: 547
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix Internal_Add(in FMatrix a, in FMatrix b);

		// Token: 0x06000224 RID: 548
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix Internal_Mul(in FMatrix a, in FMatrix b);

		// Token: 0x06000225 RID: 549
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix Internal_MulFloat(in FMatrix a, float b);

		// Token: 0x06000226 RID: 550
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector4 Internal_TransformFVector4(in FMatrix a, in FVector4 b);

		// Token: 0x06000227 RID: 551
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector4 Internal_TransformPosition(in FMatrix a, in FVector b);

		// Token: 0x06000228 RID: 552
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_InverseTransformPosition(in FMatrix a, in FVector b);

		// Token: 0x06000229 RID: 553
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector4 Internal_TransformVector(in FMatrix a, in FVector b);

		// Token: 0x0600022A RID: 554
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_InverseTransformVector(in FMatrix a, in FVector b);

		// Token: 0x0600022B RID: 555
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix Internal_GetTransposed(in FMatrix a);

		// Token: 0x0600022C RID: 556
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_Determinant(in FMatrix a);

		// Token: 0x0600022D RID: 557
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_RotDeterminant(in FMatrix a);

		// Token: 0x0600022E RID: 558
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix Internal_InverseFast(in FMatrix a);

		// Token: 0x0600022F RID: 559
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix Internal_Inverse(in FMatrix a);

		// Token: 0x06000230 RID: 560
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix Internal_TransposeAdjoint(in FMatrix a);

		// Token: 0x06000231 RID: 561
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_RemoveScaling(ref FMatrix a, float b);

		// Token: 0x06000232 RID: 562
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix Internal_GetMatrixWithoutScale(in FMatrix a, float b);

		// Token: 0x06000233 RID: 563
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_GetScaleVector(in FMatrix a, float b);

		// Token: 0x06000234 RID: 564
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_ExtractScaling(ref FMatrix a, float b);

		// Token: 0x06000235 RID: 565
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix Internal_RemoveTranslation(in FMatrix a);

		// Token: 0x06000236 RID: 566
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix Internal_ConcatTranslation(in FMatrix a, in FVector b);

		// Token: 0x06000237 RID: 567
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_ContainsNaN(in FMatrix a);

		// Token: 0x06000238 RID: 568
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_GetMaximumAxisScale(in FMatrix a);

		// Token: 0x06000239 RID: 569
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_ScaleTranslation(ref FMatrix a, in FVector b);

		// Token: 0x0600023A RID: 570
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_GetOrigin(in FMatrix a);

		// Token: 0x0600023B RID: 571
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_GetScaledAxis(in FMatrix a, EAxis b);

		// Token: 0x0600023C RID: 572
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_GetScaledAxes(in FMatrix a, out FVector b, out FVector c, out FVector d);

		// Token: 0x0600023D RID: 573
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_GetUnitAxis(in FMatrix a, EAxis b);

		// Token: 0x0600023E RID: 574
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_GetUnitAxes(in FMatrix a, out FVector b, out FVector c, out FVector d);

		// Token: 0x0600023F RID: 575
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_SetAxis(ref FMatrix a, int b, in FVector c);

		// Token: 0x06000240 RID: 576
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_SetOrigin(ref FMatrix a, in FVector b);

		// Token: 0x06000241 RID: 577
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern void Internal_SetAxes(ref FMatrix a, FVector* b, FVector* c, FVector* d, FVector* e);

		// Token: 0x06000242 RID: 578
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_GetColumn(in FMatrix a, int b);

		// Token: 0x06000243 RID: 579
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_SetColumn(ref FMatrix a, int b, in FVector c);

		// Token: 0x06000244 RID: 580
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator Internal_Rotator(in FMatrix a);

		// Token: 0x06000245 RID: 581
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat Internal_ToQuat(in FMatrix a);

		// Token: 0x06000246 RID: 582
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_GetFrustumNearPlane(in FMatrix a, out FPlane b);

		// Token: 0x06000247 RID: 583
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_GetFrustumFarPlane(in FMatrix a, out FPlane b);

		// Token: 0x06000248 RID: 584
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_GetFrustumLeftPlane(in FMatrix a, out FPlane b);

		// Token: 0x06000249 RID: 585
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_GetFrustumRightPlane(in FMatrix a, out FPlane b);

		// Token: 0x0600024A RID: 586
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_GetFrustumTopPlane(in FMatrix a, out FPlane b);

		// Token: 0x0600024B RID: 587
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_GetFrustumBottomPlane(in FMatrix a, out FPlane b);

		// Token: 0x0600024C RID: 588
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Mirror(ref FMatrix a, EAxis b, EAxis c);

		// Token: 0x0600024D RID: 589
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern void Internal_To3x4MatrixTranspose(in FMatrix a, float* @out);

		// Token: 0x0600024E RID: 590 RVA: 0x00005840 File Offset: 0x00003A40
		public static bool operator ==(FMatrix a, FMatrix b)
		{
			return FMatrix.Internal_Eq(a, b);
		}

		// Token: 0x0600024F RID: 591 RVA: 0x0000584B File Offset: 0x00003A4B
		public static bool operator !=(FMatrix a, FMatrix b)
		{
			return !FMatrix.Internal_Eq(a, b);
		}

		// Token: 0x06000250 RID: 592 RVA: 0x0000585C File Offset: 0x00003A5C
		public unsafe bool Equals(in FMatrix b, float tolerance = 0.0001f)
		{
			fixed (FMatrix* ptr = &this)
			{
				fixed (FMatrix* ptr2 = &b)
				{
					return FMatrix.Internal_Equals(this, b, tolerance);
				}
			}
		}

		// Token: 0x06000251 RID: 593 RVA: 0x0000587C File Offset: 0x00003A7C
		public unsafe static FMatrix operator +(in FMatrix a, in FMatrix b)
		{
			fixed (FMatrix* ptr = &a)
			{
				fixed (FMatrix* ptr2 = &b)
				{
					return FMatrix.Internal_Add(a, b);
				}
			}
		}

		// Token: 0x06000252 RID: 594 RVA: 0x00005898 File Offset: 0x00003A98
		public unsafe static FMatrix operator *(in FMatrix a, in FMatrix b)
		{
			fixed (FMatrix* ptr = &a)
			{
				fixed (FMatrix* ptr2 = &b)
				{
					return FMatrix.Internal_Mul(a, b);
				}
			}
		}

		// Token: 0x06000253 RID: 595 RVA: 0x000058B4 File Offset: 0x00003AB4
		public unsafe static FMatrix operator *(in FMatrix m, float scale)
		{
			fixed (FMatrix* ptr = &m)
			{
				return FMatrix.Internal_MulFloat(m, scale);
			}
		}

		// Token: 0x06000254 RID: 596 RVA: 0x000058CC File Offset: 0x00003ACC
		public unsafe readonly FVector4 TransformFVector4(in FVector4 v)
		{
			fixed (FMatrix* ptr = &this)
			{
				fixed (FVector4* ptr2 = &v)
				{
					return FMatrix.Internal_TransformFVector4(this, v);
				}
			}
		}

		// Token: 0x06000255 RID: 597 RVA: 0x000058E8 File Offset: 0x00003AE8
		public unsafe readonly FVector4 TransformPosition(in FVector v)
		{
			fixed (FMatrix* ptr = &this)
			{
				fixed (FVector* ptr2 = &v)
				{
					return FMatrix.Internal_TransformPosition(this, v);
				}
			}
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00005904 File Offset: 0x00003B04
		public unsafe readonly FVector InverseTransformPosition(in FVector v)
		{
			fixed (FMatrix* ptr = &this)
			{
				fixed (FVector* ptr2 = &v)
				{
					return FMatrix.Internal_InverseTransformPosition(this, v);
				}
			}
		}

		// Token: 0x06000257 RID: 599 RVA: 0x00005920 File Offset: 0x00003B20
		public unsafe readonly FVector4 TransformVector(in FVector v)
		{
			fixed (FMatrix* ptr = &this)
			{
				fixed (FVector* ptr2 = &v)
				{
					return FMatrix.Internal_TransformVector(this, v);
				}
			}
		}

		// Token: 0x06000258 RID: 600 RVA: 0x0000593C File Offset: 0x00003B3C
		public unsafe readonly FVector InverseTransformVector(in FVector v)
		{
			fixed (FMatrix* ptr = &this)
			{
				fixed (FVector* ptr2 = &v)
				{
					return FMatrix.Internal_InverseTransformVector(this, v);
				}
			}
		}

		// Token: 0x06000259 RID: 601 RVA: 0x00005958 File Offset: 0x00003B58
		public unsafe readonly FMatrix GetTransposed()
		{
			fixed (FMatrix* ptr = &this)
			{
				return FMatrix.Internal_GetTransposed(this);
			}
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00005970 File Offset: 0x00003B70
		public unsafe readonly float Determinant()
		{
			fixed (FMatrix* ptr = &this)
			{
				return FMatrix.Internal_Determinant(this);
			}
		}

		// Token: 0x0600025B RID: 603 RVA: 0x00005988 File Offset: 0x00003B88
		public unsafe readonly float RotDeterminant()
		{
			fixed (FMatrix* ptr = &this)
			{
				return FMatrix.Internal_RotDeterminant(this);
			}
		}

		// Token: 0x0600025C RID: 604 RVA: 0x000059A0 File Offset: 0x00003BA0
		public unsafe readonly FMatrix InverseFast()
		{
			fixed (FMatrix* ptr = &this)
			{
				return FMatrix.Internal_InverseFast(this);
			}
		}

		// Token: 0x0600025D RID: 605 RVA: 0x000059B8 File Offset: 0x00003BB8
		public unsafe readonly FMatrix Inverse()
		{
			fixed (FMatrix* ptr = &this)
			{
				return FMatrix.Internal_Inverse(this);
			}
		}

		// Token: 0x0600025E RID: 606 RVA: 0x000059D0 File Offset: 0x00003BD0
		public unsafe readonly FMatrix TransposeAdjoint()
		{
			fixed (FMatrix* ptr = &this)
			{
				return FMatrix.Internal_TransposeAdjoint(this);
			}
		}

		// Token: 0x0600025F RID: 607 RVA: 0x000059E8 File Offset: 0x00003BE8
		public unsafe void RemoveScaling(float tolerance = 1E-08f)
		{
			fixed (FMatrix* ptr = &this)
			{
				FMatrix.Internal_RemoveScaling(ref this, tolerance);
			}
		}

		// Token: 0x06000260 RID: 608 RVA: 0x00005A04 File Offset: 0x00003C04
		public unsafe readonly FMatrix GetMatrixWithoutScale(float tolerance = 1E-08f)
		{
			fixed (FMatrix* ptr = &this)
			{
				return FMatrix.Internal_GetMatrixWithoutScale(this, tolerance);
			}
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00005A1C File Offset: 0x00003C1C
		public unsafe readonly FVector GetScaleVector(float tolerance = 1E-08f)
		{
			fixed (FMatrix* ptr = &this)
			{
				return FMatrix.Internal_GetScaleVector(this, tolerance);
			}
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00005A34 File Offset: 0x00003C34
		public unsafe FVector ExtractScaling(float tolerance = 1E-08f)
		{
			fixed (FMatrix* ptr = &this)
			{
				return FMatrix.Internal_ExtractScaling(ref this, tolerance);
			}
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00005A4C File Offset: 0x00003C4C
		public unsafe readonly FMatrix RemoveTranslation()
		{
			fixed (FMatrix* ptr = &this)
			{
				return FMatrix.Internal_RemoveTranslation(this);
			}
		}

		// Token: 0x06000264 RID: 612 RVA: 0x00005A64 File Offset: 0x00003C64
		public unsafe readonly FMatrix ConcatTranslation(in FVector translation)
		{
			fixed (FMatrix* ptr = &this)
			{
				fixed (FVector* ptr2 = &translation)
				{
					return FMatrix.Internal_ConcatTranslation(this, translation);
				}
			}
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00005A80 File Offset: 0x00003C80
		public unsafe readonly bool ContainsNaN()
		{
			fixed (FMatrix* ptr = &this)
			{
				return FMatrix.Internal_ContainsNaN(this);
			}
		}

		// Token: 0x06000266 RID: 614 RVA: 0x00005A98 File Offset: 0x00003C98
		public unsafe readonly float GetMaximumAxisScale()
		{
			fixed (FMatrix* ptr = &this)
			{
				return FMatrix.Internal_GetMaximumAxisScale(this);
			}
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00005AB0 File Offset: 0x00003CB0
		public unsafe void ScaleTranslation(in FVector scale)
		{
			fixed (FMatrix* ptr = &this)
			{
				fixed (FVector* ptr2 = &scale)
				{
					FMatrix.Internal_ScaleTranslation(ref this, scale);
				}
			}
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00005AD4 File Offset: 0x00003CD4
		public unsafe readonly FVector GetOrigin()
		{
			fixed (FMatrix* ptr = &this)
			{
				return FMatrix.Internal_GetOrigin(this);
			}
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00005AEC File Offset: 0x00003CEC
		public unsafe readonly FVector GetScaledAxis(EAxis axis)
		{
			fixed (FMatrix* ptr = &this)
			{
				return FMatrix.Internal_GetScaledAxis(this, axis);
			}
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00005B04 File Offset: 0x00003D04
		public unsafe readonly void GetScaledAxes(out FVector x, out FVector y, out FVector z)
		{
			fixed (FMatrix* ptr = &this)
			{
				fixed (FVector* ptr2 = &x)
				{
					fixed (FVector* ptr3 = &y)
					{
						fixed (FVector* ptr4 = &z)
						{
							FMatrix.Internal_GetScaledAxes(this, out x, out y, out z);
						}
					}
				}
			}
		}

		// Token: 0x0600026B RID: 619 RVA: 0x00005B38 File Offset: 0x00003D38
		public unsafe readonly FVector GetUnitAxis(EAxis axis)
		{
			fixed (FMatrix* ptr = &this)
			{
				return FMatrix.Internal_GetUnitAxis(this, axis);
			}
		}

		// Token: 0x0600026C RID: 620 RVA: 0x00005B50 File Offset: 0x00003D50
		public unsafe readonly void GetUnitAxes(out FVector x, out FVector y, out FVector z)
		{
			fixed (FMatrix* ptr = &this)
			{
				fixed (FVector* ptr2 = &x)
				{
					fixed (FVector* ptr3 = &y)
					{
						fixed (FVector* ptr4 = &z)
						{
							FMatrix.Internal_GetUnitAxes(this, out x, out y, out z);
						}
					}
				}
			}
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00005B84 File Offset: 0x00003D84
		public unsafe void SetAxis(int i, in FVector axis)
		{
			fixed (FMatrix* ptr = &this)
			{
				fixed (FVector* ptr2 = &axis)
				{
					FMatrix.Internal_SetAxis(ref this, i, axis);
				}
			}
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00005BA8 File Offset: 0x00003DA8
		public unsafe void SetOrigin(in FVector origin)
		{
			fixed (FMatrix* ptr = &this)
			{
				fixed (FVector* ptr2 = &origin)
				{
					FMatrix.Internal_SetOrigin(ref this, origin);
				}
			}
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00005BCC File Offset: 0x00003DCC
		public unsafe void SetAxes(FVector? x = null, FVector? y = null, FVector? z = null, FVector? w = null)
		{
			fixed (FMatrix* ptr = &this)
			{
				FMatrix.Internal_SetAxes(ref this, (FVector*)((x != null) ? Unsafe.AsPointer<FVector>(Unsafe.AsRef<FVector>(Nullable.GetValueRefOrDefaultRef<FVector>(ref x))) : null), (FVector*)((y != null) ? Unsafe.AsPointer<FVector>(Unsafe.AsRef<FVector>(Nullable.GetValueRefOrDefaultRef<FVector>(ref y))) : null), (FVector*)((z != null) ? Unsafe.AsPointer<FVector>(Unsafe.AsRef<FVector>(Nullable.GetValueRefOrDefaultRef<FVector>(ref z))) : null), (FVector*)((w != null) ? Unsafe.AsPointer<FVector>(Unsafe.AsRef<FVector>(Nullable.GetValueRefOrDefaultRef<FVector>(ref w))) : null));
			}
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00005C60 File Offset: 0x00003E60
		public unsafe readonly FVector GetColumn(int i)
		{
			fixed (FMatrix* ptr = &this)
			{
				return FMatrix.Internal_GetColumn(this, i);
			}
		}

		// Token: 0x06000271 RID: 625 RVA: 0x00005C78 File Offset: 0x00003E78
		public unsafe void SetColumn(int i, in FVector value)
		{
			fixed (FMatrix* ptr = &this)
			{
				FMatrix.Internal_SetColumn(ref this, i, value);
			}
		}

		// Token: 0x06000272 RID: 626 RVA: 0x00005C94 File Offset: 0x00003E94
		public unsafe readonly FRotator Rotator()
		{
			fixed (FMatrix* ptr = &this)
			{
				return FMatrix.Internal_Rotator(this);
			}
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00005CAC File Offset: 0x00003EAC
		public unsafe readonly FQuat ToQuat()
		{
			fixed (FMatrix* ptr = &this)
			{
				return FMatrix.Internal_ToQuat(this);
			}
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00005CC4 File Offset: 0x00003EC4
		public unsafe readonly bool GetFrustumNearPlane(out FPlane plane)
		{
			fixed (FMatrix* ptr = &this)
			{
				fixed (FPlane* ptr2 = &plane)
				{
					return FMatrix.Internal_GetFrustumNearPlane(this, out plane);
				}
			}
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00005CE0 File Offset: 0x00003EE0
		public unsafe readonly bool GetFrustumFarPlane(out FPlane plane)
		{
			fixed (FMatrix* ptr = &this)
			{
				fixed (FPlane* ptr2 = &plane)
				{
					return FMatrix.Internal_GetFrustumFarPlane(this, out plane);
				}
			}
		}

		// Token: 0x06000276 RID: 630 RVA: 0x00005CFC File Offset: 0x00003EFC
		public unsafe readonly bool GetFrustumLeftPlane(out FPlane plane)
		{
			fixed (FMatrix* ptr = &this)
			{
				fixed (FPlane* ptr2 = &plane)
				{
					return FMatrix.Internal_GetFrustumLeftPlane(this, out plane);
				}
			}
		}

		// Token: 0x06000277 RID: 631 RVA: 0x00005D18 File Offset: 0x00003F18
		public unsafe readonly bool GetFrustumRightPlane(out FPlane plane)
		{
			fixed (FMatrix* ptr = &this)
			{
				fixed (FPlane* ptr2 = &plane)
				{
					return FMatrix.Internal_GetFrustumRightPlane(this, out plane);
				}
			}
		}

		// Token: 0x06000278 RID: 632 RVA: 0x00005D34 File Offset: 0x00003F34
		public unsafe readonly bool GetFrustumTopPlane(out FPlane plane)
		{
			fixed (FMatrix* ptr = &this)
			{
				fixed (FPlane* ptr2 = &plane)
				{
					return FMatrix.Internal_GetFrustumTopPlane(this, out plane);
				}
			}
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00005D50 File Offset: 0x00003F50
		public unsafe readonly bool GetFrustumBottomPlane(out FPlane plane)
		{
			fixed (FMatrix* ptr = &this)
			{
				fixed (FPlane* ptr2 = &plane)
				{
					return FMatrix.Internal_GetFrustumBottomPlane(this, out plane);
				}
			}
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00005D6C File Offset: 0x00003F6C
		public unsafe void Mirror(EAxis mirrorAxis, EAxis flipAxis)
		{
			fixed (FMatrix* ptr = &this)
			{
				FMatrix.Internal_Mirror(ref this, mirrorAxis, flipAxis);
			}
		}

		// Token: 0x0600027B RID: 635 RVA: 0x00005D88 File Offset: 0x00003F88
		public unsafe readonly void To3x4MatrixTranspose(Span<float> result)
		{
			if (result.Length < 12)
			{
				throw new IndexOutOfRangeException();
			}
			fixed (FMatrix* ptr = &this)
			{
				fixed (float* pinnableReference = result.GetPinnableReference())
				{
					float* @out = pinnableReference;
					FMatrix.Internal_To3x4MatrixTranspose(this, @out);
				}
			}
		}

		// Token: 0x0600027C RID: 636 RVA: 0x00005DC2 File Offset: 0x00003FC2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMatrix._ScriptStructPtr != 0) ? FMatrix._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.Matrix", ref FMatrix._ScriptStructPtr);
		}

		// Token: 0x04000080 RID: 128
		[FieldOffset(0)]
		public FVector4 Row0;

		// Token: 0x04000081 RID: 129
		[FieldOffset(16)]
		public FVector4 Row1;

		// Token: 0x04000082 RID: 130
		[FieldOffset(32)]
		public FVector4 Row2;

		// Token: 0x04000083 RID: 131
		[FieldOffset(48)]
		public FVector4 Row3;

		// Token: 0x04000084 RID: 132
		public static readonly FMatrix Identity = new FMatrix(1f, 0f, 0f, 0f, 0f, 1f, 0f, 0f, 0f, 0f, 1f, 0f, 0f, 0f, 0f, 1f);

		// Token: 0x04000085 RID: 133
		public const string __ObjectPath = "/Script/CoreUObject.Matrix";

		// Token: 0x04000086 RID: 134
		private static IntPtr _ScriptStructPtr;
	}
}
