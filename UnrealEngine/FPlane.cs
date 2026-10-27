using System;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000037 RID: 55
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(16, 16, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 16)]
	[UnrealObjectPath("/Script/CoreUObject.Plane")]
	[StructLayout(LayoutKind.Explicit, Pack = 16, Size = 16)]
	public struct FPlane : IEquatable<FPlane>, IEqualityOperators<FPlane, FPlane, bool>, IUnrealScriptStruct
	{
		// Token: 0x06000328 RID: 808 RVA: 0x00009ADB File Offset: 0x00007CDB
		public FPlane()
		{
			this.X = 0f;
			this.Y = 0f;
			this.Z = 0f;
			this.W = 0f;
		}

		// Token: 0x06000329 RID: 809 RVA: 0x00009B09 File Offset: 0x00007D09
		public FPlane(float x, float y, float z, float w)
		{
			this.X = x;
			this.Y = y;
			this.Z = z;
			this.W = w;
		}

		// Token: 0x0600032A RID: 810 RVA: 0x00009B28 File Offset: 0x00007D28
		public FPlane(in FVector4 v)
		{
			this.X = v.X;
			this.Y = v.Y;
			this.Z = v.Z;
			this.W = v.W;
		}

		// Token: 0x0600032B RID: 811 RVA: 0x00009B5A File Offset: 0x00007D5A
		public FPlane(in FVector normal, float w)
		{
			this.X = normal.X;
			this.Y = normal.Y;
			this.Z = normal.Z;
			this.W = w;
		}

		// Token: 0x0600032C RID: 812 RVA: 0x00009B87 File Offset: 0x00007D87
		public static bool operator ==(FPlane a, FPlane b)
		{
			return a.X == b.X && a.Y == b.Y && a.Z == b.Z && a.W == b.W;
		}

		// Token: 0x0600032D RID: 813 RVA: 0x00009BC3 File Offset: 0x00007DC3
		public static bool operator !=(FPlane a, FPlane b)
		{
			return a.X != b.X || a.Y != b.Y || a.Z != b.Z || a.W != b.W;
		}

		// Token: 0x0600032E RID: 814 RVA: 0x00009C02 File Offset: 0x00007E02
		public readonly bool Equals(FPlane other)
		{
			return this == other;
		}

		// Token: 0x0600032F RID: 815 RVA: 0x00009C10 File Offset: 0x00007E10
		[NullableContext(2)]
		public override readonly bool Equals(object obj)
		{
			if (obj is FPlane)
			{
				FPlane b = (FPlane)obj;
				return this == b;
			}
			return false;
		}

		// Token: 0x06000330 RID: 816 RVA: 0x00009C3A File Offset: 0x00007E3A
		public override readonly int GetHashCode()
		{
			return HashCode.Combine<float, float, float, float>(this.X, this.Y, this.Z, this.W);
		}

		// Token: 0x1700000B RID: 11
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

		// Token: 0x06000333 RID: 819 RVA: 0x00009CEB File Offset: 0x00007EEB
		public static FPlane operator *(float scale, in FPlane p)
		{
			return p * scale;
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000334 RID: 820 RVA: 0x00009CF4 File Offset: 0x00007EF4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public readonly ref FPlaneView View
		{
			get
			{
				return Unsafe.As<FPlane, FPlaneView>(Unsafe.AsRef<FPlane>(ref this));
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000335 RID: 821 RVA: 0x00009D01 File Offset: 0x00007F01
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref FPlaneView RwView
		{
			get
			{
				return Unsafe.As<FPlane, FPlaneView>(Unsafe.AsRef<FPlane>(ref this));
			}
		}

		// Token: 0x06000336 RID: 822
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FPlane Internal_Ctor_FVector_FVector(in FVector @base, in FVector normal);

		// Token: 0x06000337 RID: 823
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FPlane Internal_Ctor_FVector_FVector_FVector(in FVector a, in FVector b, in FVector c);

		// Token: 0x06000338 RID: 824
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_Equals(in FPlane a, in FPlane b, float tolerance);

		// Token: 0x06000339 RID: 825
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IsValid(in FPlane plane);

		// Token: 0x0600033A RID: 826
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_GetOrigin(in FPlane plane);

		// Token: 0x0600033B RID: 827
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_GetNormal(in FPlane plane);

		// Token: 0x0600033C RID: 828
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_PlaneDot(in FPlane plane, in FVector p);

		// Token: 0x0600033D RID: 829
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_Normalize(ref FPlane plane, float tolerance);

		// Token: 0x0600033E RID: 830
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FPlane Internal_Flip(in FPlane plane);

		// Token: 0x0600033F RID: 831
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FPlane Internal_TransformBy(in FPlane plane, in FMatrix m);

		// Token: 0x06000340 RID: 832
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FPlane Internal_TransformByUsingAdjointT(in FPlane plane, in FMatrix m, float detM, in FMatrix ta);

		// Token: 0x06000341 RID: 833
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FPlane Internal_Add(in FPlane a, in FPlane b);

		// Token: 0x06000342 RID: 834
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FPlane Internal_Sub(in FPlane a, in FPlane b);

		// Token: 0x06000343 RID: 835
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FPlane Internal_Mul(in FPlane a, in FPlane b);

		// Token: 0x06000344 RID: 836
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FPlane Internal_MulFloat(in FPlane plane, float scale);

		// Token: 0x06000345 RID: 837
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FPlane Internal_DivFloat(in FPlane plane, float scale);

		// Token: 0x06000346 RID: 838
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_Or(in FPlane a, in FPlane b);

		// Token: 0x06000347 RID: 839 RVA: 0x00009D10 File Offset: 0x00007F10
		public unsafe FPlane(in FVector @base, in FVector normal)
		{
			fixed (FVector* ptr = &@base)
			{
				fixed (FVector* ptr2 = &normal)
				{
					fixed (FPlane* ptr3 = &this)
					{
						this = FPlane.Internal_Ctor_FVector_FVector(@base, normal);
					}
				}
			}
		}

		// Token: 0x06000348 RID: 840 RVA: 0x00009D40 File Offset: 0x00007F40
		public unsafe FPlane(in FVector a, in FVector b, in FVector c)
		{
			fixed (FVector* ptr = &a)
			{
				fixed (FVector* ptr2 = &b)
				{
					fixed (FVector* ptr3 = &c)
					{
						fixed (FPlane* ptr4 = &this)
						{
							this = FPlane.Internal_Ctor_FVector_FVector_FVector(a, b, c);
						}
					}
				}
			}
		}

		// Token: 0x06000349 RID: 841 RVA: 0x00009D78 File Offset: 0x00007F78
		public unsafe static FPlane operator +(in FPlane a, in FPlane b)
		{
			fixed (FPlane* ptr = &a)
			{
				fixed (FPlane* ptr2 = &b)
				{
					return FPlane.Internal_Add(a, b);
				}
			}
		}

		// Token: 0x0600034A RID: 842 RVA: 0x00009D94 File Offset: 0x00007F94
		public unsafe static FPlane operator -(in FPlane a, in FPlane b)
		{
			fixed (FPlane* ptr = &a)
			{
				fixed (FPlane* ptr2 = &b)
				{
					return FPlane.Internal_Sub(a, b);
				}
			}
		}

		// Token: 0x0600034B RID: 843 RVA: 0x00009DB0 File Offset: 0x00007FB0
		public unsafe static FPlane operator *(in FPlane a, in FPlane b)
		{
			fixed (FPlane* ptr = &a)
			{
				fixed (FPlane* ptr2 = &b)
				{
					return FPlane.Internal_Mul(a, b);
				}
			}
		}

		// Token: 0x0600034C RID: 844 RVA: 0x00009DCC File Offset: 0x00007FCC
		public unsafe static FPlane operator *(in FPlane plane, float scale)
		{
			fixed (FPlane* ptr = &plane)
			{
				return FPlane.Internal_MulFloat(plane, scale);
			}
		}

		// Token: 0x0600034D RID: 845 RVA: 0x00009DE4 File Offset: 0x00007FE4
		public unsafe static FPlane operator /(in FPlane plane, float scale)
		{
			fixed (FPlane* ptr = &plane)
			{
				return FPlane.Internal_DivFloat(plane, scale);
			}
		}

		// Token: 0x0600034E RID: 846 RVA: 0x00009DFC File Offset: 0x00007FFC
		public unsafe static float operator |(in FPlane a, in FPlane b)
		{
			fixed (FPlane* ptr = &a)
			{
				fixed (FPlane* ptr2 = &b)
				{
					return FPlane.Internal_Or(a, b);
				}
			}
		}

		// Token: 0x0600034F RID: 847 RVA: 0x00009E18 File Offset: 0x00008018
		public unsafe readonly bool Equals(in FPlane other, float tolerance = 0.0001f)
		{
			fixed (FPlane* ptr = &this)
			{
				fixed (FPlane* ptr2 = &other)
				{
					return FPlane.Internal_Equals(this, other, tolerance);
				}
			}
		}

		// Token: 0x06000350 RID: 848 RVA: 0x00009E38 File Offset: 0x00008038
		public unsafe readonly bool IsValid()
		{
			fixed (FPlane* ptr = &this)
			{
				return FPlane.Internal_IsValid(this);
			}
		}

		// Token: 0x06000351 RID: 849 RVA: 0x00009E50 File Offset: 0x00008050
		public unsafe readonly FVector GetOrigin()
		{
			fixed (FPlane* ptr = &this)
			{
				return FPlane.Internal_GetOrigin(this);
			}
		}

		// Token: 0x06000352 RID: 850 RVA: 0x00009E68 File Offset: 0x00008068
		public unsafe readonly FVector GetNormal()
		{
			fixed (FPlane* ptr = &this)
			{
				return FPlane.Internal_GetNormal(this);
			}
		}

		// Token: 0x06000353 RID: 851 RVA: 0x00009E80 File Offset: 0x00008080
		public unsafe readonly float PlaneDot(in FVector p)
		{
			fixed (FPlane* ptr = &this)
			{
				fixed (FVector* ptr2 = &p)
				{
					return FPlane.Internal_PlaneDot(this, p);
				}
			}
		}

		// Token: 0x06000354 RID: 852 RVA: 0x00009E9C File Offset: 0x0000809C
		public unsafe bool Normalize(float tolerance = 1E-08f)
		{
			fixed (FPlane* ptr = &this)
			{
				return FPlane.Internal_Normalize(ref this, tolerance);
			}
		}

		// Token: 0x06000355 RID: 853 RVA: 0x00009EB4 File Offset: 0x000080B4
		public unsafe readonly FPlane Flip()
		{
			fixed (FPlane* ptr = &this)
			{
				return FPlane.Internal_Flip(this);
			}
		}

		// Token: 0x06000356 RID: 854 RVA: 0x00009ECC File Offset: 0x000080CC
		public unsafe readonly FPlane TransformBy(in FMatrix m)
		{
			fixed (FPlane* ptr = &this)
			{
				fixed (FMatrix* ptr2 = &m)
				{
					return FPlane.Internal_TransformBy(this, m);
				}
			}
		}

		// Token: 0x06000357 RID: 855 RVA: 0x00009EE8 File Offset: 0x000080E8
		public unsafe readonly FPlane TransformByUsingAdjointT(in FMatrix m, float detM, in FMatrix ta)
		{
			fixed (FPlane* ptr = &this)
			{
				fixed (FMatrix* ptr2 = &m)
				{
					fixed (FMatrix* ptr3 = &ta)
					{
						return FPlane.Internal_TransformByUsingAdjointT(this, m, detM, ta);
					}
				}
			}
		}

		// Token: 0x06000358 RID: 856 RVA: 0x00009F0A File Offset: 0x0000810A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPlane._ScriptStructPtr != 0) ? FPlane._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.Plane", ref FPlane._ScriptStructPtr);
		}

		// Token: 0x040000D9 RID: 217
		[FieldOffset(0)]
		public float X;

		// Token: 0x040000DA RID: 218
		[FieldOffset(4)]
		public float Y;

		// Token: 0x040000DB RID: 219
		[FieldOffset(8)]
		public float Z;

		// Token: 0x040000DC RID: 220
		[FieldOffset(12)]
		public float W;

		// Token: 0x040000DD RID: 221
		public const string __ObjectPath = "/Script/CoreUObject.Plane";

		// Token: 0x040000DE RID: 222
		private static IntPtr _ScriptStructPtr;
	}
}
