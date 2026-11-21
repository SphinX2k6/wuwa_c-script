using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200000A RID: 10
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(4, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 4)]
	[UnrealObjectPath("/Script/CoreUObject.Color")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 4)]
	public struct FColor : IEquatable<FColor>, IEqualityOperators<FColor, FColor, bool>, IUnrealScriptStruct
	{
		// Token: 0x060000C1 RID: 193 RVA: 0x000033C4 File Offset: 0x000015C4
		public unsafe readonly uint DWColor()
		{
			return *this.Dummy;
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x000033CD File Offset: 0x000015CD
		public FColor()
		{
			this.B = 0;
			this.G = 0;
			this.R = 0;
			this.A = 0;
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x000033EB File Offset: 0x000015EB
		public FColor(byte r, byte g, byte b, byte a = 255)
		{
			this.B = b;
			this.G = g;
			this.R = r;
			this.A = a;
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x0000340A File Offset: 0x0000160A
		public unsafe FColor(uint color)
		{
			this.B = 0;
			this.G = 0;
			this.R = 0;
			this.A = 0;
			*this.Dummy = color;
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x00003430 File Offset: 0x00001630
		public readonly ref uint Dummy
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return Unsafe.As<FColor, uint>(Unsafe.AsRef<FColor>(ref this));
			}
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x0000343D File Offset: 0x0000163D
		public readonly bool Equals(FColor other)
		{
			return this == other;
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x0000344C File Offset: 0x0000164C
		[NullableContext(2)]
		public override readonly bool Equals(object obj)
		{
			if (obj is FColor)
			{
				FColor right = (FColor)obj;
				return this == right;
			}
			return false;
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00003476 File Offset: 0x00001676
		public override readonly int GetHashCode()
		{
			return HashCode.Combine<byte, byte, byte, byte>(this.R, this.G, this.B, this.A);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00003498 File Offset: 0x00001698
		[NullableContext(1)]
		public override readonly string ToString()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 4);
			defaultInterpolatedStringHandler.AppendLiteral("(R=");
			defaultInterpolatedStringHandler.AppendFormatted<byte>(this.R);
			defaultInterpolatedStringHandler.AppendLiteral(",G=");
			defaultInterpolatedStringHandler.AppendFormatted<byte>(this.G);
			defaultInterpolatedStringHandler.AppendLiteral(",B=");
			defaultInterpolatedStringHandler.AppendFormatted<byte>(this.B);
			defaultInterpolatedStringHandler.AppendLiteral(",A=");
			defaultInterpolatedStringHandler.AppendFormatted<byte>(this.A);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00003528 File Offset: 0x00001728
		[NullableContext(1)]
		public readonly string ToHex()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 4);
			defaultInterpolatedStringHandler.AppendFormatted<byte>(this.R, "X2");
			defaultInterpolatedStringHandler.AppendFormatted<byte>(this.G, "X2");
			defaultInterpolatedStringHandler.AppendFormatted<byte>(this.B, "X2");
			defaultInterpolatedStringHandler.AppendFormatted<byte>(this.A, "X2");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x060000CB RID: 203 RVA: 0x0000358D File Offset: 0x0000178D
		public unsafe static bool operator ==(FColor left, FColor right)
		{
			return *left.Dummy == *right.Dummy;
		}

		// Token: 0x060000CC RID: 204 RVA: 0x000035A1 File Offset: 0x000017A1
		public unsafe static bool operator !=(FColor left, FColor right)
		{
			return *left.Dummy != *right.Dummy;
		}

		// Token: 0x060000CD RID: 205
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FColor Internal_FromHex(in FCSharpStringView str);

		// Token: 0x060000CE RID: 206
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_MakeRandomColor(out FColor result);

		// Token: 0x060000CF RID: 207
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FColor Internal_MakeRedToGreenColorFromScalar(float f);

		// Token: 0x060000D0 RID: 208
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FColor Internal_MakeFromColorTemperature(float f);

		// Token: 0x060000D1 RID: 209
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Add(ref FColor a, in FColor b);

		// Token: 0x060000D2 RID: 210
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FLinearColor Internal_FromRGBE(in FColor a);

		// Token: 0x060000D3 RID: 211
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FColor Internal_WithAlpha(in FColor a, byte alpha);

		// Token: 0x060000D4 RID: 212
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FLinearColor Internal_ReinterpretAsLinear(in FColor a);

		// Token: 0x060000D5 RID: 213
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern uint Internal_ToPackedARGB(in FColor a);

		// Token: 0x060000D6 RID: 214
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern uint Internal_ToPackedABGR(in FColor a);

		// Token: 0x060000D7 RID: 215
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern uint Internal_ToPackedRGBA(in FColor a);

		// Token: 0x060000D8 RID: 216
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern uint Internal_ToPackedBGRA(in FColor a);

		// Token: 0x060000D9 RID: 217
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_InitFromString(ref FColor a, in FCSharpStringView b);

		// Token: 0x060000DA RID: 218 RVA: 0x000035B8 File Offset: 0x000017B8
		[NullableContext(2)]
		public unsafe static FColor FromHex(string hexStr)
		{
			if (hexStr == null || hexStr.Length == 0)
			{
				return default(FColor);
			}
			char* ptr;
			if (hexStr == null)
			{
				ptr = null;
			}
			else
			{
				fixed (char* pinnableReference = hexStr.GetPinnableReference())
				{
					ptr = pinnableReference;
				}
			}
			FCSharpStringView fcsharpStringView = new FCSharpStringView(ptr, hexStr.Length);
			return FColor.Internal_FromHex(fcsharpStringView);
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00003600 File Offset: 0x00001800
		public static FColor MakeRandomColor()
		{
			FColor result;
			FColor.Internal_MakeRandomColor(out result);
			return result;
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00003615 File Offset: 0x00001815
		public static FColor MakeRedToGreenColorFromScalar(float scalar)
		{
			return FColor.Internal_MakeRedToGreenColorFromScalar(scalar);
		}

		// Token: 0x060000DD RID: 221 RVA: 0x0000361D File Offset: 0x0000181D
		public static FColor MakeFromColorTemperature(float temp)
		{
			return FColor.Internal_MakeFromColorTemperature(temp);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00003628 File Offset: 0x00001828
		public unsafe static FColor operator +(FColor a, in FColor b)
		{
			fixed (FColor* ptr = &b)
			{
				FColor.Internal_Add(ref a, b);
			}
			return a;
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00003648 File Offset: 0x00001848
		public unsafe readonly FLinearColor FromRGBE()
		{
			fixed (FColor* ptr = &this)
			{
				return FColor.Internal_FromRGBE(this);
			}
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00003660 File Offset: 0x00001860
		public unsafe readonly FColor WithAlpha(byte alpha)
		{
			fixed (FColor* ptr = &this)
			{
				return FColor.Internal_WithAlpha(this, alpha);
			}
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00003678 File Offset: 0x00001878
		public unsafe readonly FLinearColor ReinterpretAsLinear()
		{
			fixed (FColor* ptr = &this)
			{
				return FColor.Internal_ReinterpretAsLinear(this);
			}
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00003690 File Offset: 0x00001890
		public unsafe readonly uint ToPackedARGB()
		{
			fixed (FColor* ptr = &this)
			{
				return FColor.Internal_ToPackedARGB(this);
			}
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x000036A8 File Offset: 0x000018A8
		public unsafe readonly uint ToPackedABGR()
		{
			fixed (FColor* ptr = &this)
			{
				return FColor.Internal_ToPackedABGR(this);
			}
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x000036C0 File Offset: 0x000018C0
		public unsafe readonly uint ToPackedRGBA()
		{
			fixed (FColor* ptr = &this)
			{
				return FColor.Internal_ToPackedRGBA(this);
			}
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x000036D8 File Offset: 0x000018D8
		public unsafe readonly uint ToPackedBGRA()
		{
			fixed (FColor* ptr = &this)
			{
				return FColor.Internal_ToPackedBGRA(this);
			}
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x000036F0 File Offset: 0x000018F0
		[NullableContext(2)]
		public unsafe bool InitFromString(string str)
		{
			if (str == null || str.Length == 0)
			{
				this.R = (this.G = (this.B = 0));
				this.A = byte.MaxValue;
				return false;
			}
			fixed (FColor* ptr = &this)
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
				return FColor.Internal_InitFromString(ref this, fcsharpStringView);
			}
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00003759 File Offset: 0x00001959
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FColor._ScriptStructPtr != 0) ? FColor._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.Color", ref FColor._ScriptStructPtr);
		}

		// Token: 0x04000026 RID: 38
		[FieldOffset(0)]
		public byte B;

		// Token: 0x04000027 RID: 39
		[FieldOffset(1)]
		public byte G;

		// Token: 0x04000028 RID: 40
		[FieldOffset(2)]
		public byte R;

		// Token: 0x04000029 RID: 41
		[FieldOffset(3)]
		public byte A;

		// Token: 0x0400002A RID: 42
		public static readonly FColor White = new FColor(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue);

		// Token: 0x0400002B RID: 43
		public static readonly FColor Black = new FColor(0, 0, 0, byte.MaxValue);

		// Token: 0x0400002C RID: 44
		public static readonly FColor Transparent = new FColor(0, 0, 0, 0);

		// Token: 0x0400002D RID: 45
		public static readonly FColor Red = new FColor(byte.MaxValue, 0, 0, byte.MaxValue);

		// Token: 0x0400002E RID: 46
		public static readonly FColor Green = new FColor(0, byte.MaxValue, 0, byte.MaxValue);

		// Token: 0x0400002F RID: 47
		public static readonly FColor Blue = new FColor(0, 0, byte.MaxValue, byte.MaxValue);

		// Token: 0x04000030 RID: 48
		public static readonly FColor Yellow = new FColor(byte.MaxValue, byte.MaxValue, 0, byte.MaxValue);

		// Token: 0x04000031 RID: 49
		public static readonly FColor Cyan = new FColor(0, byte.MaxValue, byte.MaxValue, byte.MaxValue);

		// Token: 0x04000032 RID: 50
		public static readonly FColor Magenta = new FColor(byte.MaxValue, 0, byte.MaxValue, byte.MaxValue);

		// Token: 0x04000033 RID: 51
		public static readonly FColor Orange = new FColor(243, 156, 18, byte.MaxValue);

		// Token: 0x04000034 RID: 52
		public static readonly FColor Purple = new FColor(169, 7, 228, byte.MaxValue);

		// Token: 0x04000035 RID: 53
		public static readonly FColor Turquoise = new FColor(26, 188, 156, byte.MaxValue);

		// Token: 0x04000036 RID: 54
		public static readonly FColor Silver = new FColor(189, 195, 199, byte.MaxValue);

		// Token: 0x04000037 RID: 55
		public static readonly FColor Emerald = new FColor(46, 204, 113, byte.MaxValue);

		// Token: 0x04000038 RID: 56
		public const string __ObjectPath = "/Script/CoreUObject.Color";

		// Token: 0x04000039 RID: 57
		private static IntPtr _ScriptStructPtr;
	}
}
