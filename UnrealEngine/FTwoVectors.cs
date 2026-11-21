using System;
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
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 24)]
	[UnrealObjectPath("/Script/CoreUObject.TwoVectors")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 24)]
	public struct FTwoVectors : IEquatable<FTwoVectors>, IEqualityOperators<FTwoVectors, FTwoVectors, bool>, IUnrealScriptStruct
	{
		// Token: 0x06000530 RID: 1328 RVA: 0x00009676 File Offset: 0x00007876
		public FTwoVectors(in FVector in1, in FVector in2)
		{
			this.v1 = in1;
			this.v2 = in2;
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x00009690 File Offset: 0x00007890
		public FTwoVectors()
		{
			this.v1 = default(FVector);
			this.v2 = default(FVector);
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x000096AA File Offset: 0x000078AA
		public static FTwoVectors operator *(float scale, in FTwoVectors v)
		{
			return v * scale;
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x000096B4 File Offset: 0x000078B4
		public static FTwoVectors operator -(in FTwoVectors v)
		{
			FVector fvector = -v.v1;
			FVector fvector2 = -v.v2;
			return new FTwoVectors(ref fvector, ref fvector2);
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x000096E2 File Offset: 0x000078E2
		public static bool operator ==(FTwoVectors a, FTwoVectors b)
		{
			return a.v1 == b.v1 && a.v2 == b.v2;
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x0000970A File Offset: 0x0000790A
		public static bool operator !=(FTwoVectors a, FTwoVectors b)
		{
			return a.v1 != b.v1 || a.v2 != b.v2;
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x00009734 File Offset: 0x00007934
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

		// Token: 0x06000537 RID: 1335 RVA: 0x00009790 File Offset: 0x00007990
		public readonly bool Equals(FTwoVectors other)
		{
			return this == other;
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x000097A0 File Offset: 0x000079A0
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

		// Token: 0x06000539 RID: 1337 RVA: 0x000097CA File Offset: 0x000079CA
		public override readonly int GetHashCode()
		{
			return HashCode.Combine<FVector, FVector>(this.v1, this.v2);
		}

		// Token: 0x17000014 RID: 20
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

		// Token: 0x0600053C RID: 1340
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTwoVectors Internal_Add(in FTwoVectors a, in FTwoVectors b);

		// Token: 0x0600053D RID: 1341
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTwoVectors Internal_Sub(in FTwoVectors a, in FTwoVectors b);

		// Token: 0x0600053E RID: 1342
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTwoVectors Internal_Mul(in FTwoVectors a, in FTwoVectors b);

		// Token: 0x0600053F RID: 1343
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTwoVectors Internal_MulFloat(in FTwoVectors a, float b);

		// Token: 0x06000540 RID: 1344
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTwoVectors Internal_Div(in FTwoVectors a, in FTwoVectors b);

		// Token: 0x06000541 RID: 1345
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTwoVectors Internal_DivFloat(in FTwoVectors a, float b);

		// Token: 0x06000542 RID: 1346
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_Equals(in FTwoVectors a, in FTwoVectors b, float tolerance = 0.0001f);

		// Token: 0x06000543 RID: 1347
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_GetMax(in FTwoVectors a);

		// Token: 0x06000544 RID: 1348
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_GetMin(in FTwoVectors a);

		// Token: 0x06000545 RID: 1349 RVA: 0x000098E8 File Offset: 0x00007AE8
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

		// Token: 0x06000546 RID: 1350 RVA: 0x00009904 File Offset: 0x00007B04
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

		// Token: 0x06000547 RID: 1351 RVA: 0x00009920 File Offset: 0x00007B20
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

		// Token: 0x06000548 RID: 1352 RVA: 0x0000993C File Offset: 0x00007B3C
		public unsafe static FTwoVectors operator *(in FTwoVectors a, float b)
		{
			fixed (FTwoVectors* ptr = &a)
			{
				return FTwoVectors.Internal_MulFloat(a, b);
			}
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x00009954 File Offset: 0x00007B54
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

		// Token: 0x0600054A RID: 1354 RVA: 0x00009970 File Offset: 0x00007B70
		public unsafe static FTwoVectors operator /(in FTwoVectors a, float b)
		{
			fixed (FTwoVectors* ptr = &a)
			{
				return FTwoVectors.Internal_DivFloat(a, b);
			}
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x00009988 File Offset: 0x00007B88
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

		// Token: 0x0600054C RID: 1356 RVA: 0x000099A8 File Offset: 0x00007BA8
		public unsafe readonly float GetMax()
		{
			fixed (FTwoVectors* ptr = &this)
			{
				return FTwoVectors.Internal_GetMax(this);
			}
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x000099C0 File Offset: 0x00007BC0
		public unsafe readonly float GetMin()
		{
			fixed (FTwoVectors* ptr = &this)
			{
				return FTwoVectors.Internal_GetMin(this);
			}
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x000099D7 File Offset: 0x00007BD7
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTwoVectors._ScriptStructPtr != 0) ? FTwoVectors._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.TwoVectors", ref FTwoVectors._ScriptStructPtr);
		}

		// Token: 0x040000BA RID: 186
		[FieldOffset(0)]
		public FVector v1;

		// Token: 0x040000BB RID: 187
		[FieldOffset(12)]
		public FVector v2;

		// Token: 0x040000BC RID: 188
		public const string __ObjectPath = "/Script/CoreUObject.TwoVectors";

		// Token: 0x040000BD RID: 189
		private static IntPtr _ScriptStructPtr;
	}
}
