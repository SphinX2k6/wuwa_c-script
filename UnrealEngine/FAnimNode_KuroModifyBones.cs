using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001613 RID: 5651
	[UnrealObjectPath("/Script/KuroAnim.AnimNode_KuroModifyBones")]
	[UnrealStructLayout(504, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 504)]
	public class FAnimNode_KuroModifyBones : FAnimNode_SkeletalControlBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601468E RID: 83598 RVA: 0x001E0148 File Offset: 0x001DE348
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_KuroModifyBones._ScriptStructPtr != 0) ? FAnimNode_KuroModifyBones._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.AnimNode_KuroModifyBones", ref FAnimNode_KuroModifyBones._ScriptStructPtr);
		}

		// Token: 0x1700503D RID: 20541
		// (get) Token: 0x0601468F RID: 83599 RVA: 0x001E016C File Offset: 0x001DE36C
		// (set) Token: 0x06014690 RID: 83600 RVA: 0x001E01AF File Offset: 0x001DE3AF
		[Nullable(1)]
		public TMap<FName, FTransform> BoneTransformsMap
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FTransform> result;
				if ((result = this._BoneTransformsMap) == null)
				{
					result = (this._BoneTransformsMap = new TMap<FName, FTransform>(base.NativePtr + (IntPtr)FAnimNode_KuroModifyBones.__PropertyOffset_BoneTransformsMap, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.BoneTransformsMap.CopyAssign(value);
			}
		}

		// Token: 0x1700503E RID: 20542
		// (get) Token: 0x06014691 RID: 83601 RVA: 0x001E01BD File Offset: 0x001DE3BD
		// (set) Token: 0x06014692 RID: 83602 RVA: 0x001E01D1 File Offset: 0x001DE3D1
		public unsafe TEnumAsByte<EBoneModificationMode> TranslationMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_KuroModifyBones.__PropertyOffset_TranslationMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KuroModifyBones.__PropertyOffset_TranslationMode) = value;
			}
		}

		// Token: 0x1700503F RID: 20543
		// (get) Token: 0x06014693 RID: 83603 RVA: 0x001E01E6 File Offset: 0x001DE3E6
		// (set) Token: 0x06014694 RID: 83604 RVA: 0x001E01FA File Offset: 0x001DE3FA
		public unsafe TEnumAsByte<EBoneModificationMode> RotationMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_KuroModifyBones.__PropertyOffset_RotationMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KuroModifyBones.__PropertyOffset_RotationMode) = value;
			}
		}

		// Token: 0x17005040 RID: 20544
		// (get) Token: 0x06014695 RID: 83605 RVA: 0x001E020F File Offset: 0x001DE40F
		// (set) Token: 0x06014696 RID: 83606 RVA: 0x001E0223 File Offset: 0x001DE423
		public unsafe TEnumAsByte<EBoneModificationMode> ScaleMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_KuroModifyBones.__PropertyOffset_ScaleMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KuroModifyBones.__PropertyOffset_ScaleMode) = value;
			}
		}

		// Token: 0x17005041 RID: 20545
		// (get) Token: 0x06014697 RID: 83607 RVA: 0x001E0238 File Offset: 0x001DE438
		// (set) Token: 0x06014698 RID: 83608 RVA: 0x001E024C File Offset: 0x001DE44C
		public unsafe TEnumAsByte<EBoneControlSpace> TranslationSpace
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_KuroModifyBones.__PropertyOffset_TranslationSpace);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KuroModifyBones.__PropertyOffset_TranslationSpace) = value;
			}
		}

		// Token: 0x17005042 RID: 20546
		// (get) Token: 0x06014699 RID: 83609 RVA: 0x001E0261 File Offset: 0x001DE461
		// (set) Token: 0x0601469A RID: 83610 RVA: 0x001E0275 File Offset: 0x001DE475
		public unsafe TEnumAsByte<EBoneControlSpace> RotationSpace
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_KuroModifyBones.__PropertyOffset_RotationSpace);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KuroModifyBones.__PropertyOffset_RotationSpace) = value;
			}
		}

		// Token: 0x17005043 RID: 20547
		// (get) Token: 0x0601469B RID: 83611 RVA: 0x001E028A File Offset: 0x001DE48A
		// (set) Token: 0x0601469C RID: 83612 RVA: 0x001E029E File Offset: 0x001DE49E
		public unsafe TEnumAsByte<EBoneControlSpace> ScaleSpace
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_KuroModifyBones.__PropertyOffset_ScaleSpace);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_KuroModifyBones.__PropertyOffset_ScaleSpace) = value;
			}
		}

		// Token: 0x0601469D RID: 83613 RVA: 0x001E02B3 File Offset: 0x001DE4B3
		public FAnimNode_KuroModifyBones()
		{
		}

		// Token: 0x0601469E RID: 83614 RVA: 0x001E02BC File Offset: 0x001DE4BC
		public FAnimNode_KuroModifyBones([Nullable(1)] TMap<FName, FTransform> BoneTransformsMap, TEnumAsByte<EBoneModificationMode> TranslationMode, TEnumAsByte<EBoneModificationMode> RotationMode, TEnumAsByte<EBoneModificationMode> ScaleMode, TEnumAsByte<EBoneControlSpace> TranslationSpace, TEnumAsByte<EBoneControlSpace> RotationSpace, TEnumAsByte<EBoneControlSpace> ScaleSpace, [Nullable(1)] FComponentSpacePoseLink ComponentPose, int LODThreshold, int KuroLODMask, float ActualAlpha, EAnimAlphaInputType AlphaInputType, bool bAlphaBoolEnabled, bool bParallelEvalEnabled, bool bEnableOnMobile, float Alpha, [Nullable(1)] FInputScaleBias AlphaScaleBias, [Nullable(1)] FInputAlphaBoolBlend AlphaBoolBlend, FName AlphaCurveName, [Nullable(1)] FInputScaleBiasClamp AlphaScaleBiasClamp)
		{
			this.BoneTransformsMap = BoneTransformsMap;
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

		// Token: 0x0601469F RID: 83615 RVA: 0x001E036C File Offset: 0x001DE56C
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_KuroModifyBones.StaticStruct();
		}

		// Token: 0x060146A0 RID: 83616 RVA: 0x001E0378 File Offset: 0x001DE578
		[NullableContext(2)]
		public FAnimNode_KuroModifyBones(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060146A1 RID: 83617 RVA: 0x001E0382 File Offset: 0x001DE582
		public FAnimNode_KuroModifyBones(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060146A2 RID: 83618 RVA: 0x001E038D File Offset: 0x001DE58D
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_KuroModifyBones(Pointer, false, true);
		}

		// Token: 0x060146A3 RID: 83619 RVA: 0x001E0397 File Offset: 0x001DE597
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_KuroModifyBones(Pointer, MemoryOwner);
		}

		// Token: 0x0400B1AF RID: 45487
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroAnim.AnimNode_KuroModifyBones";

		// Token: 0x0400B1B0 RID: 45488
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B1B1 RID: 45489
		internal static int __PropertyOffset_BoneTransformsMap;

		// Token: 0x0400B1B2 RID: 45490
		[Nullable(2)]
		private TMap<FName, FTransform> _BoneTransformsMap;

		// Token: 0x0400B1B3 RID: 45491
		internal static int __PropertyOffset_TranslationMode;

		// Token: 0x0400B1B4 RID: 45492
		internal static int __PropertyOffset_RotationMode;

		// Token: 0x0400B1B5 RID: 45493
		internal static int __PropertyOffset_ScaleMode;

		// Token: 0x0400B1B6 RID: 45494
		internal static int __PropertyOffset_TranslationSpace;

		// Token: 0x0400B1B7 RID: 45495
		internal static int __PropertyOffset_RotationSpace;

		// Token: 0x0400B1B8 RID: 45496
		internal static int __PropertyOffset_ScaleSpace;
	}
}
