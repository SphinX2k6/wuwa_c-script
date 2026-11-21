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
	// Token: 0x02000028 RID: 40
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(16, 16, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 16)]
	[UnrealObjectPath("/Script/CoreUObject.Vector4")]
	[StructLayout(LayoutKind.Explicit, Pack = 16, Size = 16)]
	public struct FVector4 : IEquatable<FVector4>, IEqualityOperators<FVector4, FVector4, bool>, IUnrealScriptStruct
	{
		// Token: 0x060006F2 RID: 1778 RVA: 0x0000B964 File Offset: 0x00009B64
		[Conditional("ENABLE_NAN_DIAGNOSTIC")]
		public void DiagnosticCheckNaN()
		{
			if (!SharpherealAssert.Ensure(!this.ContainsNaN(), "FVector4 contains NaN: {0}", new object[]
			{
				this
			}))
			{
				this = new FVector4(0f, 0f, 0f, 1f);
			}
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x0000B9B9 File Offset: 0x00009BB9
		public FVector4()
		{
			this.X = 0f;
			this.Y = 0f;
			this.Z = 0f;
			this.W = 1f;
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x0000B9E7 File Offset: 0x00009BE7
		public FVector4(in FVector v, float w = 1f)
		{
			this = new FVector4(v.X, v.Y, v.Z, w);
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x0000BA02 File Offset: 0x00009C02
		public FVector4(in FLinearColor color)
		{
			this = new FVector4(color.R, color.G, color.B, color.A);
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x0000BA22 File Offset: 0x00009C22
		public FVector4(in FVector2D xy, in FVector2D zw)
		{
			this = new FVector4(xy.X, xy.Y, zw.X, zw.Y);
		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x0000BA42 File Offset: 0x00009C42
		public FVector4(in FIntVector4 v)
		{
			this = new FVector4((float)v.X, (float)v.Y, (float)v.Z, (float)v.W);
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x0000BA66 File Offset: 0x00009C66
		public static FVector4 CreateOne(float v)
		{
			return new FVector4(v, v, v, v);
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x0000BA71 File Offset: 0x00009C71
		public static FVector4 operator *(float scale, in FVector4 v)
		{
			return v * scale;
		}

		// Token: 0x060006FA RID: 1786 RVA: 0x0000BA7A File Offset: 0x00009C7A
		public static FVector4 operator -(in FVector4 v)
		{
			return new FVector4(-v.X, -v.Y, -v.Z, -v.W);
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x0000BA9D File Offset: 0x00009C9D
		public static bool operator ==(FVector4 a, FVector4 b)
		{
			return a.X == b.X && a.Y == b.Y && a.Z == b.Z && a.W == b.W;
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x0000BAD9 File Offset: 0x00009CD9
		public static bool operator !=(FVector4 a, FVector4 b)
		{
			return a.X != b.X || a.Y != b.Y || a.Z != b.Z || a.W != b.W;
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x0000BB18 File Offset: 0x00009D18
		public readonly bool Equals(FVector4 other)
		{
			return this == other;
		}

		// Token: 0x060006FE RID: 1790 RVA: 0x0000BB28 File Offset: 0x00009D28
		[NullableContext(2)]
		public override readonly bool Equals(object obj)
		{
			if (obj is FVector4)
			{
				FVector4 b = (FVector4)obj;
				return this == b;
			}
			return false;
		}

		// Token: 0x060006FF RID: 1791 RVA: 0x0000BB52 File Offset: 0x00009D52
		public override readonly int GetHashCode()
		{
			return HashCode.Combine<float, float, float, float>(this.X, this.Y, this.Z, this.W);
		}

		// Token: 0x06000700 RID: 1792 RVA: 0x0000BB74 File Offset: 0x00009D74
		[NullableContext(1)]
		public override readonly string ToString()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(11, 4);
			defaultInterpolatedStringHandler.AppendLiteral("X=");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.X);
			defaultInterpolatedStringHandler.AppendLiteral(" Y=");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.Y);
			defaultInterpolatedStringHandler.AppendLiteral(" Z=");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.Z);
			defaultInterpolatedStringHandler.AppendLiteral(" W=");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.W);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x1700001E RID: 30
		public float this[int index]
		{
			readonly get
			{
				float result;
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
				case 3:
					result = this.W;
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
				case 3:
					this.W = value;
					return;
				default:
					throw new IndexOutOfRangeException();
				}
			}
		}

		// Token: 0x06000703 RID: 1795
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector4 Internal_Ctor(float x, float y, float z, float w);

		// Token: 0x06000704 RID: 1796
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector4 Internal_Add(in FVector4 a, in FVector4 b);

		// Token: 0x06000705 RID: 1797
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector4 Internal_Sub(in FVector4 a, in FVector4 b);

		// Token: 0x06000706 RID: 1798
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector4 Internal_Mul(in FVector4 a, in FVector4 b);

		// Token: 0x06000707 RID: 1799
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector4 Internal_MulFloat(in FVector4 a, float scale);

		// Token: 0x06000708 RID: 1800
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector4 Internal_Div(in FVector4 a, in FVector4 b);

		// Token: 0x06000709 RID: 1801
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector4 Internal_DivFloat(in FVector4 a, float scale);

		// Token: 0x0600070A RID: 1802
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector4 Internal_Xor(in FVector4 a, in FVector4 b);

		// Token: 0x0600070B RID: 1803
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_Dot3(in FVector4 a, in FVector4 b);

		// Token: 0x0600070C RID: 1804
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_Dot4(in FVector4 a, in FVector4 b);

		// Token: 0x0600070D RID: 1805
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_Equals(in FVector4 a, in FVector4 b, float tolerance = 0.0001f);

		// Token: 0x0600070E RID: 1806
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IsUnit3(in FVector4 a, float tolerance = 0.0001f);

		// Token: 0x0600070F RID: 1807
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Set(ref FVector4 a, float x, float y, float z, float w);

		// Token: 0x06000710 RID: 1808
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_Size(in FVector4 a);

		// Token: 0x06000711 RID: 1809
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_Size3(in FVector4 a);

		// Token: 0x06000712 RID: 1810
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_SizeSquared(in FVector4 a);

		// Token: 0x06000713 RID: 1811
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_SizeSquared3(in FVector4 a);

		// Token: 0x06000714 RID: 1812
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector4 Internal_GetUnsafeNormal3(in FVector4 a);

		// Token: 0x06000715 RID: 1813
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector4 Internal_GetSafeNormal(in FVector4 a, float tolerance = 1E-08f);

		// Token: 0x06000716 RID: 1814
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator Internal_ToOrientationRotator(in FVector4 a);

		// Token: 0x06000717 RID: 1815
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat Internal_ToOrientationQuat(in FVector4 a);

		// Token: 0x06000718 RID: 1816
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator Internal_Rotation(in FVector4 a);

		// Token: 0x06000719 RID: 1817
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IsNearlyZero3(in FVector4 a, float tolerance);

		// Token: 0x0600071A RID: 1818
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector4 Internal_Reflect3(in FVector4 a, in FVector4 normal);

		// Token: 0x0600071B RID: 1819
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_FindBestAxisVectors3(in FVector4 a, out FVector4 outAxis1, out FVector4 outAxis2);

		// Token: 0x0600071C RID: 1820
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_ContainsNaN(in FVector4 a);

		// Token: 0x0600071D RID: 1821
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_InitFromString(ref FVector4 a, in FCSharpStringView str);

		// Token: 0x0600071E RID: 1822 RVA: 0x0000BC87 File Offset: 0x00009E87
		public FVector4(float x = 0f, float y = 0f, float z = 0f, float w = 1f)
		{
			this.X = x;
			this.Y = y;
			this.Z = z;
			this.W = w;
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x0000BCA8 File Offset: 0x00009EA8
		public unsafe static FVector4 operator +(in FVector4 a, in FVector4 b)
		{
			fixed (FVector4* ptr = &a)
			{
				fixed (FVector4* ptr2 = &b)
				{
					return FVector4.Internal_Add(a, b);
				}
			}
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x0000BCC4 File Offset: 0x00009EC4
		public unsafe static FVector4 operator -(in FVector4 a, in FVector4 b)
		{
			fixed (FVector4* ptr = &a)
			{
				fixed (FVector4* ptr2 = &b)
				{
					return FVector4.Internal_Sub(a, b);
				}
			}
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x0000BCE0 File Offset: 0x00009EE0
		public unsafe static FVector4 operator *(in FVector4 a, in FVector4 b)
		{
			fixed (FVector4* ptr = &a)
			{
				fixed (FVector4* ptr2 = &b)
				{
					return FVector4.Internal_Mul(a, b);
				}
			}
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x0000BCFC File Offset: 0x00009EFC
		public unsafe static FVector4 operator *(in FVector4 a, float scale)
		{
			fixed (FVector4* ptr = &a)
			{
				return FVector4.Internal_MulFloat(a, scale);
			}
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x0000BD14 File Offset: 0x00009F14
		public unsafe static FVector4 operator /(in FVector4 a, in FVector4 b)
		{
			fixed (FVector4* ptr = &a)
			{
				fixed (FVector4* ptr2 = &b)
				{
					return FVector4.Internal_Div(a, b);
				}
			}
		}

		// Token: 0x06000724 RID: 1828 RVA: 0x0000BD30 File Offset: 0x00009F30
		public unsafe static FVector4 operator /(in FVector4 a, float scale)
		{
			fixed (FVector4* ptr = &a)
			{
				return FVector4.Internal_DivFloat(a, scale);
			}
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x0000BD48 File Offset: 0x00009F48
		public unsafe static FVector4 operator ^(in FVector4 a, in FVector4 b)
		{
			fixed (FVector4* ptr = &a)
			{
				fixed (FVector4* ptr2 = &b)
				{
					return FVector4.Internal_Xor(a, b);
				}
			}
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x0000BD64 File Offset: 0x00009F64
		public unsafe static float Dot3(in FVector4 a, in FVector4 b)
		{
			fixed (FVector4* ptr = &a)
			{
				fixed (FVector4* ptr2 = &b)
				{
					return FVector4.Internal_Dot3(a, b);
				}
			}
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x0000BD80 File Offset: 0x00009F80
		public unsafe static float Dot4(in FVector4 a, in FVector4 b)
		{
			fixed (FVector4* ptr = &a)
			{
				fixed (FVector4* ptr2 = &b)
				{
					return FVector4.Internal_Dot4(a, b);
				}
			}
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x0000BD9C File Offset: 0x00009F9C
		public unsafe readonly bool Equals(in FVector4 b, float tolerance = 0.0001f)
		{
			fixed (FVector4* ptr = &this)
			{
				fixed (FVector4* ptr2 = &b)
				{
					return FVector4.Internal_Equals(this, b, tolerance);
				}
			}
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x0000BDBC File Offset: 0x00009FBC
		public unsafe readonly bool IsUnit3(float tolerance = 0.0001f)
		{
			fixed (FVector4* ptr = &this)
			{
				return FVector4.Internal_IsUnit3(this, tolerance);
			}
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x0000BDD4 File Offset: 0x00009FD4
		public unsafe void Set(float x, float y, float z, float w)
		{
			fixed (FVector4* ptr = &this)
			{
				FVector4.Internal_Set(ref this, x, y, z, w);
			}
		}

		// Token: 0x0600072B RID: 1835 RVA: 0x0000BDF4 File Offset: 0x00009FF4
		public unsafe readonly float Size()
		{
			fixed (FVector4* ptr = &this)
			{
				return FVector4.Internal_Size(this);
			}
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x0000BE0C File Offset: 0x0000A00C
		public unsafe readonly float Size3()
		{
			fixed (FVector4* ptr = &this)
			{
				return FVector4.Internal_Size3(this);
			}
		}

		// Token: 0x0600072D RID: 1837 RVA: 0x0000BE24 File Offset: 0x0000A024
		public unsafe readonly float SizeSquared()
		{
			fixed (FVector4* ptr = &this)
			{
				return FVector4.Internal_SizeSquared(this);
			}
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x0000BE3C File Offset: 0x0000A03C
		public unsafe readonly float SizeSquared3()
		{
			fixed (FVector4* ptr = &this)
			{
				return FVector4.Internal_SizeSquared3(this);
			}
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x0000BE54 File Offset: 0x0000A054
		public unsafe readonly FVector4 GetUnsafeNormal3()
		{
			fixed (FVector4* ptr = &this)
			{
				return FVector4.Internal_GetUnsafeNormal3(this);
			}
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x0000BE6C File Offset: 0x0000A06C
		public unsafe readonly FVector4 GetSafeNormal(float tolerance = 1E-08f)
		{
			fixed (FVector4* ptr = &this)
			{
				return FVector4.Internal_GetSafeNormal(this, tolerance);
			}
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x0000BE84 File Offset: 0x0000A084
		public unsafe readonly FRotator ToOrientationRotator()
		{
			fixed (FVector4* ptr = &this)
			{
				return FVector4.Internal_ToOrientationRotator(this);
			}
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x0000BE9C File Offset: 0x0000A09C
		public unsafe readonly FQuat ToOrientationQuat()
		{
			fixed (FVector4* ptr = &this)
			{
				return FVector4.Internal_ToOrientationQuat(this);
			}
		}

		// Token: 0x06000733 RID: 1843 RVA: 0x0000BEB4 File Offset: 0x0000A0B4
		public unsafe readonly FRotator Rotation()
		{
			fixed (FVector4* ptr = &this)
			{
				return FVector4.Internal_Rotation(this);
			}
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x0000BECC File Offset: 0x0000A0CC
		public unsafe readonly bool IsNearlyZero3(float tolerance = 0.0001f)
		{
			fixed (FVector4* ptr = &this)
			{
				return FVector4.Internal_IsNearlyZero3(this, tolerance);
			}
		}

		// Token: 0x06000735 RID: 1845 RVA: 0x0000BEE4 File Offset: 0x0000A0E4
		public unsafe readonly FVector4 Reflect3(in FVector4 normal)
		{
			fixed (FVector4* ptr = &this)
			{
				fixed (FVector4* ptr2 = &normal)
				{
					return FVector4.Internal_Reflect3(this, normal);
				}
			}
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x0000BF00 File Offset: 0x0000A100
		public unsafe readonly void FindBestAxisVectors3(out FVector4 outAxis1, out FVector4 outAxis2)
		{
			fixed (FVector4* ptr = &this)
			{
				fixed (FVector4* ptr2 = &outAxis1)
				{
					fixed (FVector4* ptr3 = &outAxis2)
					{
						FVector4.Internal_FindBestAxisVectors3(this, out outAxis1, out outAxis2);
					}
				}
			}
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x0000BF2C File Offset: 0x0000A12C
		public unsafe readonly bool ContainsNaN()
		{
			fixed (FVector4* ptr = &this)
			{
				return FVector4.Internal_ContainsNaN(this);
			}
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x0000BF44 File Offset: 0x0000A144
		[NullableContext(2)]
		public unsafe void InitFromString(string str)
		{
			if (str == null || str.Length == 0)
			{
				this.X = (this.Y = (this.Z = 0f));
				return;
			}
			fixed (FVector4* ptr = &this)
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
				FVector4.Internal_InitFromString(ref this, fcsharpStringView);
				char* ptr3 = null;
			}
		}

		// Token: 0x06000739 RID: 1849 RVA: 0x0000BFAB File Offset: 0x0000A1AB
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FVector4._ScriptStructPtr != 0) ? FVector4._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.Vector4", ref FVector4._ScriptStructPtr);
		}

		// Token: 0x040000E0 RID: 224
		public const int Alignment = 16;

		// Token: 0x040000E1 RID: 225
		public static readonly FVector4 ZeroVector = new FVector4(0f, 0f, 0f, 0f);

		// Token: 0x040000E2 RID: 226
		public static readonly FVector4 OneVector = new FVector4(1f, 1f, 1f, 1f);

		// Token: 0x040000E3 RID: 227
		[FieldOffset(0)]
		public float X;

		// Token: 0x040000E4 RID: 228
		[FieldOffset(4)]
		public float Y;

		// Token: 0x040000E5 RID: 229
		[FieldOffset(8)]
		public float Z;

		// Token: 0x040000E6 RID: 230
		[FieldOffset(12)]
		public float W;

		// Token: 0x040000E7 RID: 231
		public const string __ObjectPath = "/Script/CoreUObject.Vector4";

		// Token: 0x040000E8 RID: 232
		private static IntPtr _ScriptStructPtr;
	}
}
