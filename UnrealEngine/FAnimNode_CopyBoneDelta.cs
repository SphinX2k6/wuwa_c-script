using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002DC RID: 732
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.AnimNode_CopyBoneDelta")]
	[UnrealStructLayout(392, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 392)]
	public class FAnimNode_CopyBoneDelta : FAnimNode_SkeletalControlBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002936 RID: 10550 RVA: 0x0003E4AC File Offset: 0x0003C6AC
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_CopyBoneDelta._ScriptStructPtr != 0) ? FAnimNode_CopyBoneDelta._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.AnimNode_CopyBoneDelta", ref FAnimNode_CopyBoneDelta._ScriptStructPtr);
		}

		// Token: 0x170009FD RID: 2557
		// (get) Token: 0x06002937 RID: 10551 RVA: 0x0003E4D0 File Offset: 0x0003C6D0
		// (set) Token: 0x06002938 RID: 10552 RVA: 0x0003E513 File Offset: 0x0003C713
		public FBoneReference SourceBone
		{
			get
			{
				base.FastCheckIsValid();
				FBoneReference result;
				if ((result = this._SourceBone) == null)
				{
					result = (this._SourceBone = new FBoneReference(base.NativePtr + (IntPtr)FAnimNode_CopyBoneDelta.__PropertyOffset_SourceBone, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneReference.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_CopyBoneDelta.__PropertyOffset_SourceBone, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170009FE RID: 2558
		// (get) Token: 0x06002939 RID: 10553 RVA: 0x0003E534 File Offset: 0x0003C734
		// (set) Token: 0x0600293A RID: 10554 RVA: 0x0003E577 File Offset: 0x0003C777
		public FBoneReference TargetBone
		{
			get
			{
				base.FastCheckIsValid();
				FBoneReference result;
				if ((result = this._TargetBone) == null)
				{
					result = (this._TargetBone = new FBoneReference(base.NativePtr + (IntPtr)FAnimNode_CopyBoneDelta.__PropertyOffset_TargetBone, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneReference.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_CopyBoneDelta.__PropertyOffset_TargetBone, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170009FF RID: 2559
		// (get) Token: 0x0600293B RID: 10555 RVA: 0x0003E598 File Offset: 0x0003C798
		// (set) Token: 0x0600293C RID: 10556 RVA: 0x0003E5A8 File Offset: 0x0003C7A8
		public unsafe bool bCopyTranslation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_CopyBoneDelta.__PropertyOffset_bCopyTranslation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_CopyBoneDelta.__PropertyOffset_bCopyTranslation) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000A00 RID: 2560
		// (get) Token: 0x0600293D RID: 10557 RVA: 0x0003E5B9 File Offset: 0x0003C7B9
		// (set) Token: 0x0600293E RID: 10558 RVA: 0x0003E5C9 File Offset: 0x0003C7C9
		public unsafe bool bCopyRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_CopyBoneDelta.__PropertyOffset_bCopyRotation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_CopyBoneDelta.__PropertyOffset_bCopyRotation) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000A01 RID: 2561
		// (get) Token: 0x0600293F RID: 10559 RVA: 0x0003E5DA File Offset: 0x0003C7DA
		// (set) Token: 0x06002940 RID: 10560 RVA: 0x0003E5EA File Offset: 0x0003C7EA
		public unsafe bool bCopyScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_CopyBoneDelta.__PropertyOffset_bCopyScale) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_CopyBoneDelta.__PropertyOffset_bCopyScale) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000A02 RID: 2562
		// (get) Token: 0x06002941 RID: 10561 RVA: 0x0003E5FB File Offset: 0x0003C7FB
		// (set) Token: 0x06002942 RID: 10562 RVA: 0x0003E60B File Offset: 0x0003C80B
		public unsafe CopyBoneDeltaMode CopyMode
		{
			get
			{
				return (CopyBoneDeltaMode)(*(base.NativePtr + (IntPtr)FAnimNode_CopyBoneDelta.__PropertyOffset_CopyMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_CopyBoneDelta.__PropertyOffset_CopyMode) = (byte)value;
			}
		}

		// Token: 0x17000A03 RID: 2563
		// (get) Token: 0x06002943 RID: 10563 RVA: 0x0003E61C File Offset: 0x0003C81C
		// (set) Token: 0x06002944 RID: 10564 RVA: 0x0003E62C File Offset: 0x0003C82C
		public unsafe float TranslationMultiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_CopyBoneDelta.__PropertyOffset_TranslationMultiplier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_CopyBoneDelta.__PropertyOffset_TranslationMultiplier) = value;
			}
		}

		// Token: 0x17000A04 RID: 2564
		// (get) Token: 0x06002945 RID: 10565 RVA: 0x0003E63D File Offset: 0x0003C83D
		// (set) Token: 0x06002946 RID: 10566 RVA: 0x0003E64D File Offset: 0x0003C84D
		public unsafe float RotationMultiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_CopyBoneDelta.__PropertyOffset_RotationMultiplier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_CopyBoneDelta.__PropertyOffset_RotationMultiplier) = value;
			}
		}

		// Token: 0x17000A05 RID: 2565
		// (get) Token: 0x06002947 RID: 10567 RVA: 0x0003E65E File Offset: 0x0003C85E
		// (set) Token: 0x06002948 RID: 10568 RVA: 0x0003E66E File Offset: 0x0003C86E
		public unsafe float ScaleMultiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_CopyBoneDelta.__PropertyOffset_ScaleMultiplier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_CopyBoneDelta.__PropertyOffset_ScaleMultiplier) = value;
			}
		}

		// Token: 0x06002949 RID: 10569 RVA: 0x0003E67F File Offset: 0x0003C87F
		public FAnimNode_CopyBoneDelta()
		{
		}

		// Token: 0x0600294A RID: 10570 RVA: 0x0003E688 File Offset: 0x0003C888
		public FAnimNode_CopyBoneDelta(FBoneReference SourceBone, FBoneReference TargetBone, bool bCopyTranslation, bool bCopyRotation, bool bCopyScale, CopyBoneDeltaMode CopyMode, float TranslationMultiplier, float RotationMultiplier, float ScaleMultiplier, FComponentSpacePoseLink ComponentPose, int LODThreshold, int KuroLODMask, float ActualAlpha, EAnimAlphaInputType AlphaInputType, bool bAlphaBoolEnabled, bool bParallelEvalEnabled, bool bEnableOnMobile, float Alpha, FInputScaleBias AlphaScaleBias, FInputAlphaBoolBlend AlphaBoolBlend, FName AlphaCurveName, FInputScaleBiasClamp AlphaScaleBiasClamp)
		{
			this.SourceBone = SourceBone;
			this.TargetBone = TargetBone;
			this.bCopyTranslation = bCopyTranslation;
			this.bCopyRotation = bCopyRotation;
			this.bCopyScale = bCopyScale;
			this.CopyMode = CopyMode;
			this.TranslationMultiplier = TranslationMultiplier;
			this.RotationMultiplier = RotationMultiplier;
			this.ScaleMultiplier = ScaleMultiplier;
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

		// Token: 0x0600294B RID: 10571 RVA: 0x0003E748 File Offset: 0x0003C948
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_CopyBoneDelta.StaticStruct();
		}

		// Token: 0x0600294C RID: 10572 RVA: 0x0003E754 File Offset: 0x0003C954
		[NullableContext(2)]
		public FAnimNode_CopyBoneDelta(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600294D RID: 10573 RVA: 0x0003E75E File Offset: 0x0003C95E
		public FAnimNode_CopyBoneDelta(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600294E RID: 10574 RVA: 0x0003E769 File Offset: 0x0003C969
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_CopyBoneDelta(Pointer, false, true);
		}

		// Token: 0x0600294F RID: 10575 RVA: 0x0003E773 File Offset: 0x0003C973
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_CopyBoneDelta(Pointer, MemoryOwner);
		}

		// Token: 0x04001083 RID: 4227
		public new const string __ObjectPath = "/Script/AnimGraphRuntime.AnimNode_CopyBoneDelta";

		// Token: 0x04001084 RID: 4228
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001085 RID: 4229
		internal static int __PropertyOffset_SourceBone;

		// Token: 0x04001086 RID: 4230
		[Nullable(2)]
		private FBoneReference _SourceBone;

		// Token: 0x04001087 RID: 4231
		internal static int __PropertyOffset_TargetBone;

		// Token: 0x04001088 RID: 4232
		[Nullable(2)]
		private FBoneReference _TargetBone;

		// Token: 0x04001089 RID: 4233
		internal static int __PropertyOffset_bCopyTranslation;

		// Token: 0x0400108A RID: 4234
		internal static int __PropertyOffset_bCopyRotation;

		// Token: 0x0400108B RID: 4235
		internal static int __PropertyOffset_bCopyScale;

		// Token: 0x0400108C RID: 4236
		internal static int __PropertyOffset_CopyMode;

		// Token: 0x0400108D RID: 4237
		internal static int __PropertyOffset_TranslationMultiplier;

		// Token: 0x0400108E RID: 4238
		internal static int __PropertyOffset_RotationMultiplier;

		// Token: 0x0400108F RID: 4239
		internal static int __PropertyOffset_ScaleMultiplier;
	}
}
