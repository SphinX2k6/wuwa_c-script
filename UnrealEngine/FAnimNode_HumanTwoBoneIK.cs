using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200160D RID: 5645
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.AnimNode_HumanTwoBoneIK")]
	[UnrealStructLayout(576, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 576)]
	public class FAnimNode_HumanTwoBoneIK : FAnimNode_SkeletalControlBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060145E2 RID: 83426 RVA: 0x001DEF02 File Offset: 0x001DD102
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_HumanTwoBoneIK._ScriptStructPtr != 0) ? FAnimNode_HumanTwoBoneIK._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.AnimNode_HumanTwoBoneIK", ref FAnimNode_HumanTwoBoneIK._ScriptStructPtr);
		}

		// Token: 0x17004FFF RID: 20479
		// (get) Token: 0x060145E3 RID: 83427 RVA: 0x001DEF28 File Offset: 0x001DD128
		// (set) Token: 0x060145E4 RID: 83428 RVA: 0x001DEF6B File Offset: 0x001DD16B
		public FBoneReference IKBone
		{
			get
			{
				base.FastCheckIsValid();
				FBoneReference result;
				if ((result = this._IKBone) == null)
				{
					result = (this._IKBone = new FBoneReference(base.NativePtr + (IntPtr)FAnimNode_HumanTwoBoneIK.__PropertyOffset_IKBone, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneReference.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_HumanTwoBoneIK.__PropertyOffset_IKBone, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005000 RID: 20480
		// (get) Token: 0x060145E5 RID: 83429 RVA: 0x001DEF8C File Offset: 0x001DD18C
		// (set) Token: 0x060145E6 RID: 83430 RVA: 0x001DEF9C File Offset: 0x001DD19C
		public unsafe KuroAnimIKMode bMode
		{
			get
			{
				return (KuroAnimIKMode)(*(base.NativePtr + (IntPtr)FAnimNode_HumanTwoBoneIK.__PropertyOffset_bMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_HumanTwoBoneIK.__PropertyOffset_bMode) = (byte)value;
			}
		}

		// Token: 0x17005001 RID: 20481
		// (get) Token: 0x060145E7 RID: 83431 RVA: 0x001DEFAD File Offset: 0x001DD1AD
		// (set) Token: 0x060145E8 RID: 83432 RVA: 0x001DEFC1 File Offset: 0x001DD1C1
		public unsafe FName BaseAngleCurveName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_HumanTwoBoneIK.__PropertyOffset_BaseAngleCurveName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_HumanTwoBoneIK.__PropertyOffset_BaseAngleCurveName) = value;
			}
		}

		// Token: 0x17005002 RID: 20482
		// (get) Token: 0x060145E9 RID: 83433 RVA: 0x001DEFD6 File Offset: 0x001DD1D6
		// (set) Token: 0x060145EA RID: 83434 RVA: 0x001DEFEA File Offset: 0x001DD1EA
		public unsafe string LocationCurveName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAnimNode_HumanTwoBoneIK.__PropertyOffset_LocationCurveName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAnimNode_HumanTwoBoneIK.__PropertyOffset_LocationCurveName)), value);
			}
		}

		// Token: 0x17005003 RID: 20483
		// (get) Token: 0x060145EB RID: 83435 RVA: 0x001DEFFF File Offset: 0x001DD1FF
		// (set) Token: 0x060145EC RID: 83436 RVA: 0x001DF013 File Offset: 0x001DD213
		public unsafe FVector IKLocalPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_HumanTwoBoneIK.__PropertyOffset_IKLocalPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_HumanTwoBoneIK.__PropertyOffset_IKLocalPos) = value;
			}
		}

		// Token: 0x17005004 RID: 20484
		// (get) Token: 0x060145ED RID: 83437 RVA: 0x001DF028 File Offset: 0x001DD228
		// (set) Token: 0x060145EE RID: 83438 RVA: 0x001DF06C File Offset: 0x001DD26C
		public TFixedArray<float> LowerLimit
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<float> result;
				if ((result = this._LowerLimit) == null)
				{
					result = (this._LowerLimit = new TFixedArray<float>(base.NativePtr + (IntPtr)FAnimNode_HumanTwoBoneIK.__PropertyOffset_LowerLimit, 2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.LowerLimit.CopyAssign(value);
			}
		}

		// Token: 0x17005005 RID: 20485
		// (get) Token: 0x060145EF RID: 83439 RVA: 0x001DF07A File Offset: 0x001DD27A
		// (set) Token: 0x060145F0 RID: 83440 RVA: 0x001DF08E File Offset: 0x001DD28E
		public unsafe FVector OffsetOrTargetPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_HumanTwoBoneIK.__PropertyOffset_OffsetOrTargetPosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_HumanTwoBoneIK.__PropertyOffset_OffsetOrTargetPosition) = value;
			}
		}

		// Token: 0x17005006 RID: 20486
		// (get) Token: 0x060145F1 RID: 83441 RVA: 0x001DF0A3 File Offset: 0x001DD2A3
		// (set) Token: 0x060145F2 RID: 83442 RVA: 0x001DF0B3 File Offset: 0x001DD2B3
		public unsafe EndBoneIKMode bEndBoneMode
		{
			get
			{
				return (EndBoneIKMode)(*(base.NativePtr + (IntPtr)FAnimNode_HumanTwoBoneIK.__PropertyOffset_bEndBoneMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_HumanTwoBoneIK.__PropertyOffset_bEndBoneMode) = (byte)value;
			}
		}

		// Token: 0x17005007 RID: 20487
		// (get) Token: 0x060145F3 RID: 83443 RVA: 0x001DF0C4 File Offset: 0x001DD2C4
		// (set) Token: 0x060145F4 RID: 83444 RVA: 0x001DF0D8 File Offset: 0x001DD2D8
		public unsafe FVector EndBoneBaseAxis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_HumanTwoBoneIK.__PropertyOffset_EndBoneBaseAxis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_HumanTwoBoneIK.__PropertyOffset_EndBoneBaseAxis) = value;
			}
		}

		// Token: 0x17005008 RID: 20488
		// (get) Token: 0x060145F5 RID: 83445 RVA: 0x001DF0ED File Offset: 0x001DD2ED
		// (set) Token: 0x060145F6 RID: 83446 RVA: 0x001DF101 File Offset: 0x001DD301
		public unsafe FVector EndBoneTargetAxis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_HumanTwoBoneIK.__PropertyOffset_EndBoneTargetAxis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_HumanTwoBoneIK.__PropertyOffset_EndBoneTargetAxis) = value;
			}
		}

		// Token: 0x17005009 RID: 20489
		// (get) Token: 0x060145F7 RID: 83447 RVA: 0x001DF116 File Offset: 0x001DD316
		// (set) Token: 0x060145F8 RID: 83448 RVA: 0x001DF12A File Offset: 0x001DD32A
		public unsafe FQuat EndBoneTargetRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_HumanTwoBoneIK.__PropertyOffset_EndBoneTargetRotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_HumanTwoBoneIK.__PropertyOffset_EndBoneTargetRotation) = value;
			}
		}

		// Token: 0x1700500A RID: 20490
		// (get) Token: 0x060145F9 RID: 83449 RVA: 0x001DF140 File Offset: 0x001DD340
		// (set) Token: 0x060145FA RID: 83450 RVA: 0x001DF184 File Offset: 0x001DD384
		public TFixedArray<float> EndBoneLimit
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<float> result;
				if ((result = this._EndBoneLimit) == null)
				{
					result = (this._EndBoneLimit = new TFixedArray<float>(base.NativePtr + (IntPtr)FAnimNode_HumanTwoBoneIK.__PropertyOffset_EndBoneLimit, 6, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.EndBoneLimit.CopyAssign(value);
			}
		}

		// Token: 0x060145FB RID: 83451 RVA: 0x001DF192 File Offset: 0x001DD392
		public FAnimNode_HumanTwoBoneIK()
		{
		}

		// Token: 0x060145FC RID: 83452 RVA: 0x001DF19C File Offset: 0x001DD39C
		public FAnimNode_HumanTwoBoneIK(FBoneReference IKBone, KuroAnimIKMode bMode, FName BaseAngleCurveName, string LocationCurveName, FVector IKLocalPos, TFixedArray<float> LowerLimit, FVector OffsetOrTargetPosition, EndBoneIKMode bEndBoneMode, FVector EndBoneBaseAxis, FVector EndBoneTargetAxis, FQuat EndBoneTargetRotation, TFixedArray<float> EndBoneLimit, FComponentSpacePoseLink ComponentPose, int LODThreshold, int KuroLODMask, float ActualAlpha, EAnimAlphaInputType AlphaInputType, bool bAlphaBoolEnabled, bool bParallelEvalEnabled, bool bEnableOnMobile, float Alpha, FInputScaleBias AlphaScaleBias, FInputAlphaBoolBlend AlphaBoolBlend, FName AlphaCurveName, FInputScaleBiasClamp AlphaScaleBiasClamp)
		{
			this.IKBone = IKBone;
			this.bMode = bMode;
			this.BaseAngleCurveName = BaseAngleCurveName;
			this.LocationCurveName = LocationCurveName;
			this.IKLocalPos = IKLocalPos;
			this.LowerLimit = LowerLimit;
			this.OffsetOrTargetPosition = OffsetOrTargetPosition;
			this.bEndBoneMode = bEndBoneMode;
			this.EndBoneBaseAxis = EndBoneBaseAxis;
			this.EndBoneTargetAxis = EndBoneTargetAxis;
			this.EndBoneTargetRotation = EndBoneTargetRotation;
			this.EndBoneLimit = EndBoneLimit;
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

		// Token: 0x060145FD RID: 83453 RVA: 0x001DF274 File Offset: 0x001DD474
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_HumanTwoBoneIK.StaticStruct();
		}

		// Token: 0x060145FE RID: 83454 RVA: 0x001DF280 File Offset: 0x001DD480
		[NullableContext(2)]
		public FAnimNode_HumanTwoBoneIK(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060145FF RID: 83455 RVA: 0x001DF28A File Offset: 0x001DD48A
		public FAnimNode_HumanTwoBoneIK(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06014600 RID: 83456 RVA: 0x001DF295 File Offset: 0x001DD495
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_HumanTwoBoneIK(Pointer, false, true);
		}

		// Token: 0x06014601 RID: 83457 RVA: 0x001DF29F File Offset: 0x001DD49F
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_HumanTwoBoneIK(Pointer, MemoryOwner);
		}

		// Token: 0x0400B156 RID: 45398
		public new const string __ObjectPath = "/Script/KuroAnim.AnimNode_HumanTwoBoneIK";

		// Token: 0x0400B157 RID: 45399
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B158 RID: 45400
		internal static int __PropertyOffset_IKBone;

		// Token: 0x0400B159 RID: 45401
		[Nullable(2)]
		private FBoneReference _IKBone;

		// Token: 0x0400B15A RID: 45402
		internal static int __PropertyOffset_bMode;

		// Token: 0x0400B15B RID: 45403
		internal static int __PropertyOffset_BaseAngleCurveName;

		// Token: 0x0400B15C RID: 45404
		internal static int __PropertyOffset_LocationCurveName;

		// Token: 0x0400B15D RID: 45405
		internal static int __PropertyOffset_IKLocalPos;

		// Token: 0x0400B15E RID: 45406
		internal static int __PropertyOffset_LowerLimit;

		// Token: 0x0400B15F RID: 45407
		[Nullable(2)]
		private TFixedArray<float> _LowerLimit;

		// Token: 0x0400B160 RID: 45408
		internal static int __PropertyOffset_OffsetOrTargetPosition;

		// Token: 0x0400B161 RID: 45409
		internal static int __PropertyOffset_bEndBoneMode;

		// Token: 0x0400B162 RID: 45410
		internal static int __PropertyOffset_EndBoneBaseAxis;

		// Token: 0x0400B163 RID: 45411
		internal static int __PropertyOffset_EndBoneTargetAxis;

		// Token: 0x0400B164 RID: 45412
		internal static int __PropertyOffset_EndBoneTargetRotation;

		// Token: 0x0400B165 RID: 45413
		internal static int __PropertyOffset_EndBoneLimit;

		// Token: 0x0400B166 RID: 45414
		[Nullable(2)]
		private TFixedArray<float> _EndBoneLimit;
	}
}
