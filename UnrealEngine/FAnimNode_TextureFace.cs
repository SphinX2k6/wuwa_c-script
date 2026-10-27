using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001623 RID: 5667
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.AnimNode_TextureFace")]
	[UnrealStructLayout(216, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 216)]
	public class FAnimNode_TextureFace : FAnimNode_Base, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060147CC RID: 83916 RVA: 0x001E2324 File Offset: 0x001E0524
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_TextureFace._ScriptStructPtr != 0) ? FAnimNode_TextureFace._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.AnimNode_TextureFace", ref FAnimNode_TextureFace._ScriptStructPtr);
		}

		// Token: 0x1700509C RID: 20636
		// (get) Token: 0x060147CD RID: 83917 RVA: 0x001E2348 File Offset: 0x001E0548
		// (set) Token: 0x060147CE RID: 83918 RVA: 0x001E238B File Offset: 0x001E058B
		public FPoseLink Base
		{
			get
			{
				base.FastCheckIsValid();
				FPoseLink result;
				if ((result = this._Base) == null)
				{
					result = (this._Base = new FPoseLink(base.NativePtr + (IntPtr)FAnimNode_TextureFace.__PropertyOffset_Base, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_TextureFace.__PropertyOffset_Base, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700509D RID: 20637
		// (get) Token: 0x060147CF RID: 83919 RVA: 0x001E23AC File Offset: 0x001E05AC
		// (set) Token: 0x060147D0 RID: 83920 RVA: 0x001E23EF File Offset: 0x001E05EF
		public FPoseLink CurveAnim
		{
			get
			{
				base.FastCheckIsValid();
				FPoseLink result;
				if ((result = this._CurveAnim) == null)
				{
					result = (this._CurveAnim = new FPoseLink(base.NativePtr + (IntPtr)FAnimNode_TextureFace.__PropertyOffset_CurveAnim, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_TextureFace.__PropertyOffset_CurveAnim, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700509E RID: 20638
		// (get) Token: 0x060147D1 RID: 83921 RVA: 0x001E2410 File Offset: 0x001E0610
		// (set) Token: 0x060147D2 RID: 83922 RVA: 0x001E2420 File Offset: 0x001E0620
		public unsafe bool Enable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_TextureFace.__PropertyOffset_Enable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_TextureFace.__PropertyOffset_Enable) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700509F RID: 20639
		// (get) Token: 0x060147D3 RID: 83923 RVA: 0x001E2431 File Offset: 0x001E0631
		// (set) Token: 0x060147D4 RID: 83924 RVA: 0x001E2441 File Offset: 0x001E0641
		public unsafe float TexEyeOpenId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_TextureFace.__PropertyOffset_TexEyeOpenId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_TextureFace.__PropertyOffset_TexEyeOpenId) = value;
			}
		}

		// Token: 0x170050A0 RID: 20640
		// (get) Token: 0x060147D5 RID: 83925 RVA: 0x001E2452 File Offset: 0x001E0652
		// (set) Token: 0x060147D6 RID: 83926 RVA: 0x001E2462 File Offset: 0x001E0662
		public unsafe float TexEyeCloseId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_TextureFace.__PropertyOffset_TexEyeCloseId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_TextureFace.__PropertyOffset_TexEyeCloseId) = value;
			}
		}

		// Token: 0x170050A1 RID: 20641
		// (get) Token: 0x060147D7 RID: 83927 RVA: 0x001E2473 File Offset: 0x001E0673
		// (set) Token: 0x060147D8 RID: 83928 RVA: 0x001E2483 File Offset: 0x001E0683
		public unsafe float Alpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_TextureFace.__PropertyOffset_Alpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_TextureFace.__PropertyOffset_Alpha) = value;
			}
		}

		// Token: 0x170050A2 RID: 20642
		// (get) Token: 0x060147D9 RID: 83929 RVA: 0x001E2494 File Offset: 0x001E0694
		// (set) Token: 0x060147DA RID: 83930 RVA: 0x001E24A4 File Offset: 0x001E06A4
		public unsafe float TexEyeCloseThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_TextureFace.__PropertyOffset_TexEyeCloseThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_TextureFace.__PropertyOffset_TexEyeCloseThreshold) = value;
			}
		}

		// Token: 0x170050A3 RID: 20643
		// (get) Token: 0x060147DB RID: 83931 RVA: 0x001E24B5 File Offset: 0x001E06B5
		// (set) Token: 0x060147DC RID: 83932 RVA: 0x001E24C9 File Offset: 0x001E06C9
		[Nullable(2)]
		public unsafe USkeletalMeshComponent TexFaceMeshComp
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + FAnimNode_TextureFace.__PropertyOffset_TexFaceMeshComp);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FAnimNode_TextureFace.__PropertyOffset_TexFaceMeshComp, value);
			}
		}

		// Token: 0x170050A4 RID: 20644
		// (get) Token: 0x060147DD RID: 83933 RVA: 0x001E24DE File Offset: 0x001E06DE
		// (set) Token: 0x060147DE RID: 83934 RVA: 0x001E24F2 File Offset: 0x001E06F2
		public unsafe FName TexMatSlotName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_TextureFace.__PropertyOffset_TexMatSlotName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_TextureFace.__PropertyOffset_TexMatSlotName) = value;
			}
		}

		// Token: 0x170050A5 RID: 20645
		// (get) Token: 0x060147DF RID: 83935 RVA: 0x001E2507 File Offset: 0x001E0707
		// (set) Token: 0x060147E0 RID: 83936 RVA: 0x001E251B File Offset: 0x001E071B
		public unsafe FName TexFaceSwitchKey
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_TextureFace.__PropertyOffset_TexFaceSwitchKey);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_TextureFace.__PropertyOffset_TexFaceSwitchKey) = value;
			}
		}

		// Token: 0x170050A6 RID: 20646
		// (get) Token: 0x060147E1 RID: 83937 RVA: 0x001E2530 File Offset: 0x001E0730
		// (set) Token: 0x060147E2 RID: 83938 RVA: 0x001E2544 File Offset: 0x001E0744
		public unsafe FName TexTargetCurveName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_TextureFace.__PropertyOffset_TexTargetCurveName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_TextureFace.__PropertyOffset_TexTargetCurveName) = value;
			}
		}

		// Token: 0x170050A7 RID: 20647
		// (get) Token: 0x060147E3 RID: 83939 RVA: 0x001E2559 File Offset: 0x001E0759
		// (set) Token: 0x060147E4 RID: 83940 RVA: 0x001E256D File Offset: 0x001E076D
		public unsafe FName FaceSwitchRowName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_TextureFace.__PropertyOffset_FaceSwitchRowName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_TextureFace.__PropertyOffset_FaceSwitchRowName) = value;
			}
		}

		// Token: 0x170050A8 RID: 20648
		// (get) Token: 0x060147E5 RID: 83941 RVA: 0x001E2582 File Offset: 0x001E0782
		// (set) Token: 0x060147E6 RID: 83942 RVA: 0x001E2592 File Offset: 0x001E0792
		public unsafe float FaceSwitchRowNum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_TextureFace.__PropertyOffset_FaceSwitchRowNum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_TextureFace.__PropertyOffset_FaceSwitchRowNum) = value;
			}
		}

		// Token: 0x170050A9 RID: 20649
		// (get) Token: 0x060147E7 RID: 83943 RVA: 0x001E25A4 File Offset: 0x001E07A4
		// (set) Token: 0x060147E8 RID: 83944 RVA: 0x001E25E7 File Offset: 0x001E07E7
		public TArray<FName> MouthCurves
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._MouthCurves) == null)
				{
					result = (this._MouthCurves = new TArray<FName>(base.NativePtr + (IntPtr)FAnimNode_TextureFace.__PropertyOffset_MouthCurves, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MouthCurves.CopyAssign(value);
			}
		}

		// Token: 0x170050AA RID: 20650
		// (get) Token: 0x060147E9 RID: 83945 RVA: 0x001E25F5 File Offset: 0x001E07F5
		// (set) Token: 0x060147EA RID: 83946 RVA: 0x001E2609 File Offset: 0x001E0809
		public unsafe FName MouthAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_TextureFace.__PropertyOffset_MouthAlpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_TextureFace.__PropertyOffset_MouthAlpha) = value;
			}
		}

		// Token: 0x170050AB RID: 20651
		// (get) Token: 0x060147EB RID: 83947 RVA: 0x001E261E File Offset: 0x001E081E
		// (set) Token: 0x060147EC RID: 83948 RVA: 0x001E262E File Offset: 0x001E082E
		public unsafe float MouthAlphaThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_TextureFace.__PropertyOffset_MouthAlphaThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_TextureFace.__PropertyOffset_MouthAlphaThreshold) = value;
			}
		}

		// Token: 0x170050AC RID: 20652
		// (get) Token: 0x060147ED RID: 83949 RVA: 0x001E263F File Offset: 0x001E083F
		// (set) Token: 0x060147EE RID: 83950 RVA: 0x001E264F File Offset: 0x001E084F
		public unsafe float OpenMouthThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_TextureFace.__PropertyOffset_OpenMouthThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_TextureFace.__PropertyOffset_OpenMouthThreshold) = value;
			}
		}

		// Token: 0x170050AD RID: 20653
		// (get) Token: 0x060147EF RID: 83951 RVA: 0x001E2660 File Offset: 0x001E0860
		// (set) Token: 0x060147F0 RID: 83952 RVA: 0x001E2670 File Offset: 0x001E0870
		public unsafe float OpenMouthTexId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_TextureFace.__PropertyOffset_OpenMouthTexId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_TextureFace.__PropertyOffset_OpenMouthTexId) = value;
			}
		}

		// Token: 0x060147F1 RID: 83953 RVA: 0x001E2681 File Offset: 0x001E0881
		public FAnimNode_TextureFace()
		{
		}

		// Token: 0x060147F2 RID: 83954 RVA: 0x001E268C File Offset: 0x001E088C
		public FAnimNode_TextureFace(FPoseLink Base, FPoseLink CurveAnim, bool Enable, float TexEyeOpenId, float TexEyeCloseId, float Alpha, float TexEyeCloseThreshold, USkeletalMeshComponent TexFaceMeshComp, FName TexMatSlotName, FName TexFaceSwitchKey, FName TexTargetCurveName, FName FaceSwitchRowName, float FaceSwitchRowNum, TArray<FName> MouthCurves, FName MouthAlpha, float MouthAlphaThreshold, float OpenMouthThreshold, float OpenMouthTexId)
		{
			this.Base = Base;
			this.CurveAnim = CurveAnim;
			this.Enable = Enable;
			this.TexEyeOpenId = TexEyeOpenId;
			this.TexEyeCloseId = TexEyeCloseId;
			this.Alpha = Alpha;
			this.TexEyeCloseThreshold = TexEyeCloseThreshold;
			this.TexFaceMeshComp = TexFaceMeshComp;
			this.TexMatSlotName = TexMatSlotName;
			this.TexFaceSwitchKey = TexFaceSwitchKey;
			this.TexTargetCurveName = TexTargetCurveName;
			this.FaceSwitchRowName = FaceSwitchRowName;
			this.FaceSwitchRowNum = FaceSwitchRowNum;
			this.MouthCurves = MouthCurves;
			this.MouthAlpha = MouthAlpha;
			this.MouthAlphaThreshold = MouthAlphaThreshold;
			this.OpenMouthThreshold = OpenMouthThreshold;
			this.OpenMouthTexId = OpenMouthTexId;
		}

		// Token: 0x060147F3 RID: 83955 RVA: 0x001E272C File Offset: 0x001E092C
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_TextureFace.StaticStruct();
		}

		// Token: 0x060147F4 RID: 83956 RVA: 0x001E2738 File Offset: 0x001E0938
		[NullableContext(2)]
		public FAnimNode_TextureFace(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060147F5 RID: 83957 RVA: 0x001E2742 File Offset: 0x001E0942
		public FAnimNode_TextureFace(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060147F6 RID: 83958 RVA: 0x001E274D File Offset: 0x001E094D
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_TextureFace(Pointer, false, true);
		}

		// Token: 0x060147F7 RID: 83959 RVA: 0x001E2757 File Offset: 0x001E0957
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_TextureFace(Pointer, MemoryOwner);
		}

		// Token: 0x0400B248 RID: 45640
		public new const string __ObjectPath = "/Script/KuroAnim.AnimNode_TextureFace";

		// Token: 0x0400B249 RID: 45641
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B24A RID: 45642
		internal static int __PropertyOffset_Base;

		// Token: 0x0400B24B RID: 45643
		[Nullable(2)]
		private FPoseLink _Base;

		// Token: 0x0400B24C RID: 45644
		internal static int __PropertyOffset_CurveAnim;

		// Token: 0x0400B24D RID: 45645
		[Nullable(2)]
		private FPoseLink _CurveAnim;

		// Token: 0x0400B24E RID: 45646
		internal static int __PropertyOffset_Enable;

		// Token: 0x0400B24F RID: 45647
		internal static int __PropertyOffset_TexEyeOpenId;

		// Token: 0x0400B250 RID: 45648
		internal static int __PropertyOffset_TexEyeCloseId;

		// Token: 0x0400B251 RID: 45649
		internal static int __PropertyOffset_Alpha;

		// Token: 0x0400B252 RID: 45650
		internal static int __PropertyOffset_TexEyeCloseThreshold;

		// Token: 0x0400B253 RID: 45651
		internal static int __PropertyOffset_TexFaceMeshComp;

		// Token: 0x0400B254 RID: 45652
		internal static int __PropertyOffset_TexMatSlotName;

		// Token: 0x0400B255 RID: 45653
		internal static int __PropertyOffset_TexFaceSwitchKey;

		// Token: 0x0400B256 RID: 45654
		internal static int __PropertyOffset_TexTargetCurveName;

		// Token: 0x0400B257 RID: 45655
		internal static int __PropertyOffset_FaceSwitchRowName;

		// Token: 0x0400B258 RID: 45656
		internal static int __PropertyOffset_FaceSwitchRowNum;

		// Token: 0x0400B259 RID: 45657
		internal static int __PropertyOffset_MouthCurves;

		// Token: 0x0400B25A RID: 45658
		[Nullable(2)]
		private TArray<FName> _MouthCurves;

		// Token: 0x0400B25B RID: 45659
		internal static int __PropertyOffset_MouthAlpha;

		// Token: 0x0400B25C RID: 45660
		internal static int __PropertyOffset_MouthAlphaThreshold;

		// Token: 0x0400B25D RID: 45661
		internal static int __PropertyOffset_OpenMouthThreshold;

		// Token: 0x0400B25E RID: 45662
		internal static int __PropertyOffset_OpenMouthTexId;
	}
}
