using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200000B RID: 11
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 8)]
	[UnrealObjectPath("/Script/CoreUObject.FloatInterval")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 8)]
	public struct FFloatInterval : IEquatable<FFloatInterval>, IEqualityOperators<FFloatInterval, FFloatInterval, bool>, IUnrealScriptStruct
	{
		// Token: 0x060000E9 RID: 233 RVA: 0x000038E1 File Offset: 0x00001AE1
		public FFloatInterval()
		{
			this.Min = float.MaxValue;
			this.Max = float.MinValue;
		}

		// Token: 0x060000EA RID: 234 RVA: 0x000038F9 File Offset: 0x00001AF9
		public FFloatInterval(float min, float max)
		{
			this.Min = min;
			this.Max = max;
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00003909 File Offset: 0x00001B09
		public static bool operator ==(FFloatInterval left, FFloatInterval right)
		{
			return left.Min == right.Min && left.Max == right.Max;
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00003929 File Offset: 0x00001B29
		public static bool operator !=(FFloatInterval left, FFloatInterval right)
		{
			return left.Min != right.Min || left.Max != right.Max;
		}

		// Token: 0x060000ED RID: 237 RVA: 0x0000394C File Offset: 0x00001B4C
		public readonly bool Equals(FFloatInterval other)
		{
			return this == other;
		}

		// Token: 0x060000EE RID: 238 RVA: 0x0000395C File Offset: 0x00001B5C
		[NullableContext(2)]
		public override readonly bool Equals(object obj)
		{
			if (obj is FFloatInterval)
			{
				FFloatInterval right = (FFloatInterval)obj;
				return this == right;
			}
			return false;
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00003986 File Offset: 0x00001B86
		public override readonly int GetHashCode()
		{
			return HashCode.Combine<float, float>(this.Min, this.Max);
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x0000399C File Offset: 0x00001B9C
		[NullableContext(1)]
		public override readonly string ToString()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 2);
			defaultInterpolatedStringHandler.AppendLiteral("Min=");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.Min);
			defaultInterpolatedStringHandler.AppendLiteral(", Max=");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.Max);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x060000F1 RID: 241
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Add(ref FFloatInterval a, float b);

		// Token: 0x060000F2 RID: 242
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Subtract(ref FFloatInterval a, float b);

		// Token: 0x060000F3 RID: 243
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_Size(in FFloatInterval a);

		// Token: 0x060000F4 RID: 244
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IsValid(in FFloatInterval a);

		// Token: 0x060000F5 RID: 245
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_Contains(in FFloatInterval a, float b);

		// Token: 0x060000F6 RID: 246
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Expand(ref FFloatInterval a, float b);

		// Token: 0x060000F7 RID: 247
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Include(ref FFloatInterval a, float b);

		// Token: 0x060000F8 RID: 248
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_Interpolate(in FFloatInterval a, float b);

		// Token: 0x060000F9 RID: 249
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FFloatInterval Internal_Intersect(in FFloatInterval a, in FFloatInterval b);

		// Token: 0x060000FA RID: 250 RVA: 0x000039EC File Offset: 0x00001BEC
		public unsafe void Add(float x)
		{
			fixed (FFloatInterval* ptr = &this)
			{
				FFloatInterval.Internal_Add(ref this, x);
			}
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00003A08 File Offset: 0x00001C08
		public unsafe void Subtract(float x)
		{
			fixed (FFloatInterval* ptr = &this)
			{
				FFloatInterval.Internal_Subtract(ref this, x);
			}
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00003A24 File Offset: 0x00001C24
		public unsafe readonly float Size()
		{
			fixed (FFloatInterval* ptr = &this)
			{
				return FFloatInterval.Internal_Size(this);
			}
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00003A3C File Offset: 0x00001C3C
		public unsafe readonly bool IsValid()
		{
			fixed (FFloatInterval* ptr = &this)
			{
				return FFloatInterval.Internal_IsValid(this);
			}
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00003A54 File Offset: 0x00001C54
		public unsafe readonly bool Contains(float element)
		{
			fixed (FFloatInterval* ptr = &this)
			{
				return FFloatInterval.Internal_Contains(this, element);
			}
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00003A6C File Offset: 0x00001C6C
		public unsafe void Expand(float expandAmount)
		{
			fixed (FFloatInterval* ptr = &this)
			{
				FFloatInterval.Internal_Expand(ref this, expandAmount);
			}
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00003A88 File Offset: 0x00001C88
		public unsafe void Include(float x)
		{
			fixed (FFloatInterval* ptr = &this)
			{
				FFloatInterval.Internal_Include(ref this, x);
			}
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00003AA4 File Offset: 0x00001CA4
		public unsafe readonly float Interpolate(float alpha)
		{
			fixed (FFloatInterval* ptr = &this)
			{
				return FFloatInterval.Internal_Interpolate(this, alpha);
			}
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00003ABC File Offset: 0x00001CBC
		public unsafe static FFloatInterval Intersect(in FFloatInterval a, in FFloatInterval b)
		{
			fixed (FFloatInterval* ptr = &a)
			{
				fixed (FFloatInterval* ptr2 = &b)
				{
					return FFloatInterval.Internal_Intersect(a, b);
				}
			}
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00003AD8 File Offset: 0x00001CD8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FFloatInterval._ScriptStructPtr != 0) ? FFloatInterval._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.FloatInterval", ref FFloatInterval._ScriptStructPtr);
		}

		// Token: 0x0400003A RID: 58
		public static readonly FFloatInterval Invalid = new FFloatInterval();

		// Token: 0x0400003B RID: 59
		[FieldOffset(0)]
		public float Min;

		// Token: 0x0400003C RID: 60
		[FieldOffset(4)]
		public float Max;

		// Token: 0x0400003D RID: 61
		public const string __ObjectPath = "/Script/CoreUObject.FloatInterval";

		// Token: 0x0400003E RID: 62
		private static IntPtr _ScriptStructPtr;
	}
}
