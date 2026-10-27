using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002F7 RID: 759
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.AnimNode_RigidBody")]
	[UnrealStructLayout(1936, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 1936)]
	public class FAnimNode_RigidBody : FAnimNode_SkeletalControlBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002B3F RID: 11071 RVA: 0x00041CB0 File Offset: 0x0003FEB0
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_RigidBody._ScriptStructPtr != 0) ? FAnimNode_RigidBody._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.AnimNode_RigidBody", ref FAnimNode_RigidBody._ScriptStructPtr);
		}

		// Token: 0x17000A96 RID: 2710
		// (get) Token: 0x06002B40 RID: 11072 RVA: 0x00041CD4 File Offset: 0x0003FED4
		// (set) Token: 0x06002B41 RID: 11073 RVA: 0x00041CE8 File Offset: 0x0003FEE8
		[Nullable(2)]
		public unsafe UPhysicsAsset OverridePhysicsAsset
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPhysicsAsset>(base.NativePtr / (IntPtr)sizeof(void*) + FAnimNode_RigidBody.__PropertyOffset_OverridePhysicsAsset);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FAnimNode_RigidBody.__PropertyOffset_OverridePhysicsAsset, value);
			}
		}

		// Token: 0x17000A97 RID: 2711
		// (get) Token: 0x06002B42 RID: 11074 RVA: 0x00041CFD File Offset: 0x0003FEFD
		// (set) Token: 0x06002B43 RID: 11075 RVA: 0x00041D11 File Offset: 0x0003FF11
		public unsafe FVector OverrideWorldGravity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_RigidBody.__PropertyOffset_OverrideWorldGravity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_RigidBody.__PropertyOffset_OverrideWorldGravity) = value;
			}
		}

		// Token: 0x17000A98 RID: 2712
		// (get) Token: 0x06002B44 RID: 11076 RVA: 0x00041D26 File Offset: 0x0003FF26
		// (set) Token: 0x06002B45 RID: 11077 RVA: 0x00041D3A File Offset: 0x0003FF3A
		public unsafe FVector ExternalForce
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_RigidBody.__PropertyOffset_ExternalForce);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_RigidBody.__PropertyOffset_ExternalForce) = value;
			}
		}

		// Token: 0x17000A99 RID: 2713
		// (get) Token: 0x06002B46 RID: 11078 RVA: 0x00041D4F File Offset: 0x0003FF4F
		// (set) Token: 0x06002B47 RID: 11079 RVA: 0x00041D63 File Offset: 0x0003FF63
		public unsafe FVector ComponentLinearAccScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_RigidBody.__PropertyOffset_ComponentLinearAccScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_RigidBody.__PropertyOffset_ComponentLinearAccScale) = value;
			}
		}

		// Token: 0x17000A9A RID: 2714
		// (get) Token: 0x06002B48 RID: 11080 RVA: 0x00041D78 File Offset: 0x0003FF78
		// (set) Token: 0x06002B49 RID: 11081 RVA: 0x00041D8C File Offset: 0x0003FF8C
		public unsafe FVector ComponentLinearVelScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_RigidBody.__PropertyOffset_ComponentLinearVelScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_RigidBody.__PropertyOffset_ComponentLinearVelScale) = value;
			}
		}

		// Token: 0x17000A9B RID: 2715
		// (get) Token: 0x06002B4A RID: 11082 RVA: 0x00041DA1 File Offset: 0x0003FFA1
		// (set) Token: 0x06002B4B RID: 11083 RVA: 0x00041DB5 File Offset: 0x0003FFB5
		public unsafe FVector ComponentAppliedLinearAccClamp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_RigidBody.__PropertyOffset_ComponentAppliedLinearAccClamp);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_RigidBody.__PropertyOffset_ComponentAppliedLinearAccClamp) = value;
			}
		}

		// Token: 0x17000A9C RID: 2716
		// (get) Token: 0x06002B4C RID: 11084 RVA: 0x00041DCC File Offset: 0x0003FFCC
		// (set) Token: 0x06002B4D RID: 11085 RVA: 0x00041E0F File Offset: 0x0004000F
		public FSimSpaceSettings SimSpaceSettings
		{
			get
			{
				base.FastCheckIsValid();
				FSimSpaceSettings result;
				if ((result = this._SimSpaceSettings) == null)
				{
					result = (this._SimSpaceSettings = new FSimSpaceSettings(base.NativePtr + (IntPtr)FAnimNode_RigidBody.__PropertyOffset_SimSpaceSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSimSpaceSettings.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_RigidBody.__PropertyOffset_SimSpaceSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000A9D RID: 2717
		// (get) Token: 0x06002B4E RID: 11086 RVA: 0x00041E30 File Offset: 0x00040030
		// (set) Token: 0x06002B4F RID: 11087 RVA: 0x00041E40 File Offset: 0x00040040
		public unsafe float CachedBoundsScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_RigidBody.__PropertyOffset_CachedBoundsScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_RigidBody.__PropertyOffset_CachedBoundsScale) = value;
			}
		}

		// Token: 0x17000A9E RID: 2718
		// (get) Token: 0x06002B50 RID: 11088 RVA: 0x00041E54 File Offset: 0x00040054
		// (set) Token: 0x06002B51 RID: 11089 RVA: 0x00041E97 File Offset: 0x00040097
		public FBoneReference BaseBoneRef
		{
			get
			{
				base.FastCheckIsValid();
				FBoneReference result;
				if ((result = this._BaseBoneRef) == null)
				{
					result = (this._BaseBoneRef = new FBoneReference(base.NativePtr + (IntPtr)FAnimNode_RigidBody.__PropertyOffset_BaseBoneRef, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneReference.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_RigidBody.__PropertyOffset_BaseBoneRef, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000A9F RID: 2719
		// (get) Token: 0x06002B52 RID: 11090 RVA: 0x00041EB8 File Offset: 0x000400B8
		// (set) Token: 0x06002B53 RID: 11091 RVA: 0x00041ECC File Offset: 0x000400CC
		[Nullable(0)]
		public unsafe TEnumAsByte<ECollisionChannel> OverlapChannel
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_RigidBody.__PropertyOffset_OverlapChannel);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_RigidBody.__PropertyOffset_OverlapChannel) = value;
			}
		}

		// Token: 0x17000AA0 RID: 2720
		// (get) Token: 0x06002B54 RID: 11092 RVA: 0x00041EE1 File Offset: 0x000400E1
		// (set) Token: 0x06002B55 RID: 11093 RVA: 0x00041EF1 File Offset: 0x000400F1
		public unsafe ESimulationSpace SimulationSpace
		{
			get
			{
				return (ESimulationSpace)(*(base.NativePtr + (IntPtr)FAnimNode_RigidBody.__PropertyOffset_SimulationSpace));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_RigidBody.__PropertyOffset_SimulationSpace) = (byte)value;
			}
		}

		// Token: 0x17000AA1 RID: 2721
		// (get) Token: 0x06002B56 RID: 11094 RVA: 0x00041F02 File Offset: 0x00040102
		// (set) Token: 0x06002B57 RID: 11095 RVA: 0x00041F12 File Offset: 0x00040112
		public unsafe bool bForceDisableCollisionBetweenConstraintBodies
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_RigidBody.__PropertyOffset_bForceDisableCollisionBetweenConstraintBodies) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_RigidBody.__PropertyOffset_bForceDisableCollisionBetweenConstraintBodies) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000AA2 RID: 2722
		// (get) Token: 0x06002B58 RID: 11096 RVA: 0x00041F23 File Offset: 0x00040123
		// (set) Token: 0x06002B59 RID: 11097 RVA: 0x00041F3C File Offset: 0x0004013C
		public unsafe bool bEnableWorldGeometry
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FAnimNode_RigidBody.__PropertyOffset_bEnableWorldGeometry) & FAnimNode_RigidBody.__PropertyMask_bEnableWorldGeometry) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FAnimNode_RigidBody.__PropertyOffset_bEnableWorldGeometry) = ((*(base.NativePtr + (IntPtr)FAnimNode_RigidBody.__PropertyOffset_bEnableWorldGeometry) & ~FAnimNode_RigidBody.__PropertyMask_bEnableWorldGeometry) | (value ? FAnimNode_RigidBody.__PropertyMask_bEnableWorldGeometry : 0));
			}
		}

		// Token: 0x17000AA3 RID: 2723
		// (get) Token: 0x06002B5A RID: 11098 RVA: 0x00041F6C File Offset: 0x0004016C
		// (set) Token: 0x06002B5B RID: 11099 RVA: 0x00041F85 File Offset: 0x00040185
		public unsafe bool bOverrideWorldGravity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FAnimNode_RigidBody.__PropertyOffset_bOverrideWorldGravity) & FAnimNode_RigidBody.__PropertyMask_bOverrideWorldGravity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FAnimNode_RigidBody.__PropertyOffset_bOverrideWorldGravity) = ((*(base.NativePtr + (IntPtr)FAnimNode_RigidBody.__PropertyOffset_bOverrideWorldGravity) & ~FAnimNode_RigidBody.__PropertyMask_bOverrideWorldGravity) | (value ? FAnimNode_RigidBody.__PropertyMask_bOverrideWorldGravity : 0));
			}
		}

		// Token: 0x17000AA4 RID: 2724
		// (get) Token: 0x06002B5C RID: 11100 RVA: 0x00041FB5 File Offset: 0x000401B5
		// (set) Token: 0x06002B5D RID: 11101 RVA: 0x00041FCE File Offset: 0x000401CE
		public unsafe bool bTransferBoneVelocities
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FAnimNode_RigidBody.__PropertyOffset_bTransferBoneVelocities) & FAnimNode_RigidBody.__PropertyMask_bTransferBoneVelocities) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FAnimNode_RigidBody.__PropertyOffset_bTransferBoneVelocities) = ((*(base.NativePtr + (IntPtr)FAnimNode_RigidBody.__PropertyOffset_bTransferBoneVelocities) & ~FAnimNode_RigidBody.__PropertyMask_bTransferBoneVelocities) | (value ? FAnimNode_RigidBody.__PropertyMask_bTransferBoneVelocities : 0));
			}
		}

		// Token: 0x17000AA5 RID: 2725
		// (get) Token: 0x06002B5E RID: 11102 RVA: 0x00041FFE File Offset: 0x000401FE
		// (set) Token: 0x06002B5F RID: 11103 RVA: 0x00042017 File Offset: 0x00040217
		public unsafe bool bFreezeIncomingPoseOnStart
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FAnimNode_RigidBody.__PropertyOffset_bFreezeIncomingPoseOnStart) & FAnimNode_RigidBody.__PropertyMask_bFreezeIncomingPoseOnStart) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FAnimNode_RigidBody.__PropertyOffset_bFreezeIncomingPoseOnStart) = ((*(base.NativePtr + (IntPtr)FAnimNode_RigidBody.__PropertyOffset_bFreezeIncomingPoseOnStart) & ~FAnimNode_RigidBody.__PropertyMask_bFreezeIncomingPoseOnStart) | (value ? FAnimNode_RigidBody.__PropertyMask_bFreezeIncomingPoseOnStart : 0));
			}
		}

		// Token: 0x17000AA6 RID: 2726
		// (get) Token: 0x06002B60 RID: 11104 RVA: 0x00042047 File Offset: 0x00040247
		// (set) Token: 0x06002B61 RID: 11105 RVA: 0x00042060 File Offset: 0x00040260
		public unsafe bool bClampLinearTranslationLimitToRefPose
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FAnimNode_RigidBody.__PropertyOffset_bClampLinearTranslationLimitToRefPose) & FAnimNode_RigidBody.__PropertyMask_bClampLinearTranslationLimitToRefPose) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FAnimNode_RigidBody.__PropertyOffset_bClampLinearTranslationLimitToRefPose) = ((*(base.NativePtr + (IntPtr)FAnimNode_RigidBody.__PropertyOffset_bClampLinearTranslationLimitToRefPose) & ~FAnimNode_RigidBody.__PropertyMask_bClampLinearTranslationLimitToRefPose) | (value ? FAnimNode_RigidBody.__PropertyMask_bClampLinearTranslationLimitToRefPose : 0));
			}
		}

		// Token: 0x17000AA7 RID: 2727
		// (get) Token: 0x06002B62 RID: 11106 RVA: 0x00042090 File Offset: 0x00040290
		// (set) Token: 0x06002B63 RID: 11107 RVA: 0x000420A0 File Offset: 0x000402A0
		public unsafe float WorldSpaceMinimumScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_RigidBody.__PropertyOffset_WorldSpaceMinimumScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_RigidBody.__PropertyOffset_WorldSpaceMinimumScale) = value;
			}
		}

		// Token: 0x17000AA8 RID: 2728
		// (get) Token: 0x06002B64 RID: 11108 RVA: 0x000420B1 File Offset: 0x000402B1
		// (set) Token: 0x06002B65 RID: 11109 RVA: 0x000420C1 File Offset: 0x000402C1
		public unsafe float EvaluationResetTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_RigidBody.__PropertyOffset_EvaluationResetTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_RigidBody.__PropertyOffset_EvaluationResetTime) = value;
			}
		}

		// Token: 0x06002B66 RID: 11110 RVA: 0x000420D2 File Offset: 0x000402D2
		public FAnimNode_RigidBody()
		{
		}

		// Token: 0x06002B67 RID: 11111 RVA: 0x000420DC File Offset: 0x000402DC
		public FAnimNode_RigidBody(UPhysicsAsset OverridePhysicsAsset, FVector OverrideWorldGravity, FVector ExternalForce, FVector ComponentLinearAccScale, FVector ComponentLinearVelScale, FVector ComponentAppliedLinearAccClamp, FSimSpaceSettings SimSpaceSettings, float CachedBoundsScale, FBoneReference BaseBoneRef, [Nullable(0)] TEnumAsByte<ECollisionChannel> OverlapChannel, ESimulationSpace SimulationSpace, bool bForceDisableCollisionBetweenConstraintBodies, bool bEnableWorldGeometry, bool bOverrideWorldGravity, bool bTransferBoneVelocities, bool bFreezeIncomingPoseOnStart, bool bClampLinearTranslationLimitToRefPose, float WorldSpaceMinimumScale, float EvaluationResetTime, bool bComponentSpaceSimulation_DEPRECATED, FComponentSpacePoseLink ComponentPose, int LODThreshold, int KuroLODMask, float ActualAlpha, EAnimAlphaInputType AlphaInputType, bool bAlphaBoolEnabled, bool bParallelEvalEnabled, bool bEnableOnMobile, float Alpha, FInputScaleBias AlphaScaleBias, FInputAlphaBoolBlend AlphaBoolBlend, FName AlphaCurveName, FInputScaleBiasClamp AlphaScaleBiasClamp)
		{
			this.OverridePhysicsAsset = OverridePhysicsAsset;
			this.OverrideWorldGravity = OverrideWorldGravity;
			this.ExternalForce = ExternalForce;
			this.ComponentLinearAccScale = ComponentLinearAccScale;
			this.ComponentLinearVelScale = ComponentLinearVelScale;
			this.ComponentAppliedLinearAccClamp = ComponentAppliedLinearAccClamp;
			this.SimSpaceSettings = SimSpaceSettings;
			this.CachedBoundsScale = CachedBoundsScale;
			this.BaseBoneRef = BaseBoneRef;
			this.OverlapChannel = OverlapChannel;
			this.SimulationSpace = SimulationSpace;
			this.bForceDisableCollisionBetweenConstraintBodies = bForceDisableCollisionBetweenConstraintBodies;
			this.bEnableWorldGeometry = bEnableWorldGeometry;
			this.bOverrideWorldGravity = bOverrideWorldGravity;
			this.bTransferBoneVelocities = bTransferBoneVelocities;
			this.bFreezeIncomingPoseOnStart = bFreezeIncomingPoseOnStart;
			this.bClampLinearTranslationLimitToRefPose = bClampLinearTranslationLimitToRefPose;
			this.WorldSpaceMinimumScale = WorldSpaceMinimumScale;
			this.EvaluationResetTime = EvaluationResetTime;
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

		// Token: 0x06002B68 RID: 11112 RVA: 0x000421EC File Offset: 0x000403EC
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_RigidBody.StaticStruct();
		}

		// Token: 0x06002B69 RID: 11113 RVA: 0x000421F8 File Offset: 0x000403F8
		[NullableContext(2)]
		public FAnimNode_RigidBody(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002B6A RID: 11114 RVA: 0x00042202 File Offset: 0x00040402
		public FAnimNode_RigidBody(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002B6B RID: 11115 RVA: 0x0004220D File Offset: 0x0004040D
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_RigidBody(Pointer, false, true);
		}

		// Token: 0x06002B6C RID: 11116 RVA: 0x00042217 File Offset: 0x00040417
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_RigidBody(Pointer, MemoryOwner);
		}

		// Token: 0x04001190 RID: 4496
		public new const string __ObjectPath = "/Script/AnimGraphRuntime.AnimNode_RigidBody";

		// Token: 0x04001191 RID: 4497
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001192 RID: 4498
		internal static int __PropertyOffset_OverridePhysicsAsset;

		// Token: 0x04001193 RID: 4499
		internal static int __PropertyOffset_OverrideWorldGravity;

		// Token: 0x04001194 RID: 4500
		internal static int __PropertyOffset_ExternalForce;

		// Token: 0x04001195 RID: 4501
		internal static int __PropertyOffset_ComponentLinearAccScale;

		// Token: 0x04001196 RID: 4502
		internal static int __PropertyOffset_ComponentLinearVelScale;

		// Token: 0x04001197 RID: 4503
		internal static int __PropertyOffset_ComponentAppliedLinearAccClamp;

		// Token: 0x04001198 RID: 4504
		internal static int __PropertyOffset_SimSpaceSettings;

		// Token: 0x04001199 RID: 4505
		[Nullable(2)]
		private FSimSpaceSettings _SimSpaceSettings;

		// Token: 0x0400119A RID: 4506
		internal static int __PropertyOffset_CachedBoundsScale;

		// Token: 0x0400119B RID: 4507
		internal static int __PropertyOffset_BaseBoneRef;

		// Token: 0x0400119C RID: 4508
		[Nullable(2)]
		private FBoneReference _BaseBoneRef;

		// Token: 0x0400119D RID: 4509
		internal static int __PropertyOffset_OverlapChannel;

		// Token: 0x0400119E RID: 4510
		internal static int __PropertyOffset_SimulationSpace;

		// Token: 0x0400119F RID: 4511
		internal static int __PropertyOffset_bForceDisableCollisionBetweenConstraintBodies;

		// Token: 0x040011A0 RID: 4512
		internal static int __PropertyOffset_bEnableWorldGeometry;

		// Token: 0x040011A1 RID: 4513
		internal static byte __PropertyMask_bEnableWorldGeometry;

		// Token: 0x040011A2 RID: 4514
		internal static int __PropertyOffset_bOverrideWorldGravity;

		// Token: 0x040011A3 RID: 4515
		internal static byte __PropertyMask_bOverrideWorldGravity;

		// Token: 0x040011A4 RID: 4516
		internal static int __PropertyOffset_bTransferBoneVelocities;

		// Token: 0x040011A5 RID: 4517
		internal static byte __PropertyMask_bTransferBoneVelocities;

		// Token: 0x040011A6 RID: 4518
		internal static int __PropertyOffset_bFreezeIncomingPoseOnStart;

		// Token: 0x040011A7 RID: 4519
		internal static byte __PropertyMask_bFreezeIncomingPoseOnStart;

		// Token: 0x040011A8 RID: 4520
		internal static int __PropertyOffset_bClampLinearTranslationLimitToRefPose;

		// Token: 0x040011A9 RID: 4521
		internal static byte __PropertyMask_bClampLinearTranslationLimitToRefPose;

		// Token: 0x040011AA RID: 4522
		internal static int __PropertyOffset_WorldSpaceMinimumScale;

		// Token: 0x040011AB RID: 4523
		internal static int __PropertyOffset_EvaluationResetTime;
	}
}
