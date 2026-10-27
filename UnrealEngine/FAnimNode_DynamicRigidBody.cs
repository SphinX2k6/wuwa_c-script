using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001607 RID: 5639
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.AnimNode_DynamicRigidBody")]
	[UnrealStructLayout(1664, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 1664)]
	public class FAnimNode_DynamicRigidBody : FAnimNode_SkeletalControlBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601453E RID: 83262 RVA: 0x001DDD62 File Offset: 0x001DBF62
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_DynamicRigidBody._ScriptStructPtr != 0) ? FAnimNode_DynamicRigidBody._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.AnimNode_DynamicRigidBody", ref FAnimNode_DynamicRigidBody._ScriptStructPtr);
		}

		// Token: 0x17004FC5 RID: 20421
		// (get) Token: 0x0601453F RID: 83263 RVA: 0x001DDD86 File Offset: 0x001DBF86
		// (set) Token: 0x06014540 RID: 83264 RVA: 0x001DDD9A File Offset: 0x001DBF9A
		[Nullable(2)]
		public unsafe UPhysicsAsset RagdollPhysicsAsset
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPhysicsAsset>(base.NativePtr / (IntPtr)sizeof(void*) + FAnimNode_DynamicRigidBody.__PropertyOffset_RagdollPhysicsAsset);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FAnimNode_DynamicRigidBody.__PropertyOffset_RagdollPhysicsAsset, value);
			}
		}

		// Token: 0x17004FC6 RID: 20422
		// (get) Token: 0x06014541 RID: 83265 RVA: 0x001DDDAF File Offset: 0x001DBFAF
		// (set) Token: 0x06014542 RID: 83266 RVA: 0x001DDDBF File Offset: 0x001DBFBF
		public unsafe EDynamicRBModeType SimMode
		{
			get
			{
				return (EDynamicRBModeType)(*(base.NativePtr + (IntPtr)FAnimNode_DynamicRigidBody.__PropertyOffset_SimMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_DynamicRigidBody.__PropertyOffset_SimMode) = (byte)value;
			}
		}

		// Token: 0x17004FC7 RID: 20423
		// (get) Token: 0x06014543 RID: 83267 RVA: 0x001DDDD0 File Offset: 0x001DBFD0
		// (set) Token: 0x06014544 RID: 83268 RVA: 0x001DDDE9 File Offset: 0x001DBFE9
		public unsafe bool bOverrideWorldGravity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FAnimNode_DynamicRigidBody.__PropertyOffset_bOverrideWorldGravity) & FAnimNode_DynamicRigidBody.__PropertyMask_bOverrideWorldGravity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FAnimNode_DynamicRigidBody.__PropertyOffset_bOverrideWorldGravity) = ((*(base.NativePtr + (IntPtr)FAnimNode_DynamicRigidBody.__PropertyOffset_bOverrideWorldGravity) & ~FAnimNode_DynamicRigidBody.__PropertyMask_bOverrideWorldGravity) | (value ? FAnimNode_DynamicRigidBody.__PropertyMask_bOverrideWorldGravity : 0));
			}
		}

		// Token: 0x17004FC8 RID: 20424
		// (get) Token: 0x06014545 RID: 83269 RVA: 0x001DDE19 File Offset: 0x001DC019
		// (set) Token: 0x06014546 RID: 83270 RVA: 0x001DDE2D File Offset: 0x001DC02D
		public unsafe FVector OverrideWorldGravity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_DynamicRigidBody.__PropertyOffset_OverrideWorldGravity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_DynamicRigidBody.__PropertyOffset_OverrideWorldGravity) = value;
			}
		}

		// Token: 0x17004FC9 RID: 20425
		// (get) Token: 0x06014547 RID: 83271 RVA: 0x001DDE42 File Offset: 0x001DC042
		// (set) Token: 0x06014548 RID: 83272 RVA: 0x001DDE52 File Offset: 0x001DC052
		public unsafe EDynamicRBSimulationSpace SimulationSpace
		{
			get
			{
				return (EDynamicRBSimulationSpace)(*(base.NativePtr + (IntPtr)FAnimNode_DynamicRigidBody.__PropertyOffset_SimulationSpace));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_DynamicRigidBody.__PropertyOffset_SimulationSpace) = (byte)value;
			}
		}

		// Token: 0x17004FCA RID: 20426
		// (get) Token: 0x06014549 RID: 83273 RVA: 0x001DDE64 File Offset: 0x001DC064
		// (set) Token: 0x0601454A RID: 83274 RVA: 0x001DDEA7 File Offset: 0x001DC0A7
		public FBoneReference BaseBoneRef
		{
			get
			{
				base.FastCheckIsValid();
				FBoneReference result;
				if ((result = this._BaseBoneRef) == null)
				{
					result = (this._BaseBoneRef = new FBoneReference(base.NativePtr + (IntPtr)FAnimNode_DynamicRigidBody.__PropertyOffset_BaseBoneRef, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneReference.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_DynamicRigidBody.__PropertyOffset_BaseBoneRef, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004FCB RID: 20427
		// (get) Token: 0x0601454B RID: 83275 RVA: 0x001DDEC8 File Offset: 0x001DC0C8
		// (set) Token: 0x0601454C RID: 83276 RVA: 0x001DDED8 File Offset: 0x001DC0D8
		public unsafe bool bForceDisableCollisionBetweenConstraintBodies
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_DynamicRigidBody.__PropertyOffset_bForceDisableCollisionBetweenConstraintBodies) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_DynamicRigidBody.__PropertyOffset_bForceDisableCollisionBetweenConstraintBodies) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004FCC RID: 20428
		// (get) Token: 0x0601454D RID: 83277 RVA: 0x001DDEE9 File Offset: 0x001DC0E9
		// (set) Token: 0x0601454E RID: 83278 RVA: 0x001DDF02 File Offset: 0x001DC102
		public unsafe bool bClampLinearTranslationLimitToRefPose
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FAnimNode_DynamicRigidBody.__PropertyOffset_bClampLinearTranslationLimitToRefPose) & FAnimNode_DynamicRigidBody.__PropertyMask_bClampLinearTranslationLimitToRefPose) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FAnimNode_DynamicRigidBody.__PropertyOffset_bClampLinearTranslationLimitToRefPose) = ((*(base.NativePtr + (IntPtr)FAnimNode_DynamicRigidBody.__PropertyOffset_bClampLinearTranslationLimitToRefPose) & ~FAnimNode_DynamicRigidBody.__PropertyMask_bClampLinearTranslationLimitToRefPose) | (value ? FAnimNode_DynamicRigidBody.__PropertyMask_bClampLinearTranslationLimitToRefPose : 0));
			}
		}

		// Token: 0x17004FCD RID: 20429
		// (get) Token: 0x0601454F RID: 83279 RVA: 0x001DDF32 File Offset: 0x001DC132
		// (set) Token: 0x06014550 RID: 83280 RVA: 0x001DDF42 File Offset: 0x001DC142
		public unsafe float ClampLinearTranslationLimitToRefPose_Rate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_DynamicRigidBody.__PropertyOffset_ClampLinearTranslationLimitToRefPose_Rate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_DynamicRigidBody.__PropertyOffset_ClampLinearTranslationLimitToRefPose_Rate) = value;
			}
		}

		// Token: 0x17004FCE RID: 20430
		// (get) Token: 0x06014551 RID: 83281 RVA: 0x001DDF53 File Offset: 0x001DC153
		// (set) Token: 0x06014552 RID: 83282 RVA: 0x001DDF63 File Offset: 0x001DC163
		public unsafe float AnimPhysicsMinDeltaTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_DynamicRigidBody.__PropertyOffset_AnimPhysicsMinDeltaTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_DynamicRigidBody.__PropertyOffset_AnimPhysicsMinDeltaTime) = value;
			}
		}

		// Token: 0x17004FCF RID: 20431
		// (get) Token: 0x06014553 RID: 83283 RVA: 0x001DDF74 File Offset: 0x001DC174
		// (set) Token: 0x06014554 RID: 83284 RVA: 0x001DDF84 File Offset: 0x001DC184
		public unsafe bool bSimulateAnimPhysicsAfterReset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_DynamicRigidBody.__PropertyOffset_bSimulateAnimPhysicsAfterReset) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_DynamicRigidBody.__PropertyOffset_bSimulateAnimPhysicsAfterReset) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004FD0 RID: 20432
		// (get) Token: 0x06014555 RID: 83285 RVA: 0x001DDF95 File Offset: 0x001DC195
		// (set) Token: 0x06014556 RID: 83286 RVA: 0x001DDFA5 File Offset: 0x001DC1A5
		public unsafe float WorldSpaceMinimumScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_DynamicRigidBody.__PropertyOffset_WorldSpaceMinimumScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_DynamicRigidBody.__PropertyOffset_WorldSpaceMinimumScale) = value;
			}
		}

		// Token: 0x17004FD1 RID: 20433
		// (get) Token: 0x06014557 RID: 83287 RVA: 0x001DDFB6 File Offset: 0x001DC1B6
		// (set) Token: 0x06014558 RID: 83288 RVA: 0x001DDFC6 File Offset: 0x001DC1C6
		public unsafe int SimulateMaxSubSteps
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_DynamicRigidBody.__PropertyOffset_SimulateMaxSubSteps);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_DynamicRigidBody.__PropertyOffset_SimulateMaxSubSteps) = value;
			}
		}

		// Token: 0x17004FD2 RID: 20434
		// (get) Token: 0x06014559 RID: 83289 RVA: 0x001DDFD7 File Offset: 0x001DC1D7
		// (set) Token: 0x0601455A RID: 83290 RVA: 0x001DDFE7 File Offset: 0x001DC1E7
		public unsafe float MaxDeltaSeconds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_DynamicRigidBody.__PropertyOffset_MaxDeltaSeconds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_DynamicRigidBody.__PropertyOffset_MaxDeltaSeconds) = value;
			}
		}

		// Token: 0x17004FD3 RID: 20435
		// (get) Token: 0x0601455B RID: 83291 RVA: 0x001DDFF8 File Offset: 0x001DC1F8
		// (set) Token: 0x0601455C RID: 83292 RVA: 0x001DE03B File Offset: 0x001DC23B
		public FAnimPhysicsConfig AnimPhysicsConfigData
		{
			get
			{
				base.FastCheckIsValid();
				FAnimPhysicsConfig result;
				if ((result = this._AnimPhysicsConfigData) == null)
				{
					result = (this._AnimPhysicsConfigData = new FAnimPhysicsConfig(base.NativePtr + (IntPtr)FAnimNode_DynamicRigidBody.__PropertyOffset_AnimPhysicsConfigData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAnimPhysicsConfig.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_DynamicRigidBody.__PropertyOffset_AnimPhysicsConfigData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004FD4 RID: 20436
		// (get) Token: 0x0601455D RID: 83293 RVA: 0x001DE05C File Offset: 0x001DC25C
		// (set) Token: 0x0601455E RID: 83294 RVA: 0x001DE06C File Offset: 0x001DC26C
		public unsafe float AnimPhysicsStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_DynamicRigidBody.__PropertyOffset_AnimPhysicsStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_DynamicRigidBody.__PropertyOffset_AnimPhysicsStrength) = value;
			}
		}

		// Token: 0x17004FD5 RID: 20437
		// (get) Token: 0x0601455F RID: 83295 RVA: 0x001DE07D File Offset: 0x001DC27D
		// (set) Token: 0x06014560 RID: 83296 RVA: 0x001DE096 File Offset: 0x001DC296
		public unsafe bool bEnableWorldGeometry
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FAnimNode_DynamicRigidBody.__PropertyOffset_bEnableWorldGeometry) & FAnimNode_DynamicRigidBody.__PropertyMask_bEnableWorldGeometry) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FAnimNode_DynamicRigidBody.__PropertyOffset_bEnableWorldGeometry) = ((*(base.NativePtr + (IntPtr)FAnimNode_DynamicRigidBody.__PropertyOffset_bEnableWorldGeometry) & ~FAnimNode_DynamicRigidBody.__PropertyMask_bEnableWorldGeometry) | (value ? FAnimNode_DynamicRigidBody.__PropertyMask_bEnableWorldGeometry : 0));
			}
		}

		// Token: 0x17004FD6 RID: 20438
		// (get) Token: 0x06014561 RID: 83297 RVA: 0x001DE0C6 File Offset: 0x001DC2C6
		// (set) Token: 0x06014562 RID: 83298 RVA: 0x001DE0D6 File Offset: 0x001DC2D6
		public unsafe float CachedBoundsScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_DynamicRigidBody.__PropertyOffset_CachedBoundsScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_DynamicRigidBody.__PropertyOffset_CachedBoundsScale) = value;
			}
		}

		// Token: 0x17004FD7 RID: 20439
		// (get) Token: 0x06014563 RID: 83299 RVA: 0x001DE0E7 File Offset: 0x001DC2E7
		// (set) Token: 0x06014564 RID: 83300 RVA: 0x001DE0FB File Offset: 0x001DC2FB
		[Nullable(0)]
		public unsafe TEnumAsByte<ECollisionChannel> OverlapChannel
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_DynamicRigidBody.__PropertyOffset_OverlapChannel);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_DynamicRigidBody.__PropertyOffset_OverlapChannel) = value;
			}
		}

		// Token: 0x17004FD8 RID: 20440
		// (get) Token: 0x06014565 RID: 83301 RVA: 0x001DE110 File Offset: 0x001DC310
		// (set) Token: 0x06014566 RID: 83302 RVA: 0x001DE120 File Offset: 0x001DC320
		public unsafe float EvaluationResetTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_DynamicRigidBody.__PropertyOffset_EvaluationResetTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_DynamicRigidBody.__PropertyOffset_EvaluationResetTime) = value;
			}
		}

		// Token: 0x17004FD9 RID: 20441
		// (get) Token: 0x06014567 RID: 83303 RVA: 0x001DE131 File Offset: 0x001DC331
		// (set) Token: 0x06014568 RID: 83304 RVA: 0x001DE14A File Offset: 0x001DC34A
		public unsafe bool bDebugDraw
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FAnimNode_DynamicRigidBody.__PropertyOffset_bDebugDraw) & FAnimNode_DynamicRigidBody.__PropertyMask_bDebugDraw) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FAnimNode_DynamicRigidBody.__PropertyOffset_bDebugDraw) = ((*(base.NativePtr + (IntPtr)FAnimNode_DynamicRigidBody.__PropertyOffset_bDebugDraw) & ~FAnimNode_DynamicRigidBody.__PropertyMask_bDebugDraw) | (value ? FAnimNode_DynamicRigidBody.__PropertyMask_bDebugDraw : 0));
			}
		}

		// Token: 0x17004FDA RID: 20442
		// (get) Token: 0x06014569 RID: 83305 RVA: 0x001DE17A File Offset: 0x001DC37A
		// (set) Token: 0x0601456A RID: 83306 RVA: 0x001DE193 File Offset: 0x001DC393
		public unsafe bool bTransferBoneVelocities
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FAnimNode_DynamicRigidBody.__PropertyOffset_bTransferBoneVelocities) & FAnimNode_DynamicRigidBody.__PropertyMask_bTransferBoneVelocities) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FAnimNode_DynamicRigidBody.__PropertyOffset_bTransferBoneVelocities) = ((*(base.NativePtr + (IntPtr)FAnimNode_DynamicRigidBody.__PropertyOffset_bTransferBoneVelocities) & ~FAnimNode_DynamicRigidBody.__PropertyMask_bTransferBoneVelocities) | (value ? FAnimNode_DynamicRigidBody.__PropertyMask_bTransferBoneVelocities : 0));
			}
		}

		// Token: 0x17004FDB RID: 20443
		// (get) Token: 0x0601456B RID: 83307 RVA: 0x001DE1C3 File Offset: 0x001DC3C3
		// (set) Token: 0x0601456C RID: 83308 RVA: 0x001DE1DC File Offset: 0x001DC3DC
		public unsafe bool bFreezeIncomingPoseOnStart
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FAnimNode_DynamicRigidBody.__PropertyOffset_bFreezeIncomingPoseOnStart) & FAnimNode_DynamicRigidBody.__PropertyMask_bFreezeIncomingPoseOnStart) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FAnimNode_DynamicRigidBody.__PropertyOffset_bFreezeIncomingPoseOnStart) = ((*(base.NativePtr + (IntPtr)FAnimNode_DynamicRigidBody.__PropertyOffset_bFreezeIncomingPoseOnStart) & ~FAnimNode_DynamicRigidBody.__PropertyMask_bFreezeIncomingPoseOnStart) | (value ? FAnimNode_DynamicRigidBody.__PropertyMask_bFreezeIncomingPoseOnStart : 0));
			}
		}

		// Token: 0x0601456D RID: 83309 RVA: 0x001DE20C File Offset: 0x001DC40C
		public FAnimNode_DynamicRigidBody()
		{
		}

		// Token: 0x0601456E RID: 83310 RVA: 0x001DE214 File Offset: 0x001DC414
		public FAnimNode_DynamicRigidBody(UPhysicsAsset RagdollPhysicsAsset, EDynamicRBModeType SimMode, bool bOverrideWorldGravity, FVector OverrideWorldGravity, EDynamicRBSimulationSpace SimulationSpace, FBoneReference BaseBoneRef, bool bForceDisableCollisionBetweenConstraintBodies, bool bClampLinearTranslationLimitToRefPose, float ClampLinearTranslationLimitToRefPose_Rate, float AnimPhysicsMinDeltaTime, bool bSimulateAnimPhysicsAfterReset, float WorldSpaceMinimumScale, int SimulateMaxSubSteps, float MaxDeltaSeconds, FAnimPhysicsConfig AnimPhysicsConfigData, float AnimPhysicsStrength, bool bEnableWorldGeometry, float CachedBoundsScale, [Nullable(0)] TEnumAsByte<ECollisionChannel> OverlapChannel, float EvaluationResetTime, bool bDebugDraw, bool bTransferBoneVelocities, bool bFreezeIncomingPoseOnStart, FComponentSpacePoseLink ComponentPose, int LODThreshold, int KuroLODMask, float ActualAlpha, EAnimAlphaInputType AlphaInputType, bool bAlphaBoolEnabled, bool bParallelEvalEnabled, bool bEnableOnMobile, float Alpha, FInputScaleBias AlphaScaleBias, FInputAlphaBoolBlend AlphaBoolBlend, FName AlphaCurveName, FInputScaleBiasClamp AlphaScaleBiasClamp)
		{
			this.RagdollPhysicsAsset = RagdollPhysicsAsset;
			this.SimMode = SimMode;
			this.bOverrideWorldGravity = bOverrideWorldGravity;
			this.OverrideWorldGravity = OverrideWorldGravity;
			this.SimulationSpace = SimulationSpace;
			this.BaseBoneRef = BaseBoneRef;
			this.bForceDisableCollisionBetweenConstraintBodies = bForceDisableCollisionBetweenConstraintBodies;
			this.bClampLinearTranslationLimitToRefPose = bClampLinearTranslationLimitToRefPose;
			this.ClampLinearTranslationLimitToRefPose_Rate = ClampLinearTranslationLimitToRefPose_Rate;
			this.AnimPhysicsMinDeltaTime = AnimPhysicsMinDeltaTime;
			this.bSimulateAnimPhysicsAfterReset = bSimulateAnimPhysicsAfterReset;
			this.WorldSpaceMinimumScale = WorldSpaceMinimumScale;
			this.SimulateMaxSubSteps = SimulateMaxSubSteps;
			this.MaxDeltaSeconds = MaxDeltaSeconds;
			this.AnimPhysicsConfigData = AnimPhysicsConfigData;
			this.AnimPhysicsStrength = AnimPhysicsStrength;
			this.bEnableWorldGeometry = bEnableWorldGeometry;
			this.CachedBoundsScale = CachedBoundsScale;
			this.OverlapChannel = OverlapChannel;
			this.EvaluationResetTime = EvaluationResetTime;
			this.bDebugDraw = bDebugDraw;
			this.bTransferBoneVelocities = bTransferBoneVelocities;
			this.bFreezeIncomingPoseOnStart = bFreezeIncomingPoseOnStart;
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

		// Token: 0x0601456F RID: 83311 RVA: 0x001DE344 File Offset: 0x001DC544
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_DynamicRigidBody.StaticStruct();
		}

		// Token: 0x06014570 RID: 83312 RVA: 0x001DE350 File Offset: 0x001DC550
		[NullableContext(2)]
		public FAnimNode_DynamicRigidBody(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06014571 RID: 83313 RVA: 0x001DE35A File Offset: 0x001DC55A
		public FAnimNode_DynamicRigidBody(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06014572 RID: 83314 RVA: 0x001DE365 File Offset: 0x001DC565
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_DynamicRigidBody(Pointer, false, true);
		}

		// Token: 0x06014573 RID: 83315 RVA: 0x001DE36F File Offset: 0x001DC56F
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_DynamicRigidBody(Pointer, MemoryOwner);
		}

		// Token: 0x0400B0FC RID: 45308
		public new const string __ObjectPath = "/Script/KuroAnim.AnimNode_DynamicRigidBody";

		// Token: 0x0400B0FD RID: 45309
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B0FE RID: 45310
		internal static int __PropertyOffset_RagdollPhysicsAsset;

		// Token: 0x0400B0FF RID: 45311
		internal static int __PropertyOffset_SimMode;

		// Token: 0x0400B100 RID: 45312
		internal static int __PropertyOffset_bOverrideWorldGravity;

		// Token: 0x0400B101 RID: 45313
		internal static byte __PropertyMask_bOverrideWorldGravity;

		// Token: 0x0400B102 RID: 45314
		internal static int __PropertyOffset_OverrideWorldGravity;

		// Token: 0x0400B103 RID: 45315
		internal static int __PropertyOffset_SimulationSpace;

		// Token: 0x0400B104 RID: 45316
		internal static int __PropertyOffset_BaseBoneRef;

		// Token: 0x0400B105 RID: 45317
		[Nullable(2)]
		private FBoneReference _BaseBoneRef;

		// Token: 0x0400B106 RID: 45318
		internal static int __PropertyOffset_bForceDisableCollisionBetweenConstraintBodies;

		// Token: 0x0400B107 RID: 45319
		internal static int __PropertyOffset_bClampLinearTranslationLimitToRefPose;

		// Token: 0x0400B108 RID: 45320
		internal static byte __PropertyMask_bClampLinearTranslationLimitToRefPose;

		// Token: 0x0400B109 RID: 45321
		internal static int __PropertyOffset_ClampLinearTranslationLimitToRefPose_Rate;

		// Token: 0x0400B10A RID: 45322
		internal static int __PropertyOffset_AnimPhysicsMinDeltaTime;

		// Token: 0x0400B10B RID: 45323
		internal static int __PropertyOffset_bSimulateAnimPhysicsAfterReset;

		// Token: 0x0400B10C RID: 45324
		internal static int __PropertyOffset_WorldSpaceMinimumScale;

		// Token: 0x0400B10D RID: 45325
		internal static int __PropertyOffset_SimulateMaxSubSteps;

		// Token: 0x0400B10E RID: 45326
		internal static int __PropertyOffset_MaxDeltaSeconds;

		// Token: 0x0400B10F RID: 45327
		internal static int __PropertyOffset_AnimPhysicsConfigData;

		// Token: 0x0400B110 RID: 45328
		[Nullable(2)]
		private FAnimPhysicsConfig _AnimPhysicsConfigData;

		// Token: 0x0400B111 RID: 45329
		internal static int __PropertyOffset_AnimPhysicsStrength;

		// Token: 0x0400B112 RID: 45330
		internal static int __PropertyOffset_bEnableWorldGeometry;

		// Token: 0x0400B113 RID: 45331
		internal static byte __PropertyMask_bEnableWorldGeometry;

		// Token: 0x0400B114 RID: 45332
		internal static int __PropertyOffset_CachedBoundsScale;

		// Token: 0x0400B115 RID: 45333
		internal static int __PropertyOffset_OverlapChannel;

		// Token: 0x0400B116 RID: 45334
		internal static int __PropertyOffset_EvaluationResetTime;

		// Token: 0x0400B117 RID: 45335
		internal static int __PropertyOffset_bDebugDraw;

		// Token: 0x0400B118 RID: 45336
		internal static byte __PropertyMask_bDebugDraw;

		// Token: 0x0400B119 RID: 45337
		internal static int __PropertyOffset_bTransferBoneVelocities;

		// Token: 0x0400B11A RID: 45338
		internal static byte __PropertyMask_bTransferBoneVelocities;

		// Token: 0x0400B11B RID: 45339
		internal static int __PropertyOffset_bFreezeIncomingPoseOnStart;

		// Token: 0x0400B11C RID: 45340
		internal static byte __PropertyMask_bFreezeIncomingPoseOnStart;
	}
}
