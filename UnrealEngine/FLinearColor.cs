using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200002E RID: 46
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 16)]
	[UnrealObjectPath("/Script/CoreUObject.LinearColor")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 16)]
	public struct FLinearColor : IEquatable<FLinearColor>, IEqualityOperators<FLinearColor, FLinearColor, bool>, IUnrealScriptStruct
	{
		// Token: 0x0600023D RID: 573 RVA: 0x0000831C File Offset: 0x0000651C
		public FLinearColor()
		{
			this = new FLinearColor(0f, 0f, 0f, 0f);
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00008338 File Offset: 0x00006538
		public FLinearColor(float r, float g, float b, float a = 1f)
		{
			this.R = r;
			this.G = g;
			this.B = b;
			this.A = a;
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00008357 File Offset: 0x00006557
		[NullableContext(1)]
		public FLinearColor(float[] rgba)
		{
			this = new FLinearColor(rgba[0], rgba[1], rgba[2], rgba[3]);
		}

		// Token: 0x06000240 RID: 576 RVA: 0x0000836B File Offset: 0x0000656B
		public unsafe FLinearColor(Span<float> rgba)
		{
			this = new FLinearColor(*rgba[0], *rgba[1], *rgba[2], *rgba[3]);
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00008397 File Offset: 0x00006597
		public FLinearColor(in FVector vector)
		{
			this = new FLinearColor(vector.X, vector.Y, vector.Z, 1f);
		}

		// Token: 0x06000242 RID: 578 RVA: 0x000083B6 File Offset: 0x000065B6
		public FLinearColor(in FVector4 vector)
		{
			this = new FLinearColor(vector.X, vector.Y, vector.Z, vector.W);
		}

		// Token: 0x06000243 RID: 579 RVA: 0x000083D6 File Offset: 0x000065D6
		public readonly bool Equals(FLinearColor other)
		{
			return this == other;
		}

		// Token: 0x06000244 RID: 580 RVA: 0x000083E4 File Offset: 0x000065E4
		[NullableContext(2)]
		public override readonly bool Equals(object obj)
		{
			if (obj is FLinearColor)
			{
				FLinearColor b = (FLinearColor)obj;
				return this == b;
			}
			return false;
		}

		// Token: 0x06000245 RID: 581 RVA: 0x0000840E File Offset: 0x0000660E
		public override readonly int GetHashCode()
		{
			return HashCode.Combine<float, float, float, float>(this.R, this.G, this.B, this.A);
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00008430 File Offset: 0x00006630
		[NullableContext(1)]
		public override readonly string ToString()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 4);
			defaultInterpolatedStringHandler.AppendLiteral("(R=");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.R);
			defaultInterpolatedStringHandler.AppendLiteral(",G=");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.G);
			defaultInterpolatedStringHandler.AppendLiteral(",B=");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.B);
			defaultInterpolatedStringHandler.AppendLiteral(",A=");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.A);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x06000247 RID: 583 RVA: 0x000084C0 File Offset: 0x000066C0
		public readonly float Component(int index)
		{
			float result;
			switch (index)
			{
			case 0:
				result = this.R;
				break;
			case 1:
				result = this.G;
				break;
			case 2:
				result = this.B;
				break;
			case 3:
				result = this.A;
				break;
			default:
				throw new IndexOutOfRangeException();
			}
			return result;
		}

		// Token: 0x06000248 RID: 584 RVA: 0x00008510 File Offset: 0x00006710
		public readonly float GetLuminance()
		{
			return this.ComputeLuminance();
		}

		// Token: 0x06000249 RID: 585 RVA: 0x00008518 File Offset: 0x00006718
		public static FLinearColor operator *(float scalar, in FLinearColor color)
		{
			return color * scalar;
		}

		// Token: 0x0600024A RID: 586
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FLinearColor Internal_Ctor_FColor(in FColor color);

		// Token: 0x0600024B RID: 587
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FLinearColor Internal_FromSRGBColor(in FColor color);

		// Token: 0x0600024C RID: 588
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FLinearColor Internal_FromPow22Color(in FColor color);

		// Token: 0x0600024D RID: 589
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FLinearColor Internal_MakeFromHSV8(byte h, byte s, byte v);

		// Token: 0x0600024E RID: 590
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FLinearColor Internal_MakeRandomColor();

		// Token: 0x0600024F RID: 591
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FLinearColor Internal_MakeRandomSeededColor(int seed);

		// Token: 0x06000250 RID: 592
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FLinearColor Internal_MakeFromColorTemperature(float temperature);

		// Token: 0x06000251 RID: 593
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_Eq(in FLinearColor a, in FLinearColor b);

		// Token: 0x06000252 RID: 594
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_NotEq(in FLinearColor a, in FLinearColor b);

		// Token: 0x06000253 RID: 595
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FColor Internal_ToRGBE(in FLinearColor color);

		// Token: 0x06000254 RID: 596
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FLinearColor Internal_Add(in FLinearColor a, in FLinearColor b);

		// Token: 0x06000255 RID: 597
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FLinearColor Internal_Sub(in FLinearColor a, in FLinearColor b);

		// Token: 0x06000256 RID: 598
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FLinearColor Internal_Mul(in FLinearColor a, in FLinearColor b);

		// Token: 0x06000257 RID: 599
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FLinearColor Internal_MulFloat(in FLinearColor a, float b);

		// Token: 0x06000258 RID: 600
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FLinearColor Internal_Div(in FLinearColor a, in FLinearColor b);

		// Token: 0x06000259 RID: 601
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FLinearColor Internal_DivFloat(in FLinearColor a, float b);

		// Token: 0x0600025A RID: 602
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_Equals(in FLinearColor a, in FLinearColor b, float tolerance);

		// Token: 0x0600025B RID: 603
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FLinearColor Internal_GetClamped(in FLinearColor color, float min, float max);

		// Token: 0x0600025C RID: 604
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FLinearColor Internal_CopyWithNewOpacity(in FLinearColor color, float opacity);

		// Token: 0x0600025D RID: 605
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_Dist(in FLinearColor a, in FLinearColor b);

		// Token: 0x0600025E RID: 606
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern float Internal_EvaluateBezier(FLinearColor* controlPoints, int controlPointsCount, IntPtr outPoints);

		// Token: 0x0600025F RID: 607
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FLinearColor Internal_LinearRGBToHSV(in FLinearColor color);

		// Token: 0x06000260 RID: 608
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FLinearColor Internal_HSVToLinearRGB(in FLinearColor color);

		// Token: 0x06000261 RID: 609
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FLinearColor Internal_LerpUsingHSV(in FLinearColor a, in FLinearColor b, float alpha);

		// Token: 0x06000262 RID: 610
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FColor Internal_Quantize(in FLinearColor color);

		// Token: 0x06000263 RID: 611
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FColor Internal_QuantizeRound(in FLinearColor color);

		// Token: 0x06000264 RID: 612
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FColor Internal_ToFColor(in FLinearColor color, bool bSGRB);

		// Token: 0x06000265 RID: 613
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FLinearColor Internal_Desaturate(in FLinearColor color, float desaturation);

		// Token: 0x06000266 RID: 614
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_ComputeLuminance(in FLinearColor color);

		// Token: 0x06000267 RID: 615
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_GetMax(in FLinearColor color);

		// Token: 0x06000268 RID: 616
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_GetMin(in FLinearColor color);

		// Token: 0x06000269 RID: 617
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IsAlmostBlack(in FLinearColor color);

		// Token: 0x0600026A RID: 618
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_InitFromString(ref FLinearColor color, in FCSharpStringView str);

		// Token: 0x0600026B RID: 619 RVA: 0x00008524 File Offset: 0x00006724
		public unsafe FLinearColor(in FColor color)
		{
			fixed (FColor* ptr = &color)
			{
				fixed (FLinearColor* ptr2 = &this)
				{
					this = FLinearColor.Internal_Ctor_FColor(color);
				}
			}
		}

		// Token: 0x0600026C RID: 620 RVA: 0x0000854C File Offset: 0x0000674C
		public unsafe static FLinearColor FromSRGBColor(in FColor color)
		{
			fixed (FColor* ptr = &color)
			{
				return FLinearColor.Internal_FromSRGBColor(color);
			}
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00008564 File Offset: 0x00006764
		public unsafe static FLinearColor FromPow22Color(in FColor color)
		{
			fixed (FColor* ptr = &color)
			{
				return FLinearColor.Internal_FromPow22Color(color);
			}
		}

		// Token: 0x0600026E RID: 622 RVA: 0x0000857B File Offset: 0x0000677B
		public static FLinearColor MakeFromHSV8(byte h, byte s, byte v)
		{
			return FLinearColor.Internal_MakeFromHSV8(h, s, v);
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00008585 File Offset: 0x00006785
		public static FLinearColor MakeRandomColor()
		{
			return FLinearColor.Internal_MakeRandomColor();
		}

		// Token: 0x06000270 RID: 624 RVA: 0x0000858C File Offset: 0x0000678C
		public static FLinearColor MakeRandomSeededColor(int seed)
		{
			return FLinearColor.Internal_MakeRandomSeededColor(seed);
		}

		// Token: 0x06000271 RID: 625 RVA: 0x00008594 File Offset: 0x00006794
		public static FLinearColor MakeFromColorTemperature(float temperature)
		{
			return FLinearColor.Internal_MakeFromColorTemperature(temperature);
		}

		// Token: 0x06000272 RID: 626 RVA: 0x0000859C File Offset: 0x0000679C
		public static bool operator ==(FLinearColor a, FLinearColor b)
		{
			return FLinearColor.Internal_Eq(a, b);
		}

		// Token: 0x06000273 RID: 627 RVA: 0x000085A7 File Offset: 0x000067A7
		public static bool operator !=(FLinearColor a, FLinearColor b)
		{
			return FLinearColor.Internal_NotEq(a, b);
		}

		// Token: 0x06000274 RID: 628 RVA: 0x000085B4 File Offset: 0x000067B4
		public unsafe static FLinearColor operator +(in FLinearColor a, in FLinearColor b)
		{
			fixed (FLinearColor* ptr = &a)
			{
				fixed (FLinearColor* ptr2 = &b)
				{
					return FLinearColor.Internal_Add(a, b);
				}
			}
		}

		// Token: 0x06000275 RID: 629 RVA: 0x000085D0 File Offset: 0x000067D0
		public unsafe static FLinearColor operator -(in FLinearColor a, in FLinearColor b)
		{
			fixed (FLinearColor* ptr = &a)
			{
				fixed (FLinearColor* ptr2 = &b)
				{
					return FLinearColor.Internal_Sub(a, b);
				}
			}
		}

		// Token: 0x06000276 RID: 630 RVA: 0x000085EC File Offset: 0x000067EC
		public unsafe static FLinearColor operator *(in FLinearColor a, in FLinearColor b)
		{
			fixed (FLinearColor* ptr = &a)
			{
				fixed (FLinearColor* ptr2 = &b)
				{
					return FLinearColor.Internal_Mul(a, b);
				}
			}
		}

		// Token: 0x06000277 RID: 631 RVA: 0x00008608 File Offset: 0x00006808
		public unsafe static FLinearColor operator *(in FLinearColor a, float b)
		{
			fixed (FLinearColor* ptr = &a)
			{
				return FLinearColor.Internal_MulFloat(a, b);
			}
		}

		// Token: 0x06000278 RID: 632 RVA: 0x00008620 File Offset: 0x00006820
		public unsafe static FLinearColor operator /(in FLinearColor a, in FLinearColor b)
		{
			fixed (FLinearColor* ptr = &a)
			{
				fixed (FLinearColor* ptr2 = &b)
				{
					return FLinearColor.Internal_Div(a, b);
				}
			}
		}

		// Token: 0x06000279 RID: 633 RVA: 0x0000863C File Offset: 0x0000683C
		public unsafe static FLinearColor operator /(in FLinearColor a, float b)
		{
			fixed (FLinearColor* ptr = &a)
			{
				return FLinearColor.Internal_DivFloat(a, b);
			}
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00008654 File Offset: 0x00006854
		public unsafe readonly FColor ToRGBE()
		{
			fixed (FLinearColor* ptr = &this)
			{
				return FLinearColor.Internal_ToRGBE(this);
			}
		}

		// Token: 0x0600027B RID: 635 RVA: 0x0000866C File Offset: 0x0000686C
		public unsafe readonly bool Equals(in FLinearColor other, float tolerance = 0.0001f)
		{
			fixed (FLinearColor* ptr = &this)
			{
				fixed (FLinearColor* ptr2 = &other)
				{
					return FLinearColor.Internal_Equals(this, other, tolerance);
				}
			}
		}

		// Token: 0x0600027C RID: 636 RVA: 0x0000868C File Offset: 0x0000688C
		public unsafe readonly FLinearColor GetClamped(float min, float max)
		{
			fixed (FLinearColor* ptr = &this)
			{
				return FLinearColor.Internal_GetClamped(this, min, max);
			}
		}

		// Token: 0x0600027D RID: 637 RVA: 0x000086A8 File Offset: 0x000068A8
		public unsafe readonly FLinearColor CopyWithNewOpacity(float opacity)
		{
			fixed (FLinearColor* ptr = &this)
			{
				return FLinearColor.Internal_CopyWithNewOpacity(this, opacity);
			}
		}

		// Token: 0x0600027E RID: 638 RVA: 0x000086C0 File Offset: 0x000068C0
		public unsafe static float Dist(in FLinearColor a, in FLinearColor b)
		{
			fixed (FLinearColor* ptr = &a)
			{
				fixed (FLinearColor* ptr2 = &b)
				{
					return FLinearColor.Internal_Dist(a, b);
				}
			}
		}

		// Token: 0x0600027F RID: 639 RVA: 0x000086DC File Offset: 0x000068DC
		public unsafe static float EvaluateBezier(Span<FLinearColor> controlPoints, [Nullable(1)] out TArray<FLinearColor> outPoints)
		{
			SharpherealAssert.Assert(controlPoints.Length >= 2, "EvaluateBezier");
			outPoints = new TArray<FLinearColor>();
			fixed (FLinearColor* pinnableReference = controlPoints.GetPinnableReference())
			{
				return FLinearColor.Internal_EvaluateBezier(pinnableReference, controlPoints.Length, outPoints._NativePtr);
			}
		}

		// Token: 0x06000280 RID: 640 RVA: 0x00008724 File Offset: 0x00006924
		public unsafe readonly FLinearColor LinearRGBToHSV()
		{
			fixed (FLinearColor* ptr = &this)
			{
				return FLinearColor.Internal_LinearRGBToHSV(this);
			}
		}

		// Token: 0x06000281 RID: 641 RVA: 0x0000873C File Offset: 0x0000693C
		public unsafe readonly FLinearColor HSVToLinearRGB()
		{
			fixed (FLinearColor* ptr = &this)
			{
				return FLinearColor.Internal_HSVToLinearRGB(this);
			}
		}

		// Token: 0x06000282 RID: 642 RVA: 0x00008754 File Offset: 0x00006954
		public unsafe static FLinearColor LerpUsingHSV(in FLinearColor a, in FLinearColor b, float alpha)
		{
			fixed (FLinearColor* ptr = &a)
			{
				fixed (FLinearColor* ptr2 = &b)
				{
					return FLinearColor.Internal_LerpUsingHSV(a, b, alpha);
				}
			}
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00008774 File Offset: 0x00006974
		public unsafe readonly FColor Quantize()
		{
			fixed (FLinearColor* ptr = &this)
			{
				return FLinearColor.Internal_Quantize(this);
			}
		}

		// Token: 0x06000284 RID: 644 RVA: 0x0000878C File Offset: 0x0000698C
		public unsafe readonly FColor QuantizeRound()
		{
			fixed (FLinearColor* ptr = &this)
			{
				return FLinearColor.Internal_QuantizeRound(this);
			}
		}

		// Token: 0x06000285 RID: 645 RVA: 0x000087A4 File Offset: 0x000069A4
		public unsafe readonly FColor ToFColor(bool bSGRB)
		{
			fixed (FLinearColor* ptr = &this)
			{
				return FLinearColor.Internal_ToFColor(this, bSGRB);
			}
		}

		// Token: 0x06000286 RID: 646 RVA: 0x000087BC File Offset: 0x000069BC
		public unsafe readonly FLinearColor Desaturate(float desaturation)
		{
			fixed (FLinearColor* ptr = &this)
			{
				return FLinearColor.Internal_Desaturate(this, desaturation);
			}
		}

		// Token: 0x06000287 RID: 647 RVA: 0x000087D4 File Offset: 0x000069D4
		public unsafe readonly float ComputeLuminance()
		{
			fixed (FLinearColor* ptr = &this)
			{
				return FLinearColor.Internal_ComputeLuminance(this);
			}
		}

		// Token: 0x06000288 RID: 648 RVA: 0x000087EC File Offset: 0x000069EC
		public unsafe readonly float GetMax()
		{
			fixed (FLinearColor* ptr = &this)
			{
				return FLinearColor.Internal_GetMax(this);
			}
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00008804 File Offset: 0x00006A04
		public unsafe readonly float GetMin()
		{
			fixed (FLinearColor* ptr = &this)
			{
				return FLinearColor.Internal_GetMin(this);
			}
		}

		// Token: 0x0600028A RID: 650 RVA: 0x0000881C File Offset: 0x00006A1C
		public unsafe readonly bool IsAlmostBlack()
		{
			fixed (FLinearColor* ptr = &this)
			{
				return FLinearColor.Internal_IsAlmostBlack(this);
			}
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00008834 File Offset: 0x00006A34
		[NullableContext(2)]
		public unsafe bool InitFromString(string str)
		{
			if (str == null || str.Length == 0)
			{
				this.R = (this.G = (this.B = 0f));
				this.A = 1f;
				return false;
			}
			fixed (FLinearColor* ptr = &this)
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
				return FLinearColor.Internal_InitFromString(ref this, fcsharpStringView);
			}
		}

		// Token: 0x0600028C RID: 652 RVA: 0x000088A1 File Offset: 0x00006AA1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLinearColor._ScriptStructPtr != 0) ? FLinearColor._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.LinearColor", ref FLinearColor._ScriptStructPtr);
		}

		// Token: 0x040000AF RID: 175
		public static readonly FLinearColor White = new FLinearColor(1f, 1f, 1f, 1f);

		// Token: 0x040000B0 RID: 176
		public static readonly FLinearColor Gray = new FLinearColor(0.5f, 0.5f, 0.5f, 1f);

		// Token: 0x040000B1 RID: 177
		public static readonly FLinearColor Black = new FLinearColor(0f, 0f, 0f, 1f);

		// Token: 0x040000B2 RID: 178
		public static readonly FLinearColor Transparent = new FLinearColor(0f, 0f, 0f, 0f);

		// Token: 0x040000B3 RID: 179
		public static readonly FLinearColor Red = new FLinearColor(1f, 0f, 0f, 1f);

		// Token: 0x040000B4 RID: 180
		public static readonly FLinearColor Green = new FLinearColor(0f, 1f, 0f, 1f);

		// Token: 0x040000B5 RID: 181
		public static readonly FLinearColor Blue = new FLinearColor(0f, 0f, 1f, 1f);

		// Token: 0x040000B6 RID: 182
		public static readonly FLinearColor Yellow = new FLinearColor(1f, 1f, 0f, 1f);

		// Token: 0x040000B7 RID: 183
		private static readonly float OneOver255 = 0.003921569f;

		// Token: 0x040000B8 RID: 184
		[FieldOffset(0)]
		public float R;

		// Token: 0x040000B9 RID: 185
		[FieldOffset(4)]
		public float G;

		// Token: 0x040000BA RID: 186
		[FieldOffset(8)]
		public float B;

		// Token: 0x040000BB RID: 187
		[FieldOffset(12)]
		public float A;

		// Token: 0x040000BC RID: 188
		public const string __ObjectPath = "/Script/CoreUObject.LinearColor";

		// Token: 0x040000BD RID: 189
		private static IntPtr _ScriptStructPtr;
	}
}
