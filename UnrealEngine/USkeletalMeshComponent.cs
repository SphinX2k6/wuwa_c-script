using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020010F7 RID: 4343
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SkeletalMeshComponent")]
	[UnrealStructLayout(6016, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 6016)]
	public class USkeletalMeshComponent : USkinnedMeshComponent, IUnrealUObject, IUnrealObject, IInterface_CollisionDataProvider, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0600F9EC RID: 63980 RVA: 0x001718BC File Offset: 0x0016FABC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USkeletalMeshComponent._ClassPtr;
		}

		// Token: 0x0600F9ED RID: 63981 RVA: 0x001718C8 File Offset: 0x0016FAC8
		int IInterface_CollisionDataProvider.InterfaceOffset()
		{
			return USkeletalMeshComponent.__InterfaceOffset_IInterface_CollisionDataProvider;
		}

		// Token: 0x0600F9EE RID: 63982 RVA: 0x001718D0 File Offset: 0x0016FAD0
		public USkeletalMeshComponent() : this(BuiltinUtils.AllocNativeUObject(USkeletalMeshComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600F9EF RID: 63983 RVA: 0x001718F8 File Offset: 0x0016FAF8
		[NullableContext(1)]
		public USkeletalMeshComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USkeletalMeshComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003CF0 RID: 15600
		// (get) Token: 0x0600F9F0 RID: 63984 RVA: 0x0017192B File Offset: 0x0016FB2B
		// (set) Token: 0x0600F9F1 RID: 63985 RVA: 0x0017193F File Offset: 0x0016FB3F
		public unsafe UClassStackOnlyPtr AnimBlueprintGeneratedClass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_AnimBlueprintGeneratedClass);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_AnimBlueprintGeneratedClass) = value;
			}
		}

		// Token: 0x17003CF1 RID: 15601
		// (get) Token: 0x0600F9F2 RID: 63986 RVA: 0x00171954 File Offset: 0x0016FB54
		// (set) Token: 0x0600F9F3 RID: 63987 RVA: 0x00171968 File Offset: 0x0016FB68
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UAnimInstance> AnimClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_AnimClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_AnimClass) = value;
			}
		}

		// Token: 0x17003CF2 RID: 15602
		// (get) Token: 0x0600F9F4 RID: 63988 RVA: 0x0017197D File Offset: 0x0016FB7D
		// (set) Token: 0x0600F9F5 RID: 63989 RVA: 0x00171991 File Offset: 0x0016FB91
		public unsafe UAnimInstance AnimScriptInstance
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimInstance>(base.NativePtr / (IntPtr)sizeof(void*) + USkeletalMeshComponent.__PropertyOffset_AnimScriptInstance);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USkeletalMeshComponent.__PropertyOffset_AnimScriptInstance, value);
			}
		}

		// Token: 0x17003CF3 RID: 15603
		// (get) Token: 0x0600F9F6 RID: 63990 RVA: 0x001719A6 File Offset: 0x0016FBA6
		// (set) Token: 0x0600F9F7 RID: 63991 RVA: 0x001719BA File Offset: 0x0016FBBA
		public unsafe UAnimInstance PostProcessAnimInstance
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimInstance>(base.NativePtr / (IntPtr)sizeof(void*) + USkeletalMeshComponent.__PropertyOffset_PostProcessAnimInstance);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USkeletalMeshComponent.__PropertyOffset_PostProcessAnimInstance, value);
			}
		}

		// Token: 0x17003CF4 RID: 15604
		// (get) Token: 0x0600F9F8 RID: 63992 RVA: 0x001719CF File Offset: 0x0016FBCF
		// (set) Token: 0x0600F9F9 RID: 63993 RVA: 0x001719E3 File Offset: 0x0016FBE3
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UAnimInstance> KuroPostProcessAnimBlueprint
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_KuroPostProcessAnimBlueprint);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_KuroPostProcessAnimBlueprint) = value;
			}
		}

		// Token: 0x17003CF5 RID: 15605
		// (get) Token: 0x0600F9FA RID: 63994 RVA: 0x001719F8 File Offset: 0x0016FBF8
		// (set) Token: 0x0600F9FB RID: 63995 RVA: 0x00171A0C File Offset: 0x0016FC0C
		public unsafe UAnimInstance PredictionAnimInstance
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimInstance>(base.NativePtr / (IntPtr)sizeof(void*) + USkeletalMeshComponent.__PropertyOffset_PredictionAnimInstance);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USkeletalMeshComponent.__PropertyOffset_PredictionAnimInstance, value);
			}
		}

		// Token: 0x17003CF6 RID: 15606
		// (get) Token: 0x0600F9FC RID: 63996 RVA: 0x00171A24 File Offset: 0x0016FC24
		// (set) Token: 0x0600F9FD RID: 63997 RVA: 0x00171A5D File Offset: 0x0016FC5D
		[Nullable(1)]
		public FSingleAnimationPlayData AnimationData
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FSingleAnimationPlayData result;
				if ((result = this._AnimationData) == null)
				{
					result = (this._AnimationData = new FSingleAnimationPlayData(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_AnimationData, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSingleAnimationPlayData.StaticStruct(), base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_AnimationData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003CF7 RID: 15607
		// (get) Token: 0x0600F9FE RID: 63998 RVA: 0x00171A7E File Offset: 0x0016FC7E
		// (set) Token: 0x0600F9FF RID: 63999 RVA: 0x00171A8E File Offset: 0x0016FC8E
		public unsafe bool bKuroForceShears
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bKuroForceShears) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bKuroForceShears) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003CF8 RID: 15608
		// (get) Token: 0x0600FA00 RID: 64000 RVA: 0x00171A9F File Offset: 0x0016FC9F
		// (set) Token: 0x0600FA01 RID: 64001 RVA: 0x00171AB3 File Offset: 0x0016FCB3
		public unsafe FVector RootBoneTranslation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_RootBoneTranslation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_RootBoneTranslation) = value;
			}
		}

		// Token: 0x17003CF9 RID: 15609
		// (get) Token: 0x0600FA02 RID: 64002 RVA: 0x00171AC8 File Offset: 0x0016FCC8
		// (set) Token: 0x0600FA03 RID: 64003 RVA: 0x00171ADC File Offset: 0x0016FCDC
		public unsafe FVector LineCheckBoundsScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_LineCheckBoundsScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_LineCheckBoundsScale) = value;
			}
		}

		// Token: 0x17003CFA RID: 15610
		// (get) Token: 0x0600FA04 RID: 64004 RVA: 0x00171AF1 File Offset: 0x0016FCF1
		// (set) Token: 0x0600FA05 RID: 64005 RVA: 0x00171B0A File Offset: 0x0016FD0A
		public unsafe bool bRenderInKuroXRayPass
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bRenderInKuroXRayPass) & USkeletalMeshComponent.__PropertyMask_bRenderInKuroXRayPass) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bRenderInKuroXRayPass) = ((*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bRenderInKuroXRayPass) & ~USkeletalMeshComponent.__PropertyMask_bRenderInKuroXRayPass) | (value ? USkeletalMeshComponent.__PropertyMask_bRenderInKuroXRayPass : 0));
			}
		}

		// Token: 0x17003CFB RID: 15611
		// (get) Token: 0x0600FA06 RID: 64006 RVA: 0x00171B3A File Offset: 0x0016FD3A
		// (set) Token: 0x0600FA07 RID: 64007 RVA: 0x00171B4E File Offset: 0x0016FD4E
		public unsafe FLinearColor KuroXRayColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_KuroXRayColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_KuroXRayColor) = value;
			}
		}

		// Token: 0x17003CFC RID: 15612
		// (get) Token: 0x0600FA08 RID: 64008 RVA: 0x00171B63 File Offset: 0x0016FD63
		// (set) Token: 0x0600FA09 RID: 64009 RVA: 0x00171B77 File Offset: 0x0016FD77
		public unsafe UMaterialInterface KuroXRayMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + USkeletalMeshComponent.__PropertyOffset_KuroXRayMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USkeletalMeshComponent.__PropertyOffset_KuroXRayMaterial, value);
			}
		}

		// Token: 0x17003CFD RID: 15613
		// (get) Token: 0x0600FA0A RID: 64010 RVA: 0x00171B8C File Offset: 0x0016FD8C
		// (set) Token: 0x0600FA0B RID: 64011 RVA: 0x00171BA0 File Offset: 0x0016FDA0
		public unsafe UMaterialInterface KuroXRayOutlineMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + USkeletalMeshComponent.__PropertyOffset_KuroXRayOutlineMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USkeletalMeshComponent.__PropertyOffset_KuroXRayOutlineMaterial, value);
			}
		}

		// Token: 0x17003CFE RID: 15614
		// (get) Token: 0x0600FA0C RID: 64012 RVA: 0x00171BB5 File Offset: 0x0016FDB5
		// (set) Token: 0x0600FA0D RID: 64013 RVA: 0x00171BC5 File Offset: 0x0016FDC5
		public unsafe float KuroXRayDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_KuroXRayDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_KuroXRayDistance) = value;
			}
		}

		// Token: 0x17003CFF RID: 15615
		// (get) Token: 0x0600FA0E RID: 64014 RVA: 0x00171BD6 File Offset: 0x0016FDD6
		// (set) Token: 0x0600FA0F RID: 64015 RVA: 0x00171BE6 File Offset: 0x0016FDE6
		public unsafe float KuroXRayOutlineWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_KuroXRayOutlineWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_KuroXRayOutlineWidth) = value;
			}
		}

		// Token: 0x17003D00 RID: 15616
		// (get) Token: 0x0600FA10 RID: 64016 RVA: 0x00171BF7 File Offset: 0x0016FDF7
		// (set) Token: 0x0600FA11 RID: 64017 RVA: 0x00171C10 File Offset: 0x0016FE10
		public unsafe bool bKuroXRayPenetrateCharacters
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bKuroXRayPenetrateCharacters) & USkeletalMeshComponent.__PropertyMask_bKuroXRayPenetrateCharacters) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bKuroXRayPenetrateCharacters) = ((*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bKuroXRayPenetrateCharacters) & ~USkeletalMeshComponent.__PropertyMask_bKuroXRayPenetrateCharacters) | (value ? USkeletalMeshComponent.__PropertyMask_bKuroXRayPenetrateCharacters : 0));
			}
		}

		// Token: 0x17003D01 RID: 15617
		// (get) Token: 0x0600FA12 RID: 64018 RVA: 0x00171C40 File Offset: 0x0016FE40
		// (set) Token: 0x0600FA13 RID: 64019 RVA: 0x00171C59 File Offset: 0x0016FE59
		public unsafe bool bKuroXRayPenetrateCharactersFromDA
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bKuroXRayPenetrateCharactersFromDA) & USkeletalMeshComponent.__PropertyMask_bKuroXRayPenetrateCharactersFromDA) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bKuroXRayPenetrateCharactersFromDA) = ((*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bKuroXRayPenetrateCharactersFromDA) & ~USkeletalMeshComponent.__PropertyMask_bKuroXRayPenetrateCharactersFromDA) | (value ? USkeletalMeshComponent.__PropertyMask_bKuroXRayPenetrateCharactersFromDA : 0));
			}
		}

		// Token: 0x17003D02 RID: 15618
		// (get) Token: 0x0600FA14 RID: 64020 RVA: 0x00171C89 File Offset: 0x0016FE89
		// (set) Token: 0x0600FA15 RID: 64021 RVA: 0x00171CA2 File Offset: 0x0016FEA2
		public unsafe bool bKuroXRayPenetrateCharactersFromDAValid
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bKuroXRayPenetrateCharactersFromDAValid) & USkeletalMeshComponent.__PropertyMask_bKuroXRayPenetrateCharactersFromDAValid) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bKuroXRayPenetrateCharactersFromDAValid) = ((*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bKuroXRayPenetrateCharactersFromDAValid) & ~USkeletalMeshComponent.__PropertyMask_bKuroXRayPenetrateCharactersFromDAValid) | (value ? USkeletalMeshComponent.__PropertyMask_bKuroXRayPenetrateCharactersFromDAValid : 0));
			}
		}

		// Token: 0x17003D03 RID: 15619
		// (get) Token: 0x0600FA16 RID: 64022 RVA: 0x00171CD2 File Offset: 0x0016FED2
		// (set) Token: 0x0600FA17 RID: 64023 RVA: 0x00171CE2 File Offset: 0x0016FEE2
		public unsafe EKuroMaterialControllerUpdateGroupMode KuroMaterialControllerUpdateGroupMode
		{
			get
			{
				return (EKuroMaterialControllerUpdateGroupMode)(*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_KuroMaterialControllerUpdateGroupMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_KuroMaterialControllerUpdateGroupMode) = (byte)value;
			}
		}

		// Token: 0x17003D04 RID: 15620
		// (get) Token: 0x0600FA18 RID: 64024 RVA: 0x00171CF3 File Offset: 0x0016FEF3
		// (set) Token: 0x0600FA19 RID: 64025 RVA: 0x00171D07 File Offset: 0x0016FF07
		public unsafe FName KuroMaterialControllerCustomUpdateGroup
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_KuroMaterialControllerCustomUpdateGroup);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_KuroMaterialControllerCustomUpdateGroup) = value;
			}
		}

		// Token: 0x17003D05 RID: 15621
		// (get) Token: 0x0600FA1A RID: 64026 RVA: 0x00171D1C File Offset: 0x0016FF1C
		// (set) Token: 0x0600FA1B RID: 64027 RVA: 0x00171D35 File Offset: 0x0016FF35
		public unsafe bool bDisableWaterForToon
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bDisableWaterForToon) & USkeletalMeshComponent.__PropertyMask_bDisableWaterForToon) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bDisableWaterForToon) = ((*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bDisableWaterForToon) & ~USkeletalMeshComponent.__PropertyMask_bDisableWaterForToon) | (value ? USkeletalMeshComponent.__PropertyMask_bDisableWaterForToon : 0));
			}
		}

		// Token: 0x17003D06 RID: 15622
		// (get) Token: 0x0600FA1C RID: 64028 RVA: 0x00171D65 File Offset: 0x0016FF65
		// (set) Token: 0x0600FA1D RID: 64029 RVA: 0x00171D7E File Offset: 0x0016FF7E
		public unsafe bool bOverrideSkeletalMeshScreenSizeCullRatio
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bOverrideSkeletalMeshScreenSizeCullRatio) & USkeletalMeshComponent.__PropertyMask_bOverrideSkeletalMeshScreenSizeCullRatio) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bOverrideSkeletalMeshScreenSizeCullRatio) = ((*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bOverrideSkeletalMeshScreenSizeCullRatio) & ~USkeletalMeshComponent.__PropertyMask_bOverrideSkeletalMeshScreenSizeCullRatio) | (value ? USkeletalMeshComponent.__PropertyMask_bOverrideSkeletalMeshScreenSizeCullRatio : 0));
			}
		}

		// Token: 0x17003D07 RID: 15623
		// (get) Token: 0x0600FA1E RID: 64030 RVA: 0x00171DAE File Offset: 0x0016FFAE
		// (set) Token: 0x0600FA1F RID: 64031 RVA: 0x00171DBE File Offset: 0x0016FFBE
		public unsafe float SkeletalMeshScreenSizeCullRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_SkeletalMeshScreenSizeCullRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_SkeletalMeshScreenSizeCullRatio) = value;
			}
		}

		// Token: 0x17003D08 RID: 15624
		// (get) Token: 0x0600FA20 RID: 64032 RVA: 0x00171DCF File Offset: 0x0016FFCF
		// (set) Token: 0x0600FA21 RID: 64033 RVA: 0x00171DDF File Offset: 0x0016FFDF
		public unsafe int KuroAnimInstanceLod
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_KuroAnimInstanceLod);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_KuroAnimInstanceLod) = value;
			}
		}

		// Token: 0x17003D09 RID: 15625
		// (get) Token: 0x0600FA22 RID: 64034 RVA: 0x00171DF0 File Offset: 0x0016FFF0
		// (set) Token: 0x0600FA23 RID: 64035 RVA: 0x00171E00 File Offset: 0x00170000
		public unsafe int KuroLodMask
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_KuroLodMask);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_KuroLodMask) = value;
			}
		}

		// Token: 0x17003D0A RID: 15626
		// (get) Token: 0x0600FA24 RID: 64036 RVA: 0x00171E11 File Offset: 0x00170011
		// (set) Token: 0x0600FA25 RID: 64037 RVA: 0x00171E25 File Offset: 0x00170025
		public unsafe FVector KuroClothWind
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_KuroClothWind);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_KuroClothWind) = value;
			}
		}

		// Token: 0x17003D0B RID: 15627
		// (get) Token: 0x0600FA26 RID: 64038 RVA: 0x00171E3A File Offset: 0x0017003A
		// (set) Token: 0x0600FA27 RID: 64039 RVA: 0x00171E4A File Offset: 0x0017004A
		public unsafe float KuroClothCapsuleHalfHeightOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_KuroClothCapsuleHalfHeightOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_KuroClothCapsuleHalfHeightOffset) = value;
			}
		}

		// Token: 0x17003D0C RID: 15628
		// (get) Token: 0x0600FA28 RID: 64040 RVA: 0x00171E5B File Offset: 0x0017005B
		// (set) Token: 0x0600FA29 RID: 64041 RVA: 0x00171E6B File Offset: 0x0017006B
		public unsafe float KuroClothCapsuleRadiusOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_KuroClothCapsuleRadiusOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_KuroClothCapsuleRadiusOffset) = value;
			}
		}

		// Token: 0x17003D0D RID: 15629
		// (get) Token: 0x0600FA2A RID: 64042 RVA: 0x00171E7C File Offset: 0x0017007C
		// (set) Token: 0x0600FA2B RID: 64043 RVA: 0x00171EB5 File Offset: 0x001700B5
		[Nullable(1)]
		public FKAggregateGeom SelfAggGeom
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FKAggregateGeom result;
				if ((result = this._SelfAggGeom) == null)
				{
					result = (this._SelfAggGeom = new FKAggregateGeom(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_SelfAggGeom, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKAggregateGeom.StaticStruct(), base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_SelfAggGeom, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003D0E RID: 15630
		// (get) Token: 0x0600FA2C RID: 64044 RVA: 0x00171ED6 File Offset: 0x001700D6
		// (set) Token: 0x0600FA2D RID: 64045 RVA: 0x00171EEF File Offset: 0x001700EF
		public unsafe bool bKuroSkipAnimNotifies
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bKuroSkipAnimNotifies) & USkeletalMeshComponent.__PropertyMask_bKuroSkipAnimNotifies) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bKuroSkipAnimNotifies) = ((*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bKuroSkipAnimNotifies) & ~USkeletalMeshComponent.__PropertyMask_bKuroSkipAnimNotifies) | (value ? USkeletalMeshComponent.__PropertyMask_bKuroSkipAnimNotifies : 0));
			}
		}

		// Token: 0x17003D0F RID: 15631
		// (get) Token: 0x0600FA2E RID: 64046 RVA: 0x00171F20 File Offset: 0x00170120
		// (set) Token: 0x0600FA2F RID: 64047 RVA: 0x00171F59 File Offset: 0x00170159
		[Nullable(1)]
		public TArray<UAnimInstance> LinkedInstances
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UAnimInstance> result;
				if ((result = this._LinkedInstances) == null)
				{
					result = (this._LinkedInstances = new TArray<UAnimInstance>(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_LinkedInstances, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.LinkedInstances.CopyAssign(value);
			}
		}

		// Token: 0x17003D10 RID: 15632
		// (get) Token: 0x0600FA30 RID: 64048 RVA: 0x00171F68 File Offset: 0x00170168
		// (set) Token: 0x0600FA31 RID: 64049 RVA: 0x00171FA1 File Offset: 0x001701A1
		[Nullable(1)]
		public TArray<FTransform> CachedBoneSpaceTransforms
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FTransform> result;
				if ((result = this._CachedBoneSpaceTransforms) == null)
				{
					result = (this._CachedBoneSpaceTransforms = new TArray<FTransform>(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_CachedBoneSpaceTransforms, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.CachedBoneSpaceTransforms.CopyAssign(value);
			}
		}

		// Token: 0x17003D11 RID: 15633
		// (get) Token: 0x0600FA32 RID: 64050 RVA: 0x00171FB0 File Offset: 0x001701B0
		// (set) Token: 0x0600FA33 RID: 64051 RVA: 0x00171FE9 File Offset: 0x001701E9
		[Nullable(1)]
		public TArray<FTransform> CachedComponentSpaceTransforms
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FTransform> result;
				if ((result = this._CachedComponentSpaceTransforms) == null)
				{
					result = (this._CachedComponentSpaceTransforms = new TArray<FTransform>(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_CachedComponentSpaceTransforms, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.CachedComponentSpaceTransforms.CopyAssign(value);
			}
		}

		// Token: 0x17003D12 RID: 15634
		// (get) Token: 0x0600FA34 RID: 64052 RVA: 0x00171FF8 File Offset: 0x001701F8
		// (set) Token: 0x0600FA35 RID: 64053 RVA: 0x00172031 File Offset: 0x00170231
		[Nullable(1)]
		public TArray<FVector> BoneSpaceShears
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._BoneSpaceShears) == null)
				{
					result = (this._BoneSpaceShears = new TArray<FVector>(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_BoneSpaceShears, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.BoneSpaceShears.CopyAssign(value);
			}
		}

		// Token: 0x17003D13 RID: 15635
		// (get) Token: 0x0600FA36 RID: 64054 RVA: 0x00172040 File Offset: 0x00170240
		// (set) Token: 0x0600FA37 RID: 64055 RVA: 0x00172079 File Offset: 0x00170279
		[Nullable(1)]
		public TArray<FVector> CachedBoneSpaceShears
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._CachedBoneSpaceShears) == null)
				{
					result = (this._CachedBoneSpaceShears = new TArray<FVector>(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_CachedBoneSpaceShears, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.CachedBoneSpaceShears.CopyAssign(value);
			}
		}

		// Token: 0x17003D14 RID: 15636
		// (get) Token: 0x0600FA38 RID: 64056 RVA: 0x00172088 File Offset: 0x00170288
		// (set) Token: 0x0600FA39 RID: 64057 RVA: 0x001720C1 File Offset: 0x001702C1
		[Nullable(1)]
		public TArray<FVector> CachedComponentSpaceShears
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._CachedComponentSpaceShears) == null)
				{
					result = (this._CachedComponentSpaceShears = new TArray<FVector>(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_CachedComponentSpaceShears, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.CachedComponentSpaceShears.CopyAssign(value);
			}
		}

		// Token: 0x17003D15 RID: 15637
		// (get) Token: 0x0600FA3A RID: 64058 RVA: 0x001720D0 File Offset: 0x001702D0
		// (set) Token: 0x0600FA3B RID: 64059 RVA: 0x00172109 File Offset: 0x00170309
		[Nullable(1)]
		public TMap<UClass, UAnimInstanceCache> AnimInstanceCachePool
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<UClass, UAnimInstanceCache> result;
				if ((result = this._AnimInstanceCachePool) == null)
				{
					result = (this._AnimInstanceCachePool = new TMap<UClass, UAnimInstanceCache>(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_AnimInstanceCachePool, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.AnimInstanceCachePool.CopyAssign(value);
			}
		}

		// Token: 0x17003D16 RID: 15638
		// (get) Token: 0x0600FA3C RID: 64060 RVA: 0x00172117 File Offset: 0x00170317
		// (set) Token: 0x0600FA3D RID: 64061 RVA: 0x00172127 File Offset: 0x00170327
		public unsafe float GlobalAnimRateScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_GlobalAnimRateScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_GlobalAnimRateScale) = value;
			}
		}

		// Token: 0x17003D17 RID: 15639
		// (get) Token: 0x0600FA3E RID: 64062 RVA: 0x00172138 File Offset: 0x00170338
		// (set) Token: 0x0600FA3F RID: 64063 RVA: 0x0017214C File Offset: 0x0017034C
		[Nullable(0)]
		public unsafe TEnumAsByte<EKinematicBonesUpdateToPhysics> KinematicBonesUpdateType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_KinematicBonesUpdateType);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_KinematicBonesUpdateType) = value;
			}
		}

		// Token: 0x17003D18 RID: 15640
		// (get) Token: 0x0600FA40 RID: 64064 RVA: 0x00172161 File Offset: 0x00170361
		// (set) Token: 0x0600FA41 RID: 64065 RVA: 0x00172175 File Offset: 0x00170375
		[Nullable(0)]
		public unsafe TEnumAsByte<EPhysicsTransformUpdateMode> PhysicsTransformUpdateMode
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_PhysicsTransformUpdateMode);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_PhysicsTransformUpdateMode) = value;
			}
		}

		// Token: 0x17003D19 RID: 15641
		// (get) Token: 0x0600FA42 RID: 64066 RVA: 0x0017218A File Offset: 0x0017038A
		// (set) Token: 0x0600FA43 RID: 64067 RVA: 0x0017219E File Offset: 0x0017039E
		[Nullable(0)]
		public unsafe TEnumAsByte<EAnimationMode> AnimationMode
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_AnimationMode);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_AnimationMode) = value;
			}
		}

		// Token: 0x17003D1A RID: 15642
		// (get) Token: 0x0600FA44 RID: 64068 RVA: 0x001721B3 File Offset: 0x001703B3
		// (set) Token: 0x0600FA45 RID: 64069 RVA: 0x001721CC File Offset: 0x001703CC
		public unsafe bool bDisablePostProcessBlueprint
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bDisablePostProcessBlueprint) & USkeletalMeshComponent.__PropertyMask_bDisablePostProcessBlueprint) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bDisablePostProcessBlueprint) = ((*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bDisablePostProcessBlueprint) & ~USkeletalMeshComponent.__PropertyMask_bDisablePostProcessBlueprint) | (value ? USkeletalMeshComponent.__PropertyMask_bDisablePostProcessBlueprint : 0));
			}
		}

		// Token: 0x17003D1B RID: 15643
		// (get) Token: 0x0600FA46 RID: 64070 RVA: 0x001721FC File Offset: 0x001703FC
		// (set) Token: 0x0600FA47 RID: 64071 RVA: 0x00172215 File Offset: 0x00170415
		public unsafe bool bUpdateOverlapsOnAnimationFinalize
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bUpdateOverlapsOnAnimationFinalize) & USkeletalMeshComponent.__PropertyMask_bUpdateOverlapsOnAnimationFinalize) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bUpdateOverlapsOnAnimationFinalize) = ((*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bUpdateOverlapsOnAnimationFinalize) & ~USkeletalMeshComponent.__PropertyMask_bUpdateOverlapsOnAnimationFinalize) | (value ? USkeletalMeshComponent.__PropertyMask_bUpdateOverlapsOnAnimationFinalize : 0));
			}
		}

		// Token: 0x17003D1C RID: 15644
		// (get) Token: 0x0600FA48 RID: 64072 RVA: 0x00172245 File Offset: 0x00170445
		// (set) Token: 0x0600FA49 RID: 64073 RVA: 0x0017225E File Offset: 0x0017045E
		public unsafe bool bHasValidBodies
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bHasValidBodies) & USkeletalMeshComponent.__PropertyMask_bHasValidBodies) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bHasValidBodies) = ((*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bHasValidBodies) & ~USkeletalMeshComponent.__PropertyMask_bHasValidBodies) | (value ? USkeletalMeshComponent.__PropertyMask_bHasValidBodies : 0));
			}
		}

		// Token: 0x17003D1D RID: 15645
		// (get) Token: 0x0600FA4A RID: 64074 RVA: 0x0017228E File Offset: 0x0017048E
		// (set) Token: 0x0600FA4B RID: 64075 RVA: 0x001722A7 File Offset: 0x001704A7
		public unsafe bool bBlendPhysics
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bBlendPhysics) & USkeletalMeshComponent.__PropertyMask_bBlendPhysics) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bBlendPhysics) = ((*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bBlendPhysics) & ~USkeletalMeshComponent.__PropertyMask_bBlendPhysics) | (value ? USkeletalMeshComponent.__PropertyMask_bBlendPhysics : 0));
			}
		}

		// Token: 0x17003D1E RID: 15646
		// (get) Token: 0x0600FA4C RID: 64076 RVA: 0x001722D7 File Offset: 0x001704D7
		// (set) Token: 0x0600FA4D RID: 64077 RVA: 0x001722F0 File Offset: 0x001704F0
		public unsafe bool bEnablePhysicsOnDedicatedServer
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bEnablePhysicsOnDedicatedServer) & USkeletalMeshComponent.__PropertyMask_bEnablePhysicsOnDedicatedServer) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bEnablePhysicsOnDedicatedServer) = ((*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bEnablePhysicsOnDedicatedServer) & ~USkeletalMeshComponent.__PropertyMask_bEnablePhysicsOnDedicatedServer) | (value ? USkeletalMeshComponent.__PropertyMask_bEnablePhysicsOnDedicatedServer : 0));
			}
		}

		// Token: 0x17003D1F RID: 15647
		// (get) Token: 0x0600FA4E RID: 64078 RVA: 0x00172320 File Offset: 0x00170520
		// (set) Token: 0x0600FA4F RID: 64079 RVA: 0x00172339 File Offset: 0x00170539
		public unsafe bool bUpdateJointsFromAnimation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bUpdateJointsFromAnimation) & USkeletalMeshComponent.__PropertyMask_bUpdateJointsFromAnimation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bUpdateJointsFromAnimation) = ((*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bUpdateJointsFromAnimation) & ~USkeletalMeshComponent.__PropertyMask_bUpdateJointsFromAnimation) | (value ? USkeletalMeshComponent.__PropertyMask_bUpdateJointsFromAnimation : 0));
			}
		}

		// Token: 0x17003D20 RID: 15648
		// (get) Token: 0x0600FA50 RID: 64080 RVA: 0x00172369 File Offset: 0x00170569
		// (set) Token: 0x0600FA51 RID: 64081 RVA: 0x00172382 File Offset: 0x00170582
		public unsafe bool bDisableClothSimulation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bDisableClothSimulation) & USkeletalMeshComponent.__PropertyMask_bDisableClothSimulation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bDisableClothSimulation) = ((*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bDisableClothSimulation) & ~USkeletalMeshComponent.__PropertyMask_bDisableClothSimulation) | (value ? USkeletalMeshComponent.__PropertyMask_bDisableClothSimulation : 0));
			}
		}

		// Token: 0x17003D21 RID: 15649
		// (get) Token: 0x0600FA52 RID: 64082 RVA: 0x001723B2 File Offset: 0x001705B2
		// (set) Token: 0x0600FA53 RID: 64083 RVA: 0x001723CB File Offset: 0x001705CB
		public unsafe bool bDisableRigidBodyAnimNode
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bDisableRigidBodyAnimNode) & USkeletalMeshComponent.__PropertyMask_bDisableRigidBodyAnimNode) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bDisableRigidBodyAnimNode) = ((*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bDisableRigidBodyAnimNode) & ~USkeletalMeshComponent.__PropertyMask_bDisableRigidBodyAnimNode) | (value ? USkeletalMeshComponent.__PropertyMask_bDisableRigidBodyAnimNode : 0));
			}
		}

		// Token: 0x17003D22 RID: 15650
		// (get) Token: 0x0600FA54 RID: 64084 RVA: 0x001723FB File Offset: 0x001705FB
		// (set) Token: 0x0600FA55 RID: 64085 RVA: 0x00172414 File Offset: 0x00170614
		public unsafe bool bAllowAnimCurveEvaluation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bAllowAnimCurveEvaluation) & USkeletalMeshComponent.__PropertyMask_bAllowAnimCurveEvaluation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bAllowAnimCurveEvaluation) = ((*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bAllowAnimCurveEvaluation) & ~USkeletalMeshComponent.__PropertyMask_bAllowAnimCurveEvaluation) | (value ? USkeletalMeshComponent.__PropertyMask_bAllowAnimCurveEvaluation : 0));
			}
		}

		// Token: 0x17003D23 RID: 15651
		// (get) Token: 0x0600FA56 RID: 64086 RVA: 0x00172444 File Offset: 0x00170644
		// (set) Token: 0x0600FA57 RID: 64087 RVA: 0x0017245D File Offset: 0x0017065D
		public unsafe bool bDisableAnimCurves_DEPRECATED
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bDisableAnimCurves_DEPRECATED) & USkeletalMeshComponent.__PropertyMask_bDisableAnimCurves_DEPRECATED) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bDisableAnimCurves_DEPRECATED) = ((*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bDisableAnimCurves_DEPRECATED) & ~USkeletalMeshComponent.__PropertyMask_bDisableAnimCurves_DEPRECATED) | (value ? USkeletalMeshComponent.__PropertyMask_bDisableAnimCurves_DEPRECATED : 0));
			}
		}

		// Token: 0x17003D24 RID: 15652
		// (get) Token: 0x0600FA58 RID: 64088 RVA: 0x0017248D File Offset: 0x0017068D
		// (set) Token: 0x0600FA59 RID: 64089 RVA: 0x001724A6 File Offset: 0x001706A6
		public unsafe bool bCollideWithEnvironment
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bCollideWithEnvironment) & USkeletalMeshComponent.__PropertyMask_bCollideWithEnvironment) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bCollideWithEnvironment) = ((*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bCollideWithEnvironment) & ~USkeletalMeshComponent.__PropertyMask_bCollideWithEnvironment) | (value ? USkeletalMeshComponent.__PropertyMask_bCollideWithEnvironment : 0));
			}
		}

		// Token: 0x17003D25 RID: 15653
		// (get) Token: 0x0600FA5A RID: 64090 RVA: 0x001724D6 File Offset: 0x001706D6
		// (set) Token: 0x0600FA5B RID: 64091 RVA: 0x001724EF File Offset: 0x001706EF
		public unsafe bool bCollideWithAttachedChildren
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bCollideWithAttachedChildren) & USkeletalMeshComponent.__PropertyMask_bCollideWithAttachedChildren) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bCollideWithAttachedChildren) = ((*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bCollideWithAttachedChildren) & ~USkeletalMeshComponent.__PropertyMask_bCollideWithAttachedChildren) | (value ? USkeletalMeshComponent.__PropertyMask_bCollideWithAttachedChildren : 0));
			}
		}

		// Token: 0x17003D26 RID: 15654
		// (get) Token: 0x0600FA5C RID: 64092 RVA: 0x0017251F File Offset: 0x0017071F
		// (set) Token: 0x0600FA5D RID: 64093 RVA: 0x00172538 File Offset: 0x00170738
		public unsafe bool bKuroStaticClothCollideWithEnvironment
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bKuroStaticClothCollideWithEnvironment) & USkeletalMeshComponent.__PropertyMask_bKuroStaticClothCollideWithEnvironment) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bKuroStaticClothCollideWithEnvironment) = ((*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bKuroStaticClothCollideWithEnvironment) & ~USkeletalMeshComponent.__PropertyMask_bKuroStaticClothCollideWithEnvironment) | (value ? USkeletalMeshComponent.__PropertyMask_bKuroStaticClothCollideWithEnvironment : 0));
			}
		}

		// Token: 0x17003D27 RID: 15655
		// (get) Token: 0x0600FA5E RID: 64094 RVA: 0x00172568 File Offset: 0x00170768
		// (set) Token: 0x0600FA5F RID: 64095 RVA: 0x00172581 File Offset: 0x00170781
		public unsafe bool bKuroSkeletalBodySetupsClothingSimulation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bKuroSkeletalBodySetupsClothingSimulation) & USkeletalMeshComponent.__PropertyMask_bKuroSkeletalBodySetupsClothingSimulation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bKuroSkeletalBodySetupsClothingSimulation) = ((*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bKuroSkeletalBodySetupsClothingSimulation) & ~USkeletalMeshComponent.__PropertyMask_bKuroSkeletalBodySetupsClothingSimulation) | (value ? USkeletalMeshComponent.__PropertyMask_bKuroSkeletalBodySetupsClothingSimulation : 0));
			}
		}

		// Token: 0x17003D28 RID: 15656
		// (get) Token: 0x0600FA60 RID: 64096 RVA: 0x001725B1 File Offset: 0x001707B1
		// (set) Token: 0x0600FA61 RID: 64097 RVA: 0x001725C1 File Offset: 0x001707C1
		public unsafe float bKuroSkeletalBodySetupsVelocityRadiusScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bKuroSkeletalBodySetupsVelocityRadiusScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bKuroSkeletalBodySetupsVelocityRadiusScale) = value;
			}
		}

		// Token: 0x17003D29 RID: 15657
		// (get) Token: 0x0600FA62 RID: 64098 RVA: 0x001725D2 File Offset: 0x001707D2
		// (set) Token: 0x0600FA63 RID: 64099 RVA: 0x001725EB File Offset: 0x001707EB
		public unsafe bool bKuroClothUseOriginTangentToLocal
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bKuroClothUseOriginTangentToLocal) & USkeletalMeshComponent.__PropertyMask_bKuroClothUseOriginTangentToLocal) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bKuroClothUseOriginTangentToLocal) = ((*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bKuroClothUseOriginTangentToLocal) & ~USkeletalMeshComponent.__PropertyMask_bKuroClothUseOriginTangentToLocal) | (value ? USkeletalMeshComponent.__PropertyMask_bKuroClothUseOriginTangentToLocal : 0));
			}
		}

		// Token: 0x17003D2A RID: 15658
		// (get) Token: 0x0600FA64 RID: 64100 RVA: 0x0017261B File Offset: 0x0017081B
		// (set) Token: 0x0600FA65 RID: 64101 RVA: 0x00172634 File Offset: 0x00170834
		public unsafe bool bKuroBoundStopClothingSimulation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bKuroBoundStopClothingSimulation) & USkeletalMeshComponent.__PropertyMask_bKuroBoundStopClothingSimulation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bKuroBoundStopClothingSimulation) = ((*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bKuroBoundStopClothingSimulation) & ~USkeletalMeshComponent.__PropertyMask_bKuroBoundStopClothingSimulation) | (value ? USkeletalMeshComponent.__PropertyMask_bKuroBoundStopClothingSimulation : 0));
			}
		}

		// Token: 0x17003D2B RID: 15659
		// (get) Token: 0x0600FA66 RID: 64102 RVA: 0x00172664 File Offset: 0x00170864
		// (set) Token: 0x0600FA67 RID: 64103 RVA: 0x0017267D File Offset: 0x0017087D
		public unsafe bool bLocalSpaceSimulation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bLocalSpaceSimulation) & USkeletalMeshComponent.__PropertyMask_bLocalSpaceSimulation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bLocalSpaceSimulation) = ((*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bLocalSpaceSimulation) & ~USkeletalMeshComponent.__PropertyMask_bLocalSpaceSimulation) | (value ? USkeletalMeshComponent.__PropertyMask_bLocalSpaceSimulation : 0));
			}
		}

		// Token: 0x17003D2C RID: 15660
		// (get) Token: 0x0600FA68 RID: 64104 RVA: 0x001726AD File Offset: 0x001708AD
		// (set) Token: 0x0600FA69 RID: 64105 RVA: 0x001726C6 File Offset: 0x001708C6
		public unsafe bool bResetAfterTeleport
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bResetAfterTeleport) & USkeletalMeshComponent.__PropertyMask_bResetAfterTeleport) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bResetAfterTeleport) = ((*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bResetAfterTeleport) & ~USkeletalMeshComponent.__PropertyMask_bResetAfterTeleport) | (value ? USkeletalMeshComponent.__PropertyMask_bResetAfterTeleport : 0));
			}
		}

		// Token: 0x17003D2D RID: 15661
		// (get) Token: 0x0600FA6A RID: 64106 RVA: 0x001726F6 File Offset: 0x001708F6
		// (set) Token: 0x0600FA6B RID: 64107 RVA: 0x0017270F File Offset: 0x0017090F
		public unsafe bool bDeferKinematicBoneUpdate
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bDeferKinematicBoneUpdate) & USkeletalMeshComponent.__PropertyMask_bDeferKinematicBoneUpdate) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bDeferKinematicBoneUpdate) = ((*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bDeferKinematicBoneUpdate) & ~USkeletalMeshComponent.__PropertyMask_bDeferKinematicBoneUpdate) | (value ? USkeletalMeshComponent.__PropertyMask_bDeferKinematicBoneUpdate : 0));
			}
		}

		// Token: 0x17003D2E RID: 15662
		// (get) Token: 0x0600FA6C RID: 64108 RVA: 0x0017273F File Offset: 0x0017093F
		// (set) Token: 0x0600FA6D RID: 64109 RVA: 0x00172758 File Offset: 0x00170958
		public unsafe bool bNoSkeletonUpdate
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bNoSkeletonUpdate) & USkeletalMeshComponent.__PropertyMask_bNoSkeletonUpdate) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bNoSkeletonUpdate) = ((*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bNoSkeletonUpdate) & ~USkeletalMeshComponent.__PropertyMask_bNoSkeletonUpdate) | (value ? USkeletalMeshComponent.__PropertyMask_bNoSkeletonUpdate : 0));
			}
		}

		// Token: 0x17003D2F RID: 15663
		// (get) Token: 0x0600FA6E RID: 64110 RVA: 0x00172788 File Offset: 0x00170988
		// (set) Token: 0x0600FA6F RID: 64111 RVA: 0x001727A1 File Offset: 0x001709A1
		public unsafe bool bEnableShearAnim
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bEnableShearAnim) & USkeletalMeshComponent.__PropertyMask_bEnableShearAnim) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bEnableShearAnim) = ((*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bEnableShearAnim) & ~USkeletalMeshComponent.__PropertyMask_bEnableShearAnim) | (value ? USkeletalMeshComponent.__PropertyMask_bEnableShearAnim : 0));
			}
		}

		// Token: 0x17003D30 RID: 15664
		// (get) Token: 0x0600FA70 RID: 64112 RVA: 0x001727D1 File Offset: 0x001709D1
		// (set) Token: 0x0600FA71 RID: 64113 RVA: 0x001727EA File Offset: 0x001709EA
		public unsafe bool bEnableAnimTexture
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bEnableAnimTexture) & USkeletalMeshComponent.__PropertyMask_bEnableAnimTexture) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bEnableAnimTexture) = ((*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bEnableAnimTexture) & ~USkeletalMeshComponent.__PropertyMask_bEnableAnimTexture) | (value ? USkeletalMeshComponent.__PropertyMask_bEnableAnimTexture : 0));
			}
		}

		// Token: 0x17003D31 RID: 15665
		// (get) Token: 0x0600FA72 RID: 64114 RVA: 0x0017281A File Offset: 0x00170A1A
		// (set) Token: 0x0600FA73 RID: 64115 RVA: 0x00172833 File Offset: 0x00170A33
		public unsafe bool bPauseAnims
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bPauseAnims) & USkeletalMeshComponent.__PropertyMask_bPauseAnims) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bPauseAnims) = ((*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bPauseAnims) & ~USkeletalMeshComponent.__PropertyMask_bPauseAnims) | (value ? USkeletalMeshComponent.__PropertyMask_bPauseAnims : 0));
			}
		}

		// Token: 0x17003D32 RID: 15666
		// (get) Token: 0x0600FA74 RID: 64116 RVA: 0x00172863 File Offset: 0x00170A63
		// (set) Token: 0x0600FA75 RID: 64117 RVA: 0x0017287C File Offset: 0x00170A7C
		public unsafe bool bUseRefPoseOnInitAnim
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bUseRefPoseOnInitAnim) & USkeletalMeshComponent.__PropertyMask_bUseRefPoseOnInitAnim) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bUseRefPoseOnInitAnim) = ((*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bUseRefPoseOnInitAnim) & ~USkeletalMeshComponent.__PropertyMask_bUseRefPoseOnInitAnim) | (value ? USkeletalMeshComponent.__PropertyMask_bUseRefPoseOnInitAnim : 0));
			}
		}

		// Token: 0x17003D33 RID: 15667
		// (get) Token: 0x0600FA76 RID: 64118 RVA: 0x001728AC File Offset: 0x00170AAC
		// (set) Token: 0x0600FA77 RID: 64119 RVA: 0x001728C5 File Offset: 0x00170AC5
		public unsafe bool bEnablePerPolyCollision
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bEnablePerPolyCollision) & USkeletalMeshComponent.__PropertyMask_bEnablePerPolyCollision) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bEnablePerPolyCollision) = ((*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bEnablePerPolyCollision) & ~USkeletalMeshComponent.__PropertyMask_bEnablePerPolyCollision) | (value ? USkeletalMeshComponent.__PropertyMask_bEnablePerPolyCollision : 0));
			}
		}

		// Token: 0x17003D34 RID: 15668
		// (get) Token: 0x0600FA78 RID: 64120 RVA: 0x001728F5 File Offset: 0x00170AF5
		// (set) Token: 0x0600FA79 RID: 64121 RVA: 0x0017290E File Offset: 0x00170B0E
		public unsafe bool bForceRefpose
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bForceRefpose) & USkeletalMeshComponent.__PropertyMask_bForceRefpose) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bForceRefpose) = ((*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bForceRefpose) & ~USkeletalMeshComponent.__PropertyMask_bForceRefpose) | (value ? USkeletalMeshComponent.__PropertyMask_bForceRefpose : 0));
			}
		}

		// Token: 0x17003D35 RID: 15669
		// (get) Token: 0x0600FA7A RID: 64122 RVA: 0x0017293E File Offset: 0x00170B3E
		// (set) Token: 0x0600FA7B RID: 64123 RVA: 0x00172957 File Offset: 0x00170B57
		public unsafe bool bOnlyAllowAutonomousTickPose
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bOnlyAllowAutonomousTickPose) & USkeletalMeshComponent.__PropertyMask_bOnlyAllowAutonomousTickPose) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bOnlyAllowAutonomousTickPose) = ((*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bOnlyAllowAutonomousTickPose) & ~USkeletalMeshComponent.__PropertyMask_bOnlyAllowAutonomousTickPose) | (value ? USkeletalMeshComponent.__PropertyMask_bOnlyAllowAutonomousTickPose : 0));
			}
		}

		// Token: 0x17003D36 RID: 15670
		// (get) Token: 0x0600FA7C RID: 64124 RVA: 0x00172987 File Offset: 0x00170B87
		// (set) Token: 0x0600FA7D RID: 64125 RVA: 0x001729A0 File Offset: 0x00170BA0
		public unsafe bool bIsAutonomousTickPose
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bIsAutonomousTickPose) & USkeletalMeshComponent.__PropertyMask_bIsAutonomousTickPose) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bIsAutonomousTickPose) = ((*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bIsAutonomousTickPose) & ~USkeletalMeshComponent.__PropertyMask_bIsAutonomousTickPose) | (value ? USkeletalMeshComponent.__PropertyMask_bIsAutonomousTickPose : 0));
			}
		}

		// Token: 0x17003D37 RID: 15671
		// (get) Token: 0x0600FA7E RID: 64126 RVA: 0x001729D0 File Offset: 0x00170BD0
		// (set) Token: 0x0600FA7F RID: 64127 RVA: 0x001729E9 File Offset: 0x00170BE9
		public unsafe bool bOldForceRefPose
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bOldForceRefPose) & USkeletalMeshComponent.__PropertyMask_bOldForceRefPose) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bOldForceRefPose) = ((*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bOldForceRefPose) & ~USkeletalMeshComponent.__PropertyMask_bOldForceRefPose) | (value ? USkeletalMeshComponent.__PropertyMask_bOldForceRefPose : 0));
			}
		}

		// Token: 0x17003D38 RID: 15672
		// (get) Token: 0x0600FA80 RID: 64128 RVA: 0x00172A19 File Offset: 0x00170C19
		// (set) Token: 0x0600FA81 RID: 64129 RVA: 0x00172A32 File Offset: 0x00170C32
		public unsafe bool bShowPrePhysBones
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bShowPrePhysBones) & USkeletalMeshComponent.__PropertyMask_bShowPrePhysBones) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bShowPrePhysBones) = ((*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bShowPrePhysBones) & ~USkeletalMeshComponent.__PropertyMask_bShowPrePhysBones) | (value ? USkeletalMeshComponent.__PropertyMask_bShowPrePhysBones : 0));
			}
		}

		// Token: 0x17003D39 RID: 15673
		// (get) Token: 0x0600FA82 RID: 64130 RVA: 0x00172A62 File Offset: 0x00170C62
		// (set) Token: 0x0600FA83 RID: 64131 RVA: 0x00172A7B File Offset: 0x00170C7B
		public unsafe bool bRequiredBonesUpToDate
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bRequiredBonesUpToDate) & USkeletalMeshComponent.__PropertyMask_bRequiredBonesUpToDate) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bRequiredBonesUpToDate) = ((*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bRequiredBonesUpToDate) & ~USkeletalMeshComponent.__PropertyMask_bRequiredBonesUpToDate) | (value ? USkeletalMeshComponent.__PropertyMask_bRequiredBonesUpToDate : 0));
			}
		}

		// Token: 0x17003D3A RID: 15674
		// (get) Token: 0x0600FA84 RID: 64132 RVA: 0x00172AAB File Offset: 0x00170CAB
		// (set) Token: 0x0600FA85 RID: 64133 RVA: 0x00172AC4 File Offset: 0x00170CC4
		public unsafe bool bAnimTreeInitialised
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bAnimTreeInitialised) & USkeletalMeshComponent.__PropertyMask_bAnimTreeInitialised) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bAnimTreeInitialised) = ((*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bAnimTreeInitialised) & ~USkeletalMeshComponent.__PropertyMask_bAnimTreeInitialised) | (value ? USkeletalMeshComponent.__PropertyMask_bAnimTreeInitialised : 0));
			}
		}

		// Token: 0x17003D3B RID: 15675
		// (get) Token: 0x0600FA86 RID: 64134 RVA: 0x00172AF4 File Offset: 0x00170CF4
		// (set) Token: 0x0600FA87 RID: 64135 RVA: 0x00172B0D File Offset: 0x00170D0D
		public unsafe bool bIncludeComponentLocationIntoBounds
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bIncludeComponentLocationIntoBounds) & USkeletalMeshComponent.__PropertyMask_bIncludeComponentLocationIntoBounds) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bIncludeComponentLocationIntoBounds) = ((*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bIncludeComponentLocationIntoBounds) & ~USkeletalMeshComponent.__PropertyMask_bIncludeComponentLocationIntoBounds) | (value ? USkeletalMeshComponent.__PropertyMask_bIncludeComponentLocationIntoBounds : 0));
			}
		}

		// Token: 0x17003D3C RID: 15676
		// (get) Token: 0x0600FA88 RID: 64136 RVA: 0x00172B3D File Offset: 0x00170D3D
		// (set) Token: 0x0600FA89 RID: 64137 RVA: 0x00172B56 File Offset: 0x00170D56
		public unsafe bool bEnableLineCheckWithBounds
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bEnableLineCheckWithBounds) & USkeletalMeshComponent.__PropertyMask_bEnableLineCheckWithBounds) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bEnableLineCheckWithBounds) = ((*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bEnableLineCheckWithBounds) & ~USkeletalMeshComponent.__PropertyMask_bEnableLineCheckWithBounds) | (value ? USkeletalMeshComponent.__PropertyMask_bEnableLineCheckWithBounds : 0));
			}
		}

		// Token: 0x17003D3D RID: 15677
		// (get) Token: 0x0600FA8A RID: 64138 RVA: 0x00172B86 File Offset: 0x00170D86
		// (set) Token: 0x0600FA8B RID: 64139 RVA: 0x00172B9F File Offset: 0x00170D9F
		public unsafe bool bUseBendingElements_DEPRECATED
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bUseBendingElements_DEPRECATED) & USkeletalMeshComponent.__PropertyMask_bUseBendingElements_DEPRECATED) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bUseBendingElements_DEPRECATED) = ((*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bUseBendingElements_DEPRECATED) & ~USkeletalMeshComponent.__PropertyMask_bUseBendingElements_DEPRECATED) | (value ? USkeletalMeshComponent.__PropertyMask_bUseBendingElements_DEPRECATED : 0));
			}
		}

		// Token: 0x17003D3E RID: 15678
		// (get) Token: 0x0600FA8C RID: 64140 RVA: 0x00172BCF File Offset: 0x00170DCF
		// (set) Token: 0x0600FA8D RID: 64141 RVA: 0x00172BE8 File Offset: 0x00170DE8
		public unsafe bool bUseTetrahedralConstraints_DEPRECATED
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bUseTetrahedralConstraints_DEPRECATED) & USkeletalMeshComponent.__PropertyMask_bUseTetrahedralConstraints_DEPRECATED) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bUseTetrahedralConstraints_DEPRECATED) = ((*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bUseTetrahedralConstraints_DEPRECATED) & ~USkeletalMeshComponent.__PropertyMask_bUseTetrahedralConstraints_DEPRECATED) | (value ? USkeletalMeshComponent.__PropertyMask_bUseTetrahedralConstraints_DEPRECATED : 0));
			}
		}

		// Token: 0x17003D3F RID: 15679
		// (get) Token: 0x0600FA8E RID: 64142 RVA: 0x00172C18 File Offset: 0x00170E18
		// (set) Token: 0x0600FA8F RID: 64143 RVA: 0x00172C31 File Offset: 0x00170E31
		public unsafe bool bUseThinShellVolumeConstraints_DEPRECATED
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bUseThinShellVolumeConstraints_DEPRECATED) & USkeletalMeshComponent.__PropertyMask_bUseThinShellVolumeConstraints_DEPRECATED) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bUseThinShellVolumeConstraints_DEPRECATED) = ((*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bUseThinShellVolumeConstraints_DEPRECATED) & ~USkeletalMeshComponent.__PropertyMask_bUseThinShellVolumeConstraints_DEPRECATED) | (value ? USkeletalMeshComponent.__PropertyMask_bUseThinShellVolumeConstraints_DEPRECATED : 0));
			}
		}

		// Token: 0x17003D40 RID: 15680
		// (get) Token: 0x0600FA90 RID: 64144 RVA: 0x00172C61 File Offset: 0x00170E61
		// (set) Token: 0x0600FA91 RID: 64145 RVA: 0x00172C7A File Offset: 0x00170E7A
		public unsafe bool bUseSelfCollisions_DEPRECATED
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bUseSelfCollisions_DEPRECATED) & USkeletalMeshComponent.__PropertyMask_bUseSelfCollisions_DEPRECATED) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bUseSelfCollisions_DEPRECATED) = ((*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bUseSelfCollisions_DEPRECATED) & ~USkeletalMeshComponent.__PropertyMask_bUseSelfCollisions_DEPRECATED) | (value ? USkeletalMeshComponent.__PropertyMask_bUseSelfCollisions_DEPRECATED : 0));
			}
		}

		// Token: 0x17003D41 RID: 15681
		// (get) Token: 0x0600FA92 RID: 64146 RVA: 0x00172CAA File Offset: 0x00170EAA
		// (set) Token: 0x0600FA93 RID: 64147 RVA: 0x00172CC3 File Offset: 0x00170EC3
		public unsafe bool bUseContinuousCollisionDetection_DEPRECATED
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bUseContinuousCollisionDetection_DEPRECATED) & USkeletalMeshComponent.__PropertyMask_bUseContinuousCollisionDetection_DEPRECATED) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bUseContinuousCollisionDetection_DEPRECATED) = ((*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bUseContinuousCollisionDetection_DEPRECATED) & ~USkeletalMeshComponent.__PropertyMask_bUseContinuousCollisionDetection_DEPRECATED) | (value ? USkeletalMeshComponent.__PropertyMask_bUseContinuousCollisionDetection_DEPRECATED : 0));
			}
		}

		// Token: 0x17003D42 RID: 15682
		// (get) Token: 0x0600FA94 RID: 64148 RVA: 0x00172CF3 File Offset: 0x00170EF3
		// (set) Token: 0x0600FA95 RID: 64149 RVA: 0x00172D0C File Offset: 0x00170F0C
		public unsafe bool bPropagateCurvesToSlaves
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bPropagateCurvesToSlaves) & USkeletalMeshComponent.__PropertyMask_bPropagateCurvesToSlaves) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bPropagateCurvesToSlaves) = ((*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bPropagateCurvesToSlaves) & ~USkeletalMeshComponent.__PropertyMask_bPropagateCurvesToSlaves) | (value ? USkeletalMeshComponent.__PropertyMask_bPropagateCurvesToSlaves : 0));
			}
		}

		// Token: 0x17003D43 RID: 15683
		// (get) Token: 0x0600FA96 RID: 64150 RVA: 0x00172D3C File Offset: 0x00170F3C
		// (set) Token: 0x0600FA97 RID: 64151 RVA: 0x00172D55 File Offset: 0x00170F55
		public unsafe bool bSkipKinematicUpdateWhenInterpolating
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bSkipKinematicUpdateWhenInterpolating) & USkeletalMeshComponent.__PropertyMask_bSkipKinematicUpdateWhenInterpolating) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bSkipKinematicUpdateWhenInterpolating) = ((*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bSkipKinematicUpdateWhenInterpolating) & ~USkeletalMeshComponent.__PropertyMask_bSkipKinematicUpdateWhenInterpolating) | (value ? USkeletalMeshComponent.__PropertyMask_bSkipKinematicUpdateWhenInterpolating : 0));
			}
		}

		// Token: 0x17003D44 RID: 15684
		// (get) Token: 0x0600FA98 RID: 64152 RVA: 0x00172D85 File Offset: 0x00170F85
		// (set) Token: 0x0600FA99 RID: 64153 RVA: 0x00172D9E File Offset: 0x00170F9E
		public unsafe bool bSkipBoundsUpdateWhenInterpolating
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bSkipBoundsUpdateWhenInterpolating) & USkeletalMeshComponent.__PropertyMask_bSkipBoundsUpdateWhenInterpolating) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bSkipBoundsUpdateWhenInterpolating) = ((*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bSkipBoundsUpdateWhenInterpolating) & ~USkeletalMeshComponent.__PropertyMask_bSkipBoundsUpdateWhenInterpolating) | (value ? USkeletalMeshComponent.__PropertyMask_bSkipBoundsUpdateWhenInterpolating : 0));
			}
		}

		// Token: 0x17003D45 RID: 15685
		// (get) Token: 0x0600FA9A RID: 64154 RVA: 0x00172DCE File Offset: 0x00170FCE
		// (set) Token: 0x0600FA9B RID: 64155 RVA: 0x00172DE7 File Offset: 0x00170FE7
		public unsafe bool bMaybeShearingPose
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bMaybeShearingPose) & USkeletalMeshComponent.__PropertyMask_bMaybeShearingPose) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bMaybeShearingPose) = ((*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bMaybeShearingPose) & ~USkeletalMeshComponent.__PropertyMask_bMaybeShearingPose) | (value ? USkeletalMeshComponent.__PropertyMask_bMaybeShearingPose : 0));
			}
		}

		// Token: 0x17003D46 RID: 15686
		// (get) Token: 0x0600FA9C RID: 64156 RVA: 0x00172E17 File Offset: 0x00171017
		// (set) Token: 0x0600FA9D RID: 64157 RVA: 0x00172E30 File Offset: 0x00171030
		public unsafe bool bNeedsQueuedAnimEventsDispatched
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bNeedsQueuedAnimEventsDispatched) & USkeletalMeshComponent.__PropertyMask_bNeedsQueuedAnimEventsDispatched) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bNeedsQueuedAnimEventsDispatched) = ((*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bNeedsQueuedAnimEventsDispatched) & ~USkeletalMeshComponent.__PropertyMask_bNeedsQueuedAnimEventsDispatched) | (value ? USkeletalMeshComponent.__PropertyMask_bNeedsQueuedAnimEventsDispatched : 0));
			}
		}

		// Token: 0x17003D47 RID: 15687
		// (get) Token: 0x0600FA9E RID: 64158 RVA: 0x00172E60 File Offset: 0x00171060
		// (set) Token: 0x0600FA9F RID: 64159 RVA: 0x00172E70 File Offset: 0x00171070
		public unsafe ushort CachedAnimCurveUidVersion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_CachedAnimCurveUidVersion);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_CachedAnimCurveUidVersion) = (short)value;
			}
		}

		// Token: 0x17003D48 RID: 15688
		// (get) Token: 0x0600FAA0 RID: 64160 RVA: 0x00172E81 File Offset: 0x00171081
		// (set) Token: 0x0600FAA1 RID: 64161 RVA: 0x00172E91 File Offset: 0x00171091
		public unsafe EClothMassMode MassMode_DEPRECATED
		{
			get
			{
				return (EClothMassMode)(*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_MassMode_DEPRECATED));
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_MassMode_DEPRECATED) = (byte)value;
			}
		}

		// Token: 0x17003D49 RID: 15689
		// (get) Token: 0x0600FAA2 RID: 64162 RVA: 0x00172EA2 File Offset: 0x001710A2
		// (set) Token: 0x0600FAA3 RID: 64163 RVA: 0x00172EB2 File Offset: 0x001710B2
		public unsafe float UniformMass_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_UniformMass_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_UniformMass_DEPRECATED) = value;
			}
		}

		// Token: 0x17003D4A RID: 15690
		// (get) Token: 0x0600FAA4 RID: 64164 RVA: 0x00172EC3 File Offset: 0x001710C3
		// (set) Token: 0x0600FAA5 RID: 64165 RVA: 0x00172ED3 File Offset: 0x001710D3
		public unsafe float TotalMass_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_TotalMass_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_TotalMass_DEPRECATED) = value;
			}
		}

		// Token: 0x17003D4B RID: 15691
		// (get) Token: 0x0600FAA6 RID: 64166 RVA: 0x00172EE4 File Offset: 0x001710E4
		// (set) Token: 0x0600FAA7 RID: 64167 RVA: 0x00172EF4 File Offset: 0x001710F4
		public unsafe float Density_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_Density_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_Density_DEPRECATED) = value;
			}
		}

		// Token: 0x17003D4C RID: 15692
		// (get) Token: 0x0600FAA8 RID: 64168 RVA: 0x00172F05 File Offset: 0x00171105
		// (set) Token: 0x0600FAA9 RID: 64169 RVA: 0x00172F15 File Offset: 0x00171115
		public unsafe float MinPerParticleMass_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_MinPerParticleMass_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_MinPerParticleMass_DEPRECATED) = value;
			}
		}

		// Token: 0x17003D4D RID: 15693
		// (get) Token: 0x0600FAAA RID: 64170 RVA: 0x00172F26 File Offset: 0x00171126
		// (set) Token: 0x0600FAAB RID: 64171 RVA: 0x00172F36 File Offset: 0x00171136
		public unsafe float ClothBlendWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_ClothBlendWeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_ClothBlendWeight) = value;
			}
		}

		// Token: 0x17003D4E RID: 15694
		// (get) Token: 0x0600FAAC RID: 64172 RVA: 0x00172F47 File Offset: 0x00171147
		// (set) Token: 0x0600FAAD RID: 64173 RVA: 0x00172F57 File Offset: 0x00171157
		public unsafe float EdgeStiffness_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_EdgeStiffness_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_EdgeStiffness_DEPRECATED) = value;
			}
		}

		// Token: 0x17003D4F RID: 15695
		// (get) Token: 0x0600FAAE RID: 64174 RVA: 0x00172F68 File Offset: 0x00171168
		// (set) Token: 0x0600FAAF RID: 64175 RVA: 0x00172F78 File Offset: 0x00171178
		public unsafe float BendingStiffness_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_BendingStiffness_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_BendingStiffness_DEPRECATED) = value;
			}
		}

		// Token: 0x17003D50 RID: 15696
		// (get) Token: 0x0600FAB0 RID: 64176 RVA: 0x00172F89 File Offset: 0x00171189
		// (set) Token: 0x0600FAB1 RID: 64177 RVA: 0x00172F99 File Offset: 0x00171199
		public unsafe float AreaStiffness_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_AreaStiffness_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_AreaStiffness_DEPRECATED) = value;
			}
		}

		// Token: 0x17003D51 RID: 15697
		// (get) Token: 0x0600FAB2 RID: 64178 RVA: 0x00172FAA File Offset: 0x001711AA
		// (set) Token: 0x0600FAB3 RID: 64179 RVA: 0x00172FBA File Offset: 0x001711BA
		public unsafe float VolumeStiffness_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_VolumeStiffness_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_VolumeStiffness_DEPRECATED) = value;
			}
		}

		// Token: 0x17003D52 RID: 15698
		// (get) Token: 0x0600FAB4 RID: 64180 RVA: 0x00172FCB File Offset: 0x001711CB
		// (set) Token: 0x0600FAB5 RID: 64181 RVA: 0x00172FDB File Offset: 0x001711DB
		public unsafe float StrainLimitingStiffness_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_StrainLimitingStiffness_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_StrainLimitingStiffness_DEPRECATED) = value;
			}
		}

		// Token: 0x17003D53 RID: 15699
		// (get) Token: 0x0600FAB6 RID: 64182 RVA: 0x00172FEC File Offset: 0x001711EC
		// (set) Token: 0x0600FAB7 RID: 64183 RVA: 0x00172FFC File Offset: 0x001711FC
		public unsafe float ShapeTargetStiffness_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_ShapeTargetStiffness_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_ShapeTargetStiffness_DEPRECATED) = value;
			}
		}

		// Token: 0x17003D54 RID: 15700
		// (get) Token: 0x0600FAB8 RID: 64184 RVA: 0x0017300D File Offset: 0x0017120D
		// (set) Token: 0x0600FAB9 RID: 64185 RVA: 0x0017301D File Offset: 0x0017121D
		public unsafe bool bWaitForParallelClothTask
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bWaitForParallelClothTask) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bWaitForParallelClothTask) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003D55 RID: 15701
		// (get) Token: 0x0600FABA RID: 64186 RVA: 0x0017302E File Offset: 0x0017122E
		// (set) Token: 0x0600FABB RID: 64187 RVA: 0x0017303E File Offset: 0x0017123E
		public unsafe bool bUseRegionalSlaveBoneBounds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bUseRegionalSlaveBoneBounds) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bUseRegionalSlaveBoneBounds) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003D56 RID: 15702
		// (get) Token: 0x0600FABC RID: 64188 RVA: 0x0017304F File Offset: 0x0017124F
		// (set) Token: 0x0600FABD RID: 64189 RVA: 0x0017305F File Offset: 0x0017125F
		public unsafe bool bUseCustomSlaveBoneBounds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bUseCustomSlaveBoneBounds) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bUseCustomSlaveBoneBounds) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003D57 RID: 15703
		// (get) Token: 0x0600FABE RID: 64190 RVA: 0x00173070 File Offset: 0x00171270
		// (set) Token: 0x0600FABF RID: 64191 RVA: 0x001730A9 File Offset: 0x001712A9
		[Nullable(1)]
		public TArray<FName> CustomSlaveBoneBoundsConcernedBones
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._CustomSlaveBoneBoundsConcernedBones) == null)
				{
					result = (this._CustomSlaveBoneBoundsConcernedBones = new TArray<FName>(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_CustomSlaveBoneBoundsConcernedBones, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.CustomSlaveBoneBoundsConcernedBones.CopyAssign(value);
			}
		}

		// Token: 0x17003D58 RID: 15704
		// (get) Token: 0x0600FAC0 RID: 64192 RVA: 0x001730B7 File Offset: 0x001712B7
		// (set) Token: 0x0600FAC1 RID: 64193 RVA: 0x001730C7 File Offset: 0x001712C7
		public unsafe float CustomSlaveBoneBoundsExtension
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_CustomSlaveBoneBoundsExtension);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_CustomSlaveBoneBoundsExtension) = value;
			}
		}

		// Token: 0x17003D59 RID: 15705
		// (get) Token: 0x0600FAC2 RID: 64194 RVA: 0x001730D8 File Offset: 0x001712D8
		// (set) Token: 0x0600FAC3 RID: 64195 RVA: 0x00173111 File Offset: 0x00171311
		[Nullable(1)]
		public TArray<FName> DisallowedAnimCurves
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._DisallowedAnimCurves) == null)
				{
					result = (this._DisallowedAnimCurves = new TArray<FName>(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_DisallowedAnimCurves, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.DisallowedAnimCurves.CopyAssign(value);
			}
		}

		// Token: 0x17003D5A RID: 15706
		// (get) Token: 0x0600FAC4 RID: 64196 RVA: 0x0017311F File Offset: 0x0017131F
		// (set) Token: 0x0600FAC5 RID: 64197 RVA: 0x00173133 File Offset: 0x00171333
		public unsafe UBodySetup BodySetup
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBodySetup>(base.NativePtr / (IntPtr)sizeof(void*) + USkeletalMeshComponent.__PropertyOffset_BodySetup);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USkeletalMeshComponent.__PropertyOffset_BodySetup, value);
			}
		}

		// Token: 0x17003D5B RID: 15707
		// (get) Token: 0x0600FAC6 RID: 64198 RVA: 0x00173148 File Offset: 0x00171348
		// (set) Token: 0x0600FAC7 RID: 64199 RVA: 0x00173181 File Offset: 0x00171381
		[Nullable(1)]
		public FConstraintBrokenSignature OnConstraintBroken
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FConstraintBrokenSignature result;
				if ((result = this._OnConstraintBroken) == null)
				{
					result = (this._OnConstraintBroken = new FConstraintBrokenSignature(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_OnConstraintBroken, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_OnConstraintBroken, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17003D5C RID: 15708
		// (get) Token: 0x0600FAC8 RID: 64200 RVA: 0x001731A2 File Offset: 0x001713A2
		// (set) Token: 0x0600FAC9 RID: 64201 RVA: 0x001731B6 File Offset: 0x001713B6
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UClothingSimulationFactory> ClothingSimulationFactory
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_ClothingSimulationFactory);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_ClothingSimulationFactory) = value;
			}
		}

		// Token: 0x17003D5D RID: 15709
		// (get) Token: 0x0600FACA RID: 64202 RVA: 0x001731CB File Offset: 0x001713CB
		// (set) Token: 0x0600FACB RID: 64203 RVA: 0x001731DB File Offset: 0x001713DB
		public unsafe float TeleportDistanceThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_TeleportDistanceThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_TeleportDistanceThreshold) = value;
			}
		}

		// Token: 0x17003D5E RID: 15710
		// (get) Token: 0x0600FACC RID: 64204 RVA: 0x001731EC File Offset: 0x001713EC
		// (set) Token: 0x0600FACD RID: 64205 RVA: 0x001731FC File Offset: 0x001713FC
		public unsafe float TeleportRotationThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_TeleportRotationThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_TeleportRotationThreshold) = value;
			}
		}

		// Token: 0x17003D5F RID: 15711
		// (get) Token: 0x0600FACE RID: 64206 RVA: 0x0017320D File Offset: 0x0017140D
		// (set) Token: 0x0600FACF RID: 64207 RVA: 0x0017321D File Offset: 0x0017141D
		public unsafe uint LastPoseTickFrame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_LastPoseTickFrame);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_LastPoseTickFrame) = (int)value;
			}
		}

		// Token: 0x17003D60 RID: 15712
		// (get) Token: 0x0600FAD0 RID: 64208 RVA: 0x0017322E File Offset: 0x0017142E
		// (set) Token: 0x0600FAD1 RID: 64209 RVA: 0x00173242 File Offset: 0x00171442
		public unsafe UClothingSimulationInteractor ClothingInteractor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UClothingSimulationInteractor>(base.NativePtr / (IntPtr)sizeof(void*) + USkeletalMeshComponent.__PropertyOffset_ClothingInteractor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USkeletalMeshComponent.__PropertyOffset_ClothingInteractor, value);
			}
		}

		// Token: 0x17003D61 RID: 15713
		// (get) Token: 0x0600FAD2 RID: 64210 RVA: 0x00173258 File Offset: 0x00171458
		// (set) Token: 0x0600FAD3 RID: 64211 RVA: 0x00173291 File Offset: 0x00171491
		[Nullable(1)]
		public FOnAnimInitialized OnAnimInitialized
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FOnAnimInitialized result;
				if ((result = this._OnAnimInitialized) == null)
				{
					result = (this._OnAnimInitialized = new FOnAnimInitialized(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_OnAnimInitialized, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_OnAnimInitialized, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17003D62 RID: 15714
		// (get) Token: 0x0600FAD4 RID: 64212 RVA: 0x001732B2 File Offset: 0x001714B2
		// (set) Token: 0x0600FAD5 RID: 64213 RVA: 0x001732CB File Offset: 0x001714CB
		public unsafe bool EndGetHeadBondPos
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_EndGetHeadBondPos) & USkeletalMeshComponent.__PropertyMask_EndGetHeadBondPos) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_EndGetHeadBondPos) = ((*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_EndGetHeadBondPos) & ~USkeletalMeshComponent.__PropertyMask_EndGetHeadBondPos) | (value ? USkeletalMeshComponent.__PropertyMask_EndGetHeadBondPos : 0));
			}
		}

		// Token: 0x17003D63 RID: 15715
		// (get) Token: 0x0600FAD6 RID: 64214 RVA: 0x001732FB File Offset: 0x001714FB
		// (set) Token: 0x0600FAD7 RID: 64215 RVA: 0x0017330B File Offset: 0x0017150B
		public unsafe bool bRunPostUpdateTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bRunPostUpdateTick) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bRunPostUpdateTick) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003D64 RID: 15716
		// (get) Token: 0x0600FAD8 RID: 64216 RVA: 0x0017331C File Offset: 0x0017151C
		// (set) Token: 0x0600FAD9 RID: 64217 RVA: 0x00173330 File Offset: 0x00171530
		public unsafe USkeletalMeshComponent PrerequisiteComp
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + USkeletalMeshComponent.__PropertyOffset_PrerequisiteComp);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USkeletalMeshComponent.__PropertyOffset_PrerequisiteComp, value);
			}
		}

		// Token: 0x17003D65 RID: 15717
		// (get) Token: 0x0600FADA RID: 64218 RVA: 0x00173345 File Offset: 0x00171545
		// (set) Token: 0x0600FADB RID: 64219 RVA: 0x00173355 File Offset: 0x00171555
		public unsafe bool bBanMontage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bBanMontage) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bBanMontage) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003D66 RID: 15718
		// (get) Token: 0x0600FADC RID: 64220 RVA: 0x00173366 File Offset: 0x00171566
		// (set) Token: 0x0600FADD RID: 64221 RVA: 0x0017337F File Offset: 0x0017157F
		public unsafe bool bUseDelayComplete
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bUseDelayComplete) & USkeletalMeshComponent.__PropertyMask_bUseDelayComplete) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bUseDelayComplete) = ((*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bUseDelayComplete) & ~USkeletalMeshComponent.__PropertyMask_bUseDelayComplete) | (value ? USkeletalMeshComponent.__PropertyMask_bUseDelayComplete : 0));
			}
		}

		// Token: 0x17003D67 RID: 15719
		// (get) Token: 0x0600FADE RID: 64222 RVA: 0x001733AF File Offset: 0x001715AF
		// (set) Token: 0x0600FADF RID: 64223 RVA: 0x001733BF File Offset: 0x001715BF
		public unsafe bool bUpdateChildTransInDelayComplete
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bUpdateChildTransInDelayComplete) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bUpdateChildTransInDelayComplete) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003D68 RID: 15720
		// (get) Token: 0x0600FAE0 RID: 64224 RVA: 0x001733D0 File Offset: 0x001715D0
		// (set) Token: 0x0600FAE1 RID: 64225 RVA: 0x001733E9 File Offset: 0x001715E9
		public unsafe bool bUseKuroParallel
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bUseKuroParallel) & USkeletalMeshComponent.__PropertyMask_bUseKuroParallel) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bUseKuroParallel) = ((*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bUseKuroParallel) & ~USkeletalMeshComponent.__PropertyMask_bUseKuroParallel) | (value ? USkeletalMeshComponent.__PropertyMask_bUseKuroParallel : 0));
			}
		}

		// Token: 0x17003D69 RID: 15721
		// (get) Token: 0x0600FAE2 RID: 64226 RVA: 0x00173419 File Offset: 0x00171619
		// (set) Token: 0x0600FAE3 RID: 64227 RVA: 0x00173432 File Offset: 0x00171632
		public unsafe bool bConsumeAllRootMotion
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bConsumeAllRootMotion) & USkeletalMeshComponent.__PropertyMask_bConsumeAllRootMotion) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bConsumeAllRootMotion) = ((*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bConsumeAllRootMotion) & ~USkeletalMeshComponent.__PropertyMask_bConsumeAllRootMotion) | (value ? USkeletalMeshComponent.__PropertyMask_bConsumeAllRootMotion : 0));
			}
		}

		// Token: 0x17003D6A RID: 15722
		// (get) Token: 0x0600FAE4 RID: 64228 RVA: 0x00173462 File Offset: 0x00171662
		// (set) Token: 0x0600FAE5 RID: 64229 RVA: 0x0017347B File Offset: 0x0017167B
		public unsafe bool bCacheFirstAnimInstance
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bCacheFirstAnimInstance) & USkeletalMeshComponent.__PropertyMask_bCacheFirstAnimInstance) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bCacheFirstAnimInstance) = ((*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bCacheFirstAnimInstance) & ~USkeletalMeshComponent.__PropertyMask_bCacheFirstAnimInstance) | (value ? USkeletalMeshComponent.__PropertyMask_bCacheFirstAnimInstance : 0));
			}
		}

		// Token: 0x17003D6B RID: 15723
		// (get) Token: 0x0600FAE6 RID: 64230 RVA: 0x001734AB File Offset: 0x001716AB
		// (set) Token: 0x0600FAE7 RID: 64231 RVA: 0x001734C4 File Offset: 0x001716C4
		public unsafe bool bUseAnimInstanceCachePool
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bUseAnimInstanceCachePool) & USkeletalMeshComponent.__PropertyMask_bUseAnimInstanceCachePool) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bUseAnimInstanceCachePool) = ((*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bUseAnimInstanceCachePool) & ~USkeletalMeshComponent.__PropertyMask_bUseAnimInstanceCachePool) | (value ? USkeletalMeshComponent.__PropertyMask_bUseAnimInstanceCachePool : 0));
			}
		}

		// Token: 0x17003D6C RID: 15724
		// (get) Token: 0x0600FAE8 RID: 64232 RVA: 0x001734F4 File Offset: 0x001716F4
		// (set) Token: 0x0600FAE9 RID: 64233 RVA: 0x00173504 File Offset: 0x00171704
		public unsafe float WeakenKawaiiFollow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_WeakenKawaiiFollow);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_WeakenKawaiiFollow) = value;
			}
		}

		// Token: 0x17003D6D RID: 15725
		// (get) Token: 0x0600FAEA RID: 64234 RVA: 0x00173515 File Offset: 0x00171715
		// (set) Token: 0x0600FAEB RID: 64235 RVA: 0x0017352E File Offset: 0x0017172E
		public unsafe bool bUseParallelSkelCtrlNodeEval
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bUseParallelSkelCtrlNodeEval) & USkeletalMeshComponent.__PropertyMask_bUseParallelSkelCtrlNodeEval) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bUseParallelSkelCtrlNodeEval) = ((*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bUseParallelSkelCtrlNodeEval) & ~USkeletalMeshComponent.__PropertyMask_bUseParallelSkelCtrlNodeEval) | (value ? USkeletalMeshComponent.__PropertyMask_bUseParallelSkelCtrlNodeEval : 0));
			}
		}

		// Token: 0x17003D6E RID: 15726
		// (get) Token: 0x0600FAEC RID: 64236 RVA: 0x0017355E File Offset: 0x0017175E
		// (set) Token: 0x0600FAED RID: 64237 RVA: 0x00173572 File Offset: 0x00171772
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UClothSimulationCreateBase> ClothSimulationCreateClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_ClothSimulationCreateClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_ClothSimulationCreateClass) = value;
			}
		}

		// Token: 0x17003D6F RID: 15727
		// (get) Token: 0x0600FAEE RID: 64238 RVA: 0x00173588 File Offset: 0x00171788
		// (set) Token: 0x0600FAEF RID: 64239 RVA: 0x001735C1 File Offset: 0x001717C1
		[Nullable(1)]
		public TArray<UKCClothAssetBase> KCClothAssets
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UKCClothAssetBase> result;
				if ((result = this._KCClothAssets) == null)
				{
					result = (this._KCClothAssets = new TArray<UKCClothAssetBase>(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_KCClothAssets, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.KCClothAssets.CopyAssign(value);
			}
		}

		// Token: 0x17003D70 RID: 15728
		// (get) Token: 0x0600FAF0 RID: 64240 RVA: 0x001735CF File Offset: 0x001717CF
		// (set) Token: 0x0600FAF1 RID: 64241 RVA: 0x001735DF File Offset: 0x001717DF
		public unsafe bool bEnableKuroClothSimulation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bEnableKuroClothSimulation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bEnableKuroClothSimulation) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003D71 RID: 15729
		// (get) Token: 0x0600FAF2 RID: 64242 RVA: 0x001735F0 File Offset: 0x001717F0
		// (set) Token: 0x0600FAF3 RID: 64243 RVA: 0x00173600 File Offset: 0x00171800
		public unsafe bool bRootMotionDebug
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bRootMotionDebug) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkeletalMeshComponent.__PropertyOffset_bRootMotionDebug) = (value ? 1 : 0);
			}
		}

		// Token: 0x0600FAF4 RID: 64244 RVA: 0x00173611 File Offset: 0x00171811
		public void UpdateLODStatus_Outside()
		{
			USkeletalMeshComponent.__UpdateLODStatus_Outside_Internal(base.NativePtr);
		}

		// Token: 0x0600FAF5 RID: 64245 RVA: 0x0017361E File Offset: 0x0017181E
		public void UnlockKuroEvaluation()
		{
			USkeletalMeshComponent.__UnlockKuroEvaluation_Internal(base.NativePtr);
		}

		// Token: 0x0600FAF6 RID: 64246 RVA: 0x0017362B File Offset: 0x0017182B
		public void UnlinkAnimClassLayers([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UAnimInstance> InClass)
		{
			USkeletalMeshComponent.__UnlinkAnimClassLayers_Internal(base.NativePtr, InClass._NativePtr);
		}

		// Token: 0x0600FAF7 RID: 64247 RVA: 0x0017363E File Offset: 0x0017183E
		public void UnbindClothFromMasterPoseComponent(bool bRestoreSimulationSpace = true)
		{
			USkeletalMeshComponent.__UnbindClothFromMasterPoseComponent_Internal(base.NativePtr, bRestoreSimulationSpace);
		}

		// Token: 0x0600FAF8 RID: 64248 RVA: 0x0017364C File Offset: 0x0017184C
		public void ToggleDisablePostProcessBlueprint()
		{
			USkeletalMeshComponent.__ToggleDisablePostProcessBlueprint_Internal(base.NativePtr);
		}

		// Token: 0x0600FAF9 RID: 64249 RVA: 0x00173659 File Offset: 0x00171859
		public void TickSoftAssetLoading()
		{
			USkeletalMeshComponent.__TickSoftAssetLoading_Internal(base.NativePtr);
		}

		// Token: 0x0600FAFA RID: 64250 RVA: 0x00173666 File Offset: 0x00171866
		public void TestGetBoneSpaceTransforms()
		{
			USkeletalMeshComponent.__TestGetBoneSpaceTransforms_Internal(base.NativePtr);
		}

		// Token: 0x0600FAFB RID: 64251 RVA: 0x00173673 File Offset: 0x00171873
		public void TermBodiesBelow(FName ParentBoneName)
		{
			USkeletalMeshComponent.__TermBodiesBelow_Internal(base.NativePtr, ParentBoneName);
		}

		// Token: 0x0600FAFC RID: 64252 RVA: 0x00173681 File Offset: 0x00171881
		public void SuspendClothingSimulation()
		{
			USkeletalMeshComponent.__SuspendClothingSimulation_Internal(base.NativePtr);
		}

		// Token: 0x0600FAFD RID: 64253 RVA: 0x0017368E File Offset: 0x0017188E
		public void Stop()
		{
			USkeletalMeshComponent.__Stop_Internal(base.NativePtr);
		}

		// Token: 0x0600FAFE RID: 64254 RVA: 0x0017369B File Offset: 0x0017189B
		public void SnapshotPose(ref FPoseSnapshot Snapshot)
		{
			USkeletalMeshComponent.__SnapshotPose_Internal(base.NativePtr, (Snapshot ?? new FPoseSnapshot()).NativePtr);
		}

		// Token: 0x0600FAFF RID: 64255 RVA: 0x001736B8 File Offset: 0x001718B8
		public void SetUseProxyDataBuffer(bool Use)
		{
			USkeletalMeshComponent.__SetUseProxyDataBuffer_Internal(base.NativePtr, Use);
		}

		// Token: 0x0600FB00 RID: 64256 RVA: 0x001736C6 File Offset: 0x001718C6
		public void SetUpdateClothInEditor(bool NewUpdateState)
		{
			USkeletalMeshComponent.__SetUpdateClothInEditor_Internal(base.NativePtr, NewUpdateState);
		}

		// Token: 0x0600FB01 RID: 64257 RVA: 0x001736D4 File Offset: 0x001718D4
		public void SetUpdateAnimationInEditor(bool NewUpdateState)
		{
			USkeletalMeshComponent.__SetUpdateAnimationInEditor_Internal(base.NativePtr, NewUpdateState);
		}

		// Token: 0x0600FB02 RID: 64258 RVA: 0x001736E2 File Offset: 0x001718E2
		public void SetTeleportRotationThreshold(float Threshold)
		{
			USkeletalMeshComponent.__SetTeleportRotationThreshold_Internal(base.NativePtr, Threshold);
		}

		// Token: 0x0600FB03 RID: 64259 RVA: 0x001736F0 File Offset: 0x001718F0
		public void SetTeleportDistanceThreshold(float Threshold)
		{
			USkeletalMeshComponent.__SetTeleportDistanceThreshold_Internal(base.NativePtr, Threshold);
		}

		// Token: 0x0600FB04 RID: 64260 RVA: 0x001736FE File Offset: 0x001718FE
		public void SetSkeletalMeshScreenSizeCullRatio(float Value)
		{
			USkeletalMeshComponent.__SetSkeletalMeshScreenSizeCullRatio_Internal(base.NativePtr, Value);
		}

		// Token: 0x0600FB05 RID: 64261 RVA: 0x0017370C File Offset: 0x0017190C
		public void SetRenderInKuroXRayPass(bool bValue)
		{
			USkeletalMeshComponent.__SetRenderInKuroXRayPass_Internal(base.NativePtr, bValue);
		}

		// Token: 0x0600FB06 RID: 64262 RVA: 0x0017371A File Offset: 0x0017191A
		public void SetPosition(float InPos, bool bFireNotifies = true)
		{
			USkeletalMeshComponent.__SetPosition_Internal(base.NativePtr, InPos, bFireNotifies);
		}

		// Token: 0x0600FB07 RID: 64263 RVA: 0x00173729 File Offset: 0x00171929
		public void SetPlayRate(float Rate)
		{
			USkeletalMeshComponent.__SetPlayRate_Internal(base.NativePtr, Rate);
		}

		// Token: 0x0600FB08 RID: 64264 RVA: 0x00173737 File Offset: 0x00171937
		public void SetPhysicsBlendWeight(float PhysicsBlendWeight)
		{
			USkeletalMeshComponent.__SetPhysicsBlendWeight_Internal(base.NativePtr, PhysicsBlendWeight);
		}

		// Token: 0x0600FB09 RID: 64265 RVA: 0x00173745 File Offset: 0x00171945
		public void SetNotifyRigidBodyCollisionBelow(bool bNewNotifyRigidBodyCollision, FName BoneName = default(FName), bool bIncludeSelf = true)
		{
			USkeletalMeshComponent.__SetNotifyRigidBodyCollisionBelow_Internal(base.NativePtr, bNewNotifyRigidBodyCollision, BoneName, bIncludeSelf);
		}

		// Token: 0x0600FB0A RID: 64266 RVA: 0x00173755 File Offset: 0x00171955
		public void SetMorphTarget(FName MorphTargetName, float Value, bool bRemoveZeroWeight = true)
		{
			USkeletalMeshComponent.__SetMorphTarget_Internal(base.NativePtr, MorphTargetName, Value, bRemoveZeroWeight);
		}

		// Token: 0x0600FB0B RID: 64267 RVA: 0x00173765 File Offset: 0x00171965
		public void SetKuroXRayPenetrateCharacters(bool bValue)
		{
			USkeletalMeshComponent.__SetKuroXRayPenetrateCharacters_Internal(base.NativePtr, bValue);
		}

		// Token: 0x0600FB0C RID: 64268 RVA: 0x00173773 File Offset: 0x00171973
		public void SetKuroXRayOutlineWidth(float InWidth)
		{
			USkeletalMeshComponent.__SetKuroXRayOutlineWidth_Internal(base.NativePtr, InWidth);
		}

		// Token: 0x0600FB0D RID: 64269 RVA: 0x00173781 File Offset: 0x00171981
		public void SetKuroXRayOutlineMaterial(UMaterialInterface InMaterial)
		{
			USkeletalMeshComponent.__SetKuroXRayOutlineMaterial_Internal(base.NativePtr, (InMaterial != null) ? InMaterial.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600FB0E RID: 64270 RVA: 0x0017379E File Offset: 0x0017199E
		public void SetKuroXRayMaterial(UMaterialInterface InMaterial)
		{
			USkeletalMeshComponent.__SetKuroXRayMaterial_Internal(base.NativePtr, (InMaterial != null) ? InMaterial.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600FB0F RID: 64271 RVA: 0x001737BB File Offset: 0x001719BB
		public void SetKuroXRayDistance(float InDistance)
		{
			USkeletalMeshComponent.__SetKuroXRayDistance_Internal(base.NativePtr, InDistance);
		}

		// Token: 0x0600FB10 RID: 64272 RVA: 0x001737C9 File Offset: 0x001719C9
		public void SetKuroXRayColor(FLinearColor InKuroXRayColor)
		{
			USkeletalMeshComponent.__SetKuroXRayColor_Internal(base.NativePtr, InKuroXRayColor);
		}

		// Token: 0x0600FB11 RID: 64273 RVA: 0x001737D7 File Offset: 0x001719D7
		public void SetKuroSkipAnimNotifies(bool bInSkip)
		{
			USkeletalMeshComponent.__SetKuroSkipAnimNotifies_Internal(base.NativePtr, bInSkip);
		}

		// Token: 0x0600FB12 RID: 64274 RVA: 0x001737E5 File Offset: 0x001719E5
		public void SetForceDisableBoneBounds(bool InForceDisableBoneBounds = true)
		{
			USkeletalMeshComponent.__SetForceDisableBoneBounds_Internal(base.NativePtr, InForceDisableBoneBounds);
		}

		// Token: 0x0600FB13 RID: 64275 RVA: 0x001737F3 File Offset: 0x001719F3
		public void SetEnablePhysicsBlending(bool bNewBlendPhysics)
		{
			USkeletalMeshComponent.__SetEnablePhysicsBlending_Internal(base.NativePtr, bNewBlendPhysics);
		}

		// Token: 0x0600FB14 RID: 64276 RVA: 0x00173801 File Offset: 0x00171A01
		public void SetEnableOverrideSkeletalMeshScreenSizeCullRatio(bool bValue)
		{
			USkeletalMeshComponent.__SetEnableOverrideSkeletalMeshScreenSizeCullRatio_Internal(base.NativePtr, bValue);
		}

		// Token: 0x0600FB15 RID: 64277 RVA: 0x0017380F File Offset: 0x00171A0F
		public void SetEnableGravityOnAllBodiesBelow(bool bEnableGravity, FName BoneName, bool bIncludeSelf = true)
		{
			USkeletalMeshComponent.__SetEnableGravityOnAllBodiesBelow_Internal(base.NativePtr, bEnableGravity, BoneName, bIncludeSelf);
		}

		// Token: 0x0600FB16 RID: 64278 RVA: 0x0017381F File Offset: 0x00171A1F
		public void SetEnableBodyGravity(bool bEnableGravity, FName BoneName)
		{
			USkeletalMeshComponent.__SetEnableBodyGravity_Internal(base.NativePtr, bEnableGravity, BoneName);
		}

		// Token: 0x0600FB17 RID: 64279 RVA: 0x00173830 File Offset: 0x00171A30
		public unsafe void SetDynamicMaterialScalarParameterValue(int InMatIndex, in FName InParamName, float InValue)
		{
			fixed (FName* ptr = &InParamName)
			{
				void* ptr2 = (void*)ptr;
				USkeletalMeshComponent.__SetDynamicMaterialScalarParameterValue_Internal(base.NativePtr, InMatIndex, InParamName, InValue);
			}
		}

		// Token: 0x0600FB18 RID: 64280 RVA: 0x00173853 File Offset: 0x00171A53
		public void SetDisableWaterForToon(bool bValue)
		{
			USkeletalMeshComponent.__SetDisableWaterForToon_Internal(base.NativePtr, bValue);
		}

		// Token: 0x0600FB19 RID: 64281 RVA: 0x00173861 File Offset: 0x00171A61
		public void SetDisablePostProcessBlueprint(bool bInDisablePostProcess)
		{
			USkeletalMeshComponent.__SetDisablePostProcessBlueprint_Internal(base.NativePtr, bInDisablePostProcess);
		}

		// Token: 0x0600FB1A RID: 64282 RVA: 0x0017386F File Offset: 0x00171A6F
		public void SetDisableAnimCurves(bool bInDisableAnimCurves)
		{
			USkeletalMeshComponent.__SetDisableAnimCurves_Internal(base.NativePtr, bInDisableAnimCurves);
		}

		// Token: 0x0600FB1B RID: 64283 RVA: 0x0017387D File Offset: 0x00171A7D
		public void SetDelayCompleteParallelEvaluation()
		{
			USkeletalMeshComponent.__SetDelayCompleteParallelEvaluation_Internal(base.NativePtr);
		}

		// Token: 0x0600FB1C RID: 64284 RVA: 0x0017388A File Offset: 0x00171A8A
		public void SetConstraintProfileForAll(FName ProfileName, bool bDefaultIfNotFound = false)
		{
			USkeletalMeshComponent.__SetConstraintProfileForAll_Internal(base.NativePtr, ProfileName, bDefaultIfNotFound);
		}

		// Token: 0x0600FB1D RID: 64285 RVA: 0x00173899 File Offset: 0x00171A99
		public void SetConstraintProfile(FName JointName, FName ProfileName, bool bDefaultIfNotFound = false)
		{
			USkeletalMeshComponent.__SetConstraintProfile_Internal(base.NativePtr, JointName, ProfileName, bDefaultIfNotFound);
		}

		// Token: 0x0600FB1E RID: 64286 RVA: 0x001738A9 File Offset: 0x00171AA9
		public void SetClothMaxDistanceScale(float Scale)
		{
			USkeletalMeshComponent.__SetClothMaxDistanceScale_Internal(base.NativePtr, Scale);
		}

		// Token: 0x0600FB1F RID: 64287 RVA: 0x001738B7 File Offset: 0x00171AB7
		public void SetBodyNotifyRigidBodyCollision(bool bNewNotifyRigidBodyCollision, FName BoneName = default(FName))
		{
			USkeletalMeshComponent.__SetBodyNotifyRigidBodyCollision_Internal(base.NativePtr, bNewNotifyRigidBodyCollision, BoneName);
		}

		// Token: 0x0600FB20 RID: 64288 RVA: 0x001738C6 File Offset: 0x00171AC6
		public void SetAnimClass(UClassStackOnlyPtr NewClass)
		{
			USkeletalMeshComponent.__SetAnimClass_Internal(base.NativePtr, NewClass._NativePtr);
		}

		// Token: 0x0600FB21 RID: 64289 RVA: 0x001738D9 File Offset: 0x00171AD9
		public void SetAnimationRibbonAsset(UAnimationAsset NewRibbonAsset)
		{
			USkeletalMeshComponent.__SetAnimationRibbonAsset_Internal(base.NativePtr, (NewRibbonAsset != null) ? NewRibbonAsset.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600FB22 RID: 64290 RVA: 0x001738F6 File Offset: 0x00171AF6
		public void SetAnimationMode(EAnimationMode InAnimationMode)
		{
			USkeletalMeshComponent.__SetAnimationMode_Internal(base.NativePtr, InAnimationMode);
		}

		// Token: 0x0600FB23 RID: 64291 RVA: 0x00173909 File Offset: 0x00171B09
		public void SetAnimation(UAnimationAsset NewAnimToPlay)
		{
			USkeletalMeshComponent.__SetAnimation_Internal(base.NativePtr, (NewAnimToPlay != null) ? NewAnimToPlay.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600FB24 RID: 64292 RVA: 0x00173926 File Offset: 0x00171B26
		public void SetAngularLimits(FName InBoneName, float Swing1LimitAngle, float TwistLimitAngle, float Swing2LimitAngle)
		{
			USkeletalMeshComponent.__SetAngularLimits_Internal(base.NativePtr, InBoneName, Swing1LimitAngle, TwistLimitAngle, Swing2LimitAngle);
		}

		// Token: 0x0600FB25 RID: 64293 RVA: 0x00173938 File Offset: 0x00171B38
		public void SetAllowRigidBodyAnimNode(bool bInAllow, bool bReinitAnim = true)
		{
			USkeletalMeshComponent.__SetAllowRigidBodyAnimNode_Internal(base.NativePtr, bInAllow, bReinitAnim);
		}

		// Token: 0x0600FB26 RID: 64294 RVA: 0x00173947 File Offset: 0x00171B47
		public void SetAllowedAnimCurvesEvaluation(in TArray<FName> List, bool bAllow)
		{
			USkeletalMeshComponent.__SetAllowedAnimCurvesEvaluation_Internal(base.NativePtr, (List ?? new TArray<FName>()).NativePtr, bAllow);
		}

		// Token: 0x0600FB27 RID: 64295 RVA: 0x00173965 File Offset: 0x00171B65
		public void SetAllowAnimCurveEvaluation(bool bInAllow)
		{
			USkeletalMeshComponent.__SetAllowAnimCurveEvaluation_Internal(base.NativePtr, bInAllow);
		}

		// Token: 0x0600FB28 RID: 64296 RVA: 0x00173973 File Offset: 0x00171B73
		public void SetAllMotorsAngularVelocityDrive(bool bEnableSwingDrive, bool bEnableTwistDrive, bool bSkipCustomPhysicsType = false)
		{
			USkeletalMeshComponent.__SetAllMotorsAngularVelocityDrive_Internal(base.NativePtr, bEnableSwingDrive, bEnableTwistDrive, bSkipCustomPhysicsType);
		}

		// Token: 0x0600FB29 RID: 64297 RVA: 0x00173983 File Offset: 0x00171B83
		public void SetAllMotorsAngularPositionDrive(bool bEnableSwingDrive, bool bEnableTwistDrive, bool bSkipCustomPhysicsType = false)
		{
			USkeletalMeshComponent.__SetAllMotorsAngularPositionDrive_Internal(base.NativePtr, bEnableSwingDrive, bEnableTwistDrive, bSkipCustomPhysicsType);
		}

		// Token: 0x0600FB2A RID: 64298 RVA: 0x00173993 File Offset: 0x00171B93
		public void SetAllMotorsAngularDriveParams(float InSpring, float InDamping, float InForceLimit, bool bSkipCustomPhysicsType = false)
		{
			USkeletalMeshComponent.__SetAllMotorsAngularDriveParams_Internal(base.NativePtr, InSpring, InDamping, InForceLimit, bSkipCustomPhysicsType);
		}

		// Token: 0x0600FB2B RID: 64299 RVA: 0x001739A5 File Offset: 0x00171BA5
		public void SetAllBodiesSimulatePhysics(bool bNewSimulate)
		{
			USkeletalMeshComponent.__SetAllBodiesSimulatePhysics_Internal(base.NativePtr, bNewSimulate);
		}

		// Token: 0x0600FB2C RID: 64300 RVA: 0x001739B3 File Offset: 0x00171BB3
		public void SetAllBodiesPhysicsBlendWeight(float PhysicsBlendWeight, bool bSkipCustomPhysicsType = false)
		{
			USkeletalMeshComponent.__SetAllBodiesPhysicsBlendWeight_Internal(base.NativePtr, PhysicsBlendWeight, bSkipCustomPhysicsType);
		}

		// Token: 0x0600FB2D RID: 64301 RVA: 0x001739C4 File Offset: 0x00171BC4
		public unsafe void SetAllBodiesBelowSimulatePhysics(in FName InBoneName, bool bNewSimulate, bool bIncludeSelf = true)
		{
			fixed (FName* ptr = &InBoneName)
			{
				void* ptr2 = (void*)ptr;
				USkeletalMeshComponent.__SetAllBodiesBelowSimulatePhysics_Internal(base.NativePtr, InBoneName, bNewSimulate, bIncludeSelf);
			}
		}

		// Token: 0x0600FB2E RID: 64302 RVA: 0x001739E8 File Offset: 0x00171BE8
		public unsafe void SetAllBodiesBelowPhysicsBlendWeight(in FName InBoneName, float PhysicsBlendWeight, bool bSkipCustomPhysicsType = false, bool bIncludeSelf = true)
		{
			fixed (FName* ptr = &InBoneName)
			{
				void* ptr2 = (void*)ptr;
				USkeletalMeshComponent.__SetAllBodiesBelowPhysicsBlendWeight_Internal(base.NativePtr, InBoneName, PhysicsBlendWeight, bSkipCustomPhysicsType, bIncludeSelf);
			}
		}

		// Token: 0x0600FB2F RID: 64303 RVA: 0x00173A0D File Offset: 0x00171C0D
		public void ResumeClothingSimulation()
		{
			USkeletalMeshComponent.__ResumeClothingSimulation_Internal(base.NativePtr);
		}

		// Token: 0x0600FB30 RID: 64304 RVA: 0x00173A1A File Offset: 0x00171C1A
		public void ResetEvaluationDebugStatistics()
		{
			USkeletalMeshComponent.__ResetEvaluationDebugStatistics_Internal(base.NativePtr);
		}

		// Token: 0x0600FB31 RID: 64305 RVA: 0x00173A27 File Offset: 0x00171C27
		public void ResetClothTeleportMode()
		{
			USkeletalMeshComponent.__ResetClothTeleportMode_Internal(base.NativePtr);
		}

		// Token: 0x0600FB32 RID: 64306 RVA: 0x00173A34 File Offset: 0x00171C34
		public void ResetAnimInstanceDynamics(ETeleportType InTeleportType = ETeleportType.ResetPhysics)
		{
			USkeletalMeshComponent.__ResetAnimInstanceDynamics_Internal(base.NativePtr, InTeleportType);
		}

		// Token: 0x0600FB33 RID: 64307 RVA: 0x00173A42 File Offset: 0x00171C42
		public void ResetAllowedAnimCurveEvaluation()
		{
			USkeletalMeshComponent.__ResetAllowedAnimCurveEvaluation_Internal(base.NativePtr);
		}

		// Token: 0x0600FB34 RID: 64308 RVA: 0x00173A4F File Offset: 0x00171C4F
		public void ResetAllBodiesSimulatePhysics()
		{
			USkeletalMeshComponent.__ResetAllBodiesSimulatePhysics_Internal(base.NativePtr);
		}

		// Token: 0x0600FB35 RID: 64309 RVA: 0x00173A5C File Offset: 0x00171C5C
		public void RemoveKuroCloth(UKCClothAssetBase ClothAsset)
		{
			USkeletalMeshComponent.__RemoveKuroCloth_Internal(base.NativePtr, (ClothAsset != null) ? ClothAsset.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600FB36 RID: 64310 RVA: 0x00173A79 File Offset: 0x00171C79
		public void RegisterKuroCharPostUpdateTickFun(bool bRegister)
		{
			USkeletalMeshComponent.__RegisterKuroCharPostUpdateTickFun_Internal(base.NativePtr, bRegister);
		}

		// Token: 0x0600FB37 RID: 64311 RVA: 0x00173A87 File Offset: 0x00171C87
		public void RecreateKuroCloth()
		{
			USkeletalMeshComponent.__RecreateKuroCloth_Internal(base.NativePtr);
		}

		// Token: 0x0600FB38 RID: 64312 RVA: 0x00173A94 File Offset: 0x00171C94
		public void PlayAnimation(UAnimationAsset NewAnimToPlay, bool bLooping)
		{
			USkeletalMeshComponent.__PlayAnimation_Internal(base.NativePtr, (NewAnimToPlay != null) ? NewAnimToPlay.NativePtr : IntPtr.Zero, bLooping);
		}

		// Token: 0x0600FB39 RID: 64313 RVA: 0x00173AB2 File Offset: 0x00171CB2
		public void Play(bool bLooping)
		{
			USkeletalMeshComponent.__Play_Internal(base.NativePtr, bLooping);
		}

		// Token: 0x0600FB3A RID: 64314 RVA: 0x00173AC0 File Offset: 0x00171CC0
		public void OverrideAnimationData(UAnimationAsset InAnimToPlay, bool bIsLooping = true, bool bIsPlaying = true, float Position = 0f, float PlayRate = 1f)
		{
			USkeletalMeshComponent.__OverrideAnimationData_Internal(base.NativePtr, (InAnimToPlay != null) ? InAnimToPlay.NativePtr : IntPtr.Zero, bIsLooping, bIsPlaying, Position, PlayRate);
		}

		// Token: 0x0600FB3B RID: 64315 RVA: 0x00173AE3 File Offset: 0x00171CE3
		public void LinkAnimGraphByTag(FName InTag, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UAnimInstance> InClass)
		{
			USkeletalMeshComponent.__LinkAnimGraphByTag_Internal(base.NativePtr, InTag, InClass._NativePtr);
		}

		// Token: 0x0600FB3C RID: 64316 RVA: 0x00173AF7 File Offset: 0x00171CF7
		public void LinkAnimClassLayers([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UAnimInstance> InClass)
		{
			USkeletalMeshComponent.__LinkAnimClassLayers_Internal(base.NativePtr, InClass._NativePtr);
		}

		// Token: 0x0600FB3D RID: 64317 RVA: 0x00173B0A File Offset: 0x00171D0A
		public void Kuro_UpdateRootMotionParams()
		{
			USkeletalMeshComponent.__Kuro_UpdateRootMotionParams_Internal(base.NativePtr);
		}

		// Token: 0x0600FB3E RID: 64318 RVA: 0x00173B18 File Offset: 0x00171D18
		public unsafe bool K2_GetClosestPointOnPhysicsAsset(in FVector WorldPosition, ref FVector ClosestWorldPosition, ref FVector Normal, ref FName BoneName, ref float Distance)
		{
			fixed (FVector* ptr = &ClosestWorldPosition)
			{
				void* ptr2 = (void*)ptr;
				fixed (FVector* ptr3 = &Normal)
				{
					void* ptr4 = (void*)ptr3;
					fixed (FName* ptr5 = &BoneName)
					{
						void* ptr6 = (void*)ptr5;
						fixed (float* ptr7 = &Distance)
						{
							void* ptr8 = (void*)ptr7;
							return USkeletalMeshComponent.__K2_GetClosestPointOnPhysicsAsset_Internal(base.NativePtr, WorldPosition, ref ClosestWorldPosition, ref Normal, ref BoneName, ref Distance);
						}
					}
				}
			}
		}

		// Token: 0x0600FB3F RID: 64319 RVA: 0x00173B55 File Offset: 0x00171D55
		public bool IsPlaying()
		{
			return USkeletalMeshComponent.__IsPlaying_Internal(base.NativePtr);
		}

		// Token: 0x0600FB40 RID: 64320 RVA: 0x00173B62 File Offset: 0x00171D62
		public bool IsClothingSimulationSuspended()
		{
			return USkeletalMeshComponent.__IsClothingSimulationSuspended_Internal(base.NativePtr);
		}

		// Token: 0x0600FB41 RID: 64321 RVA: 0x00173B6F File Offset: 0x00171D6F
		public bool IsBodyGravityEnabled(FName BoneName)
		{
			return USkeletalMeshComponent.__IsBodyGravityEnabled_Internal(base.NativePtr, BoneName);
		}

		// Token: 0x0600FB42 RID: 64322 RVA: 0x00173B7D File Offset: 0x00171D7D
		public bool HasValidAnimationInstance()
		{
			return USkeletalMeshComponent.__HasValidAnimationInstance_Internal(base.NativePtr);
		}

		// Token: 0x0600FB43 RID: 64323 RVA: 0x00173B8A File Offset: 0x00171D8A
		public float GetTeleportRotationThreshold()
		{
			return USkeletalMeshComponent.__GetTeleportRotationThreshold_Internal(base.NativePtr);
		}

		// Token: 0x0600FB44 RID: 64324 RVA: 0x00173B97 File Offset: 0x00171D97
		public float GetTeleportDistanceThreshold()
		{
			return USkeletalMeshComponent.__GetTeleportDistanceThreshold_Internal(base.NativePtr);
		}

		// Token: 0x0600FB45 RID: 64325 RVA: 0x00173BA4 File Offset: 0x00171DA4
		[NullableContext(1)]
		public unsafe bool GetStringAttribute_Ref(in FName BoneName, in FName AttributeName, ref string OutValue, ECustomBoneAttributeLookup LookupType = ECustomBoneAttributeLookup.BoneOnly)
		{
			FString fstring = FString.AllocTemp(OutValue);
			fixed (FName* ptr = &BoneName)
			{
				void* ptr2 = (void*)ptr;
				fixed (FName* ptr3 = &AttributeName)
				{
					void* ptr4 = (void*)ptr3;
					bool result = USkeletalMeshComponent.__GetStringAttribute_Ref_Internal(base.NativePtr, BoneName, AttributeName, ref fstring, LookupType);
					OutValue = FString.ToString(fstring);
					FString.NativeDestruct(&fstring, 1);
					return result;
				}
			}
		}

		// Token: 0x0600FB46 RID: 64326 RVA: 0x00173BE8 File Offset: 0x00171DE8
		[NullableContext(1)]
		public unsafe bool GetStringAttribute(in FName BoneName, in FName AttributeName, string DefaultValue, ref string OutValue, ECustomBoneAttributeLookup LookupType = ECustomBoneAttributeLookup.BoneOnly)
		{
			FString fstring = FString.AllocTemp(DefaultValue);
			FString fstring2 = FString.AllocTemp(OutValue);
			fixed (FName* ptr = &BoneName)
			{
				void* ptr2 = (void*)ptr;
				fixed (FName* ptr3 = &AttributeName)
				{
					void* ptr4 = (void*)ptr3;
					bool result = USkeletalMeshComponent.__GetStringAttribute_Internal(base.NativePtr, BoneName, AttributeName, fstring, ref fstring2, LookupType);
					FString.NativeDestruct(&fstring, 1);
					OutValue = FString.ToString(fstring2);
					FString.NativeDestruct(&fstring2, 1);
					return result;
				}
			}
		}

		// Token: 0x0600FB47 RID: 64327 RVA: 0x00173C42 File Offset: 0x00171E42
		public float GetSkeletalMeshScreenSizeCullRatio()
		{
			return USkeletalMeshComponent.__GetSkeletalMeshScreenSizeCullRatio_Internal(base.NativePtr);
		}

		// Token: 0x0600FB48 RID: 64328 RVA: 0x00173C4F File Offset: 0x00171E4F
		public FVector GetSkeletalCenterOfMass()
		{
			return USkeletalMeshComponent.__GetSkeletalCenterOfMass_Internal(base.NativePtr);
		}

		// Token: 0x0600FB49 RID: 64329 RVA: 0x00173C5C File Offset: 0x00171E5C
		public bool GetRenderInKuroXRayPass()
		{
			return USkeletalMeshComponent.__GetRenderInKuroXRayPass_Internal(base.NativePtr);
		}

		// Token: 0x0600FB4A RID: 64330 RVA: 0x00173C69 File Offset: 0x00171E69
		public FVectorDouble GetRefBoneWorldPosition(FName BoneName)
		{
			return USkeletalMeshComponent.__GetRefBoneWorldPosition_Internal(base.NativePtr, BoneName);
		}

		// Token: 0x0600FB4B RID: 64331 RVA: 0x00173C77 File Offset: 0x00171E77
		public FVectorDouble GetRefBoneComponentPosition(FName BoneName)
		{
			return USkeletalMeshComponent.__GetRefBoneComponentPosition_Internal(base.NativePtr, BoneName);
		}

		// Token: 0x0600FB4C RID: 64332 RVA: 0x00173C85 File Offset: 0x00171E85
		public UAnimInstance GetPostProcessInstance()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimInstance>(USkeletalMeshComponent.__GetPostProcessInstance_Internal(base.NativePtr));
		}

		// Token: 0x0600FB4D RID: 64333 RVA: 0x00173C97 File Offset: 0x00171E97
		public float GetPosition()
		{
			return USkeletalMeshComponent.__GetPosition_Internal(base.NativePtr);
		}

		// Token: 0x0600FB4E RID: 64334 RVA: 0x00173CA4 File Offset: 0x00171EA4
		public float GetPlayRate()
		{
			return USkeletalMeshComponent.__GetPlayRate_Internal(base.NativePtr);
		}

		// Token: 0x0600FB4F RID: 64335 RVA: 0x00173CB1 File Offset: 0x00171EB1
		[NullableContext(1)]
		public TArray<string> GetMorphTargetNames()
		{
			return new TArray<string>(USkeletalMeshComponent.__GetMorphTargetNames_Internal(base.NativePtr), null);
		}

		// Token: 0x0600FB50 RID: 64336 RVA: 0x00173CC4 File Offset: 0x00171EC4
		public float GetMorphTarget(FName MorphTargetName)
		{
			return USkeletalMeshComponent.__GetMorphTarget_Internal(base.NativePtr, MorphTargetName);
		}

		// Token: 0x0600FB51 RID: 64337 RVA: 0x00173CD2 File Offset: 0x00171ED2
		public UAnimInstance GetLinkedAnimLayerInstanceByGroup(FName InGroup)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimInstance>(USkeletalMeshComponent.__GetLinkedAnimLayerInstanceByGroup_Internal(base.NativePtr, InGroup));
		}

		// Token: 0x0600FB52 RID: 64338 RVA: 0x00173CE5 File Offset: 0x00171EE5
		public UAnimInstance GetLinkedAnimLayerInstanceByClass([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UAnimInstance> InClass)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimInstance>(USkeletalMeshComponent.__GetLinkedAnimLayerInstanceByClass_Internal(base.NativePtr, InClass._NativePtr));
		}

		// Token: 0x0600FB53 RID: 64339 RVA: 0x00173CFD File Offset: 0x00171EFD
		public void GetLinkedAnimGraphInstancesByTag(FName InTag, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<UAnimInstance> OutLinkedInstances)
		{
			USkeletalMeshComponent.__GetLinkedAnimGraphInstancesByTag_Internal(base.NativePtr, InTag, (OutLinkedInstances ?? new TArray<UAnimInstance>()).NativePtr);
		}

		// Token: 0x0600FB54 RID: 64340 RVA: 0x00173D1B File Offset: 0x00171F1B
		public UAnimInstance GetLinkedAnimGraphInstanceByTag(FName InTag)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimInstance>(USkeletalMeshComponent.__GetLinkedAnimGraphInstanceByTag_Internal(base.NativePtr, InTag));
		}

		// Token: 0x0600FB55 RID: 64341 RVA: 0x00173D2E File Offset: 0x00171F2E
		public bool GetKuroXRayPenetrateCharacters()
		{
			return USkeletalMeshComponent.__GetKuroXRayPenetrateCharacters_Internal(base.NativePtr);
		}

		// Token: 0x0600FB56 RID: 64342 RVA: 0x00173D3B File Offset: 0x00171F3B
		public float GetKuroXRayOutlineWidth()
		{
			return USkeletalMeshComponent.__GetKuroXRayOutlineWidth_Internal(base.NativePtr);
		}

		// Token: 0x0600FB57 RID: 64343 RVA: 0x00173D48 File Offset: 0x00171F48
		public UMaterialInterface GetKuroXRayOutlineMaterial()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInterface>(USkeletalMeshComponent.__GetKuroXRayOutlineMaterial_Internal(base.NativePtr));
		}

		// Token: 0x0600FB58 RID: 64344 RVA: 0x00173D5A File Offset: 0x00171F5A
		public UMaterialInterface GetKuroXRayMaterial()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInterface>(USkeletalMeshComponent.__GetKuroXRayMaterial_Internal(base.NativePtr));
		}

		// Token: 0x0600FB59 RID: 64345 RVA: 0x00173D6C File Offset: 0x00171F6C
		public float GetKuroXRayDistance()
		{
			return USkeletalMeshComponent.__GetKuroXRayDistance_Internal(base.NativePtr);
		}

		// Token: 0x0600FB5A RID: 64346 RVA: 0x00173D79 File Offset: 0x00171F79
		public FVector4 GetKuroXRayColor()
		{
			return USkeletalMeshComponent.__GetKuroXRayColor_Internal(base.NativePtr);
		}

		// Token: 0x0600FB5B RID: 64347 RVA: 0x00173D86 File Offset: 0x00171F86
		public bool GetKuroSkipAnimNotifies()
		{
			return USkeletalMeshComponent.__GetKuroSkipAnimNotifies_Internal(base.NativePtr);
		}

		// Token: 0x0600FB5C RID: 64348 RVA: 0x00173D94 File Offset: 0x00171F94
		public unsafe bool GetIntegerAttribute_Ref(in FName BoneName, in FName AttributeName, ref int OutValue, ECustomBoneAttributeLookup LookupType = ECustomBoneAttributeLookup.BoneOnly)
		{
			fixed (FName* ptr = &BoneName)
			{
				void* ptr2 = (void*)ptr;
				fixed (FName* ptr3 = &AttributeName)
				{
					void* ptr4 = (void*)ptr3;
					fixed (int* ptr5 = &OutValue)
					{
						void* ptr6 = (void*)ptr5;
						return USkeletalMeshComponent.__GetIntegerAttribute_Ref_Internal(base.NativePtr, BoneName, AttributeName, ref OutValue, LookupType);
					}
				}
			}
		}

		// Token: 0x0600FB5D RID: 64349 RVA: 0x00173DC4 File Offset: 0x00171FC4
		public unsafe bool GetIntegerAttribute(in FName BoneName, in FName AttributeName, int DefaultValue, ref int OutValue, ECustomBoneAttributeLookup LookupType = ECustomBoneAttributeLookup.BoneOnly)
		{
			fixed (FName* ptr = &BoneName)
			{
				void* ptr2 = (void*)ptr;
				fixed (FName* ptr3 = &AttributeName)
				{
					void* ptr4 = (void*)ptr3;
					fixed (int* ptr5 = &OutValue)
					{
						void* ptr6 = (void*)ptr5;
						return USkeletalMeshComponent.__GetIntegerAttribute_Internal(base.NativePtr, BoneName, AttributeName, DefaultValue, ref OutValue, LookupType);
					}
				}
			}
		}

		// Token: 0x0600FB5E RID: 64350 RVA: 0x00173DF8 File Offset: 0x00171FF8
		public unsafe bool GetFloatAttribute_Ref(in FName BoneName, in FName AttributeName, ref float OutValue, ECustomBoneAttributeLookup LookupType = ECustomBoneAttributeLookup.BoneOnly)
		{
			fixed (FName* ptr = &BoneName)
			{
				void* ptr2 = (void*)ptr;
				fixed (FName* ptr3 = &AttributeName)
				{
					void* ptr4 = (void*)ptr3;
					fixed (float* ptr5 = &OutValue)
					{
						void* ptr6 = (void*)ptr5;
						return USkeletalMeshComponent.__GetFloatAttribute_Ref_Internal(base.NativePtr, BoneName, AttributeName, ref OutValue, LookupType);
					}
				}
			}
		}

		// Token: 0x0600FB5F RID: 64351 RVA: 0x00173E28 File Offset: 0x00172028
		public unsafe bool GetFloatAttribute(in FName BoneName, in FName AttributeName, float DefaultValue, ref float OutValue, ECustomBoneAttributeLookup LookupType = ECustomBoneAttributeLookup.BoneOnly)
		{
			fixed (FName* ptr = &BoneName)
			{
				void* ptr2 = (void*)ptr;
				fixed (FName* ptr3 = &AttributeName)
				{
					void* ptr4 = (void*)ptr3;
					fixed (float* ptr5 = &OutValue)
					{
						void* ptr6 = (void*)ptr5;
						return USkeletalMeshComponent.__GetFloatAttribute_Internal(base.NativePtr, BoneName, AttributeName, DefaultValue, ref OutValue, LookupType);
					}
				}
			}
		}

		// Token: 0x0600FB60 RID: 64352 RVA: 0x00173E5B File Offset: 0x0017205B
		public bool GetEnableOverrideSkeletalMeshScreenSizeCullRatio()
		{
			return USkeletalMeshComponent.__GetEnableOverrideSkeletalMeshScreenSizeCullRatio_Internal(base.NativePtr);
		}

		// Token: 0x0600FB61 RID: 64353 RVA: 0x00173E68 File Offset: 0x00172068
		public bool GetDisablePostProcessBlueprint()
		{
			return USkeletalMeshComponent.__GetDisablePostProcessBlueprint_Internal(base.NativePtr);
		}

		// Token: 0x0600FB62 RID: 64354 RVA: 0x00173E75 File Offset: 0x00172075
		public bool GetDisableAnimCurves()
		{
			return USkeletalMeshComponent.__GetDisableAnimCurves_Internal(base.NativePtr);
		}

		// Token: 0x0600FB63 RID: 64355 RVA: 0x00173E84 File Offset: 0x00172084
		public unsafe void GetCurrentJointAngles(FName InBoneName, ref float Swing1Angle, ref float TwistAngle, ref float Swing2Angle)
		{
			fixed (float* ptr = &Swing1Angle)
			{
				void* ptr2 = (void*)ptr;
				fixed (float* ptr3 = &TwistAngle)
				{
					void* ptr4 = (void*)ptr3;
					fixed (float* ptr5 = &Swing2Angle)
					{
						void* ptr6 = (void*)ptr5;
						USkeletalMeshComponent.__GetCurrentJointAngles_Internal(base.NativePtr, InBoneName, ref Swing1Angle, ref TwistAngle, ref Swing2Angle);
						ptr = null;
						ptr3 = null;
					}
				}
			}
		}

		// Token: 0x0600FB64 RID: 64356 RVA: 0x00173EC0 File Offset: 0x001720C0
		public float GetClothMaxDistanceScale()
		{
			return USkeletalMeshComponent.__GetClothMaxDistanceScale_Internal(base.NativePtr);
		}

		// Token: 0x0600FB65 RID: 64357 RVA: 0x00173ECD File Offset: 0x001720CD
		public UClothingSimulationInteractor GetClothingSimulationInteractor()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UClothingSimulationInteractor>(USkeletalMeshComponent.__GetClothingSimulationInteractor_Internal(base.NativePtr));
		}

		// Token: 0x0600FB66 RID: 64358 RVA: 0x00173EDF File Offset: 0x001720DF
		public float GetBoneMass(FName BoneName = default(FName), bool bScaleMass = true)
		{
			return USkeletalMeshComponent.__GetBoneMass_Internal(base.NativePtr, BoneName, bScaleMass);
		}

		// Token: 0x0600FB67 RID: 64359 RVA: 0x00173EEE File Offset: 0x001720EE
		public byte GetAnimInstanceUpdateState()
		{
			return USkeletalMeshComponent.__GetAnimInstanceUpdateState_Internal(base.NativePtr);
		}

		// Token: 0x0600FB68 RID: 64360 RVA: 0x00173EFB File Offset: 0x001720FB
		public UAnimInstance GetAnimInstance()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimInstance>(USkeletalMeshComponent.__GetAnimInstance_Internal(base.NativePtr));
		}

		// Token: 0x0600FB69 RID: 64361 RVA: 0x00173F0D File Offset: 0x0017210D
		public UClassStackOnlyPtr GetAnimClass()
		{
			return USkeletalMeshComponent.__GetAnimClass_Internal(base.NativePtr);
		}

		// Token: 0x0600FB6A RID: 64362 RVA: 0x00173F1F File Offset: 0x0017211F
		[NullableContext(0)]
		public TEnumAsByte<EAnimationMode> GetAnimationMode()
		{
			return USkeletalMeshComponent.__GetAnimationMode_Internal(base.NativePtr);
		}

		// Token: 0x0600FB6B RID: 64363 RVA: 0x00173F2C File Offset: 0x0017212C
		public bool GetAllowRigidBodyAnimNode()
		{
			return USkeletalMeshComponent.__GetAllowRigidBodyAnimNode_Internal(base.NativePtr);
		}

		// Token: 0x0600FB6C RID: 64364 RVA: 0x00173F39 File Offset: 0x00172139
		public bool GetAllowedAnimCurveEvaluate()
		{
			return USkeletalMeshComponent.__GetAllowedAnimCurveEvaluate_Internal(base.NativePtr);
		}

		// Token: 0x0600FB6D RID: 64365 RVA: 0x00173F46 File Offset: 0x00172146
		public void ForceUpdateAnimation(float DeltaTime, bool bNeedsValidRootMotion)
		{
			USkeletalMeshComponent.__ForceUpdateAnimation_Internal(base.NativePtr, DeltaTime, bNeedsValidRootMotion);
		}

		// Token: 0x0600FB6E RID: 64366 RVA: 0x00173F55 File Offset: 0x00172155
		public void ForceClothNextUpdateTeleportAndReset()
		{
			USkeletalMeshComponent.__ForceClothNextUpdateTeleportAndReset_Internal(base.NativePtr);
		}

		// Token: 0x0600FB6F RID: 64367 RVA: 0x00173F62 File Offset: 0x00172162
		public void ForceClothNextUpdateTeleport()
		{
			USkeletalMeshComponent.__ForceClothNextUpdateTeleport_Internal(base.NativePtr);
		}

		// Token: 0x0600FB70 RID: 64368 RVA: 0x00173F6F File Offset: 0x0017216F
		public FName FindConstraintBoneName(int ConstraintIndex)
		{
			return USkeletalMeshComponent.__FindConstraintBoneName_Internal(base.NativePtr, ConstraintIndex);
		}

		// Token: 0x0600FB71 RID: 64369 RVA: 0x00173F7D File Offset: 0x0017217D
		public void EnableTickGetHeadBonePos(bool Enable)
		{
			USkeletalMeshComponent.__EnableTickGetHeadBonePos_Internal(base.NativePtr, Enable);
		}

		// Token: 0x0600FB72 RID: 64370 RVA: 0x00173F8B File Offset: 0x0017218B
		public bool DisableWaterForToon()
		{
			return USkeletalMeshComponent.__DisableWaterForToon_Internal(base.NativePtr);
		}

		// Token: 0x0600FB73 RID: 64371 RVA: 0x00173F98 File Offset: 0x00172198
		public void DestroyKuroClothSimulation()
		{
			USkeletalMeshComponent.__DestroyKuroClothSimulation_Internal(base.NativePtr);
		}

		// Token: 0x0600FB74 RID: 64372 RVA: 0x00173FA5 File Offset: 0x001721A5
		public void DealCompleteParallelEvaluation()
		{
			USkeletalMeshComponent.__DealCompleteParallelEvaluation_Internal(base.NativePtr);
		}

		// Token: 0x0600FB75 RID: 64373 RVA: 0x00173FB2 File Offset: 0x001721B2
		public void CreateKuroClothSimulation()
		{
			USkeletalMeshComponent.__CreateKuroClothSimulation_Internal(base.NativePtr);
		}

		// Token: 0x0600FB76 RID: 64374 RVA: 0x00173FBF File Offset: 0x001721BF
		public void ClearMorphTargets()
		{
			USkeletalMeshComponent.__ClearMorphTargets_Internal(base.NativePtr);
		}

		// Token: 0x0600FB77 RID: 64375 RVA: 0x00173FCC File Offset: 0x001721CC
		public void BreakConstraint(FVector Impulse, FVector HitLocation, FName InBoneName)
		{
			USkeletalMeshComponent.__BreakConstraint_Internal(base.NativePtr, Impulse, HitLocation, InBoneName);
		}

		// Token: 0x0600FB78 RID: 64376 RVA: 0x00173FDC File Offset: 0x001721DC
		public void BindClothToMasterPoseComponent()
		{
			USkeletalMeshComponent.__BindClothToMasterPoseComponent_Internal(base.NativePtr);
		}

		// Token: 0x0600FB79 RID: 64377 RVA: 0x00173FE9 File Offset: 0x001721E9
		public bool AnimPoseTickedThisFrame()
		{
			return USkeletalMeshComponent.__AnimPoseTickedThisFrame_Internal(base.NativePtr);
		}

		// Token: 0x0600FB7A RID: 64378 RVA: 0x00173FF6 File Offset: 0x001721F6
		public void AllowAnimCurveEvaluation(FName NameOfCurve, bool bAllow)
		{
			USkeletalMeshComponent.__AllowAnimCurveEvaluation_Internal(base.NativePtr, NameOfCurve, bAllow);
		}

		// Token: 0x0600FB7B RID: 64379 RVA: 0x00174005 File Offset: 0x00172205
		public void AddKuroCloth(UKCClothAssetBase ClothAsset)
		{
			USkeletalMeshComponent.__AddKuroCloth_Internal(base.NativePtr, (ClothAsset != null) ? ClothAsset.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600FB7C RID: 64380 RVA: 0x00174022 File Offset: 0x00172222
		public void AddImpulseToAllBodiesBelow(FVector Impulse, FName BoneName = default(FName), bool bVelChange = false, bool bIncludeSelf = true)
		{
			USkeletalMeshComponent.__AddImpulseToAllBodiesBelow_Internal(base.NativePtr, Impulse, BoneName, bVelChange, bIncludeSelf);
		}

		// Token: 0x0600FB7D RID: 64381 RVA: 0x00174034 File Offset: 0x00172234
		public void AddForceToAllBodiesBelow(FVector Force, FName BoneName = default(FName), bool bAccelChange = false, bool bIncludeSelf = true)
		{
			USkeletalMeshComponent.__AddForceToAllBodiesBelow_Internal(base.NativePtr, Force, BoneName, bAccelChange, bIncludeSelf);
		}

		// Token: 0x0600FB7E RID: 64382 RVA: 0x00174048 File Offset: 0x00172248
		public unsafe void AccumulateAllBodiesBelowPhysicsBlendWeight(in FName InBoneName, float AddPhysicsBlendWeight, bool bSkipCustomPhysicsType = false)
		{
			fixed (FName* ptr = &InBoneName)
			{
				void* ptr2 = (void*)ptr;
				USkeletalMeshComponent.__AccumulateAllBodiesBelowPhysicsBlendWeight_Internal(base.NativePtr, InBoneName, AddPhysicsBlendWeight, bSkipCustomPhysicsType);
			}
		}

		// Token: 0x0600FB7F RID: 64383
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateLODStatus_Outside_Internal(IntPtr @this);

		// Token: 0x0600FB80 RID: 64384
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnlockKuroEvaluation_Internal(IntPtr @this);

		// Token: 0x0600FB81 RID: 64385
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnlinkAnimClassLayers_Internal(IntPtr @this, IntPtr InClass);

		// Token: 0x0600FB82 RID: 64386
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnbindClothFromMasterPoseComponent_Internal(IntPtr @this, bool bRestoreSimulationSpace);

		// Token: 0x0600FB83 RID: 64387
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ToggleDisablePostProcessBlueprint_Internal(IntPtr @this);

		// Token: 0x0600FB84 RID: 64388
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __TickSoftAssetLoading_Internal(IntPtr @this);

		// Token: 0x0600FB85 RID: 64389
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __TestGetBoneSpaceTransforms_Internal(IntPtr @this);

		// Token: 0x0600FB86 RID: 64390
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __TermBodiesBelow_Internal(IntPtr @this, FName ParentBoneName);

		// Token: 0x0600FB87 RID: 64391
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SuspendClothingSimulation_Internal(IntPtr @this);

		// Token: 0x0600FB88 RID: 64392
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Stop_Internal(IntPtr @this);

		// Token: 0x0600FB89 RID: 64393
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SnapshotPose_Internal(IntPtr @this, IntPtr Snapshot);

		// Token: 0x0600FB8A RID: 64394
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUseProxyDataBuffer_Internal(IntPtr @this, bool Use);

		// Token: 0x0600FB8B RID: 64395
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUpdateClothInEditor_Internal(IntPtr @this, bool NewUpdateState);

		// Token: 0x0600FB8C RID: 64396
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUpdateAnimationInEditor_Internal(IntPtr @this, bool NewUpdateState);

		// Token: 0x0600FB8D RID: 64397
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTeleportRotationThreshold_Internal(IntPtr @this, float Threshold);

		// Token: 0x0600FB8E RID: 64398
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTeleportDistanceThreshold_Internal(IntPtr @this, float Threshold);

		// Token: 0x0600FB8F RID: 64399
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSkeletalMeshScreenSizeCullRatio_Internal(IntPtr @this, float Value);

		// Token: 0x0600FB90 RID: 64400
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRenderInKuroXRayPass_Internal(IntPtr @this, bool bValue);

		// Token: 0x0600FB91 RID: 64401
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPosition_Internal(IntPtr @this, float InPos, bool bFireNotifies);

		// Token: 0x0600FB92 RID: 64402
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPlayRate_Internal(IntPtr @this, float Rate);

		// Token: 0x0600FB93 RID: 64403
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPhysicsBlendWeight_Internal(IntPtr @this, float PhysicsBlendWeight);

		// Token: 0x0600FB94 RID: 64404
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNotifyRigidBodyCollisionBelow_Internal(IntPtr @this, bool bNewNotifyRigidBodyCollision, FName BoneName, bool bIncludeSelf);

		// Token: 0x0600FB95 RID: 64405
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMorphTarget_Internal(IntPtr @this, FName MorphTargetName, float Value, bool bRemoveZeroWeight);

		// Token: 0x0600FB96 RID: 64406
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroXRayPenetrateCharacters_Internal(IntPtr @this, bool bValue);

		// Token: 0x0600FB97 RID: 64407
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroXRayOutlineWidth_Internal(IntPtr @this, float InWidth);

		// Token: 0x0600FB98 RID: 64408
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroXRayOutlineMaterial_Internal(IntPtr @this, IntPtr InMaterial);

		// Token: 0x0600FB99 RID: 64409
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroXRayMaterial_Internal(IntPtr @this, IntPtr InMaterial);

		// Token: 0x0600FB9A RID: 64410
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroXRayDistance_Internal(IntPtr @this, float InDistance);

		// Token: 0x0600FB9B RID: 64411
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroXRayColor_Internal(IntPtr @this, FLinearColor InKuroXRayColor);

		// Token: 0x0600FB9C RID: 64412
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroSkipAnimNotifies_Internal(IntPtr @this, bool bInSkip);

		// Token: 0x0600FB9D RID: 64413
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetForceDisableBoneBounds_Internal(IntPtr @this, bool InForceDisableBoneBounds);

		// Token: 0x0600FB9E RID: 64414
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEnablePhysicsBlending_Internal(IntPtr @this, bool bNewBlendPhysics);

		// Token: 0x0600FB9F RID: 64415
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEnableOverrideSkeletalMeshScreenSizeCullRatio_Internal(IntPtr @this, bool bValue);

		// Token: 0x0600FBA0 RID: 64416
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEnableGravityOnAllBodiesBelow_Internal(IntPtr @this, bool bEnableGravity, FName BoneName, bool bIncludeSelf);

		// Token: 0x0600FBA1 RID: 64417
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEnableBodyGravity_Internal(IntPtr @this, bool bEnableGravity, FName BoneName);

		// Token: 0x0600FBA2 RID: 64418
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDynamicMaterialScalarParameterValue_Internal(IntPtr @this, int InMatIndex, in FName InParamName, float InValue);

		// Token: 0x0600FBA3 RID: 64419
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDisableWaterForToon_Internal(IntPtr @this, bool bValue);

		// Token: 0x0600FBA4 RID: 64420
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDisablePostProcessBlueprint_Internal(IntPtr @this, bool bInDisablePostProcess);

		// Token: 0x0600FBA5 RID: 64421
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDisableAnimCurves_Internal(IntPtr @this, bool bInDisableAnimCurves);

		// Token: 0x0600FBA6 RID: 64422
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDelayCompleteParallelEvaluation_Internal(IntPtr @this);

		// Token: 0x0600FBA7 RID: 64423
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetConstraintProfileForAll_Internal(IntPtr @this, FName ProfileName, bool bDefaultIfNotFound);

		// Token: 0x0600FBA8 RID: 64424
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetConstraintProfile_Internal(IntPtr @this, FName JointName, FName ProfileName, bool bDefaultIfNotFound);

		// Token: 0x0600FBA9 RID: 64425
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetClothMaxDistanceScale_Internal(IntPtr @this, float Scale);

		// Token: 0x0600FBAA RID: 64426
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBodyNotifyRigidBodyCollision_Internal(IntPtr @this, bool bNewNotifyRigidBodyCollision, FName BoneName);

		// Token: 0x0600FBAB RID: 64427
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAnimClass_Internal(IntPtr @this, IntPtr NewClass);

		// Token: 0x0600FBAC RID: 64428
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAnimationRibbonAsset_Internal(IntPtr @this, IntPtr NewRibbonAsset);

		// Token: 0x0600FBAD RID: 64429
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAnimationMode_Internal(IntPtr @this, TEnumAsByte<EAnimationMode> InAnimationMode);

		// Token: 0x0600FBAE RID: 64430
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAnimation_Internal(IntPtr @this, IntPtr NewAnimToPlay);

		// Token: 0x0600FBAF RID: 64431
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAngularLimits_Internal(IntPtr @this, FName InBoneName, float Swing1LimitAngle, float TwistLimitAngle, float Swing2LimitAngle);

		// Token: 0x0600FBB0 RID: 64432
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAllowRigidBodyAnimNode_Internal(IntPtr @this, bool bInAllow, bool bReinitAnim);

		// Token: 0x0600FBB1 RID: 64433
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAllowedAnimCurvesEvaluation_Internal(IntPtr @this, IntPtr List, bool bAllow);

		// Token: 0x0600FBB2 RID: 64434
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAllowAnimCurveEvaluation_Internal(IntPtr @this, bool bInAllow);

		// Token: 0x0600FBB3 RID: 64435
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAllMotorsAngularVelocityDrive_Internal(IntPtr @this, bool bEnableSwingDrive, bool bEnableTwistDrive, bool bSkipCustomPhysicsType);

		// Token: 0x0600FBB4 RID: 64436
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAllMotorsAngularPositionDrive_Internal(IntPtr @this, bool bEnableSwingDrive, bool bEnableTwistDrive, bool bSkipCustomPhysicsType);

		// Token: 0x0600FBB5 RID: 64437
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAllMotorsAngularDriveParams_Internal(IntPtr @this, float InSpring, float InDamping, float InForceLimit, bool bSkipCustomPhysicsType);

		// Token: 0x0600FBB6 RID: 64438
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAllBodiesSimulatePhysics_Internal(IntPtr @this, bool bNewSimulate);

		// Token: 0x0600FBB7 RID: 64439
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAllBodiesPhysicsBlendWeight_Internal(IntPtr @this, float PhysicsBlendWeight, bool bSkipCustomPhysicsType);

		// Token: 0x0600FBB8 RID: 64440
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAllBodiesBelowSimulatePhysics_Internal(IntPtr @this, in FName InBoneName, bool bNewSimulate, bool bIncludeSelf);

		// Token: 0x0600FBB9 RID: 64441
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAllBodiesBelowPhysicsBlendWeight_Internal(IntPtr @this, in FName InBoneName, float PhysicsBlendWeight, bool bSkipCustomPhysicsType, bool bIncludeSelf);

		// Token: 0x0600FBBA RID: 64442
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResumeClothingSimulation_Internal(IntPtr @this);

		// Token: 0x0600FBBB RID: 64443
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetEvaluationDebugStatistics_Internal(IntPtr @this);

		// Token: 0x0600FBBC RID: 64444
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetClothTeleportMode_Internal(IntPtr @this);

		// Token: 0x0600FBBD RID: 64445
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetAnimInstanceDynamics_Internal(IntPtr @this, ETeleportType InTeleportType);

		// Token: 0x0600FBBE RID: 64446
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetAllowedAnimCurveEvaluation_Internal(IntPtr @this);

		// Token: 0x0600FBBF RID: 64447
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetAllBodiesSimulatePhysics_Internal(IntPtr @this);

		// Token: 0x0600FBC0 RID: 64448
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveKuroCloth_Internal(IntPtr @this, IntPtr ClothAsset);

		// Token: 0x0600FBC1 RID: 64449
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RegisterKuroCharPostUpdateTickFun_Internal(IntPtr @this, bool bRegister);

		// Token: 0x0600FBC2 RID: 64450
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RecreateKuroCloth_Internal(IntPtr @this);

		// Token: 0x0600FBC3 RID: 64451
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PlayAnimation_Internal(IntPtr @this, IntPtr NewAnimToPlay, bool bLooping);

		// Token: 0x0600FBC4 RID: 64452
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Play_Internal(IntPtr @this, bool bLooping);

		// Token: 0x0600FBC5 RID: 64453
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OverrideAnimationData_Internal(IntPtr @this, IntPtr InAnimToPlay, bool bIsLooping, bool bIsPlaying, float Position, float PlayRate);

		// Token: 0x0600FBC6 RID: 64454
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LinkAnimGraphByTag_Internal(IntPtr @this, FName InTag, IntPtr InClass);

		// Token: 0x0600FBC7 RID: 64455
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LinkAnimClassLayers_Internal(IntPtr @this, IntPtr InClass);

		// Token: 0x0600FBC8 RID: 64456
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Kuro_UpdateRootMotionParams_Internal(IntPtr @this);

		// Token: 0x0600FBC9 RID: 64457
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_GetClosestPointOnPhysicsAsset_Internal(IntPtr @this, in FVector WorldPosition, ref FVector ClosestWorldPosition, ref FVector Normal, ref FName BoneName, ref float Distance);

		// Token: 0x0600FBCA RID: 64458
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsPlaying_Internal(IntPtr @this);

		// Token: 0x0600FBCB RID: 64459
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsClothingSimulationSuspended_Internal(IntPtr @this);

		// Token: 0x0600FBCC RID: 64460
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsBodyGravityEnabled_Internal(IntPtr @this, FName BoneName);

		// Token: 0x0600FBCD RID: 64461
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasValidAnimationInstance_Internal(IntPtr @this);

		// Token: 0x0600FBCE RID: 64462
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetTeleportRotationThreshold_Internal(IntPtr @this);

		// Token: 0x0600FBCF RID: 64463
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetTeleportDistanceThreshold_Internal(IntPtr @this);

		// Token: 0x0600FBD0 RID: 64464
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetStringAttribute_Ref_Internal(IntPtr @this, in FName BoneName, in FName AttributeName, ref FString OutValue, ECustomBoneAttributeLookup LookupType);

		// Token: 0x0600FBD1 RID: 64465
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetStringAttribute_Internal(IntPtr @this, in FName BoneName, in FName AttributeName, in FString DefaultValue, ref FString OutValue, ECustomBoneAttributeLookup LookupType);

		// Token: 0x0600FBD2 RID: 64466
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetSkeletalMeshScreenSizeCullRatio_Internal(IntPtr @this);

		// Token: 0x0600FBD3 RID: 64467
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetSkeletalCenterOfMass_Internal(IntPtr @this);

		// Token: 0x0600FBD4 RID: 64468
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetRenderInKuroXRayPass_Internal(IntPtr @this);

		// Token: 0x0600FBD5 RID: 64469
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __GetRefBoneWorldPosition_Internal(IntPtr @this, FName BoneName);

		// Token: 0x0600FBD6 RID: 64470
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __GetRefBoneComponentPosition_Internal(IntPtr @this, FName BoneName);

		// Token: 0x0600FBD7 RID: 64471
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetPostProcessInstance_Internal(IntPtr @this);

		// Token: 0x0600FBD8 RID: 64472
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetPosition_Internal(IntPtr @this);

		// Token: 0x0600FBD9 RID: 64473
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetPlayRate_Internal(IntPtr @this);

		// Token: 0x0600FBDA RID: 64474
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetMorphTargetNames_Internal(IntPtr @this);

		// Token: 0x0600FBDB RID: 64475
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetMorphTarget_Internal(IntPtr @this, FName MorphTargetName);

		// Token: 0x0600FBDC RID: 64476
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetLinkedAnimLayerInstanceByGroup_Internal(IntPtr @this, FName InGroup);

		// Token: 0x0600FBDD RID: 64477
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetLinkedAnimLayerInstanceByClass_Internal(IntPtr @this, IntPtr InClass);

		// Token: 0x0600FBDE RID: 64478
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetLinkedAnimGraphInstancesByTag_Internal(IntPtr @this, FName InTag, IntPtr OutLinkedInstances);

		// Token: 0x0600FBDF RID: 64479
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetLinkedAnimGraphInstanceByTag_Internal(IntPtr @this, FName InTag);

		// Token: 0x0600FBE0 RID: 64480
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetKuroXRayPenetrateCharacters_Internal(IntPtr @this);

		// Token: 0x0600FBE1 RID: 64481
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetKuroXRayOutlineWidth_Internal(IntPtr @this);

		// Token: 0x0600FBE2 RID: 64482
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetKuroXRayOutlineMaterial_Internal(IntPtr @this);

		// Token: 0x0600FBE3 RID: 64483
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetKuroXRayMaterial_Internal(IntPtr @this);

		// Token: 0x0600FBE4 RID: 64484
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetKuroXRayDistance_Internal(IntPtr @this);

		// Token: 0x0600FBE5 RID: 64485
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector4 __GetKuroXRayColor_Internal(IntPtr @this);

		// Token: 0x0600FBE6 RID: 64486
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetKuroSkipAnimNotifies_Internal(IntPtr @this);

		// Token: 0x0600FBE7 RID: 64487
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetIntegerAttribute_Ref_Internal(IntPtr @this, in FName BoneName, in FName AttributeName, ref int OutValue, ECustomBoneAttributeLookup LookupType);

		// Token: 0x0600FBE8 RID: 64488
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetIntegerAttribute_Internal(IntPtr @this, in FName BoneName, in FName AttributeName, int DefaultValue, ref int OutValue, ECustomBoneAttributeLookup LookupType);

		// Token: 0x0600FBE9 RID: 64489
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetFloatAttribute_Ref_Internal(IntPtr @this, in FName BoneName, in FName AttributeName, ref float OutValue, ECustomBoneAttributeLookup LookupType);

		// Token: 0x0600FBEA RID: 64490
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetFloatAttribute_Internal(IntPtr @this, in FName BoneName, in FName AttributeName, float DefaultValue, ref float OutValue, ECustomBoneAttributeLookup LookupType);

		// Token: 0x0600FBEB RID: 64491
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetEnableOverrideSkeletalMeshScreenSizeCullRatio_Internal(IntPtr @this);

		// Token: 0x0600FBEC RID: 64492
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetDisablePostProcessBlueprint_Internal(IntPtr @this);

		// Token: 0x0600FBED RID: 64493
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetDisableAnimCurves_Internal(IntPtr @this);

		// Token: 0x0600FBEE RID: 64494
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetCurrentJointAngles_Internal(IntPtr @this, FName InBoneName, ref float Swing1Angle, ref float TwistAngle, ref float Swing2Angle);

		// Token: 0x0600FBEF RID: 64495
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetClothMaxDistanceScale_Internal(IntPtr @this);

		// Token: 0x0600FBF0 RID: 64496
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetClothingSimulationInteractor_Internal(IntPtr @this);

		// Token: 0x0600FBF1 RID: 64497
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetBoneMass_Internal(IntPtr @this, FName BoneName, bool bScaleMass);

		// Token: 0x0600FBF2 RID: 64498
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern byte __GetAnimInstanceUpdateState_Internal(IntPtr @this);

		// Token: 0x0600FBF3 RID: 64499
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAnimInstance_Internal(IntPtr @this);

		// Token: 0x0600FBF4 RID: 64500
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAnimClass_Internal(IntPtr @this);

		// Token: 0x0600FBF5 RID: 64501
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern TEnumAsByte<EAnimationMode> __GetAnimationMode_Internal(IntPtr @this);

		// Token: 0x0600FBF6 RID: 64502
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetAllowRigidBodyAnimNode_Internal(IntPtr @this);

		// Token: 0x0600FBF7 RID: 64503
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetAllowedAnimCurveEvaluate_Internal(IntPtr @this);

		// Token: 0x0600FBF8 RID: 64504
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ForceUpdateAnimation_Internal(IntPtr @this, float DeltaTime, bool bNeedsValidRootMotion);

		// Token: 0x0600FBF9 RID: 64505
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ForceClothNextUpdateTeleportAndReset_Internal(IntPtr @this);

		// Token: 0x0600FBFA RID: 64506
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ForceClothNextUpdateTeleport_Internal(IntPtr @this);

		// Token: 0x0600FBFB RID: 64507
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FName __FindConstraintBoneName_Internal(IntPtr @this, int ConstraintIndex);

		// Token: 0x0600FBFC RID: 64508
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EnableTickGetHeadBonePos_Internal(IntPtr @this, bool Enable);

		// Token: 0x0600FBFD RID: 64509
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __DisableWaterForToon_Internal(IntPtr @this);

		// Token: 0x0600FBFE RID: 64510
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DestroyKuroClothSimulation_Internal(IntPtr @this);

		// Token: 0x0600FBFF RID: 64511
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DealCompleteParallelEvaluation_Internal(IntPtr @this);

		// Token: 0x0600FC00 RID: 64512
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CreateKuroClothSimulation_Internal(IntPtr @this);

		// Token: 0x0600FC01 RID: 64513
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearMorphTargets_Internal(IntPtr @this);

		// Token: 0x0600FC02 RID: 64514
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BreakConstraint_Internal(IntPtr @this, FVector Impulse, FVector HitLocation, FName InBoneName);

		// Token: 0x0600FC03 RID: 64515
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BindClothToMasterPoseComponent_Internal(IntPtr @this);

		// Token: 0x0600FC04 RID: 64516
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __AnimPoseTickedThisFrame_Internal(IntPtr @this);

		// Token: 0x0600FC05 RID: 64517
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AllowAnimCurveEvaluation_Internal(IntPtr @this, FName NameOfCurve, bool bAllow);

		// Token: 0x0600FC06 RID: 64518
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddKuroCloth_Internal(IntPtr @this, IntPtr ClothAsset);

		// Token: 0x0600FC07 RID: 64519
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddImpulseToAllBodiesBelow_Internal(IntPtr @this, FVector Impulse, FName BoneName, bool bVelChange, bool bIncludeSelf);

		// Token: 0x0600FC08 RID: 64520
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddForceToAllBodiesBelow_Internal(IntPtr @this, FVector Force, FName BoneName, bool bAccelChange, bool bIncludeSelf);

		// Token: 0x0600FC09 RID: 64521
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AccumulateAllBodiesBelowPhysicsBlendWeight_Internal(IntPtr @this, in FName InBoneName, float AddPhysicsBlendWeight, bool bSkipCustomPhysicsType);

		// Token: 0x0600FC0A RID: 64522 RVA: 0x0017406B File Offset: 0x0017226B
		static USkeletalMeshComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SkeletalMeshComponent");
		}

		// Token: 0x0600FC0B RID: 64523 RVA: 0x00174079 File Offset: 0x00172279
		protected USkeletalMeshComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040086FA RID: 34554
		internal static int __InterfaceOffset_IInterface_CollisionDataProvider;

		// Token: 0x040086FB RID: 34555
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.SkeletalMeshComponent";

		// Token: 0x040086FC RID: 34556
		private static IntPtr _ClassPtr;

		// Token: 0x040086FD RID: 34557
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040086FE RID: 34558
		internal static int __PropertyOffset_AnimBlueprintGeneratedClass;

		// Token: 0x040086FF RID: 34559
		internal static int __PropertyOffset_AnimClass;

		// Token: 0x04008700 RID: 34560
		internal static int __PropertyOffset_AnimScriptInstance;

		// Token: 0x04008701 RID: 34561
		internal static int __PropertyOffset_PostProcessAnimInstance;

		// Token: 0x04008702 RID: 34562
		internal static int __PropertyOffset_KuroPostProcessAnimBlueprint;

		// Token: 0x04008703 RID: 34563
		internal static int __PropertyOffset_PredictionAnimInstance;

		// Token: 0x04008704 RID: 34564
		internal static int __PropertyOffset_AnimationData;

		// Token: 0x04008705 RID: 34565
		private FSingleAnimationPlayData _AnimationData;

		// Token: 0x04008706 RID: 34566
		internal static int __PropertyOffset_bKuroForceShears;

		// Token: 0x04008707 RID: 34567
		internal static int __PropertyOffset_RootBoneTranslation;

		// Token: 0x04008708 RID: 34568
		internal static int __PropertyOffset_LineCheckBoundsScale;

		// Token: 0x04008709 RID: 34569
		internal static int __PropertyOffset_bRenderInKuroXRayPass;

		// Token: 0x0400870A RID: 34570
		internal static byte __PropertyMask_bRenderInKuroXRayPass;

		// Token: 0x0400870B RID: 34571
		internal static int __PropertyOffset_KuroXRayColor;

		// Token: 0x0400870C RID: 34572
		internal static int __PropertyOffset_KuroXRayMaterial;

		// Token: 0x0400870D RID: 34573
		internal static int __PropertyOffset_KuroXRayOutlineMaterial;

		// Token: 0x0400870E RID: 34574
		internal static int __PropertyOffset_KuroXRayDistance;

		// Token: 0x0400870F RID: 34575
		internal static int __PropertyOffset_KuroXRayOutlineWidth;

		// Token: 0x04008710 RID: 34576
		internal static int __PropertyOffset_bKuroXRayPenetrateCharacters;

		// Token: 0x04008711 RID: 34577
		internal static byte __PropertyMask_bKuroXRayPenetrateCharacters;

		// Token: 0x04008712 RID: 34578
		internal static int __PropertyOffset_bKuroXRayPenetrateCharactersFromDA;

		// Token: 0x04008713 RID: 34579
		internal static byte __PropertyMask_bKuroXRayPenetrateCharactersFromDA;

		// Token: 0x04008714 RID: 34580
		internal static int __PropertyOffset_bKuroXRayPenetrateCharactersFromDAValid;

		// Token: 0x04008715 RID: 34581
		internal static byte __PropertyMask_bKuroXRayPenetrateCharactersFromDAValid;

		// Token: 0x04008716 RID: 34582
		internal static int __PropertyOffset_KuroMaterialControllerUpdateGroupMode;

		// Token: 0x04008717 RID: 34583
		internal static int __PropertyOffset_KuroMaterialControllerCustomUpdateGroup;

		// Token: 0x04008718 RID: 34584
		internal static int __PropertyOffset_bDisableWaterForToon;

		// Token: 0x04008719 RID: 34585
		internal static byte __PropertyMask_bDisableWaterForToon;

		// Token: 0x0400871A RID: 34586
		internal static int __PropertyOffset_bOverrideSkeletalMeshScreenSizeCullRatio;

		// Token: 0x0400871B RID: 34587
		internal static byte __PropertyMask_bOverrideSkeletalMeshScreenSizeCullRatio;

		// Token: 0x0400871C RID: 34588
		internal static int __PropertyOffset_SkeletalMeshScreenSizeCullRatio;

		// Token: 0x0400871D RID: 34589
		internal static int __PropertyOffset_KuroAnimInstanceLod;

		// Token: 0x0400871E RID: 34590
		internal static int __PropertyOffset_KuroLodMask;

		// Token: 0x0400871F RID: 34591
		internal static int __PropertyOffset_KuroClothWind;

		// Token: 0x04008720 RID: 34592
		internal static int __PropertyOffset_KuroClothCapsuleHalfHeightOffset;

		// Token: 0x04008721 RID: 34593
		internal static int __PropertyOffset_KuroClothCapsuleRadiusOffset;

		// Token: 0x04008722 RID: 34594
		internal static int __PropertyOffset_SelfAggGeom;

		// Token: 0x04008723 RID: 34595
		private FKAggregateGeom _SelfAggGeom;

		// Token: 0x04008724 RID: 34596
		internal static int __PropertyOffset_bKuroSkipAnimNotifies;

		// Token: 0x04008725 RID: 34597
		internal static byte __PropertyMask_bKuroSkipAnimNotifies;

		// Token: 0x04008726 RID: 34598
		internal static int __PropertyOffset_LinkedInstances;

		// Token: 0x04008727 RID: 34599
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UAnimInstance> _LinkedInstances;

		// Token: 0x04008728 RID: 34600
		internal static int __PropertyOffset_CachedBoneSpaceTransforms;

		// Token: 0x04008729 RID: 34601
		private TArray<FTransform> _CachedBoneSpaceTransforms;

		// Token: 0x0400872A RID: 34602
		internal static int __PropertyOffset_CachedComponentSpaceTransforms;

		// Token: 0x0400872B RID: 34603
		private TArray<FTransform> _CachedComponentSpaceTransforms;

		// Token: 0x0400872C RID: 34604
		internal static int __PropertyOffset_BoneSpaceShears;

		// Token: 0x0400872D RID: 34605
		private TArray<FVector> _BoneSpaceShears;

		// Token: 0x0400872E RID: 34606
		internal static int __PropertyOffset_CachedBoneSpaceShears;

		// Token: 0x0400872F RID: 34607
		private TArray<FVector> _CachedBoneSpaceShears;

		// Token: 0x04008730 RID: 34608
		internal static int __PropertyOffset_CachedComponentSpaceShears;

		// Token: 0x04008731 RID: 34609
		private TArray<FVector> _CachedComponentSpaceShears;

		// Token: 0x04008732 RID: 34610
		internal static int __PropertyOffset_AnimInstanceCachePool;

		// Token: 0x04008733 RID: 34611
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<UClass, UAnimInstanceCache> _AnimInstanceCachePool;

		// Token: 0x04008734 RID: 34612
		internal static int __PropertyOffset_GlobalAnimRateScale;

		// Token: 0x04008735 RID: 34613
		internal static int __PropertyOffset_KinematicBonesUpdateType;

		// Token: 0x04008736 RID: 34614
		internal static int __PropertyOffset_PhysicsTransformUpdateMode;

		// Token: 0x04008737 RID: 34615
		internal static int __PropertyOffset_AnimationMode;

		// Token: 0x04008738 RID: 34616
		internal static int __PropertyOffset_bDisablePostProcessBlueprint;

		// Token: 0x04008739 RID: 34617
		internal static byte __PropertyMask_bDisablePostProcessBlueprint;

		// Token: 0x0400873A RID: 34618
		internal static int __PropertyOffset_bUpdateOverlapsOnAnimationFinalize;

		// Token: 0x0400873B RID: 34619
		internal static byte __PropertyMask_bUpdateOverlapsOnAnimationFinalize;

		// Token: 0x0400873C RID: 34620
		internal static int __PropertyOffset_bHasValidBodies;

		// Token: 0x0400873D RID: 34621
		internal static byte __PropertyMask_bHasValidBodies;

		// Token: 0x0400873E RID: 34622
		internal static int __PropertyOffset_bBlendPhysics;

		// Token: 0x0400873F RID: 34623
		internal static byte __PropertyMask_bBlendPhysics;

		// Token: 0x04008740 RID: 34624
		internal static int __PropertyOffset_bEnablePhysicsOnDedicatedServer;

		// Token: 0x04008741 RID: 34625
		internal static byte __PropertyMask_bEnablePhysicsOnDedicatedServer;

		// Token: 0x04008742 RID: 34626
		internal static int __PropertyOffset_bUpdateJointsFromAnimation;

		// Token: 0x04008743 RID: 34627
		internal static byte __PropertyMask_bUpdateJointsFromAnimation;

		// Token: 0x04008744 RID: 34628
		internal static int __PropertyOffset_bDisableClothSimulation;

		// Token: 0x04008745 RID: 34629
		internal static byte __PropertyMask_bDisableClothSimulation;

		// Token: 0x04008746 RID: 34630
		internal static int __PropertyOffset_bDisableRigidBodyAnimNode;

		// Token: 0x04008747 RID: 34631
		internal static byte __PropertyMask_bDisableRigidBodyAnimNode;

		// Token: 0x04008748 RID: 34632
		internal static int __PropertyOffset_bAllowAnimCurveEvaluation;

		// Token: 0x04008749 RID: 34633
		internal static byte __PropertyMask_bAllowAnimCurveEvaluation;

		// Token: 0x0400874A RID: 34634
		internal static int __PropertyOffset_bDisableAnimCurves_DEPRECATED;

		// Token: 0x0400874B RID: 34635
		internal static byte __PropertyMask_bDisableAnimCurves_DEPRECATED;

		// Token: 0x0400874C RID: 34636
		internal static int __PropertyOffset_bCollideWithEnvironment;

		// Token: 0x0400874D RID: 34637
		internal static byte __PropertyMask_bCollideWithEnvironment;

		// Token: 0x0400874E RID: 34638
		internal static int __PropertyOffset_bCollideWithAttachedChildren;

		// Token: 0x0400874F RID: 34639
		internal static byte __PropertyMask_bCollideWithAttachedChildren;

		// Token: 0x04008750 RID: 34640
		internal static int __PropertyOffset_bKuroStaticClothCollideWithEnvironment;

		// Token: 0x04008751 RID: 34641
		internal static byte __PropertyMask_bKuroStaticClothCollideWithEnvironment;

		// Token: 0x04008752 RID: 34642
		internal static int __PropertyOffset_bKuroSkeletalBodySetupsClothingSimulation;

		// Token: 0x04008753 RID: 34643
		internal static byte __PropertyMask_bKuroSkeletalBodySetupsClothingSimulation;

		// Token: 0x04008754 RID: 34644
		internal static int __PropertyOffset_bKuroSkeletalBodySetupsVelocityRadiusScale;

		// Token: 0x04008755 RID: 34645
		internal static int __PropertyOffset_bKuroClothUseOriginTangentToLocal;

		// Token: 0x04008756 RID: 34646
		internal static byte __PropertyMask_bKuroClothUseOriginTangentToLocal;

		// Token: 0x04008757 RID: 34647
		internal static int __PropertyOffset_bKuroBoundStopClothingSimulation;

		// Token: 0x04008758 RID: 34648
		internal static byte __PropertyMask_bKuroBoundStopClothingSimulation;

		// Token: 0x04008759 RID: 34649
		internal static int __PropertyOffset_bLocalSpaceSimulation;

		// Token: 0x0400875A RID: 34650
		internal static byte __PropertyMask_bLocalSpaceSimulation;

		// Token: 0x0400875B RID: 34651
		internal static int __PropertyOffset_bResetAfterTeleport;

		// Token: 0x0400875C RID: 34652
		internal static byte __PropertyMask_bResetAfterTeleport;

		// Token: 0x0400875D RID: 34653
		internal static int __PropertyOffset_bDeferKinematicBoneUpdate;

		// Token: 0x0400875E RID: 34654
		internal static byte __PropertyMask_bDeferKinematicBoneUpdate;

		// Token: 0x0400875F RID: 34655
		internal static int __PropertyOffset_bNoSkeletonUpdate;

		// Token: 0x04008760 RID: 34656
		internal static byte __PropertyMask_bNoSkeletonUpdate;

		// Token: 0x04008761 RID: 34657
		internal static int __PropertyOffset_bEnableShearAnim;

		// Token: 0x04008762 RID: 34658
		internal static byte __PropertyMask_bEnableShearAnim;

		// Token: 0x04008763 RID: 34659
		internal static int __PropertyOffset_bEnableAnimTexture;

		// Token: 0x04008764 RID: 34660
		internal static byte __PropertyMask_bEnableAnimTexture;

		// Token: 0x04008765 RID: 34661
		internal static int __PropertyOffset_bPauseAnims;

		// Token: 0x04008766 RID: 34662
		internal static byte __PropertyMask_bPauseAnims;

		// Token: 0x04008767 RID: 34663
		internal static int __PropertyOffset_bUseRefPoseOnInitAnim;

		// Token: 0x04008768 RID: 34664
		internal static byte __PropertyMask_bUseRefPoseOnInitAnim;

		// Token: 0x04008769 RID: 34665
		internal static int __PropertyOffset_bEnablePerPolyCollision;

		// Token: 0x0400876A RID: 34666
		internal static byte __PropertyMask_bEnablePerPolyCollision;

		// Token: 0x0400876B RID: 34667
		internal static int __PropertyOffset_bForceRefpose;

		// Token: 0x0400876C RID: 34668
		internal static byte __PropertyMask_bForceRefpose;

		// Token: 0x0400876D RID: 34669
		internal static int __PropertyOffset_bOnlyAllowAutonomousTickPose;

		// Token: 0x0400876E RID: 34670
		internal static byte __PropertyMask_bOnlyAllowAutonomousTickPose;

		// Token: 0x0400876F RID: 34671
		internal static int __PropertyOffset_bIsAutonomousTickPose;

		// Token: 0x04008770 RID: 34672
		internal static byte __PropertyMask_bIsAutonomousTickPose;

		// Token: 0x04008771 RID: 34673
		internal static int __PropertyOffset_bOldForceRefPose;

		// Token: 0x04008772 RID: 34674
		internal static byte __PropertyMask_bOldForceRefPose;

		// Token: 0x04008773 RID: 34675
		internal static int __PropertyOffset_bShowPrePhysBones;

		// Token: 0x04008774 RID: 34676
		internal static byte __PropertyMask_bShowPrePhysBones;

		// Token: 0x04008775 RID: 34677
		internal static int __PropertyOffset_bRequiredBonesUpToDate;

		// Token: 0x04008776 RID: 34678
		internal static byte __PropertyMask_bRequiredBonesUpToDate;

		// Token: 0x04008777 RID: 34679
		internal static int __PropertyOffset_bAnimTreeInitialised;

		// Token: 0x04008778 RID: 34680
		internal static byte __PropertyMask_bAnimTreeInitialised;

		// Token: 0x04008779 RID: 34681
		internal static int __PropertyOffset_bIncludeComponentLocationIntoBounds;

		// Token: 0x0400877A RID: 34682
		internal static byte __PropertyMask_bIncludeComponentLocationIntoBounds;

		// Token: 0x0400877B RID: 34683
		internal static int __PropertyOffset_bEnableLineCheckWithBounds;

		// Token: 0x0400877C RID: 34684
		internal static byte __PropertyMask_bEnableLineCheckWithBounds;

		// Token: 0x0400877D RID: 34685
		internal static int __PropertyOffset_bUseBendingElements_DEPRECATED;

		// Token: 0x0400877E RID: 34686
		internal static byte __PropertyMask_bUseBendingElements_DEPRECATED;

		// Token: 0x0400877F RID: 34687
		internal static int __PropertyOffset_bUseTetrahedralConstraints_DEPRECATED;

		// Token: 0x04008780 RID: 34688
		internal static byte __PropertyMask_bUseTetrahedralConstraints_DEPRECATED;

		// Token: 0x04008781 RID: 34689
		internal static int __PropertyOffset_bUseThinShellVolumeConstraints_DEPRECATED;

		// Token: 0x04008782 RID: 34690
		internal static byte __PropertyMask_bUseThinShellVolumeConstraints_DEPRECATED;

		// Token: 0x04008783 RID: 34691
		internal static int __PropertyOffset_bUseSelfCollisions_DEPRECATED;

		// Token: 0x04008784 RID: 34692
		internal static byte __PropertyMask_bUseSelfCollisions_DEPRECATED;

		// Token: 0x04008785 RID: 34693
		internal static int __PropertyOffset_bUseContinuousCollisionDetection_DEPRECATED;

		// Token: 0x04008786 RID: 34694
		internal static byte __PropertyMask_bUseContinuousCollisionDetection_DEPRECATED;

		// Token: 0x04008787 RID: 34695
		internal static int __PropertyOffset_bPropagateCurvesToSlaves;

		// Token: 0x04008788 RID: 34696
		internal static byte __PropertyMask_bPropagateCurvesToSlaves;

		// Token: 0x04008789 RID: 34697
		internal static int __PropertyOffset_bSkipKinematicUpdateWhenInterpolating;

		// Token: 0x0400878A RID: 34698
		internal static byte __PropertyMask_bSkipKinematicUpdateWhenInterpolating;

		// Token: 0x0400878B RID: 34699
		internal static int __PropertyOffset_bSkipBoundsUpdateWhenInterpolating;

		// Token: 0x0400878C RID: 34700
		internal static byte __PropertyMask_bSkipBoundsUpdateWhenInterpolating;

		// Token: 0x0400878D RID: 34701
		internal static int __PropertyOffset_bMaybeShearingPose;

		// Token: 0x0400878E RID: 34702
		internal static byte __PropertyMask_bMaybeShearingPose;

		// Token: 0x0400878F RID: 34703
		internal static int __PropertyOffset_bNeedsQueuedAnimEventsDispatched;

		// Token: 0x04008790 RID: 34704
		internal static byte __PropertyMask_bNeedsQueuedAnimEventsDispatched;

		// Token: 0x04008791 RID: 34705
		internal static int __PropertyOffset_CachedAnimCurveUidVersion;

		// Token: 0x04008792 RID: 34706
		internal static int __PropertyOffset_MassMode_DEPRECATED;

		// Token: 0x04008793 RID: 34707
		internal static int __PropertyOffset_UniformMass_DEPRECATED;

		// Token: 0x04008794 RID: 34708
		internal static int __PropertyOffset_TotalMass_DEPRECATED;

		// Token: 0x04008795 RID: 34709
		internal static int __PropertyOffset_Density_DEPRECATED;

		// Token: 0x04008796 RID: 34710
		internal static int __PropertyOffset_MinPerParticleMass_DEPRECATED;

		// Token: 0x04008797 RID: 34711
		internal static int __PropertyOffset_ClothBlendWeight;

		// Token: 0x04008798 RID: 34712
		internal static int __PropertyOffset_EdgeStiffness_DEPRECATED;

		// Token: 0x04008799 RID: 34713
		internal static int __PropertyOffset_BendingStiffness_DEPRECATED;

		// Token: 0x0400879A RID: 34714
		internal static int __PropertyOffset_AreaStiffness_DEPRECATED;

		// Token: 0x0400879B RID: 34715
		internal static int __PropertyOffset_VolumeStiffness_DEPRECATED;

		// Token: 0x0400879C RID: 34716
		internal static int __PropertyOffset_StrainLimitingStiffness_DEPRECATED;

		// Token: 0x0400879D RID: 34717
		internal static int __PropertyOffset_ShapeTargetStiffness_DEPRECATED;

		// Token: 0x0400879E RID: 34718
		internal static int __PropertyOffset_bWaitForParallelClothTask;

		// Token: 0x0400879F RID: 34719
		internal static int __PropertyOffset_bUseRegionalSlaveBoneBounds;

		// Token: 0x040087A0 RID: 34720
		internal static int __PropertyOffset_bUseCustomSlaveBoneBounds;

		// Token: 0x040087A1 RID: 34721
		internal static int __PropertyOffset_CustomSlaveBoneBoundsConcernedBones;

		// Token: 0x040087A2 RID: 34722
		private TArray<FName> _CustomSlaveBoneBoundsConcernedBones;

		// Token: 0x040087A3 RID: 34723
		internal static int __PropertyOffset_CustomSlaveBoneBoundsExtension;

		// Token: 0x040087A4 RID: 34724
		internal static int __PropertyOffset_DisallowedAnimCurves;

		// Token: 0x040087A5 RID: 34725
		private TArray<FName> _DisallowedAnimCurves;

		// Token: 0x040087A6 RID: 34726
		internal static int __PropertyOffset_BodySetup;

		// Token: 0x040087A7 RID: 34727
		internal static int __PropertyOffset_OnConstraintBroken;

		// Token: 0x040087A8 RID: 34728
		private FConstraintBrokenSignature _OnConstraintBroken;

		// Token: 0x040087A9 RID: 34729
		internal static int __PropertyOffset_ClothingSimulationFactory;

		// Token: 0x040087AA RID: 34730
		internal static int __PropertyOffset_TeleportDistanceThreshold;

		// Token: 0x040087AB RID: 34731
		internal static int __PropertyOffset_TeleportRotationThreshold;

		// Token: 0x040087AC RID: 34732
		internal static int __PropertyOffset_LastPoseTickFrame;

		// Token: 0x040087AD RID: 34733
		internal static int __PropertyOffset_ClothingInteractor;

		// Token: 0x040087AE RID: 34734
		internal static int __PropertyOffset_OnAnimInitialized;

		// Token: 0x040087AF RID: 34735
		private FOnAnimInitialized _OnAnimInitialized;

		// Token: 0x040087B0 RID: 34736
		internal static int __PropertyOffset_EndGetHeadBondPos;

		// Token: 0x040087B1 RID: 34737
		internal static byte __PropertyMask_EndGetHeadBondPos;

		// Token: 0x040087B2 RID: 34738
		internal static int __PropertyOffset_bRunPostUpdateTick;

		// Token: 0x040087B3 RID: 34739
		internal static int __PropertyOffset_PrerequisiteComp;

		// Token: 0x040087B4 RID: 34740
		internal static int __PropertyOffset_bBanMontage;

		// Token: 0x040087B5 RID: 34741
		internal static int __PropertyOffset_bUseDelayComplete;

		// Token: 0x040087B6 RID: 34742
		internal static byte __PropertyMask_bUseDelayComplete;

		// Token: 0x040087B7 RID: 34743
		internal static int __PropertyOffset_bUpdateChildTransInDelayComplete;

		// Token: 0x040087B8 RID: 34744
		internal static int __PropertyOffset_bUseKuroParallel;

		// Token: 0x040087B9 RID: 34745
		internal static byte __PropertyMask_bUseKuroParallel;

		// Token: 0x040087BA RID: 34746
		internal static int __PropertyOffset_bConsumeAllRootMotion;

		// Token: 0x040087BB RID: 34747
		internal static byte __PropertyMask_bConsumeAllRootMotion;

		// Token: 0x040087BC RID: 34748
		internal static int __PropertyOffset_bCacheFirstAnimInstance;

		// Token: 0x040087BD RID: 34749
		internal static byte __PropertyMask_bCacheFirstAnimInstance;

		// Token: 0x040087BE RID: 34750
		internal static int __PropertyOffset_bUseAnimInstanceCachePool;

		// Token: 0x040087BF RID: 34751
		internal static byte __PropertyMask_bUseAnimInstanceCachePool;

		// Token: 0x040087C0 RID: 34752
		internal static int __PropertyOffset_WeakenKawaiiFollow;

		// Token: 0x040087C1 RID: 34753
		internal static int __PropertyOffset_bUseParallelSkelCtrlNodeEval;

		// Token: 0x040087C2 RID: 34754
		internal static byte __PropertyMask_bUseParallelSkelCtrlNodeEval;

		// Token: 0x040087C3 RID: 34755
		internal static int __PropertyOffset_ClothSimulationCreateClass;

		// Token: 0x040087C4 RID: 34756
		internal static int __PropertyOffset_KCClothAssets;

		// Token: 0x040087C5 RID: 34757
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UKCClothAssetBase> _KCClothAssets;

		// Token: 0x040087C6 RID: 34758
		internal static int __PropertyOffset_bEnableKuroClothSimulation;

		// Token: 0x040087C7 RID: 34759
		internal static int __PropertyOffset_bRootMotionDebug;
	}
}
