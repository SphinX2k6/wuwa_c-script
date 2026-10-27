using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001601 RID: 5633
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.AbpLogicParams")]
	[UnrealStructLayout(560, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 560)]
	public class UAbpLogicParams : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601443B RID: 83003 RVA: 0x001DC6EF File Offset: 0x001DA8EF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAbpLogicParams._ClassPtr;
		}

		// Token: 0x0601443C RID: 83004 RVA: 0x001DC6FC File Offset: 0x001DA8FC
		public UAbpLogicParams() : this(BuiltinUtils.AllocNativeUObject(UAbpLogicParams.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601443D RID: 83005 RVA: 0x001DC724 File Offset: 0x001DA924
		public UAbpLogicParams(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAbpLogicParams.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004F5A RID: 20314
		// (get) Token: 0x0601443E RID: 83006 RVA: 0x001DC757 File Offset: 0x001DA957
		// (set) Token: 0x0601443F RID: 83007 RVA: 0x001DC767 File Offset: 0x001DA967
		public unsafe bool AcceptedNewBeHitRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_AcceptedNewBeHitRef) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_AcceptedNewBeHitRef) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004F5B RID: 20315
		// (get) Token: 0x06014440 RID: 83008 RVA: 0x001DC778 File Offset: 0x001DA978
		// (set) Token: 0x06014441 RID: 83009 RVA: 0x001DC788 File Offset: 0x001DA988
		public unsafe int BeHitAnimRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_BeHitAnimRef);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_BeHitAnimRef) = value;
			}
		}

		// Token: 0x17004F5C RID: 20316
		// (get) Token: 0x06014442 RID: 83010 RVA: 0x001DC799 File Offset: 0x001DA999
		// (set) Token: 0x06014443 RID: 83011 RVA: 0x001DC7A9 File Offset: 0x001DA9A9
		public unsafe bool EnterFkRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_EnterFkRef) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_EnterFkRef) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004F5D RID: 20317
		// (get) Token: 0x06014444 RID: 83012 RVA: 0x001DC7BA File Offset: 0x001DA9BA
		// (set) Token: 0x06014445 RID: 83013 RVA: 0x001DC7CA File Offset: 0x001DA9CA
		public unsafe bool DoubleHitInAirRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_DoubleHitInAirRef) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_DoubleHitInAirRef) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004F5E RID: 20318
		// (get) Token: 0x06014446 RID: 83014 RVA: 0x001DC7DB File Offset: 0x001DA9DB
		// (set) Token: 0x06014447 RID: 83015 RVA: 0x001DC7EF File Offset: 0x001DA9EF
		public unsafe FVector BeHitDirectRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_BeHitDirectRef);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_BeHitDirectRef) = value;
			}
		}

		// Token: 0x17004F5F RID: 20319
		// (get) Token: 0x06014448 RID: 83016 RVA: 0x001DC804 File Offset: 0x001DAA04
		// (set) Token: 0x06014449 RID: 83017 RVA: 0x001DC818 File Offset: 0x001DAA18
		public unsafe FVector BeHitLocationRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_BeHitLocationRef);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_BeHitLocationRef) = value;
			}
		}

		// Token: 0x17004F60 RID: 20320
		// (get) Token: 0x0601444A RID: 83018 RVA: 0x001DC82D File Offset: 0x001DAA2D
		// (set) Token: 0x0601444B RID: 83019 RVA: 0x001DC841 File Offset: 0x001DAA41
		public unsafe FName BeHitSocketNameRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_BeHitSocketNameRef);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_BeHitSocketNameRef) = value;
			}
		}

		// Token: 0x17004F61 RID: 20321
		// (get) Token: 0x0601444C RID: 83020 RVA: 0x001DC856 File Offset: 0x001DAA56
		// (set) Token: 0x0601444D RID: 83021 RVA: 0x001DC86A File Offset: 0x001DAA6A
		public unsafe FName BeHitBoneRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_BeHitBoneRef);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_BeHitBoneRef) = value;
			}
		}

		// Token: 0x17004F62 RID: 20322
		// (get) Token: 0x0601444E RID: 83022 RVA: 0x001DC880 File Offset: 0x001DAA80
		// (set) Token: 0x0601444F RID: 83023 RVA: 0x001DC8B9 File Offset: 0x001DAAB9
		public FBoneFeedbackAnimHitInfo HitInfo
		{
			get
			{
				base.FastCheckIsValid();
				FBoneFeedbackAnimHitInfo result;
				if ((result = this._HitInfo) == null)
				{
					result = (this._HitInfo = new FBoneFeedbackAnimHitInfo(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_HitInfo, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneFeedbackAnimHitInfo.StaticStruct(), base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_HitInfo, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004F63 RID: 20323
		// (get) Token: 0x06014450 RID: 83024 RVA: 0x001DC8DA File Offset: 0x001DAADA
		// (set) Token: 0x06014451 RID: 83025 RVA: 0x001DC8EA File Offset: 0x001DAAEA
		public unsafe ECharMoveStateType CharMoveStateRef
		{
			get
			{
				return (ECharMoveStateType)(*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_CharMoveStateRef));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_CharMoveStateRef) = (byte)value;
			}
		}

		// Token: 0x17004F64 RID: 20324
		// (get) Token: 0x06014452 RID: 83026 RVA: 0x001DC8FB File Offset: 0x001DAAFB
		// (set) Token: 0x06014453 RID: 83027 RVA: 0x001DC90B File Offset: 0x001DAB0B
		public unsafe ECharPositionStateType CharPositionStateRef
		{
			get
			{
				return (ECharPositionStateType)(*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_CharPositionStateRef));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_CharPositionStateRef) = (byte)value;
			}
		}

		// Token: 0x17004F65 RID: 20325
		// (get) Token: 0x06014454 RID: 83028 RVA: 0x001DC91C File Offset: 0x001DAB1C
		// (set) Token: 0x06014455 RID: 83029 RVA: 0x001DC92C File Offset: 0x001DAB2C
		public unsafe ECharViewDirectionStateType CharCameraStateRef
		{
			get
			{
				return (ECharViewDirectionStateType)(*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_CharCameraStateRef));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_CharCameraStateRef) = (byte)value;
			}
		}

		// Token: 0x17004F66 RID: 20326
		// (get) Token: 0x06014456 RID: 83030 RVA: 0x001DC93D File Offset: 0x001DAB3D
		// (set) Token: 0x06014457 RID: 83031 RVA: 0x001DC94D File Offset: 0x001DAB4D
		public unsafe float BattleIdleTimeRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_BattleIdleTimeRef);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_BattleIdleTimeRef) = value;
			}
		}

		// Token: 0x17004F67 RID: 20327
		// (get) Token: 0x06014458 RID: 83032 RVA: 0x001DC95E File Offset: 0x001DAB5E
		// (set) Token: 0x06014459 RID: 83033 RVA: 0x001DC96E File Offset: 0x001DAB6E
		public unsafe float DegMovementSlopeRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_DegMovementSlopeRef);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_DegMovementSlopeRef) = value;
			}
		}

		// Token: 0x17004F68 RID: 20328
		// (get) Token: 0x0601445A RID: 83034 RVA: 0x001DC97F File Offset: 0x001DAB7F
		// (set) Token: 0x0601445B RID: 83035 RVA: 0x001DC993 File Offset: 0x001DAB93
		public unsafe FVector SightDirectRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_SightDirectRef);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_SightDirectRef) = value;
			}
		}

		// Token: 0x17004F69 RID: 20329
		// (get) Token: 0x0601445C RID: 83036 RVA: 0x001DC9A8 File Offset: 0x001DABA8
		// (set) Token: 0x0601445D RID: 83037 RVA: 0x001DC9B8 File Offset: 0x001DABB8
		public unsafe bool RagQuitStateRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_RagQuitStateRef) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_RagQuitStateRef) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004F6A RID: 20330
		// (get) Token: 0x0601445E RID: 83038 RVA: 0x001DC9C9 File Offset: 0x001DABC9
		// (set) Token: 0x0601445F RID: 83039 RVA: 0x001DC9D9 File Offset: 0x001DABD9
		public unsafe bool IsJumpRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_IsJumpRef) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_IsJumpRef) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004F6B RID: 20331
		// (get) Token: 0x06014460 RID: 83040 RVA: 0x001DC9EA File Offset: 0x001DABEA
		// (set) Token: 0x06014461 RID: 83041 RVA: 0x001DC9FE File Offset: 0x001DABFE
		public unsafe FVector AccelerationRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_AccelerationRef);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_AccelerationRef) = value;
			}
		}

		// Token: 0x17004F6C RID: 20332
		// (get) Token: 0x06014462 RID: 83042 RVA: 0x001DCA13 File Offset: 0x001DAC13
		// (set) Token: 0x06014463 RID: 83043 RVA: 0x001DCA23 File Offset: 0x001DAC23
		public unsafe bool IsMovingRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_IsMovingRef) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_IsMovingRef) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004F6D RID: 20333
		// (get) Token: 0x06014464 RID: 83044 RVA: 0x001DCA34 File Offset: 0x001DAC34
		// (set) Token: 0x06014465 RID: 83045 RVA: 0x001DCA44 File Offset: 0x001DAC44
		public unsafe float SpeedRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_SpeedRef);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_SpeedRef) = value;
			}
		}

		// Token: 0x17004F6E RID: 20334
		// (get) Token: 0x06014466 RID: 83046 RVA: 0x001DCA55 File Offset: 0x001DAC55
		// (set) Token: 0x06014467 RID: 83047 RVA: 0x001DCA69 File Offset: 0x001DAC69
		public unsafe FVector InputDirectRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_InputDirectRef);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_InputDirectRef) = value;
			}
		}

		// Token: 0x17004F6F RID: 20335
		// (get) Token: 0x06014468 RID: 83048 RVA: 0x001DCA7E File Offset: 0x001DAC7E
		// (set) Token: 0x06014469 RID: 83049 RVA: 0x001DCA92 File Offset: 0x001DAC92
		public unsafe FRotator InputRotatorRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_InputRotatorRef);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_InputRotatorRef) = value;
			}
		}

		// Token: 0x17004F70 RID: 20336
		// (get) Token: 0x0601446A RID: 83050 RVA: 0x001DCAA7 File Offset: 0x001DACA7
		// (set) Token: 0x0601446B RID: 83051 RVA: 0x001DCAB7 File Offset: 0x001DACB7
		public unsafe bool IsFallingIntoWaterRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_IsFallingIntoWaterRef) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_IsFallingIntoWaterRef) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004F71 RID: 20337
		// (get) Token: 0x0601446C RID: 83052 RVA: 0x001DCAC8 File Offset: 0x001DACC8
		// (set) Token: 0x0601446D RID: 83053 RVA: 0x001DCAD8 File Offset: 0x001DACD8
		public unsafe float GroundedTimeRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_GroundedTimeRef);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_GroundedTimeRef) = value;
			}
		}

		// Token: 0x17004F72 RID: 20338
		// (get) Token: 0x0601446E RID: 83054 RVA: 0x001DCAE9 File Offset: 0x001DACE9
		// (set) Token: 0x0601446F RID: 83055 RVA: 0x001DCAF9 File Offset: 0x001DACF9
		public unsafe bool HasMoveInputRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_HasMoveInputRef) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_HasMoveInputRef) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004F73 RID: 20339
		// (get) Token: 0x06014470 RID: 83056 RVA: 0x001DCB0C File Offset: 0x001DAD0C
		// (set) Token: 0x06014471 RID: 83057 RVA: 0x001DCB45 File Offset: 0x001DAD45
		public FClimbInfoStruct ClimbInfoRef
		{
			get
			{
				base.FastCheckIsValid();
				FClimbInfoStruct result;
				if ((result = this._ClimbInfoRef) == null)
				{
					result = (this._ClimbInfoRef = new FClimbInfoStruct(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_ClimbInfoRef, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FClimbInfoStruct.StaticStruct(), base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_ClimbInfoRef, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004F74 RID: 20340
		// (get) Token: 0x06014472 RID: 83058 RVA: 0x001DCB68 File Offset: 0x001DAD68
		// (set) Token: 0x06014473 RID: 83059 RVA: 0x001DCBA1 File Offset: 0x001DADA1
		public FClimbStateStruct ClimbStateRef
		{
			get
			{
				base.FastCheckIsValid();
				FClimbStateStruct result;
				if ((result = this._ClimbStateRef) == null)
				{
					result = (this._ClimbStateRef = new FClimbStateStruct(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_ClimbStateRef, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FClimbStateStruct.StaticStruct(), base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_ClimbStateRef, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004F75 RID: 20341
		// (get) Token: 0x06014474 RID: 83060 RVA: 0x001DCBC2 File Offset: 0x001DADC2
		// (set) Token: 0x06014475 RID: 83061 RVA: 0x001DCBD2 File Offset: 0x001DADD2
		public unsafe float ClimbOnWallAngleRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_ClimbOnWallAngleRef);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_ClimbOnWallAngleRef) = value;
			}
		}

		// Token: 0x17004F76 RID: 20342
		// (get) Token: 0x06014476 RID: 83062 RVA: 0x001DCBE3 File Offset: 0x001DADE3
		// (set) Token: 0x06014477 RID: 83063 RVA: 0x001DCBF3 File Offset: 0x001DADF3
		public unsafe float SprintSwimOffsetRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_SprintSwimOffsetRef);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_SprintSwimOffsetRef) = value;
			}
		}

		// Token: 0x17004F77 RID: 20343
		// (get) Token: 0x06014478 RID: 83064 RVA: 0x001DCC04 File Offset: 0x001DAE04
		// (set) Token: 0x06014479 RID: 83065 RVA: 0x001DCC14 File Offset: 0x001DAE14
		public unsafe float SprintSwimOffsetLerpSpeedRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_SprintSwimOffsetLerpSpeedRef);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_SprintSwimOffsetLerpSpeedRef) = value;
			}
		}

		// Token: 0x17004F78 RID: 20344
		// (get) Token: 0x0601447A RID: 83066 RVA: 0x001DCC25 File Offset: 0x001DAE25
		// (set) Token: 0x0601447B RID: 83067 RVA: 0x001DCC39 File Offset: 0x001DAE39
		public unsafe FVector SlideForwardRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_SlideForwardRef);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_SlideForwardRef) = value;
			}
		}

		// Token: 0x17004F79 RID: 20345
		// (get) Token: 0x0601447C RID: 83068 RVA: 0x001DCC4E File Offset: 0x001DAE4E
		// (set) Token: 0x0601447D RID: 83069 RVA: 0x001DCC5E File Offset: 0x001DAE5E
		public unsafe bool SlideSwitchThisFrameRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_SlideSwitchThisFrameRef) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_SlideSwitchThisFrameRef) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004F7A RID: 20346
		// (get) Token: 0x0601447E RID: 83070 RVA: 0x001DCC6F File Offset: 0x001DAE6F
		// (set) Token: 0x0601447F RID: 83071 RVA: 0x001DCC7F File Offset: 0x001DAE7F
		public unsafe bool SlideStandModeRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_SlideStandModeRef) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_SlideStandModeRef) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004F7B RID: 20347
		// (get) Token: 0x06014480 RID: 83072 RVA: 0x001DCC90 File Offset: 0x001DAE90
		// (set) Token: 0x06014481 RID: 83073 RVA: 0x001DCCA0 File Offset: 0x001DAEA0
		public unsafe float JumpUpRateRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_JumpUpRateRef);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_JumpUpRateRef) = value;
			}
		}

		// Token: 0x17004F7C RID: 20348
		// (get) Token: 0x06014482 RID: 83074 RVA: 0x001DCCB1 File Offset: 0x001DAEB1
		// (set) Token: 0x06014483 RID: 83075 RVA: 0x001DCCC1 File Offset: 0x001DAEC1
		public unsafe bool ForceExitStateStopRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_ForceExitStateStopRef) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_ForceExitStateStopRef) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004F7D RID: 20349
		// (get) Token: 0x06014484 RID: 83076 RVA: 0x001DCCD2 File Offset: 0x001DAED2
		// (set) Token: 0x06014485 RID: 83077 RVA: 0x001DCCE6 File Offset: 0x001DAEE6
		[Nullable(2)]
		public unsafe AActor SkillTarget
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + UAbpLogicParams.__PropertyOffset_SkillTarget);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAbpLogicParams.__PropertyOffset_SkillTarget, value);
			}
		}

		// Token: 0x17004F7E RID: 20350
		// (get) Token: 0x06014486 RID: 83078 RVA: 0x001DCCFB File Offset: 0x001DAEFB
		// (set) Token: 0x06014487 RID: 83079 RVA: 0x001DCD0F File Offset: 0x001DAF0F
		[Nullable(2)]
		public unsafe AActor HateTarget
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + UAbpLogicParams.__PropertyOffset_HateTarget);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAbpLogicParams.__PropertyOffset_HateTarget, value);
			}
		}

		// Token: 0x17004F7F RID: 20351
		// (get) Token: 0x06014488 RID: 83080 RVA: 0x001DCD24 File Offset: 0x001DAF24
		// (set) Token: 0x06014489 RID: 83081 RVA: 0x001DCD34 File Offset: 0x001DAF34
		public unsafe float LastActiveSkillTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_LastActiveSkillTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_LastActiveSkillTime) = value;
			}
		}

		// Token: 0x17004F80 RID: 20352
		// (get) Token: 0x0601448A RID: 83082 RVA: 0x001DCD45 File Offset: 0x001DAF45
		// (set) Token: 0x0601448B RID: 83083 RVA: 0x001DCD55 File Offset: 0x001DAF55
		public unsafe int SitDownDirect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_SitDownDirect);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_SitDownDirect) = value;
			}
		}

		// Token: 0x17004F81 RID: 20353
		// (get) Token: 0x0601448C RID: 83084 RVA: 0x001DCD66 File Offset: 0x001DAF66
		// (set) Token: 0x0601448D RID: 83085 RVA: 0x001DCD76 File Offset: 0x001DAF76
		public unsafe int StandUpDirect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_StandUpDirect);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_StandUpDirect) = value;
			}
		}

		// Token: 0x17004F82 RID: 20354
		// (get) Token: 0x0601448E RID: 83086 RVA: 0x001DCD87 File Offset: 0x001DAF87
		// (set) Token: 0x0601448F RID: 83087 RVA: 0x001DCD97 File Offset: 0x001DAF97
		public unsafe bool bSitDown
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_bSitDown) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_bSitDown) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004F83 RID: 20355
		// (get) Token: 0x06014490 RID: 83088 RVA: 0x001DCDA8 File Offset: 0x001DAFA8
		// (set) Token: 0x06014491 RID: 83089 RVA: 0x001DCDB8 File Offset: 0x001DAFB8
		public unsafe int SitDownType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_SitDownType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_SitDownType) = value;
			}
		}

		// Token: 0x17004F84 RID: 20356
		// (get) Token: 0x06014492 RID: 83090 RVA: 0x001DCDC9 File Offset: 0x001DAFC9
		// (set) Token: 0x06014493 RID: 83091 RVA: 0x001DCDD9 File Offset: 0x001DAFD9
		public unsafe bool IsDriver
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_IsDriver) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_IsDriver) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004F85 RID: 20357
		// (get) Token: 0x06014494 RID: 83092 RVA: 0x001DCDEA File Offset: 0x001DAFEA
		// (set) Token: 0x06014495 RID: 83093 RVA: 0x001DCDFA File Offset: 0x001DAFFA
		public unsafe bool IsOnVehicle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_IsOnVehicle) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_IsOnVehicle) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004F86 RID: 20358
		// (get) Token: 0x06014496 RID: 83094 RVA: 0x001DCE0B File Offset: 0x001DB00B
		// (set) Token: 0x06014497 RID: 83095 RVA: 0x001DCE1B File Offset: 0x001DB01B
		public unsafe bool IsOnVehicleWithOther
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_IsOnVehicleWithOther) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_IsOnVehicleWithOther) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004F87 RID: 20359
		// (get) Token: 0x06014498 RID: 83096 RVA: 0x001DCE2C File Offset: 0x001DB02C
		// (set) Token: 0x06014499 RID: 83097 RVA: 0x001DCE3C File Offset: 0x001DB03C
		public unsafe bool IsLeavingVehicle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_IsLeavingVehicle) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_IsLeavingVehicle) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004F88 RID: 20360
		// (get) Token: 0x0601449A RID: 83098 RVA: 0x001DCE4D File Offset: 0x001DB04D
		// (set) Token: 0x0601449B RID: 83099 RVA: 0x001DCE5D File Offset: 0x001DB05D
		public unsafe int VehicleType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_VehicleType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_VehicleType) = value;
			}
		}

		// Token: 0x17004F89 RID: 20361
		// (get) Token: 0x0601449C RID: 83100 RVA: 0x001DCE6E File Offset: 0x001DB06E
		// (set) Token: 0x0601449D RID: 83101 RVA: 0x001DCE7E File Offset: 0x001DB07E
		public unsafe bool IsVehicleImpact
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_IsVehicleImpact) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_IsVehicleImpact) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004F8A RID: 20362
		// (get) Token: 0x0601449E RID: 83102 RVA: 0x001DCE8F File Offset: 0x001DB08F
		// (set) Token: 0x0601449F RID: 83103 RVA: 0x001DCE9F File Offset: 0x001DB09F
		public unsafe float VehicleCollisionAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_VehicleCollisionAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_VehicleCollisionAngle) = value;
			}
		}

		// Token: 0x17004F8B RID: 20363
		// (get) Token: 0x060144A0 RID: 83104 RVA: 0x001DCEB0 File Offset: 0x001DB0B0
		// (set) Token: 0x060144A1 RID: 83105 RVA: 0x001DCEC0 File Offset: 0x001DB0C0
		public unsafe float VehicleCollisionStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_VehicleCollisionStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_VehicleCollisionStrength) = value;
			}
		}

		// Token: 0x17004F8C RID: 20364
		// (get) Token: 0x060144A2 RID: 83106 RVA: 0x001DCED1 File Offset: 0x001DB0D1
		// (set) Token: 0x060144A3 RID: 83107 RVA: 0x001DCEE1 File Offset: 0x001DB0E1
		public unsafe float YawInPassengerCoordinate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_YawInPassengerCoordinate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_YawInPassengerCoordinate) = value;
			}
		}

		// Token: 0x17004F8D RID: 20365
		// (get) Token: 0x060144A4 RID: 83108 RVA: 0x001DCEF2 File Offset: 0x001DB0F2
		// (set) Token: 0x060144A5 RID: 83109 RVA: 0x001DCF06 File Offset: 0x001DB106
		public unsafe FVector VehicleVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_VehicleVelocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_VehicleVelocity) = value;
			}
		}

		// Token: 0x17004F8E RID: 20366
		// (get) Token: 0x060144A6 RID: 83110 RVA: 0x001DCF1B File Offset: 0x001DB11B
		// (set) Token: 0x060144A7 RID: 83111 RVA: 0x001DCF2B File Offset: 0x001DB12B
		public unsafe bool bIsInPerformingPlot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_bIsInPerformingPlot) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_bIsInPerformingPlot) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004F8F RID: 20367
		// (get) Token: 0x060144A8 RID: 83112 RVA: 0x001DCF3C File Offset: 0x001DB13C
		// (set) Token: 0x060144A9 RID: 83113 RVA: 0x001DCF4C File Offset: 0x001DB14C
		public unsafe bool bIsInSequence
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_bIsInSequence) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_bIsInSequence) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004F90 RID: 20368
		// (get) Token: 0x060144AA RID: 83114 RVA: 0x001DCF5D File Offset: 0x001DB15D
		// (set) Token: 0x060144AB RID: 83115 RVA: 0x001DCF6D File Offset: 0x001DB16D
		public unsafe bool bIsInSplineMove
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_bIsInSplineMove) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_bIsInSplineMove) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004F91 RID: 20369
		// (get) Token: 0x060144AC RID: 83116 RVA: 0x001DCF7E File Offset: 0x001DB17E
		// (set) Token: 0x060144AD RID: 83117 RVA: 0x001DCF8E File Offset: 0x001DB18E
		public unsafe bool bIsInUiCamera
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_bIsInUiCamera) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_bIsInUiCamera) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004F92 RID: 20370
		// (get) Token: 0x060144AE RID: 83118 RVA: 0x001DCFA0 File Offset: 0x001DB1A0
		// (set) Token: 0x060144AF RID: 83119 RVA: 0x001DCFD9 File Offset: 0x001DB1D9
		public FIKTarget LeftHandIKTargetCS
		{
			get
			{
				base.FastCheckIsValid();
				FIKTarget result;
				if ((result = this._LeftHandIKTargetCS) == null)
				{
					result = (this._LeftHandIKTargetCS = new FIKTarget(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_LeftHandIKTargetCS, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FIKTarget.StaticStruct(), base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_LeftHandIKTargetCS, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004F93 RID: 20371
		// (get) Token: 0x060144B0 RID: 83120 RVA: 0x001DCFFC File Offset: 0x001DB1FC
		// (set) Token: 0x060144B1 RID: 83121 RVA: 0x001DD035 File Offset: 0x001DB235
		public FIKTarget RightHandIKTargetCS
		{
			get
			{
				base.FastCheckIsValid();
				FIKTarget result;
				if ((result = this._RightHandIKTargetCS) == null)
				{
					result = (this._RightHandIKTargetCS = new FIKTarget(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_RightHandIKTargetCS, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FIKTarget.StaticStruct(), base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_RightHandIKTargetCS, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004F94 RID: 20372
		// (get) Token: 0x060144B2 RID: 83122 RVA: 0x001DD056 File Offset: 0x001DB256
		// (set) Token: 0x060144B3 RID: 83123 RVA: 0x001DD066 File Offset: 0x001DB266
		public unsafe bool bDisableBlink
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_bDisableBlink) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_bDisableBlink) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004F95 RID: 20373
		// (get) Token: 0x060144B4 RID: 83124 RVA: 0x001DD077 File Offset: 0x001DB277
		// (set) Token: 0x060144B5 RID: 83125 RVA: 0x001DD087 File Offset: 0x001DB287
		public unsafe bool bIgnoreMontageBlinkCurve
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_bIgnoreMontageBlinkCurve) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_bIgnoreMontageBlinkCurve) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004F96 RID: 20374
		// (get) Token: 0x060144B6 RID: 83126 RVA: 0x001DD098 File Offset: 0x001DB298
		// (set) Token: 0x060144B7 RID: 83127 RVA: 0x001DD0A8 File Offset: 0x001DB2A8
		public unsafe bool bSwingState
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_bSwingState) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_bSwingState) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004F97 RID: 20375
		// (get) Token: 0x060144B8 RID: 83128 RVA: 0x001DD0B9 File Offset: 0x001DB2B9
		// (set) Token: 0x060144B9 RID: 83129 RVA: 0x001DD0C9 File Offset: 0x001DB2C9
		public unsafe ESwingStateType SwingStateType
		{
			get
			{
				return (ESwingStateType)(*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_SwingStateType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_SwingStateType) = (byte)value;
			}
		}

		// Token: 0x17004F98 RID: 20376
		// (get) Token: 0x060144BA RID: 83130 RVA: 0x001DD0DA File Offset: 0x001DB2DA
		// (set) Token: 0x060144BB RID: 83131 RVA: 0x001DD0EE File Offset: 0x001DB2EE
		public unsafe FVector FloatingLocalDirectionRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_FloatingLocalDirectionRef);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_FloatingLocalDirectionRef) = value;
			}
		}

		// Token: 0x17004F99 RID: 20377
		// (get) Token: 0x060144BC RID: 83132 RVA: 0x001DD103 File Offset: 0x001DB303
		// (set) Token: 0x060144BD RID: 83133 RVA: 0x001DD113 File Offset: 0x001DB313
		public unsafe float FloatingMoveMixRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_FloatingMoveMixRef);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_FloatingMoveMixRef) = value;
			}
		}

		// Token: 0x17004F9A RID: 20378
		// (get) Token: 0x060144BE RID: 83134 RVA: 0x001DD124 File Offset: 0x001DB324
		// (set) Token: 0x060144BF RID: 83135 RVA: 0x001DD138 File Offset: 0x001DB338
		public unsafe FVector HookTargetLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_HookTargetLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_HookTargetLocation) = value;
			}
		}

		// Token: 0x17004F9B RID: 20379
		// (get) Token: 0x060144C0 RID: 83136 RVA: 0x001DD14D File Offset: 0x001DB34D
		// (set) Token: 0x060144C1 RID: 83137 RVA: 0x001DD15D File Offset: 0x001DB35D
		public unsafe bool bIsRailSlideMove
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_bIsRailSlideMove) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_bIsRailSlideMove) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004F9C RID: 20380
		// (get) Token: 0x060144C2 RID: 83138 RVA: 0x001DD16E File Offset: 0x001DB36E
		// (set) Token: 0x060144C3 RID: 83139 RVA: 0x001DD17E File Offset: 0x001DB37E
		public unsafe ERailSlideAnimType RailSlideAnimType
		{
			get
			{
				return (ERailSlideAnimType)(*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_RailSlideAnimType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_RailSlideAnimType) = (byte)value;
			}
		}

		// Token: 0x17004F9D RID: 20381
		// (get) Token: 0x060144C4 RID: 83140 RVA: 0x001DD18F File Offset: 0x001DB38F
		// (set) Token: 0x060144C5 RID: 83141 RVA: 0x001DD19F File Offset: 0x001DB39F
		public unsafe bool bIsAirRailSlideMove
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_bIsAirRailSlideMove) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_bIsAirRailSlideMove) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004F9E RID: 20382
		// (get) Token: 0x060144C6 RID: 83142 RVA: 0x001DD1B0 File Offset: 0x001DB3B0
		// (set) Token: 0x060144C7 RID: 83143 RVA: 0x001DD1C0 File Offset: 0x001DB3C0
		public unsafe ERailSlideJumpType RailSlideJumpType
		{
			get
			{
				return (ERailSlideJumpType)(*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_RailSlideJumpType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_RailSlideJumpType) = (byte)value;
			}
		}

		// Token: 0x17004F9F RID: 20383
		// (get) Token: 0x060144C8 RID: 83144 RVA: 0x001DD1D1 File Offset: 0x001DB3D1
		// (set) Token: 0x060144C9 RID: 83145 RVA: 0x001DD1E1 File Offset: 0x001DB3E1
		public unsafe bool bUseLandAnimation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_bUseLandAnimation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_bUseLandAnimation) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004FA0 RID: 20384
		// (get) Token: 0x060144CA RID: 83146 RVA: 0x001DD1F2 File Offset: 0x001DB3F2
		// (set) Token: 0x060144CB RID: 83147 RVA: 0x001DD202 File Offset: 0x001DB402
		public unsafe bool bInAssistedWalking
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_bInAssistedWalking) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_bInAssistedWalking) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004FA1 RID: 20385
		// (get) Token: 0x060144CC RID: 83148 RVA: 0x001DD213 File Offset: 0x001DB413
		// (set) Token: 0x060144CD RID: 83149 RVA: 0x001DD223 File Offset: 0x001DB423
		public unsafe bool bHelpedAssistedWalk
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_bHelpedAssistedWalk) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_bHelpedAssistedWalk) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004FA2 RID: 20386
		// (get) Token: 0x060144CE RID: 83150 RVA: 0x001DD234 File Offset: 0x001DB434
		// (set) Token: 0x060144CF RID: 83151 RVA: 0x001DD244 File Offset: 0x001DB444
		public unsafe bool bSkipEnterAssistedWalkAnim
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_bSkipEnterAssistedWalkAnim) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_bSkipEnterAssistedWalkAnim) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004FA3 RID: 20387
		// (get) Token: 0x060144D0 RID: 83152 RVA: 0x001DD255 File Offset: 0x001DB455
		// (set) Token: 0x060144D1 RID: 83153 RVA: 0x001DD265 File Offset: 0x001DB465
		public unsafe float AssistedWalkAnimRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_AssistedWalkAnimRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_AssistedWalkAnimRate) = value;
			}
		}

		// Token: 0x17004FA4 RID: 20388
		// (get) Token: 0x060144D2 RID: 83154 RVA: 0x001DD276 File Offset: 0x001DB476
		// (set) Token: 0x060144D3 RID: 83155 RVA: 0x001DD286 File Offset: 0x001DB486
		public unsafe float SelfiePhotoArmAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_SelfiePhotoArmAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_SelfiePhotoArmAngle) = value;
			}
		}

		// Token: 0x060144D4 RID: 83156 RVA: 0x001DD297 File Offset: 0x001DB497
		static UAbpLogicParams()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAnim.AbpLogicParams");
		}

		// Token: 0x060144D5 RID: 83157 RVA: 0x001DD2A5 File Offset: 0x001DB4A5
		protected UAbpLogicParams(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B074 RID: 45172
		public new const string __ObjectPath = "/Script/KuroAnim.AbpLogicParams";

		// Token: 0x0400B075 RID: 45173
		private static IntPtr _ClassPtr;

		// Token: 0x0400B076 RID: 45174
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400B077 RID: 45175
		internal static int __PropertyOffset_AcceptedNewBeHitRef;

		// Token: 0x0400B078 RID: 45176
		internal static int __PropertyOffset_BeHitAnimRef;

		// Token: 0x0400B079 RID: 45177
		internal static int __PropertyOffset_EnterFkRef;

		// Token: 0x0400B07A RID: 45178
		internal static int __PropertyOffset_DoubleHitInAirRef;

		// Token: 0x0400B07B RID: 45179
		internal static int __PropertyOffset_BeHitDirectRef;

		// Token: 0x0400B07C RID: 45180
		internal static int __PropertyOffset_BeHitLocationRef;

		// Token: 0x0400B07D RID: 45181
		internal static int __PropertyOffset_BeHitSocketNameRef;

		// Token: 0x0400B07E RID: 45182
		internal static int __PropertyOffset_BeHitBoneRef;

		// Token: 0x0400B07F RID: 45183
		internal static int __PropertyOffset_HitInfo;

		// Token: 0x0400B080 RID: 45184
		[Nullable(2)]
		private FBoneFeedbackAnimHitInfo _HitInfo;

		// Token: 0x0400B081 RID: 45185
		internal static int __PropertyOffset_CharMoveStateRef;

		// Token: 0x0400B082 RID: 45186
		internal static int __PropertyOffset_CharPositionStateRef;

		// Token: 0x0400B083 RID: 45187
		internal static int __PropertyOffset_CharCameraStateRef;

		// Token: 0x0400B084 RID: 45188
		internal static int __PropertyOffset_BattleIdleTimeRef;

		// Token: 0x0400B085 RID: 45189
		internal static int __PropertyOffset_DegMovementSlopeRef;

		// Token: 0x0400B086 RID: 45190
		internal static int __PropertyOffset_SightDirectRef;

		// Token: 0x0400B087 RID: 45191
		internal static int __PropertyOffset_RagQuitStateRef;

		// Token: 0x0400B088 RID: 45192
		internal static int __PropertyOffset_IsJumpRef;

		// Token: 0x0400B089 RID: 45193
		internal static int __PropertyOffset_AccelerationRef;

		// Token: 0x0400B08A RID: 45194
		internal static int __PropertyOffset_IsMovingRef;

		// Token: 0x0400B08B RID: 45195
		internal static int __PropertyOffset_SpeedRef;

		// Token: 0x0400B08C RID: 45196
		internal static int __PropertyOffset_InputDirectRef;

		// Token: 0x0400B08D RID: 45197
		internal static int __PropertyOffset_InputRotatorRef;

		// Token: 0x0400B08E RID: 45198
		internal static int __PropertyOffset_IsFallingIntoWaterRef;

		// Token: 0x0400B08F RID: 45199
		internal static int __PropertyOffset_GroundedTimeRef;

		// Token: 0x0400B090 RID: 45200
		internal static int __PropertyOffset_HasMoveInputRef;

		// Token: 0x0400B091 RID: 45201
		internal static int __PropertyOffset_ClimbInfoRef;

		// Token: 0x0400B092 RID: 45202
		[Nullable(2)]
		private FClimbInfoStruct _ClimbInfoRef;

		// Token: 0x0400B093 RID: 45203
		internal static int __PropertyOffset_ClimbStateRef;

		// Token: 0x0400B094 RID: 45204
		[Nullable(2)]
		private FClimbStateStruct _ClimbStateRef;

		// Token: 0x0400B095 RID: 45205
		internal static int __PropertyOffset_ClimbOnWallAngleRef;

		// Token: 0x0400B096 RID: 45206
		internal static int __PropertyOffset_SprintSwimOffsetRef;

		// Token: 0x0400B097 RID: 45207
		internal static int __PropertyOffset_SprintSwimOffsetLerpSpeedRef;

		// Token: 0x0400B098 RID: 45208
		internal static int __PropertyOffset_SlideForwardRef;

		// Token: 0x0400B099 RID: 45209
		internal static int __PropertyOffset_SlideSwitchThisFrameRef;

		// Token: 0x0400B09A RID: 45210
		internal static int __PropertyOffset_SlideStandModeRef;

		// Token: 0x0400B09B RID: 45211
		internal static int __PropertyOffset_JumpUpRateRef;

		// Token: 0x0400B09C RID: 45212
		internal static int __PropertyOffset_ForceExitStateStopRef;

		// Token: 0x0400B09D RID: 45213
		internal static int __PropertyOffset_SkillTarget;

		// Token: 0x0400B09E RID: 45214
		internal static int __PropertyOffset_HateTarget;

		// Token: 0x0400B09F RID: 45215
		internal static int __PropertyOffset_LastActiveSkillTime;

		// Token: 0x0400B0A0 RID: 45216
		internal static int __PropertyOffset_SitDownDirect;

		// Token: 0x0400B0A1 RID: 45217
		internal static int __PropertyOffset_StandUpDirect;

		// Token: 0x0400B0A2 RID: 45218
		internal static int __PropertyOffset_bSitDown;

		// Token: 0x0400B0A3 RID: 45219
		internal static int __PropertyOffset_SitDownType;

		// Token: 0x0400B0A4 RID: 45220
		internal static int __PropertyOffset_IsDriver;

		// Token: 0x0400B0A5 RID: 45221
		internal static int __PropertyOffset_IsOnVehicle;

		// Token: 0x0400B0A6 RID: 45222
		internal static int __PropertyOffset_IsOnVehicleWithOther;

		// Token: 0x0400B0A7 RID: 45223
		internal static int __PropertyOffset_IsLeavingVehicle;

		// Token: 0x0400B0A8 RID: 45224
		internal static int __PropertyOffset_VehicleType;

		// Token: 0x0400B0A9 RID: 45225
		internal static int __PropertyOffset_IsVehicleImpact;

		// Token: 0x0400B0AA RID: 45226
		internal static int __PropertyOffset_VehicleCollisionAngle;

		// Token: 0x0400B0AB RID: 45227
		internal static int __PropertyOffset_VehicleCollisionStrength;

		// Token: 0x0400B0AC RID: 45228
		internal static int __PropertyOffset_YawInPassengerCoordinate;

		// Token: 0x0400B0AD RID: 45229
		internal static int __PropertyOffset_VehicleVelocity;

		// Token: 0x0400B0AE RID: 45230
		internal static int __PropertyOffset_bIsInPerformingPlot;

		// Token: 0x0400B0AF RID: 45231
		internal static int __PropertyOffset_bIsInSequence;

		// Token: 0x0400B0B0 RID: 45232
		internal static int __PropertyOffset_bIsInSplineMove;

		// Token: 0x0400B0B1 RID: 45233
		internal static int __PropertyOffset_bIsInUiCamera;

		// Token: 0x0400B0B2 RID: 45234
		internal static int __PropertyOffset_LeftHandIKTargetCS;

		// Token: 0x0400B0B3 RID: 45235
		[Nullable(2)]
		private FIKTarget _LeftHandIKTargetCS;

		// Token: 0x0400B0B4 RID: 45236
		internal static int __PropertyOffset_RightHandIKTargetCS;

		// Token: 0x0400B0B5 RID: 45237
		[Nullable(2)]
		private FIKTarget _RightHandIKTargetCS;

		// Token: 0x0400B0B6 RID: 45238
		internal static int __PropertyOffset_bDisableBlink;

		// Token: 0x0400B0B7 RID: 45239
		internal static int __PropertyOffset_bIgnoreMontageBlinkCurve;

		// Token: 0x0400B0B8 RID: 45240
		internal static int __PropertyOffset_bSwingState;

		// Token: 0x0400B0B9 RID: 45241
		internal static int __PropertyOffset_SwingStateType;

		// Token: 0x0400B0BA RID: 45242
		internal static int __PropertyOffset_FloatingLocalDirectionRef;

		// Token: 0x0400B0BB RID: 45243
		internal static int __PropertyOffset_FloatingMoveMixRef;

		// Token: 0x0400B0BC RID: 45244
		internal static int __PropertyOffset_HookTargetLocation;

		// Token: 0x0400B0BD RID: 45245
		internal static int __PropertyOffset_bIsRailSlideMove;

		// Token: 0x0400B0BE RID: 45246
		internal static int __PropertyOffset_RailSlideAnimType;

		// Token: 0x0400B0BF RID: 45247
		internal static int __PropertyOffset_bIsAirRailSlideMove;

		// Token: 0x0400B0C0 RID: 45248
		internal static int __PropertyOffset_RailSlideJumpType;

		// Token: 0x0400B0C1 RID: 45249
		internal static int __PropertyOffset_bUseLandAnimation;

		// Token: 0x0400B0C2 RID: 45250
		internal static int __PropertyOffset_bInAssistedWalking;

		// Token: 0x0400B0C3 RID: 45251
		internal static int __PropertyOffset_bHelpedAssistedWalk;

		// Token: 0x0400B0C4 RID: 45252
		internal static int __PropertyOffset_bSkipEnterAssistedWalkAnim;

		// Token: 0x0400B0C5 RID: 45253
		internal static int __PropertyOffset_AssistedWalkAnimRate;

		// Token: 0x0400B0C6 RID: 45254
		internal static int __PropertyOffset_SelfiePhotoArmAngle;
	}
}
