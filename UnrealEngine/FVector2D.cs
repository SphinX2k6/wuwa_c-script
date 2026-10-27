using System;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000041 RID: 65
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 8)]
	[UnrealObjectPath("/Script/CoreUObject.Vector2D")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 8)]
	public struct FVector2D : IEquatable<FVector2D>, IEqualityOperators<FVector2D, FVector2D, bool>, IVector2D, IUnrealScriptStruct
	{
		// Token: 0x060006B5 RID: 1717 RVA: 0x0000E2F4 File Offset: 0x0000C4F4
		[Conditional("ENABLE_NAN_DIAGNOSTIC")]
		public void DiagnosticCheckNaN()
		{
			if (!SharpherealAssert.Ensure(!this.ContainsNaN(), "FVector2D contains NaN: {0}", new object[]
			{
				this
			}))
			{
				this = FVector2D.ZeroVector;
			}
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x0000E32A File Offset: 0x0000C52A
		public FVector2D()
		{
			this.X = 0f;
			this.Y = 0f;
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x0000E342 File Offset: 0x0000C542
		public FVector2D(float inX, float inY)
		{
			this.X = inX;
			this.Y = inY;
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x0000E352 File Offset: 0x0000C552
		public FVector2D(float inF)
		{
			this = new FVector2D(inF, inF);
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x0000E35C File Offset: 0x0000C55C
		public FVector2D(in FIntPoint inPos)
		{
			this = new FVector2D((float)inPos.X, (float)inPos.Y);
		}

		// Token: 0x060006BA RID: 1722 RVA: 0x0000E372 File Offset: 0x0000C572
		public FVector2D(in FVector v)
		{
			this = new FVector2D(v.X, v.Y);
		}

		// Token: 0x060006BB RID: 1723 RVA: 0x0000E386 File Offset: 0x0000C586
		public static FVector2D operator *(float scale, in FVector2D v)
		{
			return v * scale;
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x0000E38F File Offset: 0x0000C58F
		public static FVector2D operator -(in FVector2D v)
		{
			return new FVector2D(-v.X, -v.Y);
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x0000E3A4 File Offset: 0x0000C5A4
		public static FVector2D operator +(in FVector2D a, in FVector2D b)
		{
			return new FVector2D(a.X + b.X, a.Y + b.Y);
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x0000E3C5 File Offset: 0x0000C5C5
		public static FVector2D operator +(in FVector2D v, float a)
		{
			return new FVector2D(v.X + a, v.Y + a);
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x0000E3DC File Offset: 0x0000C5DC
		public static FVector2D operator -(in FVector2D a, in FVector2D b)
		{
			return new FVector2D(a.X - b.X, a.Y - b.Y);
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x0000E3FD File Offset: 0x0000C5FD
		public static FVector2D operator -(in FVector2D v, float a)
		{
			return new FVector2D(v.X - a, v.Y - a);
		}

		// Token: 0x060006C1 RID: 1729 RVA: 0x0000E414 File Offset: 0x0000C614
		public static FVector2D operator *(in FVector2D v, float scale)
		{
			return new FVector2D(v.X * scale, v.Y * scale);
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x0000E42B File Offset: 0x0000C62B
		public static FVector2D operator *(in FVector2D a, in FVector2D b)
		{
			return new FVector2D(a.X * b.X, a.Y * b.Y);
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x0000E44C File Offset: 0x0000C64C
		public static FVector2D operator /(in FVector2D a, in FVector2D b)
		{
			return new FVector2D(a.X / b.X, a.Y / b.Y);
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x0000E46D File Offset: 0x0000C66D
		public static FVector2D operator /(in FVector2D v, float scale)
		{
			return v * (1f / scale);
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x0000E47C File Offset: 0x0000C67C
		public static bool operator <(in FVector2D a, in FVector2D b)
		{
			return a.X < b.X && a.Y < b.Y;
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x0000E49C File Offset: 0x0000C69C
		public static bool operator >(in FVector2D a, in FVector2D b)
		{
			return a.X > b.X && a.Y > b.Y;
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x0000E4BC File Offset: 0x0000C6BC
		public static bool operator <=(in FVector2D a, in FVector2D b)
		{
			return a.X <= b.X && a.Y <= b.Y;
		}

		// Token: 0x060006C8 RID: 1736 RVA: 0x0000E4DF File Offset: 0x0000C6DF
		public static bool operator >=(in FVector2D a, in FVector2D b)
		{
			return a.X >= b.X && a.Y >= b.Y;
		}

		// Token: 0x060006C9 RID: 1737 RVA: 0x0000E502 File Offset: 0x0000C702
		public static float operator |(in FVector2D a, in FVector2D b)
		{
			return a.X * b.X + a.Y * b.Y;
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x0000E51F File Offset: 0x0000C71F
		public static float operator ^(in FVector2D a, in FVector2D b)
		{
			return a.X * b.Y - a.Y * b.X;
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x0000E53C File Offset: 0x0000C73C
		public static implicit operator FVector2D(in FVector4 a)
		{
			return new FVector2D(a.X, a.Y);
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x0000E54F File Offset: 0x0000C74F
		public static bool operator ==(FVector2D a, FVector2D b)
		{
			return a.X == b.X && a.Y == b.Y;
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x0000E56F File Offset: 0x0000C76F
		public static bool operator !=(FVector2D a, FVector2D b)
		{
			return a.X != b.X || a.Y != b.Y;
		}

		// Token: 0x060006CE RID: 1742 RVA: 0x0000E592 File Offset: 0x0000C792
		public readonly bool Equals(FVector2D other)
		{
			return this == other;
		}

		// Token: 0x060006CF RID: 1743 RVA: 0x0000E5A0 File Offset: 0x0000C7A0
		[NullableContext(2)]
		public override readonly bool Equals(object obj)
		{
			if (obj is FVector2D)
			{
				FVector2D b = (FVector2D)obj;
				return this == b;
			}
			return false;
		}

		// Token: 0x060006D0 RID: 1744 RVA: 0x0000E5CA File Offset: 0x0000C7CA
		public override readonly int GetHashCode()
		{
			return HashCode.Combine<float, float>(this.X, this.Y);
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x0000E5E0 File Offset: 0x0000C7E0
		[NullableContext(1)]
		public override readonly string ToString()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 2);
			defaultInterpolatedStringHandler.AppendLiteral("X=");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.X);
			defaultInterpolatedStringHandler.AppendLiteral(" Y=");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.Y);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x1700001B RID: 27
		public float this[int index]
		{
			readonly get
			{
				float result;
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

		// Token: 0x060006D4 RID: 1748 RVA: 0x0000E67F File Offset: 0x0000C87F
		public readonly float Component(int index)
		{
			return this[index];
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x0000E688 File Offset: 0x0000C888
		public void Set(float inX, float inY)
		{
			this.X = inX;
			this.Y = inY;
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x0000E698 File Offset: 0x0000C898
		public static float DotProduct(in FVector2D a, in FVector2D b)
		{
			return a | b;
		}

		// Token: 0x060006D7 RID: 1751 RVA: 0x0000E6A1 File Offset: 0x0000C8A1
		public static float CrossProduct(in FVector2D a, in FVector2D b)
		{
			return a ^ b;
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x0000E6AA File Offset: 0x0000C8AA
		public static FVector2D Max(in FVector2D a, in FVector2D b)
		{
			return new FVector2D(Math.Max(a.X, b.X), Math.Max(a.Y, b.Y));
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x0000E6D3 File Offset: 0x0000C8D3
		public static FVector2D Min(in FVector2D a, in FVector2D b)
		{
			return new FVector2D(Math.Min(a.X, b.X), Math.Min(a.Y, b.Y));
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x0000E6FC File Offset: 0x0000C8FC
		public readonly float GetMax()
		{
			return Math.Max(this.X, this.Y);
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x0000E70F File Offset: 0x0000C90F
		public readonly float GetMin()
		{
			return Math.Min(this.X, this.Y);
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x0000E722 File Offset: 0x0000C922
		public readonly bool IsZero()
		{
			return this.X == 0f && this.Y == 0f;
		}

		// Token: 0x060006DD RID: 1757
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_Distance(in FVector2D a, in FVector2D b);

		// Token: 0x060006DE RID: 1758
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_DistSquared(in FVector2D a, in FVector2D b);

		// Token: 0x060006DF RID: 1759
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_Equals(in FVector2D a, in FVector2D b, float tolerance = 0.0001f);

		// Token: 0x060006E0 RID: 1760
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_GetAbsMax(in FVector2D a);

		// Token: 0x060006E1 RID: 1761
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D Internal_GetAbs(in FVector2D a);

		// Token: 0x060006E2 RID: 1762
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_Length(in FVector2D a);

		// Token: 0x060006E3 RID: 1763
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_Size(in FVector2D a);

		// Token: 0x060006E4 RID: 1764
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_SizeSquared(in FVector2D a);

		// Token: 0x060006E5 RID: 1765
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D Internal_GetRotated(in FVector2D a, float angleDeg);

		// Token: 0x060006E6 RID: 1766
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IsNearlyZero(in FVector2D a, float tolerance = 0.0001f);

		// Token: 0x060006E7 RID: 1767
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Normalize(ref FVector2D a, float tolerance = 1E-08f);

		// Token: 0x060006E8 RID: 1768
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D Internal_GetSafeNormal(in FVector2D a, float tolerance = 1E-08f);

		// Token: 0x060006E9 RID: 1769
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_ToDirectionAndLength(in FVector2D a, out FVector2D outDirection, out float outLength);

		// Token: 0x060006EA RID: 1770
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FIntPoint Internal_IntPoint(in FVector2D a);

		// Token: 0x060006EB RID: 1771
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D Internal_RoundToVector(in FVector2D a);

		// Token: 0x060006EC RID: 1772
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D Internal_ClampAxes(in FVector2D a, float minAxisVal, float maxAxisVal);

		// Token: 0x060006ED RID: 1773
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D Internal_GetSignVector(in FVector2D a);

		// Token: 0x060006EE RID: 1774
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_ContainsNaN(in FVector2D a);

		// Token: 0x060006EF RID: 1775
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_SphericalToUnitCartesian(in FVector2D a);

		// Token: 0x060006F0 RID: 1776
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_InitFromString(ref FVector2D a, in FCSharpStringView str);

		// Token: 0x060006F1 RID: 1777 RVA: 0x0000E740 File Offset: 0x0000C940
		public unsafe static float Distance(in FVector2D a, in FVector2D b)
		{
			fixed (FVector2D* ptr = &a)
			{
				fixed (FVector2D* ptr2 = &b)
				{
					return FVector2D.Internal_Distance(a, b);
				}
			}
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x0000E75C File Offset: 0x0000C95C
		public unsafe static float DistSquared(in FVector2D a, in FVector2D b)
		{
			fixed (FVector2D* ptr = &a)
			{
				fixed (FVector2D* ptr2 = &b)
				{
					return FVector2D.Internal_DistSquared(a, b);
				}
			}
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x0000E778 File Offset: 0x0000C978
		public unsafe readonly bool Equals(in FVector2D b, float tolerance = 0.0001f)
		{
			fixed (FVector2D* ptr = &this)
			{
				fixed (FVector2D* ptr2 = &b)
				{
					return FVector2D.Internal_Equals(this, b, tolerance);
				}
			}
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x0000E798 File Offset: 0x0000C998
		public unsafe readonly float GetAbsMax()
		{
			fixed (FVector2D* ptr = &this)
			{
				return FVector2D.Internal_GetAbsMax(this);
			}
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x0000E7B0 File Offset: 0x0000C9B0
		public unsafe readonly FVector2D GetAbs()
		{
			fixed (FVector2D* ptr = &this)
			{
				return FVector2D.Internal_GetAbs(this);
			}
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x0000E7C8 File Offset: 0x0000C9C8
		public unsafe readonly float Length()
		{
			fixed (FVector2D* ptr = &this)
			{
				return FVector2D.Internal_Length(this);
			}
		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x0000E7E0 File Offset: 0x0000C9E0
		public unsafe readonly float Size()
		{
			fixed (FVector2D* ptr = &this)
			{
				return FVector2D.Internal_Size(this);
			}
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x0000E7F8 File Offset: 0x0000C9F8
		public unsafe readonly float SizeSquared()
		{
			fixed (FVector2D* ptr = &this)
			{
				return FVector2D.Internal_SizeSquared(this);
			}
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x0000E810 File Offset: 0x0000CA10
		public unsafe readonly FVector2D GetRotated(float angleDeg)
		{
			fixed (FVector2D* ptr = &this)
			{
				return FVector2D.Internal_GetRotated(this, angleDeg);
			}
		}

		// Token: 0x060006FA RID: 1786 RVA: 0x0000E828 File Offset: 0x0000CA28
		public unsafe readonly bool IsNearlyZero(float tolerance = 0.0001f)
		{
			fixed (FVector2D* ptr = &this)
			{
				return FVector2D.Internal_IsNearlyZero(this, tolerance);
			}
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x0000E840 File Offset: 0x0000CA40
		public unsafe void Normalize(float tolerance = 1E-08f)
		{
			fixed (FVector2D* ptr = &this)
			{
				FVector2D.Internal_Normalize(ref this, tolerance);
			}
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x0000E85C File Offset: 0x0000CA5C
		public unsafe readonly FVector2D GetSafeNormal(float tolerance = 1E-08f)
		{
			fixed (FVector2D* ptr = &this)
			{
				return FVector2D.Internal_GetSafeNormal(this, tolerance);
			}
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x0000E874 File Offset: 0x0000CA74
		public unsafe readonly void ToDirectionAndLength(out FVector2D outDirection, out float outLength)
		{
			fixed (FVector2D* ptr = &this)
			{
				fixed (FVector2D* ptr2 = &outDirection)
				{
					fixed (float* ptr3 = &outLength)
					{
						FVector2D.Internal_ToDirectionAndLength(this, out outDirection, out outLength);
					}
				}
			}
		}

		// Token: 0x060006FE RID: 1790 RVA: 0x0000E8A0 File Offset: 0x0000CAA0
		public unsafe readonly FIntPoint IntPoint()
		{
			fixed (FVector2D* ptr = &this)
			{
				return FVector2D.Internal_IntPoint(this);
			}
		}

		// Token: 0x060006FF RID: 1791 RVA: 0x0000E8B8 File Offset: 0x0000CAB8
		public unsafe readonly FVector2D RoundToVector()
		{
			fixed (FVector2D* ptr = &this)
			{
				return FVector2D.Internal_RoundToVector(this);
			}
		}

		// Token: 0x06000700 RID: 1792 RVA: 0x0000E8D0 File Offset: 0x0000CAD0
		public unsafe readonly FVector2D ClampAxes(float minAxisVal, float maxAxisVal)
		{
			fixed (FVector2D* ptr = &this)
			{
				return FVector2D.Internal_ClampAxes(this, minAxisVal, maxAxisVal);
			}
		}

		// Token: 0x06000701 RID: 1793 RVA: 0x0000E8EC File Offset: 0x0000CAEC
		public unsafe readonly FVector2D GetSignVector()
		{
			fixed (FVector2D* ptr = &this)
			{
				return FVector2D.Internal_GetSignVector(this);
			}
		}

		// Token: 0x06000702 RID: 1794 RVA: 0x0000E904 File Offset: 0x0000CB04
		public unsafe readonly bool ContainsNaN()
		{
			fixed (FVector2D* ptr = &this)
			{
				return FVector2D.Internal_ContainsNaN(this);
			}
		}

		// Token: 0x06000703 RID: 1795 RVA: 0x0000E91C File Offset: 0x0000CB1C
		public unsafe readonly FVector SphericalToUnitCartesian()
		{
			fixed (FVector2D* ptr = &this)
			{
				return FVector2D.Internal_SphericalToUnitCartesian(this);
			}
		}

		// Token: 0x06000704 RID: 1796 RVA: 0x0000E934 File Offset: 0x0000CB34
		[NullableContext(2)]
		public unsafe void InitFromString(string str)
		{
			if (str == null || str.Length == 0)
			{
				this.X = (this.Y = 0f);
				return;
			}
			fixed (FVector2D* ptr = &this)
			{
				char* ptr2;
				if (str == null)
				{
					ptr2 = null;
				}
				else
				{
					fixed (char* ptr3 = str.GetPinnableReference())
					{
						ptr2 = ptr3;
					}
				}
				char* ptr4 = ptr2;
				FCSharpStringView fcsharpStringView = new FCSharpStringView(ptr4, str.Length);
				FVector2D.Internal_InitFromString(ref this, fcsharpStringView);
				char* ptr3 = null;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000705 RID: 1797 RVA: 0x0000E992 File Offset: 0x0000CB92
		// (set) Token: 0x06000706 RID: 1798 RVA: 0x0000E99B File Offset: 0x0000CB9B
		double IVector2D.X
		{
			get
			{
				return (double)this.X;
			}
			set
			{
				this.X = (float)value;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000707 RID: 1799 RVA: 0x0000E9A5 File Offset: 0x0000CBA5
		// (set) Token: 0x06000708 RID: 1800 RVA: 0x0000E9AE File Offset: 0x0000CBAE
		double IVector2D.Y
		{
			get
			{
				return (double)this.Y;
			}
			set
			{
				this.Y = (float)value;
			}
		}

		// Token: 0x06000709 RID: 1801 RVA: 0x0000E9B8 File Offset: 0x0000CBB8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FVector2D._ScriptStructPtr != 0) ? FVector2D._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.Vector2D", ref FVector2D._ScriptStructPtr);
		}

		// Token: 0x04000119 RID: 281
		public static readonly FVector2D ZeroVector = new FVector2D(0f, 0f);

		// Token: 0x0400011A RID: 282
		public static readonly FVector2D UnitVector = new FVector2D(1f, 1f);

		// Token: 0x0400011B RID: 283
		public static readonly FVector2D Unit45Deg = new FVector2D(0.70710677f, 0.70710677f);

		// Token: 0x0400011C RID: 284
		[FieldOffset(0)]
		public float X;

		// Token: 0x0400011D RID: 285
		[FieldOffset(4)]
		public float Y;

		// Token: 0x0400011E RID: 286
		public const string __ObjectPath = "/Script/CoreUObject.Vector2D";

		// Token: 0x0400011F RID: 287
		private static IntPtr _ScriptStructPtr;
	}
}
