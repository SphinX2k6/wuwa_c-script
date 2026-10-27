using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001611 RID: 5649
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.AnimNode_KuroHumanIK")]
	[UnrealStructLayout(944, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 944)]
	public class FAnimNode_KuroHumanIK : FAnimNode_SkeletalControlBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601462A RID: 83498 RVA: 0x001DF710 File Offset: 0x001DD910
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_KuroHumanIK._ScriptStructPtr != 0) ? FAnimNode_KuroHumanIK._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.AnimNode_KuroHumanIK", ref FAnimNode_KuroHumanIK._ScriptStructPtr);
		}

		// Token: 0x17005013 RID: 20499
		// (get) Token: 0x0601462B RID: 83499 RVA: 0x001DF734 File Offset: 0x001DD934
		// (set) Token: 0x0601462C RID: 83500 RVA: 0x001DF777 File Offset: 0x001DD977
		public TArray<FKuroHumanIKPart> FootParts
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroHumanIKPart> result;
				if ((result = this._FootParts) == null)
				{
					result = (this._FootParts = new TArray<FKuroHumanIKPart>(base.NativePtr + (IntPtr)FAnimNode_KuroHumanIK.__PropertyOffset_FootParts, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.FootParts.CopyAssign(value);
			}
		}

		// Token: 0x17005014 RID: 20500
		// (get) Token: 0x0601462D RID: 83501 RVA: 0x001DF788 File Offset: 0x001DD988
		// (set) Token: 0x0601462E RID: 83502 RVA: 0x001DF7CB File Offset: 0x001DD9CB
		public TArray<FKuroHumanIKPart> HandParts
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroHumanIKPart> result;
				if ((result = this._HandParts) == null)
				{
					result = (this._HandParts = new TArray<FKuroHumanIKPart>(base.NativePtr + (IntPtr)FAnimNode_KuroHumanIK.__PropertyOffset_HandParts, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.HandParts.CopyAssign(value);
			}
		}

		// Token: 0x17005015 RID: 20501
		// (get) Token: 0x0601462F RID: 83503 RVA: 0x001DF7D9 File Offset: 0x001DD9D9
		// (set) Token: 0x06014630 RID: 83504 RVA: 0x001DF7E9 File Offset: 0x001DD9E9
		public unsafe KuroHumanIKMode Mode
		{
			get
			{
				return (KuroHumanIKMode)(*(base.NativePtr + (IntPtr)FAnimNode_KuroHumanIK.__PropertyOffset_Mode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KuroHumanIK.__PropertyOffset_Mode) = (byte)value;
			}
		}

		// Token: 0x17005016 RID: 20502
		// (get) Token: 0x06014631 RID: 83505 RVA: 0x001DF7FA File Offset: 0x001DD9FA
		// (set) Token: 0x06014632 RID: 83506 RVA: 0x001DF80A File Offset: 0x001DDA0A
		public unsafe float CapsuleRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_KuroHumanIK.__PropertyOffset_CapsuleRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KuroHumanIK.__PropertyOffset_CapsuleRadius) = value;
			}
		}

		// Token: 0x17005017 RID: 20503
		// (get) Token: 0x06014633 RID: 83507 RVA: 0x001DF81B File Offset: 0x001DDA1B
		// (set) Token: 0x06014634 RID: 83508 RVA: 0x001DF82B File Offset: 0x001DDA2B
		public unsafe bool bIsMoving
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_KuroHumanIK.__PropertyOffset_bIsMoving) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KuroHumanIK.__PropertyOffset_bIsMoving) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005018 RID: 20504
		// (get) Token: 0x06014635 RID: 83509 RVA: 0x001DF83C File Offset: 0x001DDA3C
		// (set) Token: 0x06014636 RID: 83510 RVA: 0x001DF84C File Offset: 0x001DDA4C
		public unsafe bool bIsComplexIk
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_KuroHumanIK.__PropertyOffset_bIsComplexIk) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KuroHumanIK.__PropertyOffset_bIsComplexIk) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005019 RID: 20505
		// (get) Token: 0x06014637 RID: 83511 RVA: 0x001DF85D File Offset: 0x001DDA5D
		// (set) Token: 0x06014638 RID: 83512 RVA: 0x001DF86D File Offset: 0x001DDA6D
		public unsafe float DeltaSeconds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_KuroHumanIK.__PropertyOffset_DeltaSeconds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KuroHumanIK.__PropertyOffset_DeltaSeconds) = value;
			}
		}

		// Token: 0x1700501A RID: 20506
		// (get) Token: 0x06014639 RID: 83513 RVA: 0x001DF87E File Offset: 0x001DDA7E
		// (set) Token: 0x0601463A RID: 83514 RVA: 0x001DF88E File Offset: 0x001DDA8E
		public unsafe bool bForbiddenCurvePosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_KuroHumanIK.__PropertyOffset_bForbiddenCurvePosition) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KuroHumanIK.__PropertyOffset_bForbiddenCurvePosition) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700501B RID: 20507
		// (get) Token: 0x0601463B RID: 83515 RVA: 0x001DF89F File Offset: 0x001DDA9F
		// (set) Token: 0x0601463C RID: 83516 RVA: 0x001DF8AF File Offset: 0x001DDAAF
		public unsafe bool bNoLerp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_KuroHumanIK.__PropertyOffset_bNoLerp) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KuroHumanIK.__PropertyOffset_bNoLerp) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700501C RID: 20508
		// (get) Token: 0x0601463D RID: 83517 RVA: 0x001DF8C0 File Offset: 0x001DDAC0
		// (set) Token: 0x0601463E RID: 83518 RVA: 0x001DF8D0 File Offset: 0x001DDAD0
		public unsafe float RootLerpSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_KuroHumanIK.__PropertyOffset_RootLerpSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KuroHumanIK.__PropertyOffset_RootLerpSpeed) = value;
			}
		}

		// Token: 0x1700501D RID: 20509
		// (get) Token: 0x0601463F RID: 83519 RVA: 0x001DF8E1 File Offset: 0x001DDAE1
		// (set) Token: 0x06014640 RID: 83520 RVA: 0x001DF8F1 File Offset: 0x001DDAF1
		public unsafe float FootLerpSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_KuroHumanIK.__PropertyOffset_FootLerpSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KuroHumanIK.__PropertyOffset_FootLerpSpeed) = value;
			}
		}

		// Token: 0x1700501E RID: 20510
		// (get) Token: 0x06014641 RID: 83521 RVA: 0x001DF902 File Offset: 0x001DDB02
		// (set) Token: 0x06014642 RID: 83522 RVA: 0x001DF912 File Offset: 0x001DDB12
		public unsafe float HandLerpSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_KuroHumanIK.__PropertyOffset_HandLerpSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KuroHumanIK.__PropertyOffset_HandLerpSpeed) = value;
			}
		}

		// Token: 0x1700501F RID: 20511
		// (get) Token: 0x06014643 RID: 83523 RVA: 0x001DF923 File Offset: 0x001DDB23
		// (set) Token: 0x06014644 RID: 83524 RVA: 0x001DF933 File Offset: 0x001DDB33
		public unsafe float HandTurnSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_KuroHumanIK.__PropertyOffset_HandTurnSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KuroHumanIK.__PropertyOffset_HandTurnSpeed) = value;
			}
		}

		// Token: 0x17005020 RID: 20512
		// (get) Token: 0x06014645 RID: 83525 RVA: 0x001DF944 File Offset: 0x001DDB44
		// (set) Token: 0x06014646 RID: 83526 RVA: 0x001DF954 File Offset: 0x001DDB54
		public unsafe float GroundDepth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_KuroHumanIK.__PropertyOffset_GroundDepth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KuroHumanIK.__PropertyOffset_GroundDepth) = value;
			}
		}

		// Token: 0x17005021 RID: 20513
		// (get) Token: 0x06014647 RID: 83527 RVA: 0x001DF965 File Offset: 0x001DDB65
		// (set) Token: 0x06014648 RID: 83528 RVA: 0x001DF975 File Offset: 0x001DDB75
		public unsafe float MaxIKFootDetectDepth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_KuroHumanIK.__PropertyOffset_MaxIKFootDetectDepth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KuroHumanIK.__PropertyOffset_MaxIKFootDetectDepth) = value;
			}
		}

		// Token: 0x17005022 RID: 20514
		// (get) Token: 0x06014649 RID: 83529 RVA: 0x001DF986 File Offset: 0x001DDB86
		// (set) Token: 0x0601464A RID: 83530 RVA: 0x001DF996 File Offset: 0x001DDB96
		public unsafe float MovingSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_KuroHumanIK.__PropertyOffset_MovingSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KuroHumanIK.__PropertyOffset_MovingSpeed) = value;
			}
		}

		// Token: 0x17005023 RID: 20515
		// (get) Token: 0x0601464B RID: 83531 RVA: 0x001DF9A7 File Offset: 0x001DDBA7
		// (set) Token: 0x0601464C RID: 83532 RVA: 0x001DF9BB File Offset: 0x001DDBBB
		public unsafe FVector MovingVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_KuroHumanIK.__PropertyOffset_MovingVelocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KuroHumanIK.__PropertyOffset_MovingVelocity) = value;
			}
		}

		// Token: 0x17005024 RID: 20516
		// (get) Token: 0x0601464D RID: 83533 RVA: 0x001DF9D0 File Offset: 0x001DDBD0
		// (set) Token: 0x0601464E RID: 83534 RVA: 0x001DF9E0 File Offset: 0x001DDBE0
		public unsafe float WalkRunMix
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_KuroHumanIK.__PropertyOffset_WalkRunMix);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KuroHumanIK.__PropertyOffset_WalkRunMix) = value;
			}
		}

		// Token: 0x17005025 RID: 20517
		// (get) Token: 0x0601464F RID: 83535 RVA: 0x001DF9F1 File Offset: 0x001DDBF1
		// (set) Token: 0x06014650 RID: 83536 RVA: 0x001DFA01 File Offset: 0x001DDC01
		public unsafe float DegMovementSlop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_KuroHumanIK.__PropertyOffset_DegMovementSlop);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KuroHumanIK.__PropertyOffset_DegMovementSlop) = value;
			}
		}

		// Token: 0x17005026 RID: 20518
		// (get) Token: 0x06014651 RID: 83537 RVA: 0x001DFA12 File Offset: 0x001DDC12
		// (set) Token: 0x06014652 RID: 83538 RVA: 0x001DFA22 File Offset: 0x001DDC22
		public unsafe float ClimbRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_KuroHumanIK.__PropertyOffset_ClimbRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KuroHumanIK.__PropertyOffset_ClimbRadius) = value;
			}
		}

		// Token: 0x17005027 RID: 20519
		// (get) Token: 0x06014653 RID: 83539 RVA: 0x001DFA33 File Offset: 0x001DDC33
		// (set) Token: 0x06014654 RID: 83540 RVA: 0x001DFA47 File Offset: 0x001DDC47
		public unsafe FVector SlideForward
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_KuroHumanIK.__PropertyOffset_SlideForward);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KuroHumanIK.__PropertyOffset_SlideForward) = value;
			}
		}

		// Token: 0x17005028 RID: 20520
		// (get) Token: 0x06014655 RID: 83541 RVA: 0x001DFA5C File Offset: 0x001DDC5C
		// (set) Token: 0x06014656 RID: 83542 RVA: 0x001DFA6C File Offset: 0x001DDC6C
		public unsafe float SlideRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_KuroHumanIK.__PropertyOffset_SlideRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KuroHumanIK.__PropertyOffset_SlideRadius) = value;
			}
		}

		// Token: 0x17005029 RID: 20521
		// (get) Token: 0x06014657 RID: 83543 RVA: 0x001DFA7D File Offset: 0x001DDC7D
		// (set) Token: 0x06014658 RID: 83544 RVA: 0x001DFA8D File Offset: 0x001DDC8D
		public unsafe bool bStandSlide
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_KuroHumanIK.__PropertyOffset_bStandSlide) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KuroHumanIK.__PropertyOffset_bStandSlide) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700502A RID: 20522
		// (get) Token: 0x06014659 RID: 83545 RVA: 0x001DFA9E File Offset: 0x001DDC9E
		// (set) Token: 0x0601465A RID: 83546 RVA: 0x001DFAAE File Offset: 0x001DDCAE
		public unsafe float PredictStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_KuroHumanIK.__PropertyOffset_PredictStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KuroHumanIK.__PropertyOffset_PredictStrength) = value;
			}
		}

		// Token: 0x1700502B RID: 20523
		// (get) Token: 0x0601465B RID: 83547 RVA: 0x001DFABF File Offset: 0x001DDCBF
		// (set) Token: 0x0601465C RID: 83548 RVA: 0x001DFACF File Offset: 0x001DDCCF
		public unsafe bool bUseComplexPrediction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_KuroHumanIK.__PropertyOffset_bUseComplexPrediction) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KuroHumanIK.__PropertyOffset_bUseComplexPrediction) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700502C RID: 20524
		// (get) Token: 0x0601465D RID: 83549 RVA: 0x001DFAE0 File Offset: 0x001DDCE0
		// (set) Token: 0x0601465E RID: 83550 RVA: 0x001DFAF0 File Offset: 0x001DDCF0
		public unsafe int PredictIterateMaxCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_KuroHumanIK.__PropertyOffset_PredictIterateMaxCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KuroHumanIK.__PropertyOffset_PredictIterateMaxCount) = value;
			}
		}

		// Token: 0x1700502D RID: 20525
		// (get) Token: 0x0601465F RID: 83551 RVA: 0x001DFB01 File Offset: 0x001DDD01
		// (set) Token: 0x06014660 RID: 83552 RVA: 0x001DFB11 File Offset: 0x001DDD11
		public unsafe float PredictInvalidDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_KuroHumanIK.__PropertyOffset_PredictInvalidDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KuroHumanIK.__PropertyOffset_PredictInvalidDistance) = value;
			}
		}

		// Token: 0x1700502E RID: 20526
		// (get) Token: 0x06014661 RID: 83553 RVA: 0x001DFB22 File Offset: 0x001DDD22
		// (set) Token: 0x06014662 RID: 83554 RVA: 0x001DFB32 File Offset: 0x001DDD32
		public unsafe float PredictDisableAccel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_KuroHumanIK.__PropertyOffset_PredictDisableAccel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KuroHumanIK.__PropertyOffset_PredictDisableAccel) = value;
			}
		}

		// Token: 0x1700502F RID: 20527
		// (get) Token: 0x06014663 RID: 83555 RVA: 0x001DFB43 File Offset: 0x001DDD43
		// (set) Token: 0x06014664 RID: 83556 RVA: 0x001DFB53 File Offset: 0x001DDD53
		public unsafe float StepLockLandingTimeRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_KuroHumanIK.__PropertyOffset_StepLockLandingTimeRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KuroHumanIK.__PropertyOffset_StepLockLandingTimeRatio) = value;
			}
		}

		// Token: 0x17005030 RID: 20528
		// (get) Token: 0x06014665 RID: 83557 RVA: 0x001DFB64 File Offset: 0x001DDD64
		// (set) Token: 0x06014666 RID: 83558 RVA: 0x001DFB74 File Offset: 0x001DDD74
		public unsafe float PredictIterateOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_KuroHumanIK.__PropertyOffset_PredictIterateOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KuroHumanIK.__PropertyOffset_PredictIterateOffset) = value;
			}
		}

		// Token: 0x17005031 RID: 20529
		// (get) Token: 0x06014667 RID: 83559 RVA: 0x001DFB85 File Offset: 0x001DDD85
		// (set) Token: 0x06014668 RID: 83560 RVA: 0x001DFB99 File Offset: 0x001DDD99
		public unsafe FVector DefaultTipOffsetAtLand
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_KuroHumanIK.__PropertyOffset_DefaultTipOffsetAtLand);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KuroHumanIK.__PropertyOffset_DefaultTipOffsetAtLand) = value;
			}
		}

		// Token: 0x17005032 RID: 20530
		// (get) Token: 0x06014669 RID: 83561 RVA: 0x001DFBAE File Offset: 0x001DDDAE
		// (set) Token: 0x0601466A RID: 83562 RVA: 0x001DFBC7 File Offset: 0x001DDDC7
		public unsafe bool TerrainSurveyFootPredictionEnable
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FAnimNode_KuroHumanIK.__PropertyOffset_TerrainSurveyFootPredictionEnable) & FAnimNode_KuroHumanIK.__PropertyMask_TerrainSurveyFootPredictionEnable) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FAnimNode_KuroHumanIK.__PropertyOffset_TerrainSurveyFootPredictionEnable) = ((*(base.NativePtr + (IntPtr)FAnimNode_KuroHumanIK.__PropertyOffset_TerrainSurveyFootPredictionEnable) & ~FAnimNode_KuroHumanIK.__PropertyMask_TerrainSurveyFootPredictionEnable) | (value ? FAnimNode_KuroHumanIK.__PropertyMask_TerrainSurveyFootPredictionEnable : 0));
			}
		}

		// Token: 0x17005033 RID: 20531
		// (get) Token: 0x0601466B RID: 83563 RVA: 0x001DFBF8 File Offset: 0x001DDDF8
		// (set) Token: 0x0601466C RID: 83564 RVA: 0x001DFC3B File Offset: 0x001DDE3B
		public FIKTarget LeftHandTargetCS
		{
			get
			{
				base.FastCheckIsValid();
				FIKTarget result;
				if ((result = this._LeftHandTargetCS) == null)
				{
					result = (this._LeftHandTargetCS = new FIKTarget(base.NativePtr + (IntPtr)FAnimNode_KuroHumanIK.__PropertyOffset_LeftHandTargetCS, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FIKTarget.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_KuroHumanIK.__PropertyOffset_LeftHandTargetCS, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005034 RID: 20532
		// (get) Token: 0x0601466D RID: 83565 RVA: 0x001DFC5C File Offset: 0x001DDE5C
		// (set) Token: 0x0601466E RID: 83566 RVA: 0x001DFC9F File Offset: 0x001DDE9F
		public FIKTarget RightHandTargetCS
		{
			get
			{
				base.FastCheckIsValid();
				FIKTarget result;
				if ((result = this._RightHandTargetCS) == null)
				{
					result = (this._RightHandTargetCS = new FIKTarget(base.NativePtr + (IntPtr)FAnimNode_KuroHumanIK.__PropertyOffset_RightHandTargetCS, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FIKTarget.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_KuroHumanIK.__PropertyOffset_RightHandTargetCS, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005035 RID: 20533
		// (get) Token: 0x0601466F RID: 83567 RVA: 0x001DFCC0 File Offset: 0x001DDEC0
		// (set) Token: 0x06014670 RID: 83568 RVA: 0x001DFCD0 File Offset: 0x001DDED0
		public unsafe ECharMoveStateType CurMoveState
		{
			get
			{
				return (ECharMoveStateType)(*(base.NativePtr + (IntPtr)FAnimNode_KuroHumanIK.__PropertyOffset_CurMoveState));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KuroHumanIK.__PropertyOffset_CurMoveState) = (byte)value;
			}
		}

		// Token: 0x17005036 RID: 20534
		// (get) Token: 0x06014671 RID: 83569 RVA: 0x001DFCE4 File Offset: 0x001DDEE4
		// (set) Token: 0x06014672 RID: 83570 RVA: 0x001DFD27 File Offset: 0x001DDF27
		public TMap<ECharMoveStateType, int> FootPredictionTimeOffset
		{
			get
			{
				base.FastCheckIsValid();
				TMap<ECharMoveStateType, int> result;
				if ((result = this._FootPredictionTimeOffset) == null)
				{
					result = (this._FootPredictionTimeOffset = new TMap<ECharMoveStateType, int>(base.NativePtr + (IntPtr)FAnimNode_KuroHumanIK.__PropertyOffset_FootPredictionTimeOffset, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.FootPredictionTimeOffset.CopyAssign(value);
			}
		}

		// Token: 0x06014673 RID: 83571 RVA: 0x001DFD35 File Offset: 0x001DDF35
		public FAnimNode_KuroHumanIK()
		{
		}

		// Token: 0x06014674 RID: 83572 RVA: 0x001DFD40 File Offset: 0x001DDF40
		public FAnimNode_KuroHumanIK(TArray<FKuroHumanIKPart> FootParts, TArray<FKuroHumanIKPart> HandParts, KuroHumanIKMode Mode, float CapsuleRadius, bool bIsMoving, bool bIsComplexIk, float DeltaSeconds, bool bForbiddenCurvePosition, bool bNoLerp, float RootLerpSpeed, float FootLerpSpeed, float HandLerpSpeed, float HandTurnSpeed, float GroundDepth, float MaxIKFootDetectDepth, float MovingSpeed, FVector MovingVelocity, float WalkRunMix, float DegMovementSlop, float ClimbRadius, FVector SlideForward, float SlideRadius, bool bStandSlide, float PredictStrength, bool bUseComplexPrediction, int PredictIterateMaxCount, float PredictInvalidDistance, float PredictDisableAccel, float StepLockLandingTimeRatio, float PredictIterateOffset, FVector DefaultTipOffsetAtLand, bool TerrainSurveyFootPredictionEnable, FIKTarget LeftHandTargetCS, FIKTarget RightHandTargetCS, ECharMoveStateType CurMoveState, TMap<ECharMoveStateType, int> FootPredictionTimeOffset, FComponentSpacePoseLink ComponentPose, int LODThreshold, int KuroLODMask, float ActualAlpha, EAnimAlphaInputType AlphaInputType, bool bAlphaBoolEnabled, bool bParallelEvalEnabled, bool bEnableOnMobile, float Alpha, FInputScaleBias AlphaScaleBias, FInputAlphaBoolBlend AlphaBoolBlend, FName AlphaCurveName, FInputScaleBiasClamp AlphaScaleBiasClamp)
		{
			this.FootParts = FootParts;
			this.HandParts = HandParts;
			this.Mode = Mode;
			this.CapsuleRadius = CapsuleRadius;
			this.bIsMoving = bIsMoving;
			this.bIsComplexIk = bIsComplexIk;
			this.DeltaSeconds = DeltaSeconds;
			this.bForbiddenCurvePosition = bForbiddenCurvePosition;
			this.bNoLerp = bNoLerp;
			this.RootLerpSpeed = RootLerpSpeed;
			this.FootLerpSpeed = FootLerpSpeed;
			this.HandLerpSpeed = HandLerpSpeed;
			this.HandTurnSpeed = HandTurnSpeed;
			this.GroundDepth = GroundDepth;
			this.MaxIKFootDetectDepth = MaxIKFootDetectDepth;
			this.MovingSpeed = MovingSpeed;
			this.MovingVelocity = MovingVelocity;
			this.WalkRunMix = WalkRunMix;
			this.DegMovementSlop = DegMovementSlop;
			this.ClimbRadius = ClimbRadius;
			this.SlideForward = SlideForward;
			this.SlideRadius = SlideRadius;
			this.bStandSlide = bStandSlide;
			this.PredictStrength = PredictStrength;
			this.bUseComplexPrediction = bUseComplexPrediction;
			this.PredictIterateMaxCount = PredictIterateMaxCount;
			this.PredictInvalidDistance = PredictInvalidDistance;
			this.PredictDisableAccel = PredictDisableAccel;
			this.StepLockLandingTimeRatio = StepLockLandingTimeRatio;
			this.PredictIterateOffset = PredictIterateOffset;
			this.DefaultTipOffsetAtLand = DefaultTipOffsetAtLand;
			this.TerrainSurveyFootPredictionEnable = TerrainSurveyFootPredictionEnable;
			this.LeftHandTargetCS = LeftHandTargetCS;
			this.RightHandTargetCS = RightHandTargetCS;
			this.CurMoveState = CurMoveState;
			this.FootPredictionTimeOffset = FootPredictionTimeOffset;
			base.ComponentPose = ComponentPose;
			base.LODThreshold = LODThreshold;
			base.KuroLODMask = KuroLODMask;
			base.ActualAlpha = ActualAlpha;
			base.AlphaInputType = AlphaInputType;
			base.bAlphaBoolEnabled = bAlphaBoolEnabled;
			base.bParallelEvalEnabled = bParallelEvalEnabled;
			base.bEnableOnMobile = bEnableOnMobile;
			base.Alpha = Alpha;
			base.AlphaScaleBias = AlphaScaleBias;
			base.AlphaBoolBlend = AlphaBoolBlend;
			base.AlphaCurveName = AlphaCurveName;
			base.AlphaScaleBiasClamp = AlphaScaleBiasClamp;
		}

		// Token: 0x06014675 RID: 83573 RVA: 0x001DFED8 File Offset: 0x001DE0D8
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_KuroHumanIK.StaticStruct();
		}

		// Token: 0x06014676 RID: 83574 RVA: 0x001DFEE4 File Offset: 0x001DE0E4
		[NullableContext(2)]
		public FAnimNode_KuroHumanIK(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06014677 RID: 83575 RVA: 0x001DFEEE File Offset: 0x001DE0EE
		public FAnimNode_KuroHumanIK(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06014678 RID: 83576 RVA: 0x001DFEF9 File Offset: 0x001DE0F9
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_KuroHumanIK(Pointer, false, true);
		}

		// Token: 0x06014679 RID: 83577 RVA: 0x001DFF03 File Offset: 0x001DE103
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_KuroHumanIK(Pointer, MemoryOwner);
		}

		// Token: 0x0400B17A RID: 45434
		public new const string __ObjectPath = "/Script/KuroAnim.AnimNode_KuroHumanIK";

		// Token: 0x0400B17B RID: 45435
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B17C RID: 45436
		internal static int __PropertyOffset_FootParts;

		// Token: 0x0400B17D RID: 45437
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroHumanIKPart> _FootParts;

		// Token: 0x0400B17E RID: 45438
		internal static int __PropertyOffset_HandParts;

		// Token: 0x0400B17F RID: 45439
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroHumanIKPart> _HandParts;

		// Token: 0x0400B180 RID: 45440
		internal static int __PropertyOffset_Mode;

		// Token: 0x0400B181 RID: 45441
		internal static int __PropertyOffset_CapsuleRadius;

		// Token: 0x0400B182 RID: 45442
		internal static int __PropertyOffset_bIsMoving;

		// Token: 0x0400B183 RID: 45443
		internal static int __PropertyOffset_bIsComplexIk;

		// Token: 0x0400B184 RID: 45444
		internal static int __PropertyOffset_DeltaSeconds;

		// Token: 0x0400B185 RID: 45445
		internal static int __PropertyOffset_bForbiddenCurvePosition;

		// Token: 0x0400B186 RID: 45446
		internal static int __PropertyOffset_bNoLerp;

		// Token: 0x0400B187 RID: 45447
		internal static int __PropertyOffset_RootLerpSpeed;

		// Token: 0x0400B188 RID: 45448
		internal static int __PropertyOffset_FootLerpSpeed;

		// Token: 0x0400B189 RID: 45449
		internal static int __PropertyOffset_HandLerpSpeed;

		// Token: 0x0400B18A RID: 45450
		internal static int __PropertyOffset_HandTurnSpeed;

		// Token: 0x0400B18B RID: 45451
		internal static int __PropertyOffset_GroundDepth;

		// Token: 0x0400B18C RID: 45452
		internal static int __PropertyOffset_MaxIKFootDetectDepth;

		// Token: 0x0400B18D RID: 45453
		internal static int __PropertyOffset_MovingSpeed;

		// Token: 0x0400B18E RID: 45454
		internal static int __PropertyOffset_MovingVelocity;

		// Token: 0x0400B18F RID: 45455
		internal static int __PropertyOffset_WalkRunMix;

		// Token: 0x0400B190 RID: 45456
		internal static int __PropertyOffset_DegMovementSlop;

		// Token: 0x0400B191 RID: 45457
		internal static int __PropertyOffset_ClimbRadius;

		// Token: 0x0400B192 RID: 45458
		internal static int __PropertyOffset_SlideForward;

		// Token: 0x0400B193 RID: 45459
		internal static int __PropertyOffset_SlideRadius;

		// Token: 0x0400B194 RID: 45460
		internal static int __PropertyOffset_bStandSlide;

		// Token: 0x0400B195 RID: 45461
		internal static int __PropertyOffset_PredictStrength;

		// Token: 0x0400B196 RID: 45462
		internal static int __PropertyOffset_bUseComplexPrediction;

		// Token: 0x0400B197 RID: 45463
		internal static int __PropertyOffset_PredictIterateMaxCount;

		// Token: 0x0400B198 RID: 45464
		internal static int __PropertyOffset_PredictInvalidDistance;

		// Token: 0x0400B199 RID: 45465
		internal static int __PropertyOffset_PredictDisableAccel;

		// Token: 0x0400B19A RID: 45466
		internal static int __PropertyOffset_StepLockLandingTimeRatio;

		// Token: 0x0400B19B RID: 45467
		internal static int __PropertyOffset_PredictIterateOffset;

		// Token: 0x0400B19C RID: 45468
		internal static int __PropertyOffset_DefaultTipOffsetAtLand;

		// Token: 0x0400B19D RID: 45469
		internal static int __PropertyOffset_TerrainSurveyFootPredictionEnable;

		// Token: 0x0400B19E RID: 45470
		internal static byte __PropertyMask_TerrainSurveyFootPredictionEnable;

		// Token: 0x0400B19F RID: 45471
		internal static int __PropertyOffset_LeftHandTargetCS;

		// Token: 0x0400B1A0 RID: 45472
		[Nullable(2)]
		private FIKTarget _LeftHandTargetCS;

		// Token: 0x0400B1A1 RID: 45473
		internal static int __PropertyOffset_RightHandTargetCS;

		// Token: 0x0400B1A2 RID: 45474
		[Nullable(2)]
		private FIKTarget _RightHandTargetCS;

		// Token: 0x0400B1A3 RID: 45475
		internal static int __PropertyOffset_CurMoveState;

		// Token: 0x0400B1A4 RID: 45476
		internal static int __PropertyOffset_FootPredictionTimeOffset;

		// Token: 0x0400B1A5 RID: 45477
		[Nullable(2)]
		private TMap<ECharMoveStateType, int> _FootPredictionTimeOffset;
	}
}
