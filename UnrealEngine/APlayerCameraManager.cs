using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200100B RID: 4107
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.PlayerCameraManager")]
	[UnrealStructLayout(18144, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 18144)]
	public class APlayerCameraManager : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600DE48 RID: 56904 RVA: 0x00147BC2 File Offset: 0x00145DC2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return APlayerCameraManager._ClassPtr;
		}

		// Token: 0x0600DE49 RID: 56905 RVA: 0x00147BD0 File Offset: 0x00145DD0
		public APlayerCameraManager() : this(BuiltinUtils.AllocNativeUObject(APlayerCameraManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600DE4A RID: 56906 RVA: 0x00147BF8 File Offset: 0x00145DF8
		public APlayerCameraManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(APlayerCameraManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700345C RID: 13404
		// (get) Token: 0x0600DE4B RID: 56907 RVA: 0x00147C2B File Offset: 0x00145E2B
		// (set) Token: 0x0600DE4C RID: 56908 RVA: 0x00147C3F File Offset: 0x00145E3F
		[Nullable(2)]
		public unsafe APlayerController PCOwner
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<APlayerController>(base.NativePtr / (IntPtr)sizeof(void*) + APlayerCameraManager.__PropertyOffset_PCOwner);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + APlayerCameraManager.__PropertyOffset_PCOwner, value);
			}
		}

		// Token: 0x1700345D RID: 13405
		// (get) Token: 0x0600DE4D RID: 56909 RVA: 0x00147C54 File Offset: 0x00145E54
		// (set) Token: 0x0600DE4E RID: 56910 RVA: 0x00147C68 File Offset: 0x00145E68
		[Nullable(2)]
		public unsafe USceneComponent TransformComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + APlayerCameraManager.__PropertyOffset_TransformComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + APlayerCameraManager.__PropertyOffset_TransformComponent, value);
			}
		}

		// Token: 0x1700345E RID: 13406
		// (get) Token: 0x0600DE4F RID: 56911 RVA: 0x00147C7D File Offset: 0x00145E7D
		// (set) Token: 0x0600DE50 RID: 56912 RVA: 0x00147C8D File Offset: 0x00145E8D
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

		// Token: 0x1700345F RID: 13407
		// (get) Token: 0x0600DE51 RID: 56913 RVA: 0x00147C9E File Offset: 0x00145E9E
		// (set) Token: 0x0600DE52 RID: 56914 RVA: 0x00147CAE File Offset: 0x00145EAE
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

		// Token: 0x17003460 RID: 13408
		// (get) Token: 0x0600DE53 RID: 56915 RVA: 0x00147CBF File Offset: 0x00145EBF
		// (set) Token: 0x0600DE54 RID: 56916 RVA: 0x00147CCF File Offset: 0x00145ECF
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

		// Token: 0x17003461 RID: 13409
		// (get) Token: 0x0600DE55 RID: 56917 RVA: 0x00147CE0 File Offset: 0x00145EE0
		// (set) Token: 0x0600DE56 RID: 56918 RVA: 0x00147CF4 File Offset: 0x00145EF4
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

		// Token: 0x17003462 RID: 13410
		// (get) Token: 0x0600DE57 RID: 56919 RVA: 0x00147D09 File Offset: 0x00145F09
		// (set) Token: 0x0600DE58 RID: 56920 RVA: 0x00147D1D File Offset: 0x00145F1D
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

		// Token: 0x17003463 RID: 13411
		// (get) Token: 0x0600DE59 RID: 56921 RVA: 0x00147D32 File Offset: 0x00145F32
		// (set) Token: 0x0600DE5A RID: 56922 RVA: 0x00147D46 File Offset: 0x00145F46
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

		// Token: 0x17003464 RID: 13412
		// (get) Token: 0x0600DE5B RID: 56923 RVA: 0x00147D5B File Offset: 0x00145F5B
		// (set) Token: 0x0600DE5C RID: 56924 RVA: 0x00147D6B File Offset: 0x00145F6B
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

		// Token: 0x17003465 RID: 13413
		// (get) Token: 0x0600DE5D RID: 56925 RVA: 0x00147D7C File Offset: 0x00145F7C
		// (set) Token: 0x0600DE5E RID: 56926 RVA: 0x00147DB5 File Offset: 0x00145FB5
		public FCameraCacheEntry CameraCache
		{
			get
			{
				base.FastCheckIsValid();
				FCameraCacheEntry result;
				if ((result = this._CameraCache) == null)
				{
					result = (this._CameraCache = new FCameraCacheEntry(base.NativePtr + (IntPtr)APlayerCameraManager.__PropertyOffset_CameraCache, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCameraCacheEntry.StaticStruct(), base.NativePtr + (IntPtr)APlayerCameraManager.__PropertyOffset_CameraCache, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003466 RID: 13414
		// (get) Token: 0x0600DE5F RID: 56927 RVA: 0x00147DD8 File Offset: 0x00145FD8
		// (set) Token: 0x0600DE60 RID: 56928 RVA: 0x00147E11 File Offset: 0x00146011
		public FCameraCacheEntry LastFrameCameraCache
		{
			get
			{
				base.FastCheckIsValid();
				FCameraCacheEntry result;
				if ((result = this._LastFrameCameraCache) == null)
				{
					result = (this._LastFrameCameraCache = new FCameraCacheEntry(base.NativePtr + (IntPtr)APlayerCameraManager.__PropertyOffset_LastFrameCameraCache, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCameraCacheEntry.StaticStruct(), base.NativePtr + (IntPtr)APlayerCameraManager.__PropertyOffset_LastFrameCameraCache, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003467 RID: 13415
		// (get) Token: 0x0600DE61 RID: 56929 RVA: 0x00147E34 File Offset: 0x00146034
		// (set) Token: 0x0600DE62 RID: 56930 RVA: 0x00147E6D File Offset: 0x0014606D
		public FTViewTarget ViewTarget
		{
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
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTViewTarget.StaticStruct(), base.NativePtr + (IntPtr)APlayerCameraManager.__PropertyOffset_ViewTarget, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003468 RID: 13416
		// (get) Token: 0x0600DE63 RID: 56931 RVA: 0x00147E90 File Offset: 0x00146090
		// (set) Token: 0x0600DE64 RID: 56932 RVA: 0x00147EC9 File Offset: 0x001460C9
		public FTViewTarget PendingViewTarget
		{
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
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTViewTarget.StaticStruct(), base.NativePtr + (IntPtr)APlayerCameraManager.__PropertyOffset_PendingViewTarget, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003469 RID: 13417
		// (get) Token: 0x0600DE65 RID: 56933 RVA: 0x00147EEC File Offset: 0x001460EC
		// (set) Token: 0x0600DE66 RID: 56934 RVA: 0x00147F25 File Offset: 0x00146125
		public FCameraCacheEntry CameraCachePrivate
		{
			get
			{
				base.FastCheckIsValid();
				FCameraCacheEntry result;
				if ((result = this._CameraCachePrivate) == null)
				{
					result = (this._CameraCachePrivate = new FCameraCacheEntry(base.NativePtr + (IntPtr)APlayerCameraManager.__PropertyOffset_CameraCachePrivate, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCameraCacheEntry.StaticStruct(), base.NativePtr + (IntPtr)APlayerCameraManager.__PropertyOffset_CameraCachePrivate, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700346A RID: 13418
		// (get) Token: 0x0600DE67 RID: 56935 RVA: 0x00147F48 File Offset: 0x00146148
		// (set) Token: 0x0600DE68 RID: 56936 RVA: 0x00147F81 File Offset: 0x00146181
		public FCameraCacheEntry LastFrameCameraCachePrivate
		{
			get
			{
				base.FastCheckIsValid();
				FCameraCacheEntry result;
				if ((result = this._LastFrameCameraCachePrivate) == null)
				{
					result = (this._LastFrameCameraCachePrivate = new FCameraCacheEntry(base.NativePtr + (IntPtr)APlayerCameraManager.__PropertyOffset_LastFrameCameraCachePrivate, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCameraCacheEntry.StaticStruct(), base.NativePtr + (IntPtr)APlayerCameraManager.__PropertyOffset_LastFrameCameraCachePrivate, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700346B RID: 13419
		// (get) Token: 0x0600DE69 RID: 56937 RVA: 0x00147FA4 File Offset: 0x001461A4
		// (set) Token: 0x0600DE6A RID: 56938 RVA: 0x00147FDD File Offset: 0x001461DD
		public TArray<UCameraModifier> ModifierList
		{
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
			set
			{
				this.ModifierList.CopyAssign(value);
			}
		}

		// Token: 0x1700346C RID: 13420
		// (get) Token: 0x0600DE6B RID: 56939 RVA: 0x00147FEC File Offset: 0x001461EC
		// (set) Token: 0x0600DE6C RID: 56940 RVA: 0x00148025 File Offset: 0x00146225
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

		// Token: 0x1700346D RID: 13421
		// (get) Token: 0x0600DE6D RID: 56941 RVA: 0x00148033 File Offset: 0x00146233
		// (set) Token: 0x0600DE6E RID: 56942 RVA: 0x00148043 File Offset: 0x00146243
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

		// Token: 0x1700346E RID: 13422
		// (get) Token: 0x0600DE6F RID: 56943 RVA: 0x00148054 File Offset: 0x00146254
		// (set) Token: 0x0600DE70 RID: 56944 RVA: 0x00148068 File Offset: 0x00146268
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

		// Token: 0x1700346F RID: 13423
		// (get) Token: 0x0600DE71 RID: 56945 RVA: 0x0014807D File Offset: 0x0014627D
		// (set) Token: 0x0600DE72 RID: 56946 RVA: 0x00148091 File Offset: 0x00146291
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

		// Token: 0x17003470 RID: 13424
		// (get) Token: 0x0600DE73 RID: 56947 RVA: 0x001480A8 File Offset: 0x001462A8
		// (set) Token: 0x0600DE74 RID: 56948 RVA: 0x001480E1 File Offset: 0x001462E1
		public FOnAudioFadeChangeSignature OnAudioFadeChangeEvent
		{
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
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)APlayerCameraManager.__PropertyOffset_OnAudioFadeChangeEvent, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17003471 RID: 13425
		// (get) Token: 0x0600DE75 RID: 56949 RVA: 0x00148104 File Offset: 0x00146304
		// (set) Token: 0x0600DE76 RID: 56950 RVA: 0x0014813D File Offset: 0x0014633D
		public TArray<AEmitterCameraLensEffectBase> CameraLensEffects
		{
			get
			{
				base.FastCheckIsValid();
				TArray<AEmitterCameraLensEffectBase> result;
				if ((result = this._CameraLensEffects) == null)
				{
					result = (this._CameraLensEffects = new TArray<AEmitterCameraLensEffectBase>(base.NativePtr + (IntPtr)APlayerCameraManager.__PropertyOffset_CameraLensEffects, this));
				}
				return result;
			}
			set
			{
				this.CameraLensEffects.CopyAssign(value);
			}
		}

		// Token: 0x17003472 RID: 13426
		// (get) Token: 0x0600DE77 RID: 56951 RVA: 0x0014814B File Offset: 0x0014634B
		// (set) Token: 0x0600DE78 RID: 56952 RVA: 0x0014815F File Offset: 0x0014635F
		[Nullable(2)]
		public unsafe UCameraModifier_CameraShake CachedCameraShakeMod
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCameraModifier_CameraShake>(base.NativePtr / (IntPtr)sizeof(void*) + APlayerCameraManager.__PropertyOffset_CachedCameraShakeMod);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + APlayerCameraManager.__PropertyOffset_CachedCameraShakeMod, value);
			}
		}

		// Token: 0x17003473 RID: 13427
		// (get) Token: 0x0600DE79 RID: 56953 RVA: 0x00148174 File Offset: 0x00146374
		// (set) Token: 0x0600DE7A RID: 56954 RVA: 0x00148184 File Offset: 0x00146384
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

		// Token: 0x17003474 RID: 13428
		// (get) Token: 0x0600DE7B RID: 56955 RVA: 0x00148198 File Offset: 0x00146398
		// (set) Token: 0x0600DE7C RID: 56956 RVA: 0x001481D2 File Offset: 0x001463D2
		public TFixedArray<UCameraAnimInst> AnimInstPool
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<UCameraAnimInst> result;
				if ((result = this._AnimInstPool) == null)
				{
					result = (this._AnimInstPool = new TFixedArray<UCameraAnimInst>(base.NativePtr + (IntPtr)APlayerCameraManager.__PropertyOffset_AnimInstPool, 8, this));
				}
				return result;
			}
			set
			{
				this.AnimInstPool.CopyAssign(value);
			}
		}

		// Token: 0x17003475 RID: 13429
		// (get) Token: 0x0600DE7D RID: 56957 RVA: 0x001481E0 File Offset: 0x001463E0
		// (set) Token: 0x0600DE7E RID: 56958 RVA: 0x00148219 File Offset: 0x00146419
		public TArray<FPostProcessSettings> PostProcessBlendCache
		{
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
			set
			{
				this.PostProcessBlendCache.CopyAssign(value);
			}
		}

		// Token: 0x17003476 RID: 13430
		// (get) Token: 0x0600DE7F RID: 56959 RVA: 0x00148228 File Offset: 0x00146428
		// (set) Token: 0x0600DE80 RID: 56960 RVA: 0x00148261 File Offset: 0x00146461
		public TArray<UCameraAnimInst> ActiveAnims
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UCameraAnimInst> result;
				if ((result = this._ActiveAnims) == null)
				{
					result = (this._ActiveAnims = new TArray<UCameraAnimInst>(base.NativePtr + (IntPtr)APlayerCameraManager.__PropertyOffset_ActiveAnims, this));
				}
				return result;
			}
			set
			{
				this.ActiveAnims.CopyAssign(value);
			}
		}

		// Token: 0x17003477 RID: 13431
		// (get) Token: 0x0600DE81 RID: 56961 RVA: 0x00148270 File Offset: 0x00146470
		// (set) Token: 0x0600DE82 RID: 56962 RVA: 0x001482A9 File Offset: 0x001464A9
		public TArray<UCameraAnimInst> FreeAnims
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UCameraAnimInst> result;
				if ((result = this._FreeAnims) == null)
				{
					result = (this._FreeAnims = new TArray<UCameraAnimInst>(base.NativePtr + (IntPtr)APlayerCameraManager.__PropertyOffset_FreeAnims, this));
				}
				return result;
			}
			set
			{
				this.FreeAnims.CopyAssign(value);
			}
		}

		// Token: 0x17003478 RID: 13432
		// (get) Token: 0x0600DE83 RID: 56963 RVA: 0x001482B7 File Offset: 0x001464B7
		// (set) Token: 0x0600DE84 RID: 56964 RVA: 0x001482CB File Offset: 0x001464CB
		[Nullable(2)]
		public unsafe ACameraActor AnimCameraActor
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ACameraActor>(base.NativePtr / (IntPtr)sizeof(void*) + APlayerCameraManager.__PropertyOffset_AnimCameraActor);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + APlayerCameraManager.__PropertyOffset_AnimCameraActor, value);
			}
		}

		// Token: 0x17003479 RID: 13433
		// (get) Token: 0x0600DE85 RID: 56965 RVA: 0x001482E0 File Offset: 0x001464E0
		// (set) Token: 0x0600DE86 RID: 56966 RVA: 0x001482F9 File Offset: 0x001464F9
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

		// Token: 0x1700347A RID: 13434
		// (get) Token: 0x0600DE87 RID: 56967 RVA: 0x00148329 File Offset: 0x00146529
		// (set) Token: 0x0600DE88 RID: 56968 RVA: 0x00148342 File Offset: 0x00146542
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

		// Token: 0x1700347B RID: 13435
		// (get) Token: 0x0600DE89 RID: 56969 RVA: 0x00148372 File Offset: 0x00146572
		// (set) Token: 0x0600DE8A RID: 56970 RVA: 0x0014838B File Offset: 0x0014658B
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

		// Token: 0x1700347C RID: 13436
		// (get) Token: 0x0600DE8B RID: 56971 RVA: 0x001483BB File Offset: 0x001465BB
		// (set) Token: 0x0600DE8C RID: 56972 RVA: 0x001483D4 File Offset: 0x001465D4
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

		// Token: 0x1700347D RID: 13437
		// (get) Token: 0x0600DE8D RID: 56973 RVA: 0x00148404 File Offset: 0x00146604
		// (set) Token: 0x0600DE8E RID: 56974 RVA: 0x0014841D File Offset: 0x0014661D
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

		// Token: 0x1700347E RID: 13438
		// (get) Token: 0x0600DE8F RID: 56975 RVA: 0x0014844D File Offset: 0x0014664D
		// (set) Token: 0x0600DE90 RID: 56976 RVA: 0x00148466 File Offset: 0x00146666
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

		// Token: 0x1700347F RID: 13439
		// (get) Token: 0x0600DE91 RID: 56977 RVA: 0x00148496 File Offset: 0x00146696
		// (set) Token: 0x0600DE92 RID: 56978 RVA: 0x001484A6 File Offset: 0x001466A6
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

		// Token: 0x17003480 RID: 13440
		// (get) Token: 0x0600DE93 RID: 56979 RVA: 0x001484B7 File Offset: 0x001466B7
		// (set) Token: 0x0600DE94 RID: 56980 RVA: 0x001484C7 File Offset: 0x001466C7
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

		// Token: 0x17003481 RID: 13441
		// (get) Token: 0x0600DE95 RID: 56981 RVA: 0x001484D8 File Offset: 0x001466D8
		// (set) Token: 0x0600DE96 RID: 56982 RVA: 0x001484E8 File Offset: 0x001466E8
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

		// Token: 0x17003482 RID: 13442
		// (get) Token: 0x0600DE97 RID: 56983 RVA: 0x001484F9 File Offset: 0x001466F9
		// (set) Token: 0x0600DE98 RID: 56984 RVA: 0x00148509 File Offset: 0x00146709
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

		// Token: 0x17003483 RID: 13443
		// (get) Token: 0x0600DE99 RID: 56985 RVA: 0x0014851A File Offset: 0x0014671A
		// (set) Token: 0x0600DE9A RID: 56986 RVA: 0x0014852A File Offset: 0x0014672A
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

		// Token: 0x17003484 RID: 13444
		// (get) Token: 0x0600DE9B RID: 56987 RVA: 0x0014853B File Offset: 0x0014673B
		// (set) Token: 0x0600DE9C RID: 56988 RVA: 0x0014854B File Offset: 0x0014674B
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

		// Token: 0x17003485 RID: 13445
		// (get) Token: 0x0600DE9D RID: 56989 RVA: 0x0014855C File Offset: 0x0014675C
		// (set) Token: 0x0600DE9E RID: 56990 RVA: 0x0014856C File Offset: 0x0014676C
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

		// Token: 0x17003486 RID: 13446
		// (get) Token: 0x0600DE9F RID: 56991 RVA: 0x0014857D File Offset: 0x0014677D
		// (set) Token: 0x0600DEA0 RID: 56992 RVA: 0x0014858D File Offset: 0x0014678D
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

		// Token: 0x0600DEA1 RID: 56993 RVA: 0x0014859E File Offset: 0x0014679E
		public void SwapPendingViewTargetWhenUsingClientSideCameraUpdates()
		{
			APlayerCameraManager.__SwapPendingViewTargetWhenUsingClientSideCameraUpdates_Internal(base.NativePtr);
		}

		// Token: 0x0600DEA2 RID: 56994 RVA: 0x001485AB File Offset: 0x001467AB
		[NullableContext(2)]
		public void StopCameraShake(UCameraShakeBase ShakeInstance, bool bImmediately = true)
		{
			APlayerCameraManager.__StopCameraShake_Internal(base.NativePtr, (ShakeInstance != null) ? ShakeInstance.NativePtr : IntPtr.Zero, bImmediately);
		}

		// Token: 0x0600DEA3 RID: 56995 RVA: 0x001485C9 File Offset: 0x001467C9
		public void StopCameraFade()
		{
			APlayerCameraManager.__StopCameraFade_Internal(base.NativePtr);
		}

		// Token: 0x0600DEA4 RID: 56996 RVA: 0x001485D6 File Offset: 0x001467D6
		[NullableContext(2)]
		public void StopCameraAnimInst(UCameraAnimInst AnimInst, bool bImmediate = false)
		{
			APlayerCameraManager.__StopCameraAnimInst_Internal(base.NativePtr, (AnimInst != null) ? AnimInst.NativePtr : IntPtr.Zero, bImmediate);
		}

		// Token: 0x0600DEA5 RID: 56997 RVA: 0x001485F4 File Offset: 0x001467F4
		[NullableContext(2)]
		public void StopAllInstancesOfCameraShakeFromSource([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UCameraShakeBase> Shake, UCameraShakeSourceComponent SourceComponent, bool bImmediately = true)
		{
			APlayerCameraManager.__StopAllInstancesOfCameraShakeFromSource_Internal(base.NativePtr, Shake._NativePtr, (SourceComponent != null) ? SourceComponent.NativePtr : IntPtr.Zero, bImmediately);
		}

		// Token: 0x0600DEA6 RID: 56998 RVA: 0x00148618 File Offset: 0x00146818
		public void StopAllInstancesOfCameraShake([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UCameraShakeBase> Shake, bool bImmediately = true)
		{
			APlayerCameraManager.__StopAllInstancesOfCameraShake_Internal(base.NativePtr, Shake._NativePtr, bImmediately);
		}

		// Token: 0x0600DEA7 RID: 56999 RVA: 0x0014862C File Offset: 0x0014682C
		[NullableContext(2)]
		public void StopAllInstancesOfCameraAnim(UCameraAnim Anim, bool bImmediate = false)
		{
			APlayerCameraManager.__StopAllInstancesOfCameraAnim_Internal(base.NativePtr, (Anim != null) ? Anim.NativePtr : IntPtr.Zero, bImmediate);
		}

		// Token: 0x0600DEA8 RID: 57000 RVA: 0x0014864A File Offset: 0x0014684A
		[NullableContext(2)]
		public void StopAllCameraShakesFromSource(UCameraShakeSourceComponent SourceComponent, bool bImmediately = true)
		{
			APlayerCameraManager.__StopAllCameraShakesFromSource_Internal(base.NativePtr, (SourceComponent != null) ? SourceComponent.NativePtr : IntPtr.Zero, bImmediately);
		}

		// Token: 0x0600DEA9 RID: 57001 RVA: 0x00148668 File Offset: 0x00146868
		public void StopAllCameraShakes(bool bImmediately = true)
		{
			APlayerCameraManager.__StopAllCameraShakes_Internal(base.NativePtr, bImmediately);
		}

		// Token: 0x0600DEAA RID: 57002 RVA: 0x00148676 File Offset: 0x00146876
		public void StopAllCameraAnims(bool bImmediate = false)
		{
			APlayerCameraManager.__StopAllCameraAnims_Internal(base.NativePtr, bImmediate);
		}

		// Token: 0x0600DEAB RID: 57003 RVA: 0x00148684 File Offset: 0x00146884
		[NullableContext(2)]
		public UMatineeCameraShake StartMatineeCameraShakeFromSource([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UMatineeCameraShake> ShakeClass, UCameraShakeSourceComponent SourceComponent, float Scale = 1f, ECameraShakePlaySpace PlaySpace = ECameraShakePlaySpace.CameraLocal, FRotator UserPlaySpaceRot = default(FRotator), float TimeDilation = 1f)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMatineeCameraShake>(APlayerCameraManager.__StartMatineeCameraShakeFromSource_Internal(base.NativePtr, ShakeClass._NativePtr, (SourceComponent != null) ? SourceComponent.NativePtr : IntPtr.Zero, Scale, PlaySpace, UserPlaySpaceRot, TimeDilation));
		}

		// Token: 0x0600DEAC RID: 57004 RVA: 0x001486B3 File Offset: 0x001468B3
		[NullableContext(2)]
		public UMatineeCameraShake StartMatineeCameraShake([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UMatineeCameraShake> ShakeClass, float Scale = 1f, ECameraShakePlaySpace PlaySpace = ECameraShakePlaySpace.CameraLocal, FRotator UserPlaySpaceRot = default(FRotator), float TimeDilation = 1f)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMatineeCameraShake>(APlayerCameraManager.__StartMatineeCameraShake_Internal(base.NativePtr, ShakeClass._NativePtr, Scale, PlaySpace, UserPlaySpaceRot, TimeDilation));
		}

		// Token: 0x0600DEAD RID: 57005 RVA: 0x001486D1 File Offset: 0x001468D1
		[NullableContext(2)]
		public UCameraShakeBase StartCameraShakeFromSource([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UCameraShakeBase> ShakeClass, UCameraShakeSourceComponent SourceComponent, float Scale = 1f, ECameraShakePlaySpace PlaySpace = ECameraShakePlaySpace.CameraLocal, FRotator UserPlaySpaceRot = default(FRotator), float TimeDilation = 1f)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UCameraShakeBase>(APlayerCameraManager.__StartCameraShakeFromSource_Internal(base.NativePtr, ShakeClass._NativePtr, (SourceComponent != null) ? SourceComponent.NativePtr : IntPtr.Zero, Scale, PlaySpace, UserPlaySpaceRot, TimeDilation));
		}

		// Token: 0x0600DEAE RID: 57006 RVA: 0x00148700 File Offset: 0x00146900
		[NullableContext(2)]
		public UCameraShakeBase StartCameraShake([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UCameraShakeBase> ShakeClass, float Scale = 1f, ECameraShakePlaySpace PlaySpace = ECameraShakePlaySpace.CameraLocal, FRotator UserPlaySpaceRot = default(FRotator), float TimeDilation = 1f)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UCameraShakeBase>(APlayerCameraManager.__StartCameraShake_Internal(base.NativePtr, ShakeClass._NativePtr, Scale, PlaySpace, UserPlaySpaceRot, TimeDilation));
		}

		// Token: 0x0600DEAF RID: 57007 RVA: 0x0014871E File Offset: 0x0014691E
		public void StartCameraFade(float FromAlpha, float ToAlpha, float Duration, FLinearColor Color, bool bShouldFadeAudio = false, bool bHoldWhenFinished = false, ECameraFadeMode FadeMode = ECameraFadeMode.CFM_Linear)
		{
			APlayerCameraManager.__StartCameraFade_Internal(base.NativePtr, FromAlpha, ToAlpha, Duration, Color, bShouldFadeAudio, bHoldWhenFinished, FadeMode);
		}

		// Token: 0x0600DEB0 RID: 57008 RVA: 0x0014873B File Offset: 0x0014693B
		public void SetManualCameraFade(float InFadeAmount, FLinearColor Color, bool bInFadeAudio)
		{
			APlayerCameraManager.__SetManualCameraFade_Internal(base.NativePtr, InFadeAmount, Color, bInFadeAudio);
		}

		// Token: 0x0600DEB1 RID: 57009 RVA: 0x0014874B File Offset: 0x0014694B
		public void SetGameCameraCutThisFrame()
		{
			APlayerCameraManager.__SetGameCameraCutThisFrame_Internal(base.NativePtr);
		}

		// Token: 0x0600DEB2 RID: 57010 RVA: 0x00148758 File Offset: 0x00146958
		[NullableContext(2)]
		public void ResetViewTarget(AActor NewViewTarget, in FViewTargetTransitionParams TransitionParams)
		{
			APlayerCameraManager.__ResetViewTarget_Internal(base.NativePtr, (NewViewTarget != null) ? NewViewTarget.NativePtr : IntPtr.Zero, (TransitionParams ?? new FViewTargetTransitionParams()).NativePtr);
		}

		// Token: 0x0600DEB3 RID: 57011 RVA: 0x00148785 File Offset: 0x00146985
		[NullableContext(2)]
		public bool RemoveCameraModifier(UCameraModifier ModifierToRemove)
		{
			return APlayerCameraManager.__RemoveCameraModifier_Internal(base.NativePtr, (ModifierToRemove != null) ? ModifierToRemove.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600DEB4 RID: 57012 RVA: 0x001487A2 File Offset: 0x001469A2
		[NullableContext(2)]
		public void RemoveCameraLensEffect(AEmitterCameraLensEffectBase Emitter)
		{
			APlayerCameraManager.__RemoveCameraLensEffect_Internal(base.NativePtr, (Emitter != null) ? Emitter.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600DEB5 RID: 57013 RVA: 0x001487C0 File Offset: 0x001469C0
		[NullableContext(2)]
		public UCameraAnimInst PlayCameraAnim(UCameraAnim Anim, float Rate = 1f, float Scale = 1f, float BlendInTime = 0f, float BlendOutTime = 0f, bool bLoop = false, bool bRandomStartTime = false, float Duration = 0f, ECameraShakePlaySpace PlaySpace = ECameraShakePlaySpace.CameraLocal, FRotator UserPlaySpaceRot = default(FRotator))
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UCameraAnimInst>(APlayerCameraManager.__PlayCameraAnim_Internal(base.NativePtr, (Anim != null) ? Anim.NativePtr : IntPtr.Zero, Rate, Scale, BlendInTime, BlendOutTime, bLoop, bRandomStartTime, Duration, PlaySpace, UserPlaySpaceRot));
		}

		// Token: 0x0600DEB6 RID: 57014 RVA: 0x00148800 File Offset: 0x00146A00
		public unsafe virtual void PhotographyCameraModify(FVector NewCameraLocation, FVector PreviousCameraLocation, FVector OriginalCameraLocation, ref FVector ResultCameraLocation)
		{
			fixed (FVector* ptr = &ResultCameraLocation)
			{
				void* ptr2 = (void*)ptr;
				APlayerCameraManager.__PhotographyCameraModify_Internal(base.NativePtr, NewCameraLocation, PreviousCameraLocation, OriginalCameraLocation, ref ResultCameraLocation);
			}
		}

		// Token: 0x0600DEB7 RID: 57015 RVA: 0x00148828 File Offset: 0x00146A28
		protected unsafe virtual void PhotographyCameraModify_Implementation(FVector NewCameraLocation, FVector PreviousCameraLocation, FVector OriginalCameraLocation, ref FVector ResultCameraLocation)
		{
			fixed (FVector* ptr = &ResultCameraLocation)
			{
				void* ptr2 = (void*)ptr;
				APlayerCameraManager.__PhotographyCameraModify_Implementation_Internal(base.NativePtr, NewCameraLocation, PreviousCameraLocation, OriginalCameraLocation, ref ResultCameraLocation);
			}
		}

		// Token: 0x0600DEB8 RID: 57016 RVA: 0x0014884E File Offset: 0x00146A4E
		public virtual void OnPhotographySessionStart()
		{
			APlayerCameraManager.__OnPhotographySessionStart_Internal(base.NativePtr);
		}

		// Token: 0x0600DEB9 RID: 57017 RVA: 0x0014885B File Offset: 0x00146A5B
		protected virtual void OnPhotographySessionStart_Implementation()
		{
			APlayerCameraManager.__OnPhotographySessionStart_Implementation_Internal(base.NativePtr);
		}

		// Token: 0x0600DEBA RID: 57018 RVA: 0x00148868 File Offset: 0x00146A68
		public virtual void OnPhotographySessionEnd()
		{
			APlayerCameraManager.__OnPhotographySessionEnd_Internal(base.NativePtr);
		}

		// Token: 0x0600DEBB RID: 57019 RVA: 0x00148875 File Offset: 0x00146A75
		protected virtual void OnPhotographySessionEnd_Implementation()
		{
			APlayerCameraManager.__OnPhotographySessionEnd_Implementation_Internal(base.NativePtr);
		}

		// Token: 0x0600DEBC RID: 57020 RVA: 0x00148882 File Offset: 0x00146A82
		public virtual void OnPhotographyMultiPartCaptureStart()
		{
			APlayerCameraManager.__OnPhotographyMultiPartCaptureStart_Internal(base.NativePtr);
		}

		// Token: 0x0600DEBD RID: 57021 RVA: 0x0014888F File Offset: 0x00146A8F
		protected virtual void OnPhotographyMultiPartCaptureStart_Implementation()
		{
			APlayerCameraManager.__OnPhotographyMultiPartCaptureStart_Implementation_Internal(base.NativePtr);
		}

		// Token: 0x0600DEBE RID: 57022 RVA: 0x0014889C File Offset: 0x00146A9C
		public virtual void OnPhotographyMultiPartCaptureEnd()
		{
			APlayerCameraManager.__OnPhotographyMultiPartCaptureEnd_Internal(base.NativePtr);
		}

		// Token: 0x0600DEBF RID: 57023 RVA: 0x001488A9 File Offset: 0x00146AA9
		protected virtual void OnPhotographyMultiPartCaptureEnd_Implementation()
		{
			APlayerCameraManager.__OnPhotographyMultiPartCaptureEnd_Implementation_Internal(base.NativePtr);
		}

		// Token: 0x0600DEC0 RID: 57024 RVA: 0x001488B6 File Offset: 0x00146AB6
		[NullableContext(2)]
		public APlayerController GetOwningPlayerController()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<APlayerController>(APlayerCameraManager.__GetOwningPlayerController_Internal(base.NativePtr));
		}

		// Token: 0x0600DEC1 RID: 57025 RVA: 0x001488C8 File Offset: 0x00146AC8
		public float GetFOVAngle()
		{
			return APlayerCameraManager.__GetFOVAngle_Internal(base.NativePtr);
		}

		// Token: 0x0600DEC2 RID: 57026 RVA: 0x001488D5 File Offset: 0x00146AD5
		public FRotator GetCameraRotation()
		{
			return APlayerCameraManager.__GetCameraRotation_Internal(base.NativePtr);
		}

		// Token: 0x0600DEC3 RID: 57027 RVA: 0x001488E2 File Offset: 0x00146AE2
		public FVector GetCameraLocation()
		{
			return APlayerCameraManager.__GetCameraLocation_Internal(base.NativePtr);
		}

		// Token: 0x0600DEC4 RID: 57028 RVA: 0x001488EF File Offset: 0x00146AEF
		[NullableContext(2)]
		public UCameraModifier FindCameraModifierByClass([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UCameraModifier> ModifierClass)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UCameraModifier>(APlayerCameraManager.__FindCameraModifierByClass_Internal(base.NativePtr, ModifierClass._NativePtr));
		}

		// Token: 0x0600DEC5 RID: 57029 RVA: 0x00148907 File Offset: 0x00146B07
		public FVectorDouble D_GetCameraLocation()
		{
			return APlayerCameraManager.__D_GetCameraLocation_Internal(base.NativePtr);
		}

		// Token: 0x0600DEC6 RID: 57030 RVA: 0x00148914 File Offset: 0x00146B14
		public void ClearCameraLensEffects()
		{
			APlayerCameraManager.__ClearCameraLensEffects_Internal(base.NativePtr);
		}

		// Token: 0x0600DEC7 RID: 57031 RVA: 0x00148924 File Offset: 0x00146B24
		[NullableContext(2)]
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

		// Token: 0x0600DEC8 RID: 57032 RVA: 0x00148964 File Offset: 0x00146B64
		[NullableContext(2)]
		public UCameraModifier AddNewCameraModifier([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UCameraModifier> ModifierClass)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UCameraModifier>(APlayerCameraManager.__AddNewCameraModifier_Internal(base.NativePtr, ModifierClass._NativePtr));
		}

		// Token: 0x0600DEC9 RID: 57033 RVA: 0x0014897C File Offset: 0x00146B7C
		[NullableContext(2)]
		public AEmitterCameraLensEffectBase AddCameraLensEffect([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<AEmitterCameraLensEffectBase> LensEffectEmitterClass)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AEmitterCameraLensEffectBase>(APlayerCameraManager.__AddCameraLensEffect_Internal(base.NativePtr, LensEffectEmitterClass._NativePtr));
		}

		// Token: 0x0600DECA RID: 57034
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SwapPendingViewTargetWhenUsingClientSideCameraUpdates_Internal(IntPtr @this);

		// Token: 0x0600DECB RID: 57035
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopCameraShake_Internal(IntPtr @this, IntPtr ShakeInstance, bool bImmediately);

		// Token: 0x0600DECC RID: 57036
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopCameraFade_Internal(IntPtr @this);

		// Token: 0x0600DECD RID: 57037
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopCameraAnimInst_Internal(IntPtr @this, IntPtr AnimInst, bool bImmediate);

		// Token: 0x0600DECE RID: 57038
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopAllInstancesOfCameraShakeFromSource_Internal(IntPtr @this, IntPtr Shake, IntPtr SourceComponent, bool bImmediately);

		// Token: 0x0600DECF RID: 57039
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopAllInstancesOfCameraShake_Internal(IntPtr @this, IntPtr Shake, bool bImmediately);

		// Token: 0x0600DED0 RID: 57040
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopAllInstancesOfCameraAnim_Internal(IntPtr @this, IntPtr Anim, bool bImmediate);

		// Token: 0x0600DED1 RID: 57041
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopAllCameraShakesFromSource_Internal(IntPtr @this, IntPtr SourceComponent, bool bImmediately);

		// Token: 0x0600DED2 RID: 57042
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopAllCameraShakes_Internal(IntPtr @this, bool bImmediately);

		// Token: 0x0600DED3 RID: 57043
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopAllCameraAnims_Internal(IntPtr @this, bool bImmediate);

		// Token: 0x0600DED4 RID: 57044
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __StartMatineeCameraShakeFromSource_Internal(IntPtr @this, IntPtr ShakeClass, IntPtr SourceComponent, float Scale, ECameraShakePlaySpace PlaySpace, FRotator UserPlaySpaceRot, float TimeDilation);

		// Token: 0x0600DED5 RID: 57045
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __StartMatineeCameraShake_Internal(IntPtr @this, IntPtr ShakeClass, float Scale, ECameraShakePlaySpace PlaySpace, FRotator UserPlaySpaceRot, float TimeDilation);

		// Token: 0x0600DED6 RID: 57046
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __StartCameraShakeFromSource_Internal(IntPtr @this, IntPtr ShakeClass, IntPtr SourceComponent, float Scale, ECameraShakePlaySpace PlaySpace, FRotator UserPlaySpaceRot, float TimeDilation);

		// Token: 0x0600DED7 RID: 57047
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __StartCameraShake_Internal(IntPtr @this, IntPtr ShakeClass, float Scale, ECameraShakePlaySpace PlaySpace, FRotator UserPlaySpaceRot, float TimeDilation);

		// Token: 0x0600DED8 RID: 57048
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StartCameraFade_Internal(IntPtr @this, float FromAlpha, float ToAlpha, float Duration, FLinearColor Color, bool bShouldFadeAudio, bool bHoldWhenFinished, TEnumAsByte<ECameraFadeMode> FadeMode);

		// Token: 0x0600DED9 RID: 57049
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetManualCameraFade_Internal(IntPtr @this, float InFadeAmount, FLinearColor Color, bool bInFadeAudio);

		// Token: 0x0600DEDA RID: 57050
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGameCameraCutThisFrame_Internal(IntPtr @this);

		// Token: 0x0600DEDB RID: 57051
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetViewTarget_Internal(IntPtr @this, IntPtr NewViewTarget, IntPtr TransitionParams);

		// Token: 0x0600DEDC RID: 57052
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __RemoveCameraModifier_Internal(IntPtr @this, IntPtr ModifierToRemove);

		// Token: 0x0600DEDD RID: 57053
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveCameraLensEffect_Internal(IntPtr @this, IntPtr Emitter);

		// Token: 0x0600DEDE RID: 57054
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __PlayCameraAnim_Internal(IntPtr @this, IntPtr Anim, float Rate, float Scale, float BlendInTime, float BlendOutTime, bool bLoop, bool bRandomStartTime, float Duration, ECameraShakePlaySpace PlaySpace, FRotator UserPlaySpaceRot);

		// Token: 0x0600DEDF RID: 57055
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PhotographyCameraModify_Internal(IntPtr @this, FVector NewCameraLocation, FVector PreviousCameraLocation, FVector OriginalCameraLocation, ref FVector ResultCameraLocation);

		// Token: 0x0600DEE0 RID: 57056
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PhotographyCameraModify_Implementation_Internal(IntPtr @this, FVector NewCameraLocation, FVector PreviousCameraLocation, FVector OriginalCameraLocation, ref FVector ResultCameraLocation);

		// Token: 0x0600DEE1 RID: 57057
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnPhotographySessionStart_Internal(IntPtr @this);

		// Token: 0x0600DEE2 RID: 57058
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnPhotographySessionStart_Implementation_Internal(IntPtr @this);

		// Token: 0x0600DEE3 RID: 57059
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnPhotographySessionEnd_Internal(IntPtr @this);

		// Token: 0x0600DEE4 RID: 57060
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnPhotographySessionEnd_Implementation_Internal(IntPtr @this);

		// Token: 0x0600DEE5 RID: 57061
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnPhotographyMultiPartCaptureStart_Internal(IntPtr @this);

		// Token: 0x0600DEE6 RID: 57062
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnPhotographyMultiPartCaptureStart_Implementation_Internal(IntPtr @this);

		// Token: 0x0600DEE7 RID: 57063
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnPhotographyMultiPartCaptureEnd_Internal(IntPtr @this);

		// Token: 0x0600DEE8 RID: 57064
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnPhotographyMultiPartCaptureEnd_Implementation_Internal(IntPtr @this);

		// Token: 0x0600DEE9 RID: 57065
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetOwningPlayerController_Internal(IntPtr @this);

		// Token: 0x0600DEEA RID: 57066
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetFOVAngle_Internal(IntPtr @this);

		// Token: 0x0600DEEB RID: 57067
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator __GetCameraRotation_Internal(IntPtr @this);

		// Token: 0x0600DEEC RID: 57068
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetCameraLocation_Internal(IntPtr @this);

		// Token: 0x0600DEED RID: 57069
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __FindCameraModifierByClass_Internal(IntPtr @this, IntPtr ModifierClass);

		// Token: 0x0600DEEE RID: 57070
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_GetCameraLocation_Internal(IntPtr @this);

		// Token: 0x0600DEEF RID: 57071
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearCameraLensEffects_Internal(IntPtr @this);

		// Token: 0x0600DEF0 RID: 57072
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __BlueprintUpdateCamera_Internal(IntPtr @this, IntPtr CameraTarget, ref FVector NewCameraLocation, ref FRotator NewCameraRotation, ref float NewCameraFOV);

		// Token: 0x0600DEF1 RID: 57073
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AddNewCameraModifier_Internal(IntPtr @this, IntPtr ModifierClass);

		// Token: 0x0600DEF2 RID: 57074
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AddCameraLensEffect_Internal(IntPtr @this, IntPtr LensEffectEmitterClass);

		// Token: 0x0600DEF3 RID: 57075 RVA: 0x00148994 File Offset: 0x00146B94
		static APlayerCameraManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.PlayerCameraManager");
		}

		// Token: 0x0600DEF4 RID: 57076 RVA: 0x001489A2 File Offset: 0x00146BA2
		protected APlayerCameraManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04007818 RID: 30744
		public new const string __ObjectPath = "/Script/Engine.PlayerCameraManager";

		// Token: 0x04007819 RID: 30745
		private static IntPtr _ClassPtr;

		// Token: 0x0400781A RID: 30746
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400781B RID: 30747
		internal static int __PropertyOffset_PCOwner;

		// Token: 0x0400781C RID: 30748
		internal static int __PropertyOffset_TransformComponent;

		// Token: 0x0400781D RID: 30749
		internal static int __PropertyOffset_DefaultFOV;

		// Token: 0x0400781E RID: 30750
		internal static int __PropertyOffset_DefaultOrthoWidth;

		// Token: 0x0400781F RID: 30751
		internal static int __PropertyOffset_DefaultAspectRatio;

		// Token: 0x04007820 RID: 30752
		internal static int __PropertyOffset_ViewPointOverride;

		// Token: 0x04007821 RID: 30753
		internal static int __PropertyOffset_ViewSizeOverride;

		// Token: 0x04007822 RID: 30754
		internal static int __PropertyOffset_FadeColor;

		// Token: 0x04007823 RID: 30755
		internal static int __PropertyOffset_FadeAmount;

		// Token: 0x04007824 RID: 30756
		internal static int __PropertyOffset_CameraCache;

		// Token: 0x04007825 RID: 30757
		[Nullable(2)]
		private FCameraCacheEntry _CameraCache;

		// Token: 0x04007826 RID: 30758
		internal static int __PropertyOffset_LastFrameCameraCache;

		// Token: 0x04007827 RID: 30759
		[Nullable(2)]
		private FCameraCacheEntry _LastFrameCameraCache;

		// Token: 0x04007828 RID: 30760
		internal static int __PropertyOffset_ViewTarget;

		// Token: 0x04007829 RID: 30761
		[Nullable(2)]
		private FTViewTarget _ViewTarget;

		// Token: 0x0400782A RID: 30762
		internal static int __PropertyOffset_PendingViewTarget;

		// Token: 0x0400782B RID: 30763
		[Nullable(2)]
		private FTViewTarget _PendingViewTarget;

		// Token: 0x0400782C RID: 30764
		internal static int __PropertyOffset_CameraCachePrivate;

		// Token: 0x0400782D RID: 30765
		[Nullable(2)]
		private FCameraCacheEntry _CameraCachePrivate;

		// Token: 0x0400782E RID: 30766
		internal static int __PropertyOffset_LastFrameCameraCachePrivate;

		// Token: 0x0400782F RID: 30767
		[Nullable(2)]
		private FCameraCacheEntry _LastFrameCameraCachePrivate;

		// Token: 0x04007830 RID: 30768
		internal static int __PropertyOffset_ModifierList;

		// Token: 0x04007831 RID: 30769
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UCameraModifier> _ModifierList;

		// Token: 0x04007832 RID: 30770
		internal static int __PropertyOffset_DefaultModifiers;

		// Token: 0x04007833 RID: 30771
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TSubclassOf<UCameraModifier>> _DefaultModifiers;

		// Token: 0x04007834 RID: 30772
		internal static int __PropertyOffset_FreeCamDistance;

		// Token: 0x04007835 RID: 30773
		internal static int __PropertyOffset_FreeCamOffset;

		// Token: 0x04007836 RID: 30774
		internal static int __PropertyOffset_ViewTargetOffset;

		// Token: 0x04007837 RID: 30775
		internal static int __PropertyOffset_OnAudioFadeChangeEvent;

		// Token: 0x04007838 RID: 30776
		[Nullable(2)]
		private FOnAudioFadeChangeSignature _OnAudioFadeChangeEvent;

		// Token: 0x04007839 RID: 30777
		internal static int __PropertyOffset_CameraLensEffects;

		// Token: 0x0400783A RID: 30778
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<AEmitterCameraLensEffectBase> _CameraLensEffects;

		// Token: 0x0400783B RID: 30779
		internal static int __PropertyOffset_CachedCameraShakeMod;

		// Token: 0x0400783C RID: 30780
		internal static int __PropertyOffset_bOpenCameraShake;

		// Token: 0x0400783D RID: 30781
		internal static int __PropertyOffset_AnimInstPool;

		// Token: 0x0400783E RID: 30782
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TFixedArray<UCameraAnimInst> _AnimInstPool;

		// Token: 0x0400783F RID: 30783
		internal static int __PropertyOffset_PostProcessBlendCache;

		// Token: 0x04007840 RID: 30784
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FPostProcessSettings> _PostProcessBlendCache;

		// Token: 0x04007841 RID: 30785
		internal static int __PropertyOffset_ActiveAnims;

		// Token: 0x04007842 RID: 30786
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UCameraAnimInst> _ActiveAnims;

		// Token: 0x04007843 RID: 30787
		internal static int __PropertyOffset_FreeAnims;

		// Token: 0x04007844 RID: 30788
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UCameraAnimInst> _FreeAnims;

		// Token: 0x04007845 RID: 30789
		internal static int __PropertyOffset_AnimCameraActor;

		// Token: 0x04007846 RID: 30790
		internal static int __PropertyOffset_bIsOrthographic;

		// Token: 0x04007847 RID: 30791
		internal static byte __PropertyMask_bIsOrthographic;

		// Token: 0x04007848 RID: 30792
		internal static int __PropertyOffset_bDefaultConstrainAspectRatio;

		// Token: 0x04007849 RID: 30793
		internal static byte __PropertyMask_bDefaultConstrainAspectRatio;

		// Token: 0x0400784A RID: 30794
		internal static int __PropertyOffset_bEnableFading;

		// Token: 0x0400784B RID: 30795
		internal static byte __PropertyMask_bEnableFading;

		// Token: 0x0400784C RID: 30796
		internal static int __PropertyOffset_bClientSimulatingViewTarget;

		// Token: 0x0400784D RID: 30797
		internal static byte __PropertyMask_bClientSimulatingViewTarget;

		// Token: 0x0400784E RID: 30798
		internal static int __PropertyOffset_bUseClientSideCameraUpdates;

		// Token: 0x0400784F RID: 30799
		internal static byte __PropertyMask_bUseClientSideCameraUpdates;

		// Token: 0x04007850 RID: 30800
		internal static int __PropertyOffset_bGameCameraCutThisFrame;

		// Token: 0x04007851 RID: 30801
		internal static byte __PropertyMask_bGameCameraCutThisFrame;

		// Token: 0x04007852 RID: 30802
		internal static int __PropertyOffset_ViewPitchMin;

		// Token: 0x04007853 RID: 30803
		internal static int __PropertyOffset_ViewPitchMax;

		// Token: 0x04007854 RID: 30804
		internal static int __PropertyOffset_ViewYawMin;

		// Token: 0x04007855 RID: 30805
		internal static int __PropertyOffset_ViewYawMax;

		// Token: 0x04007856 RID: 30806
		internal static int __PropertyOffset_ViewRollMin;

		// Token: 0x04007857 RID: 30807
		internal static int __PropertyOffset_ViewRollMax;

		// Token: 0x04007858 RID: 30808
		internal static int __PropertyOffset_ServerUpdateCameraTimeout;

		// Token: 0x04007859 RID: 30809
		internal static int __PropertyOffset_CameraModifyCustomTimeDilation;

		// Token: 0x02002DD9 RID: 11737
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __PhotographyCameraModify_FunctionParams
		{
			// Token: 0x04016815 RID: 92181
			[FieldOffset(0)]
			public FVector NewCameraLocation;

			// Token: 0x04016816 RID: 92182
			[FieldOffset(12)]
			public FVector PreviousCameraLocation;

			// Token: 0x04016817 RID: 92183
			[FieldOffset(24)]
			public FVector OriginalCameraLocation;

			// Token: 0x04016818 RID: 92184
			[FieldOffset(36)]
			public FVector ResultCameraLocation;
		}

		// Token: 0x02002DDA RID: 11738
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __BlueprintUpdateCamera_FunctionParams
		{
			// Token: 0x04016819 RID: 92185
			[FieldOffset(0)]
			public IntPtr CameraTarget;

			// Token: 0x0401681A RID: 92186
			[FieldOffset(8)]
			public FVector NewCameraLocation;

			// Token: 0x0401681B RID: 92187
			[FieldOffset(20)]
			public FRotator NewCameraRotation;

			// Token: 0x0401681C RID: 92188
			[FieldOffset(32)]
			public float NewCameraFOV;

			// Token: 0x0401681D RID: 92189
			[FieldOffset(36)]
			public bool __Result;
		}
	}
}
