using System;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200001C RID: 28
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(16, 16, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 16)]
	[UnrealObjectPath("/Script/CoreUObject.Plane")]
	[StructLayout(LayoutKind.Explicit, Pack = 16, Size = 16)]
	public struct FPlane : IEquatable<FPlane>, IEqualityOperators<FPlane, FPlane, bool>, IUnrealScriptStruct
	{
		// Token: 0x060002AD RID: 685 RVA: 0x00006347 File Offset: 0x00004547
		public FPlane()
		{
			this.X = 0f;
			this.Y = 0f;
			this.Z = 0f;
			this.W = 0f;
		}

		// Token: 0x060002AE RID: 686 RVA: 0x00006375 File Offset: 0x00004575
		public FPlane(float x, float y, float z, float w)
		{
			this.X = x;
			this.Y = y;
			this.Z = z;
			this.W = w;
		}

		// Token: 0x060002AF RID: 687 RVA: 0x00006394 File Offset: 0x00004594
		public FPlane(in FVector4 v)
		{
			this.X = v.X;
			this.Y = v.Y;
			this.Z = v.Z;
			this.W = v.W;
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x000063C6 File Offset: 0x000045C6
		public FPlane(in FVector normal, float w)
		{
			this.X = normal.X;
			this.Y = normal.Y;
			this.Z = normal.Z;
			this.W = w;
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x000063F3 File Offset: 0x000045F3
		public static bool operator ==(FPlane a, FPlane b)
		{
			return a.X == b.X && a.Y == b.Y && a.Z == b.Z && a.W == b.W;
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x0000642F File Offset: 0x0000462F
		public static bool operator !=(FPlane a, FPlane b)
		{
			return a.X != b.X || a.Y != b.Y || a.Z != b.Z || a.W != b.W;
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x0000646E File Offset: 0x0000466E
		public readonly bool Equals(FPlane other)
		{
			return this == other;
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x0000647C File Offset: 0x0000467C
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

		// Token: 0x060002B5 RID: 693 RVA: 0x000064A6 File Offset: 0x000046A6
		public override readonly int GetHashCode()
		{
			return HashCode.Combine<float, float, float, float>(this.X, this.Y, this.Z, this.W);
		}

		// Token: 0x1700000A RID: 10
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

		// Token: 0x060002B8 RID: 696 RVA: 0x00006557 File Offset: 0x00004757
		public static FPlane operator *(float scale, in FPlane p)
		{
			return p * scale;
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x060002B9 RID: 697 RVA: 0x00006560 File Offset: 0x00004760
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public readonly ref FPlaneView View
		{
			get
			{
				return Unsafe.As<FPlane, FPlaneView>(Unsafe.AsRef<FPlane>(ref this));
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x060002BA RID: 698 RVA: 0x0000656D File Offset: 0x0000476D
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref FPlaneView RwView
		{
			get
			{
				return Unsafe.As<FPlane, FPlaneView>(Unsafe.AsRef<FPlane>(ref this));
			}
		}

		// Token: 0x060002BB RID: 699
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FPlane Internal_Ctor_FVector_FVector(in FVector @base, in FVector normal);

		// Token: 0x060002BC RID: 700
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FPlane Internal_Ctor_FVector_FVector_FVector(in FVector a, in FVector b, in FVector c);

		// Token: 0x060002BD RID: 701
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_Equals(in FPlane a, in FPlane b, float tolerance);

		// Token: 0x060002BE RID: 702
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IsValid(in FPlane plane);

		// Token: 0x060002BF RID: 703
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_GetOrigin(in FPlane plane);

		// Token: 0x060002C0 RID: 704
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_GetNormal(in FPlane plane);

		// Token: 0x060002C1 RID: 705
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_PlaneDot(in FPlane plane, in FVector p);

		// Token: 0x060002C2 RID: 706
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_Normalize(ref FPlane plane, float tolerance);

		// Token: 0x060002C3 RID: 707
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FPlane Internal_Flip(in FPlane plane);

		// Token: 0x060002C4 RID: 708
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FPlane Internal_TransformBy(in FPlane plane, in FMatrix m);

		// Token: 0x060002C5 RID: 709
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FPlane Internal_TransformByUsingAdjointT(in FPlane plane, in FMatrix m, float detM, in FMatrix ta);

		// Token: 0x060002C6 RID: 710
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FPlane Internal_Add(in FPlane a, in FPlane b);

		// Token: 0x060002C7 RID: 711
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FPlane Internal_Sub(in FPlane a, in FPlane b);

		// Token: 0x060002C8 RID: 712
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FPlane Internal_Mul(in FPlane a, in FPlane b);

		// Token: 0x060002C9 RID: 713
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FPlane Internal_MulFloat(in FPlane plane, float scale);

		// Token: 0x060002CA RID: 714
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FPlane Internal_DivFloat(in FPlane plane, float scale);

		// Token: 0x060002CB RID: 715
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_Or(in FPlane a, in FPlane b);

		// Token: 0x060002CC RID: 716 RVA: 0x0000657C File Offset: 0x0000477C
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

		// Token: 0x060002CD RID: 717 RVA: 0x000065AC File Offset: 0x000047AC
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

		// Token: 0x060002CE RID: 718 RVA: 0x000065E4 File Offset: 0x000047E4
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

		// Token: 0x060002CF RID: 719 RVA: 0x00006600 File Offset: 0x00004800
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

		// Token: 0x060002D0 RID: 720 RVA: 0x0000661C File Offset: 0x0000481C
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

		// Token: 0x060002D1 RID: 721 RVA: 0x00006638 File Offset: 0x00004838
		public unsafe static FPlane operator *(in FPlane plane, float scale)
		{
			fixed (FPlane* ptr = &plane)
			{
				return FPlane.Internal_MulFloat(plane, scale);
			}
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x00006650 File Offset: 0x00004850
		public unsafe static FPlane operator /(in FPlane plane, float scale)
		{
			fixed (FPlane* ptr = &plane)
			{
				return FPlane.Internal_DivFloat(plane, scale);
			}
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x00006668 File Offset: 0x00004868
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

		// Token: 0x060002D4 RID: 724 RVA: 0x00006684 File Offset: 0x00004884
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

		// Token: 0x060002D5 RID: 725 RVA: 0x000066A4 File Offset: 0x000048A4
		public unsafe readonly bool IsValid()
		{
			fixed (FPlane* ptr = &this)
			{
				return FPlane.Internal_IsValid(this);
			}
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x000066BC File Offset: 0x000048BC
		public unsafe readonly FVector GetOrigin()
		{
			fixed (FPlane* ptr = &this)
			{
				return FPlane.Internal_GetOrigin(this);
			}
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x000066D4 File Offset: 0x000048D4
		public unsafe readonly FVector GetNormal()
		{
			fixed (FPlane* ptr = &this)
			{
				return FPlane.Internal_GetNormal(this);
			}
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x000066EC File Offset: 0x000048EC
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

		// Token: 0x060002D9 RID: 729 RVA: 0x00006708 File Offset: 0x00004908
		public unsafe bool Normalize(float tolerance = 1E-08f)
		{
			fixed (FPlane* ptr = &this)
			{
				return FPlane.Internal_Normalize(ref this, tolerance);
			}
		}

		// Token: 0x060002DA RID: 730 RVA: 0x00006720 File Offset: 0x00004920
		public unsafe readonly FPlane Flip()
		{
			fixed (FPlane* ptr = &this)
			{
				return FPlane.Internal_Flip(this);
			}
		}

		// Token: 0x060002DB RID: 731 RVA: 0x00006738 File Offset: 0x00004938
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

		// Token: 0x060002DC RID: 732 RVA: 0x00006754 File Offset: 0x00004954
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

		// Token: 0x060002DD RID: 733 RVA: 0x00006776 File Offset: 0x00004976
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPlane._ScriptStructPtr != 0) ? FPlane._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.Plane", ref FPlane._ScriptStructPtr);
		}

		// Token: 0x04000092 RID: 146
		[FieldOffset(0)]
		public float X;

		// Token: 0x04000093 RID: 147
		[FieldOffset(4)]
		public float Y;

		// Token: 0x04000094 RID: 148
		[FieldOffset(8)]
		public float Z;

		// Token: 0x04000095 RID: 149
		[FieldOffset(12)]
		public float W;

		// Token: 0x04000096 RID: 150
		public const string __ObjectPath = "/Script/CoreUObject.Plane";

		// Token: 0x04000097 RID: 151
		private static IntPtr _ScriptStructPtr;
	}
}
