using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000026 RID: 38
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 8)]
	[UnrealObjectPath("/Script/CoreUObject.FloatInterval")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 8)]
	public struct FFloatInterval : IEquatable<FFloatInterval>, IEqualityOperators<FFloatInterval, FFloatInterval, bool>, IUnrealScriptStruct
	{
		// Token: 0x06000164 RID: 356 RVA: 0x00007075 File Offset: 0x00005275
		public FFloatInterval()
		{
			this.Min = float.MaxValue;
			this.Max = float.MinValue;
		}

		// Token: 0x06000165 RID: 357 RVA: 0x0000708D File Offset: 0x0000528D
		public FFloatInterval(float min, float max)
		{
			this.Min = min;
			this.Max = max;
		}

		// Token: 0x06000166 RID: 358 RVA: 0x0000709D File Offset: 0x0000529D
		public static bool operator ==(FFloatInterval left, FFloatInterval right)
		{
			return left.Min == right.Min && left.Max == right.Max;
		}

		// Token: 0x06000167 RID: 359 RVA: 0x000070BD File Offset: 0x000052BD
		public static bool operator !=(FFloatInterval left, FFloatInterval right)
		{
			return left.Min != right.Min || left.Max != right.Max;
		}

		// Token: 0x06000168 RID: 360 RVA: 0x000070E0 File Offset: 0x000052E0
		public readonly bool Equals(FFloatInterval other)
		{
			return this == other;
		}

		// Token: 0x06000169 RID: 361 RVA: 0x000070F0 File Offset: 0x000052F0
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

		// Token: 0x0600016A RID: 362 RVA: 0x0000711A File Offset: 0x0000531A
		public override readonly int GetHashCode()
		{
			return HashCode.Combine<float, float>(this.Min, this.Max);
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00007130 File Offset: 0x00005330
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

		// Token: 0x0600016C RID: 364
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Add(ref FFloatInterval a, float b);

		// Token: 0x0600016D RID: 365
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Subtract(ref FFloatInterval a, float b);

		// Token: 0x0600016E RID: 366
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_Size(in FFloatInterval a);

		// Token: 0x0600016F RID: 367
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IsValid(in FFloatInterval a);

		// Token: 0x06000170 RID: 368
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_Contains(in FFloatInterval a, float b);

		// Token: 0x06000171 RID: 369
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Expand(ref FFloatInterval a, float b);

		// Token: 0x06000172 RID: 370
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Include(ref FFloatInterval a, float b);

		// Token: 0x06000173 RID: 371
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_Interpolate(in FFloatInterval a, float b);

		// Token: 0x06000174 RID: 372
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FFloatInterval Internal_Intersect(in FFloatInterval a, in FFloatInterval b);

		// Token: 0x06000175 RID: 373 RVA: 0x00007180 File Offset: 0x00005380
		public unsafe void Add(float x)
		{
			fixed (FFloatInterval* ptr = &this)
			{
				FFloatInterval.Internal_Add(ref this, x);
			}
		}

		// Token: 0x06000176 RID: 374 RVA: 0x0000719C File Offset: 0x0000539C
		public unsafe void Subtract(float x)
		{
			fixed (FFloatInterval* ptr = &this)
			{
				FFloatInterval.Internal_Subtract(ref this, x);
			}
		}

		// Token: 0x06000177 RID: 375 RVA: 0x000071B8 File Offset: 0x000053B8
		public unsafe readonly float Size()
		{
			fixed (FFloatInterval* ptr = &this)
			{
				return FFloatInterval.Internal_Size(this);
			}
		}

		// Token: 0x06000178 RID: 376 RVA: 0x000071D0 File Offset: 0x000053D0
		public unsafe readonly bool IsValid()
		{
			fixed (FFloatInterval* ptr = &this)
			{
				return FFloatInterval.Internal_IsValid(this);
			}
		}

		// Token: 0x06000179 RID: 377 RVA: 0x000071E8 File Offset: 0x000053E8
		public unsafe readonly bool Contains(float element)
		{
			fixed (FFloatInterval* ptr = &this)
			{
				return FFloatInterval.Internal_Contains(this, element);
			}
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00007200 File Offset: 0x00005400
		public unsafe void Expand(float expandAmount)
		{
			fixed (FFloatInterval* ptr = &this)
			{
				FFloatInterval.Internal_Expand(ref this, expandAmount);
			}
		}

		// Token: 0x0600017B RID: 379 RVA: 0x0000721C File Offset: 0x0000541C
		public unsafe void Include(float x)
		{
			fixed (FFloatInterval* ptr = &this)
			{
				FFloatInterval.Internal_Include(ref this, x);
			}
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00007238 File Offset: 0x00005438
		public unsafe readonly float Interpolate(float alpha)
		{
			fixed (FFloatInterval* ptr = &this)
			{
				return FFloatInterval.Internal_Interpolate(this, alpha);
			}
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00007250 File Offset: 0x00005450
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

		// Token: 0x0600017E RID: 382 RVA: 0x0000726C File Offset: 0x0000546C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FFloatInterval._ScriptStructPtr != 0) ? FFloatInterval._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.FloatInterval", ref FFloatInterval._ScriptStructPtr);
		}

		// Token: 0x04000081 RID: 129
		public static readonly FFloatInterval Invalid = new FFloatInterval();

		// Token: 0x04000082 RID: 130
		[FieldOffset(0)]
		public float Min;

		// Token: 0x04000083 RID: 131
		[FieldOffset(4)]
		public float Max;

		// Token: 0x04000084 RID: 132
		public const string __ObjectPath = "/Script/CoreUObject.FloatInterval";

		// Token: 0x04000085 RID: 133
		private static IntPtr _ScriptStructPtr;
	}
}
