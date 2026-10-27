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
	// Token: 0x02000043 RID: 67
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(16, 16, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 16)]
	[UnrealObjectPath("/Script/CoreUObject.Vector4")]
	[StructLayout(LayoutKind.Explicit, Pack = 16, Size = 16)]
	public struct FVector4 : IEquatable<FVector4>, IEqualityOperators<FVector4, FVector4, bool>, IUnrealScriptStruct
	{
		// Token: 0x0600076D RID: 1901 RVA: 0x0000F0F8 File Offset: 0x0000D2F8
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

		// Token: 0x0600076E RID: 1902 RVA: 0x0000F14D File Offset: 0x0000D34D
		public FVector4()
		{
			this.X = 0f;
			this.Y = 0f;
			this.Z = 0f;
			this.W = 1f;
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x0000F17B File Offset: 0x0000D37B
		public FVector4(in FVector v, float w = 1f)
		{
			this = new FVector4(v.X, v.Y, v.Z, w);
		}

		// Token: 0x06000770 RID: 1904 RVA: 0x0000F196 File Offset: 0x0000D396
		public FVector4(in FLinearColor color)
		{
			this = new FVector4(color.R, color.G, color.B, color.A);
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x0000F1B6 File Offset: 0x0000D3B6
		public FVector4(in FVector2D xy, in FVector2D zw)
		{
			this = new FVector4(xy.X, xy.Y, zw.X, zw.Y);
		}

		// Token: 0x06000772 RID: 1906 RVA: 0x0000F1D6 File Offset: 0x0000D3D6
		public FVector4(in FIntVector4 v)
		{
			this = new FVector4((float)v.X, (float)v.Y, (float)v.Z, (float)v.W);
		}

		// Token: 0x06000773 RID: 1907 RVA: 0x0000F1FA File Offset: 0x0000D3FA
		public static FVector4 CreateOne(float v)
		{
			return new FVector4(v, v, v, v);
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x0000F205 File Offset: 0x0000D405
		public static FVector4 operator *(float scale, in FVector4 v)
		{
			return v * scale;
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x0000F20E File Offset: 0x0000D40E
		public static FVector4 operator -(in FVector4 v)
		{
			return new FVector4(-v.X, -v.Y, -v.Z, -v.W);
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x0000F231 File Offset: 0x0000D431
		public static bool operator ==(FVector4 a, FVector4 b)
		{
			return a.X == b.X && a.Y == b.Y && a.Z == b.Z && a.W == b.W;
		}

		// Token: 0x06000777 RID: 1911 RVA: 0x0000F26D File Offset: 0x0000D46D
		public static bool operator !=(FVector4 a, FVector4 b)
		{
			return a.X != b.X || a.Y != b.Y || a.Z != b.Z || a.W != b.W;
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x0000F2AC File Offset: 0x0000D4AC
		public readonly bool Equals(FVector4 other)
		{
			return this == other;
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x0000F2BC File Offset: 0x0000D4BC
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

		// Token: 0x0600077A RID: 1914 RVA: 0x0000F2E6 File Offset: 0x0000D4E6
		public override readonly int GetHashCode()
		{
			return HashCode.Combine<float, float, float, float>(this.X, this.Y, this.Z, this.W);
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x0000F308 File Offset: 0x0000D508
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

		// Token: 0x1700001F RID: 31
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

		// Token: 0x0600077E RID: 1918
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector4 Internal_Ctor(float x, float y, float z, float w);

		// Token: 0x0600077F RID: 1919
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector4 Internal_Add(in FVector4 a, in FVector4 b);

		// Token: 0x06000780 RID: 1920
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector4 Internal_Sub(in FVector4 a, in FVector4 b);

		// Token: 0x06000781 RID: 1921
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector4 Internal_Mul(in FVector4 a, in FVector4 b);

		// Token: 0x06000782 RID: 1922
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector4 Internal_MulFloat(in FVector4 a, float scale);

		// Token: 0x06000783 RID: 1923
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector4 Internal_Div(in FVector4 a, in FVector4 b);

		// Token: 0x06000784 RID: 1924
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector4 Internal_DivFloat(in FVector4 a, float scale);

		// Token: 0x06000785 RID: 1925
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector4 Internal_Xor(in FVector4 a, in FVector4 b);

		// Token: 0x06000786 RID: 1926
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_Dot3(in FVector4 a, in FVector4 b);

		// Token: 0x06000787 RID: 1927
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_Dot4(in FVector4 a, in FVector4 b);

		// Token: 0x06000788 RID: 1928
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_Equals(in FVector4 a, in FVector4 b, float tolerance = 0.0001f);

		// Token: 0x06000789 RID: 1929
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IsUnit3(in FVector4 a, float tolerance = 0.0001f);

		// Token: 0x0600078A RID: 1930
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Set(ref FVector4 a, float x, float y, float z, float w);

		// Token: 0x0600078B RID: 1931
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_Size(in FVector4 a);

		// Token: 0x0600078C RID: 1932
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_Size3(in FVector4 a);

		// Token: 0x0600078D RID: 1933
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_SizeSquared(in FVector4 a);

		// Token: 0x0600078E RID: 1934
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_SizeSquared3(in FVector4 a);

		// Token: 0x0600078F RID: 1935
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector4 Internal_GetUnsafeNormal3(in FVector4 a);

		// Token: 0x06000790 RID: 1936
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector4 Internal_GetSafeNormal(in FVector4 a, float tolerance = 1E-08f);

		// Token: 0x06000791 RID: 1937
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator Internal_ToOrientationRotator(in FVector4 a);

		// Token: 0x06000792 RID: 1938
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat Internal_ToOrientationQuat(in FVector4 a);

		// Token: 0x06000793 RID: 1939
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator Internal_Rotation(in FVector4 a);

		// Token: 0x06000794 RID: 1940
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IsNearlyZero3(in FVector4 a, float tolerance);

		// Token: 0x06000795 RID: 1941
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector4 Internal_Reflect3(in FVector4 a, in FVector4 normal);

		// Token: 0x06000796 RID: 1942
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_FindBestAxisVectors3(in FVector4 a, out FVector4 outAxis1, out FVector4 outAxis2);

		// Token: 0x06000797 RID: 1943
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_ContainsNaN(in FVector4 a);

		// Token: 0x06000798 RID: 1944
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_InitFromString(ref FVector4 a, in FCSharpStringView str);

		// Token: 0x06000799 RID: 1945 RVA: 0x0000F41B File Offset: 0x0000D61B
		public FVector4(float x = 0f, float y = 0f, float z = 0f, float w = 1f)
		{
			this.X = x;
			this.Y = y;
			this.Z = z;
			this.W = w;
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x0000F43C File Offset: 0x0000D63C
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

		// Token: 0x0600079B RID: 1947 RVA: 0x0000F458 File Offset: 0x0000D658
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

		// Token: 0x0600079C RID: 1948 RVA: 0x0000F474 File Offset: 0x0000D674
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

		// Token: 0x0600079D RID: 1949 RVA: 0x0000F490 File Offset: 0x0000D690
		public unsafe static FVector4 operator *(in FVector4 a, float scale)
		{
			fixed (FVector4* ptr = &a)
			{
				return FVector4.Internal_MulFloat(a, scale);
			}
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x0000F4A8 File Offset: 0x0000D6A8
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

		// Token: 0x0600079F RID: 1951 RVA: 0x0000F4C4 File Offset: 0x0000D6C4
		public unsafe static FVector4 operator /(in FVector4 a, float scale)
		{
			fixed (FVector4* ptr = &a)
			{
				return FVector4.Internal_DivFloat(a, scale);
			}
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x0000F4DC File Offset: 0x0000D6DC
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

		// Token: 0x060007A1 RID: 1953 RVA: 0x0000F4F8 File Offset: 0x0000D6F8
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

		// Token: 0x060007A2 RID: 1954 RVA: 0x0000F514 File Offset: 0x0000D714
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

		// Token: 0x060007A3 RID: 1955 RVA: 0x0000F530 File Offset: 0x0000D730
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

		// Token: 0x060007A4 RID: 1956 RVA: 0x0000F550 File Offset: 0x0000D750
		public unsafe readonly bool IsUnit3(float tolerance = 0.0001f)
		{
			fixed (FVector4* ptr = &this)
			{
				return FVector4.Internal_IsUnit3(this, tolerance);
			}
		}

		// Token: 0x060007A5 RID: 1957 RVA: 0x0000F568 File Offset: 0x0000D768
		public unsafe void Set(float x, float y, float z, float w)
		{
			fixed (FVector4* ptr = &this)
			{
				FVector4.Internal_Set(ref this, x, y, z, w);
			}
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x0000F588 File Offset: 0x0000D788
		public unsafe readonly float Size()
		{
			fixed (FVector4* ptr = &this)
			{
				return FVector4.Internal_Size(this);
			}
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x0000F5A0 File Offset: 0x0000D7A0
		public unsafe readonly float Size3()
		{
			fixed (FVector4* ptr = &this)
			{
				return FVector4.Internal_Size3(this);
			}
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x0000F5B8 File Offset: 0x0000D7B8
		public unsafe readonly float SizeSquared()
		{
			fixed (FVector4* ptr = &this)
			{
				return FVector4.Internal_SizeSquared(this);
			}
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x0000F5D0 File Offset: 0x0000D7D0
		public unsafe readonly float SizeSquared3()
		{
			fixed (FVector4* ptr = &this)
			{
				return FVector4.Internal_SizeSquared3(this);
			}
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x0000F5E8 File Offset: 0x0000D7E8
		public unsafe readonly FVector4 GetUnsafeNormal3()
		{
			fixed (FVector4* ptr = &this)
			{
				return FVector4.Internal_GetUnsafeNormal3(this);
			}
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x0000F600 File Offset: 0x0000D800
		public unsafe readonly FVector4 GetSafeNormal(float tolerance = 1E-08f)
		{
			fixed (FVector4* ptr = &this)
			{
				return FVector4.Internal_GetSafeNormal(this, tolerance);
			}
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x0000F618 File Offset: 0x0000D818
		public unsafe readonly FRotator ToOrientationRotator()
		{
			fixed (FVector4* ptr = &this)
			{
				return FVector4.Internal_ToOrientationRotator(this);
			}
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x0000F630 File Offset: 0x0000D830
		public unsafe readonly FQuat ToOrientationQuat()
		{
			fixed (FVector4* ptr = &this)
			{
				return FVector4.Internal_ToOrientationQuat(this);
			}
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x0000F648 File Offset: 0x0000D848
		public unsafe readonly FRotator Rotation()
		{
			fixed (FVector4* ptr = &this)
			{
				return FVector4.Internal_Rotation(this);
			}
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x0000F660 File Offset: 0x0000D860
		public unsafe readonly bool IsNearlyZero3(float tolerance = 0.0001f)
		{
			fixed (FVector4* ptr = &this)
			{
				return FVector4.Internal_IsNearlyZero3(this, tolerance);
			}
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x0000F678 File Offset: 0x0000D878
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

		// Token: 0x060007B1 RID: 1969 RVA: 0x0000F694 File Offset: 0x0000D894
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

		// Token: 0x060007B2 RID: 1970 RVA: 0x0000F6C0 File Offset: 0x0000D8C0
		public unsafe readonly bool ContainsNaN()
		{
			fixed (FVector4* ptr = &this)
			{
				return FVector4.Internal_ContainsNaN(this);
			}
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x0000F6D8 File Offset: 0x0000D8D8
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

		// Token: 0x060007B4 RID: 1972 RVA: 0x0000F73F File Offset: 0x0000D93F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FVector4._ScriptStructPtr != 0) ? FVector4._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.Vector4", ref FVector4._ScriptStructPtr);
		}

		// Token: 0x04000127 RID: 295
		public const int Alignment = 16;

		// Token: 0x04000128 RID: 296
		public static readonly FVector4 ZeroVector = new FVector4(0f, 0f, 0f, 0f);

		// Token: 0x04000129 RID: 297
		public static readonly FVector4 OneVector = new FVector4(1f, 1f, 1f, 1f);

		// Token: 0x0400012A RID: 298
		[FieldOffset(0)]
		public float X;

		// Token: 0x0400012B RID: 299
		[FieldOffset(4)]
		public float Y;

		// Token: 0x0400012C RID: 300
		[FieldOffset(8)]
		public float Z;

		// Token: 0x0400012D RID: 301
		[FieldOffset(12)]
		public float W;

		// Token: 0x0400012E RID: 302
		public const string __ObjectPath = "/Script/CoreUObject.Vector4";

		// Token: 0x0400012F RID: 303
		private static IntPtr _ScriptStructPtr;
	}
}
