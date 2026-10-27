using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000305 RID: 773
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.AnimNode_TwoBoneIK")]
	[UnrealStructLayout(736, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 736)]
	public class FAnimNode_TwoBoneIK : FAnimNode_SkeletalControlBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002CA5 RID: 11429 RVA: 0x0004469C File Offset: 0x0004289C
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_TwoBoneIK._ScriptStructPtr != 0) ? FAnimNode_TwoBoneIK._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.AnimNode_TwoBoneIK", ref FAnimNode_TwoBoneIK._ScriptStructPtr);
		}

		// Token: 0x17000B11 RID: 2833
		// (get) Token: 0x06002CA6 RID: 11430 RVA: 0x000446C0 File Offset: 0x000428C0
		// (set) Token: 0x06002CA7 RID: 11431 RVA: 0x00044703 File Offset: 0x00042903
		public FBoneReference IKBone
		{
			get
			{
				base.FastCheckIsValid();
				FBoneReference result;
				if ((result = this._IKBone) == null)
				{
					result = (this._IKBone = new FBoneReference(base.NativePtr + (IntPtr)FAnimNode_TwoBoneIK.__PropertyOffset_IKBone, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneReference.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_TwoBoneIK.__PropertyOffset_IKBone, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000B12 RID: 2834
		// (get) Token: 0x06002CA8 RID: 11432 RVA: 0x00044724 File Offset: 0x00042924
		// (set) Token: 0x06002CA9 RID: 11433 RVA: 0x00044734 File Offset: 0x00042934
		public unsafe float StartStretchRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_TwoBoneIK.__PropertyOffset_StartStretchRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_TwoBoneIK.__PropertyOffset_StartStretchRatio) = value;
			}
		}

		// Token: 0x17000B13 RID: 2835
		// (get) Token: 0x06002CAA RID: 11434 RVA: 0x00044745 File Offset: 0x00042945
		// (set) Token: 0x06002CAB RID: 11435 RVA: 0x00044755 File Offset: 0x00042955
		public unsafe float MaxStretchScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_TwoBoneIK.__PropertyOffset_MaxStretchScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_TwoBoneIK.__PropertyOffset_MaxStretchScale) = value;
			}
		}

		// Token: 0x17000B14 RID: 2836
		// (get) Token: 0x06002CAC RID: 11436 RVA: 0x00044766 File Offset: 0x00042966
		// (set) Token: 0x06002CAD RID: 11437 RVA: 0x0004477A File Offset: 0x0004297A
		public unsafe FVector EffectorLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_TwoBoneIK.__PropertyOffset_EffectorLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_TwoBoneIK.__PropertyOffset_EffectorLocation) = value;
			}
		}

		// Token: 0x17000B15 RID: 2837
		// (get) Token: 0x06002CAE RID: 11438 RVA: 0x00044790 File Offset: 0x00042990
		// (set) Token: 0x06002CAF RID: 11439 RVA: 0x000447D3 File Offset: 0x000429D3
		public FBoneSocketTarget EffectorTarget
		{
			get
			{
				base.FastCheckIsValid();
				FBoneSocketTarget result;
				if ((result = this._EffectorTarget) == null)
				{
					result = (this._EffectorTarget = new FBoneSocketTarget(base.NativePtr + (IntPtr)FAnimNode_TwoBoneIK.__PropertyOffset_EffectorTarget, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneSocketTarget.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_TwoBoneIK.__PropertyOffset_EffectorTarget, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000B16 RID: 2838
		// (get) Token: 0x06002CB0 RID: 11440 RVA: 0x000447F4 File Offset: 0x000429F4
		// (set) Token: 0x06002CB1 RID: 11441 RVA: 0x00044808 File Offset: 0x00042A08
		public unsafe FVector JointTargetLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_TwoBoneIK.__PropertyOffset_JointTargetLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_TwoBoneIK.__PropertyOffset_JointTargetLocation) = value;
			}
		}

		// Token: 0x17000B17 RID: 2839
		// (get) Token: 0x06002CB2 RID: 11442 RVA: 0x00044820 File Offset: 0x00042A20
		// (set) Token: 0x06002CB3 RID: 11443 RVA: 0x00044863 File Offset: 0x00042A63
		public FBoneSocketTarget JointTarget
		{
			get
			{
				base.FastCheckIsValid();
				FBoneSocketTarget result;
				if ((result = this._JointTarget) == null)
				{
					result = (this._JointTarget = new FBoneSocketTarget(base.NativePtr + (IntPtr)FAnimNode_TwoBoneIK.__PropertyOffset_JointTarget, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneSocketTarget.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_TwoBoneIK.__PropertyOffset_JointTarget, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000B18 RID: 2840
		// (get) Token: 0x06002CB4 RID: 11444 RVA: 0x00044884 File Offset: 0x00042A84
		// (set) Token: 0x06002CB5 RID: 11445 RVA: 0x000448C7 File Offset: 0x00042AC7
		public FAxis TwistAxis
		{
			get
			{
				base.FastCheckIsValid();
				FAxis result;
				if ((result = this._TwistAxis) == null)
				{
					result = (this._TwistAxis = new FAxis(base.NativePtr + (IntPtr)FAnimNode_TwoBoneIK.__PropertyOffset_TwistAxis, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAxis.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_TwoBoneIK.__PropertyOffset_TwistAxis, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000B19 RID: 2841
		// (get) Token: 0x06002CB6 RID: 11446 RVA: 0x000448E8 File Offset: 0x00042AE8
		// (set) Token: 0x06002CB7 RID: 11447 RVA: 0x000448FC File Offset: 0x00042AFC
		[Nullable(0)]
		public unsafe TEnumAsByte<EBoneControlSpace> EffectorLocationSpace
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_TwoBoneIK.__PropertyOffset_EffectorLocationSpace);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_TwoBoneIK.__PropertyOffset_EffectorLocationSpace) = value;
			}
		}

		// Token: 0x17000B1A RID: 2842
		// (get) Token: 0x06002CB8 RID: 11448 RVA: 0x00044911 File Offset: 0x00042B11
		// (set) Token: 0x06002CB9 RID: 11449 RVA: 0x00044925 File Offset: 0x00042B25
		[Nullable(0)]
		public unsafe TEnumAsByte<EBoneControlSpace> JointTargetLocationSpace
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_TwoBoneIK.__PropertyOffset_JointTargetLocationSpace);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_TwoBoneIK.__PropertyOffset_JointTargetLocationSpace) = value;
			}
		}

		// Token: 0x17000B1B RID: 2843
		// (get) Token: 0x06002CBA RID: 11450 RVA: 0x0004493A File Offset: 0x00042B3A
		// (set) Token: 0x06002CBB RID: 11451 RVA: 0x00044953 File Offset: 0x00042B53
		public unsafe bool bAllowStretching
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FAnimNode_TwoBoneIK.__PropertyOffset_bAllowStretching) & FAnimNode_TwoBoneIK.__PropertyMask_bAllowStretching) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FAnimNode_TwoBoneIK.__PropertyOffset_bAllowStretching) = ((*(base.NativePtr + (IntPtr)FAnimNode_TwoBoneIK.__PropertyOffset_bAllowStretching) & ~FAnimNode_TwoBoneIK.__PropertyMask_bAllowStretching) | (value ? FAnimNode_TwoBoneIK.__PropertyMask_bAllowStretching : 0));
			}
		}

		// Token: 0x17000B1C RID: 2844
		// (get) Token: 0x06002CBC RID: 11452 RVA: 0x00044983 File Offset: 0x00042B83
		// (set) Token: 0x06002CBD RID: 11453 RVA: 0x0004499C File Offset: 0x00042B9C
		public unsafe bool bTakeRotationFromEffectorSpace
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FAnimNode_TwoBoneIK.__PropertyOffset_bTakeRotationFromEffectorSpace) & FAnimNode_TwoBoneIK.__PropertyMask_bTakeRotationFromEffectorSpace) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FAnimNode_TwoBoneIK.__PropertyOffset_bTakeRotationFromEffectorSpace) = ((*(base.NativePtr + (IntPtr)FAnimNode_TwoBoneIK.__PropertyOffset_bTakeRotationFromEffectorSpace) & ~FAnimNode_TwoBoneIK.__PropertyMask_bTakeRotationFromEffectorSpace) | (value ? FAnimNode_TwoBoneIK.__PropertyMask_bTakeRotationFromEffectorSpace : 0));
			}
		}

		// Token: 0x17000B1D RID: 2845
		// (get) Token: 0x06002CBE RID: 11454 RVA: 0x000449CC File Offset: 0x00042BCC
		// (set) Token: 0x06002CBF RID: 11455 RVA: 0x000449E5 File Offset: 0x00042BE5
		public unsafe bool bMaintainEffectorRelRot
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FAnimNode_TwoBoneIK.__PropertyOffset_bMaintainEffectorRelRot) & FAnimNode_TwoBoneIK.__PropertyMask_bMaintainEffectorRelRot) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FAnimNode_TwoBoneIK.__PropertyOffset_bMaintainEffectorRelRot) = ((*(base.NativePtr + (IntPtr)FAnimNode_TwoBoneIK.__PropertyOffset_bMaintainEffectorRelRot) & ~FAnimNode_TwoBoneIK.__PropertyMask_bMaintainEffectorRelRot) | (value ? FAnimNode_TwoBoneIK.__PropertyMask_bMaintainEffectorRelRot : 0));
			}
		}

		// Token: 0x17000B1E RID: 2846
		// (get) Token: 0x06002CC0 RID: 11456 RVA: 0x00044A15 File Offset: 0x00042C15
		// (set) Token: 0x06002CC1 RID: 11457 RVA: 0x00044A2E File Offset: 0x00042C2E
		public unsafe bool bAllowTwist
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FAnimNode_TwoBoneIK.__PropertyOffset_bAllowTwist) & FAnimNode_TwoBoneIK.__PropertyMask_bAllowTwist) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FAnimNode_TwoBoneIK.__PropertyOffset_bAllowTwist) = ((*(base.NativePtr + (IntPtr)FAnimNode_TwoBoneIK.__PropertyOffset_bAllowTwist) & ~FAnimNode_TwoBoneIK.__PropertyMask_bAllowTwist) | (value ? FAnimNode_TwoBoneIK.__PropertyMask_bAllowTwist : 0));
			}
		}

		// Token: 0x06002CC2 RID: 11458 RVA: 0x00044A5E File Offset: 0x00042C5E
		public FAnimNode_TwoBoneIK()
		{
		}

		// Token: 0x06002CC3 RID: 11459 RVA: 0x00044A68 File Offset: 0x00042C68
		public FAnimNode_TwoBoneIK(FBoneReference IKBone, float StartStretchRatio, float MaxStretchScale, FVector2D StretchLimits_DEPRECATED, bool bNoTwist_DEPRECATED, FName JointTargetSpaceBoneName_DEPRECATED, FName EffectorSpaceBoneName_DEPRECATED, FVector EffectorLocation, FBoneSocketTarget EffectorTarget, FVector JointTargetLocation, FBoneSocketTarget JointTarget, FAxis TwistAxis, [Nullable(0)] TEnumAsByte<EBoneControlSpace> EffectorLocationSpace, [Nullable(0)] TEnumAsByte<EBoneControlSpace> JointTargetLocationSpace, bool bAllowStretching, bool bTakeRotationFromEffectorSpace, bool bMaintainEffectorRelRot, bool bAllowTwist, FComponentSpacePoseLink ComponentPose, int LODThreshold, int KuroLODMask, float ActualAlpha, EAnimAlphaInputType AlphaInputType, bool bAlphaBoolEnabled, bool bParallelEvalEnabled, bool bEnableOnMobile, float Alpha, FInputScaleBias AlphaScaleBias, FInputAlphaBoolBlend AlphaBoolBlend, FName AlphaCurveName, FInputScaleBiasClamp AlphaScaleBiasClamp)
		{
			this.IKBone = IKBone;
			this.StartStretchRatio = StartStretchRatio;
			this.MaxStretchScale = MaxStretchScale;
			this.EffectorLocation = EffectorLocation;
			this.EffectorTarget = EffectorTarget;
			this.JointTargetLocation = JointTargetLocation;
			this.JointTarget = JointTarget;
			this.TwistAxis = TwistAxis;
			this.EffectorLocationSpace = EffectorLocationSpace;
			this.JointTargetLocationSpace = JointTargetLocationSpace;
			this.bAllowStretching = bAllowStretching;
			this.bTakeRotationFromEffectorSpace = bTakeRotationFromEffectorSpace;
			this.bMaintainEffectorRelRot = bMaintainEffectorRelRot;
			this.bAllowTwist = bAllowTwist;
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

		// Token: 0x06002CC4 RID: 11460 RVA: 0x00044B50 File Offset: 0x00042D50
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_TwoBoneIK.StaticStruct();
		}

		// Token: 0x06002CC5 RID: 11461 RVA: 0x00044B5C File Offset: 0x00042D5C
		[NullableContext(2)]
		public FAnimNode_TwoBoneIK(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002CC6 RID: 11462 RVA: 0x00044B66 File Offset: 0x00042D66
		public FAnimNode_TwoBoneIK(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002CC7 RID: 11463 RVA: 0x00044B71 File Offset: 0x00042D71
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_TwoBoneIK(Pointer, false, true);
		}

		// Token: 0x06002CC8 RID: 11464 RVA: 0x00044B7B File Offset: 0x00042D7B
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_TwoBoneIK(Pointer, MemoryOwner);
		}

		// Token: 0x0400125D RID: 4701
		public new const string __ObjectPath = "/Script/AnimGraphRuntime.AnimNode_TwoBoneIK";

		// Token: 0x0400125E RID: 4702
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400125F RID: 4703
		internal static int __PropertyOffset_IKBone;

		// Token: 0x04001260 RID: 4704
		[Nullable(2)]
		private FBoneReference _IKBone;

		// Token: 0x04001261 RID: 4705
		internal static int __PropertyOffset_StartStretchRatio;

		// Token: 0x04001262 RID: 4706
		internal static int __PropertyOffset_MaxStretchScale;

		// Token: 0x04001263 RID: 4707
		internal static int __PropertyOffset_EffectorLocation;

		// Token: 0x04001264 RID: 4708
		internal static int __PropertyOffset_EffectorTarget;

		// Token: 0x04001265 RID: 4709
		[Nullable(2)]
		private FBoneSocketTarget _EffectorTarget;

		// Token: 0x04001266 RID: 4710
		internal static int __PropertyOffset_JointTargetLocation;

		// Token: 0x04001267 RID: 4711
		internal static int __PropertyOffset_JointTarget;

		// Token: 0x04001268 RID: 4712
		[Nullable(2)]
		private FBoneSocketTarget _JointTarget;

		// Token: 0x04001269 RID: 4713
		internal static int __PropertyOffset_TwistAxis;

		// Token: 0x0400126A RID: 4714
		[Nullable(2)]
		private FAxis _TwistAxis;

		// Token: 0x0400126B RID: 4715
		internal static int __PropertyOffset_EffectorLocationSpace;

		// Token: 0x0400126C RID: 4716
		internal static int __PropertyOffset_JointTargetLocationSpace;

		// Token: 0x0400126D RID: 4717
		internal static int __PropertyOffset_bAllowStretching;

		// Token: 0x0400126E RID: 4718
		internal static byte __PropertyMask_bAllowStretching;

		// Token: 0x0400126F RID: 4719
		internal static int __PropertyOffset_bTakeRotationFromEffectorSpace;

		// Token: 0x04001270 RID: 4720
		internal static byte __PropertyMask_bTakeRotationFromEffectorSpace;

		// Token: 0x04001271 RID: 4721
		internal static int __PropertyOffset_bMaintainEffectorRelRot;

		// Token: 0x04001272 RID: 4722
		internal static byte __PropertyMask_bMaintainEffectorRelRot;

		// Token: 0x04001273 RID: 4723
		internal static int __PropertyOffset_bAllowTwist;

		// Token: 0x04001274 RID: 4724
		internal static byte __PropertyMask_bAllowTwist;
	}
}
