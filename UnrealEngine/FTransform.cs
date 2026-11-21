using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000021 RID: 33
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(48, 16, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 48)]
	[UnrealObjectPath("/Script/CoreUObject.Transform")]
	[StructLayout(LayoutKind.Explicit, Pack = 16, Size = 48)]
	public struct FTransform : IEquatable<FTransform>, IEqualityOperators<FTransform, FTransform, bool>, ITransform, IUnrealScriptStruct
	{
		// Token: 0x060003F7 RID: 1015 RVA: 0x00007D3C File Offset: 0x00005F3C
		public static bool operator ==(FTransform a, FTransform b)
		{
			return a.Rotation == b.Rotation && a.Translation == b.Translation && a.Scale3D == b.Scale3D;
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x00007D77 File Offset: 0x00005F77
		public static bool operator !=(FTransform a, FTransform b)
		{
			return a.Rotation != b.Rotation || a.Translation != b.Translation || a.Scale3D != b.Scale3D;
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x00007DB2 File Offset: 0x00005FB2
		public readonly bool Equals(FTransform other)
		{
			return this == other;
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x00007DC0 File Offset: 0x00005FC0
		[NullableContext(2)]
		public override readonly bool Equals(object obj)
		{
			if (obj is FTransform)
			{
				FTransform b = (FTransform)obj;
				return this == b;
			}
			return false;
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x00007DEA File Offset: 0x00005FEA
		public override readonly int GetHashCode()
		{
			return HashCode.Combine<FQuat, FVector, FVector>(this.Rotation, this.Translation, this.Scale3D);
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x00007E04 File Offset: 0x00006004
		public override readonly string ToString()
		{
			FRotator frotator = new FRotator(this.Rotation);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(8, 9);
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.Translation.X);
			defaultInterpolatedStringHandler.AppendLiteral(",");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.Translation.Y);
			defaultInterpolatedStringHandler.AppendLiteral(",");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.Translation.Z);
			defaultInterpolatedStringHandler.AppendLiteral("|");
			defaultInterpolatedStringHandler.AppendFormatted<float>(frotator.Pitch);
			defaultInterpolatedStringHandler.AppendLiteral(",");
			defaultInterpolatedStringHandler.AppendFormatted<float>(frotator.Yaw);
			defaultInterpolatedStringHandler.AppendLiteral(",");
			defaultInterpolatedStringHandler.AppendFormatted<float>(frotator.Roll);
			defaultInterpolatedStringHandler.AppendLiteral("|");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.Scale3D.X);
			defaultInterpolatedStringHandler.AppendLiteral(",");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.Scale3D.Y);
			defaultInterpolatedStringHandler.AppendLiteral(",");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.Scale3D.Z);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x00007F24 File Offset: 0x00006124
		public FTransform()
		{
			this.Rotation = default(FQuat);
			this.Translation = default(FVector);
			this._Unused0 = 0f;
			this._Unused1 = 0f;
			this.Rotation.W = 1f;
			this.Scale3D.X = 1f;
			this.Scale3D.Y = 1f;
			this.Scale3D.Z = 1f;
		}

		// Token: 0x060003FE RID: 1022
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform Internal_Ctor_FVector(in FVector inTranslation);

		// Token: 0x060003FF RID: 1023
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform Internal_Ctor_FQuat(in FQuat inRotation);

		// Token: 0x06000400 RID: 1024
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform Internal_Ctor_FRotator(in FRotator inRotation);

		// Token: 0x06000401 RID: 1025
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform Internal_Ctor_FQuat_FVector(in FQuat inRotation, in FVector inTranslation);

		// Token: 0x06000402 RID: 1026
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform Internal_Ctor_FQuat_FVector_FVector(in FQuat inRotation, in FVector inTranslation, in FVector inScale3D);

		// Token: 0x06000403 RID: 1027
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform Internal_Ctor_FRotator_FVector(in FRotator inRotation, in FVector inTranslation);

		// Token: 0x06000404 RID: 1028
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform Internal_Ctor_FRotator_FVector_FVector(in FRotator inRotation, in FVector inTranslation, in FVector inScale3D);

		// Token: 0x06000405 RID: 1029
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform Internal_Ctor_FMatrix(in FMatrix inMatrix);

		// Token: 0x06000406 RID: 1030
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform Internal_Ctor_FVector_FVector_FVector_FVector(in FVector x, in FVector y, in FVector z, in FVector inTranslation);

		// Token: 0x06000407 RID: 1031
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_AnyHasNegativeScale(in FVector inScale3D, in FVector inOtherScale3D);

		// Token: 0x06000408 RID: 1032
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Multiply(out FTransform outTransform, in FTransform a, in FTransform b);

		// Token: 0x06000409 RID: 1033
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_BlendFromIdentityAndAccumulate(ref FTransform finalAtom, ref FTransform sourceAtom, float blendWeight);

		// Token: 0x0600040A RID: 1034
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_AreRotationsEqual(in FTransform a, in FTransform b, float tolerance = 0.0001f);

		// Token: 0x0600040B RID: 1035
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_AreTranslationsEqual(in FTransform a, in FTransform b, float tolerance = 0.0001f);

		// Token: 0x0600040C RID: 1036
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_AreScale3DsEqual(in FTransform a, in FTransform b, float tolerance = 0.0001f);

		// Token: 0x0600040D RID: 1037
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_GetSafeScaleReciprocal(in FVector scale, float tolerance = 1E-08f);

		// Token: 0x0600040E RID: 1038
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform Internal_Add(in FTransform a, in FTransform b);

		// Token: 0x0600040F RID: 1039
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform Internal_Mul(in FTransform a, in FTransform b);

		// Token: 0x06000410 RID: 1040
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform Internal_MulFloat(in FTransform a, float f);

		// Token: 0x06000411 RID: 1041
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform Internal_MulFQuat(in FTransform a, in FQuat q);

		// Token: 0x06000412 RID: 1042
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_Equals(in FTransform a, in FTransform b, float tolerance = 0.0001f);

		// Token: 0x06000413 RID: 1043
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_Identical(in FTransform a, in FTransform b, uint portFlags = 0U);

		// Token: 0x06000414 RID: 1044
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_EqualsNoScale(in FTransform a, in FTransform b, float tolerance = 0.0001f);

		// Token: 0x06000415 RID: 1045
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_ScaleTranslation_FVector(ref FTransform a, in FVector inScale3D);

		// Token: 0x06000416 RID: 1046
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_ScaleTranslation_float(ref FTransform a, float inScale);

		// Token: 0x06000417 RID: 1047
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_RemoveScaling(ref FTransform a, float tolerance = 1E-08f);

		// Token: 0x06000418 RID: 1048
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_GetMaximumAxisScale(in FTransform a);

		// Token: 0x06000419 RID: 1049
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_GetMinimumAxisScale(in FTransform a);

		// Token: 0x0600041A RID: 1050
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform Internal_GetRelativeTransform(in FTransform a, in FTransform b);

		// Token: 0x0600041B RID: 1051
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform Internal_GetRelativeTransformReverse(in FTransform a, in FTransform b);

		// Token: 0x0600041C RID: 1052
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_SetToRelativeTransform(ref FTransform a, in FTransform parentTransform);

		// Token: 0x0600041D RID: 1053
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector4 Internal_TransformFVector4(in FTransform a, in FVector4 v);

		// Token: 0x0600041E RID: 1054
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector4 Internal_TransformFVector4NoScale(in FTransform a, in FVector4 v);

		// Token: 0x0600041F RID: 1055
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_TransformPosition(in FTransform a, in FVector v);

		// Token: 0x06000420 RID: 1056
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_TransformPositionNoScale(in FTransform a, in FVector v);

		// Token: 0x06000421 RID: 1057
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_InverseTransformPosition(in FTransform a, in FVector v);

		// Token: 0x06000422 RID: 1058
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_InverseTransformPositionNoScale(in FTransform a, in FVector v);

		// Token: 0x06000423 RID: 1059
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_TransformVector(in FTransform a, in FVector v);

		// Token: 0x06000424 RID: 1060
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_TransformVectorNoScale(in FTransform a, in FVector v);

		// Token: 0x06000425 RID: 1061
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_InverseTransformVector(in FTransform a, in FVector v);

		// Token: 0x06000426 RID: 1062
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_InverseTransformVectorNoScale(in FTransform a, in FVector v);

		// Token: 0x06000427 RID: 1063
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat Internal_TransformRotation(in FTransform a, in FQuat q);

		// Token: 0x06000428 RID: 1064
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat Internal_InverseTransformRotation(in FTransform a, in FQuat q);

		// Token: 0x06000429 RID: 1065
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform Internal_GetScaled_Float(in FTransform a, float scale);

		// Token: 0x0600042A RID: 1066
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform Internal_GetScaled_FVector(in FTransform a, in FVector scale);

		// Token: 0x0600042B RID: 1067
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_GetScaledAxis(in FTransform a, EAxis axis);

		// Token: 0x0600042C RID: 1068
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_GetUnitAxis(in FTransform a, EAxis axis);

		// Token: 0x0600042D RID: 1069
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Mirror(ref FTransform a, EAxis mirrorAxis, EAxis flipAxis);

		// Token: 0x0600042E RID: 1070
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_GetLocation(in FTransform a);

		// Token: 0x0600042F RID: 1071
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_SetLocation(ref FTransform a, in FVector origin);

		// Token: 0x06000430 RID: 1072
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator Internal_Rotator(in FTransform a);

		// Token: 0x06000431 RID: 1073
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_GetDeterminant(in FTransform a);

		// Token: 0x06000432 RID: 1074
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IsNonUniformScale(in FTransform a);

		// Token: 0x06000433 RID: 1075
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_ContainsNaN(in FTransform a);

		// Token: 0x06000434 RID: 1076
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IsValid(in FTransform a);

		// Token: 0x06000435 RID: 1077
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_SetComponents(ref FTransform a, in FQuat inRotation, in FVector inTranslation, in FVector inScale3D);

		// Token: 0x06000436 RID: 1078
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_SetIdentity(ref FTransform a);

		// Token: 0x06000437 RID: 1079
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_MultiplyScale3D(ref FTransform a, in FVector scale3DMultiplier);

		// Token: 0x06000438 RID: 1080
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_SetTranslation(ref FTransform a, in FVector newTranslation);

		// Token: 0x06000439 RID: 1081
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_CopyTranslation(ref FTransform a, in FTransform b);

		// Token: 0x0600043A RID: 1082
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_ConcatenateRotation(ref FTransform a, in FQuat deltaRotation);

		// Token: 0x0600043B RID: 1083
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_AddToTranslation(ref FTransform a, in FVector deltaTranslation);

		// Token: 0x0600043C RID: 1084
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_AddTranslations(in FTransform a, in FTransform b);

		// Token: 0x0600043D RID: 1085
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_SubtractTranslations(in FTransform a, in FTransform b);

		// Token: 0x0600043E RID: 1086
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_SetRotation(ref FTransform a, in FQuat newRotation);

		// Token: 0x0600043F RID: 1087
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_CopyRotation(ref FTransform a, in FTransform b);

		// Token: 0x06000440 RID: 1088
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_SetScale3D(ref FTransform a, in FVector newScale3D);

		// Token: 0x06000441 RID: 1089
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_CopyScale3D(ref FTransform a, in FTransform b);

		// Token: 0x06000442 RID: 1090
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_SetTranslationAndScale3D(ref FTransform a, in FVector newTranslation, in FVector newScale3D);

		// Token: 0x06000443 RID: 1091
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Accumulate_FTransform(ref FTransform a, in FTransform sourceAtom);

		// Token: 0x06000444 RID: 1092
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Accumulate_FTransform_float(ref FTransform a, in FTransform atom, float blendWeight);

		// Token: 0x06000445 RID: 1093
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_AccumulateWithShortestRotation(ref FTransform a, in FTransform deltaAtom, float blendWeight);

		// Token: 0x06000446 RID: 1094
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_AccumulateWithAdditiveScale(ref FTransform a, in FTransform atom, float blendWeight);

		// Token: 0x06000447 RID: 1095
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_LerpTranslationScale3D(ref FTransform a, in FTransform sourceAtom1, in FTransform sourceAtom2, float alpha);

		// Token: 0x06000448 RID: 1096
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_NormalizeRotation(ref FTransform a);

		// Token: 0x06000449 RID: 1097
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IsRotationNormalized(in FTransform a);

		// Token: 0x0600044A RID: 1098
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat Internal_GetRotation(in FTransform a);

		// Token: 0x0600044B RID: 1099
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_GetTranslation(in FTransform a);

		// Token: 0x0600044C RID: 1100
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_GetScale3D(in FTransform a);

		// Token: 0x0600044D RID: 1101
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_CopyRotationPart(ref FTransform a, in FTransform srcBa);

		// Token: 0x0600044E RID: 1102
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_CopyTranslationAndScale3D(ref FTransform a, in FTransform srcBa);

		// Token: 0x0600044F RID: 1103
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_SetFromMatrix(ref FTransform a, in FMatrix inMatrix);

		// Token: 0x06000450 RID: 1104
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix Internal_ToMatrixWithScale(in FTransform a);

		// Token: 0x06000451 RID: 1105
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix Internal_ToInverseMatrixWithScale(in FTransform a);

		// Token: 0x06000452 RID: 1106
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix Internal_ToMatrixWithScaleAndShear(in FTransform a, in FVector inShear);

		// Token: 0x06000453 RID: 1107
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix Internal_ToInverseMatrixWithScaleAndShear(in FTransform a, in FVector inShear);

		// Token: 0x06000454 RID: 1108
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform Internal_Inverse(in FTransform a);

		// Token: 0x06000455 RID: 1109
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix Internal_ToMatrixNoScale(in FTransform a);

		// Token: 0x06000456 RID: 1110
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Blend(ref FTransform a, in FTransform atom1, in FTransform atom2, float alpha);

		// Token: 0x06000457 RID: 1111
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_BlendWith(ref FTransform a, in FTransform otherAtom, float alpha);

		// Token: 0x06000458 RID: 1112
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_RotationEquals(in FTransform a, in FTransform b, float tolerance = 0.0001f);

		// Token: 0x06000459 RID: 1113
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_TranslationEquals(in FTransform a, in FTransform b, float tolerance = 0.0001f);

		// Token: 0x0600045A RID: 1114
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_Scale3DEquals(in FTransform a, in FTransform b, float tolerance = 0.0001f);

		// Token: 0x0600045B RID: 1115
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_InitFromString(ref FTransform a, in FCSharpStringView inSourceString);

		// Token: 0x0600045C RID: 1116 RVA: 0x00007FA0 File Offset: 0x000061A0
		public unsafe FTransform(in FVector inTranslation)
		{
			fixed (FVector* ptr = &inTranslation)
			{
				fixed (FTransform* ptr2 = &this)
				{
					this = FTransform.Internal_Ctor_FVector(inTranslation);
				}
			}
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x00007FC8 File Offset: 0x000061C8
		public unsafe FTransform(in FQuat inRotation)
		{
			fixed (FQuat* ptr = &inRotation)
			{
				fixed (FTransform* ptr2 = &this)
				{
					this = FTransform.Internal_Ctor_FQuat(inRotation);
				}
			}
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x00007FF0 File Offset: 0x000061F0
		public unsafe FTransform(in FRotator inRotation)
		{
			fixed (FRotator* ptr = &inRotation)
			{
				fixed (FTransform* ptr2 = &this)
				{
					this = FTransform.Internal_Ctor_FRotator(inRotation);
				}
			}
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x00008018 File Offset: 0x00006218
		public unsafe FTransform(in FQuat inRotation, in FVector inTranslation)
		{
			fixed (FQuat* ptr = &inRotation)
			{
				fixed (FVector* ptr2 = &inTranslation)
				{
					fixed (FTransform* ptr3 = &this)
					{
						this = FTransform.Internal_Ctor_FQuat_FVector(inRotation, inTranslation);
					}
				}
			}
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x00008048 File Offset: 0x00006248
		public unsafe FTransform(in FQuat inRotation, in FVector inTranslation, in FVector inScale3D)
		{
			fixed (FQuat* ptr = &inRotation)
			{
				fixed (FVector* ptr2 = &inTranslation)
				{
					fixed (FVector* ptr3 = &inScale3D)
					{
						fixed (FTransform* ptr4 = &this)
						{
							this = FTransform.Internal_Ctor_FQuat_FVector_FVector(inRotation, inTranslation, inScale3D);
						}
					}
				}
			}
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x00008080 File Offset: 0x00006280
		public unsafe FTransform(in FRotator inRotation, in FVector inTranslation)
		{
			fixed (FRotator* ptr = &inRotation)
			{
				fixed (FVector* ptr2 = &inTranslation)
				{
					fixed (FTransform* ptr3 = &this)
					{
						this = FTransform.Internal_Ctor_FRotator_FVector(inRotation, inTranslation);
					}
				}
			}
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x000080B0 File Offset: 0x000062B0
		public unsafe FTransform(in FRotator inRotation, in FVector inTranslation, in FVector inScale3D)
		{
			fixed (FRotator* ptr = &inRotation)
			{
				fixed (FVector* ptr2 = &inTranslation)
				{
					fixed (FVector* ptr3 = &inScale3D)
					{
						fixed (FTransform* ptr4 = &this)
						{
							this = FTransform.Internal_Ctor_FRotator_FVector_FVector(inRotation, inTranslation, inScale3D);
						}
					}
				}
			}
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x000080E8 File Offset: 0x000062E8
		public unsafe FTransform(in FMatrix inMatrix)
		{
			fixed (FMatrix* ptr = &inMatrix)
			{
				fixed (FTransform* ptr2 = &this)
				{
					this = FTransform.Internal_Ctor_FMatrix(inMatrix);
				}
			}
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x00008110 File Offset: 0x00006310
		public unsafe FTransform(in FVector x, in FVector y, in FVector z, in FVector inTranslation)
		{
			fixed (FVector* ptr = &x)
			{
				fixed (FVector* ptr2 = &y)
				{
					fixed (FVector* ptr3 = &z)
					{
						fixed (FVector* ptr4 = &inTranslation)
						{
							fixed (FTransform* ptr5 = &this)
							{
								this = FTransform.Internal_Ctor_FVector_FVector_FVector_FVector(x, y, z, inTranslation);
							}
						}
					}
				}
			}
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x00008154 File Offset: 0x00006354
		public unsafe static bool AnyHasNegativeScale(in FVector inScale3D, in FVector inOtherScale3D)
		{
			fixed (FVector* ptr = &inScale3D)
			{
				fixed (FVector* ptr2 = &inOtherScale3D)
				{
					return FTransform.Internal_AnyHasNegativeScale(inScale3D, inOtherScale3D);
				}
			}
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x00008170 File Offset: 0x00006370
		public unsafe static void Multiply(out FTransform outTransform, in FTransform a, in FTransform b)
		{
			fixed (FTransform* ptr = &outTransform)
			{
				fixed (FTransform* ptr2 = &a)
				{
					fixed (FTransform* ptr3 = &b)
					{
						FTransform.Internal_Multiply(out outTransform, a, b);
					}
				}
			}
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x0000819C File Offset: 0x0000639C
		public unsafe static void BlendFromIdentityAndAccumulate(ref FTransform finalAtom, ref FTransform sourceAtom, float blendWeight)
		{
			fixed (FTransform* ptr = &finalAtom)
			{
				fixed (FTransform* ptr2 = &sourceAtom)
				{
					FTransform.Internal_BlendFromIdentityAndAccumulate(ref finalAtom, ref sourceAtom, blendWeight);
				}
			}
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x000081C0 File Offset: 0x000063C0
		public unsafe static bool AreRotationsEqual(in FTransform a, in FTransform b, float tolerance = 0.0001f)
		{
			fixed (FTransform* ptr = &a)
			{
				fixed (FTransform* ptr2 = &b)
				{
					return FTransform.Internal_AreRotationsEqual(a, b, tolerance);
				}
			}
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x000081E0 File Offset: 0x000063E0
		public unsafe static bool AreTranslationsEqual(in FTransform a, in FTransform b, float tolerance = 0.0001f)
		{
			fixed (FTransform* ptr = &a)
			{
				fixed (FTransform* ptr2 = &b)
				{
					return FTransform.Internal_AreTranslationsEqual(a, b, tolerance);
				}
			}
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x00008200 File Offset: 0x00006400
		public unsafe static bool AreScale3DsEqual(in FTransform a, in FTransform b, float tolerance = 0.0001f)
		{
			fixed (FTransform* ptr = &a)
			{
				fixed (FTransform* ptr2 = &b)
				{
					return FTransform.Internal_AreScale3DsEqual(a, b, tolerance);
				}
			}
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x00008220 File Offset: 0x00006420
		public unsafe static FVector GetSafeScaleReciprocal(in FVector scale, float tolerance = 1E-08f)
		{
			fixed (FVector* ptr = &scale)
			{
				return FTransform.Internal_GetSafeScaleReciprocal(scale, tolerance);
			}
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x00008238 File Offset: 0x00006438
		public unsafe static FTransform operator +(in FTransform a, in FTransform b)
		{
			fixed (FTransform* ptr = &a)
			{
				fixed (FTransform* ptr2 = &b)
				{
					return FTransform.Internal_Add(a, b);
				}
			}
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x00008254 File Offset: 0x00006454
		public unsafe static FTransform operator *(in FTransform a, in FTransform b)
		{
			fixed (FTransform* ptr = &a)
			{
				fixed (FTransform* ptr2 = &b)
				{
					return FTransform.Internal_Mul(a, b);
				}
			}
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x00008270 File Offset: 0x00006470
		public unsafe static FTransform operator *(in FTransform a, float f)
		{
			fixed (FTransform* ptr = &a)
			{
				return FTransform.Internal_MulFloat(a, f);
			}
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x00008288 File Offset: 0x00006488
		public unsafe static FTransform operator *(in FTransform a, in FQuat q)
		{
			fixed (FTransform* ptr = &a)
			{
				fixed (FQuat* ptr2 = &q)
				{
					return FTransform.Internal_MulFQuat(a, q);
				}
			}
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x000082A4 File Offset: 0x000064A4
		public unsafe readonly bool Equals(in FTransform b, float tolerance = 0.0001f)
		{
			fixed (FTransform* ptr = &this)
			{
				fixed (FTransform* ptr2 = &b)
				{
					return FTransform.Internal_Equals(this, b, tolerance);
				}
			}
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x000082C4 File Offset: 0x000064C4
		public unsafe readonly bool Identical(in FTransform b, uint portFlags = 0U)
		{
			fixed (FTransform* ptr = &this)
			{
				fixed (FTransform* ptr2 = &b)
				{
					return FTransform.Internal_Identical(this, b, portFlags);
				}
			}
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x000082E4 File Offset: 0x000064E4
		public unsafe readonly bool EqualsNoScale(in FTransform b, float tolerance = 0.0001f)
		{
			fixed (FTransform* ptr = &this)
			{
				fixed (FTransform* ptr2 = &b)
				{
					return FTransform.Internal_EqualsNoScale(this, b, tolerance);
				}
			}
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x00008304 File Offset: 0x00006504
		public unsafe void ScaleTranslation(in FVector inScale3D)
		{
			fixed (FVector* ptr = &inScale3D)
			{
				fixed (FTransform* ptr2 = &this)
				{
					FTransform.Internal_ScaleTranslation_FVector(ref this, inScale3D);
				}
			}
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x00008328 File Offset: 0x00006528
		public unsafe void ScaleTranslation(float inScale)
		{
			fixed (FTransform* ptr = &this)
			{
				FTransform.Internal_ScaleTranslation_float(ref this, inScale);
			}
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x00008344 File Offset: 0x00006544
		public unsafe void RemoveScaling(float tolerance = 1E-08f)
		{
			fixed (FTransform* ptr = &this)
			{
				FTransform.Internal_RemoveScaling(ref this, tolerance);
			}
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x00008360 File Offset: 0x00006560
		public unsafe readonly float GetMaximumAxisScale()
		{
			fixed (FTransform* ptr = &this)
			{
				return FTransform.Internal_GetMaximumAxisScale(this);
			}
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x00008378 File Offset: 0x00006578
		public unsafe readonly float GetMinimumAxisScale()
		{
			fixed (FTransform* ptr = &this)
			{
				return FTransform.Internal_GetMinimumAxisScale(this);
			}
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x00008390 File Offset: 0x00006590
		public unsafe readonly FTransform GetRelativeTransform(in FTransform b)
		{
			fixed (FTransform* ptr = &this)
			{
				fixed (FTransform* ptr2 = &b)
				{
					return FTransform.Internal_GetRelativeTransform(this, b);
				}
			}
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x000083AC File Offset: 0x000065AC
		public unsafe readonly FTransform GetRelativeTransformReverse(in FTransform b)
		{
			fixed (FTransform* ptr = &this)
			{
				fixed (FTransform* ptr2 = &b)
				{
					return FTransform.Internal_GetRelativeTransformReverse(this, b);
				}
			}
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x000083C8 File Offset: 0x000065C8
		public unsafe void SetToRelativeTransform(in FTransform parentTransform)
		{
			fixed (FTransform* ptr = &this)
			{
				fixed (FTransform* ptr2 = &parentTransform)
				{
					FTransform.Internal_SetToRelativeTransform(ref this, parentTransform);
				}
			}
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x000083EC File Offset: 0x000065EC
		public unsafe readonly FVector4 TransformFVector4(in FVector4 v)
		{
			fixed (FVector4* ptr = &v)
			{
				fixed (FTransform* ptr2 = &this)
				{
					return FTransform.Internal_TransformFVector4(this, v);
				}
			}
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x00008408 File Offset: 0x00006608
		public unsafe readonly FVector4 TransformFVector4NoScale(in FVector4 v)
		{
			fixed (FVector4* ptr = &v)
			{
				fixed (FTransform* ptr2 = &this)
				{
					return FTransform.Internal_TransformFVector4NoScale(this, v);
				}
			}
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x00008424 File Offset: 0x00006624
		public unsafe readonly FVector TransformPosition(in FVector v)
		{
			fixed (FVector* ptr = &v)
			{
				fixed (FTransform* ptr2 = &this)
				{
					return FTransform.Internal_TransformPosition(this, v);
				}
			}
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x00008440 File Offset: 0x00006640
		public unsafe readonly FVector TransformPositionNoScale(in FVector v)
		{
			fixed (FVector* ptr = &v)
			{
				fixed (FTransform* ptr2 = &this)
				{
					return FTransform.Internal_TransformPositionNoScale(this, v);
				}
			}
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x0000845C File Offset: 0x0000665C
		public unsafe readonly FVector InverseTransformPosition(in FVector v)
		{
			fixed (FVector* ptr = &v)
			{
				fixed (FTransform* ptr2 = &this)
				{
					return FTransform.Internal_InverseTransformPosition(this, v);
				}
			}
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x00008478 File Offset: 0x00006678
		public unsafe readonly FVector InverseTransformPositionNoScale(in FVector v)
		{
			fixed (FVector* ptr = &v)
			{
				fixed (FTransform* ptr2 = &this)
				{
					return FTransform.Internal_InverseTransformPositionNoScale(this, v);
				}
			}
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x00008494 File Offset: 0x00006694
		public unsafe readonly FVector TransformVector(in FVector v)
		{
			fixed (FVector* ptr = &v)
			{
				fixed (FTransform* ptr2 = &this)
				{
					return FTransform.Internal_TransformVector(this, v);
				}
			}
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x000084B0 File Offset: 0x000066B0
		public unsafe readonly FVector TransformVectorNoScale(in FVector v)
		{
			fixed (FVector* ptr = &v)
			{
				fixed (FTransform* ptr2 = &this)
				{
					return FTransform.Internal_TransformVectorNoScale(this, v);
				}
			}
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x000084CC File Offset: 0x000066CC
		public unsafe readonly FVector InverseTransformVector(in FVector v)
		{
			fixed (FVector* ptr = &v)
			{
				fixed (FTransform* ptr2 = &this)
				{
					return FTransform.Internal_InverseTransformVector(this, v);
				}
			}
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x000084E8 File Offset: 0x000066E8
		public unsafe readonly FVector InverseTransformVectorNoScale(in FVector v)
		{
			fixed (FVector* ptr = &v)
			{
				fixed (FTransform* ptr2 = &this)
				{
					return FTransform.Internal_InverseTransformVectorNoScale(this, v);
				}
			}
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x00008504 File Offset: 0x00006704
		public unsafe readonly FQuat TransformRotation(in FQuat q)
		{
			fixed (FQuat* ptr = &q)
			{
				fixed (FTransform* ptr2 = &this)
				{
					return FTransform.Internal_TransformRotation(this, q);
				}
			}
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x00008520 File Offset: 0x00006720
		public unsafe readonly FQuat InverseTransformRotation(in FQuat q)
		{
			fixed (FQuat* ptr = &q)
			{
				fixed (FTransform* ptr2 = &this)
				{
					return FTransform.Internal_InverseTransformRotation(this, q);
				}
			}
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x0000853C File Offset: 0x0000673C
		public unsafe readonly FTransform GetScaled(float scale)
		{
			fixed (FTransform* ptr = &this)
			{
				return FTransform.Internal_GetScaled_Float(this, scale);
			}
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x00008554 File Offset: 0x00006754
		public unsafe readonly FTransform GetScaled(in FVector scale)
		{
			fixed (FVector* ptr = &scale)
			{
				fixed (FTransform* ptr2 = &this)
				{
					return FTransform.Internal_GetScaled_FVector(this, scale);
				}
			}
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x00008570 File Offset: 0x00006770
		public unsafe readonly FVector GetScaledAxis(EAxis axis)
		{
			fixed (FTransform* ptr = &this)
			{
				return FTransform.Internal_GetScaledAxis(this, axis);
			}
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x00008588 File Offset: 0x00006788
		public unsafe readonly FVector GetUnitAxis(EAxis axis)
		{
			fixed (FTransform* ptr = &this)
			{
				return FTransform.Internal_GetUnitAxis(this, axis);
			}
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x000085A0 File Offset: 0x000067A0
		public unsafe void Mirror(EAxis mirrorAxis, EAxis flipAxis)
		{
			fixed (FTransform* ptr = &this)
			{
				FTransform.Internal_Mirror(ref this, mirrorAxis, flipAxis);
			}
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x000085BC File Offset: 0x000067BC
		public unsafe readonly FVector GetLocation()
		{
			fixed (FTransform* ptr = &this)
			{
				return FTransform.Internal_GetLocation(this);
			}
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x000085D4 File Offset: 0x000067D4
		public unsafe void SetLocation(in FVector origin)
		{
			fixed (FVector* ptr = &origin)
			{
				fixed (FTransform* ptr2 = &this)
				{
					FTransform.Internal_SetLocation(ref this, origin);
				}
			}
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x000085F8 File Offset: 0x000067F8
		public unsafe readonly FRotator Rotator()
		{
			fixed (FTransform* ptr = &this)
			{
				return FTransform.Internal_Rotator(this);
			}
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x00008610 File Offset: 0x00006810
		public unsafe readonly float GetDeterminant()
		{
			fixed (FTransform* ptr = &this)
			{
				return FTransform.Internal_GetDeterminant(this);
			}
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x00008628 File Offset: 0x00006828
		public unsafe readonly bool IsNonUniformScale()
		{
			fixed (FTransform* ptr = &this)
			{
				return FTransform.Internal_IsNonUniformScale(this);
			}
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x00008640 File Offset: 0x00006840
		public unsafe readonly bool ContainsNaN()
		{
			fixed (FTransform* ptr = &this)
			{
				return FTransform.Internal_ContainsNaN(this);
			}
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x00008658 File Offset: 0x00006858
		public unsafe readonly bool IsValid()
		{
			fixed (FTransform* ptr = &this)
			{
				return FTransform.Internal_IsValid(this);
			}
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x00008670 File Offset: 0x00006870
		public unsafe void SetComponents(in FQuat inRotation, in FVector inTranslation, in FVector inScale3D)
		{
			fixed (FQuat* ptr = &inRotation)
			{
				fixed (FVector* ptr2 = &inTranslation)
				{
					fixed (FVector* ptr3 = &inScale3D)
					{
						fixed (FTransform* ptr4 = &this)
						{
							FTransform.Internal_SetComponents(ref this, inRotation, inTranslation, inScale3D);
						}
					}
				}
			}
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x000086A4 File Offset: 0x000068A4
		public unsafe void SetIdentity()
		{
			fixed (FTransform* ptr = &this)
			{
				FTransform.Internal_SetIdentity(ref this);
			}
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x000086C0 File Offset: 0x000068C0
		public unsafe void MultiplyScale3D(in FVector scale3DMultiplier)
		{
			fixed (FVector* ptr = &scale3DMultiplier)
			{
				fixed (FTransform* ptr2 = &this)
				{
					FTransform.Internal_MultiplyScale3D(ref this, scale3DMultiplier);
				}
			}
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x000086E4 File Offset: 0x000068E4
		public unsafe void SetTranslation(in FVector newTranslation)
		{
			fixed (FVector* ptr = &newTranslation)
			{
				fixed (FTransform* ptr2 = &this)
				{
					FTransform.Internal_SetTranslation(ref this, newTranslation);
				}
			}
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x00008708 File Offset: 0x00006908
		public unsafe void CopyTranslation(in FTransform b)
		{
			fixed (FTransform* ptr = &this)
			{
				fixed (FTransform* ptr2 = &b)
				{
					FTransform.Internal_CopyTranslation(ref this, b);
				}
			}
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x0000872C File Offset: 0x0000692C
		public unsafe void ConcatenateRotation(in FQuat deltaRotation)
		{
			fixed (FQuat* ptr = &deltaRotation)
			{
				fixed (FTransform* ptr2 = &this)
				{
					FTransform.Internal_ConcatenateRotation(ref this, deltaRotation);
				}
			}
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x00008750 File Offset: 0x00006950
		public unsafe void AddToTranslation(in FVector deltaTranslation)
		{
			fixed (FVector* ptr = &deltaTranslation)
			{
				fixed (FTransform* ptr2 = &this)
				{
					FTransform.Internal_AddToTranslation(ref this, deltaTranslation);
				}
			}
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x00008774 File Offset: 0x00006974
		public unsafe static FVector AddTranslations(in FTransform a, in FTransform b)
		{
			fixed (FTransform* ptr = &a)
			{
				fixed (FTransform* ptr2 = &b)
				{
					return FTransform.Internal_AddTranslations(a, b);
				}
			}
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x00008790 File Offset: 0x00006990
		public unsafe static FVector SubtractTranslations(in FTransform a, in FTransform b)
		{
			fixed (FTransform* ptr = &a)
			{
				fixed (FTransform* ptr2 = &b)
				{
					return FTransform.Internal_SubtractTranslations(a, b);
				}
			}
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x000087AC File Offset: 0x000069AC
		public unsafe void SetRotation(in FQuat newRotation)
		{
			fixed (FQuat* ptr = &newRotation)
			{
				fixed (FTransform* ptr2 = &this)
				{
					FTransform.Internal_SetRotation(ref this, newRotation);
				}
			}
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x000087D0 File Offset: 0x000069D0
		public unsafe void CopyRotation(in FTransform b)
		{
			fixed (FTransform* ptr = &this)
			{
				fixed (FTransform* ptr2 = &b)
				{
					FTransform.Internal_CopyRotation(ref this, b);
				}
			}
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x000087F4 File Offset: 0x000069F4
		public unsafe void SetScale3D(in FVector newScale3D)
		{
			fixed (FVector* ptr = &newScale3D)
			{
				fixed (FTransform* ptr2 = &this)
				{
					FTransform.Internal_SetScale3D(ref this, newScale3D);
				}
			}
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x00008818 File Offset: 0x00006A18
		public unsafe void CopyScale3D(in FTransform b)
		{
			fixed (FTransform* ptr = &this)
			{
				fixed (FTransform* ptr2 = &b)
				{
					FTransform.Internal_CopyScale3D(ref this, b);
				}
			}
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x0000883C File Offset: 0x00006A3C
		public unsafe void SetTranslationAndScale3D(in FVector newTranslation, in FVector newScale3D)
		{
			fixed (FVector* ptr = &newTranslation)
			{
				fixed (FVector* ptr2 = &newScale3D)
				{
					fixed (FTransform* ptr3 = &this)
					{
						FTransform.Internal_SetTranslationAndScale3D(ref this, newTranslation, newScale3D);
					}
				}
			}
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x00008868 File Offset: 0x00006A68
		public unsafe void Accumulate(in FTransform sourceAtom)
		{
			fixed (FTransform* ptr = &this)
			{
				fixed (FTransform* ptr2 = &sourceAtom)
				{
					FTransform.Internal_Accumulate_FTransform(ref this, sourceAtom);
				}
			}
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x0000888C File Offset: 0x00006A8C
		public unsafe void Accumulate(in FTransform atom, float blendWeight)
		{
			fixed (FTransform* ptr = &this)
			{
				fixed (FTransform* ptr2 = &atom)
				{
					FTransform.Internal_Accumulate_FTransform_float(ref this, atom, blendWeight);
				}
			}
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x000088B0 File Offset: 0x00006AB0
		public unsafe void AccumulateWithShortestRotation(in FTransform deltaAtom, float blendWeight)
		{
			fixed (FTransform* ptr = &this)
			{
				fixed (FTransform* ptr2 = &deltaAtom)
				{
					FTransform.Internal_AccumulateWithShortestRotation(ref this, deltaAtom, blendWeight);
				}
			}
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x000088D4 File Offset: 0x00006AD4
		public unsafe void AccumulateWithAdditiveScale(in FTransform atom, float blendWeight)
		{
			fixed (FTransform* ptr = &this)
			{
				fixed (FTransform* ptr2 = &atom)
				{
					FTransform.Internal_AccumulateWithAdditiveScale(ref this, atom, blendWeight);
				}
			}
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x000088F8 File Offset: 0x00006AF8
		public unsafe void LerpTranslationScale3D(in FTransform sourceAtom1, in FTransform sourceAtom2, float alpha)
		{
			fixed (FTransform* ptr = &this)
			{
				fixed (FTransform* ptr2 = &sourceAtom1)
				{
					fixed (FTransform* ptr3 = &sourceAtom2)
					{
						FTransform.Internal_LerpTranslationScale3D(ref this, sourceAtom1, sourceAtom2, alpha);
					}
				}
			}
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x00008924 File Offset: 0x00006B24
		public unsafe void NormalizeRotation()
		{
			fixed (FTransform* ptr = &this)
			{
				FTransform.Internal_NormalizeRotation(ref this);
			}
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x00008940 File Offset: 0x00006B40
		public unsafe readonly bool IsRotationNormalized()
		{
			fixed (FTransform* ptr = &this)
			{
				return FTransform.Internal_IsRotationNormalized(this);
			}
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x00008958 File Offset: 0x00006B58
		public unsafe readonly FQuat GetRotation()
		{
			fixed (FTransform* ptr = &this)
			{
				return FTransform.Internal_GetRotation(this);
			}
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x00008970 File Offset: 0x00006B70
		public unsafe readonly FVector GetTranslation()
		{
			fixed (FTransform* ptr = &this)
			{
				return FTransform.Internal_GetTranslation(this);
			}
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x00008988 File Offset: 0x00006B88
		public unsafe readonly FVector GetScale3D()
		{
			fixed (FTransform* ptr = &this)
			{
				return FTransform.Internal_GetScale3D(this);
			}
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x000089A0 File Offset: 0x00006BA0
		public unsafe void CopyRotationPart(in FTransform srcBa)
		{
			fixed (FTransform* ptr = &this)
			{
				fixed (FTransform* ptr2 = &srcBa)
				{
					FTransform.Internal_CopyRotationPart(ref this, srcBa);
				}
			}
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x000089C4 File Offset: 0x00006BC4
		public unsafe void CopyTranslationAndScale3D(in FTransform srcBa)
		{
			fixed (FTransform* ptr = &this)
			{
				fixed (FTransform* ptr2 = &srcBa)
				{
					FTransform.Internal_CopyTranslationAndScale3D(ref this, srcBa);
				}
			}
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x000089E8 File Offset: 0x00006BE8
		public unsafe void SetFromMatrix(in FMatrix inMatrix)
		{
			fixed (FMatrix* ptr = &inMatrix)
			{
				fixed (FTransform* ptr2 = &this)
				{
					FTransform.Internal_SetFromMatrix(ref this, inMatrix);
				}
			}
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x00008A0C File Offset: 0x00006C0C
		public unsafe readonly FMatrix ToMatrixWithScale()
		{
			fixed (FTransform* ptr = &this)
			{
				return FTransform.Internal_ToMatrixWithScale(this);
			}
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x00008A24 File Offset: 0x00006C24
		public unsafe readonly FMatrix ToInverseMatrixWithScale()
		{
			fixed (FTransform* ptr = &this)
			{
				return FTransform.Internal_ToInverseMatrixWithScale(this);
			}
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x00008A3C File Offset: 0x00006C3C
		public unsafe readonly FMatrix ToMatrixWithScaleAndShear(in FVector inShear)
		{
			fixed (FVector* ptr = &inShear)
			{
				fixed (FTransform* ptr2 = &this)
				{
					return FTransform.Internal_ToMatrixWithScaleAndShear(this, inShear);
				}
			}
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x00008A58 File Offset: 0x00006C58
		public unsafe readonly FMatrix ToInverseMatrixWithScaleAndShear(in FVector inShear)
		{
			fixed (FVector* ptr = &inShear)
			{
				fixed (FTransform* ptr2 = &this)
				{
					return FTransform.Internal_ToInverseMatrixWithScaleAndShear(this, inShear);
				}
			}
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x00008A74 File Offset: 0x00006C74
		public unsafe readonly FTransform Inverse()
		{
			fixed (FTransform* ptr = &this)
			{
				return FTransform.Internal_Inverse(this);
			}
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x00008A8C File Offset: 0x00006C8C
		public unsafe readonly FMatrix ToMatrixNoScale()
		{
			fixed (FTransform* ptr = &this)
			{
				return FTransform.Internal_ToMatrixNoScale(this);
			}
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x00008AA4 File Offset: 0x00006CA4
		public unsafe void Blend(in FTransform atom1, in FTransform atom2, float alpha)
		{
			fixed (FTransform* ptr = &this)
			{
				fixed (FTransform* ptr2 = &atom1)
				{
					fixed (FTransform* ptr3 = &atom2)
					{
						FTransform.Internal_Blend(ref this, atom1, atom2, alpha);
					}
				}
			}
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x00008AD0 File Offset: 0x00006CD0
		public unsafe void BlendWith(in FTransform otherAtom, float alpha)
		{
			fixed (FTransform* ptr = &this)
			{
				fixed (FTransform* ptr2 = &otherAtom)
				{
					FTransform.Internal_BlendWith(ref this, otherAtom, alpha);
				}
			}
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x00008AF4 File Offset: 0x00006CF4
		public unsafe readonly bool RotationEquals(in FTransform b, float tolerance = 0.0001f)
		{
			fixed (FTransform* ptr = &this)
			{
				fixed (FTransform* ptr2 = &b)
				{
					return FTransform.Internal_RotationEquals(this, b, tolerance);
				}
			}
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x00008B14 File Offset: 0x00006D14
		public unsafe readonly bool TranslationEquals(in FTransform b, float tolerance = 0.0001f)
		{
			fixed (FTransform* ptr = &this)
			{
				fixed (FTransform* ptr2 = &b)
				{
					return FTransform.Internal_TranslationEquals(this, b, tolerance);
				}
			}
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x00008B34 File Offset: 0x00006D34
		public unsafe readonly bool Scale3DEquals(in FTransform b, float tolerance = 0.0001f)
		{
			fixed (FTransform* ptr = &this)
			{
				fixed (FTransform* ptr2 = &b)
				{
					return FTransform.Internal_Scale3DEquals(this, b, tolerance);
				}
			}
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x00008B54 File Offset: 0x00006D54
		[NullableContext(2)]
		public unsafe bool InitFromString(string inSourceString)
		{
			if (inSourceString == null || inSourceString.Length == 0)
			{
				return false;
			}
			char* ptr;
			if (inSourceString == null)
			{
				ptr = null;
			}
			else
			{
				fixed (char* pinnableReference = inSourceString.GetPinnableReference())
				{
					ptr = pinnableReference;
				}
			}
			char* ptr2 = ptr;
			fixed (FTransform* ptr3 = &this)
			{
				FCSharpStringView fcsharpStringView = new FCSharpStringView(ptr2, inSourceString.Length);
				return FTransform.Internal_InitFromString(ref this, fcsharpStringView);
			}
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x00008B98 File Offset: 0x00006D98
		IVector ITransform.GetLocation()
		{
			return this.Translation;
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x00008BA5 File Offset: 0x00006DA5
		void ITransform.SetLocation(IVector value)
		{
			this.Translation.X = (float)value.X;
			this.Translation.Y = (float)value.Y;
			this.Translation.Z = (float)value.Z;
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x00008BDD File Offset: 0x00006DDD
		IQuat ITransform.GetRotation()
		{
			return this.Rotation;
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x00008BEC File Offset: 0x00006DEC
		void ITransform.SetRotation(IQuat value)
		{
			this.Rotation.X = (float)value.X;
			this.Rotation.Y = (float)value.Y;
			this.Rotation.Z = (float)value.Z;
			this.Rotation.W = (float)value.W;
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x00008C41 File Offset: 0x00006E41
		IVector ITransform.GetScale3D()
		{
			return this.Scale3D;
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x00008C4E File Offset: 0x00006E4E
		void ITransform.SetScale3D(IVector value)
		{
			this.Scale3D.X = (float)value.X;
			this.Scale3D.Y = (float)value.Y;
			this.Scale3D.Z = (float)value.Z;
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x00008C86 File Offset: 0x00006E86
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTransform._ScriptStructPtr != 0) ? FTransform._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.Transform", ref FTransform._ScriptStructPtr);
		}

		// Token: 0x040000AC RID: 172
		public static readonly FTransform Identity = new FTransform();

		// Token: 0x040000AD RID: 173
		[FieldOffset(0)]
		public FQuat Rotation;

		// Token: 0x040000AE RID: 174
		[FieldOffset(16)]
		public FVector Translation;

		// Token: 0x040000AF RID: 175
		[FieldOffset(28)]
		public float _Unused0;

		// Token: 0x040000B0 RID: 176
		[FieldOffset(32)]
		public FVector Scale3D;

		// Token: 0x040000B1 RID: 177
		[FieldOffset(44)]
		public float _Unused1;

		// Token: 0x040000B2 RID: 178
		[Nullable(0)]
		public const string __ObjectPath = "/Script/CoreUObject.Transform";

		// Token: 0x040000B3 RID: 179
		private static IntPtr _ScriptStructPtr;
	}
}
