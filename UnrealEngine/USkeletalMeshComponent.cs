using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000280 RID: 640
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SkeletalMeshComponent")]
	[UnrealStructLayout(6016, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 6016)]
	public class USkeletalMeshComponent : USkinnedMeshComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060042A5 RID: 17061 RVA: 0x0005F10D File Offset: 0x0005D30D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USkeletalMeshComponent._ClassPtr;
		}

		// Token: 0x060042A6 RID: 17062 RVA: 0x0005F11C File Offset: 0x0005D31C
		public USkeletalMeshComponent() : this(BuiltinUtils.AllocNativeUObject(USkeletalMeshComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060042A7 RID: 17063 RVA: 0x0005F144 File Offset: 0x0005D344
		[NullableContext(1)]
		public USkeletalMeshComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USkeletalMeshComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000C50 RID: 3152
		// (get) Token: 0x060042A8 RID: 17064 RVA: 0x0005F177 File Offset: 0x0005D377
		// (set) Token: 0x060042A9 RID: 17065 RVA: 0x0005F18B File Offset: 0x0005D38B
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

		// Token: 0x17000C51 RID: 3153
		// (get) Token: 0x060042AA RID: 17066 RVA: 0x0005F1A0 File Offset: 0x0005D3A0
		// (set) Token: 0x060042AB RID: 17067 RVA: 0x0005F1B4 File Offset: 0x0005D3B4
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

		// Token: 0x17000C52 RID: 3154
		// (get) Token: 0x060042AC RID: 17068 RVA: 0x0005F1C9 File Offset: 0x0005D3C9
		// (set) Token: 0x060042AD RID: 17069 RVA: 0x0005F1DD File Offset: 0x0005D3DD
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

		// Token: 0x17000C53 RID: 3155
		// (get) Token: 0x060042AE RID: 17070 RVA: 0x0005F1F2 File Offset: 0x0005D3F2
		// (set) Token: 0x060042AF RID: 17071 RVA: 0x0005F206 File Offset: 0x0005D406
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

		// Token: 0x17000C54 RID: 3156
		// (get) Token: 0x060042B0 RID: 17072 RVA: 0x0005F21B File Offset: 0x0005D41B
		// (set) Token: 0x060042B1 RID: 17073 RVA: 0x0005F22F File Offset: 0x0005D42F
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

		// Token: 0x17000C55 RID: 3157
		// (get) Token: 0x060042B2 RID: 17074 RVA: 0x0005F244 File Offset: 0x0005D444
		// (set) Token: 0x060042B3 RID: 17075 RVA: 0x0005F258 File Offset: 0x0005D458
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

		// Token: 0x17000C56 RID: 3158
		// (get) Token: 0x060042B4 RID: 17076 RVA: 0x0005F270 File Offset: 0x0005D470
		// (set) Token: 0x060042B5 RID: 17077 RVA: 0x0005F2A9 File Offset: 0x0005D4A9
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

		// Token: 0x17000C57 RID: 3159
		// (get) Token: 0x060042B6 RID: 17078 RVA: 0x0005F2CA File Offset: 0x0005D4CA
		// (set) Token: 0x060042B7 RID: 17079 RVA: 0x0005F2DA File Offset: 0x0005D4DA
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

		// Token: 0x17000C58 RID: 3160
		// (get) Token: 0x060042B8 RID: 17080 RVA: 0x0005F2EB File Offset: 0x0005D4EB
		// (set) Token: 0x060042B9 RID: 17081 RVA: 0x0005F2FF File Offset: 0x0005D4FF
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

		// Token: 0x17000C59 RID: 3161
		// (get) Token: 0x060042BA RID: 17082 RVA: 0x0005F314 File Offset: 0x0005D514
		// (set) Token: 0x060042BB RID: 17083 RVA: 0x0005F328 File Offset: 0x0005D528
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

		// Token: 0x17000C5A RID: 3162
		// (get) Token: 0x060042BC RID: 17084 RVA: 0x0005F33D File Offset: 0x0005D53D
		// (set) Token: 0x060042BD RID: 17085 RVA: 0x0005F356 File Offset: 0x0005D556
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

		// Token: 0x17000C5B RID: 3163
		// (get) Token: 0x060042BE RID: 17086 RVA: 0x0005F386 File Offset: 0x0005D586
		// (set) Token: 0x060042BF RID: 17087 RVA: 0x0005F39A File Offset: 0x0005D59A
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

		// Token: 0x17000C5C RID: 3164
		// (get) Token: 0x060042C0 RID: 17088 RVA: 0x0005F3AF File Offset: 0x0005D5AF
		// (set) Token: 0x060042C1 RID: 17089 RVA: 0x0005F3C3 File Offset: 0x0005D5C3
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

		// Token: 0x17000C5D RID: 3165
		// (get) Token: 0x060042C2 RID: 17090 RVA: 0x0005F3D8 File Offset: 0x0005D5D8
		// (set) Token: 0x060042C3 RID: 17091 RVA: 0x0005F3EC File Offset: 0x0005D5EC
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

		// Token: 0x17000C5E RID: 3166
		// (get) Token: 0x060042C4 RID: 17092 RVA: 0x0005F401 File Offset: 0x0005D601
		// (set) Token: 0x060042C5 RID: 17093 RVA: 0x0005F411 File Offset: 0x0005D611
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

		// Token: 0x17000C5F RID: 3167
		// (get) Token: 0x060042C6 RID: 17094 RVA: 0x0005F422 File Offset: 0x0005D622
		// (set) Token: 0x060042C7 RID: 17095 RVA: 0x0005F432 File Offset: 0x0005D632
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

		// Token: 0x17000C60 RID: 3168
		// (get) Token: 0x060042C8 RID: 17096 RVA: 0x0005F443 File Offset: 0x0005D643
		// (set) Token: 0x060042C9 RID: 17097 RVA: 0x0005F45C File Offset: 0x0005D65C
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

		// Token: 0x17000C61 RID: 3169
		// (get) Token: 0x060042CA RID: 17098 RVA: 0x0005F48C File Offset: 0x0005D68C
		// (set) Token: 0x060042CB RID: 17099 RVA: 0x0005F4A5 File Offset: 0x0005D6A5
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

		// Token: 0x17000C62 RID: 3170
		// (get) Token: 0x060042CC RID: 17100 RVA: 0x0005F4D5 File Offset: 0x0005D6D5
		// (set) Token: 0x060042CD RID: 17101 RVA: 0x0005F4EE File Offset: 0x0005D6EE
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

		// Token: 0x17000C63 RID: 3171
		// (get) Token: 0x060042CE RID: 17102 RVA: 0x0005F51E File Offset: 0x0005D71E
		// (set) Token: 0x060042CF RID: 17103 RVA: 0x0005F52E File Offset: 0x0005D72E
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

		// Token: 0x17000C64 RID: 3172
		// (get) Token: 0x060042D0 RID: 17104 RVA: 0x0005F53F File Offset: 0x0005D73F
		// (set) Token: 0x060042D1 RID: 17105 RVA: 0x0005F553 File Offset: 0x0005D753
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

		// Token: 0x17000C65 RID: 3173
		// (get) Token: 0x060042D2 RID: 17106 RVA: 0x0005F568 File Offset: 0x0005D768
		// (set) Token: 0x060042D3 RID: 17107 RVA: 0x0005F581 File Offset: 0x0005D781
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

		// Token: 0x17000C66 RID: 3174
		// (get) Token: 0x060042D4 RID: 17108 RVA: 0x0005F5B1 File Offset: 0x0005D7B1
		// (set) Token: 0x060042D5 RID: 17109 RVA: 0x0005F5CA File Offset: 0x0005D7CA
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

		// Token: 0x17000C67 RID: 3175
		// (get) Token: 0x060042D6 RID: 17110 RVA: 0x0005F5FA File Offset: 0x0005D7FA
		// (set) Token: 0x060042D7 RID: 17111 RVA: 0x0005F60A File Offset: 0x0005D80A
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

		// Token: 0x17000C68 RID: 3176
		// (get) Token: 0x060042D8 RID: 17112 RVA: 0x0005F61B File Offset: 0x0005D81B
		// (set) Token: 0x060042D9 RID: 17113 RVA: 0x0005F62B File Offset: 0x0005D82B
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

		// Token: 0x17000C69 RID: 3177
		// (get) Token: 0x060042DA RID: 17114 RVA: 0x0005F63C File Offset: 0x0005D83C
		// (set) Token: 0x060042DB RID: 17115 RVA: 0x0005F64C File Offset: 0x0005D84C
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

		// Token: 0x17000C6A RID: 3178
		// (get) Token: 0x060042DC RID: 17116 RVA: 0x0005F65D File Offset: 0x0005D85D
		// (set) Token: 0x060042DD RID: 17117 RVA: 0x0005F671 File Offset: 0x0005D871
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

		// Token: 0x17000C6B RID: 3179
		// (get) Token: 0x060042DE RID: 17118 RVA: 0x0005F686 File Offset: 0x0005D886
		// (set) Token: 0x060042DF RID: 17119 RVA: 0x0005F696 File Offset: 0x0005D896
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

		// Token: 0x17000C6C RID: 3180
		// (get) Token: 0x060042E0 RID: 17120 RVA: 0x0005F6A7 File Offset: 0x0005D8A7
		// (set) Token: 0x060042E1 RID: 17121 RVA: 0x0005F6B7 File Offset: 0x0005D8B7
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

		// Token: 0x17000C6D RID: 3181
		// (get) Token: 0x060042E2 RID: 17122 RVA: 0x0005F6C8 File Offset: 0x0005D8C8
		// (set) Token: 0x060042E3 RID: 17123 RVA: 0x0005F6E1 File Offset: 0x0005D8E1
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

		// Token: 0x17000C6E RID: 3182
		// (get) Token: 0x060042E4 RID: 17124 RVA: 0x0005F714 File Offset: 0x0005D914
		// (set) Token: 0x060042E5 RID: 17125 RVA: 0x0005F74D File Offset: 0x0005D94D
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

		// Token: 0x17000C6F RID: 3183
		// (get) Token: 0x060042E6 RID: 17126 RVA: 0x0005F75C File Offset: 0x0005D95C
		// (set) Token: 0x060042E7 RID: 17127 RVA: 0x0005F795 File Offset: 0x0005D995
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

		// Token: 0x17000C70 RID: 3184
		// (get) Token: 0x060042E8 RID: 17128 RVA: 0x0005F7A4 File Offset: 0x0005D9A4
		// (set) Token: 0x060042E9 RID: 17129 RVA: 0x0005F7DD File Offset: 0x0005D9DD
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

		// Token: 0x17000C71 RID: 3185
		// (get) Token: 0x060042EA RID: 17130 RVA: 0x0005F7EC File Offset: 0x0005D9EC
		// (set) Token: 0x060042EB RID: 17131 RVA: 0x0005F825 File Offset: 0x0005DA25
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

		// Token: 0x17000C72 RID: 3186
		// (get) Token: 0x060042EC RID: 17132 RVA: 0x0005F834 File Offset: 0x0005DA34
		// (set) Token: 0x060042ED RID: 17133 RVA: 0x0005F86D File Offset: 0x0005DA6D
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

		// Token: 0x17000C73 RID: 3187
		// (get) Token: 0x060042EE RID: 17134 RVA: 0x0005F87C File Offset: 0x0005DA7C
		// (set) Token: 0x060042EF RID: 17135 RVA: 0x0005F8B5 File Offset: 0x0005DAB5
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

		// Token: 0x17000C74 RID: 3188
		// (get) Token: 0x060042F0 RID: 17136 RVA: 0x0005F8C3 File Offset: 0x0005DAC3
		// (set) Token: 0x060042F1 RID: 17137 RVA: 0x0005F8D3 File Offset: 0x0005DAD3
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

		// Token: 0x17000C75 RID: 3189
		// (get) Token: 0x060042F2 RID: 17138 RVA: 0x0005F8E4 File Offset: 0x0005DAE4
		// (set) Token: 0x060042F3 RID: 17139 RVA: 0x0005F8F8 File Offset: 0x0005DAF8
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

		// Token: 0x17000C76 RID: 3190
		// (get) Token: 0x060042F4 RID: 17140 RVA: 0x0005F90D File Offset: 0x0005DB0D
		// (set) Token: 0x060042F5 RID: 17141 RVA: 0x0005F926 File Offset: 0x0005DB26
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

		// Token: 0x17000C77 RID: 3191
		// (get) Token: 0x060042F6 RID: 17142 RVA: 0x0005F956 File Offset: 0x0005DB56
		// (set) Token: 0x060042F7 RID: 17143 RVA: 0x0005F96F File Offset: 0x0005DB6F
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

		// Token: 0x17000C78 RID: 3192
		// (get) Token: 0x060042F8 RID: 17144 RVA: 0x0005F99F File Offset: 0x0005DB9F
		// (set) Token: 0x060042F9 RID: 17145 RVA: 0x0005F9B8 File Offset: 0x0005DBB8
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

		// Token: 0x17000C79 RID: 3193
		// (get) Token: 0x060042FA RID: 17146 RVA: 0x0005F9E8 File Offset: 0x0005DBE8
		// (set) Token: 0x060042FB RID: 17147 RVA: 0x0005FA01 File Offset: 0x0005DC01
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

		// Token: 0x17000C7A RID: 3194
		// (get) Token: 0x060042FC RID: 17148 RVA: 0x0005FA31 File Offset: 0x0005DC31
		// (set) Token: 0x060042FD RID: 17149 RVA: 0x0005FA4A File Offset: 0x0005DC4A
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

		// Token: 0x17000C7B RID: 3195
		// (get) Token: 0x060042FE RID: 17150 RVA: 0x0005FA7A File Offset: 0x0005DC7A
		// (set) Token: 0x060042FF RID: 17151 RVA: 0x0005FA93 File Offset: 0x0005DC93
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

		// Token: 0x17000C7C RID: 3196
		// (get) Token: 0x06004300 RID: 17152 RVA: 0x0005FAC3 File Offset: 0x0005DCC3
		// (set) Token: 0x06004301 RID: 17153 RVA: 0x0005FADC File Offset: 0x0005DCDC
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

		// Token: 0x17000C7D RID: 3197
		// (get) Token: 0x06004302 RID: 17154 RVA: 0x0005FB0C File Offset: 0x0005DD0C
		// (set) Token: 0x06004303 RID: 17155 RVA: 0x0005FB25 File Offset: 0x0005DD25
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

		// Token: 0x17000C7E RID: 3198
		// (get) Token: 0x06004304 RID: 17156 RVA: 0x0005FB55 File Offset: 0x0005DD55
		// (set) Token: 0x06004305 RID: 17157 RVA: 0x0005FB6E File Offset: 0x0005DD6E
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

		// Token: 0x17000C7F RID: 3199
		// (get) Token: 0x06004306 RID: 17158 RVA: 0x0005FB9E File Offset: 0x0005DD9E
		// (set) Token: 0x06004307 RID: 17159 RVA: 0x0005FBB7 File Offset: 0x0005DDB7
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

		// Token: 0x17000C80 RID: 3200
		// (get) Token: 0x06004308 RID: 17160 RVA: 0x0005FBE7 File Offset: 0x0005DDE7
		// (set) Token: 0x06004309 RID: 17161 RVA: 0x0005FC00 File Offset: 0x0005DE00
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

		// Token: 0x17000C81 RID: 3201
		// (get) Token: 0x0600430A RID: 17162 RVA: 0x0005FC30 File Offset: 0x0005DE30
		// (set) Token: 0x0600430B RID: 17163 RVA: 0x0005FC49 File Offset: 0x0005DE49
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

		// Token: 0x17000C82 RID: 3202
		// (get) Token: 0x0600430C RID: 17164 RVA: 0x0005FC79 File Offset: 0x0005DE79
		// (set) Token: 0x0600430D RID: 17165 RVA: 0x0005FC92 File Offset: 0x0005DE92
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

		// Token: 0x17000C83 RID: 3203
		// (get) Token: 0x0600430E RID: 17166 RVA: 0x0005FCC2 File Offset: 0x0005DEC2
		// (set) Token: 0x0600430F RID: 17167 RVA: 0x0005FCDB File Offset: 0x0005DEDB
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

		// Token: 0x17000C84 RID: 3204
		// (get) Token: 0x06004310 RID: 17168 RVA: 0x0005FD0B File Offset: 0x0005DF0B
		// (set) Token: 0x06004311 RID: 17169 RVA: 0x0005FD1B File Offset: 0x0005DF1B
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

		// Token: 0x17000C85 RID: 3205
		// (get) Token: 0x06004312 RID: 17170 RVA: 0x0005FD2C File Offset: 0x0005DF2C
		// (set) Token: 0x06004313 RID: 17171 RVA: 0x0005FD45 File Offset: 0x0005DF45
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

		// Token: 0x17000C86 RID: 3206
		// (get) Token: 0x06004314 RID: 17172 RVA: 0x0005FD75 File Offset: 0x0005DF75
		// (set) Token: 0x06004315 RID: 17173 RVA: 0x0005FD8E File Offset: 0x0005DF8E
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

		// Token: 0x17000C87 RID: 3207
		// (get) Token: 0x06004316 RID: 17174 RVA: 0x0005FDBE File Offset: 0x0005DFBE
		// (set) Token: 0x06004317 RID: 17175 RVA: 0x0005FDD7 File Offset: 0x0005DFD7
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

		// Token: 0x17000C88 RID: 3208
		// (get) Token: 0x06004318 RID: 17176 RVA: 0x0005FE07 File Offset: 0x0005E007
		// (set) Token: 0x06004319 RID: 17177 RVA: 0x0005FE20 File Offset: 0x0005E020
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

		// Token: 0x17000C89 RID: 3209
		// (get) Token: 0x0600431A RID: 17178 RVA: 0x0005FE50 File Offset: 0x0005E050
		// (set) Token: 0x0600431B RID: 17179 RVA: 0x0005FE69 File Offset: 0x0005E069
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

		// Token: 0x17000C8A RID: 3210
		// (get) Token: 0x0600431C RID: 17180 RVA: 0x0005FE99 File Offset: 0x0005E099
		// (set) Token: 0x0600431D RID: 17181 RVA: 0x0005FEB2 File Offset: 0x0005E0B2
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

		// Token: 0x17000C8B RID: 3211
		// (get) Token: 0x0600431E RID: 17182 RVA: 0x0005FEE2 File Offset: 0x0005E0E2
		// (set) Token: 0x0600431F RID: 17183 RVA: 0x0005FEFB File Offset: 0x0005E0FB
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

		// Token: 0x17000C8C RID: 3212
		// (get) Token: 0x06004320 RID: 17184 RVA: 0x0005FF2B File Offset: 0x0005E12B
		// (set) Token: 0x06004321 RID: 17185 RVA: 0x0005FF44 File Offset: 0x0005E144
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

		// Token: 0x17000C8D RID: 3213
		// (get) Token: 0x06004322 RID: 17186 RVA: 0x0005FF74 File Offset: 0x0005E174
		// (set) Token: 0x06004323 RID: 17187 RVA: 0x0005FF8D File Offset: 0x0005E18D
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

		// Token: 0x17000C8E RID: 3214
		// (get) Token: 0x06004324 RID: 17188 RVA: 0x0005FFBD File Offset: 0x0005E1BD
		// (set) Token: 0x06004325 RID: 17189 RVA: 0x0005FFD6 File Offset: 0x0005E1D6
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

		// Token: 0x17000C8F RID: 3215
		// (get) Token: 0x06004326 RID: 17190 RVA: 0x00060006 File Offset: 0x0005E206
		// (set) Token: 0x06004327 RID: 17191 RVA: 0x0006001F File Offset: 0x0005E21F
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

		// Token: 0x17000C90 RID: 3216
		// (get) Token: 0x06004328 RID: 17192 RVA: 0x0006004F File Offset: 0x0005E24F
		// (set) Token: 0x06004329 RID: 17193 RVA: 0x00060068 File Offset: 0x0005E268
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

		// Token: 0x17000C91 RID: 3217
		// (get) Token: 0x0600432A RID: 17194 RVA: 0x00060098 File Offset: 0x0005E298
		// (set) Token: 0x0600432B RID: 17195 RVA: 0x000600B1 File Offset: 0x0005E2B1
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

		// Token: 0x17000C92 RID: 3218
		// (get) Token: 0x0600432C RID: 17196 RVA: 0x000600E1 File Offset: 0x0005E2E1
		// (set) Token: 0x0600432D RID: 17197 RVA: 0x000600FA File Offset: 0x0005E2FA
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

		// Token: 0x17000C93 RID: 3219
		// (get) Token: 0x0600432E RID: 17198 RVA: 0x0006012A File Offset: 0x0005E32A
		// (set) Token: 0x0600432F RID: 17199 RVA: 0x00060143 File Offset: 0x0005E343
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

		// Token: 0x17000C94 RID: 3220
		// (get) Token: 0x06004330 RID: 17200 RVA: 0x00060173 File Offset: 0x0005E373
		// (set) Token: 0x06004331 RID: 17201 RVA: 0x0006018C File Offset: 0x0005E38C
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

		// Token: 0x17000C95 RID: 3221
		// (get) Token: 0x06004332 RID: 17202 RVA: 0x000601BC File Offset: 0x0005E3BC
		// (set) Token: 0x06004333 RID: 17203 RVA: 0x000601D5 File Offset: 0x0005E3D5
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

		// Token: 0x17000C96 RID: 3222
		// (get) Token: 0x06004334 RID: 17204 RVA: 0x00060205 File Offset: 0x0005E405
		// (set) Token: 0x06004335 RID: 17205 RVA: 0x0006021E File Offset: 0x0005E41E
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

		// Token: 0x17000C97 RID: 3223
		// (get) Token: 0x06004336 RID: 17206 RVA: 0x0006024E File Offset: 0x0005E44E
		// (set) Token: 0x06004337 RID: 17207 RVA: 0x00060267 File Offset: 0x0005E467
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

		// Token: 0x17000C98 RID: 3224
		// (get) Token: 0x06004338 RID: 17208 RVA: 0x00060297 File Offset: 0x0005E497
		// (set) Token: 0x06004339 RID: 17209 RVA: 0x000602B0 File Offset: 0x0005E4B0
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

		// Token: 0x17000C99 RID: 3225
		// (get) Token: 0x0600433A RID: 17210 RVA: 0x000602E0 File Offset: 0x0005E4E0
		// (set) Token: 0x0600433B RID: 17211 RVA: 0x000602F9 File Offset: 0x0005E4F9
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

		// Token: 0x17000C9A RID: 3226
		// (get) Token: 0x0600433C RID: 17212 RVA: 0x00060329 File Offset: 0x0005E529
		// (set) Token: 0x0600433D RID: 17213 RVA: 0x00060342 File Offset: 0x0005E542
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

		// Token: 0x17000C9B RID: 3227
		// (get) Token: 0x0600433E RID: 17214 RVA: 0x00060372 File Offset: 0x0005E572
		// (set) Token: 0x0600433F RID: 17215 RVA: 0x0006038B File Offset: 0x0005E58B
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

		// Token: 0x17000C9C RID: 3228
		// (get) Token: 0x06004340 RID: 17216 RVA: 0x000603BB File Offset: 0x0005E5BB
		// (set) Token: 0x06004341 RID: 17217 RVA: 0x000603D4 File Offset: 0x0005E5D4
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

		// Token: 0x17000C9D RID: 3229
		// (get) Token: 0x06004342 RID: 17218 RVA: 0x00060404 File Offset: 0x0005E604
		// (set) Token: 0x06004343 RID: 17219 RVA: 0x0006041D File Offset: 0x0005E61D
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

		// Token: 0x17000C9E RID: 3230
		// (get) Token: 0x06004344 RID: 17220 RVA: 0x0006044D File Offset: 0x0005E64D
		// (set) Token: 0x06004345 RID: 17221 RVA: 0x00060466 File Offset: 0x0005E666
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

		// Token: 0x17000C9F RID: 3231
		// (get) Token: 0x06004346 RID: 17222 RVA: 0x00060496 File Offset: 0x0005E696
		// (set) Token: 0x06004347 RID: 17223 RVA: 0x000604AF File Offset: 0x0005E6AF
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

		// Token: 0x17000CA0 RID: 3232
		// (get) Token: 0x06004348 RID: 17224 RVA: 0x000604DF File Offset: 0x0005E6DF
		// (set) Token: 0x06004349 RID: 17225 RVA: 0x000604F8 File Offset: 0x0005E6F8
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

		// Token: 0x17000CA1 RID: 3233
		// (get) Token: 0x0600434A RID: 17226 RVA: 0x00060528 File Offset: 0x0005E728
		// (set) Token: 0x0600434B RID: 17227 RVA: 0x00060541 File Offset: 0x0005E741
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

		// Token: 0x17000CA2 RID: 3234
		// (get) Token: 0x0600434C RID: 17228 RVA: 0x00060571 File Offset: 0x0005E771
		// (set) Token: 0x0600434D RID: 17229 RVA: 0x0006058A File Offset: 0x0005E78A
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

		// Token: 0x17000CA3 RID: 3235
		// (get) Token: 0x0600434E RID: 17230 RVA: 0x000605BA File Offset: 0x0005E7BA
		// (set) Token: 0x0600434F RID: 17231 RVA: 0x000605CA File Offset: 0x0005E7CA
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

		// Token: 0x17000CA4 RID: 3236
		// (get) Token: 0x06004350 RID: 17232 RVA: 0x000605DB File Offset: 0x0005E7DB
		// (set) Token: 0x06004351 RID: 17233 RVA: 0x000605EB File Offset: 0x0005E7EB
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

		// Token: 0x17000CA5 RID: 3237
		// (get) Token: 0x06004352 RID: 17234 RVA: 0x000605FC File Offset: 0x0005E7FC
		// (set) Token: 0x06004353 RID: 17235 RVA: 0x0006060C File Offset: 0x0005E80C
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

		// Token: 0x17000CA6 RID: 3238
		// (get) Token: 0x06004354 RID: 17236 RVA: 0x0006061D File Offset: 0x0005E81D
		// (set) Token: 0x06004355 RID: 17237 RVA: 0x0006062D File Offset: 0x0005E82D
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

		// Token: 0x17000CA7 RID: 3239
		// (get) Token: 0x06004356 RID: 17238 RVA: 0x0006063E File Offset: 0x0005E83E
		// (set) Token: 0x06004357 RID: 17239 RVA: 0x0006064E File Offset: 0x0005E84E
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

		// Token: 0x17000CA8 RID: 3240
		// (get) Token: 0x06004358 RID: 17240 RVA: 0x0006065F File Offset: 0x0005E85F
		// (set) Token: 0x06004359 RID: 17241 RVA: 0x0006066F File Offset: 0x0005E86F
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

		// Token: 0x17000CA9 RID: 3241
		// (get) Token: 0x0600435A RID: 17242 RVA: 0x00060680 File Offset: 0x0005E880
		// (set) Token: 0x0600435B RID: 17243 RVA: 0x00060690 File Offset: 0x0005E890
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

		// Token: 0x17000CAA RID: 3242
		// (get) Token: 0x0600435C RID: 17244 RVA: 0x000606A1 File Offset: 0x0005E8A1
		// (set) Token: 0x0600435D RID: 17245 RVA: 0x000606B1 File Offset: 0x0005E8B1
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

		// Token: 0x17000CAB RID: 3243
		// (get) Token: 0x0600435E RID: 17246 RVA: 0x000606C2 File Offset: 0x0005E8C2
		// (set) Token: 0x0600435F RID: 17247 RVA: 0x000606D2 File Offset: 0x0005E8D2
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

		// Token: 0x17000CAC RID: 3244
		// (get) Token: 0x06004360 RID: 17248 RVA: 0x000606E3 File Offset: 0x0005E8E3
		// (set) Token: 0x06004361 RID: 17249 RVA: 0x000606F3 File Offset: 0x0005E8F3
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

		// Token: 0x17000CAD RID: 3245
		// (get) Token: 0x06004362 RID: 17250 RVA: 0x00060704 File Offset: 0x0005E904
		// (set) Token: 0x06004363 RID: 17251 RVA: 0x00060714 File Offset: 0x0005E914
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

		// Token: 0x17000CAE RID: 3246
		// (get) Token: 0x06004364 RID: 17252 RVA: 0x00060725 File Offset: 0x0005E925
		// (set) Token: 0x06004365 RID: 17253 RVA: 0x00060735 File Offset: 0x0005E935
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

		// Token: 0x17000CAF RID: 3247
		// (get) Token: 0x06004366 RID: 17254 RVA: 0x00060746 File Offset: 0x0005E946
		// (set) Token: 0x06004367 RID: 17255 RVA: 0x00060756 File Offset: 0x0005E956
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

		// Token: 0x17000CB0 RID: 3248
		// (get) Token: 0x06004368 RID: 17256 RVA: 0x00060767 File Offset: 0x0005E967
		// (set) Token: 0x06004369 RID: 17257 RVA: 0x00060777 File Offset: 0x0005E977
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

		// Token: 0x17000CB1 RID: 3249
		// (get) Token: 0x0600436A RID: 17258 RVA: 0x00060788 File Offset: 0x0005E988
		// (set) Token: 0x0600436B RID: 17259 RVA: 0x00060798 File Offset: 0x0005E998
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

		// Token: 0x17000CB2 RID: 3250
		// (get) Token: 0x0600436C RID: 17260 RVA: 0x000607AC File Offset: 0x0005E9AC
		// (set) Token: 0x0600436D RID: 17261 RVA: 0x000607E5 File Offset: 0x0005E9E5
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

		// Token: 0x17000CB3 RID: 3251
		// (get) Token: 0x0600436E RID: 17262 RVA: 0x000607F3 File Offset: 0x0005E9F3
		// (set) Token: 0x0600436F RID: 17263 RVA: 0x00060803 File Offset: 0x0005EA03
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

		// Token: 0x17000CB4 RID: 3252
		// (get) Token: 0x06004370 RID: 17264 RVA: 0x00060814 File Offset: 0x0005EA14
		// (set) Token: 0x06004371 RID: 17265 RVA: 0x0006084D File Offset: 0x0005EA4D
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

		// Token: 0x17000CB5 RID: 3253
		// (get) Token: 0x06004372 RID: 17266 RVA: 0x0006085B File Offset: 0x0005EA5B
		// (set) Token: 0x06004373 RID: 17267 RVA: 0x0006086F File Offset: 0x0005EA6F
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

		// Token: 0x17000CB6 RID: 3254
		// (get) Token: 0x06004374 RID: 17268 RVA: 0x00060884 File Offset: 0x0005EA84
		// (set) Token: 0x06004375 RID: 17269 RVA: 0x000608BD File Offset: 0x0005EABD
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

		// Token: 0x17000CB7 RID: 3255
		// (get) Token: 0x06004376 RID: 17270 RVA: 0x000608DE File Offset: 0x0005EADE
		// (set) Token: 0x06004377 RID: 17271 RVA: 0x000608EE File Offset: 0x0005EAEE
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

		// Token: 0x17000CB8 RID: 3256
		// (get) Token: 0x06004378 RID: 17272 RVA: 0x000608FF File Offset: 0x0005EAFF
		// (set) Token: 0x06004379 RID: 17273 RVA: 0x0006090F File Offset: 0x0005EB0F
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

		// Token: 0x17000CB9 RID: 3257
		// (get) Token: 0x0600437A RID: 17274 RVA: 0x00060920 File Offset: 0x0005EB20
		// (set) Token: 0x0600437B RID: 17275 RVA: 0x00060930 File Offset: 0x0005EB30
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

		// Token: 0x17000CBA RID: 3258
		// (get) Token: 0x0600437C RID: 17276 RVA: 0x00060944 File Offset: 0x0005EB44
		// (set) Token: 0x0600437D RID: 17277 RVA: 0x0006097D File Offset: 0x0005EB7D
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

		// Token: 0x17000CBB RID: 3259
		// (get) Token: 0x0600437E RID: 17278 RVA: 0x0006099E File Offset: 0x0005EB9E
		// (set) Token: 0x0600437F RID: 17279 RVA: 0x000609B7 File Offset: 0x0005EBB7
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

		// Token: 0x17000CBC RID: 3260
		// (get) Token: 0x06004380 RID: 17280 RVA: 0x000609E7 File Offset: 0x0005EBE7
		// (set) Token: 0x06004381 RID: 17281 RVA: 0x000609F7 File Offset: 0x0005EBF7
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

		// Token: 0x17000CBD RID: 3261
		// (get) Token: 0x06004382 RID: 17282 RVA: 0x00060A08 File Offset: 0x0005EC08
		// (set) Token: 0x06004383 RID: 17283 RVA: 0x00060A1C File Offset: 0x0005EC1C
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

		// Token: 0x17000CBE RID: 3262
		// (get) Token: 0x06004384 RID: 17284 RVA: 0x00060A31 File Offset: 0x0005EC31
		// (set) Token: 0x06004385 RID: 17285 RVA: 0x00060A41 File Offset: 0x0005EC41
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

		// Token: 0x17000CBF RID: 3263
		// (get) Token: 0x06004386 RID: 17286 RVA: 0x00060A52 File Offset: 0x0005EC52
		// (set) Token: 0x06004387 RID: 17287 RVA: 0x00060A6B File Offset: 0x0005EC6B
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

		// Token: 0x17000CC0 RID: 3264
		// (get) Token: 0x06004388 RID: 17288 RVA: 0x00060A9B File Offset: 0x0005EC9B
		// (set) Token: 0x06004389 RID: 17289 RVA: 0x00060AAB File Offset: 0x0005ECAB
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

		// Token: 0x17000CC1 RID: 3265
		// (get) Token: 0x0600438A RID: 17290 RVA: 0x00060ABC File Offset: 0x0005ECBC
		// (set) Token: 0x0600438B RID: 17291 RVA: 0x00060AD5 File Offset: 0x0005ECD5
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

		// Token: 0x17000CC2 RID: 3266
		// (get) Token: 0x0600438C RID: 17292 RVA: 0x00060B05 File Offset: 0x0005ED05
		// (set) Token: 0x0600438D RID: 17293 RVA: 0x00060B1E File Offset: 0x0005ED1E
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

		// Token: 0x17000CC3 RID: 3267
		// (get) Token: 0x0600438E RID: 17294 RVA: 0x00060B4E File Offset: 0x0005ED4E
		// (set) Token: 0x0600438F RID: 17295 RVA: 0x00060B67 File Offset: 0x0005ED67
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

		// Token: 0x17000CC4 RID: 3268
		// (get) Token: 0x06004390 RID: 17296 RVA: 0x00060B97 File Offset: 0x0005ED97
		// (set) Token: 0x06004391 RID: 17297 RVA: 0x00060BB0 File Offset: 0x0005EDB0
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

		// Token: 0x17000CC5 RID: 3269
		// (get) Token: 0x06004392 RID: 17298 RVA: 0x00060BE0 File Offset: 0x0005EDE0
		// (set) Token: 0x06004393 RID: 17299 RVA: 0x00060BF0 File Offset: 0x0005EDF0
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

		// Token: 0x17000CC6 RID: 3270
		// (get) Token: 0x06004394 RID: 17300 RVA: 0x00060C01 File Offset: 0x0005EE01
		// (set) Token: 0x06004395 RID: 17301 RVA: 0x00060C1A File Offset: 0x0005EE1A
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

		// Token: 0x17000CC7 RID: 3271
		// (get) Token: 0x06004396 RID: 17302 RVA: 0x00060C4A File Offset: 0x0005EE4A
		// (set) Token: 0x06004397 RID: 17303 RVA: 0x00060C5A File Offset: 0x0005EE5A
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

		// Token: 0x17000CC8 RID: 3272
		// (get) Token: 0x06004398 RID: 17304 RVA: 0x00060C6B File Offset: 0x0005EE6B
		// (set) Token: 0x06004399 RID: 17305 RVA: 0x00060C7B File Offset: 0x0005EE7B
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

		// Token: 0x0600439A RID: 17306 RVA: 0x00060C8C File Offset: 0x0005EE8C
		public void UpdateLODStatus_Outside()
		{
			USkeletalMeshComponent.__UpdateLODStatus_Outside_Internal(base.NativePtr);
		}

		// Token: 0x0600439B RID: 17307 RVA: 0x00060C99 File Offset: 0x0005EE99
		public void UnlockKuroEvaluation()
		{
			USkeletalMeshComponent.__UnlockKuroEvaluation_Internal(base.NativePtr);
		}

		// Token: 0x0600439C RID: 17308 RVA: 0x00060CA6 File Offset: 0x0005EEA6
		public void UnlinkAnimClassLayers([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UAnimInstance> InClass)
		{
			USkeletalMeshComponent.__UnlinkAnimClassLayers_Internal(base.NativePtr, InClass._NativePtr);
		}

		// Token: 0x0600439D RID: 17309 RVA: 0x00060CB9 File Offset: 0x0005EEB9
		public void UnbindClothFromMasterPoseComponent(bool bRestoreSimulationSpace = true)
		{
			USkeletalMeshComponent.__UnbindClothFromMasterPoseComponent_Internal(base.NativePtr, bRestoreSimulationSpace);
		}

		// Token: 0x0600439E RID: 17310 RVA: 0x00060CC7 File Offset: 0x0005EEC7
		public void ToggleDisablePostProcessBlueprint()
		{
			USkeletalMeshComponent.__ToggleDisablePostProcessBlueprint_Internal(base.NativePtr);
		}

		// Token: 0x0600439F RID: 17311 RVA: 0x00060CD4 File Offset: 0x0005EED4
		public void TickSoftAssetLoading()
		{
			USkeletalMeshComponent.__TickSoftAssetLoading_Internal(base.NativePtr);
		}

		// Token: 0x060043A0 RID: 17312 RVA: 0x00060CE1 File Offset: 0x0005EEE1
		public void TestGetBoneSpaceTransforms()
		{
			USkeletalMeshComponent.__TestGetBoneSpaceTransforms_Internal(base.NativePtr);
		}

		// Token: 0x060043A1 RID: 17313 RVA: 0x00060CEE File Offset: 0x0005EEEE
		public void TermBodiesBelow(FName ParentBoneName)
		{
			USkeletalMeshComponent.__TermBodiesBelow_Internal(base.NativePtr, ParentBoneName);
		}

		// Token: 0x060043A2 RID: 17314 RVA: 0x00060CFC File Offset: 0x0005EEFC
		public void SuspendClothingSimulation()
		{
			USkeletalMeshComponent.__SuspendClothingSimulation_Internal(base.NativePtr);
		}

		// Token: 0x060043A3 RID: 17315 RVA: 0x00060D09 File Offset: 0x0005EF09
		public void Stop()
		{
			USkeletalMeshComponent.__Stop_Internal(base.NativePtr);
		}

		// Token: 0x060043A4 RID: 17316 RVA: 0x00060D16 File Offset: 0x0005EF16
		public void SetUseProxyDataBuffer(bool Use)
		{
			USkeletalMeshComponent.__SetUseProxyDataBuffer_Internal(base.NativePtr, Use);
		}

		// Token: 0x060043A5 RID: 17317 RVA: 0x00060D24 File Offset: 0x0005EF24
		public void SetUpdateClothInEditor(bool NewUpdateState)
		{
			USkeletalMeshComponent.__SetUpdateClothInEditor_Internal(base.NativePtr, NewUpdateState);
		}

		// Token: 0x060043A6 RID: 17318 RVA: 0x00060D32 File Offset: 0x0005EF32
		public void SetUpdateAnimationInEditor(bool NewUpdateState)
		{
			USkeletalMeshComponent.__SetUpdateAnimationInEditor_Internal(base.NativePtr, NewUpdateState);
		}

		// Token: 0x060043A7 RID: 17319 RVA: 0x00060D40 File Offset: 0x0005EF40
		public void SetTeleportRotationThreshold(float Threshold)
		{
			USkeletalMeshComponent.__SetTeleportRotationThreshold_Internal(base.NativePtr, Threshold);
		}

		// Token: 0x060043A8 RID: 17320 RVA: 0x00060D4E File Offset: 0x0005EF4E
		public void SetTeleportDistanceThreshold(float Threshold)
		{
			USkeletalMeshComponent.__SetTeleportDistanceThreshold_Internal(base.NativePtr, Threshold);
		}

		// Token: 0x060043A9 RID: 17321 RVA: 0x00060D5C File Offset: 0x0005EF5C
		public void SetSkeletalMeshScreenSizeCullRatio(float Value)
		{
			USkeletalMeshComponent.__SetSkeletalMeshScreenSizeCullRatio_Internal(base.NativePtr, Value);
		}

		// Token: 0x060043AA RID: 17322 RVA: 0x00060D6A File Offset: 0x0005EF6A
		public void SetRenderInKuroXRayPass(bool bValue)
		{
			USkeletalMeshComponent.__SetRenderInKuroXRayPass_Internal(base.NativePtr, bValue);
		}

		// Token: 0x060043AB RID: 17323 RVA: 0x00060D78 File Offset: 0x0005EF78
		public void SetPosition(float InPos, bool bFireNotifies = true)
		{
			USkeletalMeshComponent.__SetPosition_Internal(base.NativePtr, InPos, bFireNotifies);
		}

		// Token: 0x060043AC RID: 17324 RVA: 0x00060D87 File Offset: 0x0005EF87
		public void SetPlayRate(float Rate)
		{
			USkeletalMeshComponent.__SetPlayRate_Internal(base.NativePtr, Rate);
		}

		// Token: 0x060043AD RID: 17325 RVA: 0x00060D95 File Offset: 0x0005EF95
		public void SetPhysicsBlendWeight(float PhysicsBlendWeight)
		{
			USkeletalMeshComponent.__SetPhysicsBlendWeight_Internal(base.NativePtr, PhysicsBlendWeight);
		}

		// Token: 0x060043AE RID: 17326 RVA: 0x00060DA3 File Offset: 0x0005EFA3
		public void SetNotifyRigidBodyCollisionBelow(bool bNewNotifyRigidBodyCollision, FName BoneName = default(FName), bool bIncludeSelf = true)
		{
			USkeletalMeshComponent.__SetNotifyRigidBodyCollisionBelow_Internal(base.NativePtr, bNewNotifyRigidBodyCollision, BoneName, bIncludeSelf);
		}

		// Token: 0x060043AF RID: 17327 RVA: 0x00060DB3 File Offset: 0x0005EFB3
		public void SetMorphTarget(FName MorphTargetName, float Value, bool bRemoveZeroWeight = true)
		{
			USkeletalMeshComponent.__SetMorphTarget_Internal(base.NativePtr, MorphTargetName, Value, bRemoveZeroWeight);
		}

		// Token: 0x060043B0 RID: 17328 RVA: 0x00060DC3 File Offset: 0x0005EFC3
		public void SetKuroXRayPenetrateCharacters(bool bValue)
		{
			USkeletalMeshComponent.__SetKuroXRayPenetrateCharacters_Internal(base.NativePtr, bValue);
		}

		// Token: 0x060043B1 RID: 17329 RVA: 0x00060DD1 File Offset: 0x0005EFD1
		public void SetKuroXRayOutlineWidth(float InWidth)
		{
			USkeletalMeshComponent.__SetKuroXRayOutlineWidth_Internal(base.NativePtr, InWidth);
		}

		// Token: 0x060043B2 RID: 17330 RVA: 0x00060DDF File Offset: 0x0005EFDF
		public void SetKuroXRayOutlineMaterial(UMaterialInterface InMaterial)
		{
			USkeletalMeshComponent.__SetKuroXRayOutlineMaterial_Internal(base.NativePtr, (InMaterial != null) ? InMaterial.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060043B3 RID: 17331 RVA: 0x00060DFC File Offset: 0x0005EFFC
		public void SetKuroXRayMaterial(UMaterialInterface InMaterial)
		{
			USkeletalMeshComponent.__SetKuroXRayMaterial_Internal(base.NativePtr, (InMaterial != null) ? InMaterial.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060043B4 RID: 17332 RVA: 0x00060E19 File Offset: 0x0005F019
		public void SetKuroXRayDistance(float InDistance)
		{
			USkeletalMeshComponent.__SetKuroXRayDistance_Internal(base.NativePtr, InDistance);
		}

		// Token: 0x060043B5 RID: 17333 RVA: 0x00060E27 File Offset: 0x0005F027
		public void SetKuroXRayColor(FLinearColor InKuroXRayColor)
		{
			USkeletalMeshComponent.__SetKuroXRayColor_Internal(base.NativePtr, InKuroXRayColor);
		}

		// Token: 0x060043B6 RID: 17334 RVA: 0x00060E35 File Offset: 0x0005F035
		public void SetKuroSkipAnimNotifies(bool bInSkip)
		{
			USkeletalMeshComponent.__SetKuroSkipAnimNotifies_Internal(base.NativePtr, bInSkip);
		}

		// Token: 0x060043B7 RID: 17335 RVA: 0x00060E43 File Offset: 0x0005F043
		public void SetForceDisableBoneBounds(bool InForceDisableBoneBounds = true)
		{
			USkeletalMeshComponent.__SetForceDisableBoneBounds_Internal(base.NativePtr, InForceDisableBoneBounds);
		}

		// Token: 0x060043B8 RID: 17336 RVA: 0x00060E51 File Offset: 0x0005F051
		public void SetEnablePhysicsBlending(bool bNewBlendPhysics)
		{
			USkeletalMeshComponent.__SetEnablePhysicsBlending_Internal(base.NativePtr, bNewBlendPhysics);
		}

		// Token: 0x060043B9 RID: 17337 RVA: 0x00060E5F File Offset: 0x0005F05F
		public void SetEnableOverrideSkeletalMeshScreenSizeCullRatio(bool bValue)
		{
			USkeletalMeshComponent.__SetEnableOverrideSkeletalMeshScreenSizeCullRatio_Internal(base.NativePtr, bValue);
		}

		// Token: 0x060043BA RID: 17338 RVA: 0x00060E6D File Offset: 0x0005F06D
		public void SetEnableGravityOnAllBodiesBelow(bool bEnableGravity, FName BoneName, bool bIncludeSelf = true)
		{
			USkeletalMeshComponent.__SetEnableGravityOnAllBodiesBelow_Internal(base.NativePtr, bEnableGravity, BoneName, bIncludeSelf);
		}

		// Token: 0x060043BB RID: 17339 RVA: 0x00060E7D File Offset: 0x0005F07D
		public void SetEnableBodyGravity(bool bEnableGravity, FName BoneName)
		{
			USkeletalMeshComponent.__SetEnableBodyGravity_Internal(base.NativePtr, bEnableGravity, BoneName);
		}

		// Token: 0x060043BC RID: 17340 RVA: 0x00060E8C File Offset: 0x0005F08C
		public unsafe void SetDynamicMaterialScalarParameterValue(int InMatIndex, in FName InParamName, float InValue)
		{
			fixed (FName* ptr = &InParamName)
			{
				void* ptr2 = (void*)ptr;
				USkeletalMeshComponent.__SetDynamicMaterialScalarParameterValue_Internal(base.NativePtr, InMatIndex, InParamName, InValue);
			}
		}

		// Token: 0x060043BD RID: 17341 RVA: 0x00060EAF File Offset: 0x0005F0AF
		public void SetDisableWaterForToon(bool bValue)
		{
			USkeletalMeshComponent.__SetDisableWaterForToon_Internal(base.NativePtr, bValue);
		}

		// Token: 0x060043BE RID: 17342 RVA: 0x00060EBD File Offset: 0x0005F0BD
		public void SetDisablePostProcessBlueprint(bool bInDisablePostProcess)
		{
			USkeletalMeshComponent.__SetDisablePostProcessBlueprint_Internal(base.NativePtr, bInDisablePostProcess);
		}

		// Token: 0x060043BF RID: 17343 RVA: 0x00060ECB File Offset: 0x0005F0CB
		public void SetDisableAnimCurves(bool bInDisableAnimCurves)
		{
			USkeletalMeshComponent.__SetDisableAnimCurves_Internal(base.NativePtr, bInDisableAnimCurves);
		}

		// Token: 0x060043C0 RID: 17344 RVA: 0x00060ED9 File Offset: 0x0005F0D9
		public void SetDelayCompleteParallelEvaluation()
		{
			USkeletalMeshComponent.__SetDelayCompleteParallelEvaluation_Internal(base.NativePtr);
		}

		// Token: 0x060043C1 RID: 17345 RVA: 0x00060EE6 File Offset: 0x0005F0E6
		public void SetConstraintProfileForAll(FName ProfileName, bool bDefaultIfNotFound = false)
		{
			USkeletalMeshComponent.__SetConstraintProfileForAll_Internal(base.NativePtr, ProfileName, bDefaultIfNotFound);
		}

		// Token: 0x060043C2 RID: 17346 RVA: 0x00060EF5 File Offset: 0x0005F0F5
		public void SetConstraintProfile(FName JointName, FName ProfileName, bool bDefaultIfNotFound = false)
		{
			USkeletalMeshComponent.__SetConstraintProfile_Internal(base.NativePtr, JointName, ProfileName, bDefaultIfNotFound);
		}

		// Token: 0x060043C3 RID: 17347 RVA: 0x00060F05 File Offset: 0x0005F105
		public void SetClothMaxDistanceScale(float Scale)
		{
			USkeletalMeshComponent.__SetClothMaxDistanceScale_Internal(base.NativePtr, Scale);
		}

		// Token: 0x060043C4 RID: 17348 RVA: 0x00060F13 File Offset: 0x0005F113
		public void SetBodyNotifyRigidBodyCollision(bool bNewNotifyRigidBodyCollision, FName BoneName = default(FName))
		{
			USkeletalMeshComponent.__SetBodyNotifyRigidBodyCollision_Internal(base.NativePtr, bNewNotifyRigidBodyCollision, BoneName);
		}

		// Token: 0x060043C5 RID: 17349 RVA: 0x00060F22 File Offset: 0x0005F122
		public void SetAnimClass(UClassStackOnlyPtr NewClass)
		{
			USkeletalMeshComponent.__SetAnimClass_Internal(base.NativePtr, NewClass._NativePtr);
		}

		// Token: 0x060043C6 RID: 17350 RVA: 0x00060F35 File Offset: 0x0005F135
		public void SetAnimationRibbonAsset(UAnimationAsset NewRibbonAsset)
		{
			USkeletalMeshComponent.__SetAnimationRibbonAsset_Internal(base.NativePtr, (NewRibbonAsset != null) ? NewRibbonAsset.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060043C7 RID: 17351 RVA: 0x00060F52 File Offset: 0x0005F152
		public void SetAnimationMode(EAnimationMode InAnimationMode)
		{
			USkeletalMeshComponent.__SetAnimationMode_Internal(base.NativePtr, InAnimationMode);
		}

		// Token: 0x060043C8 RID: 17352 RVA: 0x00060F65 File Offset: 0x0005F165
		public void SetAnimation(UAnimationAsset NewAnimToPlay)
		{
			USkeletalMeshComponent.__SetAnimation_Internal(base.NativePtr, (NewAnimToPlay != null) ? NewAnimToPlay.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060043C9 RID: 17353 RVA: 0x00060F82 File Offset: 0x0005F182
		public void SetAngularLimits(FName InBoneName, float Swing1LimitAngle, float TwistLimitAngle, float Swing2LimitAngle)
		{
			USkeletalMeshComponent.__SetAngularLimits_Internal(base.NativePtr, InBoneName, Swing1LimitAngle, TwistLimitAngle, Swing2LimitAngle);
		}

		// Token: 0x060043CA RID: 17354 RVA: 0x00060F94 File Offset: 0x0005F194
		public void SetAllowRigidBodyAnimNode(bool bInAllow, bool bReinitAnim = true)
		{
			USkeletalMeshComponent.__SetAllowRigidBodyAnimNode_Internal(base.NativePtr, bInAllow, bReinitAnim);
		}

		// Token: 0x060043CB RID: 17355 RVA: 0x00060FA3 File Offset: 0x0005F1A3
		public void SetAllowedAnimCurvesEvaluation(in TArray<FName> List, bool bAllow)
		{
			USkeletalMeshComponent.__SetAllowedAnimCurvesEvaluation_Internal(base.NativePtr, (List ?? new TArray<FName>()).NativePtr, bAllow);
		}

		// Token: 0x060043CC RID: 17356 RVA: 0x00060FC1 File Offset: 0x0005F1C1
		public void SetAllowAnimCurveEvaluation(bool bInAllow)
		{
			USkeletalMeshComponent.__SetAllowAnimCurveEvaluation_Internal(base.NativePtr, bInAllow);
		}

		// Token: 0x060043CD RID: 17357 RVA: 0x00060FCF File Offset: 0x0005F1CF
		public void SetAllMotorsAngularVelocityDrive(bool bEnableSwingDrive, bool bEnableTwistDrive, bool bSkipCustomPhysicsType = false)
		{
			USkeletalMeshComponent.__SetAllMotorsAngularVelocityDrive_Internal(base.NativePtr, bEnableSwingDrive, bEnableTwistDrive, bSkipCustomPhysicsType);
		}

		// Token: 0x060043CE RID: 17358 RVA: 0x00060FDF File Offset: 0x0005F1DF
		public void SetAllMotorsAngularPositionDrive(bool bEnableSwingDrive, bool bEnableTwistDrive, bool bSkipCustomPhysicsType = false)
		{
			USkeletalMeshComponent.__SetAllMotorsAngularPositionDrive_Internal(base.NativePtr, bEnableSwingDrive, bEnableTwistDrive, bSkipCustomPhysicsType);
		}

		// Token: 0x060043CF RID: 17359 RVA: 0x00060FEF File Offset: 0x0005F1EF
		public void SetAllMotorsAngularDriveParams(float InSpring, float InDamping, float InForceLimit, bool bSkipCustomPhysicsType = false)
		{
			USkeletalMeshComponent.__SetAllMotorsAngularDriveParams_Internal(base.NativePtr, InSpring, InDamping, InForceLimit, bSkipCustomPhysicsType);
		}

		// Token: 0x060043D0 RID: 17360 RVA: 0x00061001 File Offset: 0x0005F201
		public void SetAllBodiesSimulatePhysics(bool bNewSimulate)
		{
			USkeletalMeshComponent.__SetAllBodiesSimulatePhysics_Internal(base.NativePtr, bNewSimulate);
		}

		// Token: 0x060043D1 RID: 17361 RVA: 0x0006100F File Offset: 0x0005F20F
		public void SetAllBodiesPhysicsBlendWeight(float PhysicsBlendWeight, bool bSkipCustomPhysicsType = false)
		{
			USkeletalMeshComponent.__SetAllBodiesPhysicsBlendWeight_Internal(base.NativePtr, PhysicsBlendWeight, bSkipCustomPhysicsType);
		}

		// Token: 0x060043D2 RID: 17362 RVA: 0x00061020 File Offset: 0x0005F220
		public unsafe void SetAllBodiesBelowSimulatePhysics(in FName InBoneName, bool bNewSimulate, bool bIncludeSelf = true)
		{
			fixed (FName* ptr = &InBoneName)
			{
				void* ptr2 = (void*)ptr;
				USkeletalMeshComponent.__SetAllBodiesBelowSimulatePhysics_Internal(base.NativePtr, InBoneName, bNewSimulate, bIncludeSelf);
			}
		}

		// Token: 0x060043D3 RID: 17363 RVA: 0x00061044 File Offset: 0x0005F244
		public unsafe void SetAllBodiesBelowPhysicsBlendWeight(in FName InBoneName, float PhysicsBlendWeight, bool bSkipCustomPhysicsType = false, bool bIncludeSelf = true)
		{
			fixed (FName* ptr = &InBoneName)
			{
				void* ptr2 = (void*)ptr;
				USkeletalMeshComponent.__SetAllBodiesBelowPhysicsBlendWeight_Internal(base.NativePtr, InBoneName, PhysicsBlendWeight, bSkipCustomPhysicsType, bIncludeSelf);
			}
		}

		// Token: 0x060043D4 RID: 17364 RVA: 0x00061069 File Offset: 0x0005F269
		public void ResumeClothingSimulation()
		{
			USkeletalMeshComponent.__ResumeClothingSimulation_Internal(base.NativePtr);
		}

		// Token: 0x060043D5 RID: 17365 RVA: 0x00061076 File Offset: 0x0005F276
		public void ResetEvaluationDebugStatistics()
		{
			USkeletalMeshComponent.__ResetEvaluationDebugStatistics_Internal(base.NativePtr);
		}

		// Token: 0x060043D6 RID: 17366 RVA: 0x00061083 File Offset: 0x0005F283
		public void ResetClothTeleportMode()
		{
			USkeletalMeshComponent.__ResetClothTeleportMode_Internal(base.NativePtr);
		}

		// Token: 0x060043D7 RID: 17367 RVA: 0x00061090 File Offset: 0x0005F290
		public void ResetAllowedAnimCurveEvaluation()
		{
			USkeletalMeshComponent.__ResetAllowedAnimCurveEvaluation_Internal(base.NativePtr);
		}

		// Token: 0x060043D8 RID: 17368 RVA: 0x0006109D File Offset: 0x0005F29D
		public void ResetAllBodiesSimulatePhysics()
		{
			USkeletalMeshComponent.__ResetAllBodiesSimulatePhysics_Internal(base.NativePtr);
		}

		// Token: 0x060043D9 RID: 17369 RVA: 0x000610AA File Offset: 0x0005F2AA
		public void RegisterKuroCharPostUpdateTickFun(bool bRegister)
		{
			USkeletalMeshComponent.__RegisterKuroCharPostUpdateTickFun_Internal(base.NativePtr, bRegister);
		}

		// Token: 0x060043DA RID: 17370 RVA: 0x000610B8 File Offset: 0x0005F2B8
		public void RecreateKuroCloth()
		{
			USkeletalMeshComponent.__RecreateKuroCloth_Internal(base.NativePtr);
		}

		// Token: 0x060043DB RID: 17371 RVA: 0x000610C5 File Offset: 0x0005F2C5
		public void PlayAnimation(UAnimationAsset NewAnimToPlay, bool bLooping)
		{
			USkeletalMeshComponent.__PlayAnimation_Internal(base.NativePtr, (NewAnimToPlay != null) ? NewAnimToPlay.NativePtr : IntPtr.Zero, bLooping);
		}

		// Token: 0x060043DC RID: 17372 RVA: 0x000610E3 File Offset: 0x0005F2E3
		public void Play(bool bLooping)
		{
			USkeletalMeshComponent.__Play_Internal(base.NativePtr, bLooping);
		}

		// Token: 0x060043DD RID: 17373 RVA: 0x000610F1 File Offset: 0x0005F2F1
		public void OverrideAnimationData(UAnimationAsset InAnimToPlay, bool bIsLooping = true, bool bIsPlaying = true, float Position = 0f, float PlayRate = 1f)
		{
			USkeletalMeshComponent.__OverrideAnimationData_Internal(base.NativePtr, (InAnimToPlay != null) ? InAnimToPlay.NativePtr : IntPtr.Zero, bIsLooping, bIsPlaying, Position, PlayRate);
		}

		// Token: 0x060043DE RID: 17374 RVA: 0x00061114 File Offset: 0x0005F314
		public void LinkAnimGraphByTag(FName InTag, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UAnimInstance> InClass)
		{
			USkeletalMeshComponent.__LinkAnimGraphByTag_Internal(base.NativePtr, InTag, InClass._NativePtr);
		}

		// Token: 0x060043DF RID: 17375 RVA: 0x00061128 File Offset: 0x0005F328
		public void LinkAnimClassLayers([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UAnimInstance> InClass)
		{
			USkeletalMeshComponent.__LinkAnimClassLayers_Internal(base.NativePtr, InClass._NativePtr);
		}

		// Token: 0x060043E0 RID: 17376 RVA: 0x0006113B File Offset: 0x0005F33B
		public void Kuro_UpdateRootMotionParams()
		{
			USkeletalMeshComponent.__Kuro_UpdateRootMotionParams_Internal(base.NativePtr);
		}

		// Token: 0x060043E1 RID: 17377 RVA: 0x00061148 File Offset: 0x0005F348
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

		// Token: 0x060043E2 RID: 17378 RVA: 0x00061185 File Offset: 0x0005F385
		public bool IsPlaying()
		{
			return USkeletalMeshComponent.__IsPlaying_Internal(base.NativePtr);
		}

		// Token: 0x060043E3 RID: 17379 RVA: 0x00061192 File Offset: 0x0005F392
		public bool IsClothingSimulationSuspended()
		{
			return USkeletalMeshComponent.__IsClothingSimulationSuspended_Internal(base.NativePtr);
		}

		// Token: 0x060043E4 RID: 17380 RVA: 0x0006119F File Offset: 0x0005F39F
		public bool IsBodyGravityEnabled(FName BoneName)
		{
			return USkeletalMeshComponent.__IsBodyGravityEnabled_Internal(base.NativePtr, BoneName);
		}

		// Token: 0x060043E5 RID: 17381 RVA: 0x000611AD File Offset: 0x0005F3AD
		public bool HasValidAnimationInstance()
		{
			return USkeletalMeshComponent.__HasValidAnimationInstance_Internal(base.NativePtr);
		}

		// Token: 0x060043E6 RID: 17382 RVA: 0x000611BA File Offset: 0x0005F3BA
		public float GetTeleportRotationThreshold()
		{
			return USkeletalMeshComponent.__GetTeleportRotationThreshold_Internal(base.NativePtr);
		}

		// Token: 0x060043E7 RID: 17383 RVA: 0x000611C7 File Offset: 0x0005F3C7
		public float GetTeleportDistanceThreshold()
		{
			return USkeletalMeshComponent.__GetTeleportDistanceThreshold_Internal(base.NativePtr);
		}

		// Token: 0x060043E8 RID: 17384 RVA: 0x000611D4 File Offset: 0x0005F3D4
		public float GetSkeletalMeshScreenSizeCullRatio()
		{
			return USkeletalMeshComponent.__GetSkeletalMeshScreenSizeCullRatio_Internal(base.NativePtr);
		}

		// Token: 0x060043E9 RID: 17385 RVA: 0x000611E1 File Offset: 0x0005F3E1
		public FVector GetSkeletalCenterOfMass()
		{
			return USkeletalMeshComponent.__GetSkeletalCenterOfMass_Internal(base.NativePtr);
		}

		// Token: 0x060043EA RID: 17386 RVA: 0x000611EE File Offset: 0x0005F3EE
		public bool GetRenderInKuroXRayPass()
		{
			return USkeletalMeshComponent.__GetRenderInKuroXRayPass_Internal(base.NativePtr);
		}

		// Token: 0x060043EB RID: 17387 RVA: 0x000611FB File Offset: 0x0005F3FB
		public FVectorDouble GetRefBoneWorldPosition(FName BoneName)
		{
			return USkeletalMeshComponent.__GetRefBoneWorldPosition_Internal(base.NativePtr, BoneName);
		}

		// Token: 0x060043EC RID: 17388 RVA: 0x00061209 File Offset: 0x0005F409
		public FVectorDouble GetRefBoneComponentPosition(FName BoneName)
		{
			return USkeletalMeshComponent.__GetRefBoneComponentPosition_Internal(base.NativePtr, BoneName);
		}

		// Token: 0x060043ED RID: 17389 RVA: 0x00061217 File Offset: 0x0005F417
		public UAnimInstance GetPostProcessInstance()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimInstance>(USkeletalMeshComponent.__GetPostProcessInstance_Internal(base.NativePtr));
		}

		// Token: 0x060043EE RID: 17390 RVA: 0x00061229 File Offset: 0x0005F429
		public float GetPosition()
		{
			return USkeletalMeshComponent.__GetPosition_Internal(base.NativePtr);
		}

		// Token: 0x060043EF RID: 17391 RVA: 0x00061236 File Offset: 0x0005F436
		public float GetPlayRate()
		{
			return USkeletalMeshComponent.__GetPlayRate_Internal(base.NativePtr);
		}

		// Token: 0x060043F0 RID: 17392 RVA: 0x00061243 File Offset: 0x0005F443
		[NullableContext(1)]
		public TArray<string> GetMorphTargetNames()
		{
			return new TArray<string>(USkeletalMeshComponent.__GetMorphTargetNames_Internal(base.NativePtr), null);
		}

		// Token: 0x060043F1 RID: 17393 RVA: 0x00061256 File Offset: 0x0005F456
		public float GetMorphTarget(FName MorphTargetName)
		{
			return USkeletalMeshComponent.__GetMorphTarget_Internal(base.NativePtr, MorphTargetName);
		}

		// Token: 0x060043F2 RID: 17394 RVA: 0x00061264 File Offset: 0x0005F464
		public UAnimInstance GetLinkedAnimLayerInstanceByGroup(FName InGroup)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimInstance>(USkeletalMeshComponent.__GetLinkedAnimLayerInstanceByGroup_Internal(base.NativePtr, InGroup));
		}

		// Token: 0x060043F3 RID: 17395 RVA: 0x00061277 File Offset: 0x0005F477
		public UAnimInstance GetLinkedAnimLayerInstanceByClass([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UAnimInstance> InClass)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimInstance>(USkeletalMeshComponent.__GetLinkedAnimLayerInstanceByClass_Internal(base.NativePtr, InClass._NativePtr));
		}

		// Token: 0x060043F4 RID: 17396 RVA: 0x0006128F File Offset: 0x0005F48F
		public void GetLinkedAnimGraphInstancesByTag(FName InTag, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<UAnimInstance> OutLinkedInstances)
		{
			USkeletalMeshComponent.__GetLinkedAnimGraphInstancesByTag_Internal(base.NativePtr, InTag, (OutLinkedInstances ?? new TArray<UAnimInstance>()).NativePtr);
		}

		// Token: 0x060043F5 RID: 17397 RVA: 0x000612AD File Offset: 0x0005F4AD
		public UAnimInstance GetLinkedAnimGraphInstanceByTag(FName InTag)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimInstance>(USkeletalMeshComponent.__GetLinkedAnimGraphInstanceByTag_Internal(base.NativePtr, InTag));
		}

		// Token: 0x060043F6 RID: 17398 RVA: 0x000612C0 File Offset: 0x0005F4C0
		public bool GetKuroXRayPenetrateCharacters()
		{
			return USkeletalMeshComponent.__GetKuroXRayPenetrateCharacters_Internal(base.NativePtr);
		}

		// Token: 0x060043F7 RID: 17399 RVA: 0x000612CD File Offset: 0x0005F4CD
		public float GetKuroXRayOutlineWidth()
		{
			return USkeletalMeshComponent.__GetKuroXRayOutlineWidth_Internal(base.NativePtr);
		}

		// Token: 0x060043F8 RID: 17400 RVA: 0x000612DA File Offset: 0x0005F4DA
		public UMaterialInterface GetKuroXRayOutlineMaterial()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInterface>(USkeletalMeshComponent.__GetKuroXRayOutlineMaterial_Internal(base.NativePtr));
		}

		// Token: 0x060043F9 RID: 17401 RVA: 0x000612EC File Offset: 0x0005F4EC
		public UMaterialInterface GetKuroXRayMaterial()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInterface>(USkeletalMeshComponent.__GetKuroXRayMaterial_Internal(base.NativePtr));
		}

		// Token: 0x060043FA RID: 17402 RVA: 0x000612FE File Offset: 0x0005F4FE
		public float GetKuroXRayDistance()
		{
			return USkeletalMeshComponent.__GetKuroXRayDistance_Internal(base.NativePtr);
		}

		// Token: 0x060043FB RID: 17403 RVA: 0x0006130B File Offset: 0x0005F50B
		public FVector4 GetKuroXRayColor()
		{
			return USkeletalMeshComponent.__GetKuroXRayColor_Internal(base.NativePtr);
		}

		// Token: 0x060043FC RID: 17404 RVA: 0x00061318 File Offset: 0x0005F518
		public bool GetKuroSkipAnimNotifies()
		{
			return USkeletalMeshComponent.__GetKuroSkipAnimNotifies_Internal(base.NativePtr);
		}

		// Token: 0x060043FD RID: 17405 RVA: 0x00061325 File Offset: 0x0005F525
		public bool GetEnableOverrideSkeletalMeshScreenSizeCullRatio()
		{
			return USkeletalMeshComponent.__GetEnableOverrideSkeletalMeshScreenSizeCullRatio_Internal(base.NativePtr);
		}

		// Token: 0x060043FE RID: 17406 RVA: 0x00061332 File Offset: 0x0005F532
		public bool GetDisablePostProcessBlueprint()
		{
			return USkeletalMeshComponent.__GetDisablePostProcessBlueprint_Internal(base.NativePtr);
		}

		// Token: 0x060043FF RID: 17407 RVA: 0x0006133F File Offset: 0x0005F53F
		public bool GetDisableAnimCurves()
		{
			return USkeletalMeshComponent.__GetDisableAnimCurves_Internal(base.NativePtr);
		}

		// Token: 0x06004400 RID: 17408 RVA: 0x0006134C File Offset: 0x0005F54C
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

		// Token: 0x06004401 RID: 17409 RVA: 0x00061388 File Offset: 0x0005F588
		public float GetClothMaxDistanceScale()
		{
			return USkeletalMeshComponent.__GetClothMaxDistanceScale_Internal(base.NativePtr);
		}

		// Token: 0x06004402 RID: 17410 RVA: 0x00061395 File Offset: 0x0005F595
		public float GetBoneMass(FName BoneName = default(FName), bool bScaleMass = true)
		{
			return USkeletalMeshComponent.__GetBoneMass_Internal(base.NativePtr, BoneName, bScaleMass);
		}

		// Token: 0x06004403 RID: 17411 RVA: 0x000613A4 File Offset: 0x0005F5A4
		public byte GetAnimInstanceUpdateState()
		{
			return USkeletalMeshComponent.__GetAnimInstanceUpdateState_Internal(base.NativePtr);
		}

		// Token: 0x06004404 RID: 17412 RVA: 0x000613B1 File Offset: 0x0005F5B1
		public UAnimInstance GetAnimInstance()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimInstance>(USkeletalMeshComponent.__GetAnimInstance_Internal(base.NativePtr));
		}

		// Token: 0x06004405 RID: 17413 RVA: 0x000613C3 File Offset: 0x0005F5C3
		public UClassStackOnlyPtr GetAnimClass()
		{
			return USkeletalMeshComponent.__GetAnimClass_Internal(base.NativePtr);
		}

		// Token: 0x06004406 RID: 17414 RVA: 0x000613D5 File Offset: 0x0005F5D5
		[NullableContext(0)]
		public TEnumAsByte<EAnimationMode> GetAnimationMode()
		{
			return USkeletalMeshComponent.__GetAnimationMode_Internal(base.NativePtr);
		}

		// Token: 0x06004407 RID: 17415 RVA: 0x000613E2 File Offset: 0x0005F5E2
		public bool GetAllowRigidBodyAnimNode()
		{
			return USkeletalMeshComponent.__GetAllowRigidBodyAnimNode_Internal(base.NativePtr);
		}

		// Token: 0x06004408 RID: 17416 RVA: 0x000613EF File Offset: 0x0005F5EF
		public bool GetAllowedAnimCurveEvaluate()
		{
			return USkeletalMeshComponent.__GetAllowedAnimCurveEvaluate_Internal(base.NativePtr);
		}

		// Token: 0x06004409 RID: 17417 RVA: 0x000613FC File Offset: 0x0005F5FC
		public void ForceUpdateAnimation(float DeltaTime, bool bNeedsValidRootMotion)
		{
			USkeletalMeshComponent.__ForceUpdateAnimation_Internal(base.NativePtr, DeltaTime, bNeedsValidRootMotion);
		}

		// Token: 0x0600440A RID: 17418 RVA: 0x0006140B File Offset: 0x0005F60B
		public void ForceClothNextUpdateTeleportAndReset()
		{
			USkeletalMeshComponent.__ForceClothNextUpdateTeleportAndReset_Internal(base.NativePtr);
		}

		// Token: 0x0600440B RID: 17419 RVA: 0x00061418 File Offset: 0x0005F618
		public void ForceClothNextUpdateTeleport()
		{
			USkeletalMeshComponent.__ForceClothNextUpdateTeleport_Internal(base.NativePtr);
		}

		// Token: 0x0600440C RID: 17420 RVA: 0x00061425 File Offset: 0x0005F625
		public FName FindConstraintBoneName(int ConstraintIndex)
		{
			return USkeletalMeshComponent.__FindConstraintBoneName_Internal(base.NativePtr, ConstraintIndex);
		}

		// Token: 0x0600440D RID: 17421 RVA: 0x00061433 File Offset: 0x0005F633
		public void EnableTickGetHeadBonePos(bool Enable)
		{
			USkeletalMeshComponent.__EnableTickGetHeadBonePos_Internal(base.NativePtr, Enable);
		}

		// Token: 0x0600440E RID: 17422 RVA: 0x00061441 File Offset: 0x0005F641
		public bool DisableWaterForToon()
		{
			return USkeletalMeshComponent.__DisableWaterForToon_Internal(base.NativePtr);
		}

		// Token: 0x0600440F RID: 17423 RVA: 0x0006144E File Offset: 0x0005F64E
		public void DestroyKuroClothSimulation()
		{
			USkeletalMeshComponent.__DestroyKuroClothSimulation_Internal(base.NativePtr);
		}

		// Token: 0x06004410 RID: 17424 RVA: 0x0006145B File Offset: 0x0005F65B
		public void DealCompleteParallelEvaluation()
		{
			USkeletalMeshComponent.__DealCompleteParallelEvaluation_Internal(base.NativePtr);
		}

		// Token: 0x06004411 RID: 17425 RVA: 0x00061468 File Offset: 0x0005F668
		public void CreateKuroClothSimulation()
		{
			USkeletalMeshComponent.__CreateKuroClothSimulation_Internal(base.NativePtr);
		}

		// Token: 0x06004412 RID: 17426 RVA: 0x00061475 File Offset: 0x0005F675
		public void ClearMorphTargets()
		{
			USkeletalMeshComponent.__ClearMorphTargets_Internal(base.NativePtr);
		}

		// Token: 0x06004413 RID: 17427 RVA: 0x00061482 File Offset: 0x0005F682
		public void BreakConstraint(FVector Impulse, FVector HitLocation, FName InBoneName)
		{
			USkeletalMeshComponent.__BreakConstraint_Internal(base.NativePtr, Impulse, HitLocation, InBoneName);
		}

		// Token: 0x06004414 RID: 17428 RVA: 0x00061492 File Offset: 0x0005F692
		public void BindClothToMasterPoseComponent()
		{
			USkeletalMeshComponent.__BindClothToMasterPoseComponent_Internal(base.NativePtr);
		}

		// Token: 0x06004415 RID: 17429 RVA: 0x0006149F File Offset: 0x0005F69F
		public bool AnimPoseTickedThisFrame()
		{
			return USkeletalMeshComponent.__AnimPoseTickedThisFrame_Internal(base.NativePtr);
		}

		// Token: 0x06004416 RID: 17430 RVA: 0x000614AC File Offset: 0x0005F6AC
		public void AllowAnimCurveEvaluation(FName NameOfCurve, bool bAllow)
		{
			USkeletalMeshComponent.__AllowAnimCurveEvaluation_Internal(base.NativePtr, NameOfCurve, bAllow);
		}

		// Token: 0x06004417 RID: 17431 RVA: 0x000614BB File Offset: 0x0005F6BB
		public void AddImpulseToAllBodiesBelow(FVector Impulse, FName BoneName = default(FName), bool bVelChange = false, bool bIncludeSelf = true)
		{
			USkeletalMeshComponent.__AddImpulseToAllBodiesBelow_Internal(base.NativePtr, Impulse, BoneName, bVelChange, bIncludeSelf);
		}

		// Token: 0x06004418 RID: 17432 RVA: 0x000614CD File Offset: 0x0005F6CD
		public void AddForceToAllBodiesBelow(FVector Force, FName BoneName = default(FName), bool bAccelChange = false, bool bIncludeSelf = true)
		{
			USkeletalMeshComponent.__AddForceToAllBodiesBelow_Internal(base.NativePtr, Force, BoneName, bAccelChange, bIncludeSelf);
		}

		// Token: 0x06004419 RID: 17433 RVA: 0x000614E0 File Offset: 0x0005F6E0
		public unsafe void AccumulateAllBodiesBelowPhysicsBlendWeight(in FName InBoneName, float AddPhysicsBlendWeight, bool bSkipCustomPhysicsType = false)
		{
			fixed (FName* ptr = &InBoneName)
			{
				void* ptr2 = (void*)ptr;
				USkeletalMeshComponent.__AccumulateAllBodiesBelowPhysicsBlendWeight_Internal(base.NativePtr, InBoneName, AddPhysicsBlendWeight, bSkipCustomPhysicsType);
			}
		}

		// Token: 0x0600441A RID: 17434
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateLODStatus_Outside_Internal(IntPtr @this);

		// Token: 0x0600441B RID: 17435
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnlockKuroEvaluation_Internal(IntPtr @this);

		// Token: 0x0600441C RID: 17436
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnlinkAnimClassLayers_Internal(IntPtr @this, IntPtr InClass);

		// Token: 0x0600441D RID: 17437
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnbindClothFromMasterPoseComponent_Internal(IntPtr @this, bool bRestoreSimulationSpace);

		// Token: 0x0600441E RID: 17438
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ToggleDisablePostProcessBlueprint_Internal(IntPtr @this);

		// Token: 0x0600441F RID: 17439
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __TickSoftAssetLoading_Internal(IntPtr @this);

		// Token: 0x06004420 RID: 17440
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __TestGetBoneSpaceTransforms_Internal(IntPtr @this);

		// Token: 0x06004421 RID: 17441
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __TermBodiesBelow_Internal(IntPtr @this, FName ParentBoneName);

		// Token: 0x06004422 RID: 17442
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SuspendClothingSimulation_Internal(IntPtr @this);

		// Token: 0x06004423 RID: 17443
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Stop_Internal(IntPtr @this);

		// Token: 0x06004424 RID: 17444
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUseProxyDataBuffer_Internal(IntPtr @this, bool Use);

		// Token: 0x06004425 RID: 17445
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUpdateClothInEditor_Internal(IntPtr @this, bool NewUpdateState);

		// Token: 0x06004426 RID: 17446
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUpdateAnimationInEditor_Internal(IntPtr @this, bool NewUpdateState);

		// Token: 0x06004427 RID: 17447
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTeleportRotationThreshold_Internal(IntPtr @this, float Threshold);

		// Token: 0x06004428 RID: 17448
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTeleportDistanceThreshold_Internal(IntPtr @this, float Threshold);

		// Token: 0x06004429 RID: 17449
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSkeletalMeshScreenSizeCullRatio_Internal(IntPtr @this, float Value);

		// Token: 0x0600442A RID: 17450
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRenderInKuroXRayPass_Internal(IntPtr @this, bool bValue);

		// Token: 0x0600442B RID: 17451
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPosition_Internal(IntPtr @this, float InPos, bool bFireNotifies);

		// Token: 0x0600442C RID: 17452
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPlayRate_Internal(IntPtr @this, float Rate);

		// Token: 0x0600442D RID: 17453
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPhysicsBlendWeight_Internal(IntPtr @this, float PhysicsBlendWeight);

		// Token: 0x0600442E RID: 17454
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNotifyRigidBodyCollisionBelow_Internal(IntPtr @this, bool bNewNotifyRigidBodyCollision, FName BoneName, bool bIncludeSelf);

		// Token: 0x0600442F RID: 17455
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMorphTarget_Internal(IntPtr @this, FName MorphTargetName, float Value, bool bRemoveZeroWeight);

		// Token: 0x06004430 RID: 17456
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroXRayPenetrateCharacters_Internal(IntPtr @this, bool bValue);

		// Token: 0x06004431 RID: 17457
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroXRayOutlineWidth_Internal(IntPtr @this, float InWidth);

		// Token: 0x06004432 RID: 17458
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroXRayOutlineMaterial_Internal(IntPtr @this, IntPtr InMaterial);

		// Token: 0x06004433 RID: 17459
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroXRayMaterial_Internal(IntPtr @this, IntPtr InMaterial);

		// Token: 0x06004434 RID: 17460
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroXRayDistance_Internal(IntPtr @this, float InDistance);

		// Token: 0x06004435 RID: 17461
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroXRayColor_Internal(IntPtr @this, FLinearColor InKuroXRayColor);

		// Token: 0x06004436 RID: 17462
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroSkipAnimNotifies_Internal(IntPtr @this, bool bInSkip);

		// Token: 0x06004437 RID: 17463
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetForceDisableBoneBounds_Internal(IntPtr @this, bool InForceDisableBoneBounds);

		// Token: 0x06004438 RID: 17464
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEnablePhysicsBlending_Internal(IntPtr @this, bool bNewBlendPhysics);

		// Token: 0x06004439 RID: 17465
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEnableOverrideSkeletalMeshScreenSizeCullRatio_Internal(IntPtr @this, bool bValue);

		// Token: 0x0600443A RID: 17466
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEnableGravityOnAllBodiesBelow_Internal(IntPtr @this, bool bEnableGravity, FName BoneName, bool bIncludeSelf);

		// Token: 0x0600443B RID: 17467
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEnableBodyGravity_Internal(IntPtr @this, bool bEnableGravity, FName BoneName);

		// Token: 0x0600443C RID: 17468
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDynamicMaterialScalarParameterValue_Internal(IntPtr @this, int InMatIndex, in FName InParamName, float InValue);

		// Token: 0x0600443D RID: 17469
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDisableWaterForToon_Internal(IntPtr @this, bool bValue);

		// Token: 0x0600443E RID: 17470
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDisablePostProcessBlueprint_Internal(IntPtr @this, bool bInDisablePostProcess);

		// Token: 0x0600443F RID: 17471
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDisableAnimCurves_Internal(IntPtr @this, bool bInDisableAnimCurves);

		// Token: 0x06004440 RID: 17472
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDelayCompleteParallelEvaluation_Internal(IntPtr @this);

		// Token: 0x06004441 RID: 17473
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetConstraintProfileForAll_Internal(IntPtr @this, FName ProfileName, bool bDefaultIfNotFound);

		// Token: 0x06004442 RID: 17474
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetConstraintProfile_Internal(IntPtr @this, FName JointName, FName ProfileName, bool bDefaultIfNotFound);

		// Token: 0x06004443 RID: 17475
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetClothMaxDistanceScale_Internal(IntPtr @this, float Scale);

		// Token: 0x06004444 RID: 17476
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBodyNotifyRigidBodyCollision_Internal(IntPtr @this, bool bNewNotifyRigidBodyCollision, FName BoneName);

		// Token: 0x06004445 RID: 17477
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAnimClass_Internal(IntPtr @this, IntPtr NewClass);

		// Token: 0x06004446 RID: 17478
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAnimationRibbonAsset_Internal(IntPtr @this, IntPtr NewRibbonAsset);

		// Token: 0x06004447 RID: 17479
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAnimationMode_Internal(IntPtr @this, TEnumAsByte<EAnimationMode> InAnimationMode);

		// Token: 0x06004448 RID: 17480
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAnimation_Internal(IntPtr @this, IntPtr NewAnimToPlay);

		// Token: 0x06004449 RID: 17481
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAngularLimits_Internal(IntPtr @this, FName InBoneName, float Swing1LimitAngle, float TwistLimitAngle, float Swing2LimitAngle);

		// Token: 0x0600444A RID: 17482
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAllowRigidBodyAnimNode_Internal(IntPtr @this, bool bInAllow, bool bReinitAnim);

		// Token: 0x0600444B RID: 17483
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAllowedAnimCurvesEvaluation_Internal(IntPtr @this, IntPtr List, bool bAllow);

		// Token: 0x0600444C RID: 17484
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAllowAnimCurveEvaluation_Internal(IntPtr @this, bool bInAllow);

		// Token: 0x0600444D RID: 17485
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAllMotorsAngularVelocityDrive_Internal(IntPtr @this, bool bEnableSwingDrive, bool bEnableTwistDrive, bool bSkipCustomPhysicsType);

		// Token: 0x0600444E RID: 17486
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAllMotorsAngularPositionDrive_Internal(IntPtr @this, bool bEnableSwingDrive, bool bEnableTwistDrive, bool bSkipCustomPhysicsType);

		// Token: 0x0600444F RID: 17487
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAllMotorsAngularDriveParams_Internal(IntPtr @this, float InSpring, float InDamping, float InForceLimit, bool bSkipCustomPhysicsType);

		// Token: 0x06004450 RID: 17488
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAllBodiesSimulatePhysics_Internal(IntPtr @this, bool bNewSimulate);

		// Token: 0x06004451 RID: 17489
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAllBodiesPhysicsBlendWeight_Internal(IntPtr @this, float PhysicsBlendWeight, bool bSkipCustomPhysicsType);

		// Token: 0x06004452 RID: 17490
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAllBodiesBelowSimulatePhysics_Internal(IntPtr @this, in FName InBoneName, bool bNewSimulate, bool bIncludeSelf);

		// Token: 0x06004453 RID: 17491
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAllBodiesBelowPhysicsBlendWeight_Internal(IntPtr @this, in FName InBoneName, float PhysicsBlendWeight, bool bSkipCustomPhysicsType, bool bIncludeSelf);

		// Token: 0x06004454 RID: 17492
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResumeClothingSimulation_Internal(IntPtr @this);

		// Token: 0x06004455 RID: 17493
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetEvaluationDebugStatistics_Internal(IntPtr @this);

		// Token: 0x06004456 RID: 17494
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetClothTeleportMode_Internal(IntPtr @this);

		// Token: 0x06004457 RID: 17495
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetAllowedAnimCurveEvaluation_Internal(IntPtr @this);

		// Token: 0x06004458 RID: 17496
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetAllBodiesSimulatePhysics_Internal(IntPtr @this);

		// Token: 0x06004459 RID: 17497
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RegisterKuroCharPostUpdateTickFun_Internal(IntPtr @this, bool bRegister);

		// Token: 0x0600445A RID: 17498
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RecreateKuroCloth_Internal(IntPtr @this);

		// Token: 0x0600445B RID: 17499
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PlayAnimation_Internal(IntPtr @this, IntPtr NewAnimToPlay, bool bLooping);

		// Token: 0x0600445C RID: 17500
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Play_Internal(IntPtr @this, bool bLooping);

		// Token: 0x0600445D RID: 17501
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OverrideAnimationData_Internal(IntPtr @this, IntPtr InAnimToPlay, bool bIsLooping, bool bIsPlaying, float Position, float PlayRate);

		// Token: 0x0600445E RID: 17502
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LinkAnimGraphByTag_Internal(IntPtr @this, FName InTag, IntPtr InClass);

		// Token: 0x0600445F RID: 17503
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LinkAnimClassLayers_Internal(IntPtr @this, IntPtr InClass);

		// Token: 0x06004460 RID: 17504
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Kuro_UpdateRootMotionParams_Internal(IntPtr @this);

		// Token: 0x06004461 RID: 17505
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_GetClosestPointOnPhysicsAsset_Internal(IntPtr @this, in FVector WorldPosition, ref FVector ClosestWorldPosition, ref FVector Normal, ref FName BoneName, ref float Distance);

		// Token: 0x06004462 RID: 17506
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsPlaying_Internal(IntPtr @this);

		// Token: 0x06004463 RID: 17507
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsClothingSimulationSuspended_Internal(IntPtr @this);

		// Token: 0x06004464 RID: 17508
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsBodyGravityEnabled_Internal(IntPtr @this, FName BoneName);

		// Token: 0x06004465 RID: 17509
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasValidAnimationInstance_Internal(IntPtr @this);

		// Token: 0x06004466 RID: 17510
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetTeleportRotationThreshold_Internal(IntPtr @this);

		// Token: 0x06004467 RID: 17511
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetTeleportDistanceThreshold_Internal(IntPtr @this);

		// Token: 0x06004468 RID: 17512
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetSkeletalMeshScreenSizeCullRatio_Internal(IntPtr @this);

		// Token: 0x06004469 RID: 17513
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetSkeletalCenterOfMass_Internal(IntPtr @this);

		// Token: 0x0600446A RID: 17514
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetRenderInKuroXRayPass_Internal(IntPtr @this);

		// Token: 0x0600446B RID: 17515
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __GetRefBoneWorldPosition_Internal(IntPtr @this, FName BoneName);

		// Token: 0x0600446C RID: 17516
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __GetRefBoneComponentPosition_Internal(IntPtr @this, FName BoneName);

		// Token: 0x0600446D RID: 17517
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetPostProcessInstance_Internal(IntPtr @this);

		// Token: 0x0600446E RID: 17518
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetPosition_Internal(IntPtr @this);

		// Token: 0x0600446F RID: 17519
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetPlayRate_Internal(IntPtr @this);

		// Token: 0x06004470 RID: 17520
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetMorphTargetNames_Internal(IntPtr @this);

		// Token: 0x06004471 RID: 17521
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetMorphTarget_Internal(IntPtr @this, FName MorphTargetName);

		// Token: 0x06004472 RID: 17522
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetLinkedAnimLayerInstanceByGroup_Internal(IntPtr @this, FName InGroup);

		// Token: 0x06004473 RID: 17523
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetLinkedAnimLayerInstanceByClass_Internal(IntPtr @this, IntPtr InClass);

		// Token: 0x06004474 RID: 17524
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetLinkedAnimGraphInstancesByTag_Internal(IntPtr @this, FName InTag, IntPtr OutLinkedInstances);

		// Token: 0x06004475 RID: 17525
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetLinkedAnimGraphInstanceByTag_Internal(IntPtr @this, FName InTag);

		// Token: 0x06004476 RID: 17526
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetKuroXRayPenetrateCharacters_Internal(IntPtr @this);

		// Token: 0x06004477 RID: 17527
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetKuroXRayOutlineWidth_Internal(IntPtr @this);

		// Token: 0x06004478 RID: 17528
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetKuroXRayOutlineMaterial_Internal(IntPtr @this);

		// Token: 0x06004479 RID: 17529
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetKuroXRayMaterial_Internal(IntPtr @this);

		// Token: 0x0600447A RID: 17530
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetKuroXRayDistance_Internal(IntPtr @this);

		// Token: 0x0600447B RID: 17531
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector4 __GetKuroXRayColor_Internal(IntPtr @this);

		// Token: 0x0600447C RID: 17532
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetKuroSkipAnimNotifies_Internal(IntPtr @this);

		// Token: 0x0600447D RID: 17533
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetEnableOverrideSkeletalMeshScreenSizeCullRatio_Internal(IntPtr @this);

		// Token: 0x0600447E RID: 17534
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetDisablePostProcessBlueprint_Internal(IntPtr @this);

		// Token: 0x0600447F RID: 17535
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetDisableAnimCurves_Internal(IntPtr @this);

		// Token: 0x06004480 RID: 17536
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetCurrentJointAngles_Internal(IntPtr @this, FName InBoneName, ref float Swing1Angle, ref float TwistAngle, ref float Swing2Angle);

		// Token: 0x06004481 RID: 17537
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetClothMaxDistanceScale_Internal(IntPtr @this);

		// Token: 0x06004482 RID: 17538
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetBoneMass_Internal(IntPtr @this, FName BoneName, bool bScaleMass);

		// Token: 0x06004483 RID: 17539
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern byte __GetAnimInstanceUpdateState_Internal(IntPtr @this);

		// Token: 0x06004484 RID: 17540
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAnimInstance_Internal(IntPtr @this);

		// Token: 0x06004485 RID: 17541
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAnimClass_Internal(IntPtr @this);

		// Token: 0x06004486 RID: 17542
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern TEnumAsByte<EAnimationMode> __GetAnimationMode_Internal(IntPtr @this);

		// Token: 0x06004487 RID: 17543
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetAllowRigidBodyAnimNode_Internal(IntPtr @this);

		// Token: 0x06004488 RID: 17544
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetAllowedAnimCurveEvaluate_Internal(IntPtr @this);

		// Token: 0x06004489 RID: 17545
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ForceUpdateAnimation_Internal(IntPtr @this, float DeltaTime, bool bNeedsValidRootMotion);

		// Token: 0x0600448A RID: 17546
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ForceClothNextUpdateTeleportAndReset_Internal(IntPtr @this);

		// Token: 0x0600448B RID: 17547
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ForceClothNextUpdateTeleport_Internal(IntPtr @this);

		// Token: 0x0600448C RID: 17548
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FName __FindConstraintBoneName_Internal(IntPtr @this, int ConstraintIndex);

		// Token: 0x0600448D RID: 17549
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EnableTickGetHeadBonePos_Internal(IntPtr @this, bool Enable);

		// Token: 0x0600448E RID: 17550
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __DisableWaterForToon_Internal(IntPtr @this);

		// Token: 0x0600448F RID: 17551
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DestroyKuroClothSimulation_Internal(IntPtr @this);

		// Token: 0x06004490 RID: 17552
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DealCompleteParallelEvaluation_Internal(IntPtr @this);

		// Token: 0x06004491 RID: 17553
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CreateKuroClothSimulation_Internal(IntPtr @this);

		// Token: 0x06004492 RID: 17554
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearMorphTargets_Internal(IntPtr @this);

		// Token: 0x06004493 RID: 17555
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BreakConstraint_Internal(IntPtr @this, FVector Impulse, FVector HitLocation, FName InBoneName);

		// Token: 0x06004494 RID: 17556
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BindClothToMasterPoseComponent_Internal(IntPtr @this);

		// Token: 0x06004495 RID: 17557
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __AnimPoseTickedThisFrame_Internal(IntPtr @this);

		// Token: 0x06004496 RID: 17558
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AllowAnimCurveEvaluation_Internal(IntPtr @this, FName NameOfCurve, bool bAllow);

		// Token: 0x06004497 RID: 17559
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddImpulseToAllBodiesBelow_Internal(IntPtr @this, FVector Impulse, FName BoneName, bool bVelChange, bool bIncludeSelf);

		// Token: 0x06004498 RID: 17560
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddForceToAllBodiesBelow_Internal(IntPtr @this, FVector Force, FName BoneName, bool bAccelChange, bool bIncludeSelf);

		// Token: 0x06004499 RID: 17561
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AccumulateAllBodiesBelowPhysicsBlendWeight_Internal(IntPtr @this, in FName InBoneName, float AddPhysicsBlendWeight, bool bSkipCustomPhysicsType);

		// Token: 0x0600449A RID: 17562 RVA: 0x00061503 File Offset: 0x0005F703
		static USkeletalMeshComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SkeletalMeshComponent");
		}

		// Token: 0x0600449B RID: 17563 RVA: 0x00061511 File Offset: 0x0005F711
		protected USkeletalMeshComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001A13 RID: 6675
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.SkeletalMeshComponent";

		// Token: 0x04001A14 RID: 6676
		private static IntPtr _ClassPtr;

		// Token: 0x04001A15 RID: 6677
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001A16 RID: 6678
		internal static int __PropertyOffset_AnimBlueprintGeneratedClass;

		// Token: 0x04001A17 RID: 6679
		internal static int __PropertyOffset_AnimClass;

		// Token: 0x04001A18 RID: 6680
		internal static int __PropertyOffset_AnimScriptInstance;

		// Token: 0x04001A19 RID: 6681
		internal static int __PropertyOffset_PostProcessAnimInstance;

		// Token: 0x04001A1A RID: 6682
		internal static int __PropertyOffset_KuroPostProcessAnimBlueprint;

		// Token: 0x04001A1B RID: 6683
		internal static int __PropertyOffset_PredictionAnimInstance;

		// Token: 0x04001A1C RID: 6684
		internal static int __PropertyOffset_AnimationData;

		// Token: 0x04001A1D RID: 6685
		private FSingleAnimationPlayData _AnimationData;

		// Token: 0x04001A1E RID: 6686
		internal static int __PropertyOffset_bKuroForceShears;

		// Token: 0x04001A1F RID: 6687
		internal static int __PropertyOffset_RootBoneTranslation;

		// Token: 0x04001A20 RID: 6688
		internal static int __PropertyOffset_LineCheckBoundsScale;

		// Token: 0x04001A21 RID: 6689
		internal static int __PropertyOffset_bRenderInKuroXRayPass;

		// Token: 0x04001A22 RID: 6690
		internal static byte __PropertyMask_bRenderInKuroXRayPass;

		// Token: 0x04001A23 RID: 6691
		internal static int __PropertyOffset_KuroXRayColor;

		// Token: 0x04001A24 RID: 6692
		internal static int __PropertyOffset_KuroXRayMaterial;

		// Token: 0x04001A25 RID: 6693
		internal static int __PropertyOffset_KuroXRayOutlineMaterial;

		// Token: 0x04001A26 RID: 6694
		internal static int __PropertyOffset_KuroXRayDistance;

		// Token: 0x04001A27 RID: 6695
		internal static int __PropertyOffset_KuroXRayOutlineWidth;

		// Token: 0x04001A28 RID: 6696
		internal static int __PropertyOffset_bKuroXRayPenetrateCharacters;

		// Token: 0x04001A29 RID: 6697
		internal static byte __PropertyMask_bKuroXRayPenetrateCharacters;

		// Token: 0x04001A2A RID: 6698
		internal static int __PropertyOffset_bKuroXRayPenetrateCharactersFromDA;

		// Token: 0x04001A2B RID: 6699
		internal static byte __PropertyMask_bKuroXRayPenetrateCharactersFromDA;

		// Token: 0x04001A2C RID: 6700
		internal static int __PropertyOffset_bKuroXRayPenetrateCharactersFromDAValid;

		// Token: 0x04001A2D RID: 6701
		internal static byte __PropertyMask_bKuroXRayPenetrateCharactersFromDAValid;

		// Token: 0x04001A2E RID: 6702
		internal static int __PropertyOffset_KuroMaterialControllerUpdateGroupMode;

		// Token: 0x04001A2F RID: 6703
		internal static int __PropertyOffset_KuroMaterialControllerCustomUpdateGroup;

		// Token: 0x04001A30 RID: 6704
		internal static int __PropertyOffset_bDisableWaterForToon;

		// Token: 0x04001A31 RID: 6705
		internal static byte __PropertyMask_bDisableWaterForToon;

		// Token: 0x04001A32 RID: 6706
		internal static int __PropertyOffset_bOverrideSkeletalMeshScreenSizeCullRatio;

		// Token: 0x04001A33 RID: 6707
		internal static byte __PropertyMask_bOverrideSkeletalMeshScreenSizeCullRatio;

		// Token: 0x04001A34 RID: 6708
		internal static int __PropertyOffset_SkeletalMeshScreenSizeCullRatio;

		// Token: 0x04001A35 RID: 6709
		internal static int __PropertyOffset_KuroAnimInstanceLod;

		// Token: 0x04001A36 RID: 6710
		internal static int __PropertyOffset_KuroLodMask;

		// Token: 0x04001A37 RID: 6711
		internal static int __PropertyOffset_KuroClothWind;

		// Token: 0x04001A38 RID: 6712
		internal static int __PropertyOffset_KuroClothCapsuleHalfHeightOffset;

		// Token: 0x04001A39 RID: 6713
		internal static int __PropertyOffset_KuroClothCapsuleRadiusOffset;

		// Token: 0x04001A3A RID: 6714
		internal static int __PropertyOffset_bKuroSkipAnimNotifies;

		// Token: 0x04001A3B RID: 6715
		internal static byte __PropertyMask_bKuroSkipAnimNotifies;

		// Token: 0x04001A3C RID: 6716
		internal static int __PropertyOffset_LinkedInstances;

		// Token: 0x04001A3D RID: 6717
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UAnimInstance> _LinkedInstances;

		// Token: 0x04001A3E RID: 6718
		internal static int __PropertyOffset_CachedBoneSpaceTransforms;

		// Token: 0x04001A3F RID: 6719
		private TArray<FTransform> _CachedBoneSpaceTransforms;

		// Token: 0x04001A40 RID: 6720
		internal static int __PropertyOffset_CachedComponentSpaceTransforms;

		// Token: 0x04001A41 RID: 6721
		private TArray<FTransform> _CachedComponentSpaceTransforms;

		// Token: 0x04001A42 RID: 6722
		internal static int __PropertyOffset_BoneSpaceShears;

		// Token: 0x04001A43 RID: 6723
		private TArray<FVector> _BoneSpaceShears;

		// Token: 0x04001A44 RID: 6724
		internal static int __PropertyOffset_CachedBoneSpaceShears;

		// Token: 0x04001A45 RID: 6725
		private TArray<FVector> _CachedBoneSpaceShears;

		// Token: 0x04001A46 RID: 6726
		internal static int __PropertyOffset_CachedComponentSpaceShears;

		// Token: 0x04001A47 RID: 6727
		private TArray<FVector> _CachedComponentSpaceShears;

		// Token: 0x04001A48 RID: 6728
		internal static int __PropertyOffset_GlobalAnimRateScale;

		// Token: 0x04001A49 RID: 6729
		internal static int __PropertyOffset_AnimationMode;

		// Token: 0x04001A4A RID: 6730
		internal static int __PropertyOffset_bDisablePostProcessBlueprint;

		// Token: 0x04001A4B RID: 6731
		internal static byte __PropertyMask_bDisablePostProcessBlueprint;

		// Token: 0x04001A4C RID: 6732
		internal static int __PropertyOffset_bUpdateOverlapsOnAnimationFinalize;

		// Token: 0x04001A4D RID: 6733
		internal static byte __PropertyMask_bUpdateOverlapsOnAnimationFinalize;

		// Token: 0x04001A4E RID: 6734
		internal static int __PropertyOffset_bHasValidBodies;

		// Token: 0x04001A4F RID: 6735
		internal static byte __PropertyMask_bHasValidBodies;

		// Token: 0x04001A50 RID: 6736
		internal static int __PropertyOffset_bBlendPhysics;

		// Token: 0x04001A51 RID: 6737
		internal static byte __PropertyMask_bBlendPhysics;

		// Token: 0x04001A52 RID: 6738
		internal static int __PropertyOffset_bEnablePhysicsOnDedicatedServer;

		// Token: 0x04001A53 RID: 6739
		internal static byte __PropertyMask_bEnablePhysicsOnDedicatedServer;

		// Token: 0x04001A54 RID: 6740
		internal static int __PropertyOffset_bUpdateJointsFromAnimation;

		// Token: 0x04001A55 RID: 6741
		internal static byte __PropertyMask_bUpdateJointsFromAnimation;

		// Token: 0x04001A56 RID: 6742
		internal static int __PropertyOffset_bDisableClothSimulation;

		// Token: 0x04001A57 RID: 6743
		internal static byte __PropertyMask_bDisableClothSimulation;

		// Token: 0x04001A58 RID: 6744
		internal static int __PropertyOffset_bDisableRigidBodyAnimNode;

		// Token: 0x04001A59 RID: 6745
		internal static byte __PropertyMask_bDisableRigidBodyAnimNode;

		// Token: 0x04001A5A RID: 6746
		internal static int __PropertyOffset_bAllowAnimCurveEvaluation;

		// Token: 0x04001A5B RID: 6747
		internal static byte __PropertyMask_bAllowAnimCurveEvaluation;

		// Token: 0x04001A5C RID: 6748
		internal static int __PropertyOffset_bDisableAnimCurves_DEPRECATED;

		// Token: 0x04001A5D RID: 6749
		internal static byte __PropertyMask_bDisableAnimCurves_DEPRECATED;

		// Token: 0x04001A5E RID: 6750
		internal static int __PropertyOffset_bCollideWithEnvironment;

		// Token: 0x04001A5F RID: 6751
		internal static byte __PropertyMask_bCollideWithEnvironment;

		// Token: 0x04001A60 RID: 6752
		internal static int __PropertyOffset_bCollideWithAttachedChildren;

		// Token: 0x04001A61 RID: 6753
		internal static byte __PropertyMask_bCollideWithAttachedChildren;

		// Token: 0x04001A62 RID: 6754
		internal static int __PropertyOffset_bKuroStaticClothCollideWithEnvironment;

		// Token: 0x04001A63 RID: 6755
		internal static byte __PropertyMask_bKuroStaticClothCollideWithEnvironment;

		// Token: 0x04001A64 RID: 6756
		internal static int __PropertyOffset_bKuroSkeletalBodySetupsClothingSimulation;

		// Token: 0x04001A65 RID: 6757
		internal static byte __PropertyMask_bKuroSkeletalBodySetupsClothingSimulation;

		// Token: 0x04001A66 RID: 6758
		internal static int __PropertyOffset_bKuroSkeletalBodySetupsVelocityRadiusScale;

		// Token: 0x04001A67 RID: 6759
		internal static int __PropertyOffset_bKuroClothUseOriginTangentToLocal;

		// Token: 0x04001A68 RID: 6760
		internal static byte __PropertyMask_bKuroClothUseOriginTangentToLocal;

		// Token: 0x04001A69 RID: 6761
		internal static int __PropertyOffset_bKuroBoundStopClothingSimulation;

		// Token: 0x04001A6A RID: 6762
		internal static byte __PropertyMask_bKuroBoundStopClothingSimulation;

		// Token: 0x04001A6B RID: 6763
		internal static int __PropertyOffset_bLocalSpaceSimulation;

		// Token: 0x04001A6C RID: 6764
		internal static byte __PropertyMask_bLocalSpaceSimulation;

		// Token: 0x04001A6D RID: 6765
		internal static int __PropertyOffset_bResetAfterTeleport;

		// Token: 0x04001A6E RID: 6766
		internal static byte __PropertyMask_bResetAfterTeleport;

		// Token: 0x04001A6F RID: 6767
		internal static int __PropertyOffset_bDeferKinematicBoneUpdate;

		// Token: 0x04001A70 RID: 6768
		internal static byte __PropertyMask_bDeferKinematicBoneUpdate;

		// Token: 0x04001A71 RID: 6769
		internal static int __PropertyOffset_bNoSkeletonUpdate;

		// Token: 0x04001A72 RID: 6770
		internal static byte __PropertyMask_bNoSkeletonUpdate;

		// Token: 0x04001A73 RID: 6771
		internal static int __PropertyOffset_bEnableShearAnim;

		// Token: 0x04001A74 RID: 6772
		internal static byte __PropertyMask_bEnableShearAnim;

		// Token: 0x04001A75 RID: 6773
		internal static int __PropertyOffset_bEnableAnimTexture;

		// Token: 0x04001A76 RID: 6774
		internal static byte __PropertyMask_bEnableAnimTexture;

		// Token: 0x04001A77 RID: 6775
		internal static int __PropertyOffset_bPauseAnims;

		// Token: 0x04001A78 RID: 6776
		internal static byte __PropertyMask_bPauseAnims;

		// Token: 0x04001A79 RID: 6777
		internal static int __PropertyOffset_bUseRefPoseOnInitAnim;

		// Token: 0x04001A7A RID: 6778
		internal static byte __PropertyMask_bUseRefPoseOnInitAnim;

		// Token: 0x04001A7B RID: 6779
		internal static int __PropertyOffset_bEnablePerPolyCollision;

		// Token: 0x04001A7C RID: 6780
		internal static byte __PropertyMask_bEnablePerPolyCollision;

		// Token: 0x04001A7D RID: 6781
		internal static int __PropertyOffset_bForceRefpose;

		// Token: 0x04001A7E RID: 6782
		internal static byte __PropertyMask_bForceRefpose;

		// Token: 0x04001A7F RID: 6783
		internal static int __PropertyOffset_bOnlyAllowAutonomousTickPose;

		// Token: 0x04001A80 RID: 6784
		internal static byte __PropertyMask_bOnlyAllowAutonomousTickPose;

		// Token: 0x04001A81 RID: 6785
		internal static int __PropertyOffset_bIsAutonomousTickPose;

		// Token: 0x04001A82 RID: 6786
		internal static byte __PropertyMask_bIsAutonomousTickPose;

		// Token: 0x04001A83 RID: 6787
		internal static int __PropertyOffset_bOldForceRefPose;

		// Token: 0x04001A84 RID: 6788
		internal static byte __PropertyMask_bOldForceRefPose;

		// Token: 0x04001A85 RID: 6789
		internal static int __PropertyOffset_bShowPrePhysBones;

		// Token: 0x04001A86 RID: 6790
		internal static byte __PropertyMask_bShowPrePhysBones;

		// Token: 0x04001A87 RID: 6791
		internal static int __PropertyOffset_bRequiredBonesUpToDate;

		// Token: 0x04001A88 RID: 6792
		internal static byte __PropertyMask_bRequiredBonesUpToDate;

		// Token: 0x04001A89 RID: 6793
		internal static int __PropertyOffset_bAnimTreeInitialised;

		// Token: 0x04001A8A RID: 6794
		internal static byte __PropertyMask_bAnimTreeInitialised;

		// Token: 0x04001A8B RID: 6795
		internal static int __PropertyOffset_bIncludeComponentLocationIntoBounds;

		// Token: 0x04001A8C RID: 6796
		internal static byte __PropertyMask_bIncludeComponentLocationIntoBounds;

		// Token: 0x04001A8D RID: 6797
		internal static int __PropertyOffset_bEnableLineCheckWithBounds;

		// Token: 0x04001A8E RID: 6798
		internal static byte __PropertyMask_bEnableLineCheckWithBounds;

		// Token: 0x04001A8F RID: 6799
		internal static int __PropertyOffset_bUseBendingElements_DEPRECATED;

		// Token: 0x04001A90 RID: 6800
		internal static byte __PropertyMask_bUseBendingElements_DEPRECATED;

		// Token: 0x04001A91 RID: 6801
		internal static int __PropertyOffset_bUseTetrahedralConstraints_DEPRECATED;

		// Token: 0x04001A92 RID: 6802
		internal static byte __PropertyMask_bUseTetrahedralConstraints_DEPRECATED;

		// Token: 0x04001A93 RID: 6803
		internal static int __PropertyOffset_bUseThinShellVolumeConstraints_DEPRECATED;

		// Token: 0x04001A94 RID: 6804
		internal static byte __PropertyMask_bUseThinShellVolumeConstraints_DEPRECATED;

		// Token: 0x04001A95 RID: 6805
		internal static int __PropertyOffset_bUseSelfCollisions_DEPRECATED;

		// Token: 0x04001A96 RID: 6806
		internal static byte __PropertyMask_bUseSelfCollisions_DEPRECATED;

		// Token: 0x04001A97 RID: 6807
		internal static int __PropertyOffset_bUseContinuousCollisionDetection_DEPRECATED;

		// Token: 0x04001A98 RID: 6808
		internal static byte __PropertyMask_bUseContinuousCollisionDetection_DEPRECATED;

		// Token: 0x04001A99 RID: 6809
		internal static int __PropertyOffset_bPropagateCurvesToSlaves;

		// Token: 0x04001A9A RID: 6810
		internal static byte __PropertyMask_bPropagateCurvesToSlaves;

		// Token: 0x04001A9B RID: 6811
		internal static int __PropertyOffset_bSkipKinematicUpdateWhenInterpolating;

		// Token: 0x04001A9C RID: 6812
		internal static byte __PropertyMask_bSkipKinematicUpdateWhenInterpolating;

		// Token: 0x04001A9D RID: 6813
		internal static int __PropertyOffset_bSkipBoundsUpdateWhenInterpolating;

		// Token: 0x04001A9E RID: 6814
		internal static byte __PropertyMask_bSkipBoundsUpdateWhenInterpolating;

		// Token: 0x04001A9F RID: 6815
		internal static int __PropertyOffset_bMaybeShearingPose;

		// Token: 0x04001AA0 RID: 6816
		internal static byte __PropertyMask_bMaybeShearingPose;

		// Token: 0x04001AA1 RID: 6817
		internal static int __PropertyOffset_bNeedsQueuedAnimEventsDispatched;

		// Token: 0x04001AA2 RID: 6818
		internal static byte __PropertyMask_bNeedsQueuedAnimEventsDispatched;

		// Token: 0x04001AA3 RID: 6819
		internal static int __PropertyOffset_CachedAnimCurveUidVersion;

		// Token: 0x04001AA4 RID: 6820
		internal static int __PropertyOffset_UniformMass_DEPRECATED;

		// Token: 0x04001AA5 RID: 6821
		internal static int __PropertyOffset_TotalMass_DEPRECATED;

		// Token: 0x04001AA6 RID: 6822
		internal static int __PropertyOffset_Density_DEPRECATED;

		// Token: 0x04001AA7 RID: 6823
		internal static int __PropertyOffset_MinPerParticleMass_DEPRECATED;

		// Token: 0x04001AA8 RID: 6824
		internal static int __PropertyOffset_ClothBlendWeight;

		// Token: 0x04001AA9 RID: 6825
		internal static int __PropertyOffset_EdgeStiffness_DEPRECATED;

		// Token: 0x04001AAA RID: 6826
		internal static int __PropertyOffset_BendingStiffness_DEPRECATED;

		// Token: 0x04001AAB RID: 6827
		internal static int __PropertyOffset_AreaStiffness_DEPRECATED;

		// Token: 0x04001AAC RID: 6828
		internal static int __PropertyOffset_VolumeStiffness_DEPRECATED;

		// Token: 0x04001AAD RID: 6829
		internal static int __PropertyOffset_StrainLimitingStiffness_DEPRECATED;

		// Token: 0x04001AAE RID: 6830
		internal static int __PropertyOffset_ShapeTargetStiffness_DEPRECATED;

		// Token: 0x04001AAF RID: 6831
		internal static int __PropertyOffset_bWaitForParallelClothTask;

		// Token: 0x04001AB0 RID: 6832
		internal static int __PropertyOffset_bUseRegionalSlaveBoneBounds;

		// Token: 0x04001AB1 RID: 6833
		internal static int __PropertyOffset_bUseCustomSlaveBoneBounds;

		// Token: 0x04001AB2 RID: 6834
		internal static int __PropertyOffset_CustomSlaveBoneBoundsConcernedBones;

		// Token: 0x04001AB3 RID: 6835
		private TArray<FName> _CustomSlaveBoneBoundsConcernedBones;

		// Token: 0x04001AB4 RID: 6836
		internal static int __PropertyOffset_CustomSlaveBoneBoundsExtension;

		// Token: 0x04001AB5 RID: 6837
		internal static int __PropertyOffset_DisallowedAnimCurves;

		// Token: 0x04001AB6 RID: 6838
		private TArray<FName> _DisallowedAnimCurves;

		// Token: 0x04001AB7 RID: 6839
		internal static int __PropertyOffset_BodySetup;

		// Token: 0x04001AB8 RID: 6840
		internal static int __PropertyOffset_OnConstraintBroken;

		// Token: 0x04001AB9 RID: 6841
		private FConstraintBrokenSignature _OnConstraintBroken;

		// Token: 0x04001ABA RID: 6842
		internal static int __PropertyOffset_TeleportDistanceThreshold;

		// Token: 0x04001ABB RID: 6843
		internal static int __PropertyOffset_TeleportRotationThreshold;

		// Token: 0x04001ABC RID: 6844
		internal static int __PropertyOffset_LastPoseTickFrame;

		// Token: 0x04001ABD RID: 6845
		internal static int __PropertyOffset_OnAnimInitialized;

		// Token: 0x04001ABE RID: 6846
		private FOnAnimInitialized _OnAnimInitialized;

		// Token: 0x04001ABF RID: 6847
		internal static int __PropertyOffset_EndGetHeadBondPos;

		// Token: 0x04001AC0 RID: 6848
		internal static byte __PropertyMask_EndGetHeadBondPos;

		// Token: 0x04001AC1 RID: 6849
		internal static int __PropertyOffset_bRunPostUpdateTick;

		// Token: 0x04001AC2 RID: 6850
		internal static int __PropertyOffset_PrerequisiteComp;

		// Token: 0x04001AC3 RID: 6851
		internal static int __PropertyOffset_bBanMontage;

		// Token: 0x04001AC4 RID: 6852
		internal static int __PropertyOffset_bUseDelayComplete;

		// Token: 0x04001AC5 RID: 6853
		internal static byte __PropertyMask_bUseDelayComplete;

		// Token: 0x04001AC6 RID: 6854
		internal static int __PropertyOffset_bUpdateChildTransInDelayComplete;

		// Token: 0x04001AC7 RID: 6855
		internal static int __PropertyOffset_bUseKuroParallel;

		// Token: 0x04001AC8 RID: 6856
		internal static byte __PropertyMask_bUseKuroParallel;

		// Token: 0x04001AC9 RID: 6857
		internal static int __PropertyOffset_bConsumeAllRootMotion;

		// Token: 0x04001ACA RID: 6858
		internal static byte __PropertyMask_bConsumeAllRootMotion;

		// Token: 0x04001ACB RID: 6859
		internal static int __PropertyOffset_bCacheFirstAnimInstance;

		// Token: 0x04001ACC RID: 6860
		internal static byte __PropertyMask_bCacheFirstAnimInstance;

		// Token: 0x04001ACD RID: 6861
		internal static int __PropertyOffset_bUseAnimInstanceCachePool;

		// Token: 0x04001ACE RID: 6862
		internal static byte __PropertyMask_bUseAnimInstanceCachePool;

		// Token: 0x04001ACF RID: 6863
		internal static int __PropertyOffset_WeakenKawaiiFollow;

		// Token: 0x04001AD0 RID: 6864
		internal static int __PropertyOffset_bUseParallelSkelCtrlNodeEval;

		// Token: 0x04001AD1 RID: 6865
		internal static byte __PropertyMask_bUseParallelSkelCtrlNodeEval;

		// Token: 0x04001AD2 RID: 6866
		internal static int __PropertyOffset_bEnableKuroClothSimulation;

		// Token: 0x04001AD3 RID: 6867
		internal static int __PropertyOffset_bRootMotionDebug;
	}
}
