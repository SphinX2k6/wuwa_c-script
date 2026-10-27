using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002E5 RID: 741
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.AnimNode_LookAt")]
	[UnrealStructLayout(848, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 848)]
	public class FAnimNode_LookAt : FAnimNode_SkeletalControlBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002A10 RID: 10768 RVA: 0x0003FCC0 File Offset: 0x0003DEC0
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_LookAt._ScriptStructPtr != 0) ? FAnimNode_LookAt._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.AnimNode_LookAt", ref FAnimNode_LookAt._ScriptStructPtr);
		}

		// Token: 0x17000A46 RID: 2630
		// (get) Token: 0x06002A11 RID: 10769 RVA: 0x0003FCE4 File Offset: 0x0003DEE4
		// (set) Token: 0x06002A12 RID: 10770 RVA: 0x0003FD27 File Offset: 0x0003DF27
		public FBoneReference BoneToModify
		{
			get
			{
				base.FastCheckIsValid();
				FBoneReference result;
				if ((result = this._BoneToModify) == null)
				{
					result = (this._BoneToModify = new FBoneReference(base.NativePtr + (IntPtr)FAnimNode_LookAt.__PropertyOffset_BoneToModify, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneReference.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_LookAt.__PropertyOffset_BoneToModify, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000A47 RID: 2631
		// (get) Token: 0x06002A13 RID: 10771 RVA: 0x0003FD48 File Offset: 0x0003DF48
		// (set) Token: 0x06002A14 RID: 10772 RVA: 0x0003FD8B File Offset: 0x0003DF8B
		public FBoneSocketTarget LookAtTarget
		{
			get
			{
				base.FastCheckIsValid();
				FBoneSocketTarget result;
				if ((result = this._LookAtTarget) == null)
				{
					result = (this._LookAtTarget = new FBoneSocketTarget(base.NativePtr + (IntPtr)FAnimNode_LookAt.__PropertyOffset_LookAtTarget, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneSocketTarget.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_LookAt.__PropertyOffset_LookAtTarget, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000A48 RID: 2632
		// (get) Token: 0x06002A15 RID: 10773 RVA: 0x0003FDAC File Offset: 0x0003DFAC
		// (set) Token: 0x06002A16 RID: 10774 RVA: 0x0003FDC0 File Offset: 0x0003DFC0
		public unsafe FVector LookAtLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_LookAt.__PropertyOffset_LookAtLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_LookAt.__PropertyOffset_LookAtLocation) = value;
			}
		}

		// Token: 0x17000A49 RID: 2633
		// (get) Token: 0x06002A17 RID: 10775 RVA: 0x0003FDD8 File Offset: 0x0003DFD8
		// (set) Token: 0x06002A18 RID: 10776 RVA: 0x0003FE1B File Offset: 0x0003E01B
		public FAxis LookAt_Axis
		{
			get
			{
				base.FastCheckIsValid();
				FAxis result;
				if ((result = this._LookAt_Axis) == null)
				{
					result = (this._LookAt_Axis = new FAxis(base.NativePtr + (IntPtr)FAnimNode_LookAt.__PropertyOffset_LookAt_Axis, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAxis.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_LookAt.__PropertyOffset_LookAt_Axis, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000A4A RID: 2634
		// (get) Token: 0x06002A19 RID: 10777 RVA: 0x0003FE3C File Offset: 0x0003E03C
		// (set) Token: 0x06002A1A RID: 10778 RVA: 0x0003FE4C File Offset: 0x0003E04C
		public unsafe bool bUseLookUpAxis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_LookAt.__PropertyOffset_bUseLookUpAxis) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_LookAt.__PropertyOffset_bUseLookUpAxis) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000A4B RID: 2635
		// (get) Token: 0x06002A1B RID: 10779 RVA: 0x0003FE5D File Offset: 0x0003E05D
		// (set) Token: 0x06002A1C RID: 10780 RVA: 0x0003FE71 File Offset: 0x0003E071
		[Nullable(0)]
		public unsafe TEnumAsByte<EInterpolationBlend> InterpolationType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_LookAt.__PropertyOffset_InterpolationType);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_LookAt.__PropertyOffset_InterpolationType) = value;
			}
		}

		// Token: 0x17000A4C RID: 2636
		// (get) Token: 0x06002A1D RID: 10781 RVA: 0x0003FE88 File Offset: 0x0003E088
		// (set) Token: 0x06002A1E RID: 10782 RVA: 0x0003FECB File Offset: 0x0003E0CB
		public FAxis LookUp_Axis
		{
			get
			{
				base.FastCheckIsValid();
				FAxis result;
				if ((result = this._LookUp_Axis) == null)
				{
					result = (this._LookUp_Axis = new FAxis(base.NativePtr + (IntPtr)FAnimNode_LookAt.__PropertyOffset_LookUp_Axis, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAxis.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_LookAt.__PropertyOffset_LookUp_Axis, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000A4D RID: 2637
		// (get) Token: 0x06002A1F RID: 10783 RVA: 0x0003FEEC File Offset: 0x0003E0EC
		// (set) Token: 0x06002A20 RID: 10784 RVA: 0x0003FEFC File Offset: 0x0003E0FC
		public unsafe float LookAtClamp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_LookAt.__PropertyOffset_LookAtClamp);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_LookAt.__PropertyOffset_LookAtClamp) = value;
			}
		}

		// Token: 0x17000A4E RID: 2638
		// (get) Token: 0x06002A21 RID: 10785 RVA: 0x0003FF0D File Offset: 0x0003E10D
		// (set) Token: 0x06002A22 RID: 10786 RVA: 0x0003FF1D File Offset: 0x0003E11D
		public unsafe float InterpolationTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_LookAt.__PropertyOffset_InterpolationTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_LookAt.__PropertyOffset_InterpolationTime) = value;
			}
		}

		// Token: 0x17000A4F RID: 2639
		// (get) Token: 0x06002A23 RID: 10787 RVA: 0x0003FF2E File Offset: 0x0003E12E
		// (set) Token: 0x06002A24 RID: 10788 RVA: 0x0003FF3E File Offset: 0x0003E13E
		public unsafe float InterpolationTriggerThreashold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_LookAt.__PropertyOffset_InterpolationTriggerThreashold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_LookAt.__PropertyOffset_InterpolationTriggerThreashold) = value;
			}
		}

		// Token: 0x06002A25 RID: 10789 RVA: 0x0003FF4F File Offset: 0x0003E14F
		public FAnimNode_LookAt()
		{
		}

		// Token: 0x06002A26 RID: 10790 RVA: 0x0003FF58 File Offset: 0x0003E158
		public FAnimNode_LookAt(FBoneReference BoneToModify, FBoneSocketTarget LookAtTarget, FVector LookAtLocation, FAxis LookAt_Axis, bool bUseLookUpAxis, [Nullable(0)] TEnumAsByte<EInterpolationBlend> InterpolationType, FAxis LookUp_Axis, float LookAtClamp, float InterpolationTime, float InterpolationTriggerThreashold, FBoneReference LookAtBone_DEPRECATED, FName LookAtSocket_DEPRECATED, [Nullable(0)] TEnumAsByte<EAxisOption> LookAtAxis_DEPRECATED, FVector CustomLookAtAxis_DEPRECATED, [Nullable(0)] TEnumAsByte<EAxisOption> LookUpAxis_DEPRECATED, FVector CustomLookUpAxis_DEPRECATED, FComponentSpacePoseLink ComponentPose, int LODThreshold, int KuroLODMask, float ActualAlpha, EAnimAlphaInputType AlphaInputType, bool bAlphaBoolEnabled, bool bParallelEvalEnabled, bool bEnableOnMobile, float Alpha, FInputScaleBias AlphaScaleBias, FInputAlphaBoolBlend AlphaBoolBlend, FName AlphaCurveName, FInputScaleBiasClamp AlphaScaleBiasClamp)
		{
			this.BoneToModify = BoneToModify;
			this.LookAtTarget = LookAtTarget;
			this.LookAtLocation = LookAtLocation;
			this.LookAt_Axis = LookAt_Axis;
			this.bUseLookUpAxis = bUseLookUpAxis;
			this.InterpolationType = InterpolationType;
			this.LookUp_Axis = LookUp_Axis;
			this.LookAtClamp = LookAtClamp;
			this.InterpolationTime = InterpolationTime;
			this.InterpolationTriggerThreashold = InterpolationTriggerThreashold;
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

		// Token: 0x06002A27 RID: 10791 RVA: 0x00040020 File Offset: 0x0003E220
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_LookAt.StaticStruct();
		}

		// Token: 0x06002A28 RID: 10792 RVA: 0x0004002C File Offset: 0x0003E22C
		[NullableContext(2)]
		public FAnimNode_LookAt(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002A29 RID: 10793 RVA: 0x00040036 File Offset: 0x0003E236
		public FAnimNode_LookAt(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002A2A RID: 10794 RVA: 0x00040041 File Offset: 0x0003E241
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_LookAt(Pointer, false, true);
		}

		// Token: 0x06002A2B RID: 10795 RVA: 0x0004004B File Offset: 0x0003E24B
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_LookAt(Pointer, MemoryOwner);
		}

		// Token: 0x040010FB RID: 4347
		public new const string __ObjectPath = "/Script/AnimGraphRuntime.AnimNode_LookAt";

		// Token: 0x040010FC RID: 4348
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040010FD RID: 4349
		internal static int __PropertyOffset_BoneToModify;

		// Token: 0x040010FE RID: 4350
		[Nullable(2)]
		private FBoneReference _BoneToModify;

		// Token: 0x040010FF RID: 4351
		internal static int __PropertyOffset_LookAtTarget;

		// Token: 0x04001100 RID: 4352
		[Nullable(2)]
		private FBoneSocketTarget _LookAtTarget;

		// Token: 0x04001101 RID: 4353
		internal static int __PropertyOffset_LookAtLocation;

		// Token: 0x04001102 RID: 4354
		internal static int __PropertyOffset_LookAt_Axis;

		// Token: 0x04001103 RID: 4355
		[Nullable(2)]
		private FAxis _LookAt_Axis;

		// Token: 0x04001104 RID: 4356
		internal static int __PropertyOffset_bUseLookUpAxis;

		// Token: 0x04001105 RID: 4357
		internal static int __PropertyOffset_InterpolationType;

		// Token: 0x04001106 RID: 4358
		internal static int __PropertyOffset_LookUp_Axis;

		// Token: 0x04001107 RID: 4359
		[Nullable(2)]
		private FAxis _LookUp_Axis;

		// Token: 0x04001108 RID: 4360
		internal static int __PropertyOffset_LookAtClamp;

		// Token: 0x04001109 RID: 4361
		internal static int __PropertyOffset_InterpolationTime;

		// Token: 0x0400110A RID: 4362
		internal static int __PropertyOffset_InterpolationTriggerThreashold;
	}
}
