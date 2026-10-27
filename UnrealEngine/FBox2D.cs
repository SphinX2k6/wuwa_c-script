using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000023 RID: 35
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 20)]
	[UnrealObjectPath("/Script/CoreUObject.Box2D")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 20)]
	public struct FBox2D : IEquatable<FBox2D>, IEqualityOperators<FBox2D, FBox2D, bool>, IUnrealScriptStruct
	{
		// Token: 0x060000DA RID: 218 RVA: 0x0000631A File Offset: 0x0000451A
		public FBox2D()
		{
			this.Min = FVector2D.ZeroVector;
			this.Max = FVector2D.ZeroVector;
			this.bIsValid = false;
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00006339 File Offset: 0x00004539
		public FBox2D(in FVector2D inMin, in FVector2D inMax)
		{
			this.Min = inMin;
			this.Max = inMax;
			this.bIsValid = true;
		}

		// Token: 0x060000DC RID: 220 RVA: 0x0000635C File Offset: 0x0000455C
		public FBox2D(Span<FVector2D> points)
		{
			this = new FBox2D();
			for (int i = 0; i < points.Length; i++)
			{
				this = this + points[i];
			}
		}

		// Token: 0x060000DD RID: 221 RVA: 0x0000639A File Offset: 0x0000459A
		[NullableContext(1)]
		public FBox2D(FVector2D[] points)
		{
			this = new FBox2D(points.AsSpan<FVector2D>());
		}

		// Token: 0x060000DE RID: 222 RVA: 0x000063A8 File Offset: 0x000045A8
		[NullableContext(1)]
		public FBox2D(IEnumerable<FVector2D> points)
		{
			this = new FBox2D();
			foreach (FVector2D fvector2D in points)
			{
				this = this + fvector2D;
			}
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00006404 File Offset: 0x00004604
		public void Init()
		{
			this.Min = FVector2D.ZeroVector;
			this.Max = FVector2D.ZeroVector;
			this.bIsValid = false;
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00006423 File Offset: 0x00004623
		public readonly bool Equals(FBox2D other)
		{
			return this == other;
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00006434 File Offset: 0x00004634
		[NullableContext(2)]
		public override readonly bool Equals(object obj)
		{
			if (obj is FBox2D)
			{
				FBox2D b = (FBox2D)obj;
				return this == b;
			}
			return false;
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x0000645E File Offset: 0x0000465E
		public override readonly int GetHashCode()
		{
			return HashCode.Combine<FVector2D, FVector2D, bool>(this.Min, this.Max, this.bIsValid);
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00006478 File Offset: 0x00004678
		[NullableContext(1)]
		public override readonly string ToString()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 3);
			defaultInterpolatedStringHandler.AppendLiteral("bIsValid=");
			defaultInterpolatedStringHandler.AppendFormatted<bool>(this.bIsValid);
			defaultInterpolatedStringHandler.AppendLiteral(", Min=(");
			defaultInterpolatedStringHandler.AppendFormatted<FVector2D>(this.Min);
			defaultInterpolatedStringHandler.AppendLiteral("), Max=(");
			defaultInterpolatedStringHandler.AppendFormatted<FVector2D>(this.Max);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x060000E4 RID: 228
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_Eq(in FBox2D a, in FBox2D b);

		// Token: 0x060000E5 RID: 229
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBox2D Internal_Add_FVector2D(in FBox2D a, in FVector2D b);

		// Token: 0x060000E6 RID: 230
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBox2D Internal_Add_FBox2D(in FBox2D a, in FBox2D b);

		// Token: 0x060000E7 RID: 231
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_ComputeSquaredDistanceToPoint(in FBox2D a, in FVector2D b);

		// Token: 0x060000E8 RID: 232
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBox2D Internal_ExpandBy_Float(in FBox2D a, float b);

		// Token: 0x060000E9 RID: 233
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBox2D Internal_ExpandBy_FVector2D(in FBox2D a, in FVector2D b);

		// Token: 0x060000EA RID: 234
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_GetArea(in FBox2D a);

		// Token: 0x060000EB RID: 235
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D Internal_GetCenter(in FBox2D a);

		// Token: 0x060000EC RID: 236
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_GetCenterAndExtents(in FBox2D a, out FVector2D b, out FVector2D c);

		// Token: 0x060000ED RID: 237
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D Internal_GetClosestPointTo(in FBox2D a, in FVector2D b);

		// Token: 0x060000EE RID: 238
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D Internal_GetExtent(in FBox2D a);

		// Token: 0x060000EF RID: 239
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D Internal_GetSize(in FBox2D a);

		// Token: 0x060000F0 RID: 240
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBox2D Internal_Overlap(in FBox2D a, in FBox2D b);

		// Token: 0x060000F1 RID: 241
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_Intersect(in FBox2D a, in FBox2D b);

		// Token: 0x060000F2 RID: 242
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IsInsideOrOn(in FBox2D a, in FVector2D b);

		// Token: 0x060000F3 RID: 243
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IsInside_FVector2D(in FBox2D a, in FVector2D b);

		// Token: 0x060000F4 RID: 244
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IsInside_FBox2D(in FBox2D a, in FBox2D b);

		// Token: 0x060000F5 RID: 245
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBox2D Internal_ShiftBy(in FBox2D a, in FVector2D b);

		// Token: 0x060000F6 RID: 246 RVA: 0x000064ED File Offset: 0x000046ED
		public static bool operator ==(FBox2D a, FBox2D b)
		{
			return FBox2D.Internal_Eq(a, b);
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x000064F8 File Offset: 0x000046F8
		public static bool operator !=(FBox2D a, FBox2D b)
		{
			return !FBox2D.Internal_Eq(a, b);
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00006508 File Offset: 0x00004708
		public unsafe static FBox2D operator +(in FBox2D a, in FVector2D b)
		{
			fixed (FBox2D* ptr = &a)
			{
				fixed (FVector2D* ptr2 = &b)
				{
					return FBox2D.Internal_Add_FVector2D(a, b);
				}
			}
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00006524 File Offset: 0x00004724
		public unsafe static FBox2D operator +(in FBox2D a, in FBox2D b)
		{
			fixed (FBox2D* ptr = &a)
			{
				fixed (FBox2D* ptr2 = &b)
				{
					return FBox2D.Internal_Add_FBox2D(a, b);
				}
			}
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00006540 File Offset: 0x00004740
		public unsafe readonly float ComputeSquaredDistanceToPoint(in FVector2D point)
		{
			fixed (FBox2D* ptr = &this)
			{
				fixed (FVector2D* ptr2 = &point)
				{
					return FBox2D.Internal_ComputeSquaredDistanceToPoint(this, point);
				}
			}
		}

		// Token: 0x060000FB RID: 251 RVA: 0x0000655C File Offset: 0x0000475C
		public unsafe readonly FBox2D ExpandBy(float w)
		{
			fixed (FBox2D* ptr = &this)
			{
				return FBox2D.Internal_ExpandBy_Float(this, w);
			}
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00006574 File Offset: 0x00004774
		public unsafe readonly FBox2D ExpandBy(in FVector2D v)
		{
			fixed (FBox2D* ptr = &this)
			{
				fixed (FVector2D* ptr2 = &v)
				{
					return FBox2D.Internal_ExpandBy_FVector2D(this, v);
				}
			}
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00006590 File Offset: 0x00004790
		public unsafe readonly float GetArea()
		{
			fixed (FBox2D* ptr = &this)
			{
				return FBox2D.Internal_GetArea(this);
			}
		}

		// Token: 0x060000FE RID: 254 RVA: 0x000065A8 File Offset: 0x000047A8
		public unsafe readonly FVector2D GetCenter()
		{
			fixed (FBox2D* ptr = &this)
			{
				return FBox2D.Internal_GetCenter(this);
			}
		}

		// Token: 0x060000FF RID: 255 RVA: 0x000065C0 File Offset: 0x000047C0
		public unsafe readonly void GetCenterAndExtents(out FVector2D center, out FVector2D extents)
		{
			fixed (FBox2D* ptr = &this)
			{
				fixed (FVector2D* ptr2 = &center)
				{
					fixed (FVector2D* ptr3 = &extents)
					{
						FBox2D.Internal_GetCenterAndExtents(this, out center, out extents);
					}
				}
			}
		}

		// Token: 0x06000100 RID: 256 RVA: 0x000065EC File Offset: 0x000047EC
		public unsafe readonly FVector2D GetClosestPointTo(in FVector2D point)
		{
			fixed (FBox2D* ptr = &this)
			{
				fixed (FVector2D* ptr2 = &point)
				{
					return FBox2D.Internal_GetClosestPointTo(this, point);
				}
			}
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00006608 File Offset: 0x00004808
		public unsafe readonly FVector2D GetExtent()
		{
			fixed (FBox2D* ptr = &this)
			{
				return FBox2D.Internal_GetExtent(this);
			}
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00006620 File Offset: 0x00004820
		public unsafe readonly FVector2D GetSize()
		{
			fixed (FBox2D* ptr = &this)
			{
				return FBox2D.Internal_GetSize(this);
			}
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00006638 File Offset: 0x00004838
		public unsafe readonly FBox2D Overlap(in FBox2D other)
		{
			fixed (FBox2D* ptr = &this)
			{
				fixed (FBox2D* ptr2 = &other)
				{
					return FBox2D.Internal_Overlap(this, other);
				}
			}
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00006654 File Offset: 0x00004854
		public unsafe readonly bool Intersect(in FBox2D other)
		{
			fixed (FBox2D* ptr = &this)
			{
				fixed (FBox2D* ptr2 = &other)
				{
					return FBox2D.Internal_Intersect(this, other);
				}
			}
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00006670 File Offset: 0x00004870
		public unsafe readonly bool IsInsideOrOn(in FVector2D point)
		{
			fixed (FBox2D* ptr = &this)
			{
				fixed (FVector2D* ptr2 = &point)
				{
					return FBox2D.Internal_IsInsideOrOn(this, point);
				}
			}
		}

		// Token: 0x06000106 RID: 262 RVA: 0x0000668C File Offset: 0x0000488C
		public unsafe readonly bool IsInside(in FVector2D point)
		{
			fixed (FBox2D* ptr = &this)
			{
				fixed (FVector2D* ptr2 = &point)
				{
					return FBox2D.Internal_IsInside_FVector2D(this, point);
				}
			}
		}

		// Token: 0x06000107 RID: 263 RVA: 0x000066A8 File Offset: 0x000048A8
		public unsafe readonly bool IsInside(in FBox2D other)
		{
			fixed (FBox2D* ptr = &this)
			{
				fixed (FBox2D* ptr2 = &other)
				{
					return FBox2D.Internal_IsInside_FBox2D(this, other);
				}
			}
		}

		// Token: 0x06000108 RID: 264 RVA: 0x000066C4 File Offset: 0x000048C4
		public unsafe readonly FBox2D ShiftBy(in FVector2D offset)
		{
			fixed (FBox2D* ptr = &this)
			{
				fixed (FVector2D* ptr2 = &offset)
				{
					return FBox2D.Internal_ShiftBy(this, offset);
				}
			}
		}

		// Token: 0x06000109 RID: 265 RVA: 0x000066E0 File Offset: 0x000048E0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBox2D._ScriptStructPtr != 0) ? FBox2D._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.Box2D", ref FBox2D._ScriptStructPtr);
		}

		// Token: 0x04000061 RID: 97
		public static readonly FBox2D Empty = new FBox2D
		{
			bIsValid = false
		};

		// Token: 0x04000062 RID: 98
		[FieldOffset(0)]
		public FVector2D Min;

		// Token: 0x04000063 RID: 99
		[FieldOffset(8)]
		public FVector2D Max;

		// Token: 0x04000064 RID: 100
		[FieldOffset(16)]
		public bool bIsValid;

		// Token: 0x04000065 RID: 101
		public const string __ObjectPath = "/Script/CoreUObject.Box2D";

		// Token: 0x04000066 RID: 102
		private static IntPtr _ScriptStructPtr;
	}
}
