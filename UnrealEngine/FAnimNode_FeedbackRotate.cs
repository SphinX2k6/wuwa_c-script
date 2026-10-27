using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200160B RID: 5643
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.AnimNode_FeedbackRotate")]
	[UnrealStructLayout(904, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 904)]
	public class FAnimNode_FeedbackRotate : FAnimNode_SkeletalControlBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060145AE RID: 83374 RVA: 0x001DE945 File Offset: 0x001DCB45
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_FeedbackRotate._ScriptStructPtr != 0) ? FAnimNode_FeedbackRotate._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.AnimNode_FeedbackRotate", ref FAnimNode_FeedbackRotate._ScriptStructPtr);
		}

		// Token: 0x17004FED RID: 20461
		// (get) Token: 0x060145AF RID: 83375 RVA: 0x001DE96C File Offset: 0x001DCB6C
		// (set) Token: 0x060145B0 RID: 83376 RVA: 0x001DE9AF File Offset: 0x001DCBAF
		public TArray<FBoneReference> BeginBones
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBoneReference> result;
				if ((result = this._BeginBones) == null)
				{
					result = (this._BeginBones = new TArray<FBoneReference>(base.NativePtr + (IntPtr)FAnimNode_FeedbackRotate.__PropertyOffset_BeginBones, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BeginBones.CopyAssign(value);
			}
		}

		// Token: 0x17004FEE RID: 20462
		// (get) Token: 0x060145B1 RID: 83377 RVA: 0x001DE9C0 File Offset: 0x001DCBC0
		// (set) Token: 0x060145B2 RID: 83378 RVA: 0x001DEA03 File Offset: 0x001DCC03
		public TArray<FBoneReference> EndBones
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBoneReference> result;
				if ((result = this._EndBones) == null)
				{
					result = (this._EndBones = new TArray<FBoneReference>(base.NativePtr + (IntPtr)FAnimNode_FeedbackRotate.__PropertyOffset_EndBones, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.EndBones.CopyAssign(value);
			}
		}

		// Token: 0x17004FEF RID: 20463
		// (get) Token: 0x060145B3 RID: 83379 RVA: 0x001DEA14 File Offset: 0x001DCC14
		// (set) Token: 0x060145B4 RID: 83380 RVA: 0x001DEA57 File Offset: 0x001DCC57
		public TArray<FBoneReference> WeakenBones
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBoneReference> result;
				if ((result = this._WeakenBones) == null)
				{
					result = (this._WeakenBones = new TArray<FBoneReference>(base.NativePtr + (IntPtr)FAnimNode_FeedbackRotate.__PropertyOffset_WeakenBones, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.WeakenBones.CopyAssign(value);
			}
		}

		// Token: 0x17004FF0 RID: 20464
		// (get) Token: 0x060145B5 RID: 83381 RVA: 0x001DEA68 File Offset: 0x001DCC68
		// (set) Token: 0x060145B6 RID: 83382 RVA: 0x001DEAAB File Offset: 0x001DCCAB
		public FBoneReference RootBone
		{
			get
			{
				base.FastCheckIsValid();
				FBoneReference result;
				if ((result = this._RootBone) == null)
				{
					result = (this._RootBone = new FBoneReference(base.NativePtr + (IntPtr)FAnimNode_FeedbackRotate.__PropertyOffset_RootBone, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneReference.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_FeedbackRotate.__PropertyOffset_RootBone, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004FF1 RID: 20465
		// (get) Token: 0x060145B7 RID: 83383 RVA: 0x001DEACC File Offset: 0x001DCCCC
		// (set) Token: 0x060145B8 RID: 83384 RVA: 0x001DEADC File Offset: 0x001DCCDC
		public unsafe float MaxTurnAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_FeedbackRotate.__PropertyOffset_MaxTurnAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_FeedbackRotate.__PropertyOffset_MaxTurnAngle) = value;
			}
		}

		// Token: 0x17004FF2 RID: 20466
		// (get) Token: 0x060145B9 RID: 83385 RVA: 0x001DEAED File Offset: 0x001DCCED
		// (set) Token: 0x060145BA RID: 83386 RVA: 0x001DEAFD File Offset: 0x001DCCFD
		public unsafe float Weaken
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_FeedbackRotate.__PropertyOffset_Weaken);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_FeedbackRotate.__PropertyOffset_Weaken) = value;
			}
		}

		// Token: 0x17004FF3 RID: 20467
		// (get) Token: 0x060145BB RID: 83387 RVA: 0x001DEB0E File Offset: 0x001DCD0E
		// (set) Token: 0x060145BC RID: 83388 RVA: 0x001DEB1E File Offset: 0x001DCD1E
		public unsafe float RecoveryWeaken
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_FeedbackRotate.__PropertyOffset_RecoveryWeaken);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_FeedbackRotate.__PropertyOffset_RecoveryWeaken) = value;
			}
		}

		// Token: 0x17004FF4 RID: 20468
		// (get) Token: 0x060145BD RID: 83389 RVA: 0x001DEB2F File Offset: 0x001DCD2F
		// (set) Token: 0x060145BE RID: 83390 RVA: 0x001DEB3F File Offset: 0x001DCD3F
		public unsafe float MinDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_FeedbackRotate.__PropertyOffset_MinDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_FeedbackRotate.__PropertyOffset_MinDistance) = value;
			}
		}

		// Token: 0x17004FF5 RID: 20469
		// (get) Token: 0x060145BF RID: 83391 RVA: 0x001DEB50 File Offset: 0x001DCD50
		// (set) Token: 0x060145C0 RID: 83392 RVA: 0x001DEB60 File Offset: 0x001DCD60
		public unsafe float MaxDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_FeedbackRotate.__PropertyOffset_MaxDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_FeedbackRotate.__PropertyOffset_MaxDistance) = value;
			}
		}

		// Token: 0x17004FF6 RID: 20470
		// (get) Token: 0x060145C1 RID: 83393 RVA: 0x001DEB71 File Offset: 0x001DCD71
		// (set) Token: 0x060145C2 RID: 83394 RVA: 0x001DEB81 File Offset: 0x001DCD81
		public unsafe float AnimChangeOptizimeParameter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_FeedbackRotate.__PropertyOffset_AnimChangeOptizimeParameter);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_FeedbackRotate.__PropertyOffset_AnimChangeOptizimeParameter) = value;
			}
		}

		// Token: 0x17004FF7 RID: 20471
		// (get) Token: 0x060145C3 RID: 83395 RVA: 0x001DEB92 File Offset: 0x001DCD92
		// (set) Token: 0x060145C4 RID: 83396 RVA: 0x001DEBA2 File Offset: 0x001DCDA2
		public unsafe bool NewHit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_FeedbackRotate.__PropertyOffset_NewHit) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_FeedbackRotate.__PropertyOffset_NewHit) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004FF8 RID: 20472
		// (get) Token: 0x060145C5 RID: 83397 RVA: 0x001DEBB3 File Offset: 0x001DCDB3
		// (set) Token: 0x060145C6 RID: 83398 RVA: 0x001DEBC7 File Offset: 0x001DCDC7
		public unsafe FVector HitPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_FeedbackRotate.__PropertyOffset_HitPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_FeedbackRotate.__PropertyOffset_HitPos) = value;
			}
		}

		// Token: 0x17004FF9 RID: 20473
		// (get) Token: 0x060145C7 RID: 83399 RVA: 0x001DEBDC File Offset: 0x001DCDDC
		// (set) Token: 0x060145C8 RID: 83400 RVA: 0x001DEBF0 File Offset: 0x001DCDF0
		public unsafe FVector HitVector
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_FeedbackRotate.__PropertyOffset_HitVector);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_FeedbackRotate.__PropertyOffset_HitVector) = value;
			}
		}

		// Token: 0x17004FFA RID: 20474
		// (get) Token: 0x060145C9 RID: 83401 RVA: 0x001DEC05 File Offset: 0x001DCE05
		// (set) Token: 0x060145CA RID: 83402 RVA: 0x001DEC15 File Offset: 0x001DCE15
		public unsafe float FeedbackTimeLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_FeedbackRotate.__PropertyOffset_FeedbackTimeLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_FeedbackRotate.__PropertyOffset_FeedbackTimeLength) = value;
			}
		}

		// Token: 0x17004FFB RID: 20475
		// (get) Token: 0x060145CB RID: 83403 RVA: 0x001DEC26 File Offset: 0x001DCE26
		// (set) Token: 0x060145CC RID: 83404 RVA: 0x001DEC3A File Offset: 0x001DCE3A
		[Nullable(2)]
		public unsafe UCurveFloat Curve
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + FAnimNode_FeedbackRotate.__PropertyOffset_Curve);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FAnimNode_FeedbackRotate.__PropertyOffset_Curve, value);
			}
		}

		// Token: 0x060145CD RID: 83405 RVA: 0x001DEC4F File Offset: 0x001DCE4F
		public FAnimNode_FeedbackRotate()
		{
		}

		// Token: 0x060145CE RID: 83406 RVA: 0x001DEC58 File Offset: 0x001DCE58
		public FAnimNode_FeedbackRotate(TArray<FBoneReference> BeginBones, TArray<FBoneReference> EndBones, TArray<FBoneReference> WeakenBones, FBoneReference RootBone, float MaxTurnAngle, float Weaken, float RecoveryWeaken, float MinDistance, float MaxDistance, float AnimChangeOptizimeParameter, bool NewHit, FVector HitPos, FVector HitVector, float FeedbackTimeLength, UCurveFloat Curve, FComponentSpacePoseLink ComponentPose, int LODThreshold, int KuroLODMask, float ActualAlpha, EAnimAlphaInputType AlphaInputType, bool bAlphaBoolEnabled, bool bParallelEvalEnabled, bool bEnableOnMobile, float Alpha, FInputScaleBias AlphaScaleBias, FInputAlphaBoolBlend AlphaBoolBlend, FName AlphaCurveName, FInputScaleBiasClamp AlphaScaleBiasClamp)
		{
			this.BeginBones = BeginBones;
			this.EndBones = EndBones;
			this.WeakenBones = WeakenBones;
			this.RootBone = RootBone;
			this.MaxTurnAngle = MaxTurnAngle;
			this.Weaken = Weaken;
			this.RecoveryWeaken = RecoveryWeaken;
			this.MinDistance = MinDistance;
			this.MaxDistance = MaxDistance;
			this.AnimChangeOptizimeParameter = AnimChangeOptizimeParameter;
			this.NewHit = NewHit;
			this.HitPos = HitPos;
			this.HitVector = HitVector;
			this.FeedbackTimeLength = FeedbackTimeLength;
			this.Curve = Curve;
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

		// Token: 0x060145CF RID: 83407 RVA: 0x001DED48 File Offset: 0x001DCF48
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_FeedbackRotate.StaticStruct();
		}

		// Token: 0x060145D0 RID: 83408 RVA: 0x001DED54 File Offset: 0x001DCF54
		[NullableContext(2)]
		public FAnimNode_FeedbackRotate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060145D1 RID: 83409 RVA: 0x001DED5E File Offset: 0x001DCF5E
		public FAnimNode_FeedbackRotate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060145D2 RID: 83410 RVA: 0x001DED69 File Offset: 0x001DCF69
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_FeedbackRotate(Pointer, false, true);
		}

		// Token: 0x060145D3 RID: 83411 RVA: 0x001DED73 File Offset: 0x001DCF73
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_FeedbackRotate(Pointer, MemoryOwner);
		}

		// Token: 0x0400B139 RID: 45369
		public new const string __ObjectPath = "/Script/KuroAnim.AnimNode_FeedbackRotate";

		// Token: 0x0400B13A RID: 45370
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B13B RID: 45371
		internal static int __PropertyOffset_BeginBones;

		// Token: 0x0400B13C RID: 45372
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBoneReference> _BeginBones;

		// Token: 0x0400B13D RID: 45373
		internal static int __PropertyOffset_EndBones;

		// Token: 0x0400B13E RID: 45374
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBoneReference> _EndBones;

		// Token: 0x0400B13F RID: 45375
		internal static int __PropertyOffset_WeakenBones;

		// Token: 0x0400B140 RID: 45376
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBoneReference> _WeakenBones;

		// Token: 0x0400B141 RID: 45377
		internal static int __PropertyOffset_RootBone;

		// Token: 0x0400B142 RID: 45378
		[Nullable(2)]
		private FBoneReference _RootBone;

		// Token: 0x0400B143 RID: 45379
		internal static int __PropertyOffset_MaxTurnAngle;

		// Token: 0x0400B144 RID: 45380
		internal static int __PropertyOffset_Weaken;

		// Token: 0x0400B145 RID: 45381
		internal static int __PropertyOffset_RecoveryWeaken;

		// Token: 0x0400B146 RID: 45382
		internal static int __PropertyOffset_MinDistance;

		// Token: 0x0400B147 RID: 45383
		internal static int __PropertyOffset_MaxDistance;

		// Token: 0x0400B148 RID: 45384
		internal static int __PropertyOffset_AnimChangeOptizimeParameter;

		// Token: 0x0400B149 RID: 45385
		internal static int __PropertyOffset_NewHit;

		// Token: 0x0400B14A RID: 45386
		internal static int __PropertyOffset_HitPos;

		// Token: 0x0400B14B RID: 45387
		internal static int __PropertyOffset_HitVector;

		// Token: 0x0400B14C RID: 45388
		internal static int __PropertyOffset_FeedbackTimeLength;

		// Token: 0x0400B14D RID: 45389
		internal static int __PropertyOffset_Curve;
	}
}
