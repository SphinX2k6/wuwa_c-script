using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000025 RID: 37
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(4, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 4)]
	[UnrealObjectPath("/Script/CoreUObject.Color")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 4)]
	public struct FColor : IEquatable<FColor>, IEqualityOperators<FColor, FColor, bool>, IUnrealScriptStruct
	{
		// Token: 0x0600013C RID: 316 RVA: 0x00006B58 File Offset: 0x00004D58
		public unsafe readonly uint DWColor()
		{
			return *this.Dummy;
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00006B61 File Offset: 0x00004D61
		public FColor()
		{
			this.B = 0;
			this.G = 0;
			this.R = 0;
			this.A = 0;
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00006B7F File Offset: 0x00004D7F
		public FColor(byte r, byte g, byte b, byte a = 255)
		{
			this.B = b;
			this.G = g;
			this.R = r;
			this.A = a;
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00006B9E File Offset: 0x00004D9E
		public unsafe FColor(uint color)
		{
			this.B = 0;
			this.G = 0;
			this.R = 0;
			this.A = 0;
			*this.Dummy = color;
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000140 RID: 320 RVA: 0x00006BC4 File Offset: 0x00004DC4
		public readonly ref uint Dummy
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return Unsafe.As<FColor, uint>(Unsafe.AsRef<FColor>(ref this));
			}
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00006BD1 File Offset: 0x00004DD1
		public readonly bool Equals(FColor other)
		{
			return this == other;
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00006BE0 File Offset: 0x00004DE0
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

		// Token: 0x06000143 RID: 323 RVA: 0x00006C0A File Offset: 0x00004E0A
		public override readonly int GetHashCode()
		{
			return HashCode.Combine<byte, byte, byte, byte>(this.R, this.G, this.B, this.A);
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00006C2C File Offset: 0x00004E2C
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

		// Token: 0x06000145 RID: 325 RVA: 0x00006CBC File Offset: 0x00004EBC
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

		// Token: 0x06000146 RID: 326 RVA: 0x00006D21 File Offset: 0x00004F21
		public unsafe static bool operator ==(FColor left, FColor right)
		{
			return *left.Dummy == *right.Dummy;
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00006D35 File Offset: 0x00004F35
		public unsafe static bool operator !=(FColor left, FColor right)
		{
			return *left.Dummy != *right.Dummy;
		}

		// Token: 0x06000148 RID: 328
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FColor Internal_FromHex(in FCSharpStringView str);

		// Token: 0x06000149 RID: 329
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_MakeRandomColor(out FColor result);

		// Token: 0x0600014A RID: 330
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FColor Internal_MakeRedToGreenColorFromScalar(float f);

		// Token: 0x0600014B RID: 331
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FColor Internal_MakeFromColorTemperature(float f);

		// Token: 0x0600014C RID: 332
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Add(ref FColor a, in FColor b);

		// Token: 0x0600014D RID: 333
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FLinearColor Internal_FromRGBE(in FColor a);

		// Token: 0x0600014E RID: 334
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FColor Internal_WithAlpha(in FColor a, byte alpha);

		// Token: 0x0600014F RID: 335
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FLinearColor Internal_ReinterpretAsLinear(in FColor a);

		// Token: 0x06000150 RID: 336
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern uint Internal_ToPackedARGB(in FColor a);

		// Token: 0x06000151 RID: 337
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern uint Internal_ToPackedABGR(in FColor a);

		// Token: 0x06000152 RID: 338
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern uint Internal_ToPackedRGBA(in FColor a);

		// Token: 0x06000153 RID: 339
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern uint Internal_ToPackedBGRA(in FColor a);

		// Token: 0x06000154 RID: 340
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_InitFromString(ref FColor a, in FCSharpStringView b);

		// Token: 0x06000155 RID: 341 RVA: 0x00006D4C File Offset: 0x00004F4C
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

		// Token: 0x06000156 RID: 342 RVA: 0x00006D94 File Offset: 0x00004F94
		public static FColor MakeRandomColor()
		{
			FColor result;
			FColor.Internal_MakeRandomColor(out result);
			return result;
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00006DA9 File Offset: 0x00004FA9
		public static FColor MakeRedToGreenColorFromScalar(float scalar)
		{
			return FColor.Internal_MakeRedToGreenColorFromScalar(scalar);
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00006DB1 File Offset: 0x00004FB1
		public static FColor MakeFromColorTemperature(float temp)
		{
			return FColor.Internal_MakeFromColorTemperature(temp);
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00006DBC File Offset: 0x00004FBC
		public unsafe static FColor operator +(FColor a, in FColor b)
		{
			fixed (FColor* ptr = &b)
			{
				FColor.Internal_Add(ref a, b);
			}
			return a;
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00006DDC File Offset: 0x00004FDC
		public unsafe readonly FLinearColor FromRGBE()
		{
			fixed (FColor* ptr = &this)
			{
				return FColor.Internal_FromRGBE(this);
			}
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00006DF4 File Offset: 0x00004FF4
		public unsafe readonly FColor WithAlpha(byte alpha)
		{
			fixed (FColor* ptr = &this)
			{
				return FColor.Internal_WithAlpha(this, alpha);
			}
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00006E0C File Offset: 0x0000500C
		public unsafe readonly FLinearColor ReinterpretAsLinear()
		{
			fixed (FColor* ptr = &this)
			{
				return FColor.Internal_ReinterpretAsLinear(this);
			}
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00006E24 File Offset: 0x00005024
		public unsafe readonly uint ToPackedARGB()
		{
			fixed (FColor* ptr = &this)
			{
				return FColor.Internal_ToPackedARGB(this);
			}
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00006E3C File Offset: 0x0000503C
		public unsafe readonly uint ToPackedABGR()
		{
			fixed (FColor* ptr = &this)
			{
				return FColor.Internal_ToPackedABGR(this);
			}
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00006E54 File Offset: 0x00005054
		public unsafe readonly uint ToPackedRGBA()
		{
			fixed (FColor* ptr = &this)
			{
				return FColor.Internal_ToPackedRGBA(this);
			}
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00006E6C File Offset: 0x0000506C
		public unsafe readonly uint ToPackedBGRA()
		{
			fixed (FColor* ptr = &this)
			{
				return FColor.Internal_ToPackedBGRA(this);
			}
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00006E84 File Offset: 0x00005084
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

		// Token: 0x06000162 RID: 354 RVA: 0x00006EED File Offset: 0x000050ED
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FColor._ScriptStructPtr != 0) ? FColor._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.Color", ref FColor._ScriptStructPtr);
		}

		// Token: 0x0400006D RID: 109
		[FieldOffset(0)]
		public byte B;

		// Token: 0x0400006E RID: 110
		[FieldOffset(1)]
		public byte G;

		// Token: 0x0400006F RID: 111
		[FieldOffset(2)]
		public byte R;

		// Token: 0x04000070 RID: 112
		[FieldOffset(3)]
		public byte A;

		// Token: 0x04000071 RID: 113
		public static readonly FColor White = new FColor(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue);

		// Token: 0x04000072 RID: 114
		public static readonly FColor Black = new FColor(0, 0, 0, byte.MaxValue);

		// Token: 0x04000073 RID: 115
		public static readonly FColor Transparent = new FColor(0, 0, 0, 0);

		// Token: 0x04000074 RID: 116
		public static readonly FColor Red = new FColor(byte.MaxValue, 0, 0, byte.MaxValue);

		// Token: 0x04000075 RID: 117
		public static readonly FColor Green = new FColor(0, byte.MaxValue, 0, byte.MaxValue);

		// Token: 0x04000076 RID: 118
		public static readonly FColor Blue = new FColor(0, 0, byte.MaxValue, byte.MaxValue);

		// Token: 0x04000077 RID: 119
		public static readonly FColor Yellow = new FColor(byte.MaxValue, byte.MaxValue, 0, byte.MaxValue);

		// Token: 0x04000078 RID: 120
		public static readonly FColor Cyan = new FColor(0, byte.MaxValue, byte.MaxValue, byte.MaxValue);

		// Token: 0x04000079 RID: 121
		public static readonly FColor Magenta = new FColor(byte.MaxValue, 0, byte.MaxValue, byte.MaxValue);

		// Token: 0x0400007A RID: 122
		public static readonly FColor Orange = new FColor(243, 156, 18, byte.MaxValue);

		// Token: 0x0400007B RID: 123
		public static readonly FColor Purple = new FColor(169, 7, 228, byte.MaxValue);

		// Token: 0x0400007C RID: 124
		public static readonly FColor Turquoise = new FColor(26, 188, 156, byte.MaxValue);

		// Token: 0x0400007D RID: 125
		public static readonly FColor Silver = new FColor(189, 195, 199, byte.MaxValue);

		// Token: 0x0400007E RID: 126
		public static readonly FColor Emerald = new FColor(46, 204, 113, byte.MaxValue);

		// Token: 0x0400007F RID: 127
		public const string __ObjectPath = "/Script/CoreUObject.Color";

		// Token: 0x04000080 RID: 128
		private static IntPtr _ScriptStructPtr;
	}
}
