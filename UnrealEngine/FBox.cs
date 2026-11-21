using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000007 RID: 7
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(28, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 28)]
	[UnrealObjectPath("/Script/CoreUObject.Box")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 28)]
	public struct FBox : IEquatable<FBox>, IEqualityOperators<FBox, FBox, bool>, IUnrealScriptStruct
	{
		// Token: 0x06000014 RID: 20 RVA: 0x000025AC File Offset: 0x000007AC
		public FBox()
		{
			this.Min = FVector.ZeroVector;
			this.Max = FVector.ZeroVector;
			this.IsValid = 0;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000025CB File Offset: 0x000007CB
		public FBox(in FVector min, in FVector max)
		{
			this.Min = min;
			this.Max = max;
			this.IsValid = 1;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000025EC File Offset: 0x000007EC
		public FBox(in FBox other)
		{
			this.Min = other.Min;
			this.Max = other.Max;
			this.IsValid = other.IsValid;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002614 File Offset: 0x00000814
		[NullableContext(1)]
		public FBox(IEnumerable<FVector> points)
		{
			this.Min = default(FVector);
			this.Max = default(FVector);
			this.IsValid = 0;
			foreach (FVector fvector in points)
			{
				this = this + fvector;
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002684 File Offset: 0x00000884
		[NullableContext(1)]
		public FBox(FVector[] points)
		{
			this = new FBox(points.AsSpan<FVector>());
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002694 File Offset: 0x00000894
		public FBox(Span<FVector> points)
		{
			this.Min = default(FVector);
			this.Max = default(FVector);
			this.IsValid = 0;
			for (int i = 0; i < points.Length; i++)
			{
				this = this + points[i];
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000026E6 File Offset: 0x000008E6
		public readonly bool Equals(FBox other)
		{
			return this == other;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000026F4 File Offset: 0x000008F4
		[NullableContext(2)]
		public override readonly bool Equals(object obj)
		{
			if (obj is FBox)
			{
				FBox right = (FBox)obj;
				return this == right;
			}
			return false;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002720 File Offset: 0x00000920
		[NullableContext(1)]
		public override readonly string ToString()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 3);
			defaultInterpolatedStringHandler.AppendLiteral("IsValid=");
			defaultInterpolatedStringHandler.AppendFormatted<bool>(this.IsValid > 0);
			defaultInterpolatedStringHandler.AppendLiteral(", Min=(");
			defaultInterpolatedStringHandler.AppendFormatted<FVector>(this.Min);
			defaultInterpolatedStringHandler.AppendLiteral("), Max=(");
			defaultInterpolatedStringHandler.AppendFormatted<FVector>(this.Max);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002798 File Offset: 0x00000998
		public override readonly int GetHashCode()
		{
			return ((17 * 31 + this.Min.GetHashCode()) * 31 + this.Max.GetHashCode()) * 31 + this.IsValid.GetHashCode();
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000027D5 File Offset: 0x000009D5
		public void Init()
		{
			this.Min = FVector.ZeroVector;
			this.Max = FVector.ZeroVector;
			this.IsValid = 0;
		}

		// Token: 0x0600001F RID: 31
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_Eq(in FBox a, in FBox b);

		// Token: 0x06000020 RID: 32
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_NotEq(in FBox a, in FBox b);

		// Token: 0x06000021 RID: 33
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBox Internal_Add_FVector(in FBox a, in FVector v);

		// Token: 0x06000022 RID: 34
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBox Internal_Add_FBox(in FBox a, in FBox b);

		// Token: 0x06000023 RID: 35
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_Equals(in FBox a, in FBox b, float tolerance);

		// Token: 0x06000024 RID: 36
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_ComputeSquaredDistanceToPoint(in FBox a, in FVector v);

		// Token: 0x06000025 RID: 37
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBox Internal_ExpandBy_float(in FBox a, float fAbs);

		// Token: 0x06000026 RID: 38
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBox Internal_ExpandBy_FVector(in FBox a, in FVector v);

		// Token: 0x06000027 RID: 39
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBox Internal_ExpandBy_FVector_FVector(in FBox a, in FVector v, in FVector v2);

		// Token: 0x06000028 RID: 40
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBox Internal_ShiftBy(in FBox a, in FVector v);

		// Token: 0x06000029 RID: 41
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBox Internal_MoveTo(in FBox a, in FVector v);

		// Token: 0x0600002A RID: 42
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_GetCenter(in FBox a);

		// Token: 0x0600002B RID: 43
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_GetCenterAndExtents(in FBox a, out FVector outCenter, out FVector outExtents);

		// Token: 0x0600002C RID: 44
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_GetClosestPointTo(in FBox a, in FVector v);

		// Token: 0x0600002D RID: 45
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_GetExtent(in FBox a);

		// Token: 0x0600002E RID: 46
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_GetSize(in FBox a);

		// Token: 0x0600002F RID: 47
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_GetVolume(in FBox a);

		// Token: 0x06000030 RID: 48
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_Intersect(in FBox a, in FBox r);

		// Token: 0x06000031 RID: 49
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IntersectXY(in FBox a, in FBox r);

		// Token: 0x06000032 RID: 50
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IsInside_FVector(in FBox a, in FVector v);

		// Token: 0x06000033 RID: 51
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IsInsideOrOn(in FBox a, in FVector v);

		// Token: 0x06000034 RID: 52
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IsInside_FBox(in FBox a, in FBox r);

		// Token: 0x06000035 RID: 53
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IsInsideXY_FVector(in FBox a, in FVector v);

		// Token: 0x06000036 RID: 54
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IsInsideOrOnXY(in FBox a, in FVector v);

		// Token: 0x06000037 RID: 55
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IsInsideXY_FBox(in FBox a, in FBox r);

		// Token: 0x06000038 RID: 56
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBox Internal_TransformBy_FMatrix(in FBox a, in FMatrix m);

		// Token: 0x06000039 RID: 57
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBox Internal_TransformBy_FTransform(in FBox a, in FTransform tf);

		// Token: 0x0600003A RID: 58
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBox Internal_InverseTransformBy(in FBox a, in FTransform tf);

		// Token: 0x0600003B RID: 59
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBox Internal_TransformProjectBy(in FBox a, in FMatrix m);

		// Token: 0x0600003C RID: 60
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBox Internal_Overlap(in FBox a, in FBox r);

		// Token: 0x0600003D RID: 61
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBox Internal_BuildAABB(in FVector a, in FVector r);

		// Token: 0x0600003E RID: 62 RVA: 0x000027F4 File Offset: 0x000009F4
		public static bool operator ==(FBox left, FBox right)
		{
			return FBox.Internal_Eq(left, right);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000027FF File Offset: 0x000009FF
		public static bool operator !=(FBox left, FBox right)
		{
			return FBox.Internal_NotEq(left, right);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x0000280C File Offset: 0x00000A0C
		public unsafe readonly bool Equals(in FBox a, float tolerance = 0.0001f)
		{
			fixed (FBox* ptr = &this)
			{
				fixed (FBox* ptr2 = &a)
				{
					return FBox.Internal_Equals(this, a, tolerance);
				}
			}
		}

		// Token: 0x06000041 RID: 65 RVA: 0x0000282C File Offset: 0x00000A2C
		public unsafe static FBox operator +(in FBox left, in FVector right)
		{
			fixed (FBox* ptr = &left)
			{
				fixed (FVector* ptr2 = &right)
				{
					return FBox.Internal_Add_FVector(left, right);
				}
			}
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002848 File Offset: 0x00000A48
		public unsafe static FBox operator +(in FBox left, in FBox right)
		{
			fixed (FBox* ptr = &left)
			{
				fixed (FBox* ptr2 = &right)
				{
					return FBox.Internal_Add_FBox(left, right);
				}
			}
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002864 File Offset: 0x00000A64
		public unsafe readonly float ComputeSquaredDistanceToPoint(in FVector point)
		{
			fixed (FBox* ptr = &this)
			{
				fixed (FVector* ptr2 = &point)
				{
					return FBox.Internal_ComputeSquaredDistanceToPoint(this, point);
				}
			}
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002880 File Offset: 0x00000A80
		public unsafe readonly FBox ExpandBy(float w)
		{
			fixed (FBox* ptr = &this)
			{
				return FBox.Internal_ExpandBy_float(this, w);
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002898 File Offset: 0x00000A98
		public unsafe readonly FBox ExpandBy(in FVector v)
		{
			fixed (FBox* ptr = &this)
			{
				fixed (FVector* ptr2 = &v)
				{
					return FBox.Internal_ExpandBy_FVector(this, v);
				}
			}
		}

		// Token: 0x06000046 RID: 70 RVA: 0x000028B4 File Offset: 0x00000AB4
		public unsafe readonly FBox ExpandBy(in FVector neg, in FVector pos)
		{
			fixed (FBox* ptr = &this)
			{
				fixed (FVector* ptr2 = &neg)
				{
					fixed (FVector* ptr3 = &pos)
					{
						return FBox.Internal_ExpandBy_FVector_FVector(this, neg, pos);
					}
				}
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000028D8 File Offset: 0x00000AD8
		public unsafe readonly FBox ShiftBy(in FVector offset)
		{
			fixed (FBox* ptr = &this)
			{
				fixed (FVector* ptr2 = &offset)
				{
					return FBox.Internal_ShiftBy(this, offset);
				}
			}
		}

		// Token: 0x06000048 RID: 72 RVA: 0x000028F4 File Offset: 0x00000AF4
		public unsafe readonly FBox MoveTo(in FVector destination)
		{
			fixed (FBox* ptr = &this)
			{
				fixed (FVector* ptr2 = &destination)
				{
					return FBox.Internal_MoveTo(this, destination);
				}
			}
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002910 File Offset: 0x00000B10
		public unsafe readonly FVector GetCenter()
		{
			fixed (FBox* ptr = &this)
			{
				return FBox.Internal_GetCenter(this);
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002928 File Offset: 0x00000B28
		public unsafe readonly void GetCenterAndExtents(out FVector outCenter, out FVector outExtents)
		{
			fixed (FBox* ptr = &this)
			{
				fixed (FVector* ptr2 = &outCenter)
				{
					fixed (FVector* ptr3 = &outExtents)
					{
						FBox.Internal_GetCenterAndExtents(this, out outCenter, out outExtents);
					}
				}
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002954 File Offset: 0x00000B54
		public unsafe readonly FVector GetClosestPointTo(in FVector point)
		{
			fixed (FBox* ptr = &this)
			{
				fixed (FVector* ptr2 = &point)
				{
					return FBox.Internal_GetClosestPointTo(this, point);
				}
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002970 File Offset: 0x00000B70
		public unsafe readonly FVector GetExtent()
		{
			fixed (FBox* ptr = &this)
			{
				return FBox.Internal_GetExtent(this);
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002988 File Offset: 0x00000B88
		public unsafe readonly FVector GetSize()
		{
			fixed (FBox* ptr = &this)
			{
				return FBox.Internal_GetSize(this);
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x000029A0 File Offset: 0x00000BA0
		public unsafe readonly float GetVolume()
		{
			fixed (FBox* ptr = &this)
			{
				return FBox.Internal_GetVolume(this);
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000029B8 File Offset: 0x00000BB8
		public unsafe readonly bool Intersect(in FBox other)
		{
			fixed (FBox* ptr = &this)
			{
				fixed (FBox* ptr2 = &other)
				{
					return FBox.Internal_Intersect(this, other);
				}
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000029D4 File Offset: 0x00000BD4
		public unsafe readonly bool IntersectXY(in FBox other)
		{
			fixed (FBox* ptr = &this)
			{
				fixed (FBox* ptr2 = &other)
				{
					return FBox.Internal_IntersectXY(this, other);
				}
			}
		}

		// Token: 0x06000051 RID: 81 RVA: 0x000029F0 File Offset: 0x00000BF0
		public unsafe readonly bool IsInside(in FVector v)
		{
			fixed (FBox* ptr = &this)
			{
				fixed (FVector* ptr2 = &v)
				{
					return FBox.Internal_IsInside_FVector(this, v);
				}
			}
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002A0C File Offset: 0x00000C0C
		public unsafe readonly bool IsInsideOrOn(in FVector v)
		{
			fixed (FBox* ptr = &this)
			{
				fixed (FVector* ptr2 = &v)
				{
					return FBox.Internal_IsInsideOrOn(this, v);
				}
			}
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002A28 File Offset: 0x00000C28
		public unsafe readonly bool IsInside(in FBox r)
		{
			fixed (FBox* ptr = &this)
			{
				fixed (FBox* ptr2 = &r)
				{
					return FBox.Internal_IsInside_FBox(this, r);
				}
			}
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002A44 File Offset: 0x00000C44
		public unsafe readonly bool IsInsideXY(in FVector v)
		{
			fixed (FBox* ptr = &this)
			{
				fixed (FVector* ptr2 = &v)
				{
					return FBox.Internal_IsInsideXY_FVector(this, v);
				}
			}
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002A60 File Offset: 0x00000C60
		public unsafe readonly bool IsInsideOrOnXY(in FVector v)
		{
			fixed (FBox* ptr = &this)
			{
				fixed (FVector* ptr2 = &v)
				{
					return FBox.Internal_IsInsideOrOnXY(this, v);
				}
			}
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002A7C File Offset: 0x00000C7C
		public unsafe readonly bool IsInsideXY(in FBox other)
		{
			fixed (FBox* ptr = &this)
			{
				fixed (FBox* ptr2 = &other)
				{
					return FBox.Internal_IsInsideXY_FBox(this, other);
				}
			}
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002A98 File Offset: 0x00000C98
		public unsafe readonly FBox TransformBy(in FMatrix m)
		{
			fixed (FBox* ptr = &this)
			{
				fixed (FMatrix* ptr2 = &m)
				{
					return FBox.Internal_TransformBy_FMatrix(this, m);
				}
			}
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00002AB4 File Offset: 0x00000CB4
		public unsafe readonly FBox TransformBy(in FTransform tf)
		{
			fixed (FBox* ptr = &this)
			{
				fixed (FTransform* ptr2 = &tf)
				{
					return FBox.Internal_TransformBy_FTransform(this, tf);
				}
			}
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002AD0 File Offset: 0x00000CD0
		public unsafe readonly FBox InverseTransformBy(in FTransform tf)
		{
			fixed (FBox* ptr = &this)
			{
				fixed (FTransform* ptr2 = &tf)
				{
					return FBox.Internal_InverseTransformBy(this, tf);
				}
			}
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00002AEC File Offset: 0x00000CEC
		public unsafe readonly FBox TransformProjectBy(in FMatrix projM)
		{
			fixed (FBox* ptr = &this)
			{
				fixed (FMatrix* ptr2 = &projM)
				{
					return FBox.Internal_TransformProjectBy(this, projM);
				}
			}
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00002B08 File Offset: 0x00000D08
		public unsafe readonly FBox Overlap(in FBox other)
		{
			fixed (FBox* ptr = &this)
			{
				fixed (FBox* ptr2 = &other)
				{
					return FBox.Internal_Overlap(this, other);
				}
			}
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002B24 File Offset: 0x00000D24
		public unsafe static FBox BuildAABB(in FVector origin, in FVector extent)
		{
			fixed (FVector* ptr = &origin)
			{
				fixed (FVector* ptr2 = &extent)
				{
					return FBox.Internal_BuildAABB(origin, extent);
				}
			}
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002B40 File Offset: 0x00000D40
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBox._ScriptStructPtr != 0) ? FBox._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.Box", ref FBox._ScriptStructPtr);
		}

		// Token: 0x04000014 RID: 20
		public static readonly FBox ForceInit = new FBox
		{
			IsValid = 0
		};

		// Token: 0x04000015 RID: 21
		[FieldOffset(0)]
		public FVector Min;

		// Token: 0x04000016 RID: 22
		[FieldOffset(12)]
		public FVector Max;

		// Token: 0x04000017 RID: 23
		[FieldOffset(24)]
		public byte IsValid;

		// Token: 0x04000018 RID: 24
		public const string __ObjectPath = "/Script/CoreUObject.Box";

		// Token: 0x04000019 RID: 25
		private static IntPtr _ScriptStructPtr;
	}
}
