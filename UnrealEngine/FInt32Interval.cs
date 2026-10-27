using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000029 RID: 41
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 8)]
	[UnrealObjectPath("/Script/CoreUObject.Int32Interval")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 8)]
	public struct FInt32Interval : IEquatable<FInt32Interval>, IEqualityOperators<FInt32Interval, FInt32Interval, bool>, IUnrealScriptStruct
	{
		// Token: 0x060001A0 RID: 416 RVA: 0x000075A3 File Offset: 0x000057A3
		public FInt32Interval()
		{
			this.Min = int.MaxValue;
			this.Max = int.MinValue;
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x000075BB File Offset: 0x000057BB
		public FInt32Interval(int min, int max)
		{
			this.Min = min;
			this.Max = max;
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x000075CB File Offset: 0x000057CB
		public readonly bool Equals(FInt32Interval other)
		{
			return this == other;
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x000075DC File Offset: 0x000057DC
		[NullableContext(2)]
		public override readonly bool Equals(object obj)
		{
			if (obj is FInt32Interval)
			{
				FInt32Interval right = (FInt32Interval)obj;
				return this == right;
			}
			return false;
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00007606 File Offset: 0x00005806
		public override readonly int GetHashCode()
		{
			return HashCode.Combine<int, int>(this.Min, this.Max);
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x0000761C File Offset: 0x0000581C
		[NullableContext(1)]
		public override readonly string ToString()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 2);
			defaultInterpolatedStringHandler.AppendLiteral("Min=");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.Min);
			defaultInterpolatedStringHandler.AppendLiteral(", Max=");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.Max);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x0000766C File Offset: 0x0000586C
		public static bool operator ==(FInt32Interval left, FInt32Interval right)
		{
			return left.Min == right.Min && left.Max == right.Max;
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x0000768C File Offset: 0x0000588C
		public static bool operator !=(FInt32Interval left, FInt32Interval right)
		{
			return left.Min != right.Min || left.Max != right.Max;
		}

		// Token: 0x060001A8 RID: 424
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Add(ref FInt32Interval a, int b);

		// Token: 0x060001A9 RID: 425
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Subtract(ref FInt32Interval a, int b);

		// Token: 0x060001AA RID: 426
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int Internal_Size(in FInt32Interval a);

		// Token: 0x060001AB RID: 427
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IsValid(in FInt32Interval a);

		// Token: 0x060001AC RID: 428
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_Contains(in FInt32Interval a, int b);

		// Token: 0x060001AD RID: 429
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Expand(ref FInt32Interval a, int b);

		// Token: 0x060001AE RID: 430
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Include(ref FInt32Interval a, int b);

		// Token: 0x060001AF RID: 431
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int Internal_Interpolate(in FInt32Interval a, float b);

		// Token: 0x060001B0 RID: 432
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FInt32Interval Internal_Intersect(in FInt32Interval a, in FInt32Interval b);

		// Token: 0x060001B1 RID: 433 RVA: 0x000076B0 File Offset: 0x000058B0
		public unsafe void Add(int x)
		{
			fixed (FInt32Interval* ptr = &this)
			{
				FInt32Interval.Internal_Add(ref this, x);
			}
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x000076CC File Offset: 0x000058CC
		public unsafe void Subtract(int x)
		{
			fixed (FInt32Interval* ptr = &this)
			{
				FInt32Interval.Internal_Subtract(ref this, x);
			}
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x000076E8 File Offset: 0x000058E8
		public unsafe readonly int Size()
		{
			fixed (FInt32Interval* ptr = &this)
			{
				return FInt32Interval.Internal_Size(this);
			}
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00007700 File Offset: 0x00005900
		public unsafe readonly bool IsValid()
		{
			fixed (FInt32Interval* ptr = &this)
			{
				return FInt32Interval.Internal_IsValid(this);
			}
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00007718 File Offset: 0x00005918
		public unsafe readonly bool Contains(int element)
		{
			fixed (FInt32Interval* ptr = &this)
			{
				return FInt32Interval.Internal_Contains(this, element);
			}
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00007730 File Offset: 0x00005930
		public unsafe void Expand(int expandAmount)
		{
			fixed (FInt32Interval* ptr = &this)
			{
				FInt32Interval.Internal_Expand(ref this, expandAmount);
			}
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x0000774C File Offset: 0x0000594C
		public unsafe void Include(int x)
		{
			fixed (FInt32Interval* ptr = &this)
			{
				FInt32Interval.Internal_Include(ref this, x);
			}
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00007768 File Offset: 0x00005968
		public unsafe readonly int Interpolate(float alpha)
		{
			fixed (FInt32Interval* ptr = &this)
			{
				return FInt32Interval.Internal_Interpolate(this, alpha);
			}
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00007780 File Offset: 0x00005980
		public unsafe static FInt32Interval Intersect(in FInt32Interval a, in FInt32Interval b)
		{
			fixed (FInt32Interval* ptr = &a)
			{
				fixed (FInt32Interval* ptr2 = &b)
				{
					return FInt32Interval.Internal_Intersect(a, b);
				}
			}
		}

		// Token: 0x060001BA RID: 442 RVA: 0x0000779C File Offset: 0x0000599C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FInt32Interval._ScriptStructPtr != 0) ? FInt32Interval._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.Int32Interval", ref FInt32Interval._ScriptStructPtr);
		}

		// Token: 0x04000097 RID: 151
		public static readonly FInt32Interval Invalid = new FInt32Interval();

		// Token: 0x04000098 RID: 152
		[FieldOffset(0)]
		public int Min;

		// Token: 0x04000099 RID: 153
		[FieldOffset(4)]
		public int Max;

		// Token: 0x0400009A RID: 154
		public const string __ObjectPath = "/Script/CoreUObject.Int32Interval";

		// Token: 0x0400009B RID: 155
		private static IntPtr _ScriptStructPtr;
	}
}
