using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002DB RID: 731
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.AnimNode_CopyBone")]
	[UnrealStructLayout(384, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 384)]
	public class FAnimNode_CopyBone : FAnimNode_SkeletalControlBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002922 RID: 10530 RVA: 0x0003E250 File Offset: 0x0003C450
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_CopyBone._ScriptStructPtr != 0) ? FAnimNode_CopyBone._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.AnimNode_CopyBone", ref FAnimNode_CopyBone._ScriptStructPtr);
		}

		// Token: 0x170009F7 RID: 2551
		// (get) Token: 0x06002923 RID: 10531 RVA: 0x0003E274 File Offset: 0x0003C474
		// (set) Token: 0x06002924 RID: 10532 RVA: 0x0003E2B7 File Offset: 0x0003C4B7
		public FBoneReference SourceBone
		{
			get
			{
				base.FastCheckIsValid();
				FBoneReference result;
				if ((result = this._SourceBone) == null)
				{
					result = (this._SourceBone = new FBoneReference(base.NativePtr + (IntPtr)FAnimNode_CopyBone.__PropertyOffset_SourceBone, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneReference.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_CopyBone.__PropertyOffset_SourceBone, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170009F8 RID: 2552
		// (get) Token: 0x06002925 RID: 10533 RVA: 0x0003E2D8 File Offset: 0x0003C4D8
		// (set) Token: 0x06002926 RID: 10534 RVA: 0x0003E31B File Offset: 0x0003C51B
		public FBoneReference TargetBone
		{
			get
			{
				base.FastCheckIsValid();
				FBoneReference result;
				if ((result = this._TargetBone) == null)
				{
					result = (this._TargetBone = new FBoneReference(base.NativePtr + (IntPtr)FAnimNode_CopyBone.__PropertyOffset_TargetBone, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneReference.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_CopyBone.__PropertyOffset_TargetBone, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170009F9 RID: 2553
		// (get) Token: 0x06002927 RID: 10535 RVA: 0x0003E33C File Offset: 0x0003C53C
		// (set) Token: 0x06002928 RID: 10536 RVA: 0x0003E34C File Offset: 0x0003C54C
		public unsafe bool bCopyTranslation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_CopyBone.__PropertyOffset_bCopyTranslation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_CopyBone.__PropertyOffset_bCopyTranslation) = (value ? 1 : 0);
			}
		}

		// Token: 0x170009FA RID: 2554
		// (get) Token: 0x06002929 RID: 10537 RVA: 0x0003E35D File Offset: 0x0003C55D
		// (set) Token: 0x0600292A RID: 10538 RVA: 0x0003E36D File Offset: 0x0003C56D
		public unsafe bool bCopyRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_CopyBone.__PropertyOffset_bCopyRotation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_CopyBone.__PropertyOffset_bCopyRotation) = (value ? 1 : 0);
			}
		}

		// Token: 0x170009FB RID: 2555
		// (get) Token: 0x0600292B RID: 10539 RVA: 0x0003E37E File Offset: 0x0003C57E
		// (set) Token: 0x0600292C RID: 10540 RVA: 0x0003E38E File Offset: 0x0003C58E
		public unsafe bool bCopyScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_CopyBone.__PropertyOffset_bCopyScale) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_CopyBone.__PropertyOffset_bCopyScale) = (value ? 1 : 0);
			}
		}

		// Token: 0x170009FC RID: 2556
		// (get) Token: 0x0600292D RID: 10541 RVA: 0x0003E39F File Offset: 0x0003C59F
		// (set) Token: 0x0600292E RID: 10542 RVA: 0x0003E3B3 File Offset: 0x0003C5B3
		[Nullable(0)]
		public unsafe TEnumAsByte<EBoneControlSpace> ControlSpace
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_CopyBone.__PropertyOffset_ControlSpace);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_CopyBone.__PropertyOffset_ControlSpace) = value;
			}
		}

		// Token: 0x0600292F RID: 10543 RVA: 0x0003E3C8 File Offset: 0x0003C5C8
		public FAnimNode_CopyBone()
		{
		}

		// Token: 0x06002930 RID: 10544 RVA: 0x0003E3D0 File Offset: 0x0003C5D0
		public FAnimNode_CopyBone(FBoneReference SourceBone, FBoneReference TargetBone, bool bCopyTranslation, bool bCopyRotation, bool bCopyScale, [Nullable(0)] TEnumAsByte<EBoneControlSpace> ControlSpace, FComponentSpacePoseLink ComponentPose, int LODThreshold, int KuroLODMask, float ActualAlpha, EAnimAlphaInputType AlphaInputType, bool bAlphaBoolEnabled, bool bParallelEvalEnabled, bool bEnableOnMobile, float Alpha, FInputScaleBias AlphaScaleBias, FInputAlphaBoolBlend AlphaBoolBlend, FName AlphaCurveName, FInputScaleBiasClamp AlphaScaleBiasClamp)
		{
			this.SourceBone = SourceBone;
			this.TargetBone = TargetBone;
			this.bCopyTranslation = bCopyTranslation;
			this.bCopyRotation = bCopyRotation;
			this.bCopyScale = bCopyScale;
			this.ControlSpace = ControlSpace;
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

		// Token: 0x06002931 RID: 10545 RVA: 0x0003E478 File Offset: 0x0003C678
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_CopyBone.StaticStruct();
		}

		// Token: 0x06002932 RID: 10546 RVA: 0x0003E484 File Offset: 0x0003C684
		[NullableContext(2)]
		public FAnimNode_CopyBone(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002933 RID: 10547 RVA: 0x0003E48E File Offset: 0x0003C68E
		public FAnimNode_CopyBone(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002934 RID: 10548 RVA: 0x0003E499 File Offset: 0x0003C699
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_CopyBone(Pointer, false, true);
		}

		// Token: 0x06002935 RID: 10549 RVA: 0x0003E4A3 File Offset: 0x0003C6A3
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_CopyBone(Pointer, MemoryOwner);
		}

		// Token: 0x04001079 RID: 4217
		public new const string __ObjectPath = "/Script/AnimGraphRuntime.AnimNode_CopyBone";

		// Token: 0x0400107A RID: 4218
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400107B RID: 4219
		internal static int __PropertyOffset_SourceBone;

		// Token: 0x0400107C RID: 4220
		[Nullable(2)]
		private FBoneReference _SourceBone;

		// Token: 0x0400107D RID: 4221
		internal static int __PropertyOffset_TargetBone;

		// Token: 0x0400107E RID: 4222
		[Nullable(2)]
		private FBoneReference _TargetBone;

		// Token: 0x0400107F RID: 4223
		internal static int __PropertyOffset_bCopyTranslation;

		// Token: 0x04001080 RID: 4224
		internal static int __PropertyOffset_bCopyRotation;

		// Token: 0x04001081 RID: 4225
		internal static int __PropertyOffset_bCopyScale;

		// Token: 0x04001082 RID: 4226
		internal static int __PropertyOffset_ControlSpace;
	}
}
