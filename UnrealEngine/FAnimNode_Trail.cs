using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000303 RID: 771
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.AnimNode_Trail")]
	[UnrealStructLayout(800, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 800)]
	public class FAnimNode_Trail : FAnimNode_SkeletalControlBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002C5F RID: 11359 RVA: 0x00043CE1 File Offset: 0x00041EE1
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_Trail._ScriptStructPtr != 0) ? FAnimNode_Trail._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.AnimNode_Trail", ref FAnimNode_Trail._ScriptStructPtr);
		}

		// Token: 0x17000AF6 RID: 2806
		// (get) Token: 0x06002C60 RID: 11360 RVA: 0x00043D08 File Offset: 0x00041F08
		// (set) Token: 0x06002C61 RID: 11361 RVA: 0x00043D4B File Offset: 0x00041F4B
		public FBoneReference TrailBone
		{
			get
			{
				base.FastCheckIsValid();
				FBoneReference result;
				if ((result = this._TrailBone) == null)
				{
					result = (this._TrailBone = new FBoneReference(base.NativePtr + (IntPtr)FAnimNode_Trail.__PropertyOffset_TrailBone, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneReference.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_Trail.__PropertyOffset_TrailBone, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000AF7 RID: 2807
		// (get) Token: 0x06002C62 RID: 11362 RVA: 0x00043D6C File Offset: 0x00041F6C
		// (set) Token: 0x06002C63 RID: 11363 RVA: 0x00043D7C File Offset: 0x00041F7C
		public unsafe int ChainLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_Trail.__PropertyOffset_ChainLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_Trail.__PropertyOffset_ChainLength) = value;
			}
		}

		// Token: 0x17000AF8 RID: 2808
		// (get) Token: 0x06002C64 RID: 11364 RVA: 0x00043D8D File Offset: 0x00041F8D
		// (set) Token: 0x06002C65 RID: 11365 RVA: 0x00043DA1 File Offset: 0x00041FA1
		[Nullable(0)]
		public unsafe TEnumAsByte<EAxis> ChainBoneAxis
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_Trail.__PropertyOffset_ChainBoneAxis);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_Trail.__PropertyOffset_ChainBoneAxis) = value;
			}
		}

		// Token: 0x17000AF9 RID: 2809
		// (get) Token: 0x06002C66 RID: 11366 RVA: 0x00043DB6 File Offset: 0x00041FB6
		// (set) Token: 0x06002C67 RID: 11367 RVA: 0x00043DCF File Offset: 0x00041FCF
		public unsafe bool bInvertChainBoneAxis
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FAnimNode_Trail.__PropertyOffset_bInvertChainBoneAxis) & FAnimNode_Trail.__PropertyMask_bInvertChainBoneAxis) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FAnimNode_Trail.__PropertyOffset_bInvertChainBoneAxis) = ((*(base.NativePtr + (IntPtr)FAnimNode_Trail.__PropertyOffset_bInvertChainBoneAxis) & ~FAnimNode_Trail.__PropertyMask_bInvertChainBoneAxis) | (value ? FAnimNode_Trail.__PropertyMask_bInvertChainBoneAxis : 0));
			}
		}

		// Token: 0x17000AFA RID: 2810
		// (get) Token: 0x06002C68 RID: 11368 RVA: 0x00043DFF File Offset: 0x00041FFF
		// (set) Token: 0x06002C69 RID: 11369 RVA: 0x00043E18 File Offset: 0x00042018
		public unsafe bool bLimitStretch
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FAnimNode_Trail.__PropertyOffset_bLimitStretch) & FAnimNode_Trail.__PropertyMask_bLimitStretch) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FAnimNode_Trail.__PropertyOffset_bLimitStretch) = ((*(base.NativePtr + (IntPtr)FAnimNode_Trail.__PropertyOffset_bLimitStretch) & ~FAnimNode_Trail.__PropertyMask_bLimitStretch) | (value ? FAnimNode_Trail.__PropertyMask_bLimitStretch : 0));
			}
		}

		// Token: 0x17000AFB RID: 2811
		// (get) Token: 0x06002C6A RID: 11370 RVA: 0x00043E48 File Offset: 0x00042048
		// (set) Token: 0x06002C6B RID: 11371 RVA: 0x00043E61 File Offset: 0x00042061
		public unsafe bool bLimitRotation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FAnimNode_Trail.__PropertyOffset_bLimitRotation) & FAnimNode_Trail.__PropertyMask_bLimitRotation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FAnimNode_Trail.__PropertyOffset_bLimitRotation) = ((*(base.NativePtr + (IntPtr)FAnimNode_Trail.__PropertyOffset_bLimitRotation) & ~FAnimNode_Trail.__PropertyMask_bLimitRotation) | (value ? FAnimNode_Trail.__PropertyMask_bLimitRotation : 0));
			}
		}

		// Token: 0x17000AFC RID: 2812
		// (get) Token: 0x06002C6C RID: 11372 RVA: 0x00043E91 File Offset: 0x00042091
		// (set) Token: 0x06002C6D RID: 11373 RVA: 0x00043EAA File Offset: 0x000420AA
		public unsafe bool bUsePlanarLimit
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FAnimNode_Trail.__PropertyOffset_bUsePlanarLimit) & FAnimNode_Trail.__PropertyMask_bUsePlanarLimit) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FAnimNode_Trail.__PropertyOffset_bUsePlanarLimit) = ((*(base.NativePtr + (IntPtr)FAnimNode_Trail.__PropertyOffset_bUsePlanarLimit) & ~FAnimNode_Trail.__PropertyMask_bUsePlanarLimit) | (value ? FAnimNode_Trail.__PropertyMask_bUsePlanarLimit : 0));
			}
		}

		// Token: 0x17000AFD RID: 2813
		// (get) Token: 0x06002C6E RID: 11374 RVA: 0x00043EDA File Offset: 0x000420DA
		// (set) Token: 0x06002C6F RID: 11375 RVA: 0x00043EF3 File Offset: 0x000420F3
		public unsafe bool bActorSpaceFakeVel
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FAnimNode_Trail.__PropertyOffset_bActorSpaceFakeVel) & FAnimNode_Trail.__PropertyMask_bActorSpaceFakeVel) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FAnimNode_Trail.__PropertyOffset_bActorSpaceFakeVel) = ((*(base.NativePtr + (IntPtr)FAnimNode_Trail.__PropertyOffset_bActorSpaceFakeVel) & ~FAnimNode_Trail.__PropertyMask_bActorSpaceFakeVel) | (value ? FAnimNode_Trail.__PropertyMask_bActorSpaceFakeVel : 0));
			}
		}

		// Token: 0x17000AFE RID: 2814
		// (get) Token: 0x06002C70 RID: 11376 RVA: 0x00043F23 File Offset: 0x00042123
		// (set) Token: 0x06002C71 RID: 11377 RVA: 0x00043F3C File Offset: 0x0004213C
		public unsafe bool bReorientParentToChild
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FAnimNode_Trail.__PropertyOffset_bReorientParentToChild) & FAnimNode_Trail.__PropertyMask_bReorientParentToChild) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FAnimNode_Trail.__PropertyOffset_bReorientParentToChild) = ((*(base.NativePtr + (IntPtr)FAnimNode_Trail.__PropertyOffset_bReorientParentToChild) & ~FAnimNode_Trail.__PropertyMask_bReorientParentToChild) | (value ? FAnimNode_Trail.__PropertyMask_bReorientParentToChild : 0));
			}
		}

		// Token: 0x17000AFF RID: 2815
		// (get) Token: 0x06002C72 RID: 11378 RVA: 0x00043F6C File Offset: 0x0004216C
		// (set) Token: 0x06002C73 RID: 11379 RVA: 0x00043F7C File Offset: 0x0004217C
		public unsafe float MaxDeltaTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_Trail.__PropertyOffset_MaxDeltaTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_Trail.__PropertyOffset_MaxDeltaTime) = value;
			}
		}

		// Token: 0x17000B00 RID: 2816
		// (get) Token: 0x06002C74 RID: 11380 RVA: 0x00043F8D File Offset: 0x0004218D
		// (set) Token: 0x06002C75 RID: 11381 RVA: 0x00043F9D File Offset: 0x0004219D
		public unsafe float RelaxationSpeedScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_Trail.__PropertyOffset_RelaxationSpeedScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_Trail.__PropertyOffset_RelaxationSpeedScale) = value;
			}
		}

		// Token: 0x17000B01 RID: 2817
		// (get) Token: 0x06002C76 RID: 11382 RVA: 0x00043FB0 File Offset: 0x000421B0
		// (set) Token: 0x06002C77 RID: 11383 RVA: 0x00043FF3 File Offset: 0x000421F3
		public FRuntimeFloatCurve TrailRelaxationSpeed
		{
			get
			{
				base.FastCheckIsValid();
				FRuntimeFloatCurve result;
				if ((result = this._TrailRelaxationSpeed) == null)
				{
					result = (this._TrailRelaxationSpeed = new FRuntimeFloatCurve(base.NativePtr + (IntPtr)FAnimNode_Trail.__PropertyOffset_TrailRelaxationSpeed, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRuntimeFloatCurve.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_Trail.__PropertyOffset_TrailRelaxationSpeed, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000B02 RID: 2818
		// (get) Token: 0x06002C78 RID: 11384 RVA: 0x00044014 File Offset: 0x00042214
		// (set) Token: 0x06002C79 RID: 11385 RVA: 0x00044057 File Offset: 0x00042257
		public FInputScaleBiasClamp RelaxationSpeedScaleInputProcessor
		{
			get
			{
				base.FastCheckIsValid();
				FInputScaleBiasClamp result;
				if ((result = this._RelaxationSpeedScaleInputProcessor) == null)
				{
					result = (this._RelaxationSpeedScaleInputProcessor = new FInputScaleBiasClamp(base.NativePtr + (IntPtr)FAnimNode_Trail.__PropertyOffset_RelaxationSpeedScaleInputProcessor, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FInputScaleBiasClamp.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_Trail.__PropertyOffset_RelaxationSpeedScaleInputProcessor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000B03 RID: 2819
		// (get) Token: 0x06002C7A RID: 11386 RVA: 0x00044078 File Offset: 0x00042278
		// (set) Token: 0x06002C7B RID: 11387 RVA: 0x000440BB File Offset: 0x000422BB
		public TArray<FRotationLimit> RotationLimits
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FRotationLimit> result;
				if ((result = this._RotationLimits) == null)
				{
					result = (this._RotationLimits = new TArray<FRotationLimit>(base.NativePtr + (IntPtr)FAnimNode_Trail.__PropertyOffset_RotationLimits, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.RotationLimits.CopyAssign(value);
			}
		}

		// Token: 0x17000B04 RID: 2820
		// (get) Token: 0x06002C7C RID: 11388 RVA: 0x000440CC File Offset: 0x000422CC
		// (set) Token: 0x06002C7D RID: 11389 RVA: 0x0004410F File Offset: 0x0004230F
		public TArray<FVector> RotationOffsets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._RotationOffsets) == null)
				{
					result = (this._RotationOffsets = new TArray<FVector>(base.NativePtr + (IntPtr)FAnimNode_Trail.__PropertyOffset_RotationOffsets, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.RotationOffsets.CopyAssign(value);
			}
		}

		// Token: 0x17000B05 RID: 2821
		// (get) Token: 0x06002C7E RID: 11390 RVA: 0x00044120 File Offset: 0x00042320
		// (set) Token: 0x06002C7F RID: 11391 RVA: 0x00044163 File Offset: 0x00042363
		public TArray<FAnimPhysPlanarLimit> PlanarLimits
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FAnimPhysPlanarLimit> result;
				if ((result = this._PlanarLimits) == null)
				{
					result = (this._PlanarLimits = new TArray<FAnimPhysPlanarLimit>(base.NativePtr + (IntPtr)FAnimNode_Trail.__PropertyOffset_PlanarLimits, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.PlanarLimits.CopyAssign(value);
			}
		}

		// Token: 0x17000B06 RID: 2822
		// (get) Token: 0x06002C80 RID: 11392 RVA: 0x00044171 File Offset: 0x00042371
		// (set) Token: 0x06002C81 RID: 11393 RVA: 0x00044181 File Offset: 0x00042381
		public unsafe float StretchLimit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_Trail.__PropertyOffset_StretchLimit);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_Trail.__PropertyOffset_StretchLimit) = value;
			}
		}

		// Token: 0x17000B07 RID: 2823
		// (get) Token: 0x06002C82 RID: 11394 RVA: 0x00044192 File Offset: 0x00042392
		// (set) Token: 0x06002C83 RID: 11395 RVA: 0x000441A6 File Offset: 0x000423A6
		public unsafe FVector FakeVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_Trail.__PropertyOffset_FakeVelocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_Trail.__PropertyOffset_FakeVelocity) = value;
			}
		}

		// Token: 0x17000B08 RID: 2824
		// (get) Token: 0x06002C84 RID: 11396 RVA: 0x000441BC File Offset: 0x000423BC
		// (set) Token: 0x06002C85 RID: 11397 RVA: 0x000441FF File Offset: 0x000423FF
		public FBoneReference BaseJoint
		{
			get
			{
				base.FastCheckIsValid();
				FBoneReference result;
				if ((result = this._BaseJoint) == null)
				{
					result = (this._BaseJoint = new FBoneReference(base.NativePtr + (IntPtr)FAnimNode_Trail.__PropertyOffset_BaseJoint, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneReference.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_Trail.__PropertyOffset_BaseJoint, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000B09 RID: 2825
		// (get) Token: 0x06002C86 RID: 11398 RVA: 0x00044220 File Offset: 0x00042420
		// (set) Token: 0x06002C87 RID: 11399 RVA: 0x00044230 File Offset: 0x00042430
		public unsafe float LastBoneRotationAnimAlphaBlend
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_Trail.__PropertyOffset_LastBoneRotationAnimAlphaBlend);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_Trail.__PropertyOffset_LastBoneRotationAnimAlphaBlend) = value;
			}
		}

		// Token: 0x06002C88 RID: 11400 RVA: 0x00044241 File Offset: 0x00042441
		public FAnimNode_Trail()
		{
		}

		// Token: 0x06002C89 RID: 11401 RVA: 0x0004424C File Offset: 0x0004244C
		public FAnimNode_Trail(FBoneReference TrailBone, int ChainLength, [Nullable(0)] TEnumAsByte<EAxis> ChainBoneAxis, bool bInvertChainBoneAxis, bool bLimitStretch, bool bLimitRotation, bool bUsePlanarLimit, bool bActorSpaceFakeVel, bool bReorientParentToChild, bool bEnableDebug, bool bShowBaseMotion, bool bShowTrailLocation, bool bShowLimit, float DebugLifeTime, float TrailRelaxation_DEPRECATED, float MaxDeltaTime, float RelaxationSpeedScale, FRuntimeFloatCurve TrailRelaxationSpeed, FInputScaleBiasClamp RelaxationSpeedScaleInputProcessor, TArray<FRotationLimit> RotationLimits, TArray<FVector> RotationOffsets, TArray<FAnimPhysPlanarLimit> PlanarLimits, float StretchLimit, FVector FakeVelocity, FBoneReference BaseJoint, float TrailBoneRotationBlendAlpha_DEPRECATED, float LastBoneRotationAnimAlphaBlend, FComponentSpacePoseLink ComponentPose, int LODThreshold, int KuroLODMask, float ActualAlpha, EAnimAlphaInputType AlphaInputType, bool bAlphaBoolEnabled, bool bParallelEvalEnabled, bool bEnableOnMobile, float Alpha, FInputScaleBias AlphaScaleBias, FInputAlphaBoolBlend AlphaBoolBlend, FName AlphaCurveName, FInputScaleBiasClamp AlphaScaleBiasClamp)
		{
			this.TrailBone = TrailBone;
			this.ChainLength = ChainLength;
			this.ChainBoneAxis = ChainBoneAxis;
			this.bInvertChainBoneAxis = bInvertChainBoneAxis;
			this.bLimitStretch = bLimitStretch;
			this.bLimitRotation = bLimitRotation;
			this.bUsePlanarLimit = bUsePlanarLimit;
			this.bActorSpaceFakeVel = bActorSpaceFakeVel;
			this.bReorientParentToChild = bReorientParentToChild;
			this.MaxDeltaTime = MaxDeltaTime;
			this.RelaxationSpeedScale = RelaxationSpeedScale;
			this.TrailRelaxationSpeed = TrailRelaxationSpeed;
			this.RelaxationSpeedScaleInputProcessor = RelaxationSpeedScaleInputProcessor;
			this.RotationLimits = RotationLimits;
			this.RotationOffsets = RotationOffsets;
			this.PlanarLimits = PlanarLimits;
			this.StretchLimit = StretchLimit;
			this.FakeVelocity = FakeVelocity;
			this.BaseJoint = BaseJoint;
			this.LastBoneRotationAnimAlphaBlend = LastBoneRotationAnimAlphaBlend;
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

		// Token: 0x06002C8A RID: 11402 RVA: 0x00044364 File Offset: 0x00042564
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_Trail.StaticStruct();
		}

		// Token: 0x06002C8B RID: 11403 RVA: 0x00044370 File Offset: 0x00042570
		[NullableContext(2)]
		public FAnimNode_Trail(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002C8C RID: 11404 RVA: 0x0004437A File Offset: 0x0004257A
		public FAnimNode_Trail(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002C8D RID: 11405 RVA: 0x00044385 File Offset: 0x00042585
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_Trail(Pointer, false, true);
		}

		// Token: 0x06002C8E RID: 11406 RVA: 0x0004438F File Offset: 0x0004258F
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_Trail(Pointer, MemoryOwner);
		}

		// Token: 0x0400122D RID: 4653
		public new const string __ObjectPath = "/Script/AnimGraphRuntime.AnimNode_Trail";

		// Token: 0x0400122E RID: 4654
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400122F RID: 4655
		internal static int __PropertyOffset_TrailBone;

		// Token: 0x04001230 RID: 4656
		[Nullable(2)]
		private FBoneReference _TrailBone;

		// Token: 0x04001231 RID: 4657
		internal static int __PropertyOffset_ChainLength;

		// Token: 0x04001232 RID: 4658
		internal static int __PropertyOffset_ChainBoneAxis;

		// Token: 0x04001233 RID: 4659
		internal static int __PropertyOffset_bInvertChainBoneAxis;

		// Token: 0x04001234 RID: 4660
		internal static byte __PropertyMask_bInvertChainBoneAxis;

		// Token: 0x04001235 RID: 4661
		internal static int __PropertyOffset_bLimitStretch;

		// Token: 0x04001236 RID: 4662
		internal static byte __PropertyMask_bLimitStretch;

		// Token: 0x04001237 RID: 4663
		internal static int __PropertyOffset_bLimitRotation;

		// Token: 0x04001238 RID: 4664
		internal static byte __PropertyMask_bLimitRotation;

		// Token: 0x04001239 RID: 4665
		internal static int __PropertyOffset_bUsePlanarLimit;

		// Token: 0x0400123A RID: 4666
		internal static byte __PropertyMask_bUsePlanarLimit;

		// Token: 0x0400123B RID: 4667
		internal static int __PropertyOffset_bActorSpaceFakeVel;

		// Token: 0x0400123C RID: 4668
		internal static byte __PropertyMask_bActorSpaceFakeVel;

		// Token: 0x0400123D RID: 4669
		internal static int __PropertyOffset_bReorientParentToChild;

		// Token: 0x0400123E RID: 4670
		internal static byte __PropertyMask_bReorientParentToChild;

		// Token: 0x0400123F RID: 4671
		internal static int __PropertyOffset_MaxDeltaTime;

		// Token: 0x04001240 RID: 4672
		internal static int __PropertyOffset_RelaxationSpeedScale;

		// Token: 0x04001241 RID: 4673
		internal static int __PropertyOffset_TrailRelaxationSpeed;

		// Token: 0x04001242 RID: 4674
		[Nullable(2)]
		private FRuntimeFloatCurve _TrailRelaxationSpeed;

		// Token: 0x04001243 RID: 4675
		internal static int __PropertyOffset_RelaxationSpeedScaleInputProcessor;

		// Token: 0x04001244 RID: 4676
		[Nullable(2)]
		private FInputScaleBiasClamp _RelaxationSpeedScaleInputProcessor;

		// Token: 0x04001245 RID: 4677
		internal static int __PropertyOffset_RotationLimits;

		// Token: 0x04001246 RID: 4678
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FRotationLimit> _RotationLimits;

		// Token: 0x04001247 RID: 4679
		internal static int __PropertyOffset_RotationOffsets;

		// Token: 0x04001248 RID: 4680
		[Nullable(2)]
		private TArray<FVector> _RotationOffsets;

		// Token: 0x04001249 RID: 4681
		internal static int __PropertyOffset_PlanarLimits;

		// Token: 0x0400124A RID: 4682
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FAnimPhysPlanarLimit> _PlanarLimits;

		// Token: 0x0400124B RID: 4683
		internal static int __PropertyOffset_StretchLimit;

		// Token: 0x0400124C RID: 4684
		internal static int __PropertyOffset_FakeVelocity;

		// Token: 0x0400124D RID: 4685
		internal static int __PropertyOffset_BaseJoint;

		// Token: 0x0400124E RID: 4686
		[Nullable(2)]
		private FBoneReference _BaseJoint;

		// Token: 0x0400124F RID: 4687
		internal static int __PropertyOffset_LastBoneRotationAnimAlphaBlend;
	}
}
