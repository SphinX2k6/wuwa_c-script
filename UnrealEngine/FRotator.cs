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
	// Token: 0x0200003A RID: 58
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 12)]
	[UnrealObjectPath("/Script/CoreUObject.Rotator")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 12)]
	public struct FRotator : IEquatable<FRotator>, IEqualityOperators<FRotator, FRotator, bool>, IRotator, IUnrealScriptStruct
	{
		// Token: 0x06000400 RID: 1024 RVA: 0x0000AD18 File Offset: 0x00008F18
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

		// Token: 0x06000401 RID: 1025 RVA: 0x0000AD4E File Offset: 0x00008F4E
		public FRotator()
		{
			this.Pitch = 0f;
			this.Yaw = 0f;
			this.Roll = 0f;
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x0000AD71 File Offset: 0x00008F71
		public FRotator(float value)
		{
			this.Pitch = value;
			this.Yaw = value;
			this.Roll = value;
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x0000AD88 File Offset: 0x00008F88
		public FRotator(float inPitch, float inYaw, float inRoll)
		{
			this.Pitch = inPitch;
			this.Yaw = inYaw;
			this.Roll = inRoll;
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x0000AD9F File Offset: 0x00008F9F
		public FRotator(FQuat quat)
		{
			this = quat.Rotator();
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x0000ADAE File Offset: 0x00008FAE
		public static bool operator ==(FRotator a, FRotator b)
		{
			return a.Pitch == b.Pitch && a.Yaw == b.Yaw && a.Roll == b.Roll;
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x0000ADDC File Offset: 0x00008FDC
		public static bool operator !=(FRotator a, FRotator b)
		{
			return a.Pitch != b.Pitch || a.Yaw != b.Yaw || a.Roll != b.Roll;
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x0000AE0D File Offset: 0x0000900D
		public readonly bool Equals(FRotator other)
		{
			return this == other;
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x0000AE1C File Offset: 0x0000901C
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

		// Token: 0x06000409 RID: 1033 RVA: 0x0000AE46 File Offset: 0x00009046
		public override readonly int GetHashCode()
		{
			return HashCode.Combine<float, float, float>(this.Pitch, this.Yaw, this.Roll);
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x0000AE60 File Offset: 0x00009060
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

		// Token: 0x0600040B RID: 1035 RVA: 0x0000AEC8 File Offset: 0x000090C8
		public static FRotator operator *(float scale, in FRotator r)
		{
			return r * scale;
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x0000AED4 File Offset: 0x000090D4
		public readonly FVectorDouble VectorDouble()
		{
			FVector fvector = this.Vector();
			return fvector;
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x0000AEF0 File Offset: 0x000090F0
		public readonly FVectorDouble RotateVectorDouble(in FVectorDouble vector)
		{
			FVector fvector = vector;
			FVector fvector2 = this.RotateVector(fvector);
			return fvector2;
		}

		// Token: 0x0600040E RID: 1038
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Internal_ClampAxis(float angle);

		// Token: 0x0600040F RID: 1039
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Internal_NormalizeAxis(float angle);

		// Token: 0x06000410 RID: 1040
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern byte Internal_CompressAxisToByte(float angle);

		// Token: 0x06000411 RID: 1041
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Internal_DecompressAxisFromByte(byte compressed);

		// Token: 0x06000412 RID: 1042
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern ushort Internal_CompressAxisToShort(float angle);

		// Token: 0x06000413 RID: 1043
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Internal_DecompressAxisFromShort(ushort compressed);

		// Token: 0x06000414 RID: 1044
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator Internal_MakeFromEuler(in FVector euler);

		// Token: 0x06000415 RID: 1045
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator Internal_Add(in FRotator a, in FRotator b);

		// Token: 0x06000416 RID: 1046
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator Internal_Sub(in FRotator a, in FRotator b);

		// Token: 0x06000417 RID: 1047
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator Internal_Mul(in FRotator a, float scale);

		// Token: 0x06000418 RID: 1048
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_Equals(in FRotator a, in FRotator other, float tolerance);

		// Token: 0x06000419 RID: 1049
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IsNearlyZero(in FRotator a);

		// Token: 0x0600041A RID: 1050
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IsZero(in FRotator a);

		// Token: 0x0600041B RID: 1051
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Add_float_float_float(ref FRotator a, float pitch, float yaw, float roll);

		// Token: 0x0600041C RID: 1052
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator Internal_GetInverse(in FRotator a);

		// Token: 0x0600041D RID: 1053
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator Internal_GridSnap(in FRotator a, in FRotator grid);

		// Token: 0x0600041E RID: 1054
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_Vector(in FRotator a);

		// Token: 0x0600041F RID: 1055
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat Internal_Quaternion(in FRotator a);

		// Token: 0x06000420 RID: 1056
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_Euler(in FRotator a);

		// Token: 0x06000421 RID: 1057
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_RotateVector(in FRotator a, in FVector vector);

		// Token: 0x06000422 RID: 1058
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_UnrotateVector(in FRotator a, in FVector vector);

		// Token: 0x06000423 RID: 1059
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator Internal_Clamp(in FRotator a);

		// Token: 0x06000424 RID: 1060
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator Internal_GetNormalized(in FRotator a);

		// Token: 0x06000425 RID: 1061
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator Internal_GetDenormalized(in FRotator a);

		// Token: 0x06000426 RID: 1062
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Normalize(ref FRotator a);

		// Token: 0x06000427 RID: 1063
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_GetComponentForAxis(in FRotator a, EAxis axis);

		// Token: 0x06000428 RID: 1064
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_SetComponentForAxis(ref FRotator a, EAxis axis, float value);

		// Token: 0x06000429 RID: 1065
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_GetWindingAndRemainder(in FRotator a, out FRotator winding, out FRotator remainder);

		// Token: 0x0600042A RID: 1066
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_GetManhattanDistance(in FRotator a, in FRotator other);

		// Token: 0x0600042B RID: 1067
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator Internal_GetEquivalentRotator(in FRotator a);

		// Token: 0x0600042C RID: 1068
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_SetClosestToMe(in FRotator a, ref FRotator other);

		// Token: 0x0600042D RID: 1069
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_ContainsNaN(in FRotator a);

		// Token: 0x0600042E RID: 1070 RVA: 0x0000AF14 File Offset: 0x00009114
		public static float ClampAxis(float angle)
		{
			return FRotator.Internal_ClampAxis(angle);
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x0000AF1C File Offset: 0x0000911C
		public static float NormalizeAxis(float angle)
		{
			return FRotator.Internal_NormalizeAxis(angle);
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x0000AF24 File Offset: 0x00009124
		public static byte CompressAxisToByte(float angle)
		{
			return FRotator.Internal_CompressAxisToByte(angle);
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x0000AF2C File Offset: 0x0000912C
		public static float DecompressAxisFromByte(byte compressed)
		{
			return FRotator.Internal_DecompressAxisFromByte(compressed);
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x0000AF34 File Offset: 0x00009134
		public static ushort CompressAxisToShort(float angle)
		{
			return FRotator.Internal_CompressAxisToShort(angle);
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x0000AF3C File Offset: 0x0000913C
		public static float DecompressAxisFromShort(ushort compressed)
		{
			return FRotator.Internal_DecompressAxisFromShort(compressed);
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x0000AF44 File Offset: 0x00009144
		public unsafe static FRotator MakeFromEuler(in FVector euler)
		{
			fixed (FVector* ptr = &euler)
			{
				return FRotator.Internal_MakeFromEuler(euler);
			}
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x0000AF5C File Offset: 0x0000915C
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

		// Token: 0x06000436 RID: 1078 RVA: 0x0000AF78 File Offset: 0x00009178
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

		// Token: 0x06000437 RID: 1079 RVA: 0x0000AF94 File Offset: 0x00009194
		public unsafe static FRotator operator *(in FRotator a, float scale)
		{
			fixed (FRotator* ptr = &a)
			{
				return FRotator.Internal_Mul(a, scale);
			}
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x0000AFAC File Offset: 0x000091AC
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

		// Token: 0x06000439 RID: 1081 RVA: 0x0000AFCC File Offset: 0x000091CC
		public unsafe readonly bool IsNearlyZero()
		{
			fixed (FRotator* ptr = &this)
			{
				return FRotator.Internal_IsNearlyZero(this);
			}
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x0000AFE4 File Offset: 0x000091E4
		public unsafe readonly bool IsZero()
		{
			fixed (FRotator* ptr = &this)
			{
				return FRotator.Internal_IsZero(this);
			}
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x0000AFFC File Offset: 0x000091FC
		public unsafe FRotator Add(float pitch, float yaw, float roll)
		{
			fixed (FRotator* ptr = &this)
			{
				FRotator.Internal_Add_float_float_float(ref this, pitch, yaw, roll);
			}
			return this;
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x0000B020 File Offset: 0x00009220
		public unsafe readonly FRotator GetInverse()
		{
			fixed (FRotator* ptr = &this)
			{
				return FRotator.Internal_GetInverse(this);
			}
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x0000B038 File Offset: 0x00009238
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

		// Token: 0x0600043E RID: 1086 RVA: 0x0000B054 File Offset: 0x00009254
		public unsafe readonly FVector Vector()
		{
			fixed (FRotator* ptr = &this)
			{
				return FRotator.Internal_Vector(this);
			}
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x0000B06C File Offset: 0x0000926C
		public unsafe readonly FQuat Quaternion()
		{
			fixed (FRotator* ptr = &this)
			{
				return FRotator.Internal_Quaternion(this);
			}
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x0000B084 File Offset: 0x00009284
		public unsafe readonly FVector Euler()
		{
			fixed (FRotator* ptr = &this)
			{
				return FRotator.Internal_Euler(this);
			}
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x0000B09C File Offset: 0x0000929C
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

		// Token: 0x06000442 RID: 1090 RVA: 0x0000B0B8 File Offset: 0x000092B8
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

		// Token: 0x06000443 RID: 1091 RVA: 0x0000B0D4 File Offset: 0x000092D4
		public unsafe readonly FRotator Clamp()
		{
			fixed (FRotator* ptr = &this)
			{
				return FRotator.Internal_Clamp(this);
			}
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x0000B0EC File Offset: 0x000092EC
		public unsafe readonly FRotator GetNormalized()
		{
			fixed (FRotator* ptr = &this)
			{
				return FRotator.Internal_GetNormalized(this);
			}
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x0000B104 File Offset: 0x00009304
		public unsafe readonly FRotator GetDenormalized()
		{
			fixed (FRotator* ptr = &this)
			{
				return FRotator.Internal_GetDenormalized(this);
			}
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x0000B11C File Offset: 0x0000931C
		public unsafe void Normalize()
		{
			fixed (FRotator* ptr = &this)
			{
				FRotator.Internal_Normalize(ref this);
			}
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x0000B138 File Offset: 0x00009338
		public unsafe readonly float GetComponentForAxis(EAxis axis)
		{
			fixed (FRotator* ptr = &this)
			{
				return FRotator.Internal_GetComponentForAxis(this, axis);
			}
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x0000B150 File Offset: 0x00009350
		public unsafe void SetComponentForAxis(EAxis axis, float value)
		{
			fixed (FRotator* ptr = &this)
			{
				FRotator.Internal_SetComponentForAxis(ref this, axis, value);
			}
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x0000B16C File Offset: 0x0000936C
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

		// Token: 0x0600044A RID: 1098 RVA: 0x0000B198 File Offset: 0x00009398
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

		// Token: 0x0600044B RID: 1099 RVA: 0x0000B1B4 File Offset: 0x000093B4
		public unsafe readonly FRotator GetEquivalentRotator()
		{
			fixed (FRotator* ptr = &this)
			{
				return FRotator.Internal_GetEquivalentRotator(this);
			}
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x0000B1CC File Offset: 0x000093CC
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

		// Token: 0x0600044D RID: 1101 RVA: 0x0000B1F0 File Offset: 0x000093F0
		public unsafe readonly bool ContainsNaN()
		{
			fixed (FRotator* ptr = &this)
			{
				return FRotator.Internal_ContainsNaN(this);
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600044E RID: 1102 RVA: 0x0000B207 File Offset: 0x00009407
		// (set) Token: 0x0600044F RID: 1103 RVA: 0x0000B20F File Offset: 0x0000940F
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

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000450 RID: 1104 RVA: 0x0000B218 File Offset: 0x00009418
		// (set) Token: 0x06000451 RID: 1105 RVA: 0x0000B220 File Offset: 0x00009420
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

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000452 RID: 1106 RVA: 0x0000B229 File Offset: 0x00009429
		// (set) Token: 0x06000453 RID: 1107 RVA: 0x0000B231 File Offset: 0x00009431
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

		// Token: 0x06000454 RID: 1108 RVA: 0x0000B23A File Offset: 0x0000943A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRotator._ScriptStructPtr != 0) ? FRotator._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.Rotator", ref FRotator._ScriptStructPtr);
		}

		// Token: 0x040000EA RID: 234
		public static readonly FRotator ZeroRotator = new FRotator(0f, 0f, 0f);

		// Token: 0x040000EB RID: 235
		[FieldOffset(0)]
		public float Pitch;

		// Token: 0x040000EC RID: 236
		[FieldOffset(4)]
		public float Yaw;

		// Token: 0x040000ED RID: 237
		[FieldOffset(8)]
		public float Roll;

		// Token: 0x040000EE RID: 238
		public const string __ObjectPath = "/Script/CoreUObject.Rotator";

		// Token: 0x040000EF RID: 239
		private static IntPtr _ScriptStructPtr;
	}
}
