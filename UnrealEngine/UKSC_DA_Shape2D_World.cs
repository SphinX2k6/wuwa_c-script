using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000573 RID: 1395
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Shape2D_World")]
	[UnrealStructLayout(432, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 432)]
	public class UKSC_DA_Shape2D_World : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007E91 RID: 32401 RVA: 0x000BB8F6 File Offset: 0x000B9AF6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Shape2D_World._ClassPtr;
		}

		// Token: 0x06007E92 RID: 32402 RVA: 0x000BB904 File Offset: 0x000B9B04
		public UKSC_DA_Shape2D_World() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Shape2D_World.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007E93 RID: 32403 RVA: 0x000BB92C File Offset: 0x000B9B2C
		[NullableContext(1)]
		public UKSC_DA_Shape2D_World(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Shape2D_World.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700187A RID: 6266
		// (get) Token: 0x06007E94 RID: 32404 RVA: 0x000BB95F File Offset: 0x000B9B5F
		// (set) Token: 0x06007E95 RID: 32405 RVA: 0x000BB96F File Offset: 0x000B9B6F
		public unsafe float Gravity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_Gravity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_Gravity) = value;
			}
		}

		// Token: 0x1700187B RID: 6267
		// (get) Token: 0x06007E96 RID: 32406 RVA: 0x000BB980 File Offset: 0x000B9B80
		// (set) Token: 0x06007E97 RID: 32407 RVA: 0x000BB994 File Offset: 0x000B9B94
		public unsafe FVector2D GravityDir
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_GravityDir);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_GravityDir) = value;
			}
		}

		// Token: 0x1700187C RID: 6268
		// (get) Token: 0x06007E98 RID: 32408 RVA: 0x000BB9A9 File Offset: 0x000B9BA9
		// (set) Token: 0x06007E99 RID: 32409 RVA: 0x000BB9B9 File Offset: 0x000B9BB9
		public unsafe float RotateRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_RotateRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_RotateRange) = value;
			}
		}

		// Token: 0x1700187D RID: 6269
		// (get) Token: 0x06007E9A RID: 32410 RVA: 0x000BB9CA File Offset: 0x000B9BCA
		// (set) Token: 0x06007E9B RID: 32411 RVA: 0x000BB9DA File Offset: 0x000B9BDA
		public unsafe float RotateDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_RotateDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_RotateDuration) = value;
			}
		}

		// Token: 0x1700187E RID: 6270
		// (get) Token: 0x06007E9C RID: 32412 RVA: 0x000BB9EB File Offset: 0x000B9BEB
		// (set) Token: 0x06007E9D RID: 32413 RVA: 0x000BB9FB File Offset: 0x000B9BFB
		public unsafe float LaunchSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_LaunchSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_LaunchSpeed) = value;
			}
		}

		// Token: 0x1700187F RID: 6271
		// (get) Token: 0x06007E9E RID: 32414 RVA: 0x000BBA0C File Offset: 0x000B9C0C
		// (set) Token: 0x06007E9F RID: 32415 RVA: 0x000BBA20 File Offset: 0x000B9C20
		public unsafe UCurveFloat DirectionCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Shape2D_World.__PropertyOffset_DirectionCurve);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Shape2D_World.__PropertyOffset_DirectionCurve, value);
			}
		}

		// Token: 0x17001880 RID: 6272
		// (get) Token: 0x06007EA0 RID: 32416 RVA: 0x000BBA35 File Offset: 0x000B9C35
		// (set) Token: 0x06007EA1 RID: 32417 RVA: 0x000BBA49 File Offset: 0x000B9C49
		public unsafe UEffectModelBase LaunchHitEffect
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UEffectModelBase>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Shape2D_World.__PropertyOffset_LaunchHitEffect);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Shape2D_World.__PropertyOffset_LaunchHitEffect, value);
			}
		}

		// Token: 0x17001881 RID: 6273
		// (get) Token: 0x06007EA2 RID: 32418 RVA: 0x000BBA5E File Offset: 0x000B9C5E
		// (set) Token: 0x06007EA3 RID: 32419 RVA: 0x000BBA72 File Offset: 0x000B9C72
		public unsafe UEffectModelBase LaunchHitEffectPower1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UEffectModelBase>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Shape2D_World.__PropertyOffset_LaunchHitEffectPower1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Shape2D_World.__PropertyOffset_LaunchHitEffectPower1, value);
			}
		}

		// Token: 0x17001882 RID: 6274
		// (get) Token: 0x06007EA4 RID: 32420 RVA: 0x000BBA87 File Offset: 0x000B9C87
		// (set) Token: 0x06007EA5 RID: 32421 RVA: 0x000BBA9B File Offset: 0x000B9C9B
		public unsafe UEffectModelBase LaunchHitEffectPower2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UEffectModelBase>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Shape2D_World.__PropertyOffset_LaunchHitEffectPower2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Shape2D_World.__PropertyOffset_LaunchHitEffectPower2, value);
			}
		}

		// Token: 0x17001883 RID: 6275
		// (get) Token: 0x06007EA6 RID: 32422 RVA: 0x000BBAB0 File Offset: 0x000B9CB0
		// (set) Token: 0x06007EA7 RID: 32423 RVA: 0x000BBAC4 File Offset: 0x000B9CC4
		public unsafe UEffectModelBase LaunchHitEffectPower3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UEffectModelBase>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Shape2D_World.__PropertyOffset_LaunchHitEffectPower3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Shape2D_World.__PropertyOffset_LaunchHitEffectPower3, value);
			}
		}

		// Token: 0x17001884 RID: 6276
		// (get) Token: 0x06007EA8 RID: 32424 RVA: 0x000BBAD9 File Offset: 0x000B9CD9
		// (set) Token: 0x06007EA9 RID: 32425 RVA: 0x000BBAED File Offset: 0x000B9CED
		public unsafe FTransform LaunchHitEffectOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_LaunchHitEffectOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_LaunchHitEffectOffset) = value;
			}
		}

		// Token: 0x17001885 RID: 6277
		// (get) Token: 0x06007EAA RID: 32426 RVA: 0x000BBB02 File Offset: 0x000B9D02
		// (set) Token: 0x06007EAB RID: 32427 RVA: 0x000BBB16 File Offset: 0x000B9D16
		public unsafe FVector2D InitLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_InitLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_InitLocation) = value;
			}
		}

		// Token: 0x17001886 RID: 6278
		// (get) Token: 0x06007EAC RID: 32428 RVA: 0x000BBB2B File Offset: 0x000B9D2B
		// (set) Token: 0x06007EAD RID: 32429 RVA: 0x000BBB3B File Offset: 0x000B9D3B
		public unsafe float MoveDelaySeconds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_MoveDelaySeconds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_MoveDelaySeconds) = value;
			}
		}

		// Token: 0x17001887 RID: 6279
		// (get) Token: 0x06007EAE RID: 32430 RVA: 0x000BBB4C File Offset: 0x000B9D4C
		// (set) Token: 0x06007EAF RID: 32431 RVA: 0x000BBB5C File Offset: 0x000B9D5C
		public unsafe float MoveDelayMaxDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_MoveDelayMaxDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_MoveDelayMaxDistance) = value;
			}
		}

		// Token: 0x17001888 RID: 6280
		// (get) Token: 0x06007EB0 RID: 32432 RVA: 0x000BBB6D File Offset: 0x000B9D6D
		// (set) Token: 0x06007EB1 RID: 32433 RVA: 0x000BBB7D File Offset: 0x000B9D7D
		public unsafe float MoveMaxDistanceNeedSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_MoveMaxDistanceNeedSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_MoveMaxDistanceNeedSpeed) = value;
			}
		}

		// Token: 0x17001889 RID: 6281
		// (get) Token: 0x06007EB2 RID: 32434 RVA: 0x000BBB8E File Offset: 0x000B9D8E
		// (set) Token: 0x06007EB3 RID: 32435 RVA: 0x000BBB9E File Offset: 0x000B9D9E
		public unsafe float MoveDistanceInertialSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_MoveDistanceInertialSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_MoveDistanceInertialSpeed) = value;
			}
		}

		// Token: 0x1700188A RID: 6282
		// (get) Token: 0x06007EB4 RID: 32436 RVA: 0x000BBBAF File Offset: 0x000B9DAF
		// (set) Token: 0x06007EB5 RID: 32437 RVA: 0x000BBBBF File Offset: 0x000B9DBF
		public unsafe long CollisionDamageId0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_CollisionDamageId0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_CollisionDamageId0) = value;
			}
		}

		// Token: 0x1700188B RID: 6283
		// (get) Token: 0x06007EB6 RID: 32438 RVA: 0x000BBBD0 File Offset: 0x000B9DD0
		// (set) Token: 0x06007EB7 RID: 32439 RVA: 0x000BBBE0 File Offset: 0x000B9DE0
		public unsafe long CollisionDamageId1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_CollisionDamageId1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_CollisionDamageId1) = value;
			}
		}

		// Token: 0x1700188C RID: 6284
		// (get) Token: 0x06007EB8 RID: 32440 RVA: 0x000BBBF1 File Offset: 0x000B9DF1
		// (set) Token: 0x06007EB9 RID: 32441 RVA: 0x000BBC01 File Offset: 0x000B9E01
		public unsafe long CollisionDamageId2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_CollisionDamageId2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_CollisionDamageId2) = value;
			}
		}

		// Token: 0x1700188D RID: 6285
		// (get) Token: 0x06007EBA RID: 32442 RVA: 0x000BBC12 File Offset: 0x000B9E12
		// (set) Token: 0x06007EBB RID: 32443 RVA: 0x000BBC22 File Offset: 0x000B9E22
		public unsafe long CollisionDamageId3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_CollisionDamageId3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_CollisionDamageId3) = value;
			}
		}

		// Token: 0x1700188E RID: 6286
		// (get) Token: 0x06007EBC RID: 32444 RVA: 0x000BBC33 File Offset: 0x000B9E33
		// (set) Token: 0x06007EBD RID: 32445 RVA: 0x000BBC47 File Offset: 0x000B9E47
		public unsafe FGameplayTag PowerCollisionTag1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_PowerCollisionTag1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_PowerCollisionTag1) = value;
			}
		}

		// Token: 0x1700188F RID: 6287
		// (get) Token: 0x06007EBE RID: 32446 RVA: 0x000BBC5C File Offset: 0x000B9E5C
		// (set) Token: 0x06007EBF RID: 32447 RVA: 0x000BBC70 File Offset: 0x000B9E70
		public unsafe FGameplayTag PowerCollisionTag2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_PowerCollisionTag2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_PowerCollisionTag2) = value;
			}
		}

		// Token: 0x17001890 RID: 6288
		// (get) Token: 0x06007EC0 RID: 32448 RVA: 0x000BBC85 File Offset: 0x000B9E85
		// (set) Token: 0x06007EC1 RID: 32449 RVA: 0x000BBC99 File Offset: 0x000B9E99
		public unsafe FGameplayTag PowerCollisionTag3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_PowerCollisionTag3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_PowerCollisionTag3) = value;
			}
		}

		// Token: 0x17001891 RID: 6289
		// (get) Token: 0x06007EC2 RID: 32450 RVA: 0x000BBCAE File Offset: 0x000B9EAE
		// (set) Token: 0x06007EC3 RID: 32451 RVA: 0x000BBCC2 File Offset: 0x000B9EC2
		public unsafe UKSC_DA_Buff PowerCollisionBuff1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Buff>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Shape2D_World.__PropertyOffset_PowerCollisionBuff1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Shape2D_World.__PropertyOffset_PowerCollisionBuff1, value);
			}
		}

		// Token: 0x17001892 RID: 6290
		// (get) Token: 0x06007EC4 RID: 32452 RVA: 0x000BBCD7 File Offset: 0x000B9ED7
		// (set) Token: 0x06007EC5 RID: 32453 RVA: 0x000BBCEB File Offset: 0x000B9EEB
		public unsafe UKSC_DA_Buff PowerCollisionBuff2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Buff>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Shape2D_World.__PropertyOffset_PowerCollisionBuff2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Shape2D_World.__PropertyOffset_PowerCollisionBuff2, value);
			}
		}

		// Token: 0x17001893 RID: 6291
		// (get) Token: 0x06007EC6 RID: 32454 RVA: 0x000BBD00 File Offset: 0x000B9F00
		// (set) Token: 0x06007EC7 RID: 32455 RVA: 0x000BBD14 File Offset: 0x000B9F14
		public unsafe UKSC_DA_Buff PowerCollisionBuff3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Buff>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Shape2D_World.__PropertyOffset_PowerCollisionBuff3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Shape2D_World.__PropertyOffset_PowerCollisionBuff3, value);
			}
		}

		// Token: 0x17001894 RID: 6292
		// (get) Token: 0x06007EC8 RID: 32456 RVA: 0x000BBD29 File Offset: 0x000B9F29
		// (set) Token: 0x06007EC9 RID: 32457 RVA: 0x000BBD3D File Offset: 0x000B9F3D
		public unsafe UEffectModelBase CollisionDamageEffect0
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UEffectModelBase>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Shape2D_World.__PropertyOffset_CollisionDamageEffect0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Shape2D_World.__PropertyOffset_CollisionDamageEffect0, value);
			}
		}

		// Token: 0x17001895 RID: 6293
		// (get) Token: 0x06007ECA RID: 32458 RVA: 0x000BBD52 File Offset: 0x000B9F52
		// (set) Token: 0x06007ECB RID: 32459 RVA: 0x000BBD66 File Offset: 0x000B9F66
		public unsafe UEffectModelBase CollisionDamageEffect1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UEffectModelBase>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Shape2D_World.__PropertyOffset_CollisionDamageEffect1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Shape2D_World.__PropertyOffset_CollisionDamageEffect1, value);
			}
		}

		// Token: 0x17001896 RID: 6294
		// (get) Token: 0x06007ECC RID: 32460 RVA: 0x000BBD7B File Offset: 0x000B9F7B
		// (set) Token: 0x06007ECD RID: 32461 RVA: 0x000BBD8F File Offset: 0x000B9F8F
		public unsafe UEffectModelBase CollisionDamageEffect2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UEffectModelBase>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Shape2D_World.__PropertyOffset_CollisionDamageEffect2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Shape2D_World.__PropertyOffset_CollisionDamageEffect2, value);
			}
		}

		// Token: 0x17001897 RID: 6295
		// (get) Token: 0x06007ECE RID: 32462 RVA: 0x000BBDA4 File Offset: 0x000B9FA4
		// (set) Token: 0x06007ECF RID: 32463 RVA: 0x000BBDB8 File Offset: 0x000B9FB8
		public unsafe UEffectModelBase CollisionDamageEffect3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UEffectModelBase>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Shape2D_World.__PropertyOffset_CollisionDamageEffect3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_Shape2D_World.__PropertyOffset_CollisionDamageEffect3, value);
			}
		}

		// Token: 0x17001898 RID: 6296
		// (get) Token: 0x06007ED0 RID: 32464 RVA: 0x000BBDCD File Offset: 0x000B9FCD
		// (set) Token: 0x06007ED1 RID: 32465 RVA: 0x000BBDDD File Offset: 0x000B9FDD
		public unsafe byte CollisionDamageEffectMaxCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_CollisionDamageEffectMaxCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_CollisionDamageEffectMaxCount) = value;
			}
		}

		// Token: 0x17001899 RID: 6297
		// (get) Token: 0x06007ED2 RID: 32466 RVA: 0x000BBDEE File Offset: 0x000B9FEE
		// (set) Token: 0x06007ED3 RID: 32467 RVA: 0x000BBDFE File Offset: 0x000B9FFE
		public unsafe int PowerCollisionCount1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_PowerCollisionCount1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_PowerCollisionCount1) = value;
			}
		}

		// Token: 0x1700189A RID: 6298
		// (get) Token: 0x06007ED4 RID: 32468 RVA: 0x000BBE0F File Offset: 0x000BA00F
		// (set) Token: 0x06007ED5 RID: 32469 RVA: 0x000BBE1F File Offset: 0x000BA01F
		public unsafe int PowerCollisionCount2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_PowerCollisionCount2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_PowerCollisionCount2) = value;
			}
		}

		// Token: 0x1700189B RID: 6299
		// (get) Token: 0x06007ED6 RID: 32470 RVA: 0x000BBE30 File Offset: 0x000BA030
		// (set) Token: 0x06007ED7 RID: 32471 RVA: 0x000BBE40 File Offset: 0x000BA040
		public unsafe int PowerCollisionCount3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_PowerCollisionCount3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_PowerCollisionCount3) = value;
			}
		}

		// Token: 0x1700189C RID: 6300
		// (get) Token: 0x06007ED8 RID: 32472 RVA: 0x000BBE51 File Offset: 0x000BA051
		// (set) Token: 0x06007ED9 RID: 32473 RVA: 0x000BBE61 File Offset: 0x000BA061
		public unsafe float RecoverSprintEnergy
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_RecoverSprintEnergy);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_RecoverSprintEnergy) = value;
			}
		}

		// Token: 0x1700189D RID: 6301
		// (get) Token: 0x06007EDA RID: 32474 RVA: 0x000BBE72 File Offset: 0x000BA072
		// (set) Token: 0x06007EDB RID: 32475 RVA: 0x000BBE82 File Offset: 0x000BA082
		public unsafe float RecoverSprintEnergyCD
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_RecoverSprintEnergyCD);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_RecoverSprintEnergyCD) = value;
			}
		}

		// Token: 0x1700189E RID: 6302
		// (get) Token: 0x06007EDC RID: 32476 RVA: 0x000BBE93 File Offset: 0x000BA093
		// (set) Token: 0x06007EDD RID: 32477 RVA: 0x000BBEA3 File Offset: 0x000BA0A3
		public unsafe float CollisionDamageCD
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_CollisionDamageCD);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_CollisionDamageCD) = value;
			}
		}

		// Token: 0x1700189F RID: 6303
		// (get) Token: 0x06007EDE RID: 32478 RVA: 0x000BBEB4 File Offset: 0x000BA0B4
		// (set) Token: 0x06007EDF RID: 32479 RVA: 0x000BBEC4 File Offset: 0x000BA0C4
		public unsafe float CollisionDamageCDInIgnore
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_CollisionDamageCDInIgnore);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_CollisionDamageCDInIgnore) = value;
			}
		}

		// Token: 0x170018A0 RID: 6304
		// (get) Token: 0x06007EE0 RID: 32480 RVA: 0x000BBED5 File Offset: 0x000BA0D5
		// (set) Token: 0x06007EE1 RID: 32481 RVA: 0x000BBEE9 File Offset: 0x000BA0E9
		public unsafe FGameplayTag DisableCollisionDamageTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_DisableCollisionDamageTag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_DisableCollisionDamageTag) = value;
			}
		}

		// Token: 0x170018A1 RID: 6305
		// (get) Token: 0x06007EE2 RID: 32482 RVA: 0x000BBEFE File Offset: 0x000BA0FE
		// (set) Token: 0x06007EE3 RID: 32483 RVA: 0x000BBF12 File Offset: 0x000BA112
		public unsafe FGameplayTag DeadTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_DeadTag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_DeadTag) = value;
			}
		}

		// Token: 0x170018A2 RID: 6306
		// (get) Token: 0x06007EE4 RID: 32484 RVA: 0x000BBF27 File Offset: 0x000BA127
		// (set) Token: 0x06007EE5 RID: 32485 RVA: 0x000BBF3B File Offset: 0x000BA13B
		public unsafe FLinearColor PlayerBeHitColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_PlayerBeHitColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_PlayerBeHitColor) = value;
			}
		}

		// Token: 0x170018A3 RID: 6307
		// (get) Token: 0x06007EE6 RID: 32486 RVA: 0x000BBF50 File Offset: 0x000BA150
		// (set) Token: 0x06007EE7 RID: 32487 RVA: 0x000BBF60 File Offset: 0x000BA160
		public unsafe float PlayerBeHitColorCD
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_PlayerBeHitColorCD);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_PlayerBeHitColorCD) = value;
			}
		}

		// Token: 0x170018A4 RID: 6308
		// (get) Token: 0x06007EE8 RID: 32488 RVA: 0x000BBF71 File Offset: 0x000BA171
		// (set) Token: 0x06007EE9 RID: 32489 RVA: 0x000BBF85 File Offset: 0x000BA185
		public unsafe FLinearColor EnemyBeHitColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_EnemyBeHitColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_EnemyBeHitColor) = value;
			}
		}

		// Token: 0x170018A5 RID: 6309
		// (get) Token: 0x06007EEA RID: 32490 RVA: 0x000BBF9A File Offset: 0x000BA19A
		// (set) Token: 0x06007EEB RID: 32491 RVA: 0x000BBFAA File Offset: 0x000BA1AA
		public unsafe float EnemyBeHitColorCD
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_EnemyBeHitColorCD);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_EnemyBeHitColorCD) = value;
			}
		}

		// Token: 0x170018A6 RID: 6310
		// (get) Token: 0x06007EEC RID: 32492 RVA: 0x000BBFBB File Offset: 0x000BA1BB
		// (set) Token: 0x06007EED RID: 32493 RVA: 0x000BBFCB File Offset: 0x000BA1CB
		public unsafe float BeHitColorDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_BeHitColorDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Shape2D_World.__PropertyOffset_BeHitColorDuration) = value;
			}
		}

		// Token: 0x06007EEE RID: 32494 RVA: 0x000BBFDC File Offset: 0x000BA1DC
		static UKSC_DA_Shape2D_World()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Shape2D_World");
		}

		// Token: 0x06007EEF RID: 32495 RVA: 0x000BBFEA File Offset: 0x000BA1EA
		protected UKSC_DA_Shape2D_World(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003742 RID: 14146
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Shape2D_World";

		// Token: 0x04003743 RID: 14147
		private static IntPtr _ClassPtr;

		// Token: 0x04003744 RID: 14148
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003745 RID: 14149
		internal static int __PropertyOffset_Gravity;

		// Token: 0x04003746 RID: 14150
		internal static int __PropertyOffset_GravityDir;

		// Token: 0x04003747 RID: 14151
		internal static int __PropertyOffset_RotateRange;

		// Token: 0x04003748 RID: 14152
		internal static int __PropertyOffset_RotateDuration;

		// Token: 0x04003749 RID: 14153
		internal static int __PropertyOffset_LaunchSpeed;

		// Token: 0x0400374A RID: 14154
		internal static int __PropertyOffset_DirectionCurve;

		// Token: 0x0400374B RID: 14155
		internal static int __PropertyOffset_LaunchHitEffect;

		// Token: 0x0400374C RID: 14156
		internal static int __PropertyOffset_LaunchHitEffectPower1;

		// Token: 0x0400374D RID: 14157
		internal static int __PropertyOffset_LaunchHitEffectPower2;

		// Token: 0x0400374E RID: 14158
		internal static int __PropertyOffset_LaunchHitEffectPower3;

		// Token: 0x0400374F RID: 14159
		internal static int __PropertyOffset_LaunchHitEffectOffset;

		// Token: 0x04003750 RID: 14160
		internal static int __PropertyOffset_InitLocation;

		// Token: 0x04003751 RID: 14161
		internal static int __PropertyOffset_MoveDelaySeconds;

		// Token: 0x04003752 RID: 14162
		internal static int __PropertyOffset_MoveDelayMaxDistance;

		// Token: 0x04003753 RID: 14163
		internal static int __PropertyOffset_MoveMaxDistanceNeedSpeed;

		// Token: 0x04003754 RID: 14164
		internal static int __PropertyOffset_MoveDistanceInertialSpeed;

		// Token: 0x04003755 RID: 14165
		internal static int __PropertyOffset_CollisionDamageId0;

		// Token: 0x04003756 RID: 14166
		internal static int __PropertyOffset_CollisionDamageId1;

		// Token: 0x04003757 RID: 14167
		internal static int __PropertyOffset_CollisionDamageId2;

		// Token: 0x04003758 RID: 14168
		internal static int __PropertyOffset_CollisionDamageId3;

		// Token: 0x04003759 RID: 14169
		internal static int __PropertyOffset_PowerCollisionTag1;

		// Token: 0x0400375A RID: 14170
		internal static int __PropertyOffset_PowerCollisionTag2;

		// Token: 0x0400375B RID: 14171
		internal static int __PropertyOffset_PowerCollisionTag3;

		// Token: 0x0400375C RID: 14172
		internal static int __PropertyOffset_PowerCollisionBuff1;

		// Token: 0x0400375D RID: 14173
		internal static int __PropertyOffset_PowerCollisionBuff2;

		// Token: 0x0400375E RID: 14174
		internal static int __PropertyOffset_PowerCollisionBuff3;

		// Token: 0x0400375F RID: 14175
		internal static int __PropertyOffset_CollisionDamageEffect0;

		// Token: 0x04003760 RID: 14176
		internal static int __PropertyOffset_CollisionDamageEffect1;

		// Token: 0x04003761 RID: 14177
		internal static int __PropertyOffset_CollisionDamageEffect2;

		// Token: 0x04003762 RID: 14178
		internal static int __PropertyOffset_CollisionDamageEffect3;

		// Token: 0x04003763 RID: 14179
		internal static int __PropertyOffset_CollisionDamageEffectMaxCount;

		// Token: 0x04003764 RID: 14180
		internal static int __PropertyOffset_PowerCollisionCount1;

		// Token: 0x04003765 RID: 14181
		internal static int __PropertyOffset_PowerCollisionCount2;

		// Token: 0x04003766 RID: 14182
		internal static int __PropertyOffset_PowerCollisionCount3;

		// Token: 0x04003767 RID: 14183
		internal static int __PropertyOffset_RecoverSprintEnergy;

		// Token: 0x04003768 RID: 14184
		internal static int __PropertyOffset_RecoverSprintEnergyCD;

		// Token: 0x04003769 RID: 14185
		internal static int __PropertyOffset_CollisionDamageCD;

		// Token: 0x0400376A RID: 14186
		internal static int __PropertyOffset_CollisionDamageCDInIgnore;

		// Token: 0x0400376B RID: 14187
		internal static int __PropertyOffset_DisableCollisionDamageTag;

		// Token: 0x0400376C RID: 14188
		internal static int __PropertyOffset_DeadTag;

		// Token: 0x0400376D RID: 14189
		internal static int __PropertyOffset_PlayerBeHitColor;

		// Token: 0x0400376E RID: 14190
		internal static int __PropertyOffset_PlayerBeHitColorCD;

		// Token: 0x0400376F RID: 14191
		internal static int __PropertyOffset_EnemyBeHitColor;

		// Token: 0x04003770 RID: 14192
		internal static int __PropertyOffset_EnemyBeHitColorCD;

		// Token: 0x04003771 RID: 14193
		internal static int __PropertyOffset_BeHitColorDuration;
	}
}
