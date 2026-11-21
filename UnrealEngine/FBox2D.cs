using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000008 RID: 8
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 20)]
	[UnrealObjectPath("/Script/CoreUObject.Box2D")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 20)]
	public struct FBox2D : IEquatable<FBox2D>, IEqualityOperators<FBox2D, FBox2D, bool>, IUnrealScriptStruct
	{
		// Token: 0x0600005F RID: 95 RVA: 0x00002B86 File Offset: 0x00000D86
		public FBox2D()
		{
			this.Min = FVector2D.ZeroVector;
			this.Max = FVector2D.ZeroVector;
			this.bIsValid = false;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002BA5 File Offset: 0x00000DA5
		public FBox2D(in FVector2D inMin, in FVector2D inMax)
		{
			this.Min = inMin;
			this.Max = inMax;
			this.bIsValid = true;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002BC8 File Offset: 0x00000DC8
		public FBox2D(Span<FVector2D> points)
		{
			this = new FBox2D();
			for (int i = 0; i < points.Length; i++)
			{
				this = this + points[i];
			}
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002C06 File Offset: 0x00000E06
		[NullableContext(1)]
		public FBox2D(FVector2D[] points)
		{
			this = new FBox2D(points.AsSpan<FVector2D>());
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00002C14 File Offset: 0x00000E14
		[NullableContext(1)]
		public FBox2D(IEnumerable<FVector2D> points)
		{
			this = new FBox2D();
			foreach (FVector2D fvector2D in points)
			{
				this = this + fvector2D;
			}
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002C70 File Offset: 0x00000E70
		public void Init()
		{
			this.Min = FVector2D.ZeroVector;
			this.Max = FVector2D.ZeroVector;
			this.bIsValid = false;
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00002C8F File Offset: 0x00000E8F
		public readonly bool Equals(FBox2D other)
		{
			return this == other;
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00002CA0 File Offset: 0x00000EA0
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

		// Token: 0x06000067 RID: 103 RVA: 0x00002CCA File Offset: 0x00000ECA
		public override readonly int GetHashCode()
		{
			return HashCode.Combine<FVector2D, FVector2D, bool>(this.Min, this.Max, this.bIsValid);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00002CE4 File Offset: 0x00000EE4
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

		// Token: 0x06000069 RID: 105
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_Eq(in FBox2D a, in FBox2D b);

		// Token: 0x0600006A RID: 106
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBox2D Internal_Add_FVector2D(in FBox2D a, in FVector2D b);

		// Token: 0x0600006B RID: 107
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBox2D Internal_Add_FBox2D(in FBox2D a, in FBox2D b);

		// Token: 0x0600006C RID: 108
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_ComputeSquaredDistanceToPoint(in FBox2D a, in FVector2D b);

		// Token: 0x0600006D RID: 109
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBox2D Internal_ExpandBy_Float(in FBox2D a, float b);

		// Token: 0x0600006E RID: 110
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBox2D Internal_ExpandBy_FVector2D(in FBox2D a, in FVector2D b);

		// Token: 0x0600006F RID: 111
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_GetArea(in FBox2D a);

		// Token: 0x06000070 RID: 112
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D Internal_GetCenter(in FBox2D a);

		// Token: 0x06000071 RID: 113
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_GetCenterAndExtents(in FBox2D a, out FVector2D b, out FVector2D c);

		// Token: 0x06000072 RID: 114
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D Internal_GetClosestPointTo(in FBox2D a, in FVector2D b);

		// Token: 0x06000073 RID: 115
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D Internal_GetExtent(in FBox2D a);

		// Token: 0x06000074 RID: 116
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D Internal_GetSize(in FBox2D a);

		// Token: 0x06000075 RID: 117
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBox2D Internal_Overlap(in FBox2D a, in FBox2D b);

		// Token: 0x06000076 RID: 118
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_Intersect(in FBox2D a, in FBox2D b);

		// Token: 0x06000077 RID: 119
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IsInsideOrOn(in FBox2D a, in FVector2D b);

		// Token: 0x06000078 RID: 120
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IsInside_FVector2D(in FBox2D a, in FVector2D b);

		// Token: 0x06000079 RID: 121
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IsInside_FBox2D(in FBox2D a, in FBox2D b);

		// Token: 0x0600007A RID: 122
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBox2D Internal_ShiftBy(in FBox2D a, in FVector2D b);

		// Token: 0x0600007B RID: 123 RVA: 0x00002D59 File Offset: 0x00000F59
		public static bool operator ==(FBox2D a, FBox2D b)
		{
			return FBox2D.Internal_Eq(a, b);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00002D64 File Offset: 0x00000F64
		public static bool operator !=(FBox2D a, FBox2D b)
		{
			return !FBox2D.Internal_Eq(a, b);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00002D74 File Offset: 0x00000F74
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

		// Token: 0x0600007E RID: 126 RVA: 0x00002D90 File Offset: 0x00000F90
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

		// Token: 0x0600007F RID: 127 RVA: 0x00002DAC File Offset: 0x00000FAC
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

		// Token: 0x06000080 RID: 128 RVA: 0x00002DC8 File Offset: 0x00000FC8
		public unsafe readonly FBox2D ExpandBy(float w)
		{
			fixed (FBox2D* ptr = &this)
			{
				return FBox2D.Internal_ExpandBy_Float(this, w);
			}
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00002DE0 File Offset: 0x00000FE0
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

		// Token: 0x06000082 RID: 130 RVA: 0x00002DFC File Offset: 0x00000FFC
		public unsafe readonly float GetArea()
		{
			fixed (FBox2D* ptr = &this)
			{
				return FBox2D.Internal_GetArea(this);
			}
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00002E14 File Offset: 0x00001014
		public unsafe readonly FVector2D GetCenter()
		{
			fixed (FBox2D* ptr = &this)
			{
				return FBox2D.Internal_GetCenter(this);
			}
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00002E2C File Offset: 0x0000102C
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

		// Token: 0x06000085 RID: 133 RVA: 0x00002E58 File Offset: 0x00001058
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

		// Token: 0x06000086 RID: 134 RVA: 0x00002E74 File Offset: 0x00001074
		public unsafe readonly FVector2D GetExtent()
		{
			fixed (FBox2D* ptr = &this)
			{
				return FBox2D.Internal_GetExtent(this);
			}
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00002E8C File Offset: 0x0000108C
		public unsafe readonly FVector2D GetSize()
		{
			fixed (FBox2D* ptr = &this)
			{
				return FBox2D.Internal_GetSize(this);
			}
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00002EA4 File Offset: 0x000010A4
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

		// Token: 0x06000089 RID: 137 RVA: 0x00002EC0 File Offset: 0x000010C0
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

		// Token: 0x0600008A RID: 138 RVA: 0x00002EDC File Offset: 0x000010DC
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

		// Token: 0x0600008B RID: 139 RVA: 0x00002EF8 File Offset: 0x000010F8
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

		// Token: 0x0600008C RID: 140 RVA: 0x00002F14 File Offset: 0x00001114
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

		// Token: 0x0600008D RID: 141 RVA: 0x00002F30 File Offset: 0x00001130
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

		// Token: 0x0600008E RID: 142 RVA: 0x00002F4C File Offset: 0x0000114C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBox2D._ScriptStructPtr != 0) ? FBox2D._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.Box2D", ref FBox2D._ScriptStructPtr);
		}

		// Token: 0x0400001A RID: 26
		public static readonly FBox2D Empty = new FBox2D
		{
			bIsValid = false
		};

		// Token: 0x0400001B RID: 27
		[FieldOffset(0)]
		public FVector2D Min;

		// Token: 0x0400001C RID: 28
		[FieldOffset(8)]
		public FVector2D Max;

		// Token: 0x0400001D RID: 29
		[FieldOffset(16)]
		public bool bIsValid;

		// Token: 0x0400001E RID: 30
		public const string __ObjectPath = "/Script/CoreUObject.Box2D";

		// Token: 0x0400001F RID: 31
		private static IntPtr _ScriptStructPtr;
	}
}
