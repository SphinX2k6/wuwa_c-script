using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002E8 RID: 744
	[UnrealObjectPath("/Script/AnimGraphRuntime.AnimNode_ModifyBone")]
	[UnrealStructLayout(400, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 400)]
	public class FAnimNode_ModifyBone : FAnimNode_SkeletalControlBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002A41 RID: 10817 RVA: 0x0004021A File Offset: 0x0003E41A
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_ModifyBone._ScriptStructPtr != 0) ? FAnimNode_ModifyBone._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.AnimNode_ModifyBone", ref FAnimNode_ModifyBone._ScriptStructPtr);
		}

		// Token: 0x17000A53 RID: 2643
		// (get) Token: 0x06002A42 RID: 10818 RVA: 0x00040240 File Offset: 0x0003E440
		// (set) Token: 0x06002A43 RID: 10819 RVA: 0x00040283 File Offset: 0x0003E483
		[Nullable(1)]
		public FBoneReference BoneToModify
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FBoneReference result;
				if ((result = this._BoneToModify) == null)
				{
					result = (this._BoneToModify = new FBoneReference(base.NativePtr + (IntPtr)FAnimNode_ModifyBone.__PropertyOffset_BoneToModify, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneReference.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_ModifyBone.__PropertyOffset_BoneToModify, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000A54 RID: 2644
		// (get) Token: 0x06002A44 RID: 10820 RVA: 0x000402A4 File Offset: 0x0003E4A4
		// (set) Token: 0x06002A45 RID: 10821 RVA: 0x000402B8 File Offset: 0x0003E4B8
		public unsafe FVector Translation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_ModifyBone.__PropertyOffset_Translation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_ModifyBone.__PropertyOffset_Translation) = value;
			}
		}

		// Token: 0x17000A55 RID: 2645
		// (get) Token: 0x06002A46 RID: 10822 RVA: 0x000402CD File Offset: 0x0003E4CD
		// (set) Token: 0x06002A47 RID: 10823 RVA: 0x000402E1 File Offset: 0x0003E4E1
		public unsafe FRotator Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_ModifyBone.__PropertyOffset_Rotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_ModifyBone.__PropertyOffset_Rotation) = value;
			}
		}

		// Token: 0x17000A56 RID: 2646
		// (get) Token: 0x06002A48 RID: 10824 RVA: 0x000402F6 File Offset: 0x0003E4F6
		// (set) Token: 0x06002A49 RID: 10825 RVA: 0x0004030A File Offset: 0x0003E50A
		public unsafe FVector Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_ModifyBone.__PropertyOffset_Scale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_ModifyBone.__PropertyOffset_Scale) = value;
			}
		}

		// Token: 0x17000A57 RID: 2647
		// (get) Token: 0x06002A4A RID: 10826 RVA: 0x0004031F File Offset: 0x0003E51F
		// (set) Token: 0x06002A4B RID: 10827 RVA: 0x00040333 File Offset: 0x0003E533
		public unsafe TEnumAsByte<EBoneModificationMode> TranslationMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_ModifyBone.__PropertyOffset_TranslationMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_ModifyBone.__PropertyOffset_TranslationMode) = value;
			}
		}

		// Token: 0x17000A58 RID: 2648
		// (get) Token: 0x06002A4C RID: 10828 RVA: 0x00040348 File Offset: 0x0003E548
		// (set) Token: 0x06002A4D RID: 10829 RVA: 0x0004035C File Offset: 0x0003E55C
		public unsafe TEnumAsByte<EBoneModificationMode> RotationMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_ModifyBone.__PropertyOffset_RotationMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_ModifyBone.__PropertyOffset_RotationMode) = value;
			}
		}

		// Token: 0x17000A59 RID: 2649
		// (get) Token: 0x06002A4E RID: 10830 RVA: 0x00040371 File Offset: 0x0003E571
		// (set) Token: 0x06002A4F RID: 10831 RVA: 0x00040385 File Offset: 0x0003E585
		public unsafe TEnumAsByte<EBoneModificationMode> ScaleMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_ModifyBone.__PropertyOffset_ScaleMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_ModifyBone.__PropertyOffset_ScaleMode) = value;
			}
		}

		// Token: 0x17000A5A RID: 2650
		// (get) Token: 0x06002A50 RID: 10832 RVA: 0x0004039A File Offset: 0x0003E59A
		// (set) Token: 0x06002A51 RID: 10833 RVA: 0x000403AE File Offset: 0x0003E5AE
		public unsafe TEnumAsByte<EBoneControlSpace> TranslationSpace
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_ModifyBone.__PropertyOffset_TranslationSpace);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_ModifyBone.__PropertyOffset_TranslationSpace) = value;
			}
		}

		// Token: 0x17000A5B RID: 2651
		// (get) Token: 0x06002A52 RID: 10834 RVA: 0x000403C3 File Offset: 0x0003E5C3
		// (set) Token: 0x06002A53 RID: 10835 RVA: 0x000403D7 File Offset: 0x0003E5D7
		public unsafe TEnumAsByte<EBoneControlSpace> RotationSpace
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_ModifyBone.__PropertyOffset_RotationSpace);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_ModifyBone.__PropertyOffset_RotationSpace) = value;
			}
		}

		// Token: 0x17000A5C RID: 2652
		// (get) Token: 0x06002A54 RID: 10836 RVA: 0x000403EC File Offset: 0x0003E5EC
		// (set) Token: 0x06002A55 RID: 10837 RVA: 0x00040400 File Offset: 0x0003E600
		public unsafe TEnumAsByte<EBoneControlSpace> ScaleSpace
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_ModifyBone.__PropertyOffset_ScaleSpace);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_ModifyBone.__PropertyOffset_ScaleSpace) = value;
			}
		}

		// Token: 0x06002A56 RID: 10838 RVA: 0x00040415 File Offset: 0x0003E615
		public FAnimNode_ModifyBone()
		{
		}

		// Token: 0x06002A57 RID: 10839 RVA: 0x00040420 File Offset: 0x0003E620
		public FAnimNode_ModifyBone([Nullable(1)] FBoneReference BoneToModify, FVector Translation, FRotator Rotation, FVector Scale, TEnumAsByte<EBoneModificationMode> TranslationMode, TEnumAsByte<EBoneModificationMode> RotationMode, TEnumAsByte<EBoneModificationMode> ScaleMode, TEnumAsByte<EBoneControlSpace> TranslationSpace, TEnumAsByte<EBoneControlSpace> RotationSpace, TEnumAsByte<EBoneControlSpace> ScaleSpace, [Nullable(1)] FComponentSpacePoseLink ComponentPose, int LODThreshold, int KuroLODMask, float ActualAlpha, EAnimAlphaInputType AlphaInputType, bool bAlphaBoolEnabled, bool bParallelEvalEnabled, bool bEnableOnMobile, float Alpha, [Nullable(1)] FInputScaleBias AlphaScaleBias, [Nullable(1)] FInputAlphaBoolBlend AlphaBoolBlend, FName AlphaCurveName, [Nullable(1)] FInputScaleBiasClamp AlphaScaleBiasClamp)
		{
			this.BoneToModify = BoneToModify;
			this.Translation = Translation;
			this.Rotation = Rotation;
			this.Scale = Scale;
			this.TranslationMode = TranslationMode;
			this.RotationMode = RotationMode;
			this.ScaleMode = ScaleMode;
			this.TranslationSpace = TranslationSpace;
			this.RotationSpace = RotationSpace;
			this.ScaleSpace = ScaleSpace;
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

		// Token: 0x06002A58 RID: 10840 RVA: 0x000404E8 File Offset: 0x0003E6E8
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_ModifyBone.StaticStruct();
		}

		// Token: 0x06002A59 RID: 10841 RVA: 0x000404F4 File Offset: 0x0003E6F4
		[NullableContext(2)]
		public FAnimNode_ModifyBone(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002A5A RID: 10842 RVA: 0x000404FE File Offset: 0x0003E6FE
		public FAnimNode_ModifyBone(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002A5B RID: 10843 RVA: 0x00040509 File Offset: 0x0003E709
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_ModifyBone(Pointer, false, true);
		}

		// Token: 0x06002A5C RID: 10844 RVA: 0x00040513 File Offset: 0x0003E713
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_ModifyBone(Pointer, MemoryOwner);
		}

		// Token: 0x04001114 RID: 4372
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AnimGraphRuntime.AnimNode_ModifyBone";

		// Token: 0x04001115 RID: 4373
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001116 RID: 4374
		internal static int __PropertyOffset_BoneToModify;

		// Token: 0x04001117 RID: 4375
		[Nullable(2)]
		private FBoneReference _BoneToModify;

		// Token: 0x04001118 RID: 4376
		internal static int __PropertyOffset_Translation;

		// Token: 0x04001119 RID: 4377
		internal static int __PropertyOffset_Rotation;

		// Token: 0x0400111A RID: 4378
		internal static int __PropertyOffset_Scale;

		// Token: 0x0400111B RID: 4379
		internal static int __PropertyOffset_TranslationMode;

		// Token: 0x0400111C RID: 4380
		internal static int __PropertyOffset_RotationMode;

		// Token: 0x0400111D RID: 4381
		internal static int __PropertyOffset_ScaleMode;

		// Token: 0x0400111E RID: 4382
		internal static int __PropertyOffset_TranslationSpace;

		// Token: 0x0400111F RID: 4383
		internal static int __PropertyOffset_RotationSpace;

		// Token: 0x04001120 RID: 4384
		internal static int __PropertyOffset_ScaleSpace;
	}
}
