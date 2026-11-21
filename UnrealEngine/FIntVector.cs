using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000010 RID: 16
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 12)]
	[UnrealObjectPath("/Script/CoreUObject.IntVector")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 12)]
	public struct FIntVector : IEquatable<FIntVector>, IEqualityOperators<FIntVector, FIntVector, bool>, IUnrealScriptStruct
	{
		// Token: 0x0600016D RID: 365 RVA: 0x0000435E File Offset: 0x0000255E
		public FIntVector()
		{
			this.X = 0;
			this.Y = 0;
			this.Z = 0;
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00004375 File Offset: 0x00002575
		public FIntVector(int x, int y, int z)
		{
			this.X = x;
			this.Y = y;
			this.Z = z;
		}

		// Token: 0x0600016F RID: 367 RVA: 0x0000438C File Offset: 0x0000258C
		public FIntVector(int value)
		{
			this.X = value;
			this.Y = value;
			this.Z = value;
		}

		// Token: 0x06000170 RID: 368 RVA: 0x000043A3 File Offset: 0x000025A3
		public FIntVector(in FVector v)
		{
			this.X = (int)v.X;
			this.Y = (int)v.Y;
			this.Z = (int)v.Z;
		}

		// Token: 0x17000004 RID: 4
		public int this[int index]
		{
			readonly get
			{
				int result;
				switch (index)
				{
				case 0:
					result = this.X;
					break;
				case 1:
					result = this.Y;
					break;
				case 2:
					result = this.Z;
					break;
				default:
					throw new IndexOutOfRangeException();
				}
				return result;
			}
			set
			{
				switch (index)
				{
				case 0:
					this.X = value;
					return;
				case 1:
					this.Y = value;
					return;
				case 2:
					this.Z = value;
					return;
				default:
					throw new IndexOutOfRangeException();
				}
			}
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00004442 File Offset: 0x00002642
		public static bool operator ==(FIntVector a, FIntVector b)
		{
			return a.X == b.X && a.Y == b.Y && a.Z == b.Z;
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00004470 File Offset: 0x00002670
		public static bool operator !=(FIntVector a, FIntVector b)
		{
			return a.X != b.X || a.Y != b.Y || a.Z != b.Z;
		}

		// Token: 0x06000175 RID: 373 RVA: 0x000044A1 File Offset: 0x000026A1
		public readonly bool Equals(FIntVector other)
		{
			return this == other;
		}

		// Token: 0x06000176 RID: 374 RVA: 0x000044B0 File Offset: 0x000026B0
		[NullableContext(2)]
		public override readonly bool Equals(object obj)
		{
			if (obj is FIntVector)
			{
				FIntVector b = (FIntVector)obj;
				return this == b;
			}
			return false;
		}

		// Token: 0x06000177 RID: 375 RVA: 0x000044DA File Offset: 0x000026DA
		public override readonly int GetHashCode()
		{
			return HashCode.Combine<int, int, int>(this.X, this.Y, this.Z);
		}

		// Token: 0x06000178 RID: 376 RVA: 0x000044F4 File Offset: 0x000026F4
		[NullableContext(1)]
		public override readonly string ToString()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(8, 3);
			defaultInterpolatedStringHandler.AppendLiteral("X=");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.X);
			defaultInterpolatedStringHandler.AppendLiteral(" Y=");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.Y);
			defaultInterpolatedStringHandler.AppendLiteral(" Z=");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.Z);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x06000179 RID: 377 RVA: 0x0000455C File Offset: 0x0000275C
		public static int Num()
		{
			return 3;
		}

		// Token: 0x0600017A RID: 378
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FIntVector Internal_Add(in FIntVector a, in FIntVector b);

		// Token: 0x0600017B RID: 379
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FIntVector Internal_Sub(in FIntVector a, in FIntVector b);

		// Token: 0x0600017C RID: 380
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FIntVector Internal_Mul(in FIntVector a, int b);

		// Token: 0x0600017D RID: 381
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FIntVector Internal_Div(in FIntVector a, int b);

		// Token: 0x0600017E RID: 382
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FIntVector Internal_LShift(in FIntVector a, int b);

		// Token: 0x0600017F RID: 383
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FIntVector Internal_RShift(in FIntVector a, int b);

		// Token: 0x06000180 RID: 384
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FIntVector Internal_And(in FIntVector a, int b);

		// Token: 0x06000181 RID: 385
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FIntVector Internal_Or(in FIntVector a, int b);

		// Token: 0x06000182 RID: 386
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FIntVector Internal_Xor(in FIntVector a, int b);

		// Token: 0x06000183 RID: 387
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IsZero(in FIntVector a);

		// Token: 0x06000184 RID: 388
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int Internal_GetMax(in FIntVector a);

		// Token: 0x06000185 RID: 389
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int Internal_GetMin(in FIntVector a);

		// Token: 0x06000186 RID: 390
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int Internal_Size(in FIntVector a);

		// Token: 0x06000187 RID: 391
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FIntVector Internal_DivideAndRoundUp_Int(in FIntVector a, int b);

		// Token: 0x06000188 RID: 392
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FIntVector Internal_DivideAndRoundUp(in FIntVector a, in FIntVector b);

		// Token: 0x06000189 RID: 393 RVA: 0x00004560 File Offset: 0x00002760
		public unsafe static FIntVector operator +(in FIntVector a, in FIntVector b)
		{
			fixed (FIntVector* ptr = &a)
			{
				fixed (FIntVector* ptr2 = &b)
				{
					return FIntVector.Internal_Add(a, b);
				}
			}
		}

		// Token: 0x0600018A RID: 394 RVA: 0x0000457C File Offset: 0x0000277C
		public unsafe static FIntVector operator -(in FIntVector a, in FIntVector b)
		{
			fixed (FIntVector* ptr = &a)
			{
				fixed (FIntVector* ptr2 = &b)
				{
					return FIntVector.Internal_Sub(a, b);
				}
			}
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00004598 File Offset: 0x00002798
		public unsafe static FIntVector operator *(in FIntVector a, int b)
		{
			fixed (FIntVector* ptr = &a)
			{
				return FIntVector.Internal_Mul(a, b);
			}
		}

		// Token: 0x0600018C RID: 396 RVA: 0x000045B0 File Offset: 0x000027B0
		public unsafe static FIntVector operator /(in FIntVector a, int b)
		{
			fixed (FIntVector* ptr = &a)
			{
				return FIntVector.Internal_Div(a, b);
			}
		}

		// Token: 0x0600018D RID: 397 RVA: 0x000045C8 File Offset: 0x000027C8
		public unsafe static FIntVector operator <<(in FIntVector a, int b)
		{
			fixed (FIntVector* ptr = &a)
			{
				return FIntVector.Internal_LShift(a, b);
			}
		}

		// Token: 0x0600018E RID: 398 RVA: 0x000045E0 File Offset: 0x000027E0
		public unsafe static FIntVector operator >>(in FIntVector a, int b)
		{
			fixed (FIntVector* ptr = &a)
			{
				return FIntVector.Internal_RShift(a, b);
			}
		}

		// Token: 0x0600018F RID: 399 RVA: 0x000045F8 File Offset: 0x000027F8
		public unsafe static FIntVector operator &(in FIntVector a, int b)
		{
			fixed (FIntVector* ptr = &a)
			{
				return FIntVector.Internal_And(a, b);
			}
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00004610 File Offset: 0x00002810
		public unsafe static FIntVector operator |(in FIntVector a, int b)
		{
			fixed (FIntVector* ptr = &a)
			{
				return FIntVector.Internal_Or(a, b);
			}
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00004628 File Offset: 0x00002828
		public unsafe static FIntVector operator ^(in FIntVector a, int b)
		{
			fixed (FIntVector* ptr = &a)
			{
				return FIntVector.Internal_Xor(a, b);
			}
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00004640 File Offset: 0x00002840
		public unsafe readonly bool IsZero()
		{
			fixed (FIntVector* ptr = &this)
			{
				return FIntVector.Internal_IsZero(this);
			}
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00004658 File Offset: 0x00002858
		public unsafe readonly int GetMax()
		{
			fixed (FIntVector* ptr = &this)
			{
				return FIntVector.Internal_GetMax(this);
			}
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00004670 File Offset: 0x00002870
		public unsafe readonly int GetMin()
		{
			fixed (FIntVector* ptr = &this)
			{
				return FIntVector.Internal_GetMin(this);
			}
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00004688 File Offset: 0x00002888
		public unsafe readonly int Size()
		{
			fixed (FIntVector* ptr = &this)
			{
				return FIntVector.Internal_Size(this);
			}
		}

		// Token: 0x06000196 RID: 406 RVA: 0x000046A0 File Offset: 0x000028A0
		public unsafe static FIntVector DivideAndRoundUp(in FIntVector a, int b)
		{
			fixed (FIntVector* ptr = &a)
			{
				return FIntVector.Internal_DivideAndRoundUp_Int(a, b);
			}
		}

		// Token: 0x06000197 RID: 407 RVA: 0x000046B8 File Offset: 0x000028B8
		public unsafe static FIntVector DivideAndRoundUp(in FIntVector a, in FIntVector b)
		{
			fixed (FIntVector* ptr = &a)
			{
				fixed (FIntVector* ptr2 = &b)
				{
					return FIntVector.Internal_DivideAndRoundUp(a, b);
				}
			}
		}

		// Token: 0x06000198 RID: 408 RVA: 0x000046D4 File Offset: 0x000028D4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FIntVector._ScriptStructPtr != 0) ? FIntVector._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.IntVector", ref FIntVector._ScriptStructPtr);
		}

		// Token: 0x0400005B RID: 91
		public static readonly FIntVector ZeroValue = new FIntVector(0, 0, 0);

		// Token: 0x0400005C RID: 92
		public static readonly FIntVector NoneValue = new FIntVector(-1, -1, -1);

		// Token: 0x0400005D RID: 93
		[FieldOffset(0)]
		public int X;

		// Token: 0x0400005E RID: 94
		[FieldOffset(4)]
		public int Y;

		// Token: 0x0400005F RID: 95
		[FieldOffset(8)]
		public int Z;

		// Token: 0x04000060 RID: 96
		public const string __ObjectPath = "/Script/CoreUObject.IntVector";

		// Token: 0x04000061 RID: 97
		private static IntPtr _ScriptStructPtr;
	}
}
