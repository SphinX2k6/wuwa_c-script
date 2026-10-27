using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200161A RID: 5658
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.AnimNode_MultiBonesIK")]
	[UnrealStructLayout(456, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 456)]
	public class FAnimNode_MultiBonesIK : FAnimNode_SkeletalControlBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06014718 RID: 83736 RVA: 0x001E1054 File Offset: 0x001DF254
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_MultiBonesIK._ScriptStructPtr != 0) ? FAnimNode_MultiBonesIK._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.AnimNode_MultiBonesIK", ref FAnimNode_MultiBonesIK._ScriptStructPtr);
		}

		// Token: 0x17005066 RID: 20582
		// (get) Token: 0x06014719 RID: 83737 RVA: 0x001E1078 File Offset: 0x001DF278
		// (set) Token: 0x0601471A RID: 83738 RVA: 0x001E10BB File Offset: 0x001DF2BB
		public FBoneReference IKBone
		{
			get
			{
				base.FastCheckIsValid();
				FBoneReference result;
				if ((result = this._IKBone) == null)
				{
					result = (this._IKBone = new FBoneReference(base.NativePtr + (IntPtr)FAnimNode_MultiBonesIK.__PropertyOffset_IKBone, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneReference.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_MultiBonesIK.__PropertyOffset_IKBone, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005067 RID: 20583
		// (get) Token: 0x0601471B RID: 83739 RVA: 0x001E10DC File Offset: 0x001DF2DC
		// (set) Token: 0x0601471C RID: 83740 RVA: 0x001E10F0 File Offset: 0x001DF2F0
		public unsafe FVector IKBonePos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_MultiBonesIK.__PropertyOffset_IKBonePos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_MultiBonesIK.__PropertyOffset_IKBonePos) = value;
			}
		}

		// Token: 0x17005068 RID: 20584
		// (get) Token: 0x0601471D RID: 83741 RVA: 0x001E1108 File Offset: 0x001DF308
		// (set) Token: 0x0601471E RID: 83742 RVA: 0x001E114B File Offset: 0x001DF34B
		public FBoneReference BeginBone
		{
			get
			{
				base.FastCheckIsValid();
				FBoneReference result;
				if ((result = this._BeginBone) == null)
				{
					result = (this._BeginBone = new FBoneReference(base.NativePtr + (IntPtr)FAnimNode_MultiBonesIK.__PropertyOffset_BeginBone, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneReference.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_MultiBonesIK.__PropertyOffset_BeginBone, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005069 RID: 20585
		// (get) Token: 0x0601471F RID: 83743 RVA: 0x001E116C File Offset: 0x001DF36C
		// (set) Token: 0x06014720 RID: 83744 RVA: 0x001E11AF File Offset: 0x001DF3AF
		public FBoneReference EndBone
		{
			get
			{
				base.FastCheckIsValid();
				FBoneReference result;
				if ((result = this._EndBone) == null)
				{
					result = (this._EndBone = new FBoneReference(base.NativePtr + (IntPtr)FAnimNode_MultiBonesIK.__PropertyOffset_EndBone, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneReference.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_MultiBonesIK.__PropertyOffset_EndBone, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700506A RID: 20586
		// (get) Token: 0x06014721 RID: 83745 RVA: 0x001E11D0 File Offset: 0x001DF3D0
		// (set) Token: 0x06014722 RID: 83746 RVA: 0x001E11E0 File Offset: 0x001DF3E0
		public unsafe KuroAnimIKMode bMode
		{
			get
			{
				return (KuroAnimIKMode)(*(base.NativePtr + (IntPtr)FAnimNode_MultiBonesIK.__PropertyOffset_bMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_MultiBonesIK.__PropertyOffset_bMode) = (byte)value;
			}
		}

		// Token: 0x1700506B RID: 20587
		// (get) Token: 0x06014723 RID: 83747 RVA: 0x001E11F1 File Offset: 0x001DF3F1
		// (set) Token: 0x06014724 RID: 83748 RVA: 0x001E1205 File Offset: 0x001DF405
		public unsafe FVector OffsetOrTargetPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_MultiBonesIK.__PropertyOffset_OffsetOrTargetPosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_MultiBonesIK.__PropertyOffset_OffsetOrTargetPosition) = value;
			}
		}

		// Token: 0x06014725 RID: 83749 RVA: 0x001E121A File Offset: 0x001DF41A
		public FAnimNode_MultiBonesIK()
		{
		}

		// Token: 0x06014726 RID: 83750 RVA: 0x001E1224 File Offset: 0x001DF424
		public FAnimNode_MultiBonesIK(FBoneReference IKBone, FVector IKBonePos, FBoneReference BeginBone, FBoneReference EndBone, KuroAnimIKMode bMode, FVector OffsetOrTargetPosition, FComponentSpacePoseLink ComponentPose, int LODThreshold, int KuroLODMask, float ActualAlpha, EAnimAlphaInputType AlphaInputType, bool bAlphaBoolEnabled, bool bParallelEvalEnabled, bool bEnableOnMobile, float Alpha, FInputScaleBias AlphaScaleBias, FInputAlphaBoolBlend AlphaBoolBlend, FName AlphaCurveName, FInputScaleBiasClamp AlphaScaleBiasClamp)
		{
			this.IKBone = IKBone;
			this.IKBonePos = IKBonePos;
			this.BeginBone = BeginBone;
			this.EndBone = EndBone;
			this.bMode = bMode;
			this.OffsetOrTargetPosition = OffsetOrTargetPosition;
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

		// Token: 0x06014727 RID: 83751 RVA: 0x001E12CC File Offset: 0x001DF4CC
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_MultiBonesIK.StaticStruct();
		}

		// Token: 0x06014728 RID: 83752 RVA: 0x001E12D8 File Offset: 0x001DF4D8
		[NullableContext(2)]
		public FAnimNode_MultiBonesIK(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06014729 RID: 83753 RVA: 0x001E12E2 File Offset: 0x001DF4E2
		public FAnimNode_MultiBonesIK(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601472A RID: 83754 RVA: 0x001E12ED File Offset: 0x001DF4ED
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_MultiBonesIK(Pointer, false, true);
		}

		// Token: 0x0601472B RID: 83755 RVA: 0x001E12F7 File Offset: 0x001DF4F7
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_MultiBonesIK(Pointer, MemoryOwner);
		}

		// Token: 0x0400B1F1 RID: 45553
		public new const string __ObjectPath = "/Script/KuroAnim.AnimNode_MultiBonesIK";

		// Token: 0x0400B1F2 RID: 45554
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B1F3 RID: 45555
		internal static int __PropertyOffset_IKBone;

		// Token: 0x0400B1F4 RID: 45556
		[Nullable(2)]
		private FBoneReference _IKBone;

		// Token: 0x0400B1F5 RID: 45557
		internal static int __PropertyOffset_IKBonePos;

		// Token: 0x0400B1F6 RID: 45558
		internal static int __PropertyOffset_BeginBone;

		// Token: 0x0400B1F7 RID: 45559
		[Nullable(2)]
		private FBoneReference _BeginBone;

		// Token: 0x0400B1F8 RID: 45560
		internal static int __PropertyOffset_EndBone;

		// Token: 0x0400B1F9 RID: 45561
		[Nullable(2)]
		private FBoneReference _EndBone;

		// Token: 0x0400B1FA RID: 45562
		internal static int __PropertyOffset_bMode;

		// Token: 0x0400B1FB RID: 45563
		internal static int __PropertyOffset_OffsetOrTargetPosition;
	}
}
