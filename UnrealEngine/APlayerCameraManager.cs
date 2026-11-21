using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000261 RID: 609
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.PlayerCameraManager")]
	[UnrealStructLayout(18432, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 18432)]
	public class APlayerCameraManager : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003480 RID: 13440 RVA: 0x0004AB8A File Offset: 0x00048D8A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return APlayerCameraManager._ClassPtr;
		}

		// Token: 0x06003481 RID: 13441 RVA: 0x0004AB98 File Offset: 0x00048D98
		public APlayerCameraManager() : this(BuiltinUtils.AllocNativeUObject(APlayerCameraManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003482 RID: 13442 RVA: 0x0004ABC0 File Offset: 0x00048DC0
		[NullableContext(1)]
		public APlayerCameraManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(APlayerCameraManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000765 RID: 1893
		// (get) Token: 0x06003483 RID: 13443 RVA: 0x0004ABF3 File Offset: 0x00048DF3
		// (set) Token: 0x06003484 RID: 13444 RVA: 0x0004AC07 File Offset: 0x00048E07
		public unsafe APlayerController PCOwner
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<APlayerController>(base.NativePtr / (IntPtr)sizeof(void*) + APlayerCameraManager.__PropertyOffset_PCOwner);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + APlayerCameraManager.__PropertyOffset_PCOwner, value);
			}
		}

		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x06003485 RID: 13445 RVA: 0x0004AC1C File Offset: 0x00048E1C
		// (set) Token: 0x06003486 RID: 13446 RVA: 0x0004AC30 File Offset: 0x00048E30
		public unsafe USceneComponent TransformComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + APlayerCameraManager.__PropertyOffset_TransformComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + APlayerCameraManager.__PropertyOffset_TransformComponent, value);
			}
		}

		// Token: 0x17000767 RID: 1895
		// (get) Token: 0x06003487 RID: 13447 RVA: 0x0004AC45 File Offset: 0x00048E45
		// (set) Token: 0x06003488 RID: 13448 RVA: 0x0004AC55 File Offset: 0x00048E55
		public unsafe float DefaultFOV
		{
			get
			{
				return *(base.NativePtr + (IntPtr)APlayerCameraManager.__PropertyOffset_DefaultFOV);
			}
			set
			{
				*(base.NativePtr + (IntPtr)APlayerCameraManager.__PropertyOffset_DefaultFOV) = value;
			}
		}

		// Token: 0x17000768 RID: 1896
		// (get) Token: 0x06003489 RID: 13449 RVA: 0x0004AC66 File Offset: 0x00048E66
		// (set) Token: 0x0600348A RID: 13450 RVA: 0x0004AC76 File Offset: 0x00048E76
		public unsafe float DefaultOrthoWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)APlayerCameraManager.__PropertyOffset_DefaultOrthoWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)APlayerCameraManager.__PropertyOffset_DefaultOrthoWidth) = value;
			}
		}

		// Token: 0x17000769 RID: 1897
		// (get) Token: 0x0600348B RID: 13451 RVA: 0x0004AC87 File Offset: 0x00048E87
		// (set) Token: 0x0600348C RID: 13452 RVA: 0x0004AC97 File Offset: 0x00048E97
		public unsafe float DefaultAspectRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)APlayerCameraManager.__PropertyOffset_DefaultAspectRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)APlayerCameraManager.__PropertyOffset_DefaultAspectRatio) = value;
			}
		}

		// Token: 0x1700076A RID: 1898
		// (get) Token: 0x0600348D RID: 13453 RVA: 0x0004ACA8 File Offset: 0x00048EA8
		// (set) Token: 0x0600348E RID: 13454 RVA: 0x0004ACBC File Offset: 0x00048EBC
		public unsafe FVector2D ViewPointOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)APlayerCameraManager.__PropertyOffset_ViewPointOverride);
			}
			set
			{
				*(base.NativePtr + (IntPtr)APlayerCameraManager.__PropertyOffset_ViewPointOverride) = value;
			}
		}

		// Token: 0x1700076B RID: 1899
		// (get) Token: 0x0600348F RID: 13455 RVA: 0x0004ACD1 File Offset: 0x00048ED1
		// (set) Token: 0x06003490 RID: 13456 RVA: 0x0004ACE5 File Offset: 0x00048EE5
		public unsafe FVector2D ViewSizeOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)APlayerCameraManager.__PropertyOffset_ViewSizeOverride);
			}
			set
			{
				*(base.NativePtr + (IntPtr)APlayerCameraManager.__PropertyOffset_ViewSizeOverride) = value;
			}
		}

		// Token: 0x1700076C RID: 1900
		// (get) Token: 0x06003491 RID: 13457 RVA: 0x0004ACFA File Offset: 0x00048EFA
		// (set) Token: 0x06003492 RID: 13458 RVA: 0x0004AD0E File Offset: 0x00048F0E
		public unsafe FLinearColor FadeColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)APlayerCameraManager.__PropertyOffset_FadeColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)APlayerCameraManager.__PropertyOffset_FadeColor) = value;
			}
		}

		// Token: 0x1700076D RID: 1901
		// (get) Token: 0x06003493 RID: 13459 RVA: 0x0004AD23 File Offset: 0x00048F23
		// (set) Token: 0x06003494 RID: 13460 RVA: 0x0004AD33 File Offset: 0x00048F33
		public unsafe float FadeAmount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)APlayerCameraManager.__PropertyOffset_FadeAmount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)APlayerCameraManager.__PropertyOffset_FadeAmount) = value;
			}
		}

		// Token: 0x1700076E RID: 1902
		// (get) Token: 0x06003495 RID: 13461 RVA: 0x0004AD44 File Offset: 0x00048F44
		// (set) Token: 0x06003496 RID: 13462 RVA: 0x0004AD7D File Offset: 0x00048F7D
		[Nullable(1)]
		public FTViewTarget ViewTarget
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FTViewTarget result;
				if ((result = this._ViewTarget) == null)
				{
					result = (this._ViewTarget = new FTViewTarget(base.NativePtr + (IntPtr)APlayerCameraManager.__PropertyOffset_ViewTarget, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTViewTarget.StaticStruct(), base.NativePtr + (IntPtr)APlayerCameraManager.__PropertyOffset_ViewTarget, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700076F RID: 1903
		// (get) Token: 0x06003497 RID: 13463 RVA: 0x0004ADA0 File Offset: 0x00048FA0
		// (set) Token: 0x06003498 RID: 13464 RVA: 0x0004ADD9 File Offset: 0x00048FD9
		[Nullable(1)]
		public FTViewTarget PendingViewTarget
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FTViewTarget result;
				if ((result = this._PendingViewTarget) == null)
				{
					result = (this._PendingViewTarget = new FTViewTarget(base.NativePtr + (IntPtr)APlayerCameraManager.__PropertyOffset_PendingViewTarget, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTViewTarget.StaticStruct(), base.NativePtr + (IntPtr)APlayerCameraManager.__PropertyOffset_PendingViewTarget, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000770 RID: 1904
		// (get) Token: 0x06003499 RID: 13465 RVA: 0x0004ADFC File Offset: 0x00048FFC
		// (set) Token: 0x0600349A RID: 13466 RVA: 0x0004AE35 File Offset: 0x00049035
		[Nullable(1)]
		public TArray<UCameraModifier> ModifierList
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UCameraModifier> result;
				if ((result = this._ModifierList) == null)
				{
					result = (this._ModifierList = new TArray<UCameraModifier>(base.NativePtr + (IntPtr)APlayerCameraManager.__PropertyOffset_ModifierList, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ModifierList.CopyAssign(value);
			}
		}

		// Token: 0x17000771 RID: 1905
		// (get) Token: 0x0600349B RID: 13467 RVA: 0x0004AE44 File Offset: 0x00049044
		// (set) Token: 0x0600349C RID: 13468 RVA: 0x0004AE7D File Offset: 0x0004907D
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TArray<TSubclassOf<UCameraModifier>> DefaultModifiers
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TSubclassOf<UCameraModifier>> result;
				if ((result = this._DefaultModifiers) == null)
				{
					result = (this._DefaultModifiers = new TArray<TSubclassOf<UCameraModifier>>(base.NativePtr + (IntPtr)APlayerCameraManager.__PropertyOffset_DefaultModifiers, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.DefaultModifiers.CopyAssign(value);
			}
		}

		// Token: 0x17000772 RID: 1906
		// (get) Token: 0x0600349D RID: 13469 RVA: 0x0004AE8B File Offset: 0x0004908B
		// (set) Token: 0x0600349E RID: 13470 RVA: 0x0004AE9B File Offset: 0x0004909B
		public unsafe float FreeCamDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)APlayerCameraManager.__PropertyOffset_FreeCamDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)APlayerCameraManager.__PropertyOffset_FreeCamDistance) = value;
			}
		}

		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x0600349F RID: 13471 RVA: 0x0004AEAC File Offset: 0x000490AC
		// (set) Token: 0x060034A0 RID: 13472 RVA: 0x0004AEC0 File Offset: 0x000490C0
		public unsafe FVector FreeCamOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)APlayerCameraManager.__PropertyOffset_FreeCamOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)APlayerCameraManager.__PropertyOffset_FreeCamOffset) = value;
			}
		}

		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x060034A1 RID: 13473 RVA: 0x0004AED5 File Offset: 0x000490D5
		// (set) Token: 0x060034A2 RID: 13474 RVA: 0x0004AEE9 File Offset: 0x000490E9
		public unsafe FVector ViewTargetOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)APlayerCameraManager.__PropertyOffset_ViewTargetOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)APlayerCameraManager.__PropertyOffset_ViewTargetOffset) = value;
			}
		}

		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x060034A3 RID: 13475 RVA: 0x0004AF00 File Offset: 0x00049100
		// (set) Token: 0x060034A4 RID: 13476 RVA: 0x0004AF39 File Offset: 0x00049139
		[Nullable(1)]
		public FOnAudioFadeChangeSignature OnAudioFadeChangeEvent
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FOnAudioFadeChangeSignature result;
				if ((result = this._OnAudioFadeChangeEvent) == null)
				{
					result = (this._OnAudioFadeChangeEvent = new FOnAudioFadeChangeSignature(base.NativePtr + (IntPtr)APlayerCameraManager.__PropertyOffset_OnAudioFadeChangeEvent, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)APlayerCameraManager.__PropertyOffset_OnAudioFadeChangeEvent, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000776 RID: 1910
		// (get) Token: 0x060034A5 RID: 13477 RVA: 0x0004AF5A File Offset: 0x0004915A
		// (set) Token: 0x060034A6 RID: 13478 RVA: 0x0004AF6E File Offset: 0x0004916E
		public unsafe UCameraModifier_CameraShake CachedCameraShakeMod
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCameraModifier_CameraShake>(base.NativePtr / (IntPtr)sizeof(void*) + APlayerCameraManager.__PropertyOffset_CachedCameraShakeMod);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + APlayerCameraManager.__PropertyOffset_CachedCameraShakeMod, value);
			}
		}

		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x060034A7 RID: 13479 RVA: 0x0004AF83 File Offset: 0x00049183
		// (set) Token: 0x060034A8 RID: 13480 RVA: 0x0004AF93 File Offset: 0x00049193
		public unsafe bool bOpenCameraShake
		{
			get
			{
				return *(base.NativePtr + (IntPtr)APlayerCameraManager.__PropertyOffset_bOpenCameraShake) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)APlayerCameraManager.__PropertyOffset_bOpenCameraShake) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x060034A9 RID: 13481 RVA: 0x0004AFA4 File Offset: 0x000491A4
		// (set) Token: 0x060034AA RID: 13482 RVA: 0x0004AFDD File Offset: 0x000491DD
		[Nullable(1)]
		public TArray<FPostProcessSettings> PostProcessBlendCache
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FPostProcessSettings> result;
				if ((result = this._PostProcessBlendCache) == null)
				{
					result = (this._PostProcessBlendCache = new TArray<FPostProcessSettings>(base.NativePtr + (IntPtr)APlayerCameraManager.__PropertyOffset_PostProcessBlendCache, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.PostProcessBlendCache.CopyAssign(value);
			}
		}

		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x060034AB RID: 13483 RVA: 0x0004AFEB File Offset: 0x000491EB
		// (set) Token: 0x060034AC RID: 13484 RVA: 0x0004AFFF File Offset: 0x000491FF
		public unsafe ACameraActor AnimCameraActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ACameraActor>(base.NativePtr / (IntPtr)sizeof(void*) + APlayerCameraManager.__PropertyOffset_AnimCameraActor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + APlayerCameraManager.__PropertyOffset_AnimCameraActor, value);
			}
		}

		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x060034AD RID: 13485 RVA: 0x0004B014 File Offset: 0x00049214
		// (set) Token: 0x060034AE RID: 13486 RVA: 0x0004B02D File Offset: 0x0004922D
		public unsafe bool bIsOrthographic
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)APlayerCameraManager.__PropertyOffset_bIsOrthographic) & APlayerCameraManager.__PropertyMask_bIsOrthographic) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)APlayerCameraManager.__PropertyOffset_bIsOrthographic) = ((*(base.NativePtr + (IntPtr)APlayerCameraManager.__PropertyOffset_bIsOrthographic) & ~APlayerCameraManager.__PropertyMask_bIsOrthographic) | (value ? APlayerCameraManager.__PropertyMask_bIsOrthographic : 0));
			}
		}

		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x060034AF RID: 13487 RVA: 0x0004B05D File Offset: 0x0004925D
		// (set) Token: 0x060034B0 RID: 13488 RVA: 0x0004B076 File Offset: 0x00049276
		public unsafe bool bDefaultConstrainAspectRatio
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)APlayerCameraManager.__PropertyOffset_bDefaultConstrainAspectRatio) & APlayerCameraManager.__PropertyMask_bDefaultConstrainAspectRatio) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)APlayerCameraManager.__PropertyOffset_bDefaultConstrainAspectRatio) = ((*(base.NativePtr + (IntPtr)APlayerCameraManager.__PropertyOffset_bDefaultConstrainAspectRatio) & ~APlayerCameraManager.__PropertyMask_bDefaultConstrainAspectRatio) | (value ? APlayerCameraManager.__PropertyMask_bDefaultConstrainAspectRatio : 0));
			}
		}

		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x060034B1 RID: 13489 RVA: 0x0004B0A6 File Offset: 0x000492A6
		// (set) Token: 0x060034B2 RID: 13490 RVA: 0x0004B0BF File Offset: 0x000492BF
		public unsafe bool bEnableFading
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)APlayerCameraManager.__PropertyOffset_bEnableFading) & APlayerCameraManager.__PropertyMask_bEnableFading) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)APlayerCameraManager.__PropertyOffset_bEnableFading) = ((*(base.NativePtr + (IntPtr)APlayerCameraManager.__PropertyOffset_bEnableFading) & ~APlayerCameraManager.__PropertyMask_bEnableFading) | (value ? APlayerCameraManager.__PropertyMask_bEnableFading : 0));
			}
		}

		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x060034B3 RID: 13491 RVA: 0x0004B0EF File Offset: 0x000492EF
		// (set) Token: 0x060034B4 RID: 13492 RVA: 0x0004B108 File Offset: 0x00049308
		public unsafe bool bClientSimulatingViewTarget
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)APlayerCameraManager.__PropertyOffset_bClientSimulatingViewTarget) & APlayerCameraManager.__PropertyMask_bClientSimulatingViewTarget) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)APlayerCameraManager.__PropertyOffset_bClientSimulatingViewTarget) = ((*(base.NativePtr + (IntPtr)APlayerCameraManager.__PropertyOffset_bClientSimulatingViewTarget) & ~APlayerCameraManager.__PropertyMask_bClientSimulatingViewTarget) | (value ? APlayerCameraManager.__PropertyMask_bClientSimulatingViewTarget : 0));
			}
		}

		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x060034B5 RID: 13493 RVA: 0x0004B138 File Offset: 0x00049338
		// (set) Token: 0x060034B6 RID: 13494 RVA: 0x0004B151 File Offset: 0x00049351
		public unsafe bool bUseClientSideCameraUpdates
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)APlayerCameraManager.__PropertyOffset_bUseClientSideCameraUpdates) & APlayerCameraManager.__PropertyMask_bUseClientSideCameraUpdates) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)APlayerCameraManager.__PropertyOffset_bUseClientSideCameraUpdates) = ((*(base.NativePtr + (IntPtr)APlayerCameraManager.__PropertyOffset_bUseClientSideCameraUpdates) & ~APlayerCameraManager.__PropertyMask_bUseClientSideCameraUpdates) | (value ? APlayerCameraManager.__PropertyMask_bUseClientSideCameraUpdates : 0));
			}
		}

		// Token: 0x1700077F RID: 1919
		// (get) Token: 0x060034B7 RID: 13495 RVA: 0x0004B181 File Offset: 0x00049381
		// (set) Token: 0x060034B8 RID: 13496 RVA: 0x0004B19A File Offset: 0x0004939A
		public unsafe bool bGameCameraCutThisFrame
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)APlayerCameraManager.__PropertyOffset_bGameCameraCutThisFrame) & APlayerCameraManager.__PropertyMask_bGameCameraCutThisFrame) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)APlayerCameraManager.__PropertyOffset_bGameCameraCutThisFrame) = ((*(base.NativePtr + (IntPtr)APlayerCameraManager.__PropertyOffset_bGameCameraCutThisFrame) & ~APlayerCameraManager.__PropertyMask_bGameCameraCutThisFrame) | (value ? APlayerCameraManager.__PropertyMask_bGameCameraCutThisFrame : 0));
			}
		}

		// Token: 0x17000780 RID: 1920
		// (get) Token: 0x060034B9 RID: 13497 RVA: 0x0004B1CA File Offset: 0x000493CA
		// (set) Token: 0x060034BA RID: 13498 RVA: 0x0004B1DA File Offset: 0x000493DA
		public unsafe float ViewPitchMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)APlayerCameraManager.__PropertyOffset_ViewPitchMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)APlayerCameraManager.__PropertyOffset_ViewPitchMin) = value;
			}
		}

		// Token: 0x17000781 RID: 1921
		// (get) Token: 0x060034BB RID: 13499 RVA: 0x0004B1EB File Offset: 0x000493EB
		// (set) Token: 0x060034BC RID: 13500 RVA: 0x0004B1FB File Offset: 0x000493FB
		public unsafe float ViewPitchMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)APlayerCameraManager.__PropertyOffset_ViewPitchMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)APlayerCameraManager.__PropertyOffset_ViewPitchMax) = value;
			}
		}

		// Token: 0x17000782 RID: 1922
		// (get) Token: 0x060034BD RID: 13501 RVA: 0x0004B20C File Offset: 0x0004940C
		// (set) Token: 0x060034BE RID: 13502 RVA: 0x0004B21C File Offset: 0x0004941C
		public unsafe float ViewYawMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)APlayerCameraManager.__PropertyOffset_ViewYawMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)APlayerCameraManager.__PropertyOffset_ViewYawMin) = value;
			}
		}

		// Token: 0x17000783 RID: 1923
		// (get) Token: 0x060034BF RID: 13503 RVA: 0x0004B22D File Offset: 0x0004942D
		// (set) Token: 0x060034C0 RID: 13504 RVA: 0x0004B23D File Offset: 0x0004943D
		public unsafe float ViewYawMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)APlayerCameraManager.__PropertyOffset_ViewYawMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)APlayerCameraManager.__PropertyOffset_ViewYawMax) = value;
			}
		}

		// Token: 0x17000784 RID: 1924
		// (get) Token: 0x060034C1 RID: 13505 RVA: 0x0004B24E File Offset: 0x0004944E
		// (set) Token: 0x060034C2 RID: 13506 RVA: 0x0004B25E File Offset: 0x0004945E
		public unsafe float ViewRollMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)APlayerCameraManager.__PropertyOffset_ViewRollMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)APlayerCameraManager.__PropertyOffset_ViewRollMin) = value;
			}
		}

		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x060034C3 RID: 13507 RVA: 0x0004B26F File Offset: 0x0004946F
		// (set) Token: 0x060034C4 RID: 13508 RVA: 0x0004B27F File Offset: 0x0004947F
		public unsafe float ViewRollMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)APlayerCameraManager.__PropertyOffset_ViewRollMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)APlayerCameraManager.__PropertyOffset_ViewRollMax) = value;
			}
		}

		// Token: 0x17000786 RID: 1926
		// (get) Token: 0x060034C5 RID: 13509 RVA: 0x0004B290 File Offset: 0x00049490
		// (set) Token: 0x060034C6 RID: 13510 RVA: 0x0004B2A0 File Offset: 0x000494A0
		public unsafe float ServerUpdateCameraTimeout
		{
			get
			{
				return *(base.NativePtr + (IntPtr)APlayerCameraManager.__PropertyOffset_ServerUpdateCameraTimeout);
			}
			set
			{
				*(base.NativePtr + (IntPtr)APlayerCameraManager.__PropertyOffset_ServerUpdateCameraTimeout) = value;
			}
		}

		// Token: 0x17000787 RID: 1927
		// (get) Token: 0x060034C7 RID: 13511 RVA: 0x0004B2B1 File Offset: 0x000494B1
		// (set) Token: 0x060034C8 RID: 13512 RVA: 0x0004B2C1 File Offset: 0x000494C1
		public unsafe float CameraModifyCustomTimeDilation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)APlayerCameraManager.__PropertyOffset_CameraModifyCustomTimeDilation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)APlayerCameraManager.__PropertyOffset_CameraModifyCustomTimeDilation) = value;
			}
		}

		// Token: 0x060034C9 RID: 13513 RVA: 0x0004B2D2 File Offset: 0x000494D2
		public void SwapPendingViewTargetWhenUsingClientSideCameraUpdates()
		{
			APlayerCameraManager.__SwapPendingViewTargetWhenUsingClientSideCameraUpdates_Internal(base.NativePtr);
		}

		// Token: 0x060034CA RID: 13514 RVA: 0x0004B2DF File Offset: 0x000494DF
		public void StopCameraShake(UCameraShakeBase ShakeInstance, bool bImmediately = true)
		{
			APlayerCameraManager.__StopCameraShake_Internal(base.NativePtr, (ShakeInstance != null) ? ShakeInstance.NativePtr : IntPtr.Zero, bImmediately);
		}

		// Token: 0x060034CB RID: 13515 RVA: 0x0004B2FD File Offset: 0x000494FD
		public void StopCameraFade()
		{
			APlayerCameraManager.__StopCameraFade_Internal(base.NativePtr);
		}

		// Token: 0x060034CC RID: 13516 RVA: 0x0004B30A File Offset: 0x0004950A
		public void StopAllInstancesOfCameraShake([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UCameraShakeBase> Shake, bool bImmediately = true)
		{
			APlayerCameraManager.__StopAllInstancesOfCameraShake_Internal(base.NativePtr, Shake._NativePtr, bImmediately);
		}

		// Token: 0x060034CD RID: 13517 RVA: 0x0004B31E File Offset: 0x0004951E
		public void StopAllCameraShakes(bool bImmediately = true)
		{
			APlayerCameraManager.__StopAllCameraShakes_Internal(base.NativePtr, bImmediately);
		}

		// Token: 0x060034CE RID: 13518 RVA: 0x0004B32C File Offset: 0x0004952C
		public void StopAllCameraAnims(bool bImmediate = false)
		{
			APlayerCameraManager.__StopAllCameraAnims_Internal(base.NativePtr, bImmediate);
		}

		// Token: 0x060034CF RID: 13519 RVA: 0x0004B33A File Offset: 0x0004953A
		public UMatineeCameraShake StartMatineeCameraShake([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UMatineeCameraShake> ShakeClass, float Scale = 1f, ECameraShakePlaySpace PlaySpace = ECameraShakePlaySpace.CameraLocal, FRotator UserPlaySpaceRot = default(FRotator), float TimeDilation = 1f)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMatineeCameraShake>(APlayerCameraManager.__StartMatineeCameraShake_Internal(base.NativePtr, ShakeClass._NativePtr, Scale, PlaySpace, UserPlaySpaceRot, TimeDilation));
		}

		// Token: 0x060034D0 RID: 13520 RVA: 0x0004B358 File Offset: 0x00049558
		public UCameraShakeBase StartCameraShake([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UCameraShakeBase> ShakeClass, float Scale = 1f, ECameraShakePlaySpace PlaySpace = ECameraShakePlaySpace.CameraLocal, FRotator UserPlaySpaceRot = default(FRotator), float TimeDilation = 1f)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UCameraShakeBase>(APlayerCameraManager.__StartCameraShake_Internal(base.NativePtr, ShakeClass._NativePtr, Scale, PlaySpace, UserPlaySpaceRot, TimeDilation));
		}

		// Token: 0x060034D1 RID: 13521 RVA: 0x0004B376 File Offset: 0x00049576
		public void StartCameraFade(float FromAlpha, float ToAlpha, float Duration, FLinearColor Color, bool bShouldFadeAudio = false, bool bHoldWhenFinished = false, ECameraFadeMode FadeMode = ECameraFadeMode.CFM_Linear)
		{
			APlayerCameraManager.__StartCameraFade_Internal(base.NativePtr, FromAlpha, ToAlpha, Duration, Color, bShouldFadeAudio, bHoldWhenFinished, FadeMode);
		}

		// Token: 0x060034D2 RID: 13522 RVA: 0x0004B393 File Offset: 0x00049593
		public void SetManualCameraFade(float InFadeAmount, FLinearColor Color, bool bInFadeAudio)
		{
			APlayerCameraManager.__SetManualCameraFade_Internal(base.NativePtr, InFadeAmount, Color, bInFadeAudio);
		}

		// Token: 0x060034D3 RID: 13523 RVA: 0x0004B3A3 File Offset: 0x000495A3
		public void SetGameCameraCutThisFrame()
		{
			APlayerCameraManager.__SetGameCameraCutThisFrame_Internal(base.NativePtr);
		}

		// Token: 0x060034D4 RID: 13524 RVA: 0x0004B3B0 File Offset: 0x000495B0
		public void ResetViewTarget(AActor NewViewTarget, in FViewTargetTransitionParams TransitionParams)
		{
			APlayerCameraManager.__ResetViewTarget_Internal(base.NativePtr, (NewViewTarget != null) ? NewViewTarget.NativePtr : IntPtr.Zero, (TransitionParams ?? new FViewTargetTransitionParams()).NativePtr);
		}

		// Token: 0x060034D5 RID: 13525 RVA: 0x0004B3DD File Offset: 0x000495DD
		public bool RemoveCameraModifier(UCameraModifier ModifierToRemove)
		{
			return APlayerCameraManager.__RemoveCameraModifier_Internal(base.NativePtr, (ModifierToRemove != null) ? ModifierToRemove.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060034D6 RID: 13526 RVA: 0x0004B3FC File Offset: 0x000495FC
		public unsafe virtual void PhotographyCameraModify(FVector NewCameraLocation, FVector PreviousCameraLocation, FVector OriginalCameraLocation, ref FVector ResultCameraLocation)
		{
			fixed (FVector* ptr = &ResultCameraLocation)
			{
				void* ptr2 = (void*)ptr;
				APlayerCameraManager.__PhotographyCameraModify_Internal(base.NativePtr, NewCameraLocation, PreviousCameraLocation, OriginalCameraLocation, ref ResultCameraLocation);
			}
		}

		// Token: 0x060034D7 RID: 13527 RVA: 0x0004B424 File Offset: 0x00049624
		protected unsafe virtual void PhotographyCameraModify_Implementation(FVector NewCameraLocation, FVector PreviousCameraLocation, FVector OriginalCameraLocation, ref FVector ResultCameraLocation)
		{
			fixed (FVector* ptr = &ResultCameraLocation)
			{
				void* ptr2 = (void*)ptr;
				APlayerCameraManager.__PhotographyCameraModify_Implementation_Internal(base.NativePtr, NewCameraLocation, PreviousCameraLocation, OriginalCameraLocation, ref ResultCameraLocation);
			}
		}

		// Token: 0x060034D8 RID: 13528 RVA: 0x0004B44A File Offset: 0x0004964A
		public virtual void OnPhotographySessionStart()
		{
			APlayerCameraManager.__OnPhotographySessionStart_Internal(base.NativePtr);
		}

		// Token: 0x060034D9 RID: 13529 RVA: 0x0004B457 File Offset: 0x00049657
		protected virtual void OnPhotographySessionStart_Implementation()
		{
			APlayerCameraManager.__OnPhotographySessionStart_Implementation_Internal(base.NativePtr);
		}

		// Token: 0x060034DA RID: 13530 RVA: 0x0004B464 File Offset: 0x00049664
		public virtual void OnPhotographySessionEnd()
		{
			APlayerCameraManager.__OnPhotographySessionEnd_Internal(base.NativePtr);
		}

		// Token: 0x060034DB RID: 13531 RVA: 0x0004B471 File Offset: 0x00049671
		protected virtual void OnPhotographySessionEnd_Implementation()
		{
			APlayerCameraManager.__OnPhotographySessionEnd_Implementation_Internal(base.NativePtr);
		}

		// Token: 0x060034DC RID: 13532 RVA: 0x0004B47E File Offset: 0x0004967E
		public virtual void OnPhotographyMultiPartCaptureStart()
		{
			APlayerCameraManager.__OnPhotographyMultiPartCaptureStart_Internal(base.NativePtr);
		}

		// Token: 0x060034DD RID: 13533 RVA: 0x0004B48B File Offset: 0x0004968B
		protected virtual void OnPhotographyMultiPartCaptureStart_Implementation()
		{
			APlayerCameraManager.__OnPhotographyMultiPartCaptureStart_Implementation_Internal(base.NativePtr);
		}

		// Token: 0x060034DE RID: 13534 RVA: 0x0004B498 File Offset: 0x00049698
		public virtual void OnPhotographyMultiPartCaptureEnd()
		{
			APlayerCameraManager.__OnPhotographyMultiPartCaptureEnd_Internal(base.NativePtr);
		}

		// Token: 0x060034DF RID: 13535 RVA: 0x0004B4A5 File Offset: 0x000496A5
		protected virtual void OnPhotographyMultiPartCaptureEnd_Implementation()
		{
			APlayerCameraManager.__OnPhotographyMultiPartCaptureEnd_Implementation_Internal(base.NativePtr);
		}

		// Token: 0x060034E0 RID: 13536 RVA: 0x0004B4B2 File Offset: 0x000496B2
		public APlayerController GetOwningPlayerController()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<APlayerController>(APlayerCameraManager.__GetOwningPlayerController_Internal(base.NativePtr));
		}

		// Token: 0x060034E1 RID: 13537 RVA: 0x0004B4C4 File Offset: 0x000496C4
		public float GetFOVAngle()
		{
			return APlayerCameraManager.__GetFOVAngle_Internal(base.NativePtr);
		}

		// Token: 0x060034E2 RID: 13538 RVA: 0x0004B4D1 File Offset: 0x000496D1
		public FRotator GetCameraRotation()
		{
			return APlayerCameraManager.__GetCameraRotation_Internal(base.NativePtr);
		}

		// Token: 0x060034E3 RID: 13539 RVA: 0x0004B4DE File Offset: 0x000496DE
		public FVector GetCameraLocation()
		{
			return APlayerCameraManager.__GetCameraLocation_Internal(base.NativePtr);
		}

		// Token: 0x060034E4 RID: 13540 RVA: 0x0004B4EB File Offset: 0x000496EB
		public UCameraModifier FindCameraModifierByClass([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UCameraModifier> ModifierClass)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UCameraModifier>(APlayerCameraManager.__FindCameraModifierByClass_Internal(base.NativePtr, ModifierClass._NativePtr));
		}

		// Token: 0x060034E5 RID: 13541 RVA: 0x0004B503 File Offset: 0x00049703
		public FVectorDouble D_GetCameraLocation()
		{
			return APlayerCameraManager.__D_GetCameraLocation_Internal(base.NativePtr);
		}

		// Token: 0x060034E6 RID: 13542 RVA: 0x0004B510 File Offset: 0x00049710
		public void ClearCameraLensEffects()
		{
			APlayerCameraManager.__ClearCameraLensEffects_Internal(base.NativePtr);
		}

		// Token: 0x060034E7 RID: 13543 RVA: 0x0004B520 File Offset: 0x00049720
		public unsafe virtual bool BlueprintUpdateCamera(AActor CameraTarget, ref FVector NewCameraLocation, ref FRotator NewCameraRotation, ref float NewCameraFOV)
		{
			fixed (FVector* ptr = &NewCameraLocation)
			{
				void* ptr2 = (void*)ptr;
				fixed (FRotator* ptr3 = &NewCameraRotation)
				{
					void* ptr4 = (void*)ptr3;
					fixed (float* ptr5 = &NewCameraFOV)
					{
						void* ptr6 = (void*)ptr5;
						return APlayerCameraManager.__BlueprintUpdateCamera_Internal(base.NativePtr, (CameraTarget != null) ? CameraTarget.NativePtr : IntPtr.Zero, ref NewCameraLocation, ref NewCameraRotation, ref NewCameraFOV);
					}
				}
			}
		}

		// Token: 0x060034E8 RID: 13544 RVA: 0x0004B560 File Offset: 0x00049760
		public UCameraModifier AddNewCameraModifier([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UCameraModifier> ModifierClass)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UCameraModifier>(APlayerCameraManager.__AddNewCameraModifier_Internal(base.NativePtr, ModifierClass._NativePtr));
		}

		// Token: 0x060034E9 RID: 13545
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SwapPendingViewTargetWhenUsingClientSideCameraUpdates_Internal(IntPtr @this);

		// Token: 0x060034EA RID: 13546
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopCameraShake_Internal(IntPtr @this, IntPtr ShakeInstance, bool bImmediately);

		// Token: 0x060034EB RID: 13547
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopCameraFade_Internal(IntPtr @this);

		// Token: 0x060034EC RID: 13548
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopAllInstancesOfCameraShake_Internal(IntPtr @this, IntPtr Shake, bool bImmediately);

		// Token: 0x060034ED RID: 13549
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopAllCameraShakes_Internal(IntPtr @this, bool bImmediately);

		// Token: 0x060034EE RID: 13550
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopAllCameraAnims_Internal(IntPtr @this, bool bImmediate);

		// Token: 0x060034EF RID: 13551
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __StartMatineeCameraShake_Internal(IntPtr @this, IntPtr ShakeClass, float Scale, ECameraShakePlaySpace PlaySpace, FRotator UserPlaySpaceRot, float TimeDilation);

		// Token: 0x060034F0 RID: 13552
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __StartCameraShake_Internal(IntPtr @this, IntPtr ShakeClass, float Scale, ECameraShakePlaySpace PlaySpace, FRotator UserPlaySpaceRot, float TimeDilation);

		// Token: 0x060034F1 RID: 13553
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StartCameraFade_Internal(IntPtr @this, float FromAlpha, float ToAlpha, float Duration, FLinearColor Color, bool bShouldFadeAudio, bool bHoldWhenFinished, TEnumAsByte<ECameraFadeMode> FadeMode);

		// Token: 0x060034F2 RID: 13554
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetManualCameraFade_Internal(IntPtr @this, float InFadeAmount, FLinearColor Color, bool bInFadeAudio);

		// Token: 0x060034F3 RID: 13555
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGameCameraCutThisFrame_Internal(IntPtr @this);

		// Token: 0x060034F4 RID: 13556
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetViewTarget_Internal(IntPtr @this, IntPtr NewViewTarget, IntPtr TransitionParams);

		// Token: 0x060034F5 RID: 13557
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __RemoveCameraModifier_Internal(IntPtr @this, IntPtr ModifierToRemove);

		// Token: 0x060034F6 RID: 13558
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PhotographyCameraModify_Internal(IntPtr @this, FVector NewCameraLocation, FVector PreviousCameraLocation, FVector OriginalCameraLocation, ref FVector ResultCameraLocation);

		// Token: 0x060034F7 RID: 13559
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PhotographyCameraModify_Implementation_Internal(IntPtr @this, FVector NewCameraLocation, FVector PreviousCameraLocation, FVector OriginalCameraLocation, ref FVector ResultCameraLocation);

		// Token: 0x060034F8 RID: 13560
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnPhotographySessionStart_Internal(IntPtr @this);

		// Token: 0x060034F9 RID: 13561
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnPhotographySessionStart_Implementation_Internal(IntPtr @this);

		// Token: 0x060034FA RID: 13562
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnPhotographySessionEnd_Internal(IntPtr @this);

		// Token: 0x060034FB RID: 13563
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnPhotographySessionEnd_Implementation_Internal(IntPtr @this);

		// Token: 0x060034FC RID: 13564
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnPhotographyMultiPartCaptureStart_Internal(IntPtr @this);

		// Token: 0x060034FD RID: 13565
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnPhotographyMultiPartCaptureStart_Implementation_Internal(IntPtr @this);

		// Token: 0x060034FE RID: 13566
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnPhotographyMultiPartCaptureEnd_Internal(IntPtr @this);

		// Token: 0x060034FF RID: 13567
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnPhotographyMultiPartCaptureEnd_Implementation_Internal(IntPtr @this);

		// Token: 0x06003500 RID: 13568
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetOwningPlayerController_Internal(IntPtr @this);

		// Token: 0x06003501 RID: 13569
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetFOVAngle_Internal(IntPtr @this);

		// Token: 0x06003502 RID: 13570
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator __GetCameraRotation_Internal(IntPtr @this);

		// Token: 0x06003503 RID: 13571
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetCameraLocation_Internal(IntPtr @this);

		// Token: 0x06003504 RID: 13572
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __FindCameraModifierByClass_Internal(IntPtr @this, IntPtr ModifierClass);

		// Token: 0x06003505 RID: 13573
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_GetCameraLocation_Internal(IntPtr @this);

		// Token: 0x06003506 RID: 13574
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearCameraLensEffects_Internal(IntPtr @this);

		// Token: 0x06003507 RID: 13575
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __BlueprintUpdateCamera_Internal(IntPtr @this, IntPtr CameraTarget, ref FVector NewCameraLocation, ref FRotator NewCameraRotation, ref float NewCameraFOV);

		// Token: 0x06003508 RID: 13576
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AddNewCameraModifier_Internal(IntPtr @this, IntPtr ModifierClass);

		// Token: 0x06003509 RID: 13577 RVA: 0x0004B578 File Offset: 0x00049778
		static APlayerCameraManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.PlayerCameraManager");
		}

		// Token: 0x0600350A RID: 13578 RVA: 0x0004B586 File Offset: 0x00049786
		protected APlayerCameraManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400123E RID: 4670
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.PlayerCameraManager";

		// Token: 0x0400123F RID: 4671
		private static IntPtr _ClassPtr;

		// Token: 0x04001240 RID: 4672
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001241 RID: 4673
		internal static int __PropertyOffset_PCOwner;

		// Token: 0x04001242 RID: 4674
		internal static int __PropertyOffset_TransformComponent;

		// Token: 0x04001243 RID: 4675
		internal static int __PropertyOffset_DefaultFOV;

		// Token: 0x04001244 RID: 4676
		internal static int __PropertyOffset_DefaultOrthoWidth;

		// Token: 0x04001245 RID: 4677
		internal static int __PropertyOffset_DefaultAspectRatio;

		// Token: 0x04001246 RID: 4678
		internal static int __PropertyOffset_ViewPointOverride;

		// Token: 0x04001247 RID: 4679
		internal static int __PropertyOffset_ViewSizeOverride;

		// Token: 0x04001248 RID: 4680
		internal static int __PropertyOffset_FadeColor;

		// Token: 0x04001249 RID: 4681
		internal static int __PropertyOffset_FadeAmount;

		// Token: 0x0400124A RID: 4682
		internal static int __PropertyOffset_ViewTarget;

		// Token: 0x0400124B RID: 4683
		private FTViewTarget _ViewTarget;

		// Token: 0x0400124C RID: 4684
		internal static int __PropertyOffset_PendingViewTarget;

		// Token: 0x0400124D RID: 4685
		private FTViewTarget _PendingViewTarget;

		// Token: 0x0400124E RID: 4686
		internal static int __PropertyOffset_ModifierList;

		// Token: 0x0400124F RID: 4687
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UCameraModifier> _ModifierList;

		// Token: 0x04001250 RID: 4688
		internal static int __PropertyOffset_DefaultModifiers;

		// Token: 0x04001251 RID: 4689
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TSubclassOf<UCameraModifier>> _DefaultModifiers;

		// Token: 0x04001252 RID: 4690
		internal static int __PropertyOffset_FreeCamDistance;

		// Token: 0x04001253 RID: 4691
		internal static int __PropertyOffset_FreeCamOffset;

		// Token: 0x04001254 RID: 4692
		internal static int __PropertyOffset_ViewTargetOffset;

		// Token: 0x04001255 RID: 4693
		internal static int __PropertyOffset_OnAudioFadeChangeEvent;

		// Token: 0x04001256 RID: 4694
		private FOnAudioFadeChangeSignature _OnAudioFadeChangeEvent;

		// Token: 0x04001257 RID: 4695
		internal static int __PropertyOffset_CachedCameraShakeMod;

		// Token: 0x04001258 RID: 4696
		internal static int __PropertyOffset_bOpenCameraShake;

		// Token: 0x04001259 RID: 4697
		internal static int __PropertyOffset_PostProcessBlendCache;

		// Token: 0x0400125A RID: 4698
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FPostProcessSettings> _PostProcessBlendCache;

		// Token: 0x0400125B RID: 4699
		internal static int __PropertyOffset_AnimCameraActor;

		// Token: 0x0400125C RID: 4700
		internal static int __PropertyOffset_bIsOrthographic;

		// Token: 0x0400125D RID: 4701
		internal static byte __PropertyMask_bIsOrthographic;

		// Token: 0x0400125E RID: 4702
		internal static int __PropertyOffset_bDefaultConstrainAspectRatio;

		// Token: 0x0400125F RID: 4703
		internal static byte __PropertyMask_bDefaultConstrainAspectRatio;

		// Token: 0x04001260 RID: 4704
		internal static int __PropertyOffset_bEnableFading;

		// Token: 0x04001261 RID: 4705
		internal static byte __PropertyMask_bEnableFading;

		// Token: 0x04001262 RID: 4706
		internal static int __PropertyOffset_bClientSimulatingViewTarget;

		// Token: 0x04001263 RID: 4707
		internal static byte __PropertyMask_bClientSimulatingViewTarget;

		// Token: 0x04001264 RID: 4708
		internal static int __PropertyOffset_bUseClientSideCameraUpdates;

		// Token: 0x04001265 RID: 4709
		internal static byte __PropertyMask_bUseClientSideCameraUpdates;

		// Token: 0x04001266 RID: 4710
		internal static int __PropertyOffset_bGameCameraCutThisFrame;

		// Token: 0x04001267 RID: 4711
		internal static byte __PropertyMask_bGameCameraCutThisFrame;

		// Token: 0x04001268 RID: 4712
		internal static int __PropertyOffset_ViewPitchMin;

		// Token: 0x04001269 RID: 4713
		internal static int __PropertyOffset_ViewPitchMax;

		// Token: 0x0400126A RID: 4714
		internal static int __PropertyOffset_ViewYawMin;

		// Token: 0x0400126B RID: 4715
		internal static int __PropertyOffset_ViewYawMax;

		// Token: 0x0400126C RID: 4716
		internal static int __PropertyOffset_ViewRollMin;

		// Token: 0x0400126D RID: 4717
		internal static int __PropertyOffset_ViewRollMax;

		// Token: 0x0400126E RID: 4718
		internal static int __PropertyOffset_ServerUpdateCameraTimeout;

		// Token: 0x0400126F RID: 4719
		internal static int __PropertyOffset_CameraModifyCustomTimeDilation;

		// Token: 0x020009E2 RID: 2530
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __PhotographyCameraModify_FunctionParams
		{
			// Token: 0x04005974 RID: 22900
			[FieldOffset(0)]
			public FVector NewCameraLocation;

			// Token: 0x04005975 RID: 22901
			[FieldOffset(12)]
			public FVector PreviousCameraLocation;

			// Token: 0x04005976 RID: 22902
			[FieldOffset(24)]
			public FVector OriginalCameraLocation;

			// Token: 0x04005977 RID: 22903
			[FieldOffset(36)]
			public FVector ResultCameraLocation;
		}

		// Token: 0x020009E3 RID: 2531
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __BlueprintUpdateCamera_FunctionParams
		{
			// Token: 0x04005978 RID: 22904
			[FieldOffset(0)]
			public IntPtr CameraTarget;

			// Token: 0x04005979 RID: 22905
			[FieldOffset(8)]
			public FVector NewCameraLocation;

			// Token: 0x0400597A RID: 22906
			[FieldOffset(20)]
			public FRotator NewCameraRotation;

			// Token: 0x0400597B RID: 22907
			[FieldOffset(32)]
			public float NewCameraFOV;

			// Token: 0x0400597C RID: 22908
			[FieldOffset(36)]
			public bool __Result;
		}
	}
}
