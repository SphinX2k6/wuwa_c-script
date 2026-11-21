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
	// Token: 0x0200001F RID: 31
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 12)]
	[UnrealObjectPath("/Script/CoreUObject.Rotator")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 12)]
	public struct FRotator : IEquatable<FRotator>, IEqualityOperators<FRotator, FRotator, bool>, IRotator, IUnrealScriptStruct
	{
		// Token: 0x06000385 RID: 901 RVA: 0x00007584 File Offset: 0x00005784
		[Conditional("ENABLE_NAN_DIAGNOSTIC")]
		public void DiagnosticCheckNaN()
		{
			if (!SharpherealAssert.Ensure(!this.ContainsNaN(), "FRotator contains NaN: {0}", new object[]
			{
				this
			}))
			{
				this = FRotator.ZeroRotator;
			}
		}

		// Token: 0x06000386 RID: 902 RVA: 0x000075BA File Offset: 0x000057BA
		public FRotator()
		{
			this.Pitch = 0f;
			this.Yaw = 0f;
			this.Roll = 0f;
		}

		// Token: 0x06000387 RID: 903 RVA: 0x000075DD File Offset: 0x000057DD
		public FRotator(float value)
		{
			this.Pitch = value;
			this.Yaw = value;
			this.Roll = value;
		}

		// Token: 0x06000388 RID: 904 RVA: 0x000075F4 File Offset: 0x000057F4
		public FRotator(float inPitch, float inYaw, float inRoll)
		{
			this.Pitch = inPitch;
			this.Yaw = inYaw;
			this.Roll = inRoll;
		}

		// Token: 0x06000389 RID: 905 RVA: 0x0000760B File Offset: 0x0000580B
		public FRotator(FQuat quat)
		{
			this = quat.Rotator();
		}

		// Token: 0x0600038A RID: 906 RVA: 0x0000761A File Offset: 0x0000581A
		public static bool operator ==(FRotator a, FRotator b)
		{
			return a.Pitch == b.Pitch && a.Yaw == b.Yaw && a.Roll == b.Roll;
		}

		// Token: 0x0600038B RID: 907 RVA: 0x00007648 File Offset: 0x00005848
		public static bool operator !=(FRotator a, FRotator b)
		{
			return a.Pitch != b.Pitch || a.Yaw != b.Yaw || a.Roll != b.Roll;
		}

		// Token: 0x0600038C RID: 908 RVA: 0x00007679 File Offset: 0x00005879
		public readonly bool Equals(FRotator other)
		{
			return this == other;
		}

		// Token: 0x0600038D RID: 909 RVA: 0x00007688 File Offset: 0x00005888
		[NullableContext(2)]
		public override readonly bool Equals(object obj)
		{
			if (obj is FRotator)
			{
				FRotator b = (FRotator)obj;
				return this == b;
			}
			return false;
		}

		// Token: 0x0600038E RID: 910 RVA: 0x000076B2 File Offset: 0x000058B2
		public override readonly int GetHashCode()
		{
			return HashCode.Combine<float, float, float>(this.Pitch, this.Yaw, this.Roll);
		}

		// Token: 0x0600038F RID: 911 RVA: 0x000076CC File Offset: 0x000058CC
		[NullableContext(1)]
		public override readonly string ToString()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(8, 3);
			defaultInterpolatedStringHandler.AppendLiteral("P=");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.Pitch);
			defaultInterpolatedStringHandler.AppendLiteral(" Y=");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.Yaw);
			defaultInterpolatedStringHandler.AppendLiteral(" R=");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.Roll);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x06000390 RID: 912 RVA: 0x00007734 File Offset: 0x00005934
		public static FRotator operator *(float scale, in FRotator r)
		{
			return r * scale;
		}

		// Token: 0x06000391 RID: 913 RVA: 0x00007740 File Offset: 0x00005940
		public readonly FVectorDouble VectorDouble()
		{
			FVector fvector = this.Vector();
			return fvector;
		}

		// Token: 0x06000392 RID: 914 RVA: 0x0000775C File Offset: 0x0000595C
		public readonly FVectorDouble RotateVectorDouble(in FVectorDouble vector)
		{
			FVector fvector = vector;
			FVector fvector2 = this.RotateVector(fvector);
			return fvector2;
		}

		// Token: 0x06000393 RID: 915
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Internal_ClampAxis(float angle);

		// Token: 0x06000394 RID: 916
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Internal_NormalizeAxis(float angle);

		// Token: 0x06000395 RID: 917
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern byte Internal_CompressAxisToByte(float angle);

		// Token: 0x06000396 RID: 918
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Internal_DecompressAxisFromByte(byte compressed);

		// Token: 0x06000397 RID: 919
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern ushort Internal_CompressAxisToShort(float angle);

		// Token: 0x06000398 RID: 920
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Internal_DecompressAxisFromShort(ushort compressed);

		// Token: 0x06000399 RID: 921
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator Internal_MakeFromEuler(in FVector euler);

		// Token: 0x0600039A RID: 922
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator Internal_Add(in FRotator a, in FRotator b);

		// Token: 0x0600039B RID: 923
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator Internal_Sub(in FRotator a, in FRotator b);

		// Token: 0x0600039C RID: 924
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator Internal_Mul(in FRotator a, float scale);

		// Token: 0x0600039D RID: 925
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_Equals(in FRotator a, in FRotator other, float tolerance);

		// Token: 0x0600039E RID: 926
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IsNearlyZero(in FRotator a);

		// Token: 0x0600039F RID: 927
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IsZero(in FRotator a);

		// Token: 0x060003A0 RID: 928
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Add_float_float_float(ref FRotator a, float pitch, float yaw, float roll);

		// Token: 0x060003A1 RID: 929
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator Internal_GetInverse(in FRotator a);

		// Token: 0x060003A2 RID: 930
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator Internal_GridSnap(in FRotator a, in FRotator grid);

		// Token: 0x060003A3 RID: 931
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_Vector(in FRotator a);

		// Token: 0x060003A4 RID: 932
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat Internal_Quaternion(in FRotator a);

		// Token: 0x060003A5 RID: 933
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_Euler(in FRotator a);

		// Token: 0x060003A6 RID: 934
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_RotateVector(in FRotator a, in FVector vector);

		// Token: 0x060003A7 RID: 935
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_UnrotateVector(in FRotator a, in FVector vector);

		// Token: 0x060003A8 RID: 936
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator Internal_Clamp(in FRotator a);

		// Token: 0x060003A9 RID: 937
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator Internal_GetNormalized(in FRotator a);

		// Token: 0x060003AA RID: 938
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator Internal_GetDenormalized(in FRotator a);

		// Token: 0x060003AB RID: 939
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Normalize(ref FRotator a);

		// Token: 0x060003AC RID: 940
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_GetComponentForAxis(in FRotator a, EAxis axis);

		// Token: 0x060003AD RID: 941
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_SetComponentForAxis(ref FRotator a, EAxis axis, float value);

		// Token: 0x060003AE RID: 942
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_GetWindingAndRemainder(in FRotator a, out FRotator winding, out FRotator remainder);

		// Token: 0x060003AF RID: 943
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_GetManhattanDistance(in FRotator a, in FRotator other);

		// Token: 0x060003B0 RID: 944
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator Internal_GetEquivalentRotator(in FRotator a);

		// Token: 0x060003B1 RID: 945
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_SetClosestToMe(in FRotator a, ref FRotator other);

		// Token: 0x060003B2 RID: 946
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_ContainsNaN(in FRotator a);

		// Token: 0x060003B3 RID: 947 RVA: 0x00007780 File Offset: 0x00005980
		public static float ClampAxis(float angle)
		{
			return FRotator.Internal_ClampAxis(angle);
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x00007788 File Offset: 0x00005988
		public static float NormalizeAxis(float angle)
		{
			return FRotator.Internal_NormalizeAxis(angle);
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x00007790 File Offset: 0x00005990
		public static byte CompressAxisToByte(float angle)
		{
			return FRotator.Internal_CompressAxisToByte(angle);
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x00007798 File Offset: 0x00005998
		public static float DecompressAxisFromByte(byte compressed)
		{
			return FRotator.Internal_DecompressAxisFromByte(compressed);
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x000077A0 File Offset: 0x000059A0
		public static ushort CompressAxisToShort(float angle)
		{
			return FRotator.Internal_CompressAxisToShort(angle);
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x000077A8 File Offset: 0x000059A8
		public static float DecompressAxisFromShort(ushort compressed)
		{
			return FRotator.Internal_DecompressAxisFromShort(compressed);
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x000077B0 File Offset: 0x000059B0
		public unsafe static FRotator MakeFromEuler(in FVector euler)
		{
			fixed (FVector* ptr = &euler)
			{
				return FRotator.Internal_MakeFromEuler(euler);
			}
		}

		// Token: 0x060003BA RID: 954 RVA: 0x000077C8 File Offset: 0x000059C8
		public unsafe static FRotator operator +(in FRotator a, in FRotator b)
		{
			fixed (FRotator* ptr = &a)
			{
				fixed (FRotator* ptr2 = &b)
				{
					return FRotator.Internal_Add(a, b);
				}
			}
		}

		// Token: 0x060003BB RID: 955 RVA: 0x000077E4 File Offset: 0x000059E4
		public unsafe static FRotator operator -(in FRotator a, in FRotator b)
		{
			fixed (FRotator* ptr = &a)
			{
				fixed (FRotator* ptr2 = &b)
				{
					return FRotator.Internal_Sub(a, b);
				}
			}
		}

		// Token: 0x060003BC RID: 956 RVA: 0x00007800 File Offset: 0x00005A00
		public unsafe static FRotator operator *(in FRotator a, float scale)
		{
			fixed (FRotator* ptr = &a)
			{
				return FRotator.Internal_Mul(a, scale);
			}
		}

		// Token: 0x060003BD RID: 957 RVA: 0x00007818 File Offset: 0x00005A18
		public unsafe readonly bool Equals(in FRotator other, float tolerance = 0.0001f)
		{
			fixed (FRotator* ptr = &other)
			{
				fixed (FRotator* ptr2 = &this)
				{
					return FRotator.Internal_Equals(this, other, tolerance);
				}
			}
		}

		// Token: 0x060003BE RID: 958 RVA: 0x00007838 File Offset: 0x00005A38
		public unsafe readonly bool IsNearlyZero()
		{
			fixed (FRotator* ptr = &this)
			{
				return FRotator.Internal_IsNearlyZero(this);
			}
		}

		// Token: 0x060003BF RID: 959 RVA: 0x00007850 File Offset: 0x00005A50
		public unsafe readonly bool IsZero()
		{
			fixed (FRotator* ptr = &this)
			{
				return FRotator.Internal_IsZero(this);
			}
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x00007868 File Offset: 0x00005A68
		public unsafe FRotator Add(float pitch, float yaw, float roll)
		{
			fixed (FRotator* ptr = &this)
			{
				FRotator.Internal_Add_float_float_float(ref this, pitch, yaw, roll);
			}
			return this;
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x0000788C File Offset: 0x00005A8C
		public unsafe readonly FRotator GetInverse()
		{
			fixed (FRotator* ptr = &this)
			{
				return FRotator.Internal_GetInverse(this);
			}
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x000078A4 File Offset: 0x00005AA4
		public unsafe readonly FRotator GridSnap(in FRotator grid)
		{
			fixed (FRotator* ptr = &this)
			{
				fixed (FRotator* ptr2 = &grid)
				{
					return FRotator.Internal_GridSnap(this, grid);
				}
			}
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x000078C0 File Offset: 0x00005AC0
		public unsafe readonly FVector Vector()
		{
			fixed (FRotator* ptr = &this)
			{
				return FRotator.Internal_Vector(this);
			}
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x000078D8 File Offset: 0x00005AD8
		public unsafe readonly FQuat Quaternion()
		{
			fixed (FRotator* ptr = &this)
			{
				return FRotator.Internal_Quaternion(this);
			}
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x000078F0 File Offset: 0x00005AF0
		public unsafe readonly FVector Euler()
		{
			fixed (FRotator* ptr = &this)
			{
				return FRotator.Internal_Euler(this);
			}
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x00007908 File Offset: 0x00005B08
		public unsafe readonly FVector RotateVector(in FVector vector)
		{
			fixed (FRotator* ptr = &this)
			{
				fixed (FVector* ptr2 = &vector)
				{
					return FRotator.Internal_RotateVector(this, vector);
				}
			}
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x00007924 File Offset: 0x00005B24
		public unsafe readonly FVector UnrotateVector(in FVector vector)
		{
			fixed (FRotator* ptr = &this)
			{
				fixed (FVector* ptr2 = &vector)
				{
					return FRotator.Internal_UnrotateVector(this, vector);
				}
			}
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x00007940 File Offset: 0x00005B40
		public unsafe readonly FRotator Clamp()
		{
			fixed (FRotator* ptr = &this)
			{
				return FRotator.Internal_Clamp(this);
			}
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x00007958 File Offset: 0x00005B58
		public unsafe readonly FRotator GetNormalized()
		{
			fixed (FRotator* ptr = &this)
			{
				return FRotator.Internal_GetNormalized(this);
			}
		}

		// Token: 0x060003CA RID: 970 RVA: 0x00007970 File Offset: 0x00005B70
		public unsafe readonly FRotator GetDenormalized()
		{
			fixed (FRotator* ptr = &this)
			{
				return FRotator.Internal_GetDenormalized(this);
			}
		}

		// Token: 0x060003CB RID: 971 RVA: 0x00007988 File Offset: 0x00005B88
		public unsafe void Normalize()
		{
			fixed (FRotator* ptr = &this)
			{
				FRotator.Internal_Normalize(ref this);
			}
		}

		// Token: 0x060003CC RID: 972 RVA: 0x000079A4 File Offset: 0x00005BA4
		public unsafe readonly float GetComponentForAxis(EAxis axis)
		{
			fixed (FRotator* ptr = &this)
			{
				return FRotator.Internal_GetComponentForAxis(this, axis);
			}
		}

		// Token: 0x060003CD RID: 973 RVA: 0x000079BC File Offset: 0x00005BBC
		public unsafe void SetComponentForAxis(EAxis axis, float value)
		{
			fixed (FRotator* ptr = &this)
			{
				FRotator.Internal_SetComponentForAxis(ref this, axis, value);
			}
		}

		// Token: 0x060003CE RID: 974 RVA: 0x000079D8 File Offset: 0x00005BD8
		public unsafe readonly void GetWindingAndRemainder(out FRotator winding, out FRotator remainder)
		{
			fixed (FRotator* ptr = &this)
			{
				fixed (FRotator* ptr2 = &winding)
				{
					fixed (FRotator* ptr3 = &remainder)
					{
						FRotator.Internal_GetWindingAndRemainder(this, out winding, out remainder);
					}
				}
			}
		}

		// Token: 0x060003CF RID: 975 RVA: 0x00007A04 File Offset: 0x00005C04
		public unsafe readonly float GetManhattanDistance(in FRotator other)
		{
			fixed (FRotator* ptr = &this)
			{
				fixed (FRotator* ptr2 = &other)
				{
					return FRotator.Internal_GetManhattanDistance(this, other);
				}
			}
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x00007A20 File Offset: 0x00005C20
		public unsafe readonly FRotator GetEquivalentRotator()
		{
			fixed (FRotator* ptr = &this)
			{
				return FRotator.Internal_GetEquivalentRotator(this);
			}
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x00007A38 File Offset: 0x00005C38
		public unsafe readonly void SetClosestToMe(ref FRotator other)
		{
			fixed (FRotator* ptr = &this)
			{
				fixed (FRotator* ptr2 = &other)
				{
					FRotator.Internal_SetClosestToMe(this, ref other);
				}
			}
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x00007A5C File Offset: 0x00005C5C
		public unsafe readonly bool ContainsNaN()
		{
			fixed (FRotator* ptr = &this)
			{
				return FRotator.Internal_ContainsNaN(this);
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x060003D3 RID: 979 RVA: 0x00007A73 File Offset: 0x00005C73
		// (set) Token: 0x060003D4 RID: 980 RVA: 0x00007A7B File Offset: 0x00005C7B
		float IRotator.Pitch
		{
			get
			{
				return this.Pitch;
			}
			set
			{
				this.Pitch = value;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x060003D5 RID: 981 RVA: 0x00007A84 File Offset: 0x00005C84
		// (set) Token: 0x060003D6 RID: 982 RVA: 0x00007A8C File Offset: 0x00005C8C
		float IRotator.Yaw
		{
			get
			{
				return this.Yaw;
			}
			set
			{
				this.Yaw = value;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x060003D7 RID: 983 RVA: 0x00007A95 File Offset: 0x00005C95
		// (set) Token: 0x060003D8 RID: 984 RVA: 0x00007A9D File Offset: 0x00005C9D
		float IRotator.Roll
		{
			get
			{
				return this.Roll;
			}
			set
			{
				this.Roll = value;
			}
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x00007AA6 File Offset: 0x00005CA6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRotator._ScriptStructPtr != 0) ? FRotator._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.Rotator", ref FRotator._ScriptStructPtr);
		}

		// Token: 0x040000A3 RID: 163
		public static readonly FRotator ZeroRotator = new FRotator(0f, 0f, 0f);

		// Token: 0x040000A4 RID: 164
		[FieldOffset(0)]
		public float Pitch;

		// Token: 0x040000A5 RID: 165
		[FieldOffset(4)]
		public float Yaw;

		// Token: 0x040000A6 RID: 166
		[FieldOffset(8)]
		public float Roll;

		// Token: 0x040000A7 RID: 167
		public const string __ObjectPath = "/Script/CoreUObject.Rotator";

		// Token: 0x040000A8 RID: 168
		private static IntPtr _ScriptStructPtr;
	}
}
