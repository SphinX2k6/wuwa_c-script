using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000022 RID: 34
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(64, 16, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 64)]
	[UnrealObjectPath("/Script/CoreUObject.TransformDouble")]
	[StructLayout(LayoutKind.Explicit, Pack = 16, Size = 64)]
	public struct FTransformDouble : IEquatable<FTransformDouble>, IEqualityOperators<FTransformDouble, FTransformDouble, bool>, ITransform, IUnrealScriptStruct
	{
		// Token: 0x060004C2 RID: 1218 RVA: 0x00008CB6 File Offset: 0x00006EB6
		public static bool operator ==(FTransformDouble left, FTransformDouble right)
		{
			return left.Translation.Equals(right.Translation) && left.Rotation.Equals(right.Rotation) && left.Scale3D.Equals(right.Scale3D);
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x00008CF4 File Offset: 0x00006EF4
		public static bool operator !=(FTransformDouble left, FTransformDouble right)
		{
			return left.Translation != right.Translation || left.Rotation != right.Rotation || left.Scale3D != right.Scale3D;
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x00008D30 File Offset: 0x00006F30
		public override readonly string ToString()
		{
			FRotator frotator = new FRotator(this.Rotation);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(8, 9);
			defaultInterpolatedStringHandler.AppendFormatted<double>(this.Translation.X);
			defaultInterpolatedStringHandler.AppendLiteral(",");
			defaultInterpolatedStringHandler.AppendFormatted<double>(this.Translation.Y);
			defaultInterpolatedStringHandler.AppendLiteral(",");
			defaultInterpolatedStringHandler.AppendFormatted<double>(this.Translation.Z);
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

		// Token: 0x060004C5 RID: 1221 RVA: 0x00008E4E File Offset: 0x0000704E
		public readonly bool Equals(FTransformDouble other)
		{
			return this == other;
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x00008E5C File Offset: 0x0000705C
		[NullableContext(2)]
		public override readonly bool Equals(object obj)
		{
			if (obj is FTransformDouble)
			{
				FTransformDouble right = (FTransformDouble)obj;
				return this == right;
			}
			return false;
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x00008E86 File Offset: 0x00007086
		public override readonly int GetHashCode()
		{
			return HashCode.Combine<FQuat, FVectorDouble, FVector>(this.Rotation, this.Translation, this.Scale3D);
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x00008EA0 File Offset: 0x000070A0
		public void SetScale3D(in FVectorDouble Scale)
		{
			FVector fvector = Scale;
			this.SetScale3D(fvector);
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x00008EBC File Offset: 0x000070BC
		public FTransformDouble()
		{
			this.Rotation = default(FQuat);
			this.Translation = default(FVectorDouble);
			this.Rotation.W = 1f;
			this.Scale3D.X = 1f;
			this.Scale3D.Y = 1f;
			this.Scale3D.Z = 1f;
		}

		// Token: 0x060004CA RID: 1226
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransformDouble Internal_Ctor_FVectorDouble(in FVectorDouble inTranslation);

		// Token: 0x060004CB RID: 1227
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransformDouble Internal_Ctor_FQuat(in FQuat inRotation);

		// Token: 0x060004CC RID: 1228
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransformDouble Internal_Ctor_FRotator(in FRotator inRotation);

		// Token: 0x060004CD RID: 1229
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransformDouble Internal_Ctor_FTransform(in FTransform inTransform);

		// Token: 0x060004CE RID: 1230
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransformDouble Internal_Ctor_FQuat_FVectorDouble(in FQuat inRotation, in FVectorDouble inTranslation);

		// Token: 0x060004CF RID: 1231
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransformDouble Internal_Ctor_FQuat_FVectorDouble_FVector(in FQuat inRotation, in FVectorDouble inTranslation, in FVector inScale3D);

		// Token: 0x060004D0 RID: 1232
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransformDouble Internal_Ctor_FRotator_FVectorDouble(in FRotator inRotation, in FVectorDouble inTranslation);

		// Token: 0x060004D1 RID: 1233
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransformDouble Internal_Ctor_FRotator_FVectorDouble_FVector(in FRotator inRotation, in FVectorDouble inTranslation, in FVector inScale3D);

		// Token: 0x060004D2 RID: 1234
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransformDouble Internal_Ctor_FTransform_FIntVector(in FTransform inTransform, in FIntVector offset);

		// Token: 0x060004D3 RID: 1235
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Multiply(out FTransformDouble result, in FTransformDouble a, in FTransformDouble b);

		// Token: 0x060004D4 RID: 1236
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransformDouble Internal_Mul(in FTransformDouble a, in FTransformDouble b);

		// Token: 0x060004D5 RID: 1237
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransformDouble Internal_MulFQuat(in FTransformDouble a, in FQuat q);

		// Token: 0x060004D6 RID: 1238
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_Equals(in FTransformDouble a, in FTransformDouble b, float tolerance = 0.0001f);

		// Token: 0x060004D7 RID: 1239
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_Identical(in FTransformDouble a, in FTransformDouble b, uint portFlags = 0U);

		// Token: 0x060004D8 RID: 1240
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransformDouble Internal_GetRelativeTransform(in FTransformDouble a, in FTransformDouble b);

		// Token: 0x060004D9 RID: 1241
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransformDouble Internal_GetRelativeTransformReverse(in FTransformDouble a, in FTransformDouble b);

		// Token: 0x060004DA RID: 1242
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_TransformPosition(in FTransformDouble a, in FVectorDouble v);

		// Token: 0x060004DB RID: 1243
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_TransformPositionNoScale(in FTransformDouble a, in FVectorDouble v);

		// Token: 0x060004DC RID: 1244
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_InverseTransformPosition(in FTransformDouble a, in FVectorDouble v);

		// Token: 0x060004DD RID: 1245
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_InverseTransformPositionNoScale(in FTransformDouble a, in FVectorDouble v);

		// Token: 0x060004DE RID: 1246
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_TransformVector(in FTransformDouble a, in FVectorDouble v);

		// Token: 0x060004DF RID: 1247
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_TransformVectorNoScale(in FTransformDouble a, in FVectorDouble v);

		// Token: 0x060004E0 RID: 1248
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_InverseTransformVector(in FTransformDouble a, in FVectorDouble v);

		// Token: 0x060004E1 RID: 1249
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_InverseTransformVectorNoScale(in FTransformDouble a, in FVectorDouble v);

		// Token: 0x060004E2 RID: 1250
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat Internal_TransformRotation(in FTransformDouble a, in FQuat q);

		// Token: 0x060004E3 RID: 1251
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat Internal_InverseTransformRotation(in FTransformDouble a, in FQuat q);

		// Token: 0x060004E4 RID: 1252
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_GetLocation(in FTransformDouble a);

		// Token: 0x060004E5 RID: 1253
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_SetLocation(ref FTransformDouble a, in FVectorDouble origin);

		// Token: 0x060004E6 RID: 1254
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator Internal_Rotator(in FTransformDouble a);

		// Token: 0x060004E7 RID: 1255
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_ContainsNaN(in FTransformDouble a);

		// Token: 0x060004E8 RID: 1256
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IsValid(in FTransformDouble a);

		// Token: 0x060004E9 RID: 1257
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_SetComponents(ref FTransformDouble a, in FQuat inRotation, in FVectorDouble inTranslation, in FVector inScale3D);

		// Token: 0x060004EA RID: 1258
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_SetTranslation(ref FTransformDouble a, in FVectorDouble newTranslation);

		// Token: 0x060004EB RID: 1259
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_ConcatenateRotation(ref FTransformDouble a, in FQuat deltaRotation);

		// Token: 0x060004EC RID: 1260
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform Internal_ToTransform(in FTransformDouble a);

		// Token: 0x060004ED RID: 1261
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform Internal_ToLocalTransform(in FTransformDouble a, in FIntVector worldOffset);

		// Token: 0x060004EE RID: 1262
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_AddToTranslation(ref FTransformDouble a, in FVectorDouble deltaTranslation);

		// Token: 0x060004EF RID: 1263
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_SetRotation(ref FTransformDouble a, in FQuat newRotation);

		// Token: 0x060004F0 RID: 1264
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_SetScale3D(ref FTransformDouble a, in FVector newScale3D);

		// Token: 0x060004F1 RID: 1265
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_NormalizeRotation(ref FTransformDouble a);

		// Token: 0x060004F2 RID: 1266
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IsRotationNormalized(in FTransformDouble a);

		// Token: 0x060004F3 RID: 1267
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat Internal_GetRotation(in FTransformDouble a);

		// Token: 0x060004F4 RID: 1268
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_GetTranslation(in FTransformDouble a);

		// Token: 0x060004F5 RID: 1269
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_GetScale3D(in FTransformDouble a);

		// Token: 0x060004F6 RID: 1270
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransformDouble Internal_Inverse(in FTransformDouble a);

		// Token: 0x060004F7 RID: 1271
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Blend(ref FTransformDouble a, in FTransformDouble atom1, in FTransformDouble atom2, float alpha);

		// Token: 0x060004F8 RID: 1272
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_InitFromString(ref FTransformDouble a, in FCSharpStringView inSourceString);

		// Token: 0x060004F9 RID: 1273 RVA: 0x00008F24 File Offset: 0x00007124
		public unsafe FTransformDouble(in FVectorDouble inTranslation)
		{
			fixed (FVectorDouble* ptr = &inTranslation)
			{
				fixed (FTransformDouble* ptr2 = &this)
				{
					this = FTransformDouble.Internal_Ctor_FVectorDouble(inTranslation);
				}
			}
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x00008F4C File Offset: 0x0000714C
		public unsafe FTransformDouble(in FQuat inRotation)
		{
			fixed (FQuat* ptr = &inRotation)
			{
				fixed (FTransformDouble* ptr2 = &this)
				{
					this = FTransformDouble.Internal_Ctor_FQuat(inRotation);
				}
			}
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x00008F74 File Offset: 0x00007174
		public unsafe FTransformDouble(in FRotator inRotation)
		{
			fixed (FRotator* ptr = &inRotation)
			{
				fixed (FTransformDouble* ptr2 = &this)
				{
					this = FTransformDouble.Internal_Ctor_FRotator(inRotation);
				}
			}
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x00008F9C File Offset: 0x0000719C
		public unsafe FTransformDouble(in FTransform inTransform)
		{
			fixed (FTransform* ptr = &inTransform)
			{
				fixed (FTransformDouble* ptr2 = &this)
				{
					this = FTransformDouble.Internal_Ctor_FTransform(inTransform);
				}
			}
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x00008FC4 File Offset: 0x000071C4
		public unsafe FTransformDouble(in FQuat inRotation, in FVectorDouble inTranslation)
		{
			fixed (FQuat* ptr = &inRotation)
			{
				fixed (FVectorDouble* ptr2 = &inTranslation)
				{
					fixed (FTransformDouble* ptr3 = &this)
					{
						this = FTransformDouble.Internal_Ctor_FQuat_FVectorDouble(inRotation, inTranslation);
					}
				}
			}
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x00008FF4 File Offset: 0x000071F4
		public unsafe FTransformDouble(in FQuat inRotation, in FVectorDouble inTranslation, in FVector inScale3D)
		{
			fixed (FQuat* ptr = &inRotation)
			{
				fixed (FVectorDouble* ptr2 = &inTranslation)
				{
					fixed (FVector* ptr3 = &inScale3D)
					{
						fixed (FTransformDouble* ptr4 = &this)
						{
							this = FTransformDouble.Internal_Ctor_FQuat_FVectorDouble_FVector(inRotation, inTranslation, inScale3D);
						}
					}
				}
			}
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x0000902C File Offset: 0x0000722C
		public unsafe FTransformDouble(in FRotator inRotation, in FVectorDouble inTranslation)
		{
			fixed (FRotator* ptr = &inRotation)
			{
				fixed (FVectorDouble* ptr2 = &inTranslation)
				{
					fixed (FTransformDouble* ptr3 = &this)
					{
						this = FTransformDouble.Internal_Ctor_FRotator_FVectorDouble(inRotation, inTranslation);
					}
				}
			}
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x0000905C File Offset: 0x0000725C
		public unsafe FTransformDouble(in FRotator inRotation, in FVectorDouble inTranslation, in FVector inScale3D)
		{
			fixed (FRotator* ptr = &inRotation)
			{
				fixed (FVectorDouble* ptr2 = &inTranslation)
				{
					fixed (FVector* ptr3 = &inScale3D)
					{
						fixed (FTransformDouble* ptr4 = &this)
						{
							this = FTransformDouble.Internal_Ctor_FRotator_FVectorDouble_FVector(inRotation, inTranslation, inScale3D);
						}
					}
				}
			}
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x00009094 File Offset: 0x00007294
		public unsafe FTransformDouble(in FTransform inTransform, in FIntVector inOffset)
		{
			fixed (FTransform* ptr = &inTransform)
			{
				fixed (FIntVector* ptr2 = &inOffset)
				{
					fixed (FTransformDouble* ptr3 = &this)
					{
						this = FTransformDouble.Internal_Ctor_FTransform_FIntVector(inTransform, inOffset);
					}
				}
			}
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x000090C4 File Offset: 0x000072C4
		public unsafe static void Multiply(out FTransformDouble outTransform, in FTransformDouble a, in FTransformDouble b)
		{
			fixed (FTransformDouble* ptr = &outTransform)
			{
				fixed (FTransformDouble* ptr2 = &a)
				{
					fixed (FTransformDouble* ptr3 = &b)
					{
						FTransformDouble.Internal_Multiply(out outTransform, a, b);
					}
				}
			}
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x000090F0 File Offset: 0x000072F0
		public unsafe static FTransformDouble operator *(in FTransformDouble a, in FTransformDouble b)
		{
			fixed (FTransformDouble* ptr = &a)
			{
				fixed (FTransformDouble* ptr2 = &b)
				{
					return FTransformDouble.Internal_Mul(a, b);
				}
			}
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x0000910C File Offset: 0x0000730C
		public unsafe static FTransformDouble operator *(in FTransformDouble a, in FQuat q)
		{
			fixed (FTransformDouble* ptr = &a)
			{
				fixed (FQuat* ptr2 = &q)
				{
					return FTransformDouble.Internal_MulFQuat(a, q);
				}
			}
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x00009128 File Offset: 0x00007328
		public unsafe readonly bool Equals(in FTransformDouble b, float tolerance = 0.0001f)
		{
			fixed (FTransformDouble* ptr = &this)
			{
				fixed (FTransformDouble* ptr2 = &b)
				{
					return FTransformDouble.Internal_Equals(this, b, tolerance);
				}
			}
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x00009148 File Offset: 0x00007348
		public unsafe readonly bool Identical(in FTransformDouble b, uint portFlags = 0U)
		{
			fixed (FTransformDouble* ptr = &this)
			{
				fixed (FTransformDouble* ptr2 = &b)
				{
					return FTransformDouble.Internal_Identical(this, b, portFlags);
				}
			}
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x00009168 File Offset: 0x00007368
		public unsafe readonly FTransformDouble GetRelativeTransform(in FTransformDouble b)
		{
			fixed (FTransformDouble* ptr = &this)
			{
				fixed (FTransformDouble* ptr2 = &b)
				{
					return FTransformDouble.Internal_GetRelativeTransform(this, b);
				}
			}
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x00009184 File Offset: 0x00007384
		public unsafe readonly FTransformDouble GetRelativeTransformReverse(in FTransformDouble b)
		{
			fixed (FTransformDouble* ptr = &this)
			{
				fixed (FTransformDouble* ptr2 = &b)
				{
					return FTransformDouble.Internal_GetRelativeTransformReverse(this, b);
				}
			}
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x000091A0 File Offset: 0x000073A0
		public unsafe readonly FVectorDouble TransformPosition(in FVectorDouble v)
		{
			fixed (FVectorDouble* ptr = &v)
			{
				fixed (FTransformDouble* ptr2 = &this)
				{
					return FTransformDouble.Internal_TransformPosition(this, v);
				}
			}
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x000091BC File Offset: 0x000073BC
		public unsafe readonly FVectorDouble TransformPositionNoScale(in FVectorDouble v)
		{
			fixed (FVectorDouble* ptr = &v)
			{
				fixed (FTransformDouble* ptr2 = &this)
				{
					return FTransformDouble.Internal_TransformPositionNoScale(this, v);
				}
			}
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x000091D8 File Offset: 0x000073D8
		public unsafe readonly FVectorDouble InverseTransformPosition(in FVectorDouble v)
		{
			fixed (FVectorDouble* ptr = &v)
			{
				fixed (FTransformDouble* ptr2 = &this)
				{
					return FTransformDouble.Internal_InverseTransformPosition(this, v);
				}
			}
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x000091F4 File Offset: 0x000073F4
		public unsafe readonly FVectorDouble InverseTransformPositionNoScale(in FVectorDouble v)
		{
			fixed (FVectorDouble* ptr = &v)
			{
				fixed (FTransformDouble* ptr2 = &this)
				{
					return FTransformDouble.Internal_InverseTransformPositionNoScale(this, v);
				}
			}
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x00009210 File Offset: 0x00007410
		public unsafe readonly FVectorDouble TransformVector(in FVectorDouble v)
		{
			fixed (FVectorDouble* ptr = &v)
			{
				fixed (FTransformDouble* ptr2 = &this)
				{
					return FTransformDouble.Internal_TransformVector(this, v);
				}
			}
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x0000922C File Offset: 0x0000742C
		public unsafe readonly FVectorDouble TransformVectorNoScale(in FVectorDouble v)
		{
			fixed (FVectorDouble* ptr = &v)
			{
				fixed (FTransformDouble* ptr2 = &this)
				{
					return FTransformDouble.Internal_TransformVectorNoScale(this, v);
				}
			}
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x00009248 File Offset: 0x00007448
		public unsafe readonly FVectorDouble InverseTransformVector(in FVectorDouble v)
		{
			fixed (FVectorDouble* ptr = &v)
			{
				fixed (FTransformDouble* ptr2 = &this)
				{
					return FTransformDouble.Internal_InverseTransformVector(this, v);
				}
			}
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x00009264 File Offset: 0x00007464
		public unsafe readonly FVectorDouble InverseTransformVectorNoScale(in FVectorDouble v)
		{
			fixed (FVectorDouble* ptr = &v)
			{
				fixed (FTransformDouble* ptr2 = &this)
				{
					return FTransformDouble.Internal_InverseTransformVectorNoScale(this, v);
				}
			}
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x00009280 File Offset: 0x00007480
		public unsafe readonly FQuat TransformRotation(in FQuat q)
		{
			fixed (FQuat* ptr = &q)
			{
				fixed (FTransformDouble* ptr2 = &this)
				{
					return FTransformDouble.Internal_TransformRotation(this, q);
				}
			}
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x0000929C File Offset: 0x0000749C
		public unsafe readonly FQuat InverseTransformRotation(in FQuat q)
		{
			fixed (FQuat* ptr = &q)
			{
				fixed (FTransformDouble* ptr2 = &this)
				{
					return FTransformDouble.Internal_InverseTransformRotation(this, q);
				}
			}
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x000092B8 File Offset: 0x000074B8
		public unsafe readonly FVectorDouble GetLocation()
		{
			fixed (FTransformDouble* ptr = &this)
			{
				return FTransformDouble.Internal_GetLocation(this);
			}
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x000092D0 File Offset: 0x000074D0
		public unsafe void SetLocation(in FVectorDouble origin)
		{
			fixed (FVectorDouble* ptr = &origin)
			{
				fixed (FTransformDouble* ptr2 = &this)
				{
					FTransformDouble.Internal_SetLocation(ref this, origin);
				}
			}
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x000092F4 File Offset: 0x000074F4
		public unsafe readonly FRotator Rotator()
		{
			fixed (FTransformDouble* ptr = &this)
			{
				return FTransformDouble.Internal_Rotator(this);
			}
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x0000930C File Offset: 0x0000750C
		public unsafe readonly bool ContainsNaN()
		{
			fixed (FTransformDouble* ptr = &this)
			{
				return FTransformDouble.Internal_ContainsNaN(this);
			}
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x00009324 File Offset: 0x00007524
		public unsafe readonly bool IsValid()
		{
			fixed (FTransformDouble* ptr = &this)
			{
				return FTransformDouble.Internal_IsValid(this);
			}
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x0000933C File Offset: 0x0000753C
		public unsafe void SetComponents(in FQuat inRotation, in FVectorDouble inTranslation, in FVector inScale3D)
		{
			fixed (FQuat* ptr = &inRotation)
			{
				fixed (FVectorDouble* ptr2 = &inTranslation)
				{
					fixed (FVector* ptr3 = &inScale3D)
					{
						fixed (FTransformDouble* ptr4 = &this)
						{
							FTransformDouble.Internal_SetComponents(ref this, inRotation, inTranslation, inScale3D);
						}
					}
				}
			}
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x00009370 File Offset: 0x00007570
		public unsafe void SetTranslation(in FVectorDouble newTranslation)
		{
			fixed (FVectorDouble* ptr = &newTranslation)
			{
				fixed (FTransformDouble* ptr2 = &this)
				{
					FTransformDouble.Internal_SetTranslation(ref this, newTranslation);
				}
			}
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x00009394 File Offset: 0x00007594
		public unsafe void ConcatenateRotation(in FQuat deltaRotation)
		{
			fixed (FQuat* ptr = &deltaRotation)
			{
				fixed (FTransformDouble* ptr2 = &this)
				{
					FTransformDouble.Internal_ConcatenateRotation(ref this, deltaRotation);
				}
			}
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x000093B8 File Offset: 0x000075B8
		public unsafe readonly FTransform ToTransform()
		{
			fixed (FTransformDouble* ptr = &this)
			{
				return FTransformDouble.Internal_ToTransform(this);
			}
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x000093D0 File Offset: 0x000075D0
		public unsafe readonly FTransform ToLocalTransform(in FIntVector worldOffset)
		{
			fixed (FIntVector* ptr = &worldOffset)
			{
				fixed (FTransformDouble* ptr2 = &this)
				{
					return FTransformDouble.Internal_ToLocalTransform(this, worldOffset);
				}
			}
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x000093EC File Offset: 0x000075EC
		public unsafe void AddToTranslation(in FVectorDouble deltaTranslation)
		{
			fixed (FVectorDouble* ptr = &deltaTranslation)
			{
				fixed (FTransformDouble* ptr2 = &this)
				{
					FTransformDouble.Internal_AddToTranslation(ref this, deltaTranslation);
				}
			}
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x00009410 File Offset: 0x00007610
		public unsafe void SetRotation(in FQuat newRotation)
		{
			fixed (FQuat* ptr = &newRotation)
			{
				fixed (FTransformDouble* ptr2 = &this)
				{
					FTransformDouble.Internal_SetRotation(ref this, newRotation);
				}
			}
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x00009434 File Offset: 0x00007634
		public unsafe void SetScale3D(in FVector newScale3D)
		{
			fixed (FVector* ptr = &newScale3D)
			{
				fixed (FTransformDouble* ptr2 = &this)
				{
					FTransformDouble.Internal_SetScale3D(ref this, newScale3D);
				}
			}
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x00009458 File Offset: 0x00007658
		public unsafe void NormalizeRotation()
		{
			fixed (FTransformDouble* ptr = &this)
			{
				FTransformDouble.Internal_NormalizeRotation(ref this);
			}
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x00009474 File Offset: 0x00007674
		public unsafe readonly bool IsRotationNormalized()
		{
			fixed (FTransformDouble* ptr = &this)
			{
				return FTransformDouble.Internal_IsRotationNormalized(this);
			}
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x0000948C File Offset: 0x0000768C
		public unsafe readonly FQuat GetRotation()
		{
			fixed (FTransformDouble* ptr = &this)
			{
				return FTransformDouble.Internal_GetRotation(this);
			}
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x000094A4 File Offset: 0x000076A4
		public unsafe readonly FVectorDouble GetTranslation()
		{
			fixed (FTransformDouble* ptr = &this)
			{
				return FTransformDouble.Internal_GetTranslation(this);
			}
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x000094BC File Offset: 0x000076BC
		public unsafe readonly FVector GetScale3D()
		{
			fixed (FTransformDouble* ptr = &this)
			{
				return FTransformDouble.Internal_GetScale3D(this);
			}
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x000094D4 File Offset: 0x000076D4
		public unsafe readonly FTransformDouble Inverse()
		{
			fixed (FTransformDouble* ptr = &this)
			{
				return FTransformDouble.Internal_Inverse(this);
			}
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x000094EC File Offset: 0x000076EC
		public unsafe void Blend(in FTransformDouble atom1, in FTransformDouble atom2, float alpha)
		{
			fixed (FTransformDouble* ptr = &this)
			{
				fixed (FTransformDouble* ptr2 = &atom1)
				{
					fixed (FTransformDouble* ptr3 = &atom2)
					{
						FTransformDouble.Internal_Blend(ref this, atom1, atom2, alpha);
					}
				}
			}
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x00009518 File Offset: 0x00007718
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
			fixed (FTransformDouble* ptr3 = &this)
			{
				FCSharpStringView fcsharpStringView = new FCSharpStringView(ptr2, inSourceString.Length);
				return FTransformDouble.Internal_InitFromString(ref this, fcsharpStringView);
			}
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x0000955C File Offset: 0x0000775C
		IVector ITransform.GetLocation()
		{
			return this.Translation;
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x00009569 File Offset: 0x00007769
		void ITransform.SetLocation(IVector value)
		{
			this.Translation.X = value.X;
			this.Translation.Y = value.Y;
			this.Translation.Z = value.Z;
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x0000959E File Offset: 0x0000779E
		IQuat ITransform.GetRotation()
		{
			return this.Rotation;
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x000095AC File Offset: 0x000077AC
		void ITransform.SetRotation(IQuat value)
		{
			this.Rotation.X = (float)value.X;
			this.Rotation.Y = (float)value.Y;
			this.Rotation.Z = (float)value.Z;
			this.Rotation.W = (float)value.W;
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x00009601 File Offset: 0x00007801
		IVector ITransform.GetScale3D()
		{
			return this.Scale3D;
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x0000960E File Offset: 0x0000780E
		void ITransform.SetScale3D(IVector value)
		{
			this.Scale3D.X = (float)value.X;
			this.Scale3D.Y = (float)value.Y;
			this.Scale3D.Z = (float)value.Z;
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x00009646 File Offset: 0x00007846
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTransformDouble._ScriptStructPtr != 0) ? FTransformDouble._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.TransformDouble", ref FTransformDouble._ScriptStructPtr);
		}

		// Token: 0x040000B4 RID: 180
		public static readonly FTransformDouble Identity = new FTransformDouble();

		// Token: 0x040000B5 RID: 181
		[FieldOffset(0)]
		public FQuat Rotation;

		// Token: 0x040000B6 RID: 182
		[FieldOffset(16)]
		public FVectorDouble Translation;

		// Token: 0x040000B7 RID: 183
		[FieldOffset(40)]
		public FVector Scale3D;

		// Token: 0x040000B8 RID: 184
		[Nullable(0)]
		public const string __ObjectPath = "/Script/CoreUObject.TransformDouble";

		// Token: 0x040000B9 RID: 185
		private static IntPtr _ScriptStructPtr;
	}
}
