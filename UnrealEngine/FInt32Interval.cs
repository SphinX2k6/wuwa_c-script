using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200000E RID: 14
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 8)]
	[UnrealObjectPath("/Script/CoreUObject.Int32Interval")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 8)]
	public struct FInt32Interval : IEquatable<FInt32Interval>, IEqualityOperators<FInt32Interval, FInt32Interval, bool>, IUnrealScriptStruct
	{
		// Token: 0x06000125 RID: 293 RVA: 0x00003E0F File Offset: 0x0000200F
		public FInt32Interval()
		{
			this.Min = int.MaxValue;
			this.Max = int.MinValue;
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00003E27 File Offset: 0x00002027
		public FInt32Interval(int min, int max)
		{
			this.Min = min;
			this.Max = max;
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00003E37 File Offset: 0x00002037
		public readonly bool Equals(FInt32Interval other)
		{
			return this == other;
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00003E48 File Offset: 0x00002048
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

		// Token: 0x06000129 RID: 297 RVA: 0x00003E72 File Offset: 0x00002072
		public override readonly int GetHashCode()
		{
			return HashCode.Combine<int, int>(this.Min, this.Max);
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00003E88 File Offset: 0x00002088
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

		// Token: 0x0600012B RID: 299 RVA: 0x00003ED8 File Offset: 0x000020D8
		public static bool operator ==(FInt32Interval left, FInt32Interval right)
		{
			return left.Min == right.Min && left.Max == right.Max;
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00003EF8 File Offset: 0x000020F8
		public static bool operator !=(FInt32Interval left, FInt32Interval right)
		{
			return left.Min != right.Min || left.Max != right.Max;
		}

		// Token: 0x0600012D RID: 301
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Add(ref FInt32Interval a, int b);

		// Token: 0x0600012E RID: 302
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Subtract(ref FInt32Interval a, int b);

		// Token: 0x0600012F RID: 303
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int Internal_Size(in FInt32Interval a);

		// Token: 0x06000130 RID: 304
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IsValid(in FInt32Interval a);

		// Token: 0x06000131 RID: 305
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_Contains(in FInt32Interval a, int b);

		// Token: 0x06000132 RID: 306
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Expand(ref FInt32Interval a, int b);

		// Token: 0x06000133 RID: 307
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Include(ref FInt32Interval a, int b);

		// Token: 0x06000134 RID: 308
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int Internal_Interpolate(in FInt32Interval a, float b);

		// Token: 0x06000135 RID: 309
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FInt32Interval Internal_Intersect(in FInt32Interval a, in FInt32Interval b);

		// Token: 0x06000136 RID: 310 RVA: 0x00003F1C File Offset: 0x0000211C
		public unsafe void Add(int x)
		{
			fixed (FInt32Interval* ptr = &this)
			{
				FInt32Interval.Internal_Add(ref this, x);
			}
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00003F38 File Offset: 0x00002138
		public unsafe void Subtract(int x)
		{
			fixed (FInt32Interval* ptr = &this)
			{
				FInt32Interval.Internal_Subtract(ref this, x);
			}
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00003F54 File Offset: 0x00002154
		public unsafe readonly int Size()
		{
			fixed (FInt32Interval* ptr = &this)
			{
				return FInt32Interval.Internal_Size(this);
			}
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00003F6C File Offset: 0x0000216C
		public unsafe readonly bool IsValid()
		{
			fixed (FInt32Interval* ptr = &this)
			{
				return FInt32Interval.Internal_IsValid(this);
			}
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00003F84 File Offset: 0x00002184
		public unsafe readonly bool Contains(int element)
		{
			fixed (FInt32Interval* ptr = &this)
			{
				return FInt32Interval.Internal_Contains(this, element);
			}
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00003F9C File Offset: 0x0000219C
		public unsafe void Expand(int expandAmount)
		{
			fixed (FInt32Interval* ptr = &this)
			{
				FInt32Interval.Internal_Expand(ref this, expandAmount);
			}
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00003FB8 File Offset: 0x000021B8
		public unsafe void Include(int x)
		{
			fixed (FInt32Interval* ptr = &this)
			{
				FInt32Interval.Internal_Include(ref this, x);
			}
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00003FD4 File Offset: 0x000021D4
		public unsafe readonly int Interpolate(float alpha)
		{
			fixed (FInt32Interval* ptr = &this)
			{
				return FInt32Interval.Internal_Interpolate(this, alpha);
			}
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00003FEC File Offset: 0x000021EC
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

		// Token: 0x0600013F RID: 319 RVA: 0x00004008 File Offset: 0x00002208
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FInt32Interval._ScriptStructPtr != 0) ? FInt32Interval._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.Int32Interval", ref FInt32Interval._ScriptStructPtr);
		}

		// Token: 0x04000050 RID: 80
		public static readonly FInt32Interval Invalid = new FInt32Interval();

		// Token: 0x04000051 RID: 81
		[FieldOffset(0)]
		public int Min;

		// Token: 0x04000052 RID: 82
		[FieldOffset(4)]
		public int Max;

		// Token: 0x04000053 RID: 83
		public const string __ObjectPath = "/Script/CoreUObject.Int32Interval";

		// Token: 0x04000054 RID: 84
		private static IntPtr _ScriptStructPtr;
	}
}
