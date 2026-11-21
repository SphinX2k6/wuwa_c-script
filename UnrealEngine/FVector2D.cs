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
	// Token: 0x02000026 RID: 38
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 8)]
	[UnrealObjectPath("/Script/CoreUObject.Vector2D")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 8)]
	public struct FVector2D : IEquatable<FVector2D>, IEqualityOperators<FVector2D, FVector2D, bool>, IVector2D, IUnrealScriptStruct
	{
		// Token: 0x0600063A RID: 1594 RVA: 0x0000AB60 File Offset: 0x00008D60
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

		// Token: 0x0600063B RID: 1595 RVA: 0x0000AB96 File Offset: 0x00008D96
		public FVector2D()
		{
			this.X = 0f;
			this.Y = 0f;
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x0000ABAE File Offset: 0x00008DAE
		public FVector2D(float inX, float inY)
		{
			this.X = inX;
			this.Y = inY;
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x0000ABBE File Offset: 0x00008DBE
		public FVector2D(float inF)
		{
			this = new FVector2D(inF, inF);
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x0000ABC8 File Offset: 0x00008DC8
		public FVector2D(in FIntPoint inPos)
		{
			this = new FVector2D((float)inPos.X, (float)inPos.Y);
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x0000ABDE File Offset: 0x00008DDE
		public FVector2D(in FVector v)
		{
			this = new FVector2D(v.X, v.Y);
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x0000ABF2 File Offset: 0x00008DF2
		public static FVector2D operator *(float scale, in FVector2D v)
		{
			return v * scale;
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x0000ABFB File Offset: 0x00008DFB
		public static FVector2D operator -(in FVector2D v)
		{
			return new FVector2D(-v.X, -v.Y);
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x0000AC10 File Offset: 0x00008E10
		public static FVector2D operator +(in FVector2D a, in FVector2D b)
		{
			return new FVector2D(a.X + b.X, a.Y + b.Y);
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x0000AC31 File Offset: 0x00008E31
		public static FVector2D operator +(in FVector2D v, float a)
		{
			return new FVector2D(v.X + a, v.Y + a);
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x0000AC48 File Offset: 0x00008E48
		public static FVector2D operator -(in FVector2D a, in FVector2D b)
		{
			return new FVector2D(a.X - b.X, a.Y - b.Y);
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x0000AC69 File Offset: 0x00008E69
		public static FVector2D operator -(in FVector2D v, float a)
		{
			return new FVector2D(v.X - a, v.Y - a);
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x0000AC80 File Offset: 0x00008E80
		public static FVector2D operator *(in FVector2D v, float scale)
		{
			return new FVector2D(v.X * scale, v.Y * scale);
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x0000AC97 File Offset: 0x00008E97
		public static FVector2D operator *(in FVector2D a, in FVector2D b)
		{
			return new FVector2D(a.X * b.X, a.Y * b.Y);
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x0000ACB8 File Offset: 0x00008EB8
		public static FVector2D operator /(in FVector2D a, in FVector2D b)
		{
			return new FVector2D(a.X / b.X, a.Y / b.Y);
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x0000ACD9 File Offset: 0x00008ED9
		public static FVector2D operator /(in FVector2D v, float scale)
		{
			return v * (1f / scale);
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x0000ACE8 File Offset: 0x00008EE8
		public static bool operator <(in FVector2D a, in FVector2D b)
		{
			return a.X < b.X && a.Y < b.Y;
		}

		// Token: 0x0600064B RID: 1611 RVA: 0x0000AD08 File Offset: 0x00008F08
		public static bool operator >(in FVector2D a, in FVector2D b)
		{
			return a.X > b.X && a.Y > b.Y;
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x0000AD28 File Offset: 0x00008F28
		public static bool operator <=(in FVector2D a, in FVector2D b)
		{
			return a.X <= b.X && a.Y <= b.Y;
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x0000AD4B File Offset: 0x00008F4B
		public static bool operator >=(in FVector2D a, in FVector2D b)
		{
			return a.X >= b.X && a.Y >= b.Y;
		}

		// Token: 0x0600064E RID: 1614 RVA: 0x0000AD6E File Offset: 0x00008F6E
		public static float operator |(in FVector2D a, in FVector2D b)
		{
			return a.X * b.X + a.Y * b.Y;
		}

		// Token: 0x0600064F RID: 1615 RVA: 0x0000AD8B File Offset: 0x00008F8B
		public static float operator ^(in FVector2D a, in FVector2D b)
		{
			return a.X * b.Y - a.Y * b.X;
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x0000ADA8 File Offset: 0x00008FA8
		public static implicit operator FVector2D(in FVector4 a)
		{
			return new FVector2D(a.X, a.Y);
		}

		// Token: 0x06000651 RID: 1617 RVA: 0x0000ADBB File Offset: 0x00008FBB
		public static bool operator ==(FVector2D a, FVector2D b)
		{
			return a.X == b.X && a.Y == b.Y;
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x0000ADDB File Offset: 0x00008FDB
		public static bool operator !=(FVector2D a, FVector2D b)
		{
			return a.X != b.X || a.Y != b.Y;
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x0000ADFE File Offset: 0x00008FFE
		public readonly bool Equals(FVector2D other)
		{
			return this == other;
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x0000AE0C File Offset: 0x0000900C
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

		// Token: 0x06000655 RID: 1621 RVA: 0x0000AE36 File Offset: 0x00009036
		public override readonly int GetHashCode()
		{
			return HashCode.Combine<float, float>(this.X, this.Y);
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x0000AE4C File Offset: 0x0000904C
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

		// Token: 0x1700001A RID: 26
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

		// Token: 0x06000659 RID: 1625 RVA: 0x0000AEEB File Offset: 0x000090EB
		public readonly float Component(int index)
		{
			return this[index];
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x0000AEF4 File Offset: 0x000090F4
		public void Set(float inX, float inY)
		{
			this.X = inX;
			this.Y = inY;
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x0000AF04 File Offset: 0x00009104
		public static float DotProduct(in FVector2D a, in FVector2D b)
		{
			return a | b;
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x0000AF0D File Offset: 0x0000910D
		public static float CrossProduct(in FVector2D a, in FVector2D b)
		{
			return a ^ b;
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x0000AF16 File Offset: 0x00009116
		public static FVector2D Max(in FVector2D a, in FVector2D b)
		{
			return new FVector2D(Math.Max(a.X, b.X), Math.Max(a.Y, b.Y));
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x0000AF3F File Offset: 0x0000913F
		public static FVector2D Min(in FVector2D a, in FVector2D b)
		{
			return new FVector2D(Math.Min(a.X, b.X), Math.Min(a.Y, b.Y));
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x0000AF68 File Offset: 0x00009168
		public readonly float GetMax()
		{
			return Math.Max(this.X, this.Y);
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x0000AF7B File Offset: 0x0000917B
		public readonly float GetMin()
		{
			return Math.Min(this.X, this.Y);
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x0000AF8E File Offset: 0x0000918E
		public readonly bool IsZero()
		{
			return this.X == 0f && this.Y == 0f;
		}

		// Token: 0x06000662 RID: 1634
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_Distance(in FVector2D a, in FVector2D b);

		// Token: 0x06000663 RID: 1635
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_DistSquared(in FVector2D a, in FVector2D b);

		// Token: 0x06000664 RID: 1636
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_Equals(in FVector2D a, in FVector2D b, float tolerance = 0.0001f);

		// Token: 0x06000665 RID: 1637
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_GetAbsMax(in FVector2D a);

		// Token: 0x06000666 RID: 1638
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D Internal_GetAbs(in FVector2D a);

		// Token: 0x06000667 RID: 1639
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_Length(in FVector2D a);

		// Token: 0x06000668 RID: 1640
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_Size(in FVector2D a);

		// Token: 0x06000669 RID: 1641
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_SizeSquared(in FVector2D a);

		// Token: 0x0600066A RID: 1642
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D Internal_GetRotated(in FVector2D a, float angleDeg);

		// Token: 0x0600066B RID: 1643
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IsNearlyZero(in FVector2D a, float tolerance = 0.0001f);

		// Token: 0x0600066C RID: 1644
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Normalize(ref FVector2D a, float tolerance = 1E-08f);

		// Token: 0x0600066D RID: 1645
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D Internal_GetSafeNormal(in FVector2D a, float tolerance = 1E-08f);

		// Token: 0x0600066E RID: 1646
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_ToDirectionAndLength(in FVector2D a, out FVector2D outDirection, out float outLength);

		// Token: 0x0600066F RID: 1647
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FIntPoint Internal_IntPoint(in FVector2D a);

		// Token: 0x06000670 RID: 1648
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D Internal_RoundToVector(in FVector2D a);

		// Token: 0x06000671 RID: 1649
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D Internal_ClampAxes(in FVector2D a, float minAxisVal, float maxAxisVal);

		// Token: 0x06000672 RID: 1650
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D Internal_GetSignVector(in FVector2D a);

		// Token: 0x06000673 RID: 1651
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_ContainsNaN(in FVector2D a);

		// Token: 0x06000674 RID: 1652
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_SphericalToUnitCartesian(in FVector2D a);

		// Token: 0x06000675 RID: 1653
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_InitFromString(ref FVector2D a, in FCSharpStringView str);

		// Token: 0x06000676 RID: 1654 RVA: 0x0000AFAC File Offset: 0x000091AC
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

		// Token: 0x06000677 RID: 1655 RVA: 0x0000AFC8 File Offset: 0x000091C8
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

		// Token: 0x06000678 RID: 1656 RVA: 0x0000AFE4 File Offset: 0x000091E4
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

		// Token: 0x06000679 RID: 1657 RVA: 0x0000B004 File Offset: 0x00009204
		public unsafe readonly float GetAbsMax()
		{
			fixed (FVector2D* ptr = &this)
			{
				return FVector2D.Internal_GetAbsMax(this);
			}
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x0000B01C File Offset: 0x0000921C
		public unsafe readonly FVector2D GetAbs()
		{
			fixed (FVector2D* ptr = &this)
			{
				return FVector2D.Internal_GetAbs(this);
			}
		}

		// Token: 0x0600067B RID: 1659 RVA: 0x0000B034 File Offset: 0x00009234
		public unsafe readonly float Length()
		{
			fixed (FVector2D* ptr = &this)
			{
				return FVector2D.Internal_Length(this);
			}
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x0000B04C File Offset: 0x0000924C
		public unsafe readonly float Size()
		{
			fixed (FVector2D* ptr = &this)
			{
				return FVector2D.Internal_Size(this);
			}
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x0000B064 File Offset: 0x00009264
		public unsafe readonly float SizeSquared()
		{
			fixed (FVector2D* ptr = &this)
			{
				return FVector2D.Internal_SizeSquared(this);
			}
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x0000B07C File Offset: 0x0000927C
		public unsafe readonly FVector2D GetRotated(float angleDeg)
		{
			fixed (FVector2D* ptr = &this)
			{
				return FVector2D.Internal_GetRotated(this, angleDeg);
			}
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x0000B094 File Offset: 0x00009294
		public unsafe readonly bool IsNearlyZero(float tolerance = 0.0001f)
		{
			fixed (FVector2D* ptr = &this)
			{
				return FVector2D.Internal_IsNearlyZero(this, tolerance);
			}
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x0000B0AC File Offset: 0x000092AC
		public unsafe void Normalize(float tolerance = 1E-08f)
		{
			fixed (FVector2D* ptr = &this)
			{
				FVector2D.Internal_Normalize(ref this, tolerance);
			}
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x0000B0C8 File Offset: 0x000092C8
		public unsafe readonly FVector2D GetSafeNormal(float tolerance = 1E-08f)
		{
			fixed (FVector2D* ptr = &this)
			{
				return FVector2D.Internal_GetSafeNormal(this, tolerance);
			}
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x0000B0E0 File Offset: 0x000092E0
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

		// Token: 0x06000683 RID: 1667 RVA: 0x0000B10C File Offset: 0x0000930C
		public unsafe readonly FIntPoint IntPoint()
		{
			fixed (FVector2D* ptr = &this)
			{
				return FVector2D.Internal_IntPoint(this);
			}
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x0000B124 File Offset: 0x00009324
		public unsafe readonly FVector2D RoundToVector()
		{
			fixed (FVector2D* ptr = &this)
			{
				return FVector2D.Internal_RoundToVector(this);
			}
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x0000B13C File Offset: 0x0000933C
		public unsafe readonly FVector2D ClampAxes(float minAxisVal, float maxAxisVal)
		{
			fixed (FVector2D* ptr = &this)
			{
				return FVector2D.Internal_ClampAxes(this, minAxisVal, maxAxisVal);
			}
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x0000B158 File Offset: 0x00009358
		public unsafe readonly FVector2D GetSignVector()
		{
			fixed (FVector2D* ptr = &this)
			{
				return FVector2D.Internal_GetSignVector(this);
			}
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x0000B170 File Offset: 0x00009370
		public unsafe readonly bool ContainsNaN()
		{
			fixed (FVector2D* ptr = &this)
			{
				return FVector2D.Internal_ContainsNaN(this);
			}
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x0000B188 File Offset: 0x00009388
		public unsafe readonly FVector SphericalToUnitCartesian()
		{
			fixed (FVector2D* ptr = &this)
			{
				return FVector2D.Internal_SphericalToUnitCartesian(this);
			}
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x0000B1A0 File Offset: 0x000093A0
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

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600068A RID: 1674 RVA: 0x0000B1FE File Offset: 0x000093FE
		// (set) Token: 0x0600068B RID: 1675 RVA: 0x0000B207 File Offset: 0x00009407
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

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600068C RID: 1676 RVA: 0x0000B211 File Offset: 0x00009411
		// (set) Token: 0x0600068D RID: 1677 RVA: 0x0000B21A File Offset: 0x0000941A
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

		// Token: 0x0600068E RID: 1678 RVA: 0x0000B224 File Offset: 0x00009424
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FVector2D._ScriptStructPtr != 0) ? FVector2D._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.Vector2D", ref FVector2D._ScriptStructPtr);
		}

		// Token: 0x040000D2 RID: 210
		public static readonly FVector2D ZeroVector = new FVector2D(0f, 0f);

		// Token: 0x040000D3 RID: 211
		public static readonly FVector2D UnitVector = new FVector2D(1f, 1f);

		// Token: 0x040000D4 RID: 212
		public static readonly FVector2D Unit45Deg = new FVector2D(0.70710677f, 0.70710677f);

		// Token: 0x040000D5 RID: 213
		[FieldOffset(0)]
		public float X;

		// Token: 0x040000D6 RID: 214
		[FieldOffset(4)]
		public float Y;

		// Token: 0x040000D7 RID: 215
		public const string __ObjectPath = "/Script/CoreUObject.Vector2D";

		// Token: 0x040000D8 RID: 216
		private static IntPtr _ScriptStructPtr;
	}
}
