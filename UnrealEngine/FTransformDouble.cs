using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200003D RID: 61
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(64, 16, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 64)]
	[UnrealObjectPath("/Script/CoreUObject.TransformDouble")]
	[StructLayout(LayoutKind.Explicit, Pack = 16, Size = 64)]
	public struct FTransformDouble : IEquatable<FTransformDouble>, IEqualityOperators<FTransformDouble, FTransformDouble, bool>, ITransform, IUnrealScriptStruct
	{
		// Token: 0x0600053D RID: 1341 RVA: 0x0000C44A File Offset: 0x0000A64A
		public static bool operator ==(FTransformDouble left, FTransformDouble right)
		{
			return left.Translation.Equals(right.Translation) && left.Rotation.Equals(right.Rotation) && left.Scale3D.Equals(right.Scale3D);
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x0000C488 File Offset: 0x0000A688
		public static bool operator !=(FTransformDouble left, FTransformDouble right)
		{
			return left.Translation != right.Translation || left.Rotation != right.Rotation || left.Scale3D != right.Scale3D;
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x0000C4C4 File Offset: 0x0000A6C4
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

		// Token: 0x06000540 RID: 1344 RVA: 0x0000C5E2 File Offset: 0x0000A7E2
		public readonly bool Equals(FTransformDouble other)
		{
			return this == other;
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x0000C5F0 File Offset: 0x0000A7F0
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

		// Token: 0x06000542 RID: 1346 RVA: 0x0000C61A File Offset: 0x0000A81A
		public override readonly int GetHashCode()
		{
			return HashCode.Combine<FQuat, FVectorDouble, FVector>(this.Rotation, this.Translation, this.Scale3D);
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x0000C634 File Offset: 0x0000A834
		public void SetScale3D(in FVectorDouble Scale)
		{
			FVector fvector = Scale;
			this.SetScale3D(fvector);
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x0000C650 File Offset: 0x0000A850
		public FTransformDouble()
		{
			this.Rotation = default(FQuat);
			this.Translation = default(FVectorDouble);
			this.Rotation.W = 1f;
			this.Scale3D.X = 1f;
			this.Scale3D.Y = 1f;
			this.Scale3D.Z = 1f;
		}

		// Token: 0x06000545 RID: 1349
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransformDouble Internal_Ctor_FVectorDouble(in FVectorDouble inTranslation);

		// Token: 0x06000546 RID: 1350
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransformDouble Internal_Ctor_FQuat(in FQuat inRotation);

		// Token: 0x06000547 RID: 1351
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransformDouble Internal_Ctor_FRotator(in FRotator inRotation);

		// Token: 0x06000548 RID: 1352
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransformDouble Internal_Ctor_FTransform(in FTransform inTransform);

		// Token: 0x06000549 RID: 1353
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransformDouble Internal_Ctor_FQuat_FVectorDouble(in FQuat inRotation, in FVectorDouble inTranslation);

		// Token: 0x0600054A RID: 1354
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransformDouble Internal_Ctor_FQuat_FVectorDouble_FVector(in FQuat inRotation, in FVectorDouble inTranslation, in FVector inScale3D);

		// Token: 0x0600054B RID: 1355
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransformDouble Internal_Ctor_FRotator_FVectorDouble(in FRotator inRotation, in FVectorDouble inTranslation);

		// Token: 0x0600054C RID: 1356
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransformDouble Internal_Ctor_FRotator_FVectorDouble_FVector(in FRotator inRotation, in FVectorDouble inTranslation, in FVector inScale3D);

		// Token: 0x0600054D RID: 1357
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransformDouble Internal_Ctor_FTransform_FIntVector(in FTransform inTransform, in FIntVector offset);

		// Token: 0x0600054E RID: 1358
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Multiply(out FTransformDouble result, in FTransformDouble a, in FTransformDouble b);

		// Token: 0x0600054F RID: 1359
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransformDouble Internal_Mul(in FTransformDouble a, in FTransformDouble b);

		// Token: 0x06000550 RID: 1360
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransformDouble Internal_MulFQuat(in FTransformDouble a, in FQuat q);

		// Token: 0x06000551 RID: 1361
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_Equals(in FTransformDouble a, in FTransformDouble b, float tolerance = 0.0001f);

		// Token: 0x06000552 RID: 1362
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_Identical(in FTransformDouble a, in FTransformDouble b, uint portFlags = 0U);

		// Token: 0x06000553 RID: 1363
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransformDouble Internal_GetRelativeTransform(in FTransformDouble a, in FTransformDouble b);

		// Token: 0x06000554 RID: 1364
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransformDouble Internal_GetRelativeTransformReverse(in FTransformDouble a, in FTransformDouble b);

		// Token: 0x06000555 RID: 1365
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_TransformPosition(in FTransformDouble a, in FVectorDouble v);

		// Token: 0x06000556 RID: 1366
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_TransformPositionNoScale(in FTransformDouble a, in FVectorDouble v);

		// Token: 0x06000557 RID: 1367
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_InverseTransformPosition(in FTransformDouble a, in FVectorDouble v);

		// Token: 0x06000558 RID: 1368
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_InverseTransformPositionNoScale(in FTransformDouble a, in FVectorDouble v);

		// Token: 0x06000559 RID: 1369
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_TransformVector(in FTransformDouble a, in FVectorDouble v);

		// Token: 0x0600055A RID: 1370
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_TransformVectorNoScale(in FTransformDouble a, in FVectorDouble v);

		// Token: 0x0600055B RID: 1371
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_InverseTransformVector(in FTransformDouble a, in FVectorDouble v);

		// Token: 0x0600055C RID: 1372
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_InverseTransformVectorNoScale(in FTransformDouble a, in FVectorDouble v);

		// Token: 0x0600055D RID: 1373
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat Internal_TransformRotation(in FTransformDouble a, in FQuat q);

		// Token: 0x0600055E RID: 1374
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat Internal_InverseTransformRotation(in FTransformDouble a, in FQuat q);

		// Token: 0x0600055F RID: 1375
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_GetLocation(in FTransformDouble a);

		// Token: 0x06000560 RID: 1376
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_SetLocation(ref FTransformDouble a, in FVectorDouble origin);

		// Token: 0x06000561 RID: 1377
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator Internal_Rotator(in FTransformDouble a);

		// Token: 0x06000562 RID: 1378
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_ContainsNaN(in FTransformDouble a);

		// Token: 0x06000563 RID: 1379
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IsValid(in FTransformDouble a);

		// Token: 0x06000564 RID: 1380
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_SetComponents(ref FTransformDouble a, in FQuat inRotation, in FVectorDouble inTranslation, in FVector inScale3D);

		// Token: 0x06000565 RID: 1381
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_SetTranslation(ref FTransformDouble a, in FVectorDouble newTranslation);

		// Token: 0x06000566 RID: 1382
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_ConcatenateRotation(ref FTransformDouble a, in FQuat deltaRotation);

		// Token: 0x06000567 RID: 1383
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform Internal_ToTransform(in FTransformDouble a);

		// Token: 0x06000568 RID: 1384
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform Internal_ToLocalTransform(in FTransformDouble a, in FIntVector worldOffset);

		// Token: 0x06000569 RID: 1385
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_AddToTranslation(ref FTransformDouble a, in FVectorDouble deltaTranslation);

		// Token: 0x0600056A RID: 1386
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_SetRotation(ref FTransformDouble a, in FQuat newRotation);

		// Token: 0x0600056B RID: 1387
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_SetScale3D(ref FTransformDouble a, in FVector newScale3D);

		// Token: 0x0600056C RID: 1388
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_NormalizeRotation(ref FTransformDouble a);

		// Token: 0x0600056D RID: 1389
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IsRotationNormalized(in FTransformDouble a);

		// Token: 0x0600056E RID: 1390
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat Internal_GetRotation(in FTransformDouble a);

		// Token: 0x0600056F RID: 1391
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_GetTranslation(in FTransformDouble a);

		// Token: 0x06000570 RID: 1392
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_GetScale3D(in FTransformDouble a);

		// Token: 0x06000571 RID: 1393
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransformDouble Internal_Inverse(in FTransformDouble a);

		// Token: 0x06000572 RID: 1394
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Blend(ref FTransformDouble a, in FTransformDouble atom1, in FTransformDouble atom2, float alpha);

		// Token: 0x06000573 RID: 1395
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_InitFromString(ref FTransformDouble a, in FCSharpStringView inSourceString);

		// Token: 0x06000574 RID: 1396 RVA: 0x0000C6B8 File Offset: 0x0000A8B8
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

		// Token: 0x06000575 RID: 1397 RVA: 0x0000C6E0 File Offset: 0x0000A8E0
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

		// Token: 0x06000576 RID: 1398 RVA: 0x0000C708 File Offset: 0x0000A908
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

		// Token: 0x06000577 RID: 1399 RVA: 0x0000C730 File Offset: 0x0000A930
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

		// Token: 0x06000578 RID: 1400 RVA: 0x0000C758 File Offset: 0x0000A958
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

		// Token: 0x06000579 RID: 1401 RVA: 0x0000C788 File Offset: 0x0000A988
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

		// Token: 0x0600057A RID: 1402 RVA: 0x0000C7C0 File Offset: 0x0000A9C0
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

		// Token: 0x0600057B RID: 1403 RVA: 0x0000C7F0 File Offset: 0x0000A9F0
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

		// Token: 0x0600057C RID: 1404 RVA: 0x0000C828 File Offset: 0x0000AA28
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

		// Token: 0x0600057D RID: 1405 RVA: 0x0000C858 File Offset: 0x0000AA58
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

		// Token: 0x0600057E RID: 1406 RVA: 0x0000C884 File Offset: 0x0000AA84
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

		// Token: 0x0600057F RID: 1407 RVA: 0x0000C8A0 File Offset: 0x0000AAA0
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

		// Token: 0x06000580 RID: 1408 RVA: 0x0000C8BC File Offset: 0x0000AABC
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

		// Token: 0x06000581 RID: 1409 RVA: 0x0000C8DC File Offset: 0x0000AADC
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

		// Token: 0x06000582 RID: 1410 RVA: 0x0000C8FC File Offset: 0x0000AAFC
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

		// Token: 0x06000583 RID: 1411 RVA: 0x0000C918 File Offset: 0x0000AB18
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

		// Token: 0x06000584 RID: 1412 RVA: 0x0000C934 File Offset: 0x0000AB34
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

		// Token: 0x06000585 RID: 1413 RVA: 0x0000C950 File Offset: 0x0000AB50
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

		// Token: 0x06000586 RID: 1414 RVA: 0x0000C96C File Offset: 0x0000AB6C
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

		// Token: 0x06000587 RID: 1415 RVA: 0x0000C988 File Offset: 0x0000AB88
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

		// Token: 0x06000588 RID: 1416 RVA: 0x0000C9A4 File Offset: 0x0000ABA4
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

		// Token: 0x06000589 RID: 1417 RVA: 0x0000C9C0 File Offset: 0x0000ABC0
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

		// Token: 0x0600058A RID: 1418 RVA: 0x0000C9DC File Offset: 0x0000ABDC
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

		// Token: 0x0600058B RID: 1419 RVA: 0x0000C9F8 File Offset: 0x0000ABF8
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

		// Token: 0x0600058C RID: 1420 RVA: 0x0000CA14 File Offset: 0x0000AC14
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

		// Token: 0x0600058D RID: 1421 RVA: 0x0000CA30 File Offset: 0x0000AC30
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

		// Token: 0x0600058E RID: 1422 RVA: 0x0000CA4C File Offset: 0x0000AC4C
		public unsafe readonly FVectorDouble GetLocation()
		{
			fixed (FTransformDouble* ptr = &this)
			{
				return FTransformDouble.Internal_GetLocation(this);
			}
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x0000CA64 File Offset: 0x0000AC64
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

		// Token: 0x06000590 RID: 1424 RVA: 0x0000CA88 File Offset: 0x0000AC88
		public unsafe readonly FRotator Rotator()
		{
			fixed (FTransformDouble* ptr = &this)
			{
				return FTransformDouble.Internal_Rotator(this);
			}
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x0000CAA0 File Offset: 0x0000ACA0
		public unsafe readonly bool ContainsNaN()
		{
			fixed (FTransformDouble* ptr = &this)
			{
				return FTransformDouble.Internal_ContainsNaN(this);
			}
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x0000CAB8 File Offset: 0x0000ACB8
		public unsafe readonly bool IsValid()
		{
			fixed (FTransformDouble* ptr = &this)
			{
				return FTransformDouble.Internal_IsValid(this);
			}
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x0000CAD0 File Offset: 0x0000ACD0
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

		// Token: 0x06000594 RID: 1428 RVA: 0x0000CB04 File Offset: 0x0000AD04
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

		// Token: 0x06000595 RID: 1429 RVA: 0x0000CB28 File Offset: 0x0000AD28
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

		// Token: 0x06000596 RID: 1430 RVA: 0x0000CB4C File Offset: 0x0000AD4C
		public unsafe readonly FTransform ToTransform()
		{
			fixed (FTransformDouble* ptr = &this)
			{
				return FTransformDouble.Internal_ToTransform(this);
			}
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x0000CB64 File Offset: 0x0000AD64
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

		// Token: 0x06000598 RID: 1432 RVA: 0x0000CB80 File Offset: 0x0000AD80
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

		// Token: 0x06000599 RID: 1433 RVA: 0x0000CBA4 File Offset: 0x0000ADA4
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

		// Token: 0x0600059A RID: 1434 RVA: 0x0000CBC8 File Offset: 0x0000ADC8
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

		// Token: 0x0600059B RID: 1435 RVA: 0x0000CBEC File Offset: 0x0000ADEC
		public unsafe void NormalizeRotation()
		{
			fixed (FTransformDouble* ptr = &this)
			{
				FTransformDouble.Internal_NormalizeRotation(ref this);
			}
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x0000CC08 File Offset: 0x0000AE08
		public unsafe readonly bool IsRotationNormalized()
		{
			fixed (FTransformDouble* ptr = &this)
			{
				return FTransformDouble.Internal_IsRotationNormalized(this);
			}
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x0000CC20 File Offset: 0x0000AE20
		public unsafe readonly FQuat GetRotation()
		{
			fixed (FTransformDouble* ptr = &this)
			{
				return FTransformDouble.Internal_GetRotation(this);
			}
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x0000CC38 File Offset: 0x0000AE38
		public unsafe readonly FVectorDouble GetTranslation()
		{
			fixed (FTransformDouble* ptr = &this)
			{
				return FTransformDouble.Internal_GetTranslation(this);
			}
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x0000CC50 File Offset: 0x0000AE50
		public unsafe readonly FVector GetScale3D()
		{
			fixed (FTransformDouble* ptr = &this)
			{
				return FTransformDouble.Internal_GetScale3D(this);
			}
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x0000CC68 File Offset: 0x0000AE68
		public unsafe readonly FTransformDouble Inverse()
		{
			fixed (FTransformDouble* ptr = &this)
			{
				return FTransformDouble.Internal_Inverse(this);
			}
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x0000CC80 File Offset: 0x0000AE80
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

		// Token: 0x060005A2 RID: 1442 RVA: 0x0000CCAC File Offset: 0x0000AEAC
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

		// Token: 0x060005A3 RID: 1443 RVA: 0x0000CCF0 File Offset: 0x0000AEF0
		IVector ITransform.GetLocation()
		{
			return this.Translation;
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x0000CCFD File Offset: 0x0000AEFD
		void ITransform.SetLocation(IVector value)
		{
			this.Translation.X = value.X;
			this.Translation.Y = value.Y;
			this.Translation.Z = value.Z;
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x0000CD32 File Offset: 0x0000AF32
		IQuat ITransform.GetRotation()
		{
			return this.Rotation;
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x0000CD40 File Offset: 0x0000AF40
		void ITransform.SetRotation(IQuat value)
		{
			this.Rotation.X = (float)value.X;
			this.Rotation.Y = (float)value.Y;
			this.Rotation.Z = (float)value.Z;
			this.Rotation.W = (float)value.W;
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x0000CD95 File Offset: 0x0000AF95
		IVector ITransform.GetScale3D()
		{
			return this.Scale3D;
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x0000CDA2 File Offset: 0x0000AFA2
		void ITransform.SetScale3D(IVector value)
		{
			this.Scale3D.X = (float)value.X;
			this.Scale3D.Y = (float)value.Y;
			this.Scale3D.Z = (float)value.Z;
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x0000CDDA File Offset: 0x0000AFDA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTransformDouble._ScriptStructPtr != 0) ? FTransformDouble._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.TransformDouble", ref FTransformDouble._ScriptStructPtr);
		}

		// Token: 0x040000FB RID: 251
		public static readonly FTransformDouble Identity = new FTransformDouble();

		// Token: 0x040000FC RID: 252
		[FieldOffset(0)]
		public FQuat Rotation;

		// Token: 0x040000FD RID: 253
		[FieldOffset(16)]
		public FVectorDouble Translation;

		// Token: 0x040000FE RID: 254
		[FieldOffset(40)]
		public FVector Scale3D;

		// Token: 0x040000FF RID: 255
		[Nullable(0)]
		public const string __ObjectPath = "/Script/CoreUObject.TransformDouble";

		// Token: 0x04000100 RID: 256
		private static IntPtr _ScriptStructPtr;
	}
}
