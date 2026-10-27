using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200003E RID: 62
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 24)]
	[UnrealObjectPath("/Script/CoreUObject.TwoVectors")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 24)]
	public struct FTwoVectors : IEquatable<FTwoVectors>, IEqualityOperators<FTwoVectors, FTwoVectors, bool>, IUnrealScriptStruct
	{
		// Token: 0x060005AB RID: 1451 RVA: 0x0000CE0A File Offset: 0x0000B00A
		public FTwoVectors(in FVector in1, in FVector in2)
		{
			this.v1 = in1;
			this.v2 = in2;
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x0000CE24 File Offset: 0x0000B024
		public FTwoVectors()
		{
			this.v1 = default(FVector);
			this.v2 = default(FVector);
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x0000CE3E File Offset: 0x0000B03E
		public static FTwoVectors operator *(float scale, in FTwoVectors v)
		{
			return v * scale;
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x0000CE48 File Offset: 0x0000B048
		public static FTwoVectors operator -(in FTwoVectors v)
		{
			FVector fvector = -v.v1;
			FVector fvector2 = -v.v2;
			return new FTwoVectors(ref fvector, ref fvector2);
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x0000CE76 File Offset: 0x0000B076
		public static bool operator ==(FTwoVectors a, FTwoVectors b)
		{
			return a.v1 == b.v1 && a.v2 == b.v2;
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x0000CE9E File Offset: 0x0000B09E
		public static bool operator !=(FTwoVectors a, FTwoVectors b)
		{
			return a.v1 != b.v1 || a.v2 != b.v2;
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x0000CEC8 File Offset: 0x0000B0C8
		[NullableContext(1)]
		public override readonly string ToString()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(11, 2);
			defaultInterpolatedStringHandler.AppendLiteral("V1=(");
			defaultInterpolatedStringHandler.AppendFormatted<FVector>(this.v1);
			defaultInterpolatedStringHandler.AppendLiteral(") V2=(");
			defaultInterpolatedStringHandler.AppendFormatted<FVector>(this.v2);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x0000CF24 File Offset: 0x0000B124
		public readonly bool Equals(FTwoVectors other)
		{
			return this == other;
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x0000CF34 File Offset: 0x0000B134
		[NullableContext(2)]
		public override readonly bool Equals(object obj)
		{
			if (obj is FTwoVectors)
			{
				FTwoVectors b = (FTwoVectors)obj;
				return this == b;
			}
			return false;
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x0000CF5E File Offset: 0x0000B15E
		public override readonly int GetHashCode()
		{
			return HashCode.Combine<FVector, FVector>(this.v1, this.v2);
		}

		// Token: 0x17000015 RID: 21
		public float this[int index]
		{
			readonly get
			{
				float result;
				switch (index)
				{
				case 0:
					result = this.v1.X;
					break;
				case 1:
					result = this.v2.X;
					break;
				case 2:
					result = this.v1.Y;
					break;
				case 3:
					result = this.v2.Y;
					break;
				case 4:
					result = this.v1.Z;
					break;
				case 5:
					result = this.v2.Z;
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
					this.v1.X = value;
					return;
				case 1:
					this.v2.X = value;
					return;
				case 2:
					this.v1.Y = value;
					return;
				case 3:
					this.v2.Y = value;
					return;
				case 4:
					this.v1.Z = value;
					return;
				case 5:
					this.v2.Z = value;
					return;
				default:
					throw new IndexOutOfRangeException();
				}
			}
		}

		// Token: 0x060005B7 RID: 1463
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTwoVectors Internal_Add(in FTwoVectors a, in FTwoVectors b);

		// Token: 0x060005B8 RID: 1464
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTwoVectors Internal_Sub(in FTwoVectors a, in FTwoVectors b);

		// Token: 0x060005B9 RID: 1465
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTwoVectors Internal_Mul(in FTwoVectors a, in FTwoVectors b);

		// Token: 0x060005BA RID: 1466
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTwoVectors Internal_MulFloat(in FTwoVectors a, float b);

		// Token: 0x060005BB RID: 1467
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTwoVectors Internal_Div(in FTwoVectors a, in FTwoVectors b);

		// Token: 0x060005BC RID: 1468
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTwoVectors Internal_DivFloat(in FTwoVectors a, float b);

		// Token: 0x060005BD RID: 1469
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_Equals(in FTwoVectors a, in FTwoVectors b, float tolerance = 0.0001f);

		// Token: 0x060005BE RID: 1470
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_GetMax(in FTwoVectors a);

		// Token: 0x060005BF RID: 1471
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_GetMin(in FTwoVectors a);

		// Token: 0x060005C0 RID: 1472 RVA: 0x0000D07C File Offset: 0x0000B27C
		public unsafe static FTwoVectors operator +(in FTwoVectors a, in FTwoVectors b)
		{
			fixed (FTwoVectors* ptr = &a)
			{
				fixed (FTwoVectors* ptr2 = &b)
				{
					return FTwoVectors.Internal_Add(a, b);
				}
			}
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x0000D098 File Offset: 0x0000B298
		public unsafe static FTwoVectors operator -(in FTwoVectors a, in FTwoVectors b)
		{
			fixed (FTwoVectors* ptr = &a)
			{
				fixed (FTwoVectors* ptr2 = &b)
				{
					return FTwoVectors.Internal_Sub(a, b);
				}
			}
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x0000D0B4 File Offset: 0x0000B2B4
		public unsafe static FTwoVectors operator *(in FTwoVectors a, in FTwoVectors b)
		{
			fixed (FTwoVectors* ptr = &a)
			{
				fixed (FTwoVectors* ptr2 = &b)
				{
					return FTwoVectors.Internal_Mul(a, b);
				}
			}
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x0000D0D0 File Offset: 0x0000B2D0
		public unsafe static FTwoVectors operator *(in FTwoVectors a, float b)
		{
			fixed (FTwoVectors* ptr = &a)
			{
				return FTwoVectors.Internal_MulFloat(a, b);
			}
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x0000D0E8 File Offset: 0x0000B2E8
		public unsafe static FTwoVectors operator /(in FTwoVectors a, in FTwoVectors b)
		{
			fixed (FTwoVectors* ptr = &a)
			{
				fixed (FTwoVectors* ptr2 = &b)
				{
					return FTwoVectors.Internal_Div(a, b);
				}
			}
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x0000D104 File Offset: 0x0000B304
		public unsafe static FTwoVectors operator /(in FTwoVectors a, float b)
		{
			fixed (FTwoVectors* ptr = &a)
			{
				return FTwoVectors.Internal_DivFloat(a, b);
			}
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x0000D11C File Offset: 0x0000B31C
		public unsafe readonly bool Equals(in FTwoVectors b, float tolerance = 0.0001f)
		{
			fixed (FTwoVectors* ptr = &this)
			{
				fixed (FTwoVectors* ptr2 = &b)
				{
					return FTwoVectors.Internal_Equals(this, b, tolerance);
				}
			}
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x0000D13C File Offset: 0x0000B33C
		public unsafe readonly float GetMax()
		{
			fixed (FTwoVectors* ptr = &this)
			{
				return FTwoVectors.Internal_GetMax(this);
			}
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x0000D154 File Offset: 0x0000B354
		public unsafe readonly float GetMin()
		{
			fixed (FTwoVectors* ptr = &this)
			{
				return FTwoVectors.Internal_GetMin(this);
			}
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x0000D16B File Offset: 0x0000B36B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTwoVectors._ScriptStructPtr != 0) ? FTwoVectors._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.TwoVectors", ref FTwoVectors._ScriptStructPtr);
		}

		// Token: 0x04000101 RID: 257
		[FieldOffset(0)]
		public FVector v1;

		// Token: 0x04000102 RID: 258
		[FieldOffset(12)]
		public FVector v2;

		// Token: 0x04000103 RID: 259
		public const string __ObjectPath = "/Script/CoreUObject.TwoVectors";

		// Token: 0x04000104 RID: 260
		private static IntPtr _ScriptStructPtr;
	}
}
