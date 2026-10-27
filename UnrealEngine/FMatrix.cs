using System;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000030 RID: 48
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(64, 16, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 64)]
	[UnrealObjectPath("/Script/CoreUObject.Matrix")]
	[StructLayout(LayoutKind.Explicit, Pack = 16, Size = 64)]
	public struct FMatrix : IEquatable<FMatrix>, IEqualityOperators<FMatrix, FMatrix, bool>, IUnrealScriptStruct
	{
		// Token: 0x0600028E RID: 654 RVA: 0x000089D0 File Offset: 0x00006BD0
		public FMatrix(in FPlane x, in FPlane y, in FPlane z, in FPlane w)
		{
			this.Row0 = new FVector4(x.X, x.Y, x.Z, x.W);
			this.Row1 = new FVector4(y.X, y.Y, y.Z, y.W);
			this.Row2 = new FVector4(z.X, z.Y, z.Z, z.W);
			this.Row3 = new FVector4(w.X, w.Y, w.Z, w.W);
		}

		// Token: 0x0600028F RID: 655 RVA: 0x00008A70 File Offset: 0x00006C70
		public FMatrix(in FVector x, in FVector y, in FVector z, in FVector w)
		{
			this.Row0 = new FVector4(ref x, 0f);
			this.Row1 = new FVector4(ref y, 0f);
			this.Row2 = new FVector4(ref z, 0f);
			this.Row3 = new FVector4(ref w, 1f);
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00008AC4 File Offset: 0x00006CC4
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

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000291 RID: 657 RVA: 0x00008C32 File Offset: 0x00006E32
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public readonly ref FMatrixView View
		{
			get
			{
				return Unsafe.As<FMatrix, FMatrixView>(Unsafe.AsRef<FMatrix>(ref this));
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000292 RID: 658 RVA: 0x00008C3F File Offset: 0x00006E3F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref FMatrixView RwView
		{
			get
			{
				return Unsafe.As<FMatrix, FMatrixView>(Unsafe.AsRef<FMatrix>(ref this));
			}
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00008C4C File Offset: 0x00006E4C
		public unsafe readonly ReadOnlySpan<float> AsReadOnlySpan()
		{
			fixed (float* ptr = &this.View.Arr.FixedElementField)
			{
				return new Span<float>((void*)ptr, 16);
			}
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00008C78 File Offset: 0x00006E78
		public unsafe Span<float> AsSpan()
		{
			fixed (float* ptr = &this.RwView.Arr.FixedElementField)
			{
				return new Span<float>((void*)ptr, 16);
			}
		}

		// Token: 0x1700000A RID: 10
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

		// Token: 0x06000297 RID: 663 RVA: 0x00008CD8 File Offset: 0x00006ED8
		public void SetIdentity()
		{
			this = FMatrix.Identity;
		}

		// Token: 0x06000298 RID: 664 RVA: 0x00008CE5 File Offset: 0x00006EE5
		public readonly bool Equals(FMatrix other)
		{
			return this == other;
		}

		// Token: 0x06000299 RID: 665 RVA: 0x00008CF4 File Offset: 0x00006EF4
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

		// Token: 0x0600029A RID: 666 RVA: 0x00008D20 File Offset: 0x00006F20
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

		// Token: 0x0600029B RID: 667 RVA: 0x00008F94 File Offset: 0x00007194
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

		// Token: 0x0600029C RID: 668
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_Eq(in FMatrix a, in FMatrix b);

		// Token: 0x0600029D RID: 669
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_Equals(in FMatrix a, in FMatrix b, float tolerance);

		// Token: 0x0600029E RID: 670
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix Internal_Add(in FMatrix a, in FMatrix b);

		// Token: 0x0600029F RID: 671
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix Internal_Mul(in FMatrix a, in FMatrix b);

		// Token: 0x060002A0 RID: 672
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix Internal_MulFloat(in FMatrix a, float b);

		// Token: 0x060002A1 RID: 673
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector4 Internal_TransformFVector4(in FMatrix a, in FVector4 b);

		// Token: 0x060002A2 RID: 674
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector4 Internal_TransformPosition(in FMatrix a, in FVector b);

		// Token: 0x060002A3 RID: 675
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_InverseTransformPosition(in FMatrix a, in FVector b);

		// Token: 0x060002A4 RID: 676
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector4 Internal_TransformVector(in FMatrix a, in FVector b);

		// Token: 0x060002A5 RID: 677
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_InverseTransformVector(in FMatrix a, in FVector b);

		// Token: 0x060002A6 RID: 678
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix Internal_GetTransposed(in FMatrix a);

		// Token: 0x060002A7 RID: 679
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_Determinant(in FMatrix a);

		// Token: 0x060002A8 RID: 680
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_RotDeterminant(in FMatrix a);

		// Token: 0x060002A9 RID: 681
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix Internal_InverseFast(in FMatrix a);

		// Token: 0x060002AA RID: 682
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix Internal_Inverse(in FMatrix a);

		// Token: 0x060002AB RID: 683
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix Internal_TransposeAdjoint(in FMatrix a);

		// Token: 0x060002AC RID: 684
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_RemoveScaling(ref FMatrix a, float b);

		// Token: 0x060002AD RID: 685
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix Internal_GetMatrixWithoutScale(in FMatrix a, float b);

		// Token: 0x060002AE RID: 686
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_GetScaleVector(in FMatrix a, float b);

		// Token: 0x060002AF RID: 687
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_ExtractScaling(ref FMatrix a, float b);

		// Token: 0x060002B0 RID: 688
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix Internal_RemoveTranslation(in FMatrix a);

		// Token: 0x060002B1 RID: 689
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix Internal_ConcatTranslation(in FMatrix a, in FVector b);

		// Token: 0x060002B2 RID: 690
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_ContainsNaN(in FMatrix a);

		// Token: 0x060002B3 RID: 691
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_GetMaximumAxisScale(in FMatrix a);

		// Token: 0x060002B4 RID: 692
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_ScaleTranslation(ref FMatrix a, in FVector b);

		// Token: 0x060002B5 RID: 693
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_GetOrigin(in FMatrix a);

		// Token: 0x060002B6 RID: 694
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_GetScaledAxis(in FMatrix a, EAxis b);

		// Token: 0x060002B7 RID: 695
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_GetScaledAxes(in FMatrix a, out FVector b, out FVector c, out FVector d);

		// Token: 0x060002B8 RID: 696
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_GetUnitAxis(in FMatrix a, EAxis b);

		// Token: 0x060002B9 RID: 697
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_GetUnitAxes(in FMatrix a, out FVector b, out FVector c, out FVector d);

		// Token: 0x060002BA RID: 698
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_SetAxis(ref FMatrix a, int b, in FVector c);

		// Token: 0x060002BB RID: 699
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_SetOrigin(ref FMatrix a, in FVector b);

		// Token: 0x060002BC RID: 700
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern void Internal_SetAxes(ref FMatrix a, FVector* b, FVector* c, FVector* d, FVector* e);

		// Token: 0x060002BD RID: 701
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_GetColumn(in FMatrix a, int b);

		// Token: 0x060002BE RID: 702
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_SetColumn(ref FMatrix a, int b, in FVector c);

		// Token: 0x060002BF RID: 703
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator Internal_Rotator(in FMatrix a);

		// Token: 0x060002C0 RID: 704
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat Internal_ToQuat(in FMatrix a);

		// Token: 0x060002C1 RID: 705
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_GetFrustumNearPlane(in FMatrix a, out FPlane b);

		// Token: 0x060002C2 RID: 706
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_GetFrustumFarPlane(in FMatrix a, out FPlane b);

		// Token: 0x060002C3 RID: 707
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_GetFrustumLeftPlane(in FMatrix a, out FPlane b);

		// Token: 0x060002C4 RID: 708
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_GetFrustumRightPlane(in FMatrix a, out FPlane b);

		// Token: 0x060002C5 RID: 709
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_GetFrustumTopPlane(in FMatrix a, out FPlane b);

		// Token: 0x060002C6 RID: 710
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_GetFrustumBottomPlane(in FMatrix a, out FPlane b);

		// Token: 0x060002C7 RID: 711
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Mirror(ref FMatrix a, EAxis b, EAxis c);

		// Token: 0x060002C8 RID: 712
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern void Internal_To3x4MatrixTranspose(in FMatrix a, float* @out);

		// Token: 0x060002C9 RID: 713 RVA: 0x00008FD4 File Offset: 0x000071D4
		public static bool operator ==(FMatrix a, FMatrix b)
		{
			return FMatrix.Internal_Eq(a, b);
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00008FDF File Offset: 0x000071DF
		public static bool operator !=(FMatrix a, FMatrix b)
		{
			return !FMatrix.Internal_Eq(a, b);
		}

		// Token: 0x060002CB RID: 715 RVA: 0x00008FF0 File Offset: 0x000071F0
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

		// Token: 0x060002CC RID: 716 RVA: 0x00009010 File Offset: 0x00007210
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

		// Token: 0x060002CD RID: 717 RVA: 0x0000902C File Offset: 0x0000722C
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

		// Token: 0x060002CE RID: 718 RVA: 0x00009048 File Offset: 0x00007248
		public unsafe static FMatrix operator *(in FMatrix m, float scale)
		{
			fixed (FMatrix* ptr = &m)
			{
				return FMatrix.Internal_MulFloat(m, scale);
			}
		}

		// Token: 0x060002CF RID: 719 RVA: 0x00009060 File Offset: 0x00007260
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

		// Token: 0x060002D0 RID: 720 RVA: 0x0000907C File Offset: 0x0000727C
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

		// Token: 0x060002D1 RID: 721 RVA: 0x00009098 File Offset: 0x00007298
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

		// Token: 0x060002D2 RID: 722 RVA: 0x000090B4 File Offset: 0x000072B4
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

		// Token: 0x060002D3 RID: 723 RVA: 0x000090D0 File Offset: 0x000072D0
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

		// Token: 0x060002D4 RID: 724 RVA: 0x000090EC File Offset: 0x000072EC
		public unsafe readonly FMatrix GetTransposed()
		{
			fixed (FMatrix* ptr = &this)
			{
				return FMatrix.Internal_GetTransposed(this);
			}
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x00009104 File Offset: 0x00007304
		public unsafe readonly float Determinant()
		{
			fixed (FMatrix* ptr = &this)
			{
				return FMatrix.Internal_Determinant(this);
			}
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x0000911C File Offset: 0x0000731C
		public unsafe readonly float RotDeterminant()
		{
			fixed (FMatrix* ptr = &this)
			{
				return FMatrix.Internal_RotDeterminant(this);
			}
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x00009134 File Offset: 0x00007334
		public unsafe readonly FMatrix InverseFast()
		{
			fixed (FMatrix* ptr = &this)
			{
				return FMatrix.Internal_InverseFast(this);
			}
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x0000914C File Offset: 0x0000734C
		public unsafe readonly FMatrix Inverse()
		{
			fixed (FMatrix* ptr = &this)
			{
				return FMatrix.Internal_Inverse(this);
			}
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x00009164 File Offset: 0x00007364
		public unsafe readonly FMatrix TransposeAdjoint()
		{
			fixed (FMatrix* ptr = &this)
			{
				return FMatrix.Internal_TransposeAdjoint(this);
			}
		}

		// Token: 0x060002DA RID: 730 RVA: 0x0000917C File Offset: 0x0000737C
		public unsafe void RemoveScaling(float tolerance = 1E-08f)
		{
			fixed (FMatrix* ptr = &this)
			{
				FMatrix.Internal_RemoveScaling(ref this, tolerance);
			}
		}

		// Token: 0x060002DB RID: 731 RVA: 0x00009198 File Offset: 0x00007398
		public unsafe readonly FMatrix GetMatrixWithoutScale(float tolerance = 1E-08f)
		{
			fixed (FMatrix* ptr = &this)
			{
				return FMatrix.Internal_GetMatrixWithoutScale(this, tolerance);
			}
		}

		// Token: 0x060002DC RID: 732 RVA: 0x000091B0 File Offset: 0x000073B0
		public unsafe readonly FVector GetScaleVector(float tolerance = 1E-08f)
		{
			fixed (FMatrix* ptr = &this)
			{
				return FMatrix.Internal_GetScaleVector(this, tolerance);
			}
		}

		// Token: 0x060002DD RID: 733 RVA: 0x000091C8 File Offset: 0x000073C8
		public unsafe FVector ExtractScaling(float tolerance = 1E-08f)
		{
			fixed (FMatrix* ptr = &this)
			{
				return FMatrix.Internal_ExtractScaling(ref this, tolerance);
			}
		}

		// Token: 0x060002DE RID: 734 RVA: 0x000091E0 File Offset: 0x000073E0
		public unsafe readonly FMatrix RemoveTranslation()
		{
			fixed (FMatrix* ptr = &this)
			{
				return FMatrix.Internal_RemoveTranslation(this);
			}
		}

		// Token: 0x060002DF RID: 735 RVA: 0x000091F8 File Offset: 0x000073F8
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

		// Token: 0x060002E0 RID: 736 RVA: 0x00009214 File Offset: 0x00007414
		public unsafe readonly bool ContainsNaN()
		{
			fixed (FMatrix* ptr = &this)
			{
				return FMatrix.Internal_ContainsNaN(this);
			}
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x0000922C File Offset: 0x0000742C
		public unsafe readonly float GetMaximumAxisScale()
		{
			fixed (FMatrix* ptr = &this)
			{
				return FMatrix.Internal_GetMaximumAxisScale(this);
			}
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x00009244 File Offset: 0x00007444
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

		// Token: 0x060002E3 RID: 739 RVA: 0x00009268 File Offset: 0x00007468
		public unsafe readonly FVector GetOrigin()
		{
			fixed (FMatrix* ptr = &this)
			{
				return FMatrix.Internal_GetOrigin(this);
			}
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x00009280 File Offset: 0x00007480
		public unsafe readonly FVector GetScaledAxis(EAxis axis)
		{
			fixed (FMatrix* ptr = &this)
			{
				return FMatrix.Internal_GetScaledAxis(this, axis);
			}
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x00009298 File Offset: 0x00007498
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

		// Token: 0x060002E6 RID: 742 RVA: 0x000092CC File Offset: 0x000074CC
		public unsafe readonly FVector GetUnitAxis(EAxis axis)
		{
			fixed (FMatrix* ptr = &this)
			{
				return FMatrix.Internal_GetUnitAxis(this, axis);
			}
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x000092E4 File Offset: 0x000074E4
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

		// Token: 0x060002E8 RID: 744 RVA: 0x00009318 File Offset: 0x00007518
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

		// Token: 0x060002E9 RID: 745 RVA: 0x0000933C File Offset: 0x0000753C
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

		// Token: 0x060002EA RID: 746 RVA: 0x00009360 File Offset: 0x00007560
		public unsafe void SetAxes(FVector? x = null, FVector? y = null, FVector? z = null, FVector? w = null)
		{
			fixed (FMatrix* ptr = &this)
			{
				FMatrix.Internal_SetAxes(ref this, (FVector*)((x != null) ? Unsafe.AsPointer<FVector>(Unsafe.AsRef<FVector>(Nullable.GetValueRefOrDefaultRef<FVector>(ref x))) : null), (FVector*)((y != null) ? Unsafe.AsPointer<FVector>(Unsafe.AsRef<FVector>(Nullable.GetValueRefOrDefaultRef<FVector>(ref y))) : null), (FVector*)((z != null) ? Unsafe.AsPointer<FVector>(Unsafe.AsRef<FVector>(Nullable.GetValueRefOrDefaultRef<FVector>(ref z))) : null), (FVector*)((w != null) ? Unsafe.AsPointer<FVector>(Unsafe.AsRef<FVector>(Nullable.GetValueRefOrDefaultRef<FVector>(ref w))) : null));
			}
		}

		// Token: 0x060002EB RID: 747 RVA: 0x000093F4 File Offset: 0x000075F4
		public unsafe readonly FVector GetColumn(int i)
		{
			fixed (FMatrix* ptr = &this)
			{
				return FMatrix.Internal_GetColumn(this, i);
			}
		}

		// Token: 0x060002EC RID: 748 RVA: 0x0000940C File Offset: 0x0000760C
		public unsafe void SetColumn(int i, in FVector value)
		{
			fixed (FMatrix* ptr = &this)
			{
				FMatrix.Internal_SetColumn(ref this, i, value);
			}
		}

		// Token: 0x060002ED RID: 749 RVA: 0x00009428 File Offset: 0x00007628
		public unsafe readonly FRotator Rotator()
		{
			fixed (FMatrix* ptr = &this)
			{
				return FMatrix.Internal_Rotator(this);
			}
		}

		// Token: 0x060002EE RID: 750 RVA: 0x00009440 File Offset: 0x00007640
		public unsafe readonly FQuat ToQuat()
		{
			fixed (FMatrix* ptr = &this)
			{
				return FMatrix.Internal_ToQuat(this);
			}
		}

		// Token: 0x060002EF RID: 751 RVA: 0x00009458 File Offset: 0x00007658
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

		// Token: 0x060002F0 RID: 752 RVA: 0x00009474 File Offset: 0x00007674
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

		// Token: 0x060002F1 RID: 753 RVA: 0x00009490 File Offset: 0x00007690
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

		// Token: 0x060002F2 RID: 754 RVA: 0x000094AC File Offset: 0x000076AC
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

		// Token: 0x060002F3 RID: 755 RVA: 0x000094C8 File Offset: 0x000076C8
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

		// Token: 0x060002F4 RID: 756 RVA: 0x000094E4 File Offset: 0x000076E4
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

		// Token: 0x060002F5 RID: 757 RVA: 0x00009500 File Offset: 0x00007700
		public unsafe void Mirror(EAxis mirrorAxis, EAxis flipAxis)
		{
			fixed (FMatrix* ptr = &this)
			{
				FMatrix.Internal_Mirror(ref this, mirrorAxis, flipAxis);
			}
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x0000951C File Offset: 0x0000771C
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

		// Token: 0x060002F7 RID: 759 RVA: 0x00009556 File Offset: 0x00007756
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMatrix._ScriptStructPtr != 0) ? FMatrix._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.Matrix", ref FMatrix._ScriptStructPtr);
		}

		// Token: 0x040000C7 RID: 199
		[FieldOffset(0)]
		public FVector4 Row0;

		// Token: 0x040000C8 RID: 200
		[FieldOffset(16)]
		public FVector4 Row1;

		// Token: 0x040000C9 RID: 201
		[FieldOffset(32)]
		public FVector4 Row2;

		// Token: 0x040000CA RID: 202
		[FieldOffset(48)]
		public FVector4 Row3;

		// Token: 0x040000CB RID: 203
		public static readonly FMatrix Identity = new FMatrix(1f, 0f, 0f, 0f, 0f, 1f, 0f, 0f, 0f, 0f, 1f, 0f, 0f, 0f, 0f, 1f);

		// Token: 0x040000CC RID: 204
		public const string __ObjectPath = "/Script/CoreUObject.Matrix";

		// Token: 0x040000CD RID: 205
		private static IntPtr _ScriptStructPtr;
	}
}
