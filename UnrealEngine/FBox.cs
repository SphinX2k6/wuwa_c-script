using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000022 RID: 34
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(28, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 28)]
	[UnrealObjectPath("/Script/CoreUObject.Box")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 28)]
	public struct FBox : IEquatable<FBox>, IEqualityOperators<FBox, FBox, bool>, IUnrealScriptStruct
	{
		// Token: 0x0600008F RID: 143 RVA: 0x00005D40 File Offset: 0x00003F40
		public FBox()
		{
			this.Min = FVector.ZeroVector;
			this.Max = FVector.ZeroVector;
			this.IsValid = 0;
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00005D5F File Offset: 0x00003F5F
		public FBox(in FVector min, in FVector max)
		{
			this.Min = min;
			this.Max = max;
			this.IsValid = 1;
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00005D80 File Offset: 0x00003F80
		public FBox(in FBox other)
		{
			this.Min = other.Min;
			this.Max = other.Max;
			this.IsValid = other.IsValid;
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00005DA8 File Offset: 0x00003FA8
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

		// Token: 0x06000093 RID: 147 RVA: 0x00005E18 File Offset: 0x00004018
		[NullableContext(1)]
		public FBox(FVector[] points)
		{
			this = new FBox(points.AsSpan<FVector>());
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00005E28 File Offset: 0x00004028
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

		// Token: 0x06000095 RID: 149 RVA: 0x00005E7A File Offset: 0x0000407A
		public readonly bool Equals(FBox other)
		{
			return this == other;
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00005E88 File Offset: 0x00004088
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

		// Token: 0x06000097 RID: 151 RVA: 0x00005EB4 File Offset: 0x000040B4
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

		// Token: 0x06000098 RID: 152 RVA: 0x00005F2C File Offset: 0x0000412C
		public override readonly int GetHashCode()
		{
			return ((17 * 31 + this.Min.GetHashCode()) * 31 + this.Max.GetHashCode()) * 31 + this.IsValid.GetHashCode();
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00005F69 File Offset: 0x00004169
		public void Init()
		{
			this.Min = FVector.ZeroVector;
			this.Max = FVector.ZeroVector;
			this.IsValid = 0;
		}

		// Token: 0x0600009A RID: 154
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_Eq(in FBox a, in FBox b);

		// Token: 0x0600009B RID: 155
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_NotEq(in FBox a, in FBox b);

		// Token: 0x0600009C RID: 156
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBox Internal_Add_FVector(in FBox a, in FVector v);

		// Token: 0x0600009D RID: 157
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBox Internal_Add_FBox(in FBox a, in FBox b);

		// Token: 0x0600009E RID: 158
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_Equals(in FBox a, in FBox b, float tolerance);

		// Token: 0x0600009F RID: 159
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_ComputeSquaredDistanceToPoint(in FBox a, in FVector v);

		// Token: 0x060000A0 RID: 160
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBox Internal_ExpandBy_float(in FBox a, float fAbs);

		// Token: 0x060000A1 RID: 161
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBox Internal_ExpandBy_FVector(in FBox a, in FVector v);

		// Token: 0x060000A2 RID: 162
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBox Internal_ExpandBy_FVector_FVector(in FBox a, in FVector v, in FVector v2);

		// Token: 0x060000A3 RID: 163
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBox Internal_ShiftBy(in FBox a, in FVector v);

		// Token: 0x060000A4 RID: 164
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBox Internal_MoveTo(in FBox a, in FVector v);

		// Token: 0x060000A5 RID: 165
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_GetCenter(in FBox a);

		// Token: 0x060000A6 RID: 166
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_GetCenterAndExtents(in FBox a, out FVector outCenter, out FVector outExtents);

		// Token: 0x060000A7 RID: 167
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_GetClosestPointTo(in FBox a, in FVector v);

		// Token: 0x060000A8 RID: 168
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_GetExtent(in FBox a);

		// Token: 0x060000A9 RID: 169
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_GetSize(in FBox a);

		// Token: 0x060000AA RID: 170
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_GetVolume(in FBox a);

		// Token: 0x060000AB RID: 171
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_Intersect(in FBox a, in FBox r);

		// Token: 0x060000AC RID: 172
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IntersectXY(in FBox a, in FBox r);

		// Token: 0x060000AD RID: 173
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IsInside_FVector(in FBox a, in FVector v);

		// Token: 0x060000AE RID: 174
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IsInsideOrOn(in FBox a, in FVector v);

		// Token: 0x060000AF RID: 175
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IsInside_FBox(in FBox a, in FBox r);

		// Token: 0x060000B0 RID: 176
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IsInsideXY_FVector(in FBox a, in FVector v);

		// Token: 0x060000B1 RID: 177
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IsInsideOrOnXY(in FBox a, in FVector v);

		// Token: 0x060000B2 RID: 178
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IsInsideXY_FBox(in FBox a, in FBox r);

		// Token: 0x060000B3 RID: 179
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBox Internal_TransformBy_FMatrix(in FBox a, in FMatrix m);

		// Token: 0x060000B4 RID: 180
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBox Internal_TransformBy_FTransform(in FBox a, in FTransform tf);

		// Token: 0x060000B5 RID: 181
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBox Internal_InverseTransformBy(in FBox a, in FTransform tf);

		// Token: 0x060000B6 RID: 182
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBox Internal_TransformProjectBy(in FBox a, in FMatrix m);

		// Token: 0x060000B7 RID: 183
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBox Internal_Overlap(in FBox a, in FBox r);

		// Token: 0x060000B8 RID: 184
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBox Internal_BuildAABB(in FVector a, in FVector r);

		// Token: 0x060000B9 RID: 185 RVA: 0x00005F88 File Offset: 0x00004188
		public static bool operator ==(FBox left, FBox right)
		{
			return FBox.Internal_Eq(left, right);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00005F93 File Offset: 0x00004193
		public static bool operator !=(FBox left, FBox right)
		{
			return FBox.Internal_NotEq(left, right);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00005FA0 File Offset: 0x000041A0
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

		// Token: 0x060000BC RID: 188 RVA: 0x00005FC0 File Offset: 0x000041C0
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

		// Token: 0x060000BD RID: 189 RVA: 0x00005FDC File Offset: 0x000041DC
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

		// Token: 0x060000BE RID: 190 RVA: 0x00005FF8 File Offset: 0x000041F8
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

		// Token: 0x060000BF RID: 191 RVA: 0x00006014 File Offset: 0x00004214
		public unsafe readonly FBox ExpandBy(float w)
		{
			fixed (FBox* ptr = &this)
			{
				return FBox.Internal_ExpandBy_float(this, w);
			}
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x0000602C File Offset: 0x0000422C
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

		// Token: 0x060000C1 RID: 193 RVA: 0x00006048 File Offset: 0x00004248
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

		// Token: 0x060000C2 RID: 194 RVA: 0x0000606C File Offset: 0x0000426C
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

		// Token: 0x060000C3 RID: 195 RVA: 0x00006088 File Offset: 0x00004288
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

		// Token: 0x060000C4 RID: 196 RVA: 0x000060A4 File Offset: 0x000042A4
		public unsafe readonly FVector GetCenter()
		{
			fixed (FBox* ptr = &this)
			{
				return FBox.Internal_GetCenter(this);
			}
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x000060BC File Offset: 0x000042BC
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

		// Token: 0x060000C6 RID: 198 RVA: 0x000060E8 File Offset: 0x000042E8
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

		// Token: 0x060000C7 RID: 199 RVA: 0x00006104 File Offset: 0x00004304
		public unsafe readonly FVector GetExtent()
		{
			fixed (FBox* ptr = &this)
			{
				return FBox.Internal_GetExtent(this);
			}
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x0000611C File Offset: 0x0000431C
		public unsafe readonly FVector GetSize()
		{
			fixed (FBox* ptr = &this)
			{
				return FBox.Internal_GetSize(this);
			}
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00006134 File Offset: 0x00004334
		public unsafe readonly float GetVolume()
		{
			fixed (FBox* ptr = &this)
			{
				return FBox.Internal_GetVolume(this);
			}
		}

		// Token: 0x060000CA RID: 202 RVA: 0x0000614C File Offset: 0x0000434C
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

		// Token: 0x060000CB RID: 203 RVA: 0x00006168 File Offset: 0x00004368
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

		// Token: 0x060000CC RID: 204 RVA: 0x00006184 File Offset: 0x00004384
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

		// Token: 0x060000CD RID: 205 RVA: 0x000061A0 File Offset: 0x000043A0
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

		// Token: 0x060000CE RID: 206 RVA: 0x000061BC File Offset: 0x000043BC
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

		// Token: 0x060000CF RID: 207 RVA: 0x000061D8 File Offset: 0x000043D8
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

		// Token: 0x060000D0 RID: 208 RVA: 0x000061F4 File Offset: 0x000043F4
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

		// Token: 0x060000D1 RID: 209 RVA: 0x00006210 File Offset: 0x00004410
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

		// Token: 0x060000D2 RID: 210 RVA: 0x0000622C File Offset: 0x0000442C
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

		// Token: 0x060000D3 RID: 211 RVA: 0x00006248 File Offset: 0x00004448
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

		// Token: 0x060000D4 RID: 212 RVA: 0x00006264 File Offset: 0x00004464
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

		// Token: 0x060000D5 RID: 213 RVA: 0x00006280 File Offset: 0x00004480
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

		// Token: 0x060000D6 RID: 214 RVA: 0x0000629C File Offset: 0x0000449C
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

		// Token: 0x060000D7 RID: 215 RVA: 0x000062B8 File Offset: 0x000044B8
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

		// Token: 0x060000D8 RID: 216 RVA: 0x000062D4 File Offset: 0x000044D4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBox._ScriptStructPtr != 0) ? FBox._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.Box", ref FBox._ScriptStructPtr);
		}

		// Token: 0x0400005B RID: 91
		public static readonly FBox ForceInit = new FBox
		{
			IsValid = 0
		};

		// Token: 0x0400005C RID: 92
		[FieldOffset(0)]
		public FVector Min;

		// Token: 0x0400005D RID: 93
		[FieldOffset(12)]
		public FVector Max;

		// Token: 0x0400005E RID: 94
		[FieldOffset(24)]
		public byte IsValid;

		// Token: 0x0400005F RID: 95
		public const string __ObjectPath = "/Script/CoreUObject.Box";

		// Token: 0x04000060 RID: 96
		private static IntPtr _ScriptStructPtr;
	}
}
