using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200000F RID: 15
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 8)]
	[UnrealObjectPath("/Script/CoreUObject.IntPoint")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 8)]
	public struct FIntPoint : IEquatable<FIntPoint>, IEqualityOperators<FIntPoint, FIntPoint, bool>, IUnrealScriptStruct
	{
		// Token: 0x06000141 RID: 321 RVA: 0x00004038 File Offset: 0x00002238
		public FIntPoint()
		{
			this.X = 0;
			this.Y = 0;
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00004048 File Offset: 0x00002248
		public FIntPoint(int inX, int inY)
		{
			this.X = inX;
			this.Y = inY;
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00004058 File Offset: 0x00002258
		public FIntPoint(int inXy)
		{
			this.X = inXy;
			this.Y = inXy;
		}

		// Token: 0x17000003 RID: 3
		public int this[int index]
		{
			readonly get
			{
				int result;
				if (index != 0)
				{
					if (index != 1)
					{
						throw new IndexOutOfRangeException();
					}
					result = this.Y;
				}
				else
				{
					result = this.X;
				}
				return result;
			}
			set
			{
				if (index == 0)
				{
					this.X = value;
					return;
				}
				if (index != 1)
				{
					throw new IndexOutOfRangeException();
				}
				this.Y = value;
			}
		}

		// Token: 0x06000146 RID: 326 RVA: 0x000040B8 File Offset: 0x000022B8
		[NullableContext(1)]
		public override readonly string ToString()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 2);
			defaultInterpolatedStringHandler.AppendLiteral("X=");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.X);
			defaultInterpolatedStringHandler.AppendLiteral(" Y=");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.Y);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00004108 File Offset: 0x00002308
		[NullableContext(2)]
		public override readonly bool Equals(object obj)
		{
			if (obj is FIntPoint)
			{
				FIntPoint b = (FIntPoint)obj;
				return this == b;
			}
			return false;
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00004132 File Offset: 0x00002332
		public readonly bool Equals(FIntPoint other)
		{
			return this == other;
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00004140 File Offset: 0x00002340
		public override readonly int GetHashCode()
		{
			return HashCode.Combine<int, int>(this.X, this.Y);
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00004153 File Offset: 0x00002353
		public static bool operator ==(FIntPoint a, FIntPoint b)
		{
			return a.X == b.X && a.Y == b.Y;
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00004173 File Offset: 0x00002373
		public static bool operator !=(FIntPoint a, FIntPoint b)
		{
			return a.X != b.X || a.Y != b.Y;
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00004196 File Offset: 0x00002396
		public static int Num()
		{
			return 2;
		}

		// Token: 0x0600014D RID: 333
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FIntPoint Internal_Add(in FIntPoint a, in FIntPoint b);

		// Token: 0x0600014E RID: 334
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FIntPoint Internal_Sub(in FIntPoint a, in FIntPoint b);

		// Token: 0x0600014F RID: 335
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FIntPoint Internal_Mul(in FIntPoint a, in FIntPoint b);

		// Token: 0x06000150 RID: 336
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FIntPoint Internal_MulInt(in FIntPoint a, int I);

		// Token: 0x06000151 RID: 337
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FIntPoint Internal_Div(in FIntPoint a, in FIntPoint b);

		// Token: 0x06000152 RID: 338
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FIntPoint Internal_DivInt(in FIntPoint a, int I);

		// Token: 0x06000153 RID: 339
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FIntPoint Internal_ComponentMin(in FIntPoint a, in FIntPoint b);

		// Token: 0x06000154 RID: 340
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FIntPoint Internal_ComponentMax(in FIntPoint a, in FIntPoint b);

		// Token: 0x06000155 RID: 341
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int Internal_GetMax(in FIntPoint a);

		// Token: 0x06000156 RID: 342
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int Internal_GetMin(in FIntPoint a);

		// Token: 0x06000157 RID: 343
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int Internal_Size(in FIntPoint a);

		// Token: 0x06000158 RID: 344
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int Internal_SizeSquared(in FIntPoint a);

		// Token: 0x06000159 RID: 345
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FIntPoint Internal_DivideAndRoundUp_Int(in FIntPoint a, int I);

		// Token: 0x0600015A RID: 346
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FIntPoint Internal_DivideAndRoundUp(in FIntPoint a, in FIntPoint b);

		// Token: 0x0600015B RID: 347
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FIntPoint Internal_DivideAndRoundDown(in FIntPoint a, int I);

		// Token: 0x0600015C RID: 348 RVA: 0x0000419C File Offset: 0x0000239C
		public unsafe static FIntPoint operator +(in FIntPoint a, in FIntPoint b)
		{
			fixed (FIntPoint* ptr = &a)
			{
				fixed (FIntPoint* ptr2 = &b)
				{
					return FIntPoint.Internal_Add(a, b);
				}
			}
		}

		// Token: 0x0600015D RID: 349 RVA: 0x000041B8 File Offset: 0x000023B8
		public unsafe static FIntPoint operator -(in FIntPoint a, in FIntPoint b)
		{
			fixed (FIntPoint* ptr = &a)
			{
				fixed (FIntPoint* ptr2 = &b)
				{
					return FIntPoint.Internal_Sub(a, b);
				}
			}
		}

		// Token: 0x0600015E RID: 350 RVA: 0x000041D4 File Offset: 0x000023D4
		public unsafe static FIntPoint operator *(in FIntPoint a, in FIntPoint b)
		{
			fixed (FIntPoint* ptr = &a)
			{
				fixed (FIntPoint* ptr2 = &b)
				{
					return FIntPoint.Internal_Mul(a, b);
				}
			}
		}

		// Token: 0x0600015F RID: 351 RVA: 0x000041F0 File Offset: 0x000023F0
		public unsafe static FIntPoint operator *(in FIntPoint a, int scale)
		{
			fixed (FIntPoint* ptr = &a)
			{
				return FIntPoint.Internal_MulInt(a, scale);
			}
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00004208 File Offset: 0x00002408
		public unsafe static FIntPoint operator /(in FIntPoint a, in FIntPoint b)
		{
			fixed (FIntPoint* ptr = &a)
			{
				fixed (FIntPoint* ptr2 = &b)
				{
					return FIntPoint.Internal_Div(a, b);
				}
			}
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00004224 File Offset: 0x00002424
		public unsafe static FIntPoint operator /(in FIntPoint a, int divisor)
		{
			fixed (FIntPoint* ptr = &a)
			{
				return FIntPoint.Internal_DivInt(a, divisor);
			}
		}

		// Token: 0x06000162 RID: 354 RVA: 0x0000423C File Offset: 0x0000243C
		public unsafe readonly FIntPoint ComponentMin(in FIntPoint other)
		{
			fixed (FIntPoint* ptr = &this)
			{
				fixed (FIntPoint* ptr2 = &other)
				{
					return FIntPoint.Internal_ComponentMin(this, other);
				}
			}
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00004258 File Offset: 0x00002458
		public unsafe readonly FIntPoint ComponentMax(in FIntPoint other)
		{
			fixed (FIntPoint* ptr = &this)
			{
				fixed (FIntPoint* ptr2 = &other)
				{
					return FIntPoint.Internal_ComponentMax(this, other);
				}
			}
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00004274 File Offset: 0x00002474
		public unsafe readonly int GetMax()
		{
			fixed (FIntPoint* ptr = &this)
			{
				return FIntPoint.Internal_GetMax(this);
			}
		}

		// Token: 0x06000165 RID: 357 RVA: 0x0000428C File Offset: 0x0000248C
		public unsafe readonly int GetMin()
		{
			fixed (FIntPoint* ptr = &this)
			{
				return FIntPoint.Internal_GetMin(this);
			}
		}

		// Token: 0x06000166 RID: 358 RVA: 0x000042A4 File Offset: 0x000024A4
		public unsafe readonly int Size()
		{
			fixed (FIntPoint* ptr = &this)
			{
				return FIntPoint.Internal_Size(this);
			}
		}

		// Token: 0x06000167 RID: 359 RVA: 0x000042BC File Offset: 0x000024BC
		public unsafe readonly int SizeSquared()
		{
			fixed (FIntPoint* ptr = &this)
			{
				return FIntPoint.Internal_SizeSquared(this);
			}
		}

		// Token: 0x06000168 RID: 360 RVA: 0x000042D4 File Offset: 0x000024D4
		public unsafe static FIntPoint DivideAndRoundUp(in FIntPoint a, int divisor)
		{
			fixed (FIntPoint* ptr = &a)
			{
				return FIntPoint.Internal_DivideAndRoundUp_Int(a, divisor);
			}
		}

		// Token: 0x06000169 RID: 361 RVA: 0x000042EC File Offset: 0x000024EC
		public unsafe static FIntPoint DivideAndRoundUp(in FIntPoint a, in FIntPoint divisor)
		{
			fixed (FIntPoint* ptr = &a)
			{
				fixed (FIntPoint* ptr2 = &divisor)
				{
					return FIntPoint.Internal_DivideAndRoundUp(a, divisor);
				}
			}
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00004308 File Offset: 0x00002508
		public unsafe static FIntPoint DivideAndRoundDown(in FIntPoint a, int divisor)
		{
			fixed (FIntPoint* ptr = &a)
			{
				return FIntPoint.Internal_DivideAndRoundDown(a, divisor);
			}
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00004320 File Offset: 0x00002520
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FIntPoint._ScriptStructPtr != 0) ? FIntPoint._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.IntPoint", ref FIntPoint._ScriptStructPtr);
		}

		// Token: 0x04000055 RID: 85
		public static readonly FIntPoint ZeroValue = new FIntPoint(0, 0);

		// Token: 0x04000056 RID: 86
		public static readonly FIntPoint NoneValue = new FIntPoint(-1, -1);

		// Token: 0x04000057 RID: 87
		[FieldOffset(0)]
		public int X;

		// Token: 0x04000058 RID: 88
		[FieldOffset(4)]
		public int Y;

		// Token: 0x04000059 RID: 89
		public const string __ObjectPath = "/Script/CoreUObject.IntPoint";

		// Token: 0x0400005A RID: 90
		private static IntPtr _ScriptStructPtr;
	}
}
