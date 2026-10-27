using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200003C RID: 60
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(48, 16, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 48)]
	[UnrealObjectPath("/Script/CoreUObject.Transform")]
	[StructLayout(LayoutKind.Explicit, Pack = 16, Size = 48)]
	public struct FTransform : IEquatable<FTransform>, IEqualityOperators<FTransform, FTransform, bool>, ITransform, IUnrealScriptStruct
	{
		// Token: 0x06000472 RID: 1138 RVA: 0x0000B4D0 File Offset: 0x000096D0
		public static bool operator ==(FTransform a, FTransform b)
		{
			return a.Rotation == b.Rotation && a.Translation == b.Translation && a.Scale3D == b.Scale3D;
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x0000B50B File Offset: 0x0000970B
		public static bool operator !=(FTransform a, FTransform b)
		{
			return a.Rotation != b.Rotation || a.Translation != b.Translation || a.Scale3D != b.Scale3D;
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x0000B546 File Offset: 0x00009746
		public readonly bool Equals(FTransform other)
		{
			return this == other;
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x0000B554 File Offset: 0x00009754
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

		// Token: 0x06000476 RID: 1142 RVA: 0x0000B57E File Offset: 0x0000977E
		public override readonly int GetHashCode()
		{
			return HashCode.Combine<FQuat, FVector, FVector>(this.Rotation, this.Translation, this.Scale3D);
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x0000B598 File Offset: 0x00009798
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

		// Token: 0x06000478 RID: 1144 RVA: 0x0000B6B8 File Offset: 0x000098B8
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

		// Token: 0x06000479 RID: 1145
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform Internal_Ctor_FVector(in FVector inTranslation);

		// Token: 0x0600047A RID: 1146
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform Internal_Ctor_FQuat(in FQuat inRotation);

		// Token: 0x0600047B RID: 1147
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform Internal_Ctor_FRotator(in FRotator inRotation);

		// Token: 0x0600047C RID: 1148
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform Internal_Ctor_FQuat_FVector(in FQuat inRotation, in FVector inTranslation);

		// Token: 0x0600047D RID: 1149
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform Internal_Ctor_FQuat_FVector_FVector(in FQuat inRotation, in FVector inTranslation, in FVector inScale3D);

		// Token: 0x0600047E RID: 1150
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform Internal_Ctor_FRotator_FVector(in FRotator inRotation, in FVector inTranslation);

		// Token: 0x0600047F RID: 1151
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform Internal_Ctor_FRotator_FVector_FVector(in FRotator inRotation, in FVector inTranslation, in FVector inScale3D);

		// Token: 0x06000480 RID: 1152
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform Internal_Ctor_FMatrix(in FMatrix inMatrix);

		// Token: 0x06000481 RID: 1153
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform Internal_Ctor_FVector_FVector_FVector_FVector(in FVector x, in FVector y, in FVector z, in FVector inTranslation);

		// Token: 0x06000482 RID: 1154
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_AnyHasNegativeScale(in FVector inScale3D, in FVector inOtherScale3D);

		// Token: 0x06000483 RID: 1155
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Multiply(out FTransform outTransform, in FTransform a, in FTransform b);

		// Token: 0x06000484 RID: 1156
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_BlendFromIdentityAndAccumulate(ref FTransform finalAtom, ref FTransform sourceAtom, float blendWeight);

		// Token: 0x06000485 RID: 1157
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_AreRotationsEqual(in FTransform a, in FTransform b, float tolerance = 0.0001f);

		// Token: 0x06000486 RID: 1158
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_AreTranslationsEqual(in FTransform a, in FTransform b, float tolerance = 0.0001f);

		// Token: 0x06000487 RID: 1159
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_AreScale3DsEqual(in FTransform a, in FTransform b, float tolerance = 0.0001f);

		// Token: 0x06000488 RID: 1160
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_GetSafeScaleReciprocal(in FVector scale, float tolerance = 1E-08f);

		// Token: 0x06000489 RID: 1161
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform Internal_Add(in FTransform a, in FTransform b);

		// Token: 0x0600048A RID: 1162
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform Internal_Mul(in FTransform a, in FTransform b);

		// Token: 0x0600048B RID: 1163
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform Internal_MulFloat(in FTransform a, float f);

		// Token: 0x0600048C RID: 1164
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform Internal_MulFQuat(in FTransform a, in FQuat q);

		// Token: 0x0600048D RID: 1165
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_Equals(in FTransform a, in FTransform b, float tolerance = 0.0001f);

		// Token: 0x0600048E RID: 1166
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_Identical(in FTransform a, in FTransform b, uint portFlags = 0U);

		// Token: 0x0600048F RID: 1167
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_EqualsNoScale(in FTransform a, in FTransform b, float tolerance = 0.0001f);

		// Token: 0x06000490 RID: 1168
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_ScaleTranslation_FVector(ref FTransform a, in FVector inScale3D);

		// Token: 0x06000491 RID: 1169
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_ScaleTranslation_float(ref FTransform a, float inScale);

		// Token: 0x06000492 RID: 1170
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_RemoveScaling(ref FTransform a, float tolerance = 1E-08f);

		// Token: 0x06000493 RID: 1171
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_GetMaximumAxisScale(in FTransform a);

		// Token: 0x06000494 RID: 1172
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_GetMinimumAxisScale(in FTransform a);

		// Token: 0x06000495 RID: 1173
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform Internal_GetRelativeTransform(in FTransform a, in FTransform b);

		// Token: 0x06000496 RID: 1174
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform Internal_GetRelativeTransformReverse(in FTransform a, in FTransform b);

		// Token: 0x06000497 RID: 1175
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_SetToRelativeTransform(ref FTransform a, in FTransform parentTransform);

		// Token: 0x06000498 RID: 1176
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector4 Internal_TransformFVector4(in FTransform a, in FVector4 v);

		// Token: 0x06000499 RID: 1177
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector4 Internal_TransformFVector4NoScale(in FTransform a, in FVector4 v);

		// Token: 0x0600049A RID: 1178
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_TransformPosition(in FTransform a, in FVector v);

		// Token: 0x0600049B RID: 1179
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_TransformPositionNoScale(in FTransform a, in FVector v);

		// Token: 0x0600049C RID: 1180
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_InverseTransformPosition(in FTransform a, in FVector v);

		// Token: 0x0600049D RID: 1181
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_InverseTransformPositionNoScale(in FTransform a, in FVector v);

		// Token: 0x0600049E RID: 1182
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_TransformVector(in FTransform a, in FVector v);

		// Token: 0x0600049F RID: 1183
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_TransformVectorNoScale(in FTransform a, in FVector v);

		// Token: 0x060004A0 RID: 1184
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_InverseTransformVector(in FTransform a, in FVector v);

		// Token: 0x060004A1 RID: 1185
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_InverseTransformVectorNoScale(in FTransform a, in FVector v);

		// Token: 0x060004A2 RID: 1186
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat Internal_TransformRotation(in FTransform a, in FQuat q);

		// Token: 0x060004A3 RID: 1187
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat Internal_InverseTransformRotation(in FTransform a, in FQuat q);

		// Token: 0x060004A4 RID: 1188
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform Internal_GetScaled_Float(in FTransform a, float scale);

		// Token: 0x060004A5 RID: 1189
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform Internal_GetScaled_FVector(in FTransform a, in FVector scale);

		// Token: 0x060004A6 RID: 1190
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_GetScaledAxis(in FTransform a, EAxis axis);

		// Token: 0x060004A7 RID: 1191
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_GetUnitAxis(in FTransform a, EAxis axis);

		// Token: 0x060004A8 RID: 1192
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Mirror(ref FTransform a, EAxis mirrorAxis, EAxis flipAxis);

		// Token: 0x060004A9 RID: 1193
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_GetLocation(in FTransform a);

		// Token: 0x060004AA RID: 1194
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_SetLocation(ref FTransform a, in FVector origin);

		// Token: 0x060004AB RID: 1195
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator Internal_Rotator(in FTransform a);

		// Token: 0x060004AC RID: 1196
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_GetDeterminant(in FTransform a);

		// Token: 0x060004AD RID: 1197
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IsNonUniformScale(in FTransform a);

		// Token: 0x060004AE RID: 1198
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_ContainsNaN(in FTransform a);

		// Token: 0x060004AF RID: 1199
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IsValid(in FTransform a);

		// Token: 0x060004B0 RID: 1200
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_SetComponents(ref FTransform a, in FQuat inRotation, in FVector inTranslation, in FVector inScale3D);

		// Token: 0x060004B1 RID: 1201
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_SetIdentity(ref FTransform a);

		// Token: 0x060004B2 RID: 1202
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_MultiplyScale3D(ref FTransform a, in FVector scale3DMultiplier);

		// Token: 0x060004B3 RID: 1203
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_SetTranslation(ref FTransform a, in FVector newTranslation);

		// Token: 0x060004B4 RID: 1204
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_CopyTranslation(ref FTransform a, in FTransform b);

		// Token: 0x060004B5 RID: 1205
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_ConcatenateRotation(ref FTransform a, in FQuat deltaRotation);

		// Token: 0x060004B6 RID: 1206
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_AddToTranslation(ref FTransform a, in FVector deltaTranslation);

		// Token: 0x060004B7 RID: 1207
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_AddTranslations(in FTransform a, in FTransform b);

		// Token: 0x060004B8 RID: 1208
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_SubtractTranslations(in FTransform a, in FTransform b);

		// Token: 0x060004B9 RID: 1209
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_SetRotation(ref FTransform a, in FQuat newRotation);

		// Token: 0x060004BA RID: 1210
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_CopyRotation(ref FTransform a, in FTransform b);

		// Token: 0x060004BB RID: 1211
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_SetScale3D(ref FTransform a, in FVector newScale3D);

		// Token: 0x060004BC RID: 1212
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_CopyScale3D(ref FTransform a, in FTransform b);

		// Token: 0x060004BD RID: 1213
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_SetTranslationAndScale3D(ref FTransform a, in FVector newTranslation, in FVector newScale3D);

		// Token: 0x060004BE RID: 1214
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Accumulate_FTransform(ref FTransform a, in FTransform sourceAtom);

		// Token: 0x060004BF RID: 1215
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Accumulate_FTransform_float(ref FTransform a, in FTransform atom, float blendWeight);

		// Token: 0x060004C0 RID: 1216
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_AccumulateWithShortestRotation(ref FTransform a, in FTransform deltaAtom, float blendWeight);

		// Token: 0x060004C1 RID: 1217
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_AccumulateWithAdditiveScale(ref FTransform a, in FTransform atom, float blendWeight);

		// Token: 0x060004C2 RID: 1218
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_LerpTranslationScale3D(ref FTransform a, in FTransform sourceAtom1, in FTransform sourceAtom2, float alpha);

		// Token: 0x060004C3 RID: 1219
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_NormalizeRotation(ref FTransform a);

		// Token: 0x060004C4 RID: 1220
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IsRotationNormalized(in FTransform a);

		// Token: 0x060004C5 RID: 1221
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat Internal_GetRotation(in FTransform a);

		// Token: 0x060004C6 RID: 1222
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_GetTranslation(in FTransform a);

		// Token: 0x060004C7 RID: 1223
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_GetScale3D(in FTransform a);

		// Token: 0x060004C8 RID: 1224
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_CopyRotationPart(ref FTransform a, in FTransform srcBa);

		// Token: 0x060004C9 RID: 1225
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_CopyTranslationAndScale3D(ref FTransform a, in FTransform srcBa);

		// Token: 0x060004CA RID: 1226
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_SetFromMatrix(ref FTransform a, in FMatrix inMatrix);

		// Token: 0x060004CB RID: 1227
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix Internal_ToMatrixWithScale(in FTransform a);

		// Token: 0x060004CC RID: 1228
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix Internal_ToInverseMatrixWithScale(in FTransform a);

		// Token: 0x060004CD RID: 1229
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix Internal_ToMatrixWithScaleAndShear(in FTransform a, in FVector inShear);

		// Token: 0x060004CE RID: 1230
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix Internal_ToInverseMatrixWithScaleAndShear(in FTransform a, in FVector inShear);

		// Token: 0x060004CF RID: 1231
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform Internal_Inverse(in FTransform a);

		// Token: 0x060004D0 RID: 1232
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix Internal_ToMatrixNoScale(in FTransform a);

		// Token: 0x060004D1 RID: 1233
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Blend(ref FTransform a, in FTransform atom1, in FTransform atom2, float alpha);

		// Token: 0x060004D2 RID: 1234
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_BlendWith(ref FTransform a, in FTransform otherAtom, float alpha);

		// Token: 0x060004D3 RID: 1235
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_RotationEquals(in FTransform a, in FTransform b, float tolerance = 0.0001f);

		// Token: 0x060004D4 RID: 1236
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_TranslationEquals(in FTransform a, in FTransform b, float tolerance = 0.0001f);

		// Token: 0x060004D5 RID: 1237
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_Scale3DEquals(in FTransform a, in FTransform b, float tolerance = 0.0001f);

		// Token: 0x060004D6 RID: 1238
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_InitFromString(ref FTransform a, in FCSharpStringView inSourceString);

		// Token: 0x060004D7 RID: 1239 RVA: 0x0000B734 File Offset: 0x00009934
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

		// Token: 0x060004D8 RID: 1240 RVA: 0x0000B75C File Offset: 0x0000995C
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

		// Token: 0x060004D9 RID: 1241 RVA: 0x0000B784 File Offset: 0x00009984
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

		// Token: 0x060004DA RID: 1242 RVA: 0x0000B7AC File Offset: 0x000099AC
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

		// Token: 0x060004DB RID: 1243 RVA: 0x0000B7DC File Offset: 0x000099DC
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

		// Token: 0x060004DC RID: 1244 RVA: 0x0000B814 File Offset: 0x00009A14
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

		// Token: 0x060004DD RID: 1245 RVA: 0x0000B844 File Offset: 0x00009A44
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

		// Token: 0x060004DE RID: 1246 RVA: 0x0000B87C File Offset: 0x00009A7C
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

		// Token: 0x060004DF RID: 1247 RVA: 0x0000B8A4 File Offset: 0x00009AA4
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

		// Token: 0x060004E0 RID: 1248 RVA: 0x0000B8E8 File Offset: 0x00009AE8
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

		// Token: 0x060004E1 RID: 1249 RVA: 0x0000B904 File Offset: 0x00009B04
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

		// Token: 0x060004E2 RID: 1250 RVA: 0x0000B930 File Offset: 0x00009B30
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

		// Token: 0x060004E3 RID: 1251 RVA: 0x0000B954 File Offset: 0x00009B54
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

		// Token: 0x060004E4 RID: 1252 RVA: 0x0000B974 File Offset: 0x00009B74
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

		// Token: 0x060004E5 RID: 1253 RVA: 0x0000B994 File Offset: 0x00009B94
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

		// Token: 0x060004E6 RID: 1254 RVA: 0x0000B9B4 File Offset: 0x00009BB4
		public unsafe static FVector GetSafeScaleReciprocal(in FVector scale, float tolerance = 1E-08f)
		{
			fixed (FVector* ptr = &scale)
			{
				return FTransform.Internal_GetSafeScaleReciprocal(scale, tolerance);
			}
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x0000B9CC File Offset: 0x00009BCC
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

		// Token: 0x060004E8 RID: 1256 RVA: 0x0000B9E8 File Offset: 0x00009BE8
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

		// Token: 0x060004E9 RID: 1257 RVA: 0x0000BA04 File Offset: 0x00009C04
		public unsafe static FTransform operator *(in FTransform a, float f)
		{
			fixed (FTransform* ptr = &a)
			{
				return FTransform.Internal_MulFloat(a, f);
			}
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x0000BA1C File Offset: 0x00009C1C
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

		// Token: 0x060004EB RID: 1259 RVA: 0x0000BA38 File Offset: 0x00009C38
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

		// Token: 0x060004EC RID: 1260 RVA: 0x0000BA58 File Offset: 0x00009C58
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

		// Token: 0x060004ED RID: 1261 RVA: 0x0000BA78 File Offset: 0x00009C78
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

		// Token: 0x060004EE RID: 1262 RVA: 0x0000BA98 File Offset: 0x00009C98
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

		// Token: 0x060004EF RID: 1263 RVA: 0x0000BABC File Offset: 0x00009CBC
		public unsafe void ScaleTranslation(float inScale)
		{
			fixed (FTransform* ptr = &this)
			{
				FTransform.Internal_ScaleTranslation_float(ref this, inScale);
			}
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x0000BAD8 File Offset: 0x00009CD8
		public unsafe void RemoveScaling(float tolerance = 1E-08f)
		{
			fixed (FTransform* ptr = &this)
			{
				FTransform.Internal_RemoveScaling(ref this, tolerance);
			}
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x0000BAF4 File Offset: 0x00009CF4
		public unsafe readonly float GetMaximumAxisScale()
		{
			fixed (FTransform* ptr = &this)
			{
				return FTransform.Internal_GetMaximumAxisScale(this);
			}
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x0000BB0C File Offset: 0x00009D0C
		public unsafe readonly float GetMinimumAxisScale()
		{
			fixed (FTransform* ptr = &this)
			{
				return FTransform.Internal_GetMinimumAxisScale(this);
			}
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x0000BB24 File Offset: 0x00009D24
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

		// Token: 0x060004F4 RID: 1268 RVA: 0x0000BB40 File Offset: 0x00009D40
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

		// Token: 0x060004F5 RID: 1269 RVA: 0x0000BB5C File Offset: 0x00009D5C
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

		// Token: 0x060004F6 RID: 1270 RVA: 0x0000BB80 File Offset: 0x00009D80
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

		// Token: 0x060004F7 RID: 1271 RVA: 0x0000BB9C File Offset: 0x00009D9C
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

		// Token: 0x060004F8 RID: 1272 RVA: 0x0000BBB8 File Offset: 0x00009DB8
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

		// Token: 0x060004F9 RID: 1273 RVA: 0x0000BBD4 File Offset: 0x00009DD4
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

		// Token: 0x060004FA RID: 1274 RVA: 0x0000BBF0 File Offset: 0x00009DF0
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

		// Token: 0x060004FB RID: 1275 RVA: 0x0000BC0C File Offset: 0x00009E0C
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

		// Token: 0x060004FC RID: 1276 RVA: 0x0000BC28 File Offset: 0x00009E28
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

		// Token: 0x060004FD RID: 1277 RVA: 0x0000BC44 File Offset: 0x00009E44
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

		// Token: 0x060004FE RID: 1278 RVA: 0x0000BC60 File Offset: 0x00009E60
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

		// Token: 0x060004FF RID: 1279 RVA: 0x0000BC7C File Offset: 0x00009E7C
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

		// Token: 0x06000500 RID: 1280 RVA: 0x0000BC98 File Offset: 0x00009E98
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

		// Token: 0x06000501 RID: 1281 RVA: 0x0000BCB4 File Offset: 0x00009EB4
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

		// Token: 0x06000502 RID: 1282 RVA: 0x0000BCD0 File Offset: 0x00009ED0
		public unsafe readonly FTransform GetScaled(float scale)
		{
			fixed (FTransform* ptr = &this)
			{
				return FTransform.Internal_GetScaled_Float(this, scale);
			}
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x0000BCE8 File Offset: 0x00009EE8
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

		// Token: 0x06000504 RID: 1284 RVA: 0x0000BD04 File Offset: 0x00009F04
		public unsafe readonly FVector GetScaledAxis(EAxis axis)
		{
			fixed (FTransform* ptr = &this)
			{
				return FTransform.Internal_GetScaledAxis(this, axis);
			}
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x0000BD1C File Offset: 0x00009F1C
		public unsafe readonly FVector GetUnitAxis(EAxis axis)
		{
			fixed (FTransform* ptr = &this)
			{
				return FTransform.Internal_GetUnitAxis(this, axis);
			}
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x0000BD34 File Offset: 0x00009F34
		public unsafe void Mirror(EAxis mirrorAxis, EAxis flipAxis)
		{
			fixed (FTransform* ptr = &this)
			{
				FTransform.Internal_Mirror(ref this, mirrorAxis, flipAxis);
			}
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x0000BD50 File Offset: 0x00009F50
		public unsafe readonly FVector GetLocation()
		{
			fixed (FTransform* ptr = &this)
			{
				return FTransform.Internal_GetLocation(this);
			}
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x0000BD68 File Offset: 0x00009F68
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

		// Token: 0x06000509 RID: 1289 RVA: 0x0000BD8C File Offset: 0x00009F8C
		public unsafe readonly FRotator Rotator()
		{
			fixed (FTransform* ptr = &this)
			{
				return FTransform.Internal_Rotator(this);
			}
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x0000BDA4 File Offset: 0x00009FA4
		public unsafe readonly float GetDeterminant()
		{
			fixed (FTransform* ptr = &this)
			{
				return FTransform.Internal_GetDeterminant(this);
			}
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x0000BDBC File Offset: 0x00009FBC
		public unsafe readonly bool IsNonUniformScale()
		{
			fixed (FTransform* ptr = &this)
			{
				return FTransform.Internal_IsNonUniformScale(this);
			}
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x0000BDD4 File Offset: 0x00009FD4
		public unsafe readonly bool ContainsNaN()
		{
			fixed (FTransform* ptr = &this)
			{
				return FTransform.Internal_ContainsNaN(this);
			}
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x0000BDEC File Offset: 0x00009FEC
		public unsafe readonly bool IsValid()
		{
			fixed (FTransform* ptr = &this)
			{
				return FTransform.Internal_IsValid(this);
			}
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x0000BE04 File Offset: 0x0000A004
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

		// Token: 0x0600050F RID: 1295 RVA: 0x0000BE38 File Offset: 0x0000A038
		public unsafe void SetIdentity()
		{
			fixed (FTransform* ptr = &this)
			{
				FTransform.Internal_SetIdentity(ref this);
			}
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x0000BE54 File Offset: 0x0000A054
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

		// Token: 0x06000511 RID: 1297 RVA: 0x0000BE78 File Offset: 0x0000A078
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

		// Token: 0x06000512 RID: 1298 RVA: 0x0000BE9C File Offset: 0x0000A09C
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

		// Token: 0x06000513 RID: 1299 RVA: 0x0000BEC0 File Offset: 0x0000A0C0
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

		// Token: 0x06000514 RID: 1300 RVA: 0x0000BEE4 File Offset: 0x0000A0E4
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

		// Token: 0x06000515 RID: 1301 RVA: 0x0000BF08 File Offset: 0x0000A108
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

		// Token: 0x06000516 RID: 1302 RVA: 0x0000BF24 File Offset: 0x0000A124
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

		// Token: 0x06000517 RID: 1303 RVA: 0x0000BF40 File Offset: 0x0000A140
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

		// Token: 0x06000518 RID: 1304 RVA: 0x0000BF64 File Offset: 0x0000A164
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

		// Token: 0x06000519 RID: 1305 RVA: 0x0000BF88 File Offset: 0x0000A188
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

		// Token: 0x0600051A RID: 1306 RVA: 0x0000BFAC File Offset: 0x0000A1AC
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

		// Token: 0x0600051B RID: 1307 RVA: 0x0000BFD0 File Offset: 0x0000A1D0
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

		// Token: 0x0600051C RID: 1308 RVA: 0x0000BFFC File Offset: 0x0000A1FC
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

		// Token: 0x0600051D RID: 1309 RVA: 0x0000C020 File Offset: 0x0000A220
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

		// Token: 0x0600051E RID: 1310 RVA: 0x0000C044 File Offset: 0x0000A244
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

		// Token: 0x0600051F RID: 1311 RVA: 0x0000C068 File Offset: 0x0000A268
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

		// Token: 0x06000520 RID: 1312 RVA: 0x0000C08C File Offset: 0x0000A28C
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

		// Token: 0x06000521 RID: 1313 RVA: 0x0000C0B8 File Offset: 0x0000A2B8
		public unsafe void NormalizeRotation()
		{
			fixed (FTransform* ptr = &this)
			{
				FTransform.Internal_NormalizeRotation(ref this);
			}
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x0000C0D4 File Offset: 0x0000A2D4
		public unsafe readonly bool IsRotationNormalized()
		{
			fixed (FTransform* ptr = &this)
			{
				return FTransform.Internal_IsRotationNormalized(this);
			}
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x0000C0EC File Offset: 0x0000A2EC
		public unsafe readonly FQuat GetRotation()
		{
			fixed (FTransform* ptr = &this)
			{
				return FTransform.Internal_GetRotation(this);
			}
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x0000C104 File Offset: 0x0000A304
		public unsafe readonly FVector GetTranslation()
		{
			fixed (FTransform* ptr = &this)
			{
				return FTransform.Internal_GetTranslation(this);
			}
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x0000C11C File Offset: 0x0000A31C
		public unsafe readonly FVector GetScale3D()
		{
			fixed (FTransform* ptr = &this)
			{
				return FTransform.Internal_GetScale3D(this);
			}
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x0000C134 File Offset: 0x0000A334
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

		// Token: 0x06000527 RID: 1319 RVA: 0x0000C158 File Offset: 0x0000A358
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

		// Token: 0x06000528 RID: 1320 RVA: 0x0000C17C File Offset: 0x0000A37C
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

		// Token: 0x06000529 RID: 1321 RVA: 0x0000C1A0 File Offset: 0x0000A3A0
		public unsafe readonly FMatrix ToMatrixWithScale()
		{
			fixed (FTransform* ptr = &this)
			{
				return FTransform.Internal_ToMatrixWithScale(this);
			}
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x0000C1B8 File Offset: 0x0000A3B8
		public unsafe readonly FMatrix ToInverseMatrixWithScale()
		{
			fixed (FTransform* ptr = &this)
			{
				return FTransform.Internal_ToInverseMatrixWithScale(this);
			}
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x0000C1D0 File Offset: 0x0000A3D0
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

		// Token: 0x0600052C RID: 1324 RVA: 0x0000C1EC File Offset: 0x0000A3EC
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

		// Token: 0x0600052D RID: 1325 RVA: 0x0000C208 File Offset: 0x0000A408
		public unsafe readonly FTransform Inverse()
		{
			fixed (FTransform* ptr = &this)
			{
				return FTransform.Internal_Inverse(this);
			}
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x0000C220 File Offset: 0x0000A420
		public unsafe readonly FMatrix ToMatrixNoScale()
		{
			fixed (FTransform* ptr = &this)
			{
				return FTransform.Internal_ToMatrixNoScale(this);
			}
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x0000C238 File Offset: 0x0000A438
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

		// Token: 0x06000530 RID: 1328 RVA: 0x0000C264 File Offset: 0x0000A464
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

		// Token: 0x06000531 RID: 1329 RVA: 0x0000C288 File Offset: 0x0000A488
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

		// Token: 0x06000532 RID: 1330 RVA: 0x0000C2A8 File Offset: 0x0000A4A8
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

		// Token: 0x06000533 RID: 1331 RVA: 0x0000C2C8 File Offset: 0x0000A4C8
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

		// Token: 0x06000534 RID: 1332 RVA: 0x0000C2E8 File Offset: 0x0000A4E8
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

		// Token: 0x06000535 RID: 1333 RVA: 0x0000C32C File Offset: 0x0000A52C
		IVector ITransform.GetLocation()
		{
			return this.Translation;
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x0000C339 File Offset: 0x0000A539
		void ITransform.SetLocation(IVector value)
		{
			this.Translation.X = (float)value.X;
			this.Translation.Y = (float)value.Y;
			this.Translation.Z = (float)value.Z;
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x0000C371 File Offset: 0x0000A571
		IQuat ITransform.GetRotation()
		{
			return this.Rotation;
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x0000C380 File Offset: 0x0000A580
		void ITransform.SetRotation(IQuat value)
		{
			this.Rotation.X = (float)value.X;
			this.Rotation.Y = (float)value.Y;
			this.Rotation.Z = (float)value.Z;
			this.Rotation.W = (float)value.W;
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x0000C3D5 File Offset: 0x0000A5D5
		IVector ITransform.GetScale3D()
		{
			return this.Scale3D;
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x0000C3E2 File Offset: 0x0000A5E2
		void ITransform.SetScale3D(IVector value)
		{
			this.Scale3D.X = (float)value.X;
			this.Scale3D.Y = (float)value.Y;
			this.Scale3D.Z = (float)value.Z;
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x0000C41A File Offset: 0x0000A61A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTransform._ScriptStructPtr != 0) ? FTransform._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.Transform", ref FTransform._ScriptStructPtr);
		}

		// Token: 0x040000F3 RID: 243
		public static readonly FTransform Identity = new FTransform();

		// Token: 0x040000F4 RID: 244
		[FieldOffset(0)]
		public FQuat Rotation;

		// Token: 0x040000F5 RID: 245
		[FieldOffset(16)]
		public FVector Translation;

		// Token: 0x040000F6 RID: 246
		[FieldOffset(28)]
		public float _Unused0;

		// Token: 0x040000F7 RID: 247
		[FieldOffset(32)]
		public FVector Scale3D;

		// Token: 0x040000F8 RID: 248
		[FieldOffset(44)]
		public float _Unused1;

		// Token: 0x040000F9 RID: 249
		[Nullable(0)]
		public const string __ObjectPath = "/Script/CoreUObject.Transform";

		// Token: 0x040000FA RID: 250
		private static IntPtr _ScriptStructPtr;
	}
}
