using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001612 RID: 5650
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.AnimNode_KuroMachineTwoBoneSightLock")]
	[UnrealStructLayout(480, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 480)]
	public class FAnimNode_KuroMachineTwoBoneSightLock : FAnimNode_SkeletalControlBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601467A RID: 83578 RVA: 0x001DFF0C File Offset: 0x001DE10C
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_KuroMachineTwoBoneSightLock._ScriptStructPtr != 0) ? FAnimNode_KuroMachineTwoBoneSightLock._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.AnimNode_KuroMachineTwoBoneSightLock", ref FAnimNode_KuroMachineTwoBoneSightLock._ScriptStructPtr);
		}

		// Token: 0x17005037 RID: 20535
		// (get) Token: 0x0601467B RID: 83579 RVA: 0x001DFF30 File Offset: 0x001DE130
		// (set) Token: 0x0601467C RID: 83580 RVA: 0x001DFF73 File Offset: 0x001DE173
		public FBoneReference ControlBone
		{
			get
			{
				base.FastCheckIsValid();
				FBoneReference result;
				if ((result = this._ControlBone) == null)
				{
					result = (this._ControlBone = new FBoneReference(base.NativePtr + (IntPtr)FAnimNode_KuroMachineTwoBoneSightLock.__PropertyOffset_ControlBone, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneReference.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_KuroMachineTwoBoneSightLock.__PropertyOffset_ControlBone, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005038 RID: 20536
		// (get) Token: 0x0601467D RID: 83581 RVA: 0x001DFF94 File Offset: 0x001DE194
		// (set) Token: 0x0601467E RID: 83582 RVA: 0x001DFFA8 File Offset: 0x001DE1A8
		public unsafe FVector ControlBoneRotateAxis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_KuroMachineTwoBoneSightLock.__PropertyOffset_ControlBoneRotateAxis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KuroMachineTwoBoneSightLock.__PropertyOffset_ControlBoneRotateAxis) = value;
			}
		}

		// Token: 0x17005039 RID: 20537
		// (get) Token: 0x0601467F RID: 83583 RVA: 0x001DFFBD File Offset: 0x001DE1BD
		// (set) Token: 0x06014680 RID: 83584 RVA: 0x001DFFD1 File Offset: 0x001DE1D1
		public unsafe FVector2D ControlBoneRotateLimit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_KuroMachineTwoBoneSightLock.__PropertyOffset_ControlBoneRotateLimit);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KuroMachineTwoBoneSightLock.__PropertyOffset_ControlBoneRotateLimit) = value;
			}
		}

		// Token: 0x1700503A RID: 20538
		// (get) Token: 0x06014681 RID: 83585 RVA: 0x001DFFE6 File Offset: 0x001DE1E6
		// (set) Token: 0x06014682 RID: 83586 RVA: 0x001DFFFA File Offset: 0x001DE1FA
		public unsafe FVector ParentBoneRotateAxis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_KuroMachineTwoBoneSightLock.__PropertyOffset_ParentBoneRotateAxis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KuroMachineTwoBoneSightLock.__PropertyOffset_ParentBoneRotateAxis) = value;
			}
		}

		// Token: 0x1700503B RID: 20539
		// (get) Token: 0x06014683 RID: 83587 RVA: 0x001E000F File Offset: 0x001DE20F
		// (set) Token: 0x06014684 RID: 83588 RVA: 0x001E0023 File Offset: 0x001DE223
		public unsafe FVector2D ParentBoneRotateLimit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_KuroMachineTwoBoneSightLock.__PropertyOffset_ParentBoneRotateLimit);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KuroMachineTwoBoneSightLock.__PropertyOffset_ParentBoneRotateLimit) = value;
			}
		}

		// Token: 0x1700503C RID: 20540
		// (get) Token: 0x06014685 RID: 83589 RVA: 0x001E0038 File Offset: 0x001DE238
		// (set) Token: 0x06014686 RID: 83590 RVA: 0x001E004C File Offset: 0x001DE24C
		public unsafe FVector TargetDirection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_KuroMachineTwoBoneSightLock.__PropertyOffset_TargetDirection);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KuroMachineTwoBoneSightLock.__PropertyOffset_TargetDirection) = value;
			}
		}

		// Token: 0x06014687 RID: 83591 RVA: 0x001E0061 File Offset: 0x001DE261
		public FAnimNode_KuroMachineTwoBoneSightLock()
		{
		}

		// Token: 0x06014688 RID: 83592 RVA: 0x001E006C File Offset: 0x001DE26C
		public FAnimNode_KuroMachineTwoBoneSightLock(FBoneReference ControlBone, FVector ControlBoneRotateAxis, FVector2D ControlBoneRotateLimit, FVector ParentBoneRotateAxis, FVector2D ParentBoneRotateLimit, FVector TargetDirection, FComponentSpacePoseLink ComponentPose, int LODThreshold, int KuroLODMask, float ActualAlpha, EAnimAlphaInputType AlphaInputType, bool bAlphaBoolEnabled, bool bParallelEvalEnabled, bool bEnableOnMobile, float Alpha, FInputScaleBias AlphaScaleBias, FInputAlphaBoolBlend AlphaBoolBlend, FName AlphaCurveName, FInputScaleBiasClamp AlphaScaleBiasClamp)
		{
			this.ControlBone = ControlBone;
			this.ControlBoneRotateAxis = ControlBoneRotateAxis;
			this.ControlBoneRotateLimit = ControlBoneRotateLimit;
			this.ParentBoneRotateAxis = ParentBoneRotateAxis;
			this.ParentBoneRotateLimit = ParentBoneRotateLimit;
			this.TargetDirection = TargetDirection;
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

		// Token: 0x06014689 RID: 83593 RVA: 0x001E0114 File Offset: 0x001DE314
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_KuroMachineTwoBoneSightLock.StaticStruct();
		}

		// Token: 0x0601468A RID: 83594 RVA: 0x001E0120 File Offset: 0x001DE320
		[NullableContext(2)]
		public FAnimNode_KuroMachineTwoBoneSightLock(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601468B RID: 83595 RVA: 0x001E012A File Offset: 0x001DE32A
		public FAnimNode_KuroMachineTwoBoneSightLock(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601468C RID: 83596 RVA: 0x001E0135 File Offset: 0x001DE335
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_KuroMachineTwoBoneSightLock(Pointer, false, true);
		}

		// Token: 0x0601468D RID: 83597 RVA: 0x001E013F File Offset: 0x001DE33F
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_KuroMachineTwoBoneSightLock(Pointer, MemoryOwner);
		}

		// Token: 0x0400B1A6 RID: 45478
		public new const string __ObjectPath = "/Script/KuroAnim.AnimNode_KuroMachineTwoBoneSightLock";

		// Token: 0x0400B1A7 RID: 45479
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B1A8 RID: 45480
		internal static int __PropertyOffset_ControlBone;

		// Token: 0x0400B1A9 RID: 45481
		[Nullable(2)]
		private FBoneReference _ControlBone;

		// Token: 0x0400B1AA RID: 45482
		internal static int __PropertyOffset_ControlBoneRotateAxis;

		// Token: 0x0400B1AB RID: 45483
		internal static int __PropertyOffset_ControlBoneRotateLimit;

		// Token: 0x0400B1AC RID: 45484
		internal static int __PropertyOffset_ParentBoneRotateAxis;

		// Token: 0x0400B1AD RID: 45485
		internal static int __PropertyOffset_ParentBoneRotateLimit;

		// Token: 0x0400B1AE RID: 45486
		internal static int __PropertyOffset_TargetDirection;
	}
}
